namespace RepairServiceTracker
{
    partial class RepairMainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalCost = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.wrapperInput = new System.Windows.Forms.TableLayoutPanel();
            this.tInput = new System.Windows.Forms.TableLayoutPanel();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.cbDeviceType = new System.Windows.Forms.ComboBox();
            this.lblIssue = new System.Windows.Forms.Label();
            this.txtIssue = new System.Windows.Forms.RichTextBox();
            this.lblReceiveDate = new System.Windows.Forms.Label();
            this.dtpReceive = new System.Windows.Forms.DateTimePicker();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.pnlImgContainer = new System.Windows.Forms.Panel();
            this.picDevice = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pBtns = new System.Windows.Forms.FlowLayoutPanel();
            this.bAdd = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.tList = new System.Windows.Forms.TableLayoutPanel();
            this.pFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbStatusFilter = new System.Windows.Forms.ComboBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);

            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.wrapperInput.SuspendLayout();
            this.tInput.SuspendLayout();
            this.pnlImgContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDevice)).BeginInit();
            this.pBtns.SuspendLayout();
            this.grpList.SuspendLayout();
            this.tList.SuspendLayout();
            this.pFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // MenuStrip
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuFile });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1250, 24);
            this.menuStrip1.TabIndex = 0;

            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuExport, this.menuExit });
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(69, 20);
            this.menuFile.Text = "Hệ thống";

            this.menuExport.Name = "menuExport";
            this.menuExport.Size = new System.Drawing.Size(130, 22);
            this.menuExport.Text = "Xuất CSV";
            this.menuExport.Click += new System.EventHandler(this.MenuExport_Click);

            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(130, 22);
            this.menuExit.Text = "Thoát";
            this.menuExit.Click += new System.EventHandler((s, e) => Application.Exit());

            // StatusStrip
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblCount, this.lblSeparator, this.lblTotalCost });
            this.statusStrip1.Location = new System.Drawing.Point(0, 728);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1250, 22);
            this.statusStrip1.TabIndex = 1;

            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(115, 17);
            this.lblCount.Text = "Số đơn hiển thị: 0";

            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(10, 17);
            this.lblSeparator.Text = "|";

            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(185, 17);
            this.lblTotalCost.Text = "Tổng chi phí chưa hoàn tất: 0 VNĐ";

            // Main Layout
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.mainLayout.Controls.Add(this.grpInput, 0, 0);
            this.mainLayout.Controls.Add(this.grpList, 1, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(10, 35);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(1230, 683);
            this.mainLayout.TabIndex = 2;

            // grpInput
            this.grpInput.Controls.Add(this.wrapperInput);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInput.Location = new System.Drawing.Point(3, 3);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(510, 677);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Thông tin đơn đăng ký dịch vụ sửa chữa";

            // wrapperInput
            this.wrapperInput.ColumnCount = 1;
            this.wrapperInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.wrapperInput.Controls.Add(this.tInput, 0, 0);
            this.wrapperInput.Controls.Add(this.pBtns, 0, 1);
            this.wrapperInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapperInput.Location = new System.Drawing.Point(3, 16);
            this.wrapperInput.Name = "wrapperInput";
            this.wrapperInput.RowCount = 2;
            this.wrapperInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.wrapperInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.wrapperInput.Size = new System.Drawing.Size(504, 658);
            this.wrapperInput.TabIndex = 0;

            // tInput
            this.tInput.ColumnCount = 2;
            this.tInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tInput.Controls.Add(this.lblOrderId, 0, 0);
            this.tInput.Controls.Add(this.txtOrderId, 1, 0);
            this.tInput.Controls.Add(this.lblCustomerName, 0, 1);
            this.tInput.Controls.Add(this.txtCustomerName, 1, 1);
            this.tInput.Controls.Add(this.lblPhone, 0, 2);
            this.tInput.Controls.Add(this.txtPhone, 1, 2);
            this.tInput.Controls.Add(this.lblDeviceType, 0, 3);
            this.tInput.Controls.Add(this.cbDeviceType, 1, 3);
            this.tInput.Controls.Add(this.lblIssue, 0, 4);
            this.tInput.Controls.Add(this.txtIssue, 1, 4);
            this.tInput.Controls.Add(this.lblReceiveDate, 0, 5);
            this.tInput.Controls.Add(this.dtpReceive, 1, 5);
            this.tInput.Controls.Add(this.lblCost, 0, 6);
            this.tInput.Controls.Add(this.txtCost, 1, 6);
            this.tInput.Controls.Add(this.lblStatus, 0, 7);
            this.tInput.Controls.Add(this.cbStatus, 1, 7);
            this.tInput.Controls.Add(this.lblImage, 0, 8);
            this.tInput.Controls.Add(this.pnlImgContainer, 1, 8);
            this.tInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tInput.Location = new System.Drawing.Point(3, 3);
            this.tInput.Name = "tInput";
            this.tInput.RowCount = 9;
            this.tInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tInput.Size = new System.Drawing.Size(498, 586);
            this.tInput.TabIndex = 0;

            this.lblOrderId.Text = "Mã đơn:"; this.lblOrderId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOrderId.Dock = System.Windows.Forms.DockStyle.Fill;

            this.lblCustomerName.Text = "Tên khách hàng:"; this.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;

            this.lblPhone.Text = "Số điện thoại:"; this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Fill;

            this.lblDeviceType.Text = "Loại thiết bị:"; this.lblDeviceType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDeviceType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeviceType.Items.AddRange(new object[] { "Laptop", "Điện thoại", "Máy tính bảng", "Màn hình" });

            this.lblIssue.Text = "Mô tả lỗi:"; this.lblIssue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIssue.Dock = System.Windows.Forms.DockStyle.Fill;

            this.lblReceiveDate.Text = "Ngày tiếp nhận:"; this.lblReceiveDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpReceive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpReceive.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.lblCost.Text = "Chi phí dự kiến:"; this.lblCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCost.Text = "0";

            this.lblStatus.Text = "Trạng thái:"; this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Items.AddRange(new object[] { "Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy" });

            this.lblImage.Text = "Ảnh thiết bị:"; this.lblImage.Anchor = System.Windows.Forms.AnchorStyles.Left;

            // pnlImgContainer
            this.pnlImgContainer.Controls.Add(this.picDevice);
            this.pnlImgContainer.Controls.Add(this.btnBrowse);
            this.pnlImgContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImgContainer.Location = new System.Drawing.Point(177, 308);
            this.pnlImgContainer.Name = "pnlImgContainer";
            this.pnlImgContainer.Size = new System.Drawing.Size(318, 275);
            this.pnlImgContainer.TabIndex = 16;

            this.picDevice.Location = new System.Drawing.Point(0, 0);
            this.picDevice.Name = "picDevice";
            this.picDevice.Size = new System.Drawing.Size(100, 80);
            this.picDevice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDevice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnBrowse.Location = new System.Drawing.Point(110, 25);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 30);
            this.btnBrowse.Text = "Chọn ảnh";
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);

            // pBtns
            this.pBtns.Controls.Add(this.bAdd);
            this.pBtns.Controls.Add(this.bUpdate);
            this.pBtns.Controls.Add(this.bDel);
            this.pBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBtns.Location = new System.Drawing.Point(3, 595);
            this.pBtns.Name = "pBtns";
            this.pBtns.Size = new System.Drawing.Size(498, 60);
            this.pBtns.TabIndex = 1;

            this.bAdd.Text = "Thêm"; this.bAdd.Width = 70; this.bAdd.Height = 30; this.bAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            this.bUpdate.Text = "Cập nhật"; this.bUpdate.Width = 75; this.bUpdate.Height = 30; this.bUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            this.bDel.Text = "Xóa"; this.bDel.Width = 60; this.bDel.Height = 30; this.bDel.Click += new System.EventHandler(this.BtnDelete_Click);

            // grpList
            this.grpList.Controls.Add(this.tList);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.Location = new System.Drawing.Point(519, 3);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(708, 677);
            this.grpList.TabIndex = 1;
            this.grpList.TabStop = false;
            this.grpList.Text = "Danh sách đơn đăng ký dịch vụ sửa chữa";

            // tList
            this.tList.ColumnCount = 1;
            this.tList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tList.Controls.Add(this.pFilter, 0, 0);
            this.tList.Controls.Add(this.dgvOrders, 0, 1);
            this.tList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tList.Location = new System.Drawing.Point(3, 16);
            this.tList.Name = "tList";
            this.tList.RowCount = 2;
            this.tList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tList.Size = new System.Drawing.Size(702, 658);
            this.tList.TabIndex = 0;

            // pFilter
            this.pFilter.Controls.Add(this.lblSearch);
            this.pFilter.Controls.Add(this.txtSearch);
            this.pFilter.Controls.Add(this.cbStatusFilter);
            this.pFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFilter.Location = new System.Drawing.Point(3, 3);
            this.pFilter.Name = "pFilter";
            this.pFilter.Size = new System.Drawing.Size(696, 44);
            this.pFilter.TabIndex = 0;

            this.lblSearch.Text = "Tìm:"; this.lblSearch.AutoSize = true; this.lblSearch.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.txtSearch.Width = 150; this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);

            this.cbStatusFilter.Width = 140; this.cbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusFilter.Items.AddRange(new object[] { "Tất cả trạng thái", "Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy" });
            this.cbStatusFilter.SelectedIndex = 0; this.cbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.CbStatusFilter_SelectedIndexChanged);

            // dgvOrders
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(3, 53);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(696, 602);
            this.dgvOrders.TabIndex = 1;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.DgvOrders_SelectionChanged);

            // errorProvider1
            this.errorProvider1.ContainerControl = this;

            // RepairMainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 750);
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RepairMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repair Service Tracker - Quản lý đơn dịch vụ sửa chữa";

            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.wrapperInput.ResumeLayout(false);
            this.tInput.ResumeLayout(false);
            this.tInput.PerformLayout();
            this.pnlImgContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDevice)).EndInit();
            this.pBtns.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            this.tList.ResumeLayout(false);
            this.pFilter.ResumeLayout(false);
            this.pFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExport;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private System.Windows.Forms.ToolStripStatusLabel lblSeparator;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalCost;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TableLayoutPanel wrapperInput;
        private System.Windows.Forms.TableLayoutPanel tInput;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.ComboBox cbDeviceType;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.RichTextBox txtIssue;
        private System.Windows.Forms.Label lblReceiveDate;
        private System.Windows.Forms.DateTimePicker dtpReceive;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Panel pnlImgContainer;
        private System.Windows.Forms.PictureBox picDevice;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.FlowLayoutPanel pBtns;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.TableLayoutPanel tList;
        private System.Windows.Forms.FlowLayoutPanel pFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbStatusFilter;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}