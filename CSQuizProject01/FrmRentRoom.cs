using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSQuizProject01
{
    public partial class FrmRentRoom : Form
    {
        public FrmRentRoom()
        {
            InitializeComponent();
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            tbName.Clear();
            mktID.Clear();
            rdbMr.Checked = true;
            cbbType.SelectedIndex = 0;

            cbPhone.Checked = false;
            cbNet.Checked = false;
            cbWater.Checked = false;
            cbElec.Checked = false;

            tbPhone.Text = "0.00";
            tbNet.Text = "0.00";
            tbWater.Text = "0.00";
            tbElec.Text = "0.00";

            lbDate.Text = " -";
            lbID.Text = " -";
            lbName.Text = " -";
            lbType.Text = " -";

            tbPhone.Enabled = false;
            tbNet.Enabled = false;
            tbWater.Enabled = false;
            tbElec.Enabled = false;

            lbPhoneUnit.Text = "0";
            lbNetUnit.Text = "0";
            lbWaterUnit.Text = "0";
            lbElecUnit.Text = "0";

            lbPhonePay.Text = "0.00";
            lbNetPay.Text = "0.00";
            lbWaterPay.Text = "0.00";
            lbElecPay.Text = "0.00";

            lbTotal.Text = "00.00";
        }

        private void FrmRentRoom_Load(object sender, EventArgs e)
        {
            btCancel.PerformClick();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // ห้ามพิมพ์ตัวเลขและสัญลักษณ์
            }
        }

        private void tbSurName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // ห้ามพิมพ์ตัวเลขและสัญลักษณ์
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // ถ้า TextBox ว่าง และตัวอักษรที่ป้อนไม่ใช่ตัวเลข
            if (textBox.Text.Length == 0 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void tbNet_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // ถ้า TextBox ว่าง และตัวอักษรที่ป้อนไม่ใช่ตัวเลข
            if (textBox.Text.Length == 0 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void tbWater_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // ถ้า TextBox ว่าง และตัวอักษรที่ป้อนไม่ใช่ตัวเลข
            if (textBox.Text.Length == 0 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void tbElec_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // ถ้า TextBox ว่าง และตัวอักษรที่ป้อนไม่ใช่ตัวเลข
            if (textBox.Text.Length == 0 && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            if (dtpDate.Value > DateTime.Now)
            {
                shareData.showWarningMsg("กรุณาเลือกวันที่เช่าห้องที่ถูกต้อง");
            }
            else if (mktID.MaskCompleted == false)
            {
                shareData.showWarningMsg("กรุณากรอกหมายเลขบัตรประชาชนให้ครบ");
            }
            else if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                shareData.showWarningMsg("กรุณากรอกชื่อ");
            }
            else if (string.IsNullOrWhiteSpace(tbSurName.Text))
            {
                shareData.showWarningMsg("กรุณากรอกนามสกุล");
            }
            else if (cbPhone.Checked == true && string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                shareData.showWarningMsg("กรุณากรอกค่าโทรศัพท์");
            }
            else if (cbNet.Checked == true && string.IsNullOrWhiteSpace(tbNet.Text))
            {
                shareData.showWarningMsg("กรุณากรอกค่าเน็ต");
            }
            else if (cbWater.Checked == true && string.IsNullOrWhiteSpace(tbWater.Text))
            {
                shareData.showWarningMsg("กรุณากรอกค่าน้ำ");
            }
            else if (cbElec.Checked == true && string.IsNullOrWhiteSpace(tbElec.Text))
            {
                shareData.showWarningMsg("กรุณากรอกค่าไฟ");
            }
            else
            {
                lbDate.Text = dtpDate.Value.ToString("dd MMMM พ.ศ. yyyy", new CultureInfo("th-TH"));
                lbID.Text = mktID.Text;
                if (rdbMr.Checked == true)
                {
                    lbName.Text = "นาย " + tbName.Text + " " + tbSurName.Text;
                }
                else if (rdbMrs.Checked == true)
                {
                    lbName.Text = "นางสาว " + tbName.Text + " " + tbSurName.Text;
                }
                else if (rdbMiss.Checked == true)
                {
                    lbName.Text = "นาง " + tbName.Text + " " + tbSurName.Text;
                }
                lbType.Text = cbbType.Text;
                lbPhoneUnit.Text = tbPhone.Text;
                lbNetUnit.Text = tbNet.Text;
                lbWaterUnit.Text = tbWater.Text;
                lbElecUnit.Text = tbElec.Text;

                double phonePay = 0, netPay = 0, waterPay = 0, elecPay = 0;

                if (double.TryParse(tbPhone.Text, out phonePay))
                {
                    phonePay *= 1.5;
                    lbPhonePay.Text = phonePay.ToString("F2");
                }
                else
                {
                    lbPhonePay.Text = "0.00";
                }

                if (double.TryParse(tbNet.Text, out netPay))
                {
                    netPay *= 0.5;
                    lbNetPay.Text = netPay.ToString("F2");
                }
                else
                {
                    lbNetPay.Text = "0.00";
                }

                if (double.TryParse(tbWater.Text, out waterPay))
                {
                    waterPay *= 12.5;
                    lbWaterPay.Text = waterPay.ToString("F2");
                }
                else
                {
                    lbWaterPay.Text = "0.00";
                }

                if (double.TryParse(tbElec.Text, out elecPay))
                {
                    elecPay *= 15.75;
                    lbElecPay.Text = elecPay.ToString("F2");
                }
                else
                {
                    lbElecPay.Text = "0.00";
                }

                int roomType;
                if (cbbType.SelectedIndex == 0)
                {
                    roomType = 4500;
                }
                else if (cbbType.SelectedIndex == 1)
                {
                    roomType = 4000;
                }
                else if (cbbType.SelectedIndex == 2)
                {
                    roomType = 3500;
                }
                else
                {
                    roomType = 3000;
                }

                lbTotal.Text = (phonePay + netPay + waterPay + elecPay + roomType).ToString("F2");
            }
        }

        private void cbPhone_Click(object sender, EventArgs e)
        {
            if (cbPhone.Checked == true)
            {
                tbPhone.Enabled = true;
            }
            else
            {
                tbPhone.Text = "0.00";
                tbPhone.Enabled = false;
            }
        }

        private void cbNet_Click(object sender, EventArgs e)
        {
            if (cbNet.Checked == true)
            {
                tbNet.Enabled = true;
            }
            else
            {
                tbNet.Text = "0.00";
                tbNet.Enabled = false;
            }
        }

        private void cbWater_Click(object sender, EventArgs e)
        {
            if (cbWater.Checked == true)
            {
                tbWater.Enabled = true;
            }
            else
            {
                tbWater.Text = "0.00";
                tbWater.Enabled = false;
            }
        }

        private void cbElec_Click(object sender, EventArgs e)
        {
            if (cbElec.Checked == true)
            {
                tbElec.Enabled = true;
            }
            else
            {
                tbElec.Text = "0.00";
                tbElec.Enabled = false;
            }
        }
    }
    }
