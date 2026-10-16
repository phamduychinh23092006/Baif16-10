namespace ClinicAppointmentManager
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            tableLayoutMain = new TableLayoutPanel();
            grpInput = new GroupBox();
            tableInput = new TableLayoutPanel();
            lblId = new Label();
            txtAppointmentId = new TextBox();
            lblName = new Label();
            txtPatientName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblTime = new Label();
            dtpAppointmentTime = new DateTimePicker();
            lblDoctor = new Label();
            cbDoctor = new ComboBox();
            lblReason = new Label();
            txtReason = new TextBox();
            lblStatus = new Label();
            cbStatus = new ComboBox();
            panelButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            grpList = new GroupBox();
            tableListLayout = new TableLayoutPanel();
            panelFilter = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            cbFilterStatus = new ComboBox();
            chkFilterDate = new CheckBox();
            dtpFilterDate = new DateTimePicker();
            dgvAppointments = new DataGridView();
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuExport = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblStatusCount = new ToolStripStatusLabel();
            errorProvider1 = new ErrorProvider(components);
            tableLayoutMain.SuspendLayout();
            grpInput.SuspendLayout();
            tableInput.SuspendLayout();
            panelButtons.SuspendLayout();
            grpList.SuspendLayout();
            tableListLayout.SuspendLayout();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 2;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutMain.Controls.Add(grpInput, 0, 0);
            tableLayoutMain.Controls.Add(grpList, 1, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 30);
            tableLayoutMain.Margin = new Padding(4, 5, 4, 5);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 1;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.Size = new Size(1533, 999);
            tableLayoutMain.TabIndex = 2;
            // 
            // grpInput
            // 
            grpInput.Controls.Add(tableInput);
            grpInput.Dock = DockStyle.Fill;
            grpInput.Location = new Point(4, 5);
            grpInput.Margin = new Padding(4, 5, 4, 5);
            grpInput.Name = "grpInput";
            grpInput.Padding = new Padding(4, 5, 4, 5);
            grpInput.Size = new Size(605, 989);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin chi tiết lịch hẹn";
            // 
            // tableInput
            // 
            tableInput.ColumnCount = 2;
            tableInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableInput.Controls.Add(lblId, 0, 0);
            tableInput.Controls.Add(txtAppointmentId, 1, 0);
            tableInput.Controls.Add(lblName, 0, 1);
            tableInput.Controls.Add(txtPatientName, 1, 1);
            tableInput.Controls.Add(lblPhone, 0, 2);
            tableInput.Controls.Add(txtPhone, 1, 2);
            tableInput.Controls.Add(lblTime, 0, 3);
            tableInput.Controls.Add(dtpAppointmentTime, 1, 3);
            tableInput.Controls.Add(lblDoctor, 0, 4);
            tableInput.Controls.Add(cbDoctor, 1, 4);
            tableInput.Controls.Add(lblReason, 0, 5);
            tableInput.Controls.Add(txtReason, 1, 5);
            tableInput.Controls.Add(lblStatus, 0, 6);
            tableInput.Controls.Add(cbStatus, 1, 6);
            tableInput.Controls.Add(panelButtons, 1, 7);
            tableInput.Dock = DockStyle.Fill;
            tableInput.Location = new Point(4, 25);
            tableInput.Margin = new Padding(4, 5, 4, 5);
            tableInput.Name = "tableInput";
            tableInput.RowCount = 8;
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 108F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableInput.Size = new Size(597, 959);
            tableInput.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Left;
            lblId.Location = new Point(4, 13);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(133, 35);
            lblId.TabIndex = 0;
            lblId.Text = "Mã lịch hẹn:";
            // 
            // txtAppointmentId
            // 
            txtAppointmentId.Dock = DockStyle.Fill;
            txtAppointmentId.Location = new Point(212, 5);
            txtAppointmentId.Margin = new Padding(4, 5, 4, 5);
            txtAppointmentId.Name = "txtAppointmentId";
            txtAppointmentId.Size = new Size(381, 27);
            txtAppointmentId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left;
            lblName.Location = new Point(4, 75);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(133, 35);
            lblName.TabIndex = 2;
            lblName.Text = "Họ tên bệnh nhân:";
            // 
            // txtPatientName
            // 
            txtPatientName.Dock = DockStyle.Fill;
            txtPatientName.Location = new Point(212, 67);
            txtPatientName.Margin = new Padding(4, 5, 4, 5);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(381, 27);
            txtPatientName.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Left;
            lblPhone.Location = new Point(4, 137);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(133, 35);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(212, 129);
            txtPhone.Margin = new Padding(4, 5, 4, 5);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(381, 27);
            txtPhone.TabIndex = 5;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Left;
            lblTime.Location = new Point(4, 199);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(133, 35);
            lblTime.TabIndex = 6;
            lblTime.Text = "Ngày giờ hẹn:";
            // 
            // dtpAppointmentTime
            // 
            dtpAppointmentTime.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpAppointmentTime.Dock = DockStyle.Fill;
            dtpAppointmentTime.Format = DateTimePickerFormat.Custom;
            dtpAppointmentTime.Location = new Point(212, 191);
            dtpAppointmentTime.Margin = new Padding(4, 5, 4, 5);
            dtpAppointmentTime.Name = "dtpAppointmentTime";
            dtpAppointmentTime.Size = new Size(381, 27);
            dtpAppointmentTime.TabIndex = 7;
            // 
            // lblDoctor
            // 
            lblDoctor.Anchor = AnchorStyles.Left;
            lblDoctor.Location = new Point(4, 261);
            lblDoctor.Margin = new Padding(4, 0, 4, 0);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(133, 35);
            lblDoctor.TabIndex = 8;
            lblDoctor.Text = "Bác sĩ phụ trách:";
            // 
            // cbDoctor
            // 
            cbDoctor.Dock = DockStyle.Fill;
            cbDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDoctor.Items.AddRange(new object[] { "BS. Nguyễn Văn A", "BS. Trần Thị B", "BS. Lê Văn C", "BS. Phạm Thị D" });
            cbDoctor.Location = new Point(212, 253);
            cbDoctor.Margin = new Padding(4, 5, 4, 5);
            cbDoctor.Name = "cbDoctor";
            cbDoctor.Size = new Size(381, 28);
            cbDoctor.TabIndex = 9;
            // 
            // lblReason
            // 
            lblReason.Anchor = AnchorStyles.Left;
            lblReason.Location = new Point(4, 346);
            lblReason.Margin = new Padding(4, 0, 4, 0);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(133, 35);
            lblReason.TabIndex = 10;
            lblReason.Text = "Lý do khám:";
            // 
            // txtReason
            // 
            txtReason.Dock = DockStyle.Fill;
            txtReason.Location = new Point(212, 315);
            txtReason.Margin = new Padding(4, 5, 4, 5);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(381, 98);
            txtReason.TabIndex = 11;
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Left;
            lblStatus.Location = new Point(4, 431);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(133, 35);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Trạng thái:";
            // 
            // cbStatus
            // 
            cbStatus.Dock = DockStyle.Fill;
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Items.AddRange(new object[] { "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            cbStatus.Location = new Point(212, 423);
            cbStatus.Margin = new Padding(4, 5, 4, 5);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(381, 28);
            cbStatus.TabIndex = 13;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Controls.Add(btnUpdate);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Controls.Add(btnClear);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(212, 485);
            panelButtons.Margin = new Padding(4, 5, 4, 5);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(381, 469);
            panelButtons.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(4, 5);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(91, 46);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(103, 5);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 46);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(211, 5);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 46);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(4, 61);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(91, 46);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm mới";
            btnClear.Click += BtnClear_Click;
            // 
            // grpList
            // 
            grpList.Controls.Add(tableListLayout);
            grpList.Dock = DockStyle.Fill;
            grpList.Location = new Point(617, 5);
            grpList.Margin = new Padding(4, 5, 4, 5);
            grpList.Name = "grpList";
            grpList.Padding = new Padding(4, 5, 4, 5);
            grpList.Size = new Size(912, 989);
            grpList.TabIndex = 1;
            grpList.TabStop = false;
            grpList.Text = "Danh sách lịch hẹn";
            // 
            // tableListLayout
            // 
            tableListLayout.ColumnCount = 1;
            tableListLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableListLayout.Controls.Add(panelFilter, 0, 0);
            tableListLayout.Controls.Add(dgvAppointments, 0, 1);
            tableListLayout.Dock = DockStyle.Fill;
            tableListLayout.Location = new Point(4, 25);
            tableListLayout.Margin = new Padding(4, 5, 4, 5);
            tableListLayout.Name = "tableListLayout";
            tableListLayout.RowCount = 2;
            tableListLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableListLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableListLayout.Size = new Size(904, 959);
            tableListLayout.TabIndex = 0;
            // 
            // panelFilter
            // 
            panelFilter.Controls.Add(lblSearch);
            panelFilter.Controls.Add(txtSearch);
            panelFilter.Controls.Add(cbFilterStatus);
            panelFilter.Controls.Add(chkFilterDate);
            panelFilter.Controls.Add(dtpFilterDate);
            panelFilter.Dock = DockStyle.Fill;
            panelFilter.Location = new Point(4, 5);
            panelFilter.Margin = new Padding(4, 5, 4, 5);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(896, 67);
            panelFilter.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(4, 0);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Padding = new Padding(0, 8, 0, 0);
            lblSearch.Size = new Size(37, 28);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(49, 5);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(185, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // cbFilterStatus
            // 
            cbFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterStatus.Items.AddRange(new object[] { "Tất cả trạng thái", "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            cbFilterStatus.Location = new Point(242, 5);
            cbFilterStatus.Margin = new Padding(4, 5, 4, 5);
            cbFilterStatus.Name = "cbFilterStatus";
            cbFilterStatus.Size = new Size(152, 28);
            cbFilterStatus.TabIndex = 2;
            cbFilterStatus.SelectedIndexChanged += CbFilterStatus_SelectedIndexChanged;
            // 
            // chkFilterDate
            // 
            chkFilterDate.AutoSize = true;
            chkFilterDate.Location = new Point(402, 5);
            chkFilterDate.Margin = new Padding(4, 5, 4, 5);
            chkFilterDate.Name = "chkFilterDate";
            chkFilterDate.Padding = new Padding(0, 8, 0, 0);
            chkFilterDate.Size = new Size(93, 32);
            chkFilterDate.TabIndex = 3;
            chkFilterDate.Text = "Lọc ngày:";
            chkFilterDate.CheckedChanged += ChkFilterDate_CheckedChanged;
            // 
            // dtpFilterDate
            // 
            dtpFilterDate.Enabled = false;
            dtpFilterDate.Format = DateTimePickerFormat.Short;
            dtpFilterDate.Location = new Point(503, 5);
            dtpFilterDate.Margin = new Padding(4, 5, 4, 5);
            dtpFilterDate.Name = "dtpFilterDate";
            dtpFilterDate.Size = new Size(139, 27);
            dtpFilterDate.TabIndex = 4;
            dtpFilterDate.ValueChanged += DtpFilterDate_ValueChanged;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Dock = DockStyle.Fill;
            dgvAppointments.Location = new Point(4, 82);
            dgvAppointments.Margin = new Padding(4, 5, 4, 5);
            dgvAppointments.MultiSelect = false;
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(896, 872);
            dgvAppointments.TabIndex = 1;
            dgvAppointments.SelectionChanged += DgvAppointments_SelectionChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1533, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuExport });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(85, 24);
            menuFile.Text = "Hệ thống";
            // 
            // menuExport
            // 
            menuExport.Name = "menuExport";
            menuExport.Size = new Size(239, 26);
            menuExport.Text = "Xuất danh sách ra CSV";
            menuExport.Click += MenuExport_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusCount });
            statusStrip1.Location = new Point(0, 1029);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 19, 0);
            statusStrip1.Size = new Size(1533, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusCount
            // 
            lblStatusCount.Name = "lblStatusCount";
            lblStatusCount.Size = new Size(185, 20);
            lblStatusCount.Text = "Tổng số lịch hẹn hiển thị: 0";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1533, 1055);
            Controls.Add(tableLayoutMain);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinic Appointment Manager - Quản lý lịch hẹn phòng khám";
            tableLayoutMain.ResumeLayout(false);
            grpInput.ResumeLayout(false);
            tableInput.ResumeLayout(false);
            tableInput.PerformLayout();
            panelButtons.ResumeLayout(false);
            grpList.ResumeLayout(false);
            tableListLayout.ResumeLayout(false);
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TableLayoutPanel tableInput;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtAppointmentId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpAppointmentTime;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.TableLayoutPanel tableListLayout;
        private System.Windows.Forms.FlowLayoutPanel panelFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbFilterStatus;
        private System.Windows.Forms.CheckBox chkFilterDate;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExport;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusCount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}