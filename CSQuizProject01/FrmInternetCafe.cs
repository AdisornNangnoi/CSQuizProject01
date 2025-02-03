using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSQuizProject01
{
    public partial class FrmInternetCafe : Form
    {
        public FrmInternetCafe()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmInternetCafe_Load(object sender, EventArgs e)
        {
            btNew.PerformClick();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            mcDate.SelectionStart = DateTime.Now;
            tbName.Clear();
            mktID.Clear();
            tbTime.Clear();
            rdbDisc1.Checked = true;
            cbbType.SelectedIndex = 0;
            cbOK.Checked = false;
            lbDate.Text = " -";
            lbID.Text = " -";
            lbName.Text = " -";
            lbCusType.Text = " -";
            lbServiceTtype.Text = " -";
            lbNum.Text = " -";
            lbResult.Text = "00.00";
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // ห้ามพิมพ์ตัวเลขและสัญลักษณ์
            }
        }

        private void tbTime_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            
        }

        private void btEnd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ต้องการออกจากโปรแกรมใช่หรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void fareCal(double discout) 
        {
            double result = 0;
            if (cbbType.SelectedIndex == 0) {
                result = int.Parse(tbTime.Text) * 20.5 * discout;
            }
            else if (cbbType.SelectedIndex == 1)
            {
                result = int.Parse(tbTime.Text) * 10.5 * discout;
            }
            else if (cbbType.SelectedIndex == 2)
            {
                result = int.Parse(tbTime.Text) * 15.5 * discout;
            }
            else if (cbbType.SelectedIndex == 3)
            {
                result = int.Parse(tbTime.Text) * 25.5 * discout;
            }

            lbResult.Text = result.ToString("N2");
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            if (cbOK.Checked == false)
            {
                shareData.showWarningMsg("กรุณายืนยันการชำระเงิน");
            }
            else if (mcDate.SelectionStart > DateTime.Now) 
            {
                shareData.showWarningMsg("วันที่เลือกไม่ถูกต้อง");
            }
            else if (mktID.MaskCompleted == false) { 
                shareData.showWarningMsg("กรุณากรอกเลขบัตรประชาชนให้ครบ");
                mktID.Focus();
            }
            else if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                shareData.showWarningMsg("กรุณากรอกชื่อลูกค้า");
                tbName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(tbTime.Text))
            {
                shareData.showWarningMsg("กรุณากรอกระยะเวลาที่ใช้บริการ");
                tbTime.Focus();
            }
            else
            {
                if (rdbDisc1.Checked == true) 
                {
                    fareCal(0.9);
                    lbCusType.Text = "สมาชิก";
                }
                else if (rdbDisc2.Checked == true)
                {
                    fareCal(0.95);
                    lbCusType.Text = "นักเรียร/นักศึกษา";
                }
                else if (rdbDisc3.Checked == true)
                {
                    fareCal(1);
                    lbCusType.Text = "ลูกค้าทั่วไป";
                }
                lbDate.Text = mcDate.SelectionStart.ToString("dd MMMM พ.ศ. yyyy", new CultureInfo("th-TH"));
                lbID.Text = mktID.Text;
                lbName.Text = tbName.Text;
                lbServiceTtype.Text = cbbType.Text;
                lbNum.Text = tbTime.Text;
            }

            

            

        }
    }
}
