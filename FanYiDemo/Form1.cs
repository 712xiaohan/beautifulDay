using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FanYiDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFanyi_Click(object sender, EventArgs e)
        {
            StringBuilder strResult = new StringBuilder();
            Translation tran = new Translation();
            string txt = txtSourceText.Text.Trim();
            if(txt=="")
            {
                MessageBox.Show("您还未输入内容");
                return;
            }
            //AppendLine会自动换行
            if(chbEnglish.Checked)
                strResult.AppendLine( tran.TranEnglish(txt));
            if(chbFrench.Checked)
                strResult.AppendLine(tran.TranFrench(txt));
            if (chbGerman.Checked)
                strResult.AppendLine(tran.TranGerman(txt));
            if (chbRussian.Checked)
                strResult.AppendLine(tran.TranRussian(txt));
            if (chbKorean.Checked)
                strResult.AppendLine(tran.TranKorean(txt));
            if (chbJapan.Checked)
                strResult.AppendLine(tran.TranJapan(txt));
            if (chbSpanish.Checked)
                strResult.AppendLine(tran.TranSpanish(txt));
           
            txtTranText.Text = strResult.ToString();

        }

       
    }
}
