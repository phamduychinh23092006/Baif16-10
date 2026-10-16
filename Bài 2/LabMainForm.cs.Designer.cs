namespace LabEquipmentCheckout
{
    partial class LabMainForm
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
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuExport = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTotal = new ToolStripStatusLabel();
            lblSeparator = new ToolStripStatusLabel();
            lblOverdue = new ToolStripStatusLabel();
            mainLayout = new TableLayoutPanel();
            grpInput = new GroupBox();
            tInput = new TableLayoutPanel();
            lblLoanId = new Label();
            txtLoanId = new TextBox();
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            lblStudentName = new Label();
            txtStudentName = new TextBox();
            lblEquipment = new Label();
            cbEquipment = new ComboBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblLoanDate = new Label();
            dtpLoanDate = new DateTimePicker();
            lblDueDate = new Label();
            dtpDueDate = new DateTimePicker();
            pButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnReturn = new Button();
            btnDelete = new Button();
            grpList = new GroupBox();
            tList = new TableLayoutPanel();
            pFilter = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            cbStatusFilter = new ComboBox();
            dgvLoans = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            mainLayout.SuspendLayout();
            grpInput.SuspendLayout();
            tInput.SuspendLayout();
            pButtons.SuspendLayout();
            grpList.SuspendLayout();
            tList.SuspendLayout();
            pFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoans).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1600, 30);
            menuStrip1.TabIndex = 0;
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
            menuExport.Size = new Size(152, 26);
            menuExport.Text = "Xuất CSV";
            menuExport.Click += MenuExport_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTotal, lblSeparator, lblOverdue });
            statusStrip1.Location = new Point(0, 1029);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 19, 0);
            statusStrip1.Size = new Size(1600, 26);
            statusStrip1.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(152, 20);
            lblTotal.Text = "Tổng phiếu hiển thị: 0";
            // 
            // lblSeparator
            // 
            lblSeparator.Name = "lblSeparator";
            lblSeparator.Size = new Size(13, 20);
            lblSeparator.Text = "|";
            // 
            // lblOverdue
            // 
            lblOverdue.Name = "lblOverdue";
            lblOverdue.Size = new Size(79, 20);
            lblOverdue.Text = "Quá hạn: 0";
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.0625F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.9375F));
            mainLayout.Controls.Add(grpInput, 0, 0);
            mainLayout.Controls.Add(grpList, 1, 0);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 30);
            mainLayout.Margin = new Padding(4, 5, 4, 5);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 1;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(1600, 999);
            mainLayout.TabIndex = 2;
            // 
            // grpInput
            // 
            grpInput.Controls.Add(tInput);
            grpInput.Dock = DockStyle.Fill;
            grpInput.Location = new Point(4, 5);
            grpInput.Margin = new Padding(4, 5, 4, 5);
            grpInput.Name = "grpInput";
            grpInput.Padding = new Padding(4, 5, 4, 5);
            grpInput.Size = new Size(633, 989);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin phiếu mượn thiết bị";
            // 
            // tInput
            // 
            tInput.ColumnCount = 2;
            tInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tInput.Controls.Add(lblLoanId, 0, 0);
            tInput.Controls.Add(txtLoanId, 1, 0);
            tInput.Controls.Add(lblStudentId, 0, 1);
            tInput.Controls.Add(txtStudentId, 1, 1);
            tInput.Controls.Add(lblStudentName, 0, 2);
            tInput.Controls.Add(txtStudentName, 1, 2);
            tInput.Controls.Add(lblEquipment, 0, 3);
            tInput.Controls.Add(cbEquipment, 1, 3);
            tInput.Controls.Add(lblQuantity, 0, 4);
            tInput.Controls.Add(txtQuantity, 1, 4);
            tInput.Controls.Add(lblLoanDate, 0, 5);
            tInput.Controls.Add(dtpLoanDate, 1, 5);
            tInput.Controls.Add(lblDueDate, 0, 6);
            tInput.Controls.Add(dtpDueDate, 1, 6);
            tInput.Controls.Add(pButtons, 1, 7);
            tInput.Dock = DockStyle.Fill;
            tInput.Location = new Point(4, 25);
            tInput.Margin = new Padding(4, 5, 4, 5);
            tInput.Name = "tInput";
            tInput.RowCount = 8;
            tInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tInput.Size = new Size(625, 959);
            tInput.TabIndex = 0;
            // 
            // lblLoanId
            // 
            lblLoanId.Anchor = AnchorStyles.Left;
            lblLoanId.Location = new Point(4, 13);
            lblLoanId.Margin = new Padding(4, 0, 4, 0);
            lblLoanId.Name = "lblLoanId";
            lblLoanId.Size = new Size(133, 35);
            lblLoanId.TabIndex = 0;
            lblLoanId.Text = "Mã phiếu:";
            // 
            // txtLoanId
            // 
            txtLoanId.Dock = DockStyle.Fill;
            txtLoanId.Location = new Point(222, 5);
            txtLoanId.Margin = new Padding(4, 5, 4, 5);
            txtLoanId.Name = "txtLoanId";
            txtLoanId.Size = new Size(399, 27);
            txtLoanId.TabIndex = 1;
            // 
            // lblStudentId
            // 
            lblStudentId.Anchor = AnchorStyles.Left;
            lblStudentId.Location = new Point(4, 75);
            lblStudentId.Margin = new Padding(4, 0, 4, 0);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(133, 35);
            lblStudentId.TabIndex = 2;
            lblStudentId.Text = "Mã sinh viên:";
            // 
            // txtStudentId
            // 
            txtStudentId.Dock = DockStyle.Fill;
            txtStudentId.Location = new Point(222, 67);
            txtStudentId.Margin = new Padding(4, 5, 4, 5);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(399, 27);
            txtStudentId.TabIndex = 3;
            // 
            // lblStudentName
            // 
            lblStudentName.Anchor = AnchorStyles.Left;
            lblStudentName.Location = new Point(4, 137);
            lblStudentName.Margin = new Padding(4, 0, 4, 0);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(133, 35);
            lblStudentName.TabIndex = 4;
            lblStudentName.Text = "Họ tên SV:";
            // 
            // txtStudentName
            // 
            txtStudentName.Dock = DockStyle.Fill;
            txtStudentName.Location = new Point(222, 129);
            txtStudentName.Margin = new Padding(4, 5, 4, 5);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(399, 27);
            txtStudentName.TabIndex = 5;
            // 
            // lblEquipment
            // 
            lblEquipment.Anchor = AnchorStyles.Left;
            lblEquipment.Location = new Point(4, 199);
            lblEquipment.Margin = new Padding(4, 0, 4, 0);
            lblEquipment.Name = "lblEquipment";
            lblEquipment.Size = new Size(133, 35);
            lblEquipment.TabIndex = 6;
            lblEquipment.Text = "Thiết bị:";
            // 
            // cbEquipment
            // 
            cbEquipment.Dock = DockStyle.Fill;
            cbEquipment.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEquipment.Items.AddRange(new object[] { "Máy đo dao động (Oscilloscope)", "Bộ nguồn DC", "Máy hàn điện tử", "Multimeter số" });
            cbEquipment.Location = new Point(222, 191);
            cbEquipment.Margin = new Padding(4, 5, 4, 5);
            cbEquipment.Name = "cbEquipment";
            cbEquipment.Size = new Size(399, 28);
            cbEquipment.TabIndex = 7;
            // 
            // lblQuantity
            // 
            lblQuantity.Anchor = AnchorStyles.Left;
            lblQuantity.Location = new Point(4, 261);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(133, 35);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Số lượng:";
            // 
            // txtQuantity
            // 
            txtQuantity.Dock = DockStyle.Fill;
            txtQuantity.Location = new Point(222, 253);
            txtQuantity.Margin = new Padding(4, 5, 4, 5);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(399, 27);
            txtQuantity.TabIndex = 9;
            txtQuantity.Text = "1";
            // 
            // lblLoanDate
            // 
            lblLoanDate.Anchor = AnchorStyles.Left;
            lblLoanDate.Location = new Point(4, 323);
            lblLoanDate.Margin = new Padding(4, 0, 4, 0);
            lblLoanDate.Name = "lblLoanDate";
            lblLoanDate.Size = new Size(133, 35);
            lblLoanDate.TabIndex = 10;
            lblLoanDate.Text = "Ngày mượn:";
            // 
            // dtpLoanDate
            // 
            dtpLoanDate.Dock = DockStyle.Fill;
            dtpLoanDate.Format = DateTimePickerFormat.Short;
            dtpLoanDate.Location = new Point(222, 315);
            dtpLoanDate.Margin = new Padding(4, 5, 4, 5);
            dtpLoanDate.Name = "dtpLoanDate";
            dtpLoanDate.Size = new Size(399, 27);
            dtpLoanDate.TabIndex = 11;
            // 
            // lblDueDate
            // 
            lblDueDate.Anchor = AnchorStyles.Left;
            lblDueDate.Location = new Point(4, 385);
            lblDueDate.Margin = new Padding(4, 0, 4, 0);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(133, 35);
            lblDueDate.TabIndex = 12;
            lblDueDate.Text = "Hạn trả:";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Dock = DockStyle.Fill;
            dtpDueDate.Format = DateTimePickerFormat.Short;
            dtpDueDate.Location = new Point(222, 377);
            dtpDueDate.Margin = new Padding(4, 5, 4, 5);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(399, 27);
            dtpDueDate.TabIndex = 13;
            // 
            // pButtons
            // 
            pButtons.Controls.Add(btnAdd);
            pButtons.Controls.Add(btnUpdate);
            pButtons.Controls.Add(btnReturn);
            pButtons.Controls.Add(btnDelete);
            pButtons.Dock = DockStyle.Fill;
            pButtons.Location = new Point(222, 439);
            pButtons.Margin = new Padding(4, 5, 4, 5);
            pButtons.Name = "pButtons";
            pButtons.Size = new Size(399, 515);
            pButtons.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(4, 5);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(87, 46);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(99, 5);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 46);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(187, 5);
            btnReturn.Margin = new Padding(4, 5, 4, 5);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(87, 46);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "Đã trả";
            btnReturn.Click += BtnReturn_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(282, 5);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(73, 46);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.Click += BtnDelete_Click;
            // 
            // grpList
            // 
            grpList.Controls.Add(tList);
            grpList.Dock = DockStyle.Fill;
            grpList.Location = new Point(645, 5);
            grpList.Margin = new Padding(4, 5, 4, 5);
            grpList.Name = "grpList";
            grpList.Padding = new Padding(4, 5, 4, 5);
            grpList.Size = new Size(951, 989);
            grpList.TabIndex = 1;
            grpList.TabStop = false;
            grpList.Text = "Danh sách phiếu mượn thiết bị";
            // 
            // tList
            // 
            tList.ColumnCount = 1;
            tList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tList.Controls.Add(pFilter, 0, 0);
            tList.Controls.Add(dgvLoans, 0, 1);
            tList.Dock = DockStyle.Fill;
            tList.Location = new Point(4, 25);
            tList.Margin = new Padding(4, 5, 4, 5);
            tList.Name = "tList";
            tList.RowCount = 2;
            tList.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tList.Size = new Size(943, 959);
            tList.TabIndex = 0;
            // 
            // pFilter
            // 
            pFilter.Controls.Add(lblSearch);
            pFilter.Controls.Add(txtSearch);
            pFilter.Controls.Add(cbStatusFilter);
            pFilter.Dock = DockStyle.Fill;
            pFilter.Location = new Point(4, 5);
            pFilter.Margin = new Padding(4, 5, 4, 5);
            pFilter.Name = "pFilter";
            pFilter.Size = new Size(935, 67);
            pFilter.TabIndex = 0;
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
            txtSearch.Size = new Size(199, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // cbStatusFilter
            // 
            cbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatusFilter.Items.AddRange(new object[] { "Tất cả trạng thái", "Đang mượn", "Quá hạn", "Đã trả" });
            cbStatusFilter.Location = new Point(256, 5);
            cbStatusFilter.Margin = new Padding(4, 5, 4, 5);
            cbStatusFilter.Name = "cbStatusFilter";
            cbStatusFilter.Size = new Size(185, 28);
            cbStatusFilter.TabIndex = 2;
            cbStatusFilter.SelectedIndexChanged += CbStatusFilter_SelectedIndexChanged;
            // 
            // dgvLoans
            // 
            dgvLoans.AllowUserToAddRows = false;
            dgvLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoans.Dock = DockStyle.Fill;
            dgvLoans.Location = new Point(4, 82);
            dgvLoans.Margin = new Padding(4, 5, 4, 5);
            dgvLoans.MultiSelect = false;
            dgvLoans.Name = "dgvLoans";
            dgvLoans.ReadOnly = true;
            dgvLoans.RowHeadersWidth = 51;
            dgvLoans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoans.Size = new Size(935, 872);
            dgvLoans.TabIndex = 1;
            dgvLoans.SelectionChanged += DgvLoans_SelectionChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // LabMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 1055);
            Controls.Add(mainLayout);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "LabMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab Equipment Checkout - Quản lý mượn trả thiết bị phòng thực hành";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            mainLayout.ResumeLayout(false);
            grpInput.ResumeLayout(false);
            tInput.ResumeLayout(false);
            tInput.PerformLayout();
            pButtons.ResumeLayout(false);
            grpList.ResumeLayout(false);
            tList.ResumeLayout(false);
            pFilter.ResumeLayout(false);
            pFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoans).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExport;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTotal;
        private System.Windows.Forms.ToolStripStatusLabel lblSeparator;
        private System.Windows.Forms.ToolStripStatusLabel lblOverdue;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TableLayoutPanel tInput;
        private System.Windows.Forms.Label lblLoanId;
        private System.Windows.Forms.TextBox txtLoanId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.ComboBox cbEquipment;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblLoanDate;
        private System.Windows.Forms.DateTimePicker dtpLoanDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.FlowLayoutPanel pButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.TableLayoutPanel tList;
        private System.Windows.Forms.FlowLayoutPanel pFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbStatusFilter;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}