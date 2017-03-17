using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.IO;

namespace FormSIC
{
    public partial class Form1 : Form
    {
        private InputInformation input;
        

        public Form1()
        {
            InitializeComponent();
            timer.Enabled = true;
            MessageBoxManager.Yes = "Có";
            MessageBoxManager.No = "Không";
            MessageBoxManager.Cancel = "Hủy";
            MessageBoxManager.Register();

            input = new InputInformation(
                tb_somay, tb_tensv, tb_msv, tb_sdt, tb_tenmay, tb_nd, tb_ghichu,
                bt_them, bt_capnhat, bt_xoa, bt_excel,
                timer,
                gvdata,
                saveFileDialog1,
                cms_menu);

            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            input.changeData();
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            if (input.checkData())
            {
                bt_them.Enabled = true;
                timer.Stop();
            }
            else
            {
                bt_them.Enabled = false;
            }

            if(input.Redo.Count == 0)
                mi_redo.Enabled = false;
            else
                mi_redo.Enabled = true;

            if (input.Undo.Count == 0)
                mi_undo.Enabled = false;
            else
                mi_undo.Enabled = true;

            if (!timer.Enabled)
            {
                timer.Enabled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            input.Form1_FormClosing(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            input.Form1_Load(sender, e);
        }

        private void mi_newfile_Click(object sender, EventArgs e)
        {
            DialogResult dialog =
            MessageBox.Show("Bạn có chắc chắn muốn tạo mới?", "Tạo mới",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                input.TableData = new System.Data.DataTable();
                input.Form1_Load(sender, e);
                input.reset();
            }
        }

        private void mi_open_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openDialog = new OpenFileDialog();
            //if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    string pathconn = "Provider = Microsoft.jet.OLEDB.12.0; Data source=" + openDialog.FileName + ";Extended Properties=\"Excel 12.0;HDR= yes;\";";
            //    OleDbConnection conn = new OleDbConnection(pathconn);
            //    OleDbDataAdapter MyDataAdapter = new OleDbDataAdapter("Select * from [Sheet1$]", conn);
            //    DataTable dt = new DataTable();
            //    MyDataAdapter.Fill(dt);
            //    input.GvData.DataSource = dt;
            //}
        }

        private void mi_save_Click(object sender, EventArgs e)
        {
            input.saveFile();
        }

        private void mi_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mi_undo_Click(object sender, EventArgs e)
        {
            input.undo();
        }

        private void mi_redo_Click(object sender, EventArgs e)
        {
            input.redo();
        }

        private void mi_addrow_Click(object sender, EventArgs e)
        {
            input.add();
        }

        private void mi_updaterow_Click(object sender, EventArgs e)
        {
            input.update();
        }

        private void mi_deleterow_Click(object sender, EventArgs e)
        {
            input.delete();
        }

        private void mi_excel_Click(object sender, EventArgs e)
        {
            input.saveFile();
        }

        private void guideOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/messages/t/104115109644619");
        }

        private void guideOfflineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string readText = File.ReadAllText("guildOffline.txt");
            DialogResult dialog = MessageBox.Show(readText, "Hướng dẫn", MessageBoxButtons.OK);
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string readText = File.ReadAllText("it's_me.txt");
            DialogResult dialog = MessageBox.Show(readText, "Thông tin sản phẩm", MessageBoxButtons.OK);
        }

        private void informationCLBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string readText = File.ReadAllText("info_SIC.txt");
            DialogResult dialog = MessageBox.Show(readText, "Thông tin CLB", MessageBoxButtons.OK);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input.undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input.redo();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input.add();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input.update();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input.delete();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input.saveFile();
        }

        
    }
}
