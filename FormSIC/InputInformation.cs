using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;

namespace FormSIC
{
    class InputInformation
    {
        private TextBox tb_nd;
        private TextBox tb_tenmay;
        private TextBox tb_msv;
        private TextBox tb_somay;
        private TextBox tb_tensv;
        private TextBox tb_sdt;
        private TextBox tb_ghichu;

        private Button bt_them;
        private Button bt_capnhat;
        private Button bt_xoa;
        private Button bt_excel;

        private Timer timer;

        private DataGridView gvdata;

        private SaveFileDialog saveFileDialog1;

        DataTable dataTable = new DataTable();

        public DataTable TableData
        {
            get { return dataTable; }
            set { dataTable = value; }
        }

        public DataGridView GvData
        {
            get { return gvdata; }
            set { gvdata = value; }
        }

        int indexRow;
        private bool check = false;

        Stack<string> undoStack = new Stack<string>();
        Stack<string> redoStack = new Stack<string>();

        public Stack<string> Undo
        {
            get { return undoStack; }
            set { undoStack = value; }
        }

        public Stack<string> Redo
        {
            get { return redoStack; }
            set { redoStack = value; }
        }

        public InputInformation(TextBox somay, TextBox tensv, TextBox msv, TextBox sdt, 
            TextBox tenmay, TextBox nd, TextBox ghichu,
            Button them, Button capnhat, Button xoa, Button excel,
            Timer timer,
            DataGridView data,
            SaveFileDialog save)
        {
            tb_nd = nd;
            tb_somay = somay;
            tb_sdt = sdt;
            tb_ghichu = ghichu;
            tb_tensv = tensv;
            tb_msv = msv;
            tb_tenmay = tenmay;

            bt_them = them;
            bt_capnhat = capnhat;
            bt_xoa = xoa;
            bt_excel = excel;

            this.timer = timer;
            
            gvdata = data;

            saveFileDialog1 = save;
        }

        public void changeData()
        {
            this.bt_capnhat.Click += bt_capnhat_Click;
            this.bt_them.Click += bt_them_Click;
            this.bt_xoa.Click += bt_xoa_Click;
            this.bt_excel.Click += bt_excel_Click;
            this.tb_somay.TextChanged += new System.EventHandler(this.tb_somay_TextChanged);
            this.tb_tensv.TextChanged += new System.EventHandler(this.tb_tensv_TextChanged);
            this.tb_msv.TextChanged += new System.EventHandler(this.tb_msv_TextChanged);
            this.tb_sdt.TextChanged += new System.EventHandler(this.tb_sdt_TextChanged);
            this.tb_tenmay.TextChanged += new System.EventHandler(this.tb_tenmay_TextChanged);
            this.tb_nd.TextChanged += new System.EventHandler(this.tb_nd_TextChanged);
            this.tb_ghichu.TextChanged += new System.EventHandler(this.tb_ghichu_TextChanged);
            this.gvdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvdata_CellClick);
        }

        public bool checkData()
        {
            if (String.IsNullOrEmpty(tb_nd.Text) || String.IsNullOrEmpty(tb_tenmay.Text)
                || String.IsNullOrEmpty(tb_msv.Text) || String.IsNullOrEmpty(tb_somay.Text) 
                || String.IsNullOrEmpty(tb_tensv.Text) || String.IsNullOrEmpty(tb_sdt.Text))
            {
                return false;
            }
            return true;
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("Số máy", typeof(int));
            dataTable.Columns.Add("Tên SV", typeof(String));
            dataTable.Columns.Add("MSV / CMT", typeof(String));
            dataTable.Columns.Add("Số điện thoại", typeof(String));
            dataTable.Columns.Add("Tên máy", typeof(String));
            dataTable.Columns.Add("Nội dung", typeof(String));
            dataTable.Columns.Add("Ghi chú", typeof(String));

            gvdata.DataSource = dataTable;
            gvdata.Columns[0].Width = 50;
            gvdata.Columns[5].Width = 200;
        }

        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
  
            if (gvdata.Rows.Count <= 1)
            {
                DialogResult dialogResult = MessageBox.Show
                    ("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                    e.Cancel = false;

                if (dialogResult == DialogResult.Cancel)
                    e.Cancel = true;
            }

            else if (!saveFile() && gvdata.Rows.Count > 1)
            {
                DialogResult dialogResult = MessageBox.Show
                    ("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if(dialogResult == DialogResult.OK && !check)
                {
                    DialogResult dialog = MessageBox.Show
                        ("Bạn chưa lưu File!", "Lỗi thoát", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dialog == DialogResult.OK)
                    {
                        e.Cancel = true;
                    }
                }
                if (dialogResult == DialogResult.OK && check)
                    e.Cancel = false;

                if (dialogResult == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        public void tb_somay_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (tb_somay.Text != "")
            {
                if (!int.TryParse(tb_somay.Text, out result))
                {
                    tb_somay.Text = "";
                    MessageBox.Show("Yêu cầu nhập số nguyên!", "Lỗi nhập!",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    undoStack.Push("somay:" + tb_somay.Text);
                }
            }
        }

        public void tb_tensv_TextChanged(object sender, EventArgs e)
        {
            undoStack.Push("tensv:" + tb_tensv.Text);
        }

        public void tb_msv_TextChanged(object sender, EventArgs e)
        {
            undoStack.Push("msv:" + tb_msv.Text);
        }

        public void tb_sdt_TextChanged(object sender, EventArgs e)
        {
            undoStack.Push("sdt:" + tb_sdt.Text);
        }

        public void tb_tenmay_TextChanged(object sender, EventArgs e)
        {
            undoStack.Push("tenmay:" + tb_tenmay.Text);
        }

        public void tb_nd_TextChanged(object sender, EventArgs e)
        {
            undoStack.Push("nd:" + tb_nd.Text);
        }

        public void tb_ghichu_TextChanged(object sender, EventArgs e)
        {
            undoStack.Push("ghichu:" + tb_ghichu.Text);
        }

        public void gvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = gvdata.Rows[indexRow];
                tb_somay.Text = row.Cells[0].Value.ToString();
                tb_tensv.Text = row.Cells[1].Value.ToString();
                tb_msv.Text = row.Cells[2].Value.ToString();
                tb_sdt.Text = row.Cells[3].Value.ToString();
                tb_tenmay.Text = row.Cells[4].Value.ToString();
                tb_nd.Text = row.Cells[5].Value.ToString();
                tb_ghichu.Text = row.Cells[6].Value.ToString();
                bt_capnhat.Enabled = true;
                bt_xoa.Enabled = true;
            }
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            update();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            add();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void bt_excel_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        public bool saveFile()
        {
            if(gvdata.RowCount > 1)
            {
                saveFileDialog1.InitialDirectory = "C:";
                saveFileDialog1.Title = "Xuất File Excel";
                saveFileDialog1.FileName = "";
                saveFileDialog1.Filter = "Excel Files(2007/2010/2013)|*.xlsx|Excel Files(2003)|*.xls";
                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    app excel
                        = new app();
                    excel.Application.Workbooks.Add(Type.Missing);﻿

                excel.Columns.ColumnWidth = 20;

                for (int i = 1; i < gvdata.Columns.Count + 1; i++)
                {
                    excel.Cells[1, i] = gvdata.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < gvdata.Rows.Count; i++)
                {
                    for (int j = 0; j < gvdata.Columns.Count; j++)
                    {
                        if (gvdata.Rows[i].Cells[j].Value != null)
                        {
                            excel.Cells[i + 2, j + 1] = gvdata.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                excel.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                excel.ActiveWorkbook.Saved = true;
                excel.Quit();
                MessageBox.Show("Lưu File thành công!", "Lưu file",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                check = true;
                return true;
                }

                MessageBox.Show("Lưu File thất bại!", "Lỗi",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                return false;
            }

            MessageBox.Show("Không có gì để lưu!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            check = false;
            return false;
        }

        public void reset()
        {
            tb_somay.Text = "";
            tb_tensv.Text = "";
            tb_sdt.Text = "";
            tb_msv.Text = "";
            tb_nd.Text = "";
            tb_ghichu.Text = "";
            tb_tenmay.Text = "";
        }

        public void undo()
        {
            if(undoStack.Count != 0)
            {
                string s = undoStack.Pop();
                redoStack.Push(s);
                string[] words = s.Split(':');
            
                if(words[0].Equals("somay"))    tb_somay.Text = words[1];

                else if (words[0].Equals("tensv"))   tb_tensv.Text = words[1];

                if (words[0].Equals("msv"))     tb_msv.Text = words[1];

                if (words[0].Equals("sdt"))     tb_sdt.Text = words[1];

                if (words[0].Equals("tenmay"))  tb_tenmay.Text = words[1];

                if (words[0].Equals("nd"))      tb_nd.Text = words[1];

                if (words[0].Equals("ghichu"))  tb_ghichu.Text = words[1];
            }
        }

        public void redo()
        {
            if (redoStack.Count != 0)
            {
                string s = redoStack.Pop();

                string[] words = s.Split(':');

                if (words[0].Equals("somay")) tb_somay.Text = words[1];

                else if (words[0].Equals("tensv")) tb_tensv.Text = words[1];

                if (words[0].Equals("msv")) tb_msv.Text = words[1];

                if (words[0].Equals("sdt")) tb_sdt.Text = words[1];

                if (words[0].Equals("tenmay")) tb_tenmay.Text = words[1];

                if (words[0].Equals("nd")) tb_nd.Text = words[1];

                if (words[0].Equals("ghichu")) tb_ghichu.Text = words[1];
            }
        }

        public void add()
        {
            if(checkData())
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Thêm mới",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    if (String.IsNullOrEmpty(tb_ghichu.Text))
                    {
                        dataTable.Rows.Add(tb_somay.Text, tb_tensv.Text,
                    tb_msv.Text, tb_sdt.Text, tb_tenmay.Text, tb_nd.Text, "Không");
                    }
                    else
                    {
                        dataTable.Rows.Add(tb_somay.Text, tb_tensv.Text,
                        tb_msv.Text, tb_sdt.Text, tb_tenmay.Text, tb_nd.Text, tb_ghichu.Text);
                    }
                    gvdata.DataSource = dataTable;
                }

                reset();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Trường thông tin đang trống!", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void update()
        {
            if(gvdata.RowCount > 1 && checkData())
            {
                DialogResult dialogResult = MessageBox.Show
                ("Bạn có chắc chắn muốn cập nhật dữ liệu của hàng này?",
                "Cập nhật dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    DataGridViewRow newData = gvdata.Rows[indexRow];
                    newData.Cells[0].Value = tb_somay.Text;
                    newData.Cells[1].Value = tb_tensv.Text;
                    newData.Cells[2].Value = tb_msv.Text;
                    newData.Cells[3].Value = tb_sdt.Text;
                    newData.Cells[4].Value = tb_tenmay.Text;
                    newData.Cells[5].Value = tb_nd.Text;
                    newData.Cells[6].Value = tb_ghichu.Text;
                    bt_capnhat.Enabled = false;
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show
                ("Không có trường nào để cập nhật!",
                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void delete()
        {
            if(gvdata.RowCount > 1)
            {
                DialogResult dialogResult = MessageBox.Show
                ("Bạn có chắc chắn muốn xóa dữ liệu của hàng này?",
                "Xóa dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    gvdata.Rows.RemoveAt(indexRow);
                    tb_somay.Text = tb_sdt.Text = tb_nd.Text = tb_msv.Text = tb_ghichu.Text
                    = tb_tenmay.Text = tb_tensv.Text = "";
                    bt_xoa.Enabled = false;
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show
                ("Không có trường nào để xóa!",
                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
