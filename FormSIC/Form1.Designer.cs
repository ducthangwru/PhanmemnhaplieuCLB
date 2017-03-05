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
            this.tệpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngCụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quayLạiUndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtFileExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnOfflineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCLBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvdata)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.gvdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvdata_CellClick);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            this.tb_somay.TextChanged += new System.EventHandler(this.tb_somay_TextChanged);
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
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
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
            this.bt_excel.Click += new System.EventHandler(this.bt_excel_Click);
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
            this.bt_capnhat.Click += new System.EventHandler(this.bt_capnhat_Click);
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
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tệpToolStripMenuItem,
            this.côngCụToolStripMenuItem,
            this.hướngDẫnToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            this.tệpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tạoMớiToolStripMenuItem,
            this.mởToolStripMenuItem,
            this.lưuToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            this.tệpToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.tệpToolStripMenuItem.Text = "Tệp";
            // 
            // tạoMớiToolStripMenuItem
            // 
            this.tạoMớiToolStripMenuItem.Image = global::FormSIC.Properties.Resources.New;
            this.tạoMớiToolStripMenuItem.Name = "tạoMớiToolStripMenuItem";
            this.tạoMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tạoMớiToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.tạoMớiToolStripMenuItem.Text = "Tạo mới";
            // 
            // mởToolStripMenuItem
            // 
            this.mởToolStripMenuItem.Image = global::FormSIC.Properties.Resources.open;
            this.mởToolStripMenuItem.Name = "mởToolStripMenuItem";
            this.mởToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mởToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.mởToolStripMenuItem.Text = "Mở";
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Image = global::FormSIC.Properties.Resources.Save;
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.lưuToolStripMenuItem.Text = "Lưu";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::FormSIC.Properties.Resources.exit;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // côngCụToolStripMenuItem
            // 
            this.côngCụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayLạiUndoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.thêmMớiToolStripMenuItem,
            this.cậpNhậtToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.xuấtFileExcelToolStripMenuItem});
            this.côngCụToolStripMenuItem.Name = "côngCụToolStripMenuItem";
            this.côngCụToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.côngCụToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.côngCụToolStripMenuItem.Text = "Công cụ";
            // 
            // quayLạiUndoToolStripMenuItem
            // 
            this.quayLạiUndoToolStripMenuItem.Image = global::FormSIC.Properties.Resources.undo;
            this.quayLạiUndoToolStripMenuItem.Name = "quayLạiUndoToolStripMenuItem";
            this.quayLạiUndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.quayLạiUndoToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.quayLạiUndoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::FormSIC.Properties.Resources.redo;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // thêmMớiToolStripMenuItem
            // 
            this.thêmMớiToolStripMenuItem.Image = global::FormSIC.Properties.Resources.add;
            this.thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            this.thêmMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.thêmMớiToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.thêmMớiToolStripMenuItem.Text = "Thêm mới";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.Image = global::FormSIC.Properties.Resources.edit;
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Image = global::FormSIC.Properties.Resources.Delete;
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // xuấtFileExcelToolStripMenuItem
            // 
            this.xuấtFileExcelToolStripMenuItem.Image = global::FormSIC.Properties.Resources.Save;
            this.xuấtFileExcelToolStripMenuItem.Name = "xuấtFileExcelToolStripMenuItem";
            this.xuấtFileExcelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.xuấtFileExcelToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.xuấtFileExcelToolStripMenuItem.Text = "Xuất File Excel";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnOnlineToolStripMenuItem,
            this.hướngDẫnOfflineToolStripMenuItem});
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // hướngDẫnOnlineToolStripMenuItem
            // 
            this.hướngDẫnOnlineToolStripMenuItem.Image = global::FormSIC.Properties.Resources.help_online;
            this.hướngDẫnOnlineToolStripMenuItem.Name = "hướngDẫnOnlineToolStripMenuItem";
            this.hướngDẫnOnlineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hướngDẫnOnlineToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.hướngDẫnOnlineToolStripMenuItem.Text = "Hướng dẫn Online";
            // 
            // hướngDẫnOfflineToolStripMenuItem
            // 
            this.hướngDẫnOfflineToolStripMenuItem.Image = global::FormSIC.Properties.Resources.help_offline;
            this.hướngDẫnOfflineToolStripMenuItem.Name = "hướngDẫnOfflineToolStripMenuItem";
            this.hướngDẫnOfflineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.hướngDẫnOfflineToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.hướngDẫnOfflineToolStripMenuItem.Text = "Hướng dẫn Offline";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinSảnPhẩmToolStripMenuItem,
            this.thôngTinCLBToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // thôngTinSảnPhẩmToolStripMenuItem
            // 
            this.thôngTinSảnPhẩmToolStripMenuItem.Image = global::FormSIC.Properties.Resources.Info;
            this.thôngTinSảnPhẩmToolStripMenuItem.Name = "thôngTinSảnPhẩmToolStripMenuItem";
            this.thôngTinSảnPhẩmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.thôngTinSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.thôngTinSảnPhẩmToolStripMenuItem.Text = "Thông tin sản phẩm";
            // 
            // thôngTinCLBToolStripMenuItem
            // 
            this.thôngTinCLBToolStripMenuItem.Image = global::FormSIC.Properties.Resources.logo_SIC1;
            this.thôngTinCLBToolStripMenuItem.Name = "thôngTinCLBToolStripMenuItem";
            this.thôngTinCLBToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.thôngTinCLBToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.thôngTinCLBToolStripMenuItem.Text = "Thông tin CLB";
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
        private System.Windows.Forms.ToolStripMenuItem tệpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem côngCụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtFileExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnOfflineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCLBToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem quayLạiUndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    }
}

