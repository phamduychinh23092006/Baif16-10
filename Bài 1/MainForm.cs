using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClinicAppointmentManager
{
    public partial class MainForm : Form
    {
        // Chỉ khai báo các biến quản lý dữ liệu cốt lõi ở đây. 
        // Các control giao diện (txt, btn, dgv,...) đã được khai báo tự động trong MainForm.Designer.cs rồi!
        private BindingList<Appointment> appointmentList;
        private BindingSource bindingSource;

        public MainForm()
        {
            InitializeComponent(); // Gọi từ file Designer
            LoadInitialData();
        }

        private void LoadInitialData()
        {
            appointmentList = new BindingList<Appointment>
            {
                new Appointment { AppointmentId = "LH001", PatientName = "Nguyễn Văn An", PhoneNumber = "0912345678", AppointmentTime = DateTime.Now.AddHours(2), Doctor = "BS. Nguyễn Văn A", Reason = "Đau đầu, chóng mặt", Status = "Chờ khám" },
                new Appointment { AppointmentId = "LH002", PatientName = "Trần Thị Bình", PhoneNumber = "0987654321", AppointmentTime = DateTime.Now.AddDays(1), Doctor = "BS. Trần Thị B", Reason = "Khám tổng quát", Status = "Đang khám" }
            };

            bindingSource = new BindingSource { DataSource = appointmentList };
            dgvAppointments.DataSource = bindingSource;
            UpdateStatusCount();
        }

        // Kiểm tra hợp lệ dữ liệu với ErrorProvider
        private bool ValidateData(bool isNew)
        {
            bool isValid = true;
            errorProvider1.Clear();

            // 1. Mã lịch hẹn
            if (string.IsNullOrWhiteSpace(txtAppointmentId.Text))
            {
                errorProvider1.SetError(txtAppointmentId, "Mã lịch hẹn không được để trống!");
                isValid = false;
            }
            else if (isNew && appointmentList.Any(a => a.AppointmentId == txtAppointmentId.Text.Trim()))
            {
                errorProvider1.SetError(txtAppointmentId, "Mã lịch hẹn đã tồn tại!");
                isValid = false;
            }

            // 2. Tên bệnh nhân
            if (string.IsNullOrWhiteSpace(txtPatientName.Text))
            {
                errorProvider1.SetError(txtPatientName, "Tên bệnh nhân không được để trống!");
                isValid = false;
            }

            // 3. Số điện thoại (Đúng 10 chữ số, bắt đầu bằng số 0)
            string phonePattern = @"^0\d{9}$";
            if (!Regex.IsMatch(txtPhone.Text.Trim(), phonePattern))
            {
                errorProvider1.SetError(txtPhone, "Số điện thoại không hợp lệ (phải gồm 10 chữ số, bắt đầu bằng số 0)!");
                isValid = false;
            }

            // 4. Ngày hẹn không được trong quá khứ
            if (dtpAppointmentTime.Value < DateTime.Now)
            {
                errorProvider1.SetError(dtpAppointmentTime, "Ngày giờ hẹn không được nằm trong quá khứ!");
                isValid = false;
            }

            // 5. Lý do khám
            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                errorProvider1.SetError(txtReason, "Lý do khám không được để trống!");
                isValid = false;
            }

            return isValid;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateData(true)) return;

            var newAppt = new Appointment
            {
                AppointmentId = txtAppointmentId.Text.Trim(),
                PatientName = txtPatientName.Text.Trim(),
                PhoneNumber = txtPhone.Text.Trim(),
                AppointmentTime = dtpAppointmentTime.Value,
                Doctor = cbDoctor.SelectedItem.ToString(),
                Reason = txtReason.Text.Trim(),
                Status = cbStatus.SelectedItem.ToString()
            };

            appointmentList.Add(newAppt);
            ApplyFilter();
            ClearForm();
            MessageBox.Show("Thêm lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is not Appointment selectedAppt)
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateData(false)) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn cập nhật lịch hẹn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                selectedAppt.PatientName = txtPatientName.Text.Trim();
                selectedAppt.PhoneNumber = txtPhone.Text.Trim();
                selectedAppt.AppointmentTime = dtpAppointmentTime.Value;
                selectedAppt.Doctor = cbDoctor.SelectedItem.ToString();
                selectedAppt.Reason = txtReason.Text.Trim();
                selectedAppt.Status = cbStatus.SelectedItem.ToString();

                bindingSource.ResetBindings(false);
                ApplyFilter();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is not Appointment selectedAppt)
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa lịch hẹn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                appointmentList.Remove(selectedAppt);
                ApplyFilter();
                ClearForm();
                MessageBox.Show("Xóa lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtAppointmentId.Clear();
            txtPatientName.Clear();
            txtPhone.Clear();
            txtReason.Clear();
            txtAppointmentId.Enabled = true;
            dtpAppointmentTime.Value = DateTime.Now;
            if (cbDoctor.Items.Count > 0) cbDoctor.SelectedIndex = 0;
            if (cbStatus.Items.Count > 0) cbStatus.SelectedIndex = 0;
            errorProvider1.Clear();
            dgvAppointments.ClearSelection();
        }

        private void DgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow != null && bindingSource.Current is Appointment appt)
            {
                txtAppointmentId.Text = appt.AppointmentId;
                txtAppointmentId.Enabled = false; // Khóa mã lịch hẹn khi đang sửa
                txtPatientName.Text = appt.PatientName;
                txtPhone.Text = appt.PhoneNumber;
                dtpAppointmentTime.Value = appt.AppointmentTime;
                cbDoctor.SelectedItem = appt.Doctor;
                txtReason.Text = appt.Reason;
                cbStatus.SelectedItem = appt.Status;
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e) => ApplyFilter();
        private void CbFilterStatus_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilter();
        private void ChkFilterDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpFilterDate.Enabled = chkFilterDate.Checked;
            ApplyFilter();
        }
        private void DtpFilterDate_ValueChanged(object sender, EventArgs e) => ApplyFilter();

        // Tìm kiếm tức thời và lọc theo ngày/trạng thái
        private void ApplyFilter()
        {
            if (appointmentList == null) return;

            string keyword = txtSearch.Text.Trim().ToLower();
            string selectedStatus = cbFilterStatus.SelectedItem?.ToString();
            bool filterDateEnabled = chkFilterDate.Checked;
            DateTime filterDate = dtpFilterDate.Value.Date;

            var filtered = appointmentList.Where(a =>
                (string.IsNullOrEmpty(keyword) || a.PatientName.ToLower().Contains(keyword) || a.PhoneNumber.Contains(keyword)) &&
                (selectedStatus == "Tất cả trạng thái" || a.Status == selectedStatus) &&
                (!filterDateEnabled || a.AppointmentTime.Date == filterDate)
            ).ToList();

            bindingSource.DataSource = new BindingList<Appointment>(filtered);
            UpdateStatusCount();
        }

        private void UpdateStatusCount()
        {
            lblStatusCount.Text = $"Tổng số lịch hẹn hiển thị: {bindingSource?.Count ?? 0}";
        }

        // Xuất danh sách đang hiển thị ra file CSV qua SaveFileDialog
        private void MenuExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV file (*.csv)|*.csv";
                sfd.FileName = "DanhSachLichHen_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine("Mã lịch hẹn,Họ tên bệnh nhân,Số điện thoại,Ngày giờ hẹn,Bác sĩ,Lý do khám,Trạng thái");
                            foreach (var item in bindingSource.List)
                            {
                                if (item is Appointment appt)
                                {
                                    sw.WriteLine($"{appt.AppointmentId},{appt.PatientName},{appt.PhoneNumber},{appt.AppointmentTime:dd/MM/yyyy HH:mm},\"{appt.Doctor}\",\"{appt.Reason}\",{appt.Status}");
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