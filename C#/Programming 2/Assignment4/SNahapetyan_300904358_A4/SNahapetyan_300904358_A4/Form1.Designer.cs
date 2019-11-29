namespace SNahapetyan_300904358_A4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstBoxClubs = new System.Windows.Forms.ListBox();
            this.lblClubName = new System.Windows.Forms.Label();
            this.txtBoxClubName = new System.Windows.Forms.TextBox();
            this.lblClubAddressStreet = new System.Windows.Forms.Label();
            this.txtBoxClubAddressStreet = new System.Windows.Forms.TextBox();
            this.lblClubPhoneNum = new System.Windows.Forms.Label();
            this.txtBoxClubPhoneNum = new System.Windows.Forms.TextBox();
            this.butAddClub = new System.Windows.Forms.Button();
            this.txtBoxSwimmerPhoneNum = new System.Windows.Forms.TextBox();
            this.lblSwimmerPhoneNum = new System.Windows.Forms.Label();
            this.txtBoxSwimmerAddressStreet = new System.Windows.Forms.TextBox();
            this.lblSwimmerAddressStreet = new System.Windows.Forms.Label();
            this.txtBoxSwimmerName = new System.Windows.Forms.TextBox();
            this.lblSwimmerName = new System.Windows.Forms.Label();
            this.lblSwimmerDOB = new System.Windows.Forms.Label();
            this.butAddSwimmer = new System.Windows.Forms.Button();
            this.lblLstBoxClubs = new System.Windows.Forms.Label();
            this.lblLstBoxSwimmers = new System.Windows.Forms.Label();
            this.lstBoxSwimmers = new System.Windows.Forms.ListBox();
            this.lblLstBoxCoachs = new System.Windows.Forms.Label();
            this.lstBoxCoachs = new System.Windows.Forms.ListBox();
            this.butAddCoach = new System.Windows.Forms.Button();
            this.lblCoachDOB = new System.Windows.Forms.Label();
            this.txtBoxCoachPhoneNum = new System.Windows.Forms.TextBox();
            this.lblCoachPhoneNum = new System.Windows.Forms.Label();
            this.txtBoxCoachAddressStreet = new System.Windows.Forms.TextBox();
            this.lblCoachAddressStreet = new System.Windows.Forms.Label();
            this.txtBoxCoachName = new System.Windows.Forms.TextBox();
            this.lblCoachName = new System.Windows.Forms.Label();
            this.txtBoxClubAddressCity = new System.Windows.Forms.TextBox();
            this.lblClubAddressCity = new System.Windows.Forms.Label();
            this.txtBoxClubAddressZip = new System.Windows.Forms.TextBox();
            this.lblClubAddressZip = new System.Windows.Forms.Label();
            this.txtBoxClubAddressProvince = new System.Windows.Forms.TextBox();
            this.lblClubAddressProvince = new System.Windows.Forms.Label();
            this.txtBoxSwimmerAddressCity = new System.Windows.Forms.TextBox();
            this.lblSwimmerAddressCity = new System.Windows.Forms.Label();
            this.txtBoxSwimmerAddressProvince = new System.Windows.Forms.TextBox();
            this.lblSwimmerAddressProvince = new System.Windows.Forms.Label();
            this.txtBoxSwimmerAddressZip = new System.Windows.Forms.TextBox();
            this.lblSwimmerAddressZip = new System.Windows.Forms.Label();
            this.lblSwimmerClub = new System.Windows.Forms.Label();
            this.butAddSwimmerToClub = new System.Windows.Forms.Button();
            this.txtBoxCoachAddressZip = new System.Windows.Forms.TextBox();
            this.lblCoachAddressZip = new System.Windows.Forms.Label();
            this.txtBoxCoachAddressProvince = new System.Windows.Forms.TextBox();
            this.lblCoachAddressProvince = new System.Windows.Forms.Label();
            this.txtBoxCoachAddressCity = new System.Windows.Forms.TextBox();
            this.lblCoachAddressCity = new System.Windows.Forms.Label();
            this.butAddCoachToClub = new System.Windows.Forms.Button();
            this.lblCoachClub = new System.Windows.Forms.Label();
            this.comboBoxSwimmerDOBMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxSwimmerDOBDay = new System.Windows.Forms.ComboBox();
            this.txtBoxSwimmerDOBYear = new System.Windows.Forms.TextBox();
            this.txtBoxCoachDOBYear = new System.Windows.Forms.TextBox();
            this.comboBoxCoachDOBDay = new System.Windows.Forms.ComboBox();
            this.comboBoxCoachDOBMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClubInfo = new System.Windows.Forms.Label();
            this.lblClubNameInfo = new System.Windows.Forms.Label();
            this.lblClubAddressInfo = new System.Windows.Forms.Label();
            this.lblClubPhoneNumInfo = new System.Windows.Forms.Label();
            this.lblClubRegInfo = new System.Windows.Forms.Label();
            this.lstBoxClubsSwimmers = new System.Windows.Forms.ListBox();
            this.lblClubSwimmersInfo = new System.Windows.Forms.Label();
            this.lblClubSwimmerDOBInfo = new System.Windows.Forms.Label();
            this.lblClubSwimmerPhoneNumInfo = new System.Windows.Forms.Label();
            this.lblClubSwimmerAddressInfo = new System.Windows.Forms.Label();
            this.lblClubSwimmerNameInfo = new System.Windows.Forms.Label();
            this.lblClubSwimmerRegInfo = new System.Windows.Forms.Label();
            this.lblClubCoachRegInfo = new System.Windows.Forms.Label();
            this.lblClubCoachDOBInfo = new System.Windows.Forms.Label();
            this.lblClubCoachPhoneNumInfo = new System.Windows.Forms.Label();
            this.lblClubCoachAddressInfo = new System.Windows.Forms.Label();
            this.lblClubCoachNameInfo = new System.Windows.Forms.Label();
            this.lblClubCoachsInfo = new System.Windows.Forms.Label();
            this.lstBoxClubsCoachs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBoxClubs
            // 
            this.lstBoxClubs.FormattingEnabled = true;
            this.lstBoxClubs.ItemHeight = 16;
            this.lstBoxClubs.Location = new System.Drawing.Point(12, 45);
            this.lstBoxClubs.Name = "lstBoxClubs";
            this.lstBoxClubs.Size = new System.Drawing.Size(169, 132);
            this.lstBoxClubs.TabIndex = 0;
            this.lstBoxClubs.SelectedIndexChanged += new System.EventHandler(this.lstBoxClubs_SelectedIndexChanged);
            // 
            // lblClubName
            // 
            this.lblClubName.AutoSize = true;
            this.lblClubName.Location = new System.Drawing.Point(187, 45);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(81, 17);
            this.lblClubName.TabIndex = 4;
            this.lblClubName.Text = "Club Name:";
            // 
            // txtBoxClubName
            // 
            this.txtBoxClubName.Location = new System.Drawing.Point(270, 45);
            this.txtBoxClubName.Name = "txtBoxClubName";
            this.txtBoxClubName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxClubName.TabIndex = 5;
            // 
            // lblClubAddressStreet
            // 
            this.lblClubAddressStreet.AutoSize = true;
            this.lblClubAddressStreet.Location = new System.Drawing.Point(384, 45);
            this.lblClubAddressStreet.Name = "lblClubAddressStreet";
            this.lblClubAddressStreet.Size = new System.Drawing.Size(82, 17);
            this.lblClubAddressStreet.TabIndex = 6;
            this.lblClubAddressStreet.Text = "Club Street:";
            // 
            // txtBoxClubAddressStreet
            // 
            this.txtBoxClubAddressStreet.Location = new System.Drawing.Point(472, 45);
            this.txtBoxClubAddressStreet.Name = "txtBoxClubAddressStreet";
            this.txtBoxClubAddressStreet.Size = new System.Drawing.Size(100, 22);
            this.txtBoxClubAddressStreet.TabIndex = 7;
            // 
            // lblClubPhoneNum
            // 
            this.lblClubPhoneNum.AutoSize = true;
            this.lblClubPhoneNum.Location = new System.Drawing.Point(620, 90);
            this.lblClubPhoneNum.Name = "lblClubPhoneNum";
            this.lblClubPhoneNum.Size = new System.Drawing.Size(139, 17);
            this.lblClubPhoneNum.TabIndex = 8;
            this.lblClubPhoneNum.Text = "Club Phone Number:";
            // 
            // txtBoxClubPhoneNum
            // 
            this.txtBoxClubPhoneNum.Location = new System.Drawing.Point(756, 89);
            this.txtBoxClubPhoneNum.Name = "txtBoxClubPhoneNum";
            this.txtBoxClubPhoneNum.Size = new System.Drawing.Size(100, 22);
            this.txtBoxClubPhoneNum.TabIndex = 9;
            // 
            // butAddClub
            // 
            this.butAddClub.Location = new System.Drawing.Point(187, 113);
            this.butAddClub.Name = "butAddClub";
            this.butAddClub.Size = new System.Drawing.Size(128, 23);
            this.butAddClub.TabIndex = 10;
            this.butAddClub.Text = "Add Club";
            this.butAddClub.UseVisualStyleBackColor = true;
            this.butAddClub.Click += new System.EventHandler(this.butAddClub_Click);
            // 
            // txtBoxSwimmerPhoneNum
            // 
            this.txtBoxSwimmerPhoneNum.Location = new System.Drawing.Point(357, 501);
            this.txtBoxSwimmerPhoneNum.Name = "txtBoxSwimmerPhoneNum";
            this.txtBoxSwimmerPhoneNum.Size = new System.Drawing.Size(100, 22);
            this.txtBoxSwimmerPhoneNum.TabIndex = 16;
            // 
            // lblSwimmerPhoneNum
            // 
            this.lblSwimmerPhoneNum.AutoSize = true;
            this.lblSwimmerPhoneNum.Location = new System.Drawing.Point(184, 504);
            this.lblSwimmerPhoneNum.Name = "lblSwimmerPhoneNum";
            this.lblSwimmerPhoneNum.Size = new System.Drawing.Size(167, 17);
            this.lblSwimmerPhoneNum.TabIndex = 15;
            this.lblSwimmerPhoneNum.Text = "Swimmer Phone Number:";
            // 
            // txtBoxSwimmerAddressStreet
            // 
            this.txtBoxSwimmerAddressStreet.Location = new System.Drawing.Point(546, 427);
            this.txtBoxSwimmerAddressStreet.Name = "txtBoxSwimmerAddressStreet";
            this.txtBoxSwimmerAddressStreet.Size = new System.Drawing.Size(100, 22);
            this.txtBoxSwimmerAddressStreet.TabIndex = 14;
            // 
            // lblSwimmerAddressStreet
            // 
            this.lblSwimmerAddressStreet.AutoSize = true;
            this.lblSwimmerAddressStreet.Location = new System.Drawing.Point(430, 427);
            this.lblSwimmerAddressStreet.Name = "lblSwimmerAddressStreet";
            this.lblSwimmerAddressStreet.Size = new System.Drawing.Size(110, 17);
            this.lblSwimmerAddressStreet.TabIndex = 13;
            this.lblSwimmerAddressStreet.Text = "Swimmer Street:";
            // 
            // txtBoxSwimmerName
            // 
            this.txtBoxSwimmerName.Location = new System.Drawing.Point(302, 427);
            this.txtBoxSwimmerName.Name = "txtBoxSwimmerName";
            this.txtBoxSwimmerName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxSwimmerName.TabIndex = 12;
            // 
            // lblSwimmerName
            // 
            this.lblSwimmerName.AutoSize = true;
            this.lblSwimmerName.Location = new System.Drawing.Point(187, 427);
            this.lblSwimmerName.Name = "lblSwimmerName";
            this.lblSwimmerName.Size = new System.Drawing.Size(109, 17);
            this.lblSwimmerName.TabIndex = 11;
            this.lblSwimmerName.Text = "Swimmer Name:";
            // 
            // lblSwimmerDOB
            // 
            this.lblSwimmerDOB.AutoSize = true;
            this.lblSwimmerDOB.Location = new System.Drawing.Point(477, 502);
            this.lblSwimmerDOB.Name = "lblSwimmerDOB";
            this.lblSwimmerDOB.Size = new System.Drawing.Size(199, 17);
            this.lblSwimmerDOB.TabIndex = 17;
            this.lblSwimmerDOB.Text = "Swimmer Date of Birth (y/m/d):";
            // 
            // butAddSwimmer
            // 
            this.butAddSwimmer.Location = new System.Drawing.Point(187, 535);
            this.butAddSwimmer.Name = "butAddSwimmer";
            this.butAddSwimmer.Size = new System.Drawing.Size(128, 23);
            this.butAddSwimmer.TabIndex = 19;
            this.butAddSwimmer.Text = "Add Swimmer ";
            this.butAddSwimmer.UseVisualStyleBackColor = true;
            this.butAddSwimmer.Click += new System.EventHandler(this.butAddSwimmer_Click);
            // 
            // lblLstBoxClubs
            // 
            this.lblLstBoxClubs.AutoSize = true;
            this.lblLstBoxClubs.Location = new System.Drawing.Point(13, 17);
            this.lblLstBoxClubs.Name = "lblLstBoxClubs";
            this.lblLstBoxClubs.Size = new System.Drawing.Size(47, 17);
            this.lblLstBoxClubs.TabIndex = 20;
            this.lblLstBoxClubs.Text = "Clubs:";
            // 
            // lblLstBoxSwimmers
            // 
            this.lblLstBoxSwimmers.AutoSize = true;
            this.lblLstBoxSwimmers.Location = new System.Drawing.Point(13, 399);
            this.lblLstBoxSwimmers.Name = "lblLstBoxSwimmers";
            this.lblLstBoxSwimmers.Size = new System.Drawing.Size(75, 17);
            this.lblLstBoxSwimmers.TabIndex = 22;
            this.lblLstBoxSwimmers.Text = "Swimmers:";
            // 
            // lstBoxSwimmers
            // 
            this.lstBoxSwimmers.FormattingEnabled = true;
            this.lstBoxSwimmers.ItemHeight = 16;
            this.lstBoxSwimmers.Location = new System.Drawing.Point(12, 427);
            this.lstBoxSwimmers.Name = "lstBoxSwimmers";
            this.lstBoxSwimmers.Size = new System.Drawing.Size(169, 132);
            this.lstBoxSwimmers.TabIndex = 21;
            this.lstBoxSwimmers.SelectedIndexChanged += new System.EventHandler(this.lstBoxSwimmers_SelectedIndexChanged);
            // 
            // lblLstBoxCoachs
            // 
            this.lblLstBoxCoachs.AutoSize = true;
            this.lblLstBoxCoachs.Location = new System.Drawing.Point(13, 573);
            this.lblLstBoxCoachs.Name = "lblLstBoxCoachs";
            this.lblLstBoxCoachs.Size = new System.Drawing.Size(59, 17);
            this.lblLstBoxCoachs.TabIndex = 24;
            this.lblLstBoxCoachs.Text = "Coachs:";
            // 
            // lstBoxCoachs
            // 
            this.lstBoxCoachs.FormattingEnabled = true;
            this.lstBoxCoachs.ItemHeight = 16;
            this.lstBoxCoachs.Location = new System.Drawing.Point(12, 601);
            this.lstBoxCoachs.Name = "lstBoxCoachs";
            this.lstBoxCoachs.Size = new System.Drawing.Size(169, 132);
            this.lstBoxCoachs.TabIndex = 23;
            this.lstBoxCoachs.SelectedIndexChanged += new System.EventHandler(this.lstBoxCoachs_SelectedIndexChanged);
            // 
            // butAddCoach
            // 
            this.butAddCoach.Location = new System.Drawing.Point(187, 710);
            this.butAddCoach.Name = "butAddCoach";
            this.butAddCoach.Size = new System.Drawing.Size(128, 23);
            this.butAddCoach.TabIndex = 33;
            this.butAddCoach.Text = "Add Coach";
            this.butAddCoach.UseVisualStyleBackColor = true;
            this.butAddCoach.Click += new System.EventHandler(this.butAddCoach_Click);
            // 
            // lblCoachDOB
            // 
            this.lblCoachDOB.AutoSize = true;
            this.lblCoachDOB.Location = new System.Drawing.Point(477, 681);
            this.lblCoachDOB.Name = "lblCoachDOB";
            this.lblCoachDOB.Size = new System.Drawing.Size(183, 17);
            this.lblCoachDOB.TabIndex = 31;
            this.lblCoachDOB.Text = "Coach Date of Birth (y/m/d):";
            // 
            // txtBoxCoachPhoneNum
            // 
            this.txtBoxCoachPhoneNum.Location = new System.Drawing.Point(341, 681);
            this.txtBoxCoachPhoneNum.Name = "txtBoxCoachPhoneNum";
            this.txtBoxCoachPhoneNum.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCoachPhoneNum.TabIndex = 30;
            // 
            // lblCoachPhoneNum
            // 
            this.lblCoachPhoneNum.AutoSize = true;
            this.lblCoachPhoneNum.Location = new System.Drawing.Point(184, 683);
            this.lblCoachPhoneNum.Name = "lblCoachPhoneNum";
            this.lblCoachPhoneNum.Size = new System.Drawing.Size(151, 17);
            this.lblCoachPhoneNum.TabIndex = 29;
            this.lblCoachPhoneNum.Text = "Coach Phone Number:";
            // 
            // txtBoxCoachAddressStreet
            // 
            this.txtBoxCoachAddressStreet.Location = new System.Drawing.Point(527, 602);
            this.txtBoxCoachAddressStreet.Name = "txtBoxCoachAddressStreet";
            this.txtBoxCoachAddressStreet.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCoachAddressStreet.TabIndex = 28;
            // 
            // lblCoachAddressStreet
            // 
            this.lblCoachAddressStreet.AutoSize = true;
            this.lblCoachAddressStreet.Location = new System.Drawing.Point(427, 602);
            this.lblCoachAddressStreet.Name = "lblCoachAddressStreet";
            this.lblCoachAddressStreet.Size = new System.Drawing.Size(94, 17);
            this.lblCoachAddressStreet.TabIndex = 27;
            this.lblCoachAddressStreet.Text = "Coach Street:";
            // 
            // txtBoxCoachName
            // 
            this.txtBoxCoachName.Location = new System.Drawing.Point(283, 602);
            this.txtBoxCoachName.Name = "txtBoxCoachName";
            this.txtBoxCoachName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCoachName.TabIndex = 26;
            // 
            // lblCoachName
            // 
            this.lblCoachName.AutoSize = true;
            this.lblCoachName.Location = new System.Drawing.Point(184, 602);
            this.lblCoachName.Name = "lblCoachName";
            this.lblCoachName.Size = new System.Drawing.Size(93, 17);
            this.lblCoachName.TabIndex = 25;
            this.lblCoachName.Text = "Coach Name:";
            // 
            // txtBoxClubAddressCity
            // 
            this.txtBoxClubAddressCity.Location = new System.Drawing.Point(651, 42);
            this.txtBoxClubAddressCity.Name = "txtBoxClubAddressCity";
            this.txtBoxClubAddressCity.Size = new System.Drawing.Size(100, 22);
            this.txtBoxClubAddressCity.TabIndex = 35;
            // 
            // lblClubAddressCity
            // 
            this.lblClubAddressCity.AutoSize = true;
            this.lblClubAddressCity.Location = new System.Drawing.Point(578, 45);
            this.lblClubAddressCity.Name = "lblClubAddressCity";
            this.lblClubAddressCity.Size = new System.Drawing.Size(67, 17);
            this.lblClubAddressCity.TabIndex = 34;
            this.lblClubAddressCity.Text = "Club City:";
            // 
            // txtBoxClubAddressZip
            // 
            this.txtBoxClubAddressZip.Location = new System.Drawing.Point(514, 89);
            this.txtBoxClubAddressZip.Name = "txtBoxClubAddressZip";
            this.txtBoxClubAddressZip.Size = new System.Drawing.Size(100, 22);
            this.txtBoxClubAddressZip.TabIndex = 39;
            // 
            // lblClubAddressZip
            // 
            this.lblClubAddressZip.AutoSize = true;
            this.lblClubAddressZip.Location = new System.Drawing.Point(407, 92);
            this.lblClubAddressZip.Name = "lblClubAddressZip";
            this.lblClubAddressZip.Size = new System.Drawing.Size(101, 17);
            this.lblClubAddressZip.TabIndex = 38;
            this.lblClubAddressZip.Text = "Club Zip Code:";
            // 
            // txtBoxClubAddressProvince
            // 
            this.txtBoxClubAddressProvince.Location = new System.Drawing.Point(292, 90);
            this.txtBoxClubAddressProvince.Name = "txtBoxClubAddressProvince";
            this.txtBoxClubAddressProvince.Size = new System.Drawing.Size(100, 22);
            this.txtBoxClubAddressProvince.TabIndex = 37;
            // 
            // lblClubAddressProvince
            // 
            this.lblClubAddressProvince.AutoSize = true;
            this.lblClubAddressProvince.Location = new System.Drawing.Point(187, 87);
            this.lblClubAddressProvince.Name = "lblClubAddressProvince";
            this.lblClubAddressProvince.Size = new System.Drawing.Size(99, 17);
            this.lblClubAddressProvince.TabIndex = 36;
            this.lblClubAddressProvince.Text = "Club Province:";
            // 
            // txtBoxSwimmerAddressCity
            // 
            this.txtBoxSwimmerAddressCity.Location = new System.Drawing.Point(753, 430);
            this.txtBoxSwimmerAddressCity.Name = "txtBoxSwimmerAddressCity";
            this.txtBoxSwimmerAddressCity.Size = new System.Drawing.Size(100, 22);
            this.txtBoxSwimmerAddressCity.TabIndex = 41;
            // 
            // lblSwimmerAddressCity
            // 
            this.lblSwimmerAddressCity.AutoSize = true;
            this.lblSwimmerAddressCity.Location = new System.Drawing.Point(652, 430);
            this.lblSwimmerAddressCity.Name = "lblSwimmerAddressCity";
            this.lblSwimmerAddressCity.Size = new System.Drawing.Size(95, 17);
            this.lblSwimmerAddressCity.TabIndex = 40;
            this.lblSwimmerAddressCity.Text = "Swimmer City:";
            // 
            // txtBoxSwimmerAddressProvince
            // 
            this.txtBoxSwimmerAddressProvince.Location = new System.Drawing.Point(324, 465);
            this.txtBoxSwimmerAddressProvince.Name = "txtBoxSwimmerAddressProvince";
            this.txtBoxSwimmerAddressProvince.Size = new System.Drawing.Size(100, 22);
            this.txtBoxSwimmerAddressProvince.TabIndex = 43;
            // 
            // lblSwimmerAddressProvince
            // 
            this.lblSwimmerAddressProvince.AutoSize = true;
            this.lblSwimmerAddressProvince.Location = new System.Drawing.Point(191, 468);
            this.lblSwimmerAddressProvince.Name = "lblSwimmerAddressProvince";
            this.lblSwimmerAddressProvince.Size = new System.Drawing.Size(127, 17);
            this.lblSwimmerAddressProvince.TabIndex = 42;
            this.lblSwimmerAddressProvince.Text = "Swimmer Province:";
            // 
            // txtBoxSwimmerAddressZip
            // 
            this.txtBoxSwimmerAddressZip.Location = new System.Drawing.Point(580, 468);
            this.txtBoxSwimmerAddressZip.Name = "txtBoxSwimmerAddressZip";
            this.txtBoxSwimmerAddressZip.Size = new System.Drawing.Size(100, 22);
            this.txtBoxSwimmerAddressZip.TabIndex = 45;
            // 
            // lblSwimmerAddressZip
            // 
            this.lblSwimmerAddressZip.AutoSize = true;
            this.lblSwimmerAddressZip.Location = new System.Drawing.Point(445, 470);
            this.lblSwimmerAddressZip.Name = "lblSwimmerAddressZip";
            this.lblSwimmerAddressZip.Size = new System.Drawing.Size(129, 17);
            this.lblSwimmerAddressZip.TabIndex = 44;
            this.lblSwimmerAddressZip.Text = "Swimmer Zip Code:";
            // 
            // lblSwimmerClub
            // 
            this.lblSwimmerClub.AutoSize = true;
            this.lblSwimmerClub.Location = new System.Drawing.Point(374, 538);
            this.lblSwimmerClub.Name = "lblSwimmerClub";
            this.lblSwimmerClub.Size = new System.Drawing.Size(149, 17);
            this.lblSwimmerClub.TabIndex = 46;
            this.lblSwimmerClub.Text = "Select swimmer to add";
            // 
            // butAddSwimmerToClub
            // 
            this.butAddSwimmerToClub.Location = new System.Drawing.Point(677, 532);
            this.butAddSwimmerToClub.Name = "butAddSwimmerToClub";
            this.butAddSwimmerToClub.Size = new System.Drawing.Size(176, 23);
            this.butAddSwimmerToClub.TabIndex = 48;
            this.butAddSwimmerToClub.Text = "Add Swimmer to Club";
            this.butAddSwimmerToClub.UseVisualStyleBackColor = true;
            this.butAddSwimmerToClub.Click += new System.EventHandler(this.butAddSwimmerToClub_Click);
            // 
            // txtBoxCoachAddressZip
            // 
            this.txtBoxCoachAddressZip.Location = new System.Drawing.Point(580, 645);
            this.txtBoxCoachAddressZip.Name = "txtBoxCoachAddressZip";
            this.txtBoxCoachAddressZip.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCoachAddressZip.TabIndex = 54;
            // 
            // lblCoachAddressZip
            // 
            this.lblCoachAddressZip.AutoSize = true;
            this.lblCoachAddressZip.Location = new System.Drawing.Point(445, 647);
            this.lblCoachAddressZip.Name = "lblCoachAddressZip";
            this.lblCoachAddressZip.Size = new System.Drawing.Size(113, 17);
            this.lblCoachAddressZip.TabIndex = 53;
            this.lblCoachAddressZip.Text = "Coach Zip Code:";
            // 
            // txtBoxCoachAddressProvince
            // 
            this.txtBoxCoachAddressProvince.Location = new System.Drawing.Point(308, 644);
            this.txtBoxCoachAddressProvince.Name = "txtBoxCoachAddressProvince";
            this.txtBoxCoachAddressProvince.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCoachAddressProvince.TabIndex = 52;
            // 
            // lblCoachAddressProvince
            // 
            this.lblCoachAddressProvince.AutoSize = true;
            this.lblCoachAddressProvince.Location = new System.Drawing.Point(191, 645);
            this.lblCoachAddressProvince.Name = "lblCoachAddressProvince";
            this.lblCoachAddressProvince.Size = new System.Drawing.Size(111, 17);
            this.lblCoachAddressProvince.TabIndex = 51;
            this.lblCoachAddressProvince.Text = "Coach Province:";
            // 
            // txtBoxCoachAddressCity
            // 
            this.txtBoxCoachAddressCity.Location = new System.Drawing.Point(737, 607);
            this.txtBoxCoachAddressCity.Name = "txtBoxCoachAddressCity";
            this.txtBoxCoachAddressCity.Size = new System.Drawing.Size(100, 22);
            this.txtBoxCoachAddressCity.TabIndex = 50;
            // 
            // lblCoachAddressCity
            // 
            this.lblCoachAddressCity.AutoSize = true;
            this.lblCoachAddressCity.Location = new System.Drawing.Point(652, 607);
            this.lblCoachAddressCity.Name = "lblCoachAddressCity";
            this.lblCoachAddressCity.Size = new System.Drawing.Size(79, 17);
            this.lblCoachAddressCity.TabIndex = 49;
            this.lblCoachAddressCity.Text = "Coach City:";
            // 
            // butAddCoachToClub
            // 
            this.butAddCoachToClub.Location = new System.Drawing.Point(680, 710);
            this.butAddCoachToClub.Name = "butAddCoachToClub";
            this.butAddCoachToClub.Size = new System.Drawing.Size(176, 23);
            this.butAddCoachToClub.TabIndex = 56;
            this.butAddCoachToClub.Text = "Add Coach to Club";
            this.butAddCoachToClub.UseVisualStyleBackColor = true;
            this.butAddCoachToClub.Click += new System.EventHandler(this.butAddCoachToClub_Click);
            // 
            // lblCoachClub
            // 
            this.lblCoachClub.AutoSize = true;
            this.lblCoachClub.Location = new System.Drawing.Point(377, 716);
            this.lblCoachClub.Name = "lblCoachClub";
            this.lblCoachClub.Size = new System.Drawing.Size(133, 17);
            this.lblCoachClub.TabIndex = 55;
            this.lblCoachClub.Text = "Select coach to add";
            // 
            // comboBoxSwimmerDOBMonth
            // 
            this.comboBoxSwimmerDOBMonth.FormattingEnabled = true;
            this.comboBoxSwimmerDOBMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxSwimmerDOBMonth.Location = new System.Drawing.Point(756, 495);
            this.comboBoxSwimmerDOBMonth.Name = "comboBoxSwimmerDOBMonth";
            this.comboBoxSwimmerDOBMonth.Size = new System.Drawing.Size(68, 24);
            this.comboBoxSwimmerDOBMonth.TabIndex = 58;
            // 
            // comboBoxSwimmerDOBDay
            // 
            this.comboBoxSwimmerDOBDay.FormattingEnabled = true;
            this.comboBoxSwimmerDOBDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxSwimmerDOBDay.Location = new System.Drawing.Point(830, 495);
            this.comboBoxSwimmerDOBDay.Name = "comboBoxSwimmerDOBDay";
            this.comboBoxSwimmerDOBDay.Size = new System.Drawing.Size(68, 24);
            this.comboBoxSwimmerDOBDay.TabIndex = 59;
            // 
            // txtBoxSwimmerDOBYear
            // 
            this.txtBoxSwimmerDOBYear.Location = new System.Drawing.Point(682, 495);
            this.txtBoxSwimmerDOBYear.Name = "txtBoxSwimmerDOBYear";
            this.txtBoxSwimmerDOBYear.Size = new System.Drawing.Size(64, 22);
            this.txtBoxSwimmerDOBYear.TabIndex = 60;
            // 
            // txtBoxCoachDOBYear
            // 
            this.txtBoxCoachDOBYear.Location = new System.Drawing.Point(663, 678);
            this.txtBoxCoachDOBYear.Name = "txtBoxCoachDOBYear";
            this.txtBoxCoachDOBYear.Size = new System.Drawing.Size(64, 22);
            this.txtBoxCoachDOBYear.TabIndex = 63;
            // 
            // comboBoxCoachDOBDay
            // 
            this.comboBoxCoachDOBDay.FormattingEnabled = true;
            this.comboBoxCoachDOBDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxCoachDOBDay.Location = new System.Drawing.Point(811, 678);
            this.comboBoxCoachDOBDay.Name = "comboBoxCoachDOBDay";
            this.comboBoxCoachDOBDay.Size = new System.Drawing.Size(68, 24);
            this.comboBoxCoachDOBDay.TabIndex = 62;
            // 
            // comboBoxCoachDOBMonth
            // 
            this.comboBoxCoachDOBMonth.FormattingEnabled = true;
            this.comboBoxCoachDOBMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxCoachDOBMonth.Location = new System.Drawing.Point(737, 678);
            this.comboBoxCoachDOBMonth.Name = "comboBoxCoachDOBMonth";
            this.comboBoxCoachDOBMonth.Size = new System.Drawing.Size(68, 24);
            this.comboBoxCoachDOBMonth.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(686, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "By: Raj Adajania () | Sargis Nahapetyan (300904358)";
            // 
            // lblClubInfo
            // 
            this.lblClubInfo.AutoSize = true;
            this.lblClubInfo.Location = new System.Drawing.Point(9, 189);
            this.lblClubInfo.Name = "lblClubInfo";
            this.lblClubInfo.Size = new System.Drawing.Size(136, 17);
            this.lblClubInfo.TabIndex = 65;
            this.lblClubInfo.Text = "Selected Club\'s Info:";
            // 
            // lblClubNameInfo
            // 
            this.lblClubNameInfo.AutoSize = true;
            this.lblClubNameInfo.Location = new System.Drawing.Point(12, 218);
            this.lblClubNameInfo.Name = "lblClubNameInfo";
            this.lblClubNameInfo.Size = new System.Drawing.Size(81, 17);
            this.lblClubNameInfo.TabIndex = 66;
            this.lblClubNameInfo.Text = "Club Name:";
            // 
            // lblClubAddressInfo
            // 
            this.lblClubAddressInfo.AutoSize = true;
            this.lblClubAddressInfo.Location = new System.Drawing.Point(13, 311);
            this.lblClubAddressInfo.Name = "lblClubAddressInfo";
            this.lblClubAddressInfo.Size = new System.Drawing.Size(96, 17);
            this.lblClubAddressInfo.TabIndex = 67;
            this.lblClubAddressInfo.Text = "Club Address:";
            this.lblClubAddressInfo.Click += new System.EventHandler(this.lblClubAddressInfo_Click);
            // 
            // lblClubPhoneNumInfo
            // 
            this.lblClubPhoneNumInfo.AutoSize = true;
            this.lblClubPhoneNumInfo.Location = new System.Drawing.Point(12, 244);
            this.lblClubPhoneNumInfo.Name = "lblClubPhoneNumInfo";
            this.lblClubPhoneNumInfo.Size = new System.Drawing.Size(139, 17);
            this.lblClubPhoneNumInfo.TabIndex = 71;
            this.lblClubPhoneNumInfo.Text = "Club Phone Number:";
            // 
            // lblClubRegInfo
            // 
            this.lblClubRegInfo.AutoSize = true;
            this.lblClubRegInfo.Location = new System.Drawing.Point(12, 285);
            this.lblClubRegInfo.Name = "lblClubRegInfo";
            this.lblClubRegInfo.Size = new System.Drawing.Size(174, 17);
            this.lblClubRegInfo.TabIndex = 72;
            this.lblClubRegInfo.Text = "Club Registration Number:";
            this.lblClubRegInfo.Click += new System.EventHandler(this.lblClubRegInfo_Click);
            // 
            // lstBoxClubsSwimmers
            // 
            this.lstBoxClubsSwimmers.FormattingEnabled = true;
            this.lstBoxClubsSwimmers.ItemHeight = 16;
            this.lstBoxClubsSwimmers.Location = new System.Drawing.Point(233, 189);
            this.lstBoxClubsSwimmers.Name = "lstBoxClubsSwimmers";
            this.lstBoxClubsSwimmers.Size = new System.Drawing.Size(169, 132);
            this.lstBoxClubsSwimmers.TabIndex = 73;
            this.lstBoxClubsSwimmers.SelectedIndexChanged += new System.EventHandler(this.lstBoxClubsSwimmers_SelectedIndexChanged);
            // 
            // lblClubSwimmersInfo
            // 
            this.lblClubSwimmersInfo.AutoSize = true;
            this.lblClubSwimmersInfo.Location = new System.Drawing.Point(234, 160);
            this.lblClubSwimmersInfo.Name = "lblClubSwimmersInfo";
            this.lblClubSwimmersInfo.Size = new System.Drawing.Size(203, 17);
            this.lblClubSwimmersInfo.TabIndex = 74;
            this.lblClubSwimmersInfo.Text = "Selected Club\'s Swimmers Info:";
            // 
            // lblClubSwimmerDOBInfo
            // 
            this.lblClubSwimmerDOBInfo.AutoSize = true;
            this.lblClubSwimmerDOBInfo.Location = new System.Drawing.Point(408, 256);
            this.lblClubSwimmerDOBInfo.Name = "lblClubSwimmerDOBInfo";
            this.lblClubSwimmerDOBInfo.Size = new System.Drawing.Size(151, 17);
            this.lblClubSwimmerDOBInfo.TabIndex = 78;
            this.lblClubSwimmerDOBInfo.Text = "Swimmer Date of Birth:";
            this.lblClubSwimmerDOBInfo.Click += new System.EventHandler(this.lblClubSwimmerDOBInfo_Click);
            // 
            // lblClubSwimmerPhoneNumInfo
            // 
            this.lblClubSwimmerPhoneNumInfo.AutoSize = true;
            this.lblClubSwimmerPhoneNumInfo.Location = new System.Drawing.Point(408, 215);
            this.lblClubSwimmerPhoneNumInfo.Name = "lblClubSwimmerPhoneNumInfo";
            this.lblClubSwimmerPhoneNumInfo.Size = new System.Drawing.Size(167, 17);
            this.lblClubSwimmerPhoneNumInfo.TabIndex = 77;
            this.lblClubSwimmerPhoneNumInfo.Text = "Swimmer Phone Number:";
            // 
            // lblClubSwimmerAddressInfo
            // 
            this.lblClubSwimmerAddressInfo.AutoSize = true;
            this.lblClubSwimmerAddressInfo.Location = new System.Drawing.Point(408, 322);
            this.lblClubSwimmerAddressInfo.Name = "lblClubSwimmerAddressInfo";
            this.lblClubSwimmerAddressInfo.Size = new System.Drawing.Size(124, 17);
            this.lblClubSwimmerAddressInfo.TabIndex = 76;
            this.lblClubSwimmerAddressInfo.Text = "Swimmer Address:";
            this.lblClubSwimmerAddressInfo.Click += new System.EventHandler(this.lblClubSwimmerAddressInfo_Click);
            // 
            // lblClubSwimmerNameInfo
            // 
            this.lblClubSwimmerNameInfo.AutoSize = true;
            this.lblClubSwimmerNameInfo.Location = new System.Drawing.Point(408, 189);
            this.lblClubSwimmerNameInfo.Name = "lblClubSwimmerNameInfo";
            this.lblClubSwimmerNameInfo.Size = new System.Drawing.Size(109, 17);
            this.lblClubSwimmerNameInfo.TabIndex = 75;
            this.lblClubSwimmerNameInfo.Text = "Swimmer Name:";
            // 
            // lblClubSwimmerRegInfo
            // 
            this.lblClubSwimmerRegInfo.AutoSize = true;
            this.lblClubSwimmerRegInfo.Location = new System.Drawing.Point(408, 296);
            this.lblClubSwimmerRegInfo.Name = "lblClubSwimmerRegInfo";
            this.lblClubSwimmerRegInfo.Size = new System.Drawing.Size(202, 17);
            this.lblClubSwimmerRegInfo.TabIndex = 79;
            this.lblClubSwimmerRegInfo.Text = "Swimmer Registration Number:";
            this.lblClubSwimmerRegInfo.Click += new System.EventHandler(this.lblClubSwimmerRegInfo_Click);
            // 
            // lblClubCoachRegInfo
            // 
            this.lblClubCoachRegInfo.AutoSize = true;
            this.lblClubCoachRegInfo.Location = new System.Drawing.Point(811, 296);
            this.lblClubCoachRegInfo.Name = "lblClubCoachRegInfo";
            this.lblClubCoachRegInfo.Size = new System.Drawing.Size(186, 17);
            this.lblClubCoachRegInfo.TabIndex = 86;
            this.lblClubCoachRegInfo.Text = "Coach Registration Number:";
            this.lblClubCoachRegInfo.Click += new System.EventHandler(this.lblClubCoachRegInfo_Click);
            // 
            // lblClubCoachDOBInfo
            // 
            this.lblClubCoachDOBInfo.AutoSize = true;
            this.lblClubCoachDOBInfo.Location = new System.Drawing.Point(811, 256);
            this.lblClubCoachDOBInfo.Name = "lblClubCoachDOBInfo";
            this.lblClubCoachDOBInfo.Size = new System.Drawing.Size(135, 17);
            this.lblClubCoachDOBInfo.TabIndex = 85;
            this.lblClubCoachDOBInfo.Text = "Coach Date of Birth:";
            this.lblClubCoachDOBInfo.Click += new System.EventHandler(this.lblClubCoachDOBInfo_Click);
            // 
            // lblClubCoachPhoneNumInfo
            // 
            this.lblClubCoachPhoneNumInfo.AutoSize = true;
            this.lblClubCoachPhoneNumInfo.Location = new System.Drawing.Point(811, 215);
            this.lblClubCoachPhoneNumInfo.Name = "lblClubCoachPhoneNumInfo";
            this.lblClubCoachPhoneNumInfo.Size = new System.Drawing.Size(151, 17);
            this.lblClubCoachPhoneNumInfo.TabIndex = 84;
            this.lblClubCoachPhoneNumInfo.Text = "Coach Phone Number:";
            // 
            // lblClubCoachAddressInfo
            // 
            this.lblClubCoachAddressInfo.AutoSize = true;
            this.lblClubCoachAddressInfo.Location = new System.Drawing.Point(811, 322);
            this.lblClubCoachAddressInfo.Name = "lblClubCoachAddressInfo";
            this.lblClubCoachAddressInfo.Size = new System.Drawing.Size(108, 17);
            this.lblClubCoachAddressInfo.TabIndex = 83;
            this.lblClubCoachAddressInfo.Text = "Coach Address:";
            this.lblClubCoachAddressInfo.Click += new System.EventHandler(this.lblClubCoachAddressInfo_Click);
            // 
            // lblClubCoachNameInfo
            // 
            this.lblClubCoachNameInfo.AutoSize = true;
            this.lblClubCoachNameInfo.Location = new System.Drawing.Point(811, 189);
            this.lblClubCoachNameInfo.Name = "lblClubCoachNameInfo";
            this.lblClubCoachNameInfo.Size = new System.Drawing.Size(93, 17);
            this.lblClubCoachNameInfo.TabIndex = 82;
            this.lblClubCoachNameInfo.Text = "Coach Name:";
            // 
            // lblClubCoachsInfo
            // 
            this.lblClubCoachsInfo.AutoSize = true;
            this.lblClubCoachsInfo.Location = new System.Drawing.Point(637, 160);
            this.lblClubCoachsInfo.Name = "lblClubCoachsInfo";
            this.lblClubCoachsInfo.Size = new System.Drawing.Size(187, 17);
            this.lblClubCoachsInfo.TabIndex = 81;
            this.lblClubCoachsInfo.Text = "Selected Club\'s Coachs Info:";
            // 
            // lstBoxClubsCoachs
            // 
            this.lstBoxClubsCoachs.FormattingEnabled = true;
            this.lstBoxClubsCoachs.ItemHeight = 16;
            this.lstBoxClubsCoachs.Location = new System.Drawing.Point(636, 189);
            this.lstBoxClubsCoachs.Name = "lstBoxClubsCoachs";
            this.lstBoxClubsCoachs.Size = new System.Drawing.Size(169, 132);
            this.lstBoxClubsCoachs.TabIndex = 80;
            this.lstBoxClubsCoachs.SelectedIndexChanged += new System.EventHandler(this.lstBoxClubsCoachs_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 742);
            this.Controls.Add(this.lblClubCoachRegInfo);
            this.Controls.Add(this.lblClubCoachDOBInfo);
            this.Controls.Add(this.lblClubCoachPhoneNumInfo);
            this.Controls.Add(this.lblClubCoachAddressInfo);
            this.Controls.Add(this.lblClubCoachNameInfo);
            this.Controls.Add(this.lblClubCoachsInfo);
            this.Controls.Add(this.lstBoxClubsCoachs);
            this.Controls.Add(this.lblClubSwimmerRegInfo);
            this.Controls.Add(this.lblClubSwimmerDOBInfo);
            this.Controls.Add(this.lblClubSwimmerPhoneNumInfo);
            this.Controls.Add(this.lblClubSwimmerAddressInfo);
            this.Controls.Add(this.lblClubSwimmerNameInfo);
            this.Controls.Add(this.lblClubSwimmersInfo);
            this.Controls.Add(this.lstBoxClubsSwimmers);
            this.Controls.Add(this.lblClubRegInfo);
            this.Controls.Add(this.lblClubPhoneNumInfo);
            this.Controls.Add(this.lblClubAddressInfo);
            this.Controls.Add(this.lblClubNameInfo);
            this.Controls.Add(this.lblClubInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxCoachDOBYear);
            this.Controls.Add(this.comboBoxCoachDOBDay);
            this.Controls.Add(this.comboBoxCoachDOBMonth);
            this.Controls.Add(this.txtBoxSwimmerDOBYear);
            this.Controls.Add(this.comboBoxSwimmerDOBDay);
            this.Controls.Add(this.comboBoxSwimmerDOBMonth);
            this.Controls.Add(this.butAddCoachToClub);
            this.Controls.Add(this.lblCoachClub);
            this.Controls.Add(this.txtBoxCoachAddressZip);
            this.Controls.Add(this.lblCoachAddressZip);
            this.Controls.Add(this.txtBoxCoachAddressProvince);
            this.Controls.Add(this.lblCoachAddressProvince);
            this.Controls.Add(this.txtBoxCoachAddressCity);
            this.Controls.Add(this.lblCoachAddressCity);
            this.Controls.Add(this.butAddSwimmerToClub);
            this.Controls.Add(this.lblSwimmerClub);
            this.Controls.Add(this.txtBoxSwimmerAddressZip);
            this.Controls.Add(this.lblSwimmerAddressZip);
            this.Controls.Add(this.txtBoxSwimmerAddressProvince);
            this.Controls.Add(this.lblSwimmerAddressProvince);
            this.Controls.Add(this.txtBoxSwimmerAddressCity);
            this.Controls.Add(this.lblSwimmerAddressCity);
            this.Controls.Add(this.txtBoxClubAddressZip);
            this.Controls.Add(this.lblClubAddressZip);
            this.Controls.Add(this.txtBoxClubAddressProvince);
            this.Controls.Add(this.lblClubAddressProvince);
            this.Controls.Add(this.txtBoxClubAddressCity);
            this.Controls.Add(this.lblClubAddressCity);
            this.Controls.Add(this.butAddCoach);
            this.Controls.Add(this.lblCoachDOB);
            this.Controls.Add(this.txtBoxCoachPhoneNum);
            this.Controls.Add(this.lblCoachPhoneNum);
            this.Controls.Add(this.txtBoxCoachAddressStreet);
            this.Controls.Add(this.lblCoachAddressStreet);
            this.Controls.Add(this.txtBoxCoachName);
            this.Controls.Add(this.lblCoachName);
            this.Controls.Add(this.lblLstBoxCoachs);
            this.Controls.Add(this.lstBoxCoachs);
            this.Controls.Add(this.lblLstBoxSwimmers);
            this.Controls.Add(this.lstBoxSwimmers);
            this.Controls.Add(this.lblLstBoxClubs);
            this.Controls.Add(this.butAddSwimmer);
            this.Controls.Add(this.lblSwimmerDOB);
            this.Controls.Add(this.txtBoxSwimmerPhoneNum);
            this.Controls.Add(this.lblSwimmerPhoneNum);
            this.Controls.Add(this.txtBoxSwimmerAddressStreet);
            this.Controls.Add(this.lblSwimmerAddressStreet);
            this.Controls.Add(this.txtBoxSwimmerName);
            this.Controls.Add(this.lblSwimmerName);
            this.Controls.Add(this.butAddClub);
            this.Controls.Add(this.txtBoxClubPhoneNum);
            this.Controls.Add(this.lblClubPhoneNum);
            this.Controls.Add(this.txtBoxClubAddressStreet);
            this.Controls.Add(this.lblClubAddressStreet);
            this.Controls.Add(this.txtBoxClubName);
            this.Controls.Add(this.lblClubName);
            this.Controls.Add(this.lstBoxClubs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BestSwimManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxClubs;
        private System.Windows.Forms.Label lblClubName;
        private System.Windows.Forms.TextBox txtBoxClubName;
        private System.Windows.Forms.Label lblClubAddressStreet;
        private System.Windows.Forms.TextBox txtBoxClubAddressStreet;
        private System.Windows.Forms.Label lblClubPhoneNum;
        private System.Windows.Forms.TextBox txtBoxClubPhoneNum;
        private System.Windows.Forms.Button butAddClub;
        private System.Windows.Forms.TextBox txtBoxSwimmerPhoneNum;
        private System.Windows.Forms.Label lblSwimmerPhoneNum;
        private System.Windows.Forms.TextBox txtBoxSwimmerAddressStreet;
        private System.Windows.Forms.Label lblSwimmerAddressStreet;
        private System.Windows.Forms.TextBox txtBoxSwimmerName;
        private System.Windows.Forms.Label lblSwimmerName;
        private System.Windows.Forms.Label lblSwimmerDOB;
        private System.Windows.Forms.Button butAddSwimmer;
        private System.Windows.Forms.Label lblLstBoxClubs;
        private System.Windows.Forms.Label lblLstBoxSwimmers;
        private System.Windows.Forms.ListBox lstBoxSwimmers;
        private System.Windows.Forms.Label lblLstBoxCoachs;
        private System.Windows.Forms.ListBox lstBoxCoachs;
        private System.Windows.Forms.Button butAddCoach;
        private System.Windows.Forms.Label lblCoachDOB;
        private System.Windows.Forms.TextBox txtBoxCoachPhoneNum;
        private System.Windows.Forms.Label lblCoachPhoneNum;
        private System.Windows.Forms.TextBox txtBoxCoachAddressStreet;
        private System.Windows.Forms.Label lblCoachAddressStreet;
        private System.Windows.Forms.TextBox txtBoxCoachName;
        private System.Windows.Forms.Label lblCoachName;
        private System.Windows.Forms.TextBox txtBoxClubAddressCity;
        private System.Windows.Forms.Label lblClubAddressCity;
        private System.Windows.Forms.TextBox txtBoxClubAddressZip;
        private System.Windows.Forms.Label lblClubAddressZip;
        private System.Windows.Forms.TextBox txtBoxClubAddressProvince;
        private System.Windows.Forms.Label lblClubAddressProvince;
        private System.Windows.Forms.TextBox txtBoxSwimmerAddressCity;
        private System.Windows.Forms.Label lblSwimmerAddressCity;
        private System.Windows.Forms.TextBox txtBoxSwimmerAddressProvince;
        private System.Windows.Forms.Label lblSwimmerAddressProvince;
        private System.Windows.Forms.TextBox txtBoxSwimmerAddressZip;
        private System.Windows.Forms.Label lblSwimmerAddressZip;
        private System.Windows.Forms.Label lblSwimmerClub;
        private System.Windows.Forms.Button butAddSwimmerToClub;
        private System.Windows.Forms.TextBox txtBoxCoachAddressZip;
        private System.Windows.Forms.Label lblCoachAddressZip;
        private System.Windows.Forms.TextBox txtBoxCoachAddressProvince;
        private System.Windows.Forms.Label lblCoachAddressProvince;
        private System.Windows.Forms.TextBox txtBoxCoachAddressCity;
        private System.Windows.Forms.Label lblCoachAddressCity;
        private System.Windows.Forms.Button butAddCoachToClub;
        private System.Windows.Forms.Label lblCoachClub;
        private System.Windows.Forms.ComboBox comboBoxSwimmerDOBMonth;
        private System.Windows.Forms.ComboBox comboBoxSwimmerDOBDay;
        private System.Windows.Forms.TextBox txtBoxSwimmerDOBYear;
        private System.Windows.Forms.TextBox txtBoxCoachDOBYear;
        private System.Windows.Forms.ComboBox comboBoxCoachDOBDay;
        private System.Windows.Forms.ComboBox comboBoxCoachDOBMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClubInfo;
        private System.Windows.Forms.Label lblClubNameInfo;
        private System.Windows.Forms.Label lblClubAddressInfo;
        private System.Windows.Forms.Label lblClubPhoneNumInfo;
        private System.Windows.Forms.Label lblClubRegInfo;
        private System.Windows.Forms.ListBox lstBoxClubsSwimmers;
        private System.Windows.Forms.Label lblClubSwimmersInfo;
        private System.Windows.Forms.Label lblClubSwimmerDOBInfo;
        private System.Windows.Forms.Label lblClubSwimmerPhoneNumInfo;
        private System.Windows.Forms.Label lblClubSwimmerAddressInfo;
        private System.Windows.Forms.Label lblClubSwimmerNameInfo;
        private System.Windows.Forms.Label lblClubSwimmerRegInfo;
        private System.Windows.Forms.Label lblClubCoachRegInfo;
        private System.Windows.Forms.Label lblClubCoachDOBInfo;
        private System.Windows.Forms.Label lblClubCoachPhoneNumInfo;
        private System.Windows.Forms.Label lblClubCoachAddressInfo;
        private System.Windows.Forms.Label lblClubCoachNameInfo;
        private System.Windows.Forms.Label lblClubCoachsInfo;
        private System.Windows.Forms.ListBox lstBoxClubsCoachs;
    }
}

