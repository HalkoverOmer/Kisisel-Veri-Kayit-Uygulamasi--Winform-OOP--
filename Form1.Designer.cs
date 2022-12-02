namespace Kişisel_Veri_Kayit_Uygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCreateQRCode = new System.Windows.Forms.ToolStripButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstExperiences = new System.Windows.Forms.ListBox();
            this.btnExpCreate = new System.Windows.Forms.Button();
            this.txtExpCompany = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtExpCountry = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtExpCity = new System.Windows.Forms.TextBox();
            this.txtExpDetail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAddresses = new System.Windows.Forms.ListBox();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCountryRegionCode = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.txtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator1,
            this.btnCreateQRCode});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1143, 33);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(34, 28);
            this.btnOpen.Text = "&Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(34, 28);
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // btnCreateQRCode
            // 
            this.btnCreateQRCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCreateQRCode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateQRCode.Name = "btnCreateQRCode";
            this.btnCreateQRCode.Size = new System.Drawing.Size(34, 28);
            this.btnCreateQRCode.Text = "toolStripButton1";
            this.btnCreateQRCode.Click += new System.EventHandler(this.btnCreateQRCode_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lstExperiences);
            this.groupBox4.Controls.Add(this.btnExpCreate);
            this.groupBox4.Controls.Add(this.txtExpCompany);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(789, 63);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(337, 850);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "User Experiences";
            // 
            // lstExperiences
            // 
            this.lstExperiences.DisplayMember = "Company";
            this.lstExperiences.FormattingEnabled = true;
            this.lstExperiences.ItemHeight = 25;
            this.lstExperiences.Location = new System.Drawing.Point(9, 55);
            this.lstExperiences.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstExperiences.Name = "lstExperiences";
            this.lstExperiences.Size = new System.Drawing.Size(318, 229);
            this.lstExperiences.TabIndex = 5;
            // 
            // btnExpCreate
            // 
            this.btnExpCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpCreate.Enabled = false;
            this.btnExpCreate.Location = new System.Drawing.Point(221, 717);
            this.btnExpCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExpCreate.Name = "btnExpCreate";
            this.btnExpCreate.Size = new System.Drawing.Size(112, 38);
            this.btnExpCreate.TabIndex = 4;
            this.btnExpCreate.Text = "Add";
            this.btnExpCreate.UseVisualStyleBackColor = true;
            this.btnExpCreate.Click += new System.EventHandler(this.btnExpCreate_Click);
            // 
            // txtExpCompany
            // 
            this.txtExpCompany.Location = new System.Drawing.Point(9, 322);
            this.txtExpCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExpCompany.Name = "txtExpCompany";
            this.txtExpCompany.Size = new System.Drawing.Size(318, 31);
            this.txtExpCompany.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtExpCountry);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txtExpCity);
            this.groupBox5.Controls.Add(this.txtExpDetail);
            this.groupBox5.Location = new System.Drawing.Point(9, 370);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(320, 337);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Experience Address";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 260);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "Country";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 187);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "City";
            // 
            // txtExpCountry
            // 
            this.txtExpCountry.Location = new System.Drawing.Point(9, 288);
            this.txtExpCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExpCountry.Name = "txtExpCountry";
            this.txtExpCountry.Size = new System.Drawing.Size(301, 31);
            this.txtExpCountry.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 40);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "Detail";
            // 
            // txtExpCity
            // 
            this.txtExpCity.Location = new System.Drawing.Point(9, 215);
            this.txtExpCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExpCity.Name = "txtExpCity";
            this.txtExpCity.Size = new System.Drawing.Size(301, 31);
            this.txtExpCity.TabIndex = 1;
            // 
            // txtExpDetail
            // 
            this.txtExpDetail.Location = new System.Drawing.Point(9, 68);
            this.txtExpDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExpDetail.Multiline = true;
            this.txtExpDetail.Name = "txtExpDetail";
            this.txtExpDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExpDetail.Size = new System.Drawing.Size(301, 109);
            this.txtExpDetail.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 294);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Company";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAddresses);
            this.groupBox2.Controls.Add(this.btnAddAddress);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtPostalCode);
            this.groupBox2.Controls.Add(this.txtCity);
            this.groupBox2.Controls.Add(this.txtDistrict);
            this.groupBox2.Controls.Add(this.txtStreet);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(426, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(354, 850);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Addresses";
            // 
            // lstAddresses
            // 
            this.lstAddresses.FormattingEnabled = true;
            this.lstAddresses.ItemHeight = 25;
            this.lstAddresses.Location = new System.Drawing.Point(9, 55);
            this.lstAddresses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstAddresses.Name = "lstAddresses";
            this.lstAddresses.Size = new System.Drawing.Size(335, 229);
            this.lstAddresses.TabIndex = 5;
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Enabled = false;
            this.btnAddAddress.Location = new System.Drawing.Point(239, 802);
            this.btnAddAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(107, 38);
            this.btnAddAddress.TabIndex = 4;
            this.btnAddAddress.Text = "Add";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtCountryRegionCode);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtCountryName);
            this.groupBox3.Location = new System.Drawing.Point(9, 590);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(337, 202);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Address Country";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 114);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Region Code";
            // 
            // txtCountryRegionCode
            // 
            this.txtCountryRegionCode.Location = new System.Drawing.Point(9, 148);
            this.txtCountryRegionCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCountryRegionCode.Mask = "+000";
            this.txtCountryRegionCode.Name = "txtCountryRegionCode";
            this.txtCountryRegionCode.Size = new System.Drawing.Size(318, 31);
            this.txtCountryRegionCode.TabIndex = 3;
            this.txtCountryRegionCode.ValidatingType = typeof(int);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 40);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Name";
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(9, 68);
            this.txtCountryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(318, 31);
            this.txtCountryName.TabIndex = 1;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(9, 542);
            this.txtPostalCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPostalCode.Mask = "000000";
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(335, 31);
            this.txtPostalCode.TabIndex = 3;
            this.txtPostalCode.ValidatingType = typeof(int);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(9, 468);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(335, 31);
            this.txtCity.TabIndex = 1;
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(9, 395);
            this.txtDistrict.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(335, 31);
            this.txtDistrict.TabIndex = 1;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(9, 322);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(335, 31);
            this.txtStreet.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 514);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Postal Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 440);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 367);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "District";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 294);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Street";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picQRCode);
            this.groupBox1.Controls.Add(this.chkMale);
            this.groupBox1.Controls.Add(this.btnCreateUser);
            this.groupBox1.Controls.Add(this.txtTcNo);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.dtpBirthdate);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(400, 850);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            // 
            // picQRCode
            // 
            this.picQRCode.BackColor = System.Drawing.Color.White;
            this.picQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQRCode.Location = new System.Drawing.Point(24, 553);
            this.picQRCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(352, 285);
            this.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQRCode.TabIndex = 7;
            this.picQRCode.TabStop = false;
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Location = new System.Drawing.Point(24, 507);
            this.chkMale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(76, 29);
            this.chkMale.TabIndex = 5;
            this.chkMale.Text = "Male";
            this.chkMale.UseVisualStyleBackColor = true;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(269, 505);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(107, 38);
            this.btnCreateUser.TabIndex = 4;
            this.btnCreateUser.Text = "Create";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(23, 232);
            this.txtTcNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTcNo.Mask = "00000000000";
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(351, 31);
            this.txtTcNo.TabIndex = 3;
            this.txtTcNo.ValidatingType = typeof(int);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(23, 305);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(351, 31);
            this.txtPhone.TabIndex = 3;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(23, 452);
            this.dtpBirthdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(351, 31);
            this.dtpBirthdate.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(23, 378);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(351, 31);
            this.txtEmail.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(23, 158);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(351, 31);
            this.txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(23, 85);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(351, 31);
            this.txtName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 424);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Birthdate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "TC No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 922);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1165, 978);
            this.MinimumSize = new System.Drawing.Size(1165, 978);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Kayıt Programı";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnOpen;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnCreateQRCode;
        private GroupBox groupBox4;
        private ListBox lstExperiences;
        private Button btnExpCreate;
        private TextBox txtExpCompany;
        private GroupBox groupBox5;
        private Label label16;
        private Label label14;
        private TextBox txtExpCountry;
        private Label label15;
        private TextBox txtExpCity;
        private TextBox txtExpDetail;
        private Label label13;
        private GroupBox groupBox2;
        private ListBox lstAddresses;
        private Button btnAddAddress;
        private GroupBox groupBox3;
        private Label label12;
        private MaskedTextBox txtCountryRegionCode;
        private Label label11;
        private TextBox txtCountryName;
        private MaskedTextBox txtPostalCode;
        private TextBox txtCity;
        private TextBox txtDistrict;
        private TextBox txtStreet;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBox1;
        private CheckBox chkMale;
        private Button btnCreateUser;
        private MaskedTextBox txtTcNo;
        private MaskedTextBox txtPhone;
        private DateTimePicker dtpBirthdate;
        private TextBox txtEmail;
        private TextBox txtSurname;
        private TextBox txtName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox picQRCode;
    }
}