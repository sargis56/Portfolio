namespace _300904358_Nahapetyan__ASS1
{
    partial class SubscribeForm
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
            this.SubBut = new System.Windows.Forms.Button();
            this.UnsubBut = new System.Windows.Forms.Button();
            this.CancelBut = new System.Windows.Forms.Button();
            this.emailMessageChBx = new System.Windows.Forms.CheckBox();
            this.messageMobileChBx = new System.Windows.Forms.CheckBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.errorEmailLabel = new System.Windows.Forms.Label();
            this.errorMobileLabel = new System.Windows.Forms.Label();
            this.emailPictureBox = new System.Windows.Forms.PictureBox();
            this.mobilePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.emailPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SubBut
            // 
            this.SubBut.Location = new System.Drawing.Point(11, 228);
            this.SubBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubBut.Name = "SubBut";
            this.SubBut.Size = new System.Drawing.Size(121, 26);
            this.SubBut.TabIndex = 0;
            this.SubBut.Text = "Subscribe";
            this.SubBut.UseVisualStyleBackColor = true;
            this.SubBut.Click += new System.EventHandler(this.SubBut_Click);
            // 
            // UnsubBut
            // 
            this.UnsubBut.Location = new System.Drawing.Point(188, 228);
            this.UnsubBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnsubBut.Name = "UnsubBut";
            this.UnsubBut.Size = new System.Drawing.Size(121, 26);
            this.UnsubBut.TabIndex = 1;
            this.UnsubBut.Text = "Unsubscribe";
            this.UnsubBut.UseVisualStyleBackColor = true;
            this.UnsubBut.Click += new System.EventHandler(this.UnsubBut_Click);
            // 
            // CancelBut
            // 
            this.CancelBut.Location = new System.Drawing.Point(355, 228);
            this.CancelBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(115, 26);
            this.CancelBut.TabIndex = 2;
            this.CancelBut.Text = "Cancel";
            this.CancelBut.UseVisualStyleBackColor = true;
            this.CancelBut.Click += new System.EventHandler(this.CancelBut_Click);
            // 
            // emailMessageChBx
            // 
            this.emailMessageChBx.AutoSize = true;
            this.emailMessageChBx.Location = new System.Drawing.Point(35, 58);
            this.emailMessageChBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailMessageChBx.Name = "emailMessageChBx";
            this.emailMessageChBx.Size = new System.Drawing.Size(177, 21);
            this.emailMessageChBx.TabIndex = 3;
            this.emailMessageChBx.Text = "Message Sent by Email";
            this.emailMessageChBx.UseVisualStyleBackColor = true;
            this.emailMessageChBx.CheckedChanged += new System.EventHandler(this.emailMessageChBx_CheckedChanged);
            // 
            // messageMobileChBx
            // 
            this.messageMobileChBx.AutoSize = true;
            this.messageMobileChBx.Location = new System.Drawing.Point(35, 132);
            this.messageMobileChBx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.messageMobileChBx.Name = "messageMobileChBx";
            this.messageMobileChBx.Size = new System.Drawing.Size(184, 21);
            this.messageMobileChBx.TabIndex = 4;
            this.messageMobileChBx.Text = "Message Sent by Mobile";
            this.messageMobileChBx.UseVisualStyleBackColor = true;
            this.messageMobileChBx.CheckedChanged += new System.EventHandler(this.messageMobileChBx_CheckedChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(243, 55);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(189, 22);
            this.emailTextBox.TabIndex = 5;
            this.emailTextBox.Text = "Email Address";
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(243, 129);
            this.mobileTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(189, 22);
            this.mobileTextBox.TabIndex = 6;
            this.mobileTextBox.Text = "xxx-xxx-xxxx";
            // 
            // errorEmailLabel
            // 
            this.errorEmailLabel.AutoSize = true;
            this.errorEmailLabel.ForeColor = System.Drawing.Color.Red;
            this.errorEmailLabel.Location = new System.Drawing.Point(243, 95);
            this.errorEmailLabel.Name = "errorEmailLabel";
            this.errorEmailLabel.Size = new System.Drawing.Size(140, 17);
            this.errorEmailLabel.TabIndex = 7;
            this.errorEmailLabel.Text = "Invalid email address";
            this.errorEmailLabel.Visible = false;
            // 
            // errorMobileLabel
            // 
            this.errorMobileLabel.AutoSize = true;
            this.errorMobileLabel.ForeColor = System.Drawing.Color.Red;
            this.errorMobileLabel.Location = new System.Drawing.Point(243, 171);
            this.errorMobileLabel.Name = "errorMobileLabel";
            this.errorMobileLabel.Size = new System.Drawing.Size(144, 17);
            this.errorMobileLabel.TabIndex = 8;
            this.errorMobileLabel.Text = "Invalid phone number";
            this.errorMobileLabel.Visible = false;
            // 
            // emailPictureBox
            // 
            this.emailPictureBox.Image = global::_300904358_Nahapetyan__ASS1.Properties.Resources.Check_Mark_Symbol_Yes_Ok_Choice_114456;
            this.emailPictureBox.Location = new System.Drawing.Point(440, 42);
            this.emailPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailPictureBox.Name = "emailPictureBox";
            this.emailPictureBox.Size = new System.Drawing.Size(59, 38);
            this.emailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emailPictureBox.TabIndex = 9;
            this.emailPictureBox.TabStop = false;
            this.emailPictureBox.Visible = false;
            // 
            // mobilePictureBox
            // 
            this.mobilePictureBox.Image = global::_300904358_Nahapetyan__ASS1.Properties.Resources.Check_Mark_Symbol_Yes_Ok_Choice_114456;
            this.mobilePictureBox.Location = new System.Drawing.Point(440, 116);
            this.mobilePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.mobilePictureBox.Name = "mobilePictureBox";
            this.mobilePictureBox.Size = new System.Drawing.Size(59, 38);
            this.mobilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mobilePictureBox.TabIndex = 10;
            this.mobilePictureBox.TabStop = false;
            this.mobilePictureBox.Visible = false;
            // 
            // SubscribeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 273);
            this.Controls.Add(this.mobilePictureBox);
            this.Controls.Add(this.emailPictureBox);
            this.Controls.Add(this.errorMobileLabel);
            this.Controls.Add(this.errorEmailLabel);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.messageMobileChBx);
            this.Controls.Add(this.emailMessageChBx);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.UnsubBut);
            this.Controls.Add(this.SubBut);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SubscribeForm";
            this.Text = "Subscribe Form";
            ((System.ComponentModel.ISupportInitialize)(this.emailPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubBut;
        private System.Windows.Forms.Button UnsubBut;
        private System.Windows.Forms.Button CancelBut;
        private System.Windows.Forms.CheckBox emailMessageChBx;
        private System.Windows.Forms.CheckBox messageMobileChBx;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.Label errorEmailLabel;
        private System.Windows.Forms.Label errorMobileLabel;
        private System.Windows.Forms.PictureBox emailPictureBox;
        private System.Windows.Forms.PictureBox mobilePictureBox;
    }
}