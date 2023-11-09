using QLTV1.Models;
using QLTV1.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV1
{
    public partial class Form1 : Form
    {
        private Button curbtn;
        private TheLoaiUC theloaiuc = new TheLoaiUC();
        private DocGiaUC docgiauc = new DocGiaUC();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_TheLoai_Click(object sender, EventArgs e)
        {
            if(curbtn != null)
            {
                curbtn = btn_TheLoai;
            }
            if (!splitContainer1.Panel2.Controls.Contains(theloaiuc))
            {
                splitContainer1.Panel2.Controls.Clear();
                theloaiuc.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(theloaiuc);
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (curbtn != null)
                {
                    curbtn = btn_TheLoai;
                }
                if (!splitContainer1.Panel2.Controls.Contains(theloaiuc))
                {
                    splitContainer1.Panel2.Controls.Clear();
                    theloaiuc.Dock = DockStyle.Fill;
                    splitContainer1.Panel2.Controls.Add(theloaiuc);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_DocGia_Click(object sender, EventArgs e)
        {
            if (curbtn != null)
            {
                curbtn = btn_TheLoai;
            }
            if (!splitContainer1.Panel2.Controls.Contains(docgiauc))
            {
                splitContainer1.Panel2.Controls.Clear();
                docgiauc.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(docgiauc);
            }
        }

        private void label_Home_Click(object sender, EventArgs e)
        {

        }
    }
}
