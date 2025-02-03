namespace CSQuizProject01
{
    partial class FrmInternetCafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInternetCafe));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDisc3 = new System.Windows.Forms.RadioButton();
            this.rdbDisc2 = new System.Windows.Forms.RadioButton();
            this.rdbDisc1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mktID = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mcDate = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbNum = new System.Windows.Forms.Label();
            this.lbServiceTtype = new System.Windows.Forms.Label();
            this.lbCusType = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btNew = new System.Windows.Forms.Button();
            this.btCal = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.cbOK = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(254, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "โปรแกรม Internet Cafe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDisc3);
            this.groupBox1.Controls.Add(this.rdbDisc2);
            this.groupBox1.Controls.Add(this.rdbDisc1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mktID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mcDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(136, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลผู้ใช้บริการ";
            // 
            // rdbDisc3
            // 
            this.rdbDisc3.AutoSize = true;
            this.rdbDisc3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbDisc3.Location = new System.Drawing.Point(302, 200);
            this.rdbDisc3.Name = "rdbDisc3";
            this.rdbDisc3.Size = new System.Drawing.Size(153, 22);
            this.rdbDisc3.TabIndex = 9;
            this.rdbDisc3.Text = "บุคคลทั่วไปไม่มีส่วนลด";
            this.rdbDisc3.UseVisualStyleBackColor = true;
            // 
            // rdbDisc2
            // 
            this.rdbDisc2.AutoSize = true;
            this.rdbDisc2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbDisc2.Location = new System.Drawing.Point(302, 173);
            this.rdbDisc2.Name = "rdbDisc2";
            this.rdbDisc2.Size = new System.Drawing.Size(170, 22);
            this.rdbDisc2.TabIndex = 8;
            this.rdbDisc2.Text = "นักเรียน/นักศึกษา ลด 5 %";
            this.rdbDisc2.UseVisualStyleBackColor = true;
            // 
            // rdbDisc1
            // 
            this.rdbDisc1.AutoSize = true;
            this.rdbDisc1.Checked = true;
            this.rdbDisc1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdbDisc1.Location = new System.Drawing.Point(302, 145);
            this.rdbDisc1.Name = "rdbDisc1";
            this.rdbDisc1.Size = new System.Drawing.Size(120, 22);
            this.rdbDisc1.TabIndex = 7;
            this.rdbDisc1.TabStop = true;
            this.rdbDisc1.Text = "สมาชิก ลด 10 %";
            this.rdbDisc1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "ประเภทผู้ใช้บริการ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(369, 79);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(212, 24);
            this.tbName.TabIndex = 5;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "ชื่อ-สกุล";
            // 
            // mktID
            // 
            this.mktID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mktID.Location = new System.Drawing.Point(442, 44);
            this.mktID.Mask = "0-0000-00000-00-0";
            this.mktID.Name = "mktID";
            this.mktID.Size = new System.Drawing.Size(139, 24);
            this.mktID.TabIndex = 3;
            this.mktID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "รหัสประจำตัวประชาชน";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // mcDate
            // 
            this.mcDate.Location = new System.Drawing.Point(50, 72);
            this.mcDate.Name = "mcDate";
            this.mcDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "วันที่ใช้บริการ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbNum);
            this.groupBox2.Controls.Add(this.lbServiceTtype);
            this.groupBox2.Controls.Add(this.lbCusType);
            this.groupBox2.Controls.Add(this.lbName);
            this.groupBox2.Controls.Add(this.lbID);
            this.groupBox2.Controls.Add(this.lbDate);
            this.groupBox2.Controls.Add(this.lbResult);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(776, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 548);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lbNum
            // 
            this.lbNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbNum.ForeColor = System.Drawing.Color.Red;
            this.lbNum.Location = new System.Drawing.Point(167, 303);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(211, 24);
            this.lbNum.TabIndex = 29;
            this.lbNum.Text = " -";
            this.lbNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbServiceTtype
            // 
            this.lbServiceTtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbServiceTtype.ForeColor = System.Drawing.Color.Red;
            this.lbServiceTtype.Location = new System.Drawing.Point(167, 259);
            this.lbServiceTtype.Name = "lbServiceTtype";
            this.lbServiceTtype.Size = new System.Drawing.Size(211, 24);
            this.lbServiceTtype.TabIndex = 28;
            this.lbServiceTtype.Text = " -";
            this.lbServiceTtype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCusType
            // 
            this.lbCusType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbCusType.ForeColor = System.Drawing.Color.Red;
            this.lbCusType.Location = new System.Drawing.Point(167, 215);
            this.lbCusType.Name = "lbCusType";
            this.lbCusType.Size = new System.Drawing.Size(211, 24);
            this.lbCusType.TabIndex = 27;
            this.lbCusType.Text = " -";
            this.lbCusType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbName.ForeColor = System.Drawing.Color.Red;
            this.lbName.Location = new System.Drawing.Point(167, 176);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(211, 24);
            this.lbName.TabIndex = 26;
            this.lbName.Text = " -";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbID
            // 
            this.lbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbID.ForeColor = System.Drawing.Color.Red;
            this.lbID.Location = new System.Drawing.Point(167, 141);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(211, 24);
            this.lbID.TabIndex = 25;
            this.lbID.Text = " -";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbDate.ForeColor = System.Drawing.Color.Red;
            this.lbDate.Location = new System.Drawing.Point(167, 100);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(211, 24);
            this.lbDate.TabIndex = 24;
            this.lbDate.Text = " -";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.Red;
            this.lbResult.Location = new System.Drawing.Point(19, 467);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(369, 51);
            this.lbResult.TabIndex = 23;
            this.lbResult.Text = "00.00";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBox1.Image = global::CSQuizProject01.Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Game_chip_48;
            this.pictureBox1.Location = new System.Drawing.Point(153, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(12, 303);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 24);
            this.label15.TabIndex = 20;
            this.label15.Text = "จำนวนการใช้บริการ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(12, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 24);
            this.label14.TabIndex = 18;
            this.label14.Text = "ประเภทการใช้บริการ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(12, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 24);
            this.label13.TabIndex = 16;
            this.label13.Text = "ประเภทผู้ใช้บริการ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 24);
            this.label12.TabIndex = 14;
            this.label12.Text = "ชื่้อ-สกุล";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(9, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "รหัสประจำตัวประาชน";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(9, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "วันที่ใช้บริการ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(104, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 33);
            this.label9.TabIndex = 4;
            this.label9.Text = "ข้อมูลการชำระเงิน";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbTime);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbbType);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(136, 442);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 185);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ข้อมูลการใช้บริการ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "ชั่วโมง";
            // 
            // tbTime
            // 
            this.tbTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTime.Location = new System.Drawing.Point(145, 122);
            this.tbTime.MaxLength = 100;
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(100, 24);
            this.tbTime.TabIndex = 10;
            this.tbTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTime_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "ระยะเวลาการใช้บริการ";
            // 
            // cbbType
            // 
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "อินเตอร์เน็ต ชั่วโมงละ 20.50 บาท",
            "พิมพ์งาน ชั่วโมงละ 10.50 บาท",
            "เล่นเกมส์ Offline ชั่วโมงละ 15.50 บาท",
            "เล่นเกมส์ Online  ชั่วโมงละ 25.50 บาท"});
            this.cbbType.Location = new System.Drawing.Point(145, 62);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(242, 26);
            this.cbbType.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "ประเภทการใช้บริการ";
            // 
            // btNew
            // 
            this.btNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNew.Location = new System.Drawing.Point(553, 453);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(183, 33);
            this.btNew.TabIndex = 4;
            this.btNew.Text = "เริ่มใหม่";
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btCal
            // 
            this.btCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCal.Location = new System.Drawing.Point(671, 507);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(65, 33);
            this.btCal.TabIndex = 5;
            this.btCal.Text = "คำนวณ";
            this.btCal.UseVisualStyleBackColor = false;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // btEnd
            // 
            this.btEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnd.Location = new System.Drawing.Point(553, 564);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(183, 33);
            this.btEnd.TabIndex = 6;
            this.btEnd.Text = "จบโปรแกรม";
            this.btEnd.UseVisualStyleBackColor = false;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // cbOK
            // 
            this.cbOK.AutoSize = true;
            this.cbOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOK.Location = new System.Drawing.Point(553, 516);
            this.cbOK.Name = "cbOK";
            this.cbOK.Size = new System.Drawing.Size(108, 22);
            this.cbOK.TabIndex = 7;
            this.cbOK.Text = "ยืนยันชำระเงิน";
            this.cbOK.UseVisualStyleBackColor = true;
            // 
            // FrmInternetCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.cbOK);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmInternetCafe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรม Quiz1";
            this.Load += new System.EventHandler(this.FrmInternetCafe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar mcDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mktID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbDisc1;
        private System.Windows.Forms.RadioButton rdbDisc2;
        private System.Windows.Forms.RadioButton rdbDisc3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.CheckBox cbOK;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbServiceTtype;
        private System.Windows.Forms.Label lbCusType;
        private System.Windows.Forms.Label lbNum;
    }
}

