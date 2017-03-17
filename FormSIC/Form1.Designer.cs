namespace FormSIC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gvdata = new System.Windows.Forms.DataGridView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lb_so_may = new System.Windows.Forms.Label();
            this.lb_ten_sv = new System.Windows.Forms.Label();
            this.lb_msv = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.tb_somay = new System.Windows.Forms.TextBox();
            this.tb_tensv = new System.Windows.Forms.TextBox();
            this.tb_msv = new System.Windows.Forms.TextBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.tb_tenmay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.tb_nd = new System.Windows.Forms.TextBox();
            this.lb_noidung = new System.Windows.Forms.Label();
            this.lb_ghichu = new System.Windows.Forms.Label();
            this.tb_ghichu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_excel = new System.Windows.Forms.Button();
            this.bt_capnhat = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mi_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_newfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_open = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_save = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_redo = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_addrow = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_updaterow = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_deleterow = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_excel = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_guide = new System.Windows.Forms.ToolStripMenuItem();
            this.guideOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guideOfflineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_information = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationCLBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.cms_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvdata)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.cms_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvdata
            // 
            this.gvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvdata.Location = new System.Drawing.Point(376, 84);
            this.gvdata.MultiSelect = false;
            this.gvdata.Name = "gvdata";
            this.gvdata.ReadOnly = true;
            this.gvdata.Size = new System.Drawing.Size(793, 391);
            this.gvdata.TabIndex = 0;
            // 
            // lb_so_may
            // 
            this.lb_so_may.AutoSize = true;
            this.lb_so_may.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_so_may.Location = new System.Drawing.Point(14, 87);
            this.lb_so_may.Name = "lb_so_may";
            this.lb_so_may.Size = new System.Drawing.Size(66, 20);
            this.lb_so_may.TabIndex = 26;
            this.lb_so_may.Text = "Số máy:";
            // 
            // lb_ten_sv
            // 
            this.lb_ten_sv.AutoSize = true;
            this.lb_ten_sv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten_sv.Location = new System.Drawing.Point(14, 129);
            this.lb_ten_sv.Name = "lb_ten_sv";
            this.lb_ten_sv.Size = new System.Drawing.Size(66, 20);
            this.lb_ten_sv.TabIndex = 27;
            this.lb_ten_sv.Text = "Tên SV:";
            // 
            // lb_msv
            // 
            this.lb_msv.AutoSize = true;
            this.lb_msv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_msv.Location = new System.Drawing.Point(14, 172);
            this.lb_msv.Name = "lb_msv";
            this.lb_msv.Size = new System.Drawing.Size(82, 20);
            this.lb_msv.TabIndex = 28;
            this.lb_msv.Text = "Msv, CMT:";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sdt.Location = new System.Drawing.Point(14, 215);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(106, 20);
            this.lb_sdt.TabIndex = 29;
            this.lb_sdt.Text = "Số điện thoại:";
            // 
            // tb_somay
            // 
            this.tb_somay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_somay.Location = new System.Drawing.Point(142, 84);
            this.tb_somay.Name = "tb_somay";
            this.tb_somay.Size = new System.Drawing.Size(203, 26);
            this.tb_somay.TabIndex = 30;
            // 
            // tb_tensv
            // 
            this.tb_tensv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tensv.Location = new System.Drawing.Point(142, 126);
            this.tb_tensv.Name = "tb_tensv";
            this.tb_tensv.Size = new System.Drawing.Size(203, 26);
            this.tb_tensv.TabIndex = 31;
            // 
            // tb_msv
            // 
            this.tb_msv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_msv.Location = new System.Drawing.Point(142, 169);
            this.tb_msv.Name = "tb_msv";
            this.tb_msv.Size = new System.Drawing.Size(203, 26);
            this.tb_msv.TabIndex = 32;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sdt.Location = new System.Drawing.Point(142, 212);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(203, 26);
            this.tb_sdt.TabIndex = 33;
            // 
            // tb_tenmay
            // 
            this.tb_tenmay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenmay.Location = new System.Drawing.Point(142, 255);
            this.tb_tenmay.Name = "tb_tenmay";
            this.tb_tenmay.Size = new System.Drawing.Size(203, 26);
            this.tb_tenmay.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên máy:";
            // 
            // bt_them
            // 
            this.bt_them.Enabled = false;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(243, 410);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(102, 29);
            this.bt_them.TabIndex = 36;
            this.bt_them.Text = "Thêm mới";
            this.bt_them.UseVisualStyleBackColor = true;
            // 
            // tb_nd
            // 
            this.tb_nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nd.Location = new System.Drawing.Point(142, 297);
            this.tb_nd.Multiline = true;
            this.tb_nd.Name = "tb_nd";
            this.tb_nd.Size = new System.Drawing.Size(203, 70);
            this.tb_nd.TabIndex = 37;
            // 
            // lb_noidung
            // 
            this.lb_noidung.AutoSize = true;
            this.lb_noidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_noidung.Location = new System.Drawing.Point(14, 300);
            this.lb_noidung.Name = "lb_noidung";
            this.lb_noidung.Size = new System.Drawing.Size(106, 20);
            this.lb_noidung.TabIndex = 38;
            this.lb_noidung.Text = "Nội dung sửa:";
            // 
            // lb_ghichu
            // 
            this.lb_ghichu.AutoSize = true;
            this.lb_ghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ghichu.Location = new System.Drawing.Point(19, 381);
            this.lb_ghichu.Name = "lb_ghichu";
            this.lb_ghichu.Size = new System.Drawing.Size(68, 20);
            this.lb_ghichu.TabIndex = 39;
            this.lb_ghichu.Text = "Ghi chú:";
            // 
            // tb_ghichu
            // 
            this.tb_ghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ghichu.Location = new System.Drawing.Point(142, 378);
            this.tb_ghichu.Name = "tb_ghichu";
            this.tb_ghichu.Size = new System.Drawing.Size(203, 26);
            this.tb_ghichu.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nhập liệu thông tin";
            // 
            // bt_excel
            // 
            this.bt_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_excel.Location = new System.Drawing.Point(101, 449);
            this.bt_excel.Name = "bt_excel";
            this.bt_excel.Size = new System.Drawing.Size(149, 30);
            this.bt_excel.TabIndex = 49;
            this.bt_excel.Text = "Xuất file Excel";
            this.bt_excel.UseVisualStyleBackColor = true;
            // 
            // bt_capnhat
            // 
            this.bt_capnhat.Enabled = false;
            this.bt_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_capnhat.Location = new System.Drawing.Point(142, 410);
            this.bt_capnhat.Name = "bt_capnhat";
            this.bt_capnhat.Size = new System.Drawing.Size(95, 29);
            this.bt_capnhat.TabIndex = 50;
            this.bt_capnhat.Text = "Cập nhật";
            this.bt_capnhat.UseVisualStyleBackColor = true;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Enabled = false;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(46, 410);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(90, 29);
            this.bt_xoa.TabIndex = 51;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_file,
            this.mi_tool,
            this.mi_guide,
            this.mi_information});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mi_file
            // 
            this.mi_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_newfile,
            this.mi_open,
            this.mi_save,
            this.mi_exit});
            this.mi_file.Name = "mi_file";
            this.mi_file.Size = new System.Drawing.Size(39, 20);
            this.mi_file.Text = "Tệp";
            // 
            // mi_newfile
            // 
            this.mi_newfile.Image = global::FormSIC.Properties.Resources.New;
            this.mi_newfile.Name = "mi_newfile";
            this.mi_newfile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mi_newfile.Size = new System.Drawing.Size(177, 22);
            this.mi_newfile.Text = "Tạo mới";
            this.mi_newfile.Click += new System.EventHandler(this.mi_newfile_Click);
            // 
            // mi_open
            // 
            this.mi_open.Image = global::FormSIC.Properties.Resources.open;
            this.mi_open.Name = "mi_open";
            this.mi_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mi_open.Size = new System.Drawing.Size(177, 22);
            this.mi_open.Text = "Mở";
            this.mi_open.Click += new System.EventHandler(this.mi_open_Click);
            // 
            // mi_save
            // 
            this.mi_save.Image = global::FormSIC.Properties.Resources.Save;
            this.mi_save.Name = "mi_save";
            this.mi_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mi_save.Size = new System.Drawing.Size(177, 22);
            this.mi_save.Text = "Lưu";
            this.mi_save.Click += new System.EventHandler(this.mi_save_Click);
            // 
            // mi_exit
            // 
            this.mi_exit.Image = global::FormSIC.Properties.Resources.exit;
            this.mi_exit.Name = "mi_exit";
            this.mi_exit.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.mi_exit.Size = new System.Drawing.Size(177, 22);
            this.mi_exit.Text = "Thoát";
            this.mi_exit.Click += new System.EventHandler(this.mi_exit_Click);
            // 
            // mi_tool
            // 
            this.mi_tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_undo,
            this.mi_redo,
            this.mi_addrow,
            this.mi_updaterow,
            this.mi_deleterow,
            this.mi_excel});
            this.mi_tool.Name = "mi_tool";
            this.mi_tool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mi_tool.Size = new System.Drawing.Size(64, 20);
            this.mi_tool.Text = "Công cụ";
            // 
            // mi_undo
            // 
            this.mi_undo.Image = global::FormSIC.Properties.Resources.undo;
            this.mi_undo.Name = "mi_undo";
            this.mi_undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mi_undo.Size = new System.Drawing.Size(220, 22);
            this.mi_undo.Text = "Undo";
            this.mi_undo.Click += new System.EventHandler(this.mi_undo_Click);
            // 
            // mi_redo
            // 
            this.mi_redo.Image = global::FormSIC.Properties.Resources.redo;
            this.mi_redo.Name = "mi_redo";
            this.mi_redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.mi_redo.Size = new System.Drawing.Size(220, 22);
            this.mi_redo.Text = "Redo";
            this.mi_redo.Click += new System.EventHandler(this.mi_redo_Click);
            // 
            // mi_addrow
            // 
            this.mi_addrow.Image = global::FormSIC.Properties.Resources.add;
            this.mi_addrow.Name = "mi_addrow";
            this.mi_addrow.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mi_addrow.Size = new System.Drawing.Size(220, 22);
            this.mi_addrow.Text = "Thêm mới";
            this.mi_addrow.Click += new System.EventHandler(this.mi_addrow_Click);
            // 
            // mi_updaterow
            // 
            this.mi_updaterow.Image = global::FormSIC.Properties.Resources.edit;
            this.mi_updaterow.Name = "mi_updaterow";
            this.mi_updaterow.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mi_updaterow.Size = new System.Drawing.Size(220, 22);
            this.mi_updaterow.Text = "Cập nhật";
            this.mi_updaterow.Click += new System.EventHandler(this.mi_updaterow_Click);
            // 
            // mi_deleterow
            // 
            this.mi_deleterow.Image = global::FormSIC.Properties.Resources.Delete;
            this.mi_deleterow.Name = "mi_deleterow";
            this.mi_deleterow.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mi_deleterow.Size = new System.Drawing.Size(220, 22);
            this.mi_deleterow.Text = "Xóa";
            this.mi_deleterow.Click += new System.EventHandler(this.mi_deleterow_Click);
            // 
            // mi_excel
            // 
            this.mi_excel.Image = global::FormSIC.Properties.Resources.Save;
            this.mi_excel.Name = "mi_excel";
            this.mi_excel.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mi_excel.Size = new System.Drawing.Size(220, 22);
            this.mi_excel.Text = "Xuất File Excel";
            this.mi_excel.Click += new System.EventHandler(this.mi_excel_Click);
            // 
            // mi_guide
            // 
            this.mi_guide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guideOnlineToolStripMenuItem,
            this.guideOfflineToolStripMenuItem});
            this.mi_guide.Name = "mi_guide";
            this.mi_guide.Size = new System.Drawing.Size(79, 20);
            this.mi_guide.Text = "Hướng dẫn";
            // 
            // guideOnlineToolStripMenuItem
            // 
            this.guideOnlineToolStripMenuItem.Image = global::FormSIC.Properties.Resources.help_online;
            this.guideOnlineToolStripMenuItem.Name = "guideOnlineToolStripMenuItem";
            this.guideOnlineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.guideOnlineToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.guideOnlineToolStripMenuItem.Text = "Hướng dẫn Online";
            this.guideOnlineToolStripMenuItem.Click += new System.EventHandler(this.guideOnlineToolStripMenuItem_Click);
            // 
            // guideOfflineToolStripMenuItem
            // 
            this.guideOfflineToolStripMenuItem.Image = global::FormSIC.Properties.Resources.help_offline;
            this.guideOfflineToolStripMenuItem.Name = "guideOfflineToolStripMenuItem";
            this.guideOfflineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.guideOfflineToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.guideOfflineToolStripMenuItem.Text = "Hướng dẫn Offline";
            this.guideOfflineToolStripMenuItem.Click += new System.EventHandler(this.guideOfflineToolStripMenuItem_Click);
            // 
            // mi_information
            // 
            this.mi_information.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.informationCLBToolStripMenuItem});
            this.mi_information.Name = "mi_information";
            this.mi_information.Size = new System.Drawing.Size(71, 20);
            this.mi_information.Text = "Thông tin";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Image = global::FormSIC.Properties.Resources.Info;
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.informationToolStripMenuItem.Text = "Thông tin sản phẩm";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // informationCLBToolStripMenuItem
            // 
            this.informationCLBToolStripMenuItem.Image = global::FormSIC.Properties.Resources.logo_SIC1;
            this.informationCLBToolStripMenuItem.Name = "informationCLBToolStripMenuItem";
            this.informationCLBToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.informationCLBToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.informationCLBToolStripMenuItem.Text = "Thông tin CLB";
            this.informationCLBToolStripMenuItem.Click += new System.EventHandler(this.informationCLBToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(724, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Bảng nhập liệu";
            // 
            // cms_menu
            // 
            this.cms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.addNewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.cms_menu.Name = "cms_menu";
            this.cms_menu.Size = new System.Drawing.Size(187, 158);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::FormSIC.Properties.Resources.undo;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::FormSIC.Properties.Resources.redo;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Image = global::FormSIC.Properties.Resources.add;
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.addNewToolStripMenuItem.Text = "Thêm Mới";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::FormSIC.Properties.Resources.edit;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.editToolStripMenuItem.Text = "Sửa";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::FormSIC.Properties.Resources.Delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.deleteToolStripMenuItem.Text = "Xóa";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::FormSIC.Properties.Resources.Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Xuất file Excel";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Image = global::FormSIC.Properties.Resources.exit;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cancelToolStripMenuItem.Text = "Hủy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormSIC.Properties.Resources.logoForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1184, 510);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_capnhat);
            this.Controls.Add(this.bt_excel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ghichu);
            this.Controls.Add(this.lb_ghichu);
            this.Controls.Add(this.lb_noidung);
            this.Controls.Add(this.tb_nd);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tenmay);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.tb_msv);
            this.Controls.Add(this.tb_tensv);
            this.Controls.Add(this.tb_somay);
            this.Controls.Add(this.lb_sdt);
            this.Controls.Add(this.lb_msv);
            this.Controls.Add(this.lb_ten_sv);
            this.Controls.Add(this.lb_so_may);
            this.Controls.Add(this.gvdata);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Phần mềm nhập liệu - CLB Tin học Sinh Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvdata)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cms_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvdata;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lb_so_may;
        private System.Windows.Forms.Label lb_ten_sv;
        private System.Windows.Forms.Label lb_msv;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.TextBox tb_tensv;
        private System.Windows.Forms.TextBox tb_msv;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.TextBox tb_tenmay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox tb_nd;
        private System.Windows.Forms.Label lb_noidung;
        private System.Windows.Forms.Label lb_ghichu;
        private System.Windows.Forms.TextBox tb_ghichu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_excel;
        private System.Windows.Forms.Button bt_capnhat;
        private System.Windows.Forms.Button bt_xoa;
        public System.Windows.Forms.TextBox tb_somay;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mi_file;
        private System.Windows.Forms.ToolStripMenuItem mi_newfile;
        private System.Windows.Forms.ToolStripMenuItem mi_open;
        private System.Windows.Forms.ToolStripMenuItem mi_save;
        private System.Windows.Forms.ToolStripMenuItem mi_exit;
        private System.Windows.Forms.ToolStripMenuItem mi_tool;
        private System.Windows.Forms.ToolStripMenuItem mi_addrow;
        private System.Windows.Forms.ToolStripMenuItem mi_updaterow;
        private System.Windows.Forms.ToolStripMenuItem mi_deleterow;
        private System.Windows.Forms.ToolStripMenuItem mi_excel;
        private System.Windows.Forms.ToolStripMenuItem mi_guide;
        private System.Windows.Forms.ToolStripMenuItem guideOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guideOfflineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_information;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationCLBToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem mi_undo;
        private System.Windows.Forms.ToolStripMenuItem mi_redo;
        private System.Windows.Forms.ContextMenuStrip cms_menu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
    }
}

