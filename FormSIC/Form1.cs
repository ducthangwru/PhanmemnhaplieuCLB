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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Text.RegularExpressions;

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
                saveFileDialog1);

            input.changeData();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            input.Form1_FormClosing(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            input.Form1_Load(sender, e);
        }
    }
}
