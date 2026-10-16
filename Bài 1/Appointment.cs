using System;

namespace ClinicAppointmentManager
{
    public class Appointment
    {
        public string AppointmentId { get; set; }   // Mã lịch hẹn (Duy nhất)
        public string PatientName { get; set; }     // Họ tên bệnh nhân
        public string PhoneNumber { get; set; }     // Số điện thoại (10 chữ số, bắt đầu bằng 0)
        public DateTime AppointmentTime { get; set; }// Ngày giờ hẹn khám
        public string Doctor { get; set; }          // Bác sĩ phụ trách
        public string Reason { get; set; }          // Lý do khám
        public string Status { get; set; }          // Trạng thái: Chờ khám, Đang khám, Hoàn tất, Đã hủy
    }
}