using System;

namespace LabEquipmentCheckout
{
    public class EquipmentLoan
    {
        public string LoanId { get; set; }          // Mã phiếu (Duy nhất)
        public string StudentId { get; set; }       // Mã sinh viên
        public string StudentName { get; set; }     // Họ tên sinh viên
        public string EquipmentName { get; set; }   // Tên thiết bị
        public int Quantity { get; set; }           // Số lượng (> 0)
        public DateTime LoanDate { get; set; }      // Ngày mượn
        public DateTime DueDate { get; set; }       // Hạn trả (>= Ngày mượn)
        public DateTime? ReturnDate { get; set; }   // Ngày trả thực tế
        public string Status { get; set; }          // Trạng thái: Đang mượn, Đã trả, Quá hạn
    }
}