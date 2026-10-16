using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LabEquipmentCheckout
{
    public partial class LabMainForm : Form
    {
        private BindingList<EquipmentLoan> loanList;
        private BindingSource bindingSource;

        public LabMainForm()
        {
            InitializeComponent();
            SetupDataGridViewColumns();
            LoadInitialData();
        }

        private void SetupDataGridViewColumns()
        {
            dgvLoans.Columns.Clear();
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LoanId", HeaderText = "Mã phiếu", Width = 75 });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentId", HeaderText = "Mã SV", Width = 85 });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentName", HeaderText = "Họ tên SV", Width = 130 });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EquipmentName", HeaderText = "Thiết bị", Width = 150 });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "SL", Width = 50 });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LoanDate", HeaderText = "Ngày mượn", Width = 95, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DueDate", HeaderText = "Hạn trả", Width = 95, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });
            dgvLoans.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Status", HeaderText = "Trạng thái", Width = 95 });
        }

        private void LoadInitialData()
        {
            loanList = new BindingList<EquipmentLoan>
            {
                new EquipmentLoan { LoanId = "PM001", StudentId = "B21DCCN01", StudentName = "Lê Văn Hoàng", EquipmentName = "Bộ nguồn DC", Quantity = 1, LoanDate = DateTime.Now.AddDays(-5), DueDate = DateTime.Now.AddDays(-2), Status = "Quá hạn" },
                new EquipmentLoan { LoanId = "PM002", StudentId = "B21DCCN02", StudentName = "Nguyễn Thị Mai", EquipmentName = "Máy đo dao động (Oscilloscope)", Quantity = 1, LoanDate = DateTime.Now.AddDays(-1), DueDate = DateTime.Now.AddDays(3), Status = "Đang mượn" }
            };

            bindingSource = new BindingSource { DataSource = loanList };
            dgvLoans.DataSource = bindingSource;
            UpdateStatus();
        }

        private void CheckOverdueStatus()
        {
            foreach (var item in loanList)
            {
                if (item.Status != "Đã trả" && item.DueDate.Date < DateTime.Now.Date)
                {
                    item.Status = "Quá hạn";
                }
            }
        }

        private bool ValidateInput(bool isNew)
        {
            errorProvider1.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtLoanId.Text))
            {
                errorProvider1.SetError(txtLoanId, "Mã phiếu không được để trống!");
                isValid = false;
            }
            else if (isNew && loanList.Any(x => x.LoanId == txtLoanId.Text.Trim()))
            {
                errorProvider1.SetError(txtLoanId, "Mã phiếu đã tồn tại!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtStudentId.Text))
            {
                errorProvider1.SetError(txtStudentId, "Mã sinh viên không được để trống!");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                errorProvider1.SetError(txtStudentName, "Họ tên sinh viên không được để trống!");
                isValid = false;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out int q) || q <= 0)
            {
                errorProvider1.SetError(txtQuantity, "Số lượng phải là số nguyên lớn hơn 0!");
                isValid = false;
            }

            if (dtpDueDate.Value.Date < dtpLoanDate.Value.Date)
            {
                errorProvider1.SetError(dtpDueDate, "Hạn trả không được trước ngày mượn!");
                isValid = false;
            }

            return isValid;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(true)) return;

            CheckOverdueStatus();
            string status = dtpDueDate.Value.Date < DateTime.Now.Date ? "Quá hạn" : "Đang mượn";

            var newLoan = new EquipmentLoan
            {
                LoanId = txtLoanId.Text.Trim(),
                StudentId = txtStudentId.Text.Trim(),
                StudentName = txtStudentName.Text.Trim(),
                EquipmentName = cbEquipment.SelectedItem.ToString(),
                Quantity = int.Parse(txtQuantity.Text.Trim()),
                LoanDate = dtpLoanDate.Value,
                DueDate = dtpDueDate.Value,
                Status = status
            };

            loanList.Add(newLoan);
            ApplyFilter();
            ClearForm();
            MessageBox.Show("Thêm phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is not EquipmentLoan selectedLoan)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(false)) return;

            if (MessageBox.Show("Xác nhận cập nhật phiếu mượn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                selectedLoan.StudentId = txtStudentId.Text.Trim();
                selectedLoan.StudentName = txtStudentName.Text.Trim();
                selectedLoan.EquipmentName = cbEquipment.SelectedItem.ToString();
                selectedLoan.Quantity = int.Parse(txtQuantity.Text.Trim());
                selectedLoan.LoanDate = dtpLoanDate.Value;
                selectedLoan.DueDate = dtpDueDate.Value;

                if (selectedLoan.Status != "Đã trả")
                {
                    selectedLoan.Status = selectedLoan.DueDate.Date < DateTime.Now.Date ? "Quá hạn" : "Đang mượn";
                }

                bindingSource.ResetBindings(false);
                ApplyFilter();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is not EquipmentLoan selectedLoan)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần đánh dấu đã trả!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Xác nhận đánh dấu thiết bị đã được trả?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                selectedLoan.Status = "Đã trả";
                selectedLoan.ReturnDate = DateTime.Now;

                bindingSource.ResetBindings(false);
                ApplyFilter();
                MessageBox.Show("Đã cập nhật trạng thái thiết bị thành Đã trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is not EquipmentLoan selectedLoan)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu mượn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                loanList.Remove(selectedLoan);
                ApplyFilter();
                ClearForm();
                MessageBox.Show("Xóa phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearForm()
        {
            txtLoanId.Clear();
            txtStudentId.Clear();
            txtStudentName.Clear();
            txtQuantity.Text = "1";
            txtLoanId.Enabled = true;
            dtpLoanDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now;
            if (cbEquipment.Items.Count > 0) cbEquipment.SelectedIndex = 0;
            errorProvider1.Clear();
            dgvLoans.ClearSelection();
        }

        private void DgvLoans_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoans.CurrentRow != null && bindingSource.Current is EquipmentLoan l)
            {
                txtLoanId.Text = l.LoanId;
                txtLoanId.Enabled = false; // Khóa mã phiếu khi sửa
                txtStudentId.Text = l.StudentId;
                txtStudentName.Text = l.StudentName;
                cbEquipment.SelectedItem = l.EquipmentName;
                txtQuantity.Text = l.Quantity.ToString();
                dtpLoanDate.Value = l.LoanDate;
                dtpDueDate.Value = l.DueDate;
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e) => ApplyFilter();
        private void CbStatusFilter_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilter();

        private void ApplyFilter()
        {
            CheckOverdueStatus();
            string keyword = txtSearch.Text.Trim().ToLower();
            string selectedStatus = cbStatusFilter.SelectedItem?.ToString();

            var filtered = loanList.Where(x =>
                (string.IsNullOrEmpty(keyword) || x.StudentId.ToLower().Contains(keyword) || x.EquipmentName.ToLower().Contains(keyword) || x.StudentName.ToLower().Contains(keyword)) &&
                (selectedStatus == "Tất cả trạng thái" || x.Status == selectedStatus)
            ).ToList();

            bindingSource.DataSource = new BindingList<EquipmentLoan>(filtered);
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            int overdueCount = loanList.Count(x => x.Status == "Quá hạn");
            lblTotal.Text = $"Tổng phiếu hiển thị: {bindingSource?.Count ?? 0}";
            lblOverdue.Text = $"Quá hạn: {overdueCount}";
        }

        private void MenuExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV file (*.csv)|*.csv";
                sfd.FileName = "DanhSachPhieuMuon_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine("Mã phiếu,Mã SV,Họ tên,Thiết bị,Số lượng,Ngày mượn,Hạn trả,Ngày trả thực tế,Trạng thái");
                            foreach (var item in bindingSource.List)
                            {
                                if (item is EquipmentLoan i)
                                {
                                    string retDate = i.ReturnDate.HasValue ? i.ReturnDate.Value.ToString("dd/MM/yyyy HH:mm") : "";
                                    sw.WriteLine($"{i.LoanId},{i.StudentId},{i.StudentName},\"{i.EquipmentName}\",{i.Quantity},{i.LoanDate:dd/MM/yyyy},{i.DueDate:dd/MM/yyyy},{retDate},{i.Status}");
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