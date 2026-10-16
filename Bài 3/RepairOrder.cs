using System;

namespace RepairServiceTracker
{
    public class RepairOrder
    {
        public string OrderId { get; set; }         // Mã đơn (Duy nhất)
        public string CustomerName { get; set; }    // Tên khách hàng
        public string PhoneNumber { get; set; }     // Số điện thoại
        public string DeviceType { get; set; }      // Loại thiết bị
        public string IssueDescription { get; set; }// Mô tả lỗi (Bắt buộc)
        public DateTime ReceiveDate { get; set; }   // Ngày tiếp nhận
        public decimal EstimatedCost { get; set; }  // Chi phí dự kiến (>= 0)
        public string Status { get; set; }          // Trạng thái: Mới tiếp nhận, Đang sửa, Chờ linh kiện, Hoàn tất, Đã hủy
        public string ImagePath { get; set; }       // Đường dẫn ảnh thiết bị
    }
}