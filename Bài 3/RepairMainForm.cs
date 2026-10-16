using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RepairServiceTracker
{
    public partial class RepairMainForm : Form
    {
        private BindingList<RepairOrder> orderList;
        private BindingSource bindingSource;
        private string currentImagePath = "";

        public RepairMainForm()
        {
            InitializeComponent();
            SetupDataGridViewColumns();
            LoadInitialData();
        }

        private void SetupDataGridViewColumns()
        {
            dgvOrders.Columns.Clear();
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "OrderId", HeaderText = "Mã đơn", Width = 70 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CustomerName", HeaderText = "Khách hàng", Width = 115 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PhoneNumber", HeaderText = "SĐT", Width = 95 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DeviceType", HeaderText = "Thiết bị", Width = 90 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IssueDescription", HeaderText = "Mô tả lỗi", Width = 115 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EstimatedCost", HeaderText = "Chi phí dự kiến", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Trạng thái", Width = 95 });
        }

        private void LoadInitialData()
        {
            orderList = new BindingList<RepairOrder>
            {
                new RepairOrder { OrderId = "RE001", CustomerName = "Phạm Văn Nam", PhoneNumber = "0988123456", DeviceType = "Laptop", IssueDescription = "Hỏng nguồn, không lên hình", ReceiveDate = DateTime.Now, EstimatedCost = 500000, Status = "Đang sửa", ImagePath = "" }
            };

            bindingSource = new BindingSource { DataSource = orderList };
            dgvOrders.DataSource = bindingSource;
            UpdateStatus();
        }

        private bool ValidateInput(bool isNew)
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtOrderId.Text))
            {
                errorProvider1.SetError(txtOrderId, "Mã đơn không được để trống!");
                isValid = false;
            }
            else if (isNew && orderList.Any(x => x.OrderId == txtOrderId.Text.Trim()))
            {
                errorProvider1.SetError(txtOrderId, "Mã đơn đã tồn tại!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                errorProvider1.SetError(txtCustomerName, "Tên khách hàng không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtIssue.Text))
            {
                errorProvider1.SetError(txtIssue, "Mô tả lỗi bắt buộc phải nhập!");
                isValid = false;
            }

            if (!decimal.TryParse(txtCost.Text.Trim(), out decimal cost) || cost < 0)
            {
                errorProvider1.SetError(txtCost, "Chi phí dự kiến phải là số không âm (>= 0)!");
                isValid = false;
            }

            return isValid;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentImagePath = ofd.FileName;
                    try
                    {
                        picDevice.Image = Image.FromFile(currentImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(true)) return;

            var newOrder = new RepairOrder
            {
                OrderId = txtOrderId.Text.Trim(),
                CustomerName = txtCustomerName.Text.Trim(),
                PhoneNumber = txtPhone.Text.Trim(),
                DeviceType = cbDeviceType.SelectedItem.ToString(),
                IssueDescription = txtIssue.Text.Trim(),
                ReceiveDate = dtpReceive.Value,
                EstimatedCost = decimal.Parse(txtCost.Text.Trim()),
                Status = cbStatus.SelectedItem.ToString(),
                ImagePath = currentImagePath
            };

            orderList.Add(newOrder);
            ApplyFilter();
            ClearForm();
            MessageBox.Show("Thêm đơn dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is not RepairOrder selectedOrder)
            {
                MessageBox.Show("Vui lòng chọn đơn cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(false)) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn cập nhật đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                selectedOrder.CustomerName = txtCustomerName.Text.Trim();
                selectedOrder.PhoneNumber = txtPhone.Text.Trim();
                selectedOrder.DeviceType = cbDeviceType.SelectedItem.ToString();
                selectedOrder.IssueDescription = txtIssue.Text.Trim();
                selectedOrder.ReceiveDate = dtpReceive.Value;
                selectedOrder.EstimatedCost = decimal.Parse(txtCost.Text.Trim());
                selectedOrder.Status = cbStatus.SelectedItem.ToString();
                selectedOrder.ImagePath = currentImagePath;

                bindingSource.ResetBindings(false);
                ApplyFilter();
                MessageBox.Show("Cập nhật đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is not RepairOrder selectedOrder)
            {
                MessageBox.Show("Vui lòng chọn đơn cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                orderList.Remove(selectedOrder);
                ApplyFilter();
                ClearForm();
                MessageBox.Show("Xóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearForm()
        {
            txtOrderId.Clear();
            txtCustomerName.Clear();
            txtPhone.Clear();
            txtIssue.Clear();
            txtCost.Text = "0";
            txtOrderId.Enabled = true;
            currentImagePath = "";
            picDevice.Image = null;
            dtpReceive.Value = DateTime.Now;
            if (cbDeviceType.Items.Count > 0) cbDeviceType.SelectedIndex = 0;
            if (cbStatus.Items.Count > 0) cbStatus.SelectedIndex = 0;
            errorProvider1.Clear();
            dgvOrders.ClearSelection();
        }

        private void DgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow != null && bindingSource.Current is RepairOrder o)
            {
                txtOrderId.Text = o.OrderId;
                txtOrderId.Enabled = false; // Khóa mã đơn khi sửa
                txtCustomerName.Text = o.CustomerName;
                txtPhone.Text = o.PhoneNumber;
                cbDeviceType.SelectedItem = o.DeviceType;
                txtIssue.Text = o.IssueDescription;
                dtpReceive.Value = o.ReceiveDate;
                txtCost.Text = o.EstimatedCost.ToString();
                cbStatus.SelectedItem = o.Status;

                currentImagePath = o.ImagePath ?? "";
                if (!string.IsNullOrEmpty(currentImagePath) && File.Exists(currentImagePath))
                {
                    try
                    {
                        picDevice.Image = Image.FromFile(currentImagePath);
                    }
                    catch
                    {
                        picDevice.Image = null;
                    }
                }
                else
                {
                    picDevice.Image = null;
                }
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e) => ApplyFilter();
        private void CbStatusFilter_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilter();

        private void ApplyFilter()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string selectedStatus = cbStatusFilter.SelectedItem?.ToString();

            var filtered = orderList.Where(x =>
                (string.IsNullOrEmpty(keyword) || x.OrderId.ToLower().Contains(keyword) || x.CustomerName.ToLower().Contains(keyword) || x.PhoneNumber.Contains(keyword)) &&
                (selectedStatus == "Tất cả trạng thái" || x.Status == selectedStatus)
            ).ToList();

            bindingSource.DataSource = new BindingList<RepairOrder>(filtered);
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            // Tính tổng chi phí dự kiến của các đơn CHƯA HOÀN TẤT và CHƯA ĐÃ HỦY
            decimal totalPendingCost = orderList
                .Where(x => x.Status != "Hoàn tất" && x.Status != "Đã hủy")
                .Sum(x => x.EstimatedCost);

            lblCount.Text = $"Số đơn hiển thị: {bindingSource?.Count ?? 0}";
            lblTotalCost.Text = $"Tổng chi phí đơn chưa hoàn tất: {totalPendingCost:N0} VNĐ";
        }

        private void MenuExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV file (*.csv)|*.csv";
                sfd.FileName = "DonSuaChua_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine("Mã đơn,Tên khách hàng,SĐT,Loại thiết bị,Mô tả lỗi,Ngày tiếp nhận,Chi phí dự kiến,Trạng thái");
                            foreach (var item in bindingSource.List)
                            {
                                if (item is RepairOrder i)
                                {
                                    sw.WriteLine($"{i.OrderId},{i.CustomerName},{i.PhoneNumber},{i.DeviceType},\"{i.IssueDescription}\",{i.ReceiveDate:dd/MM/yyyy},{i.EstimatedCost},{i.Status}");
                                }
                            }
                        }
                        MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}