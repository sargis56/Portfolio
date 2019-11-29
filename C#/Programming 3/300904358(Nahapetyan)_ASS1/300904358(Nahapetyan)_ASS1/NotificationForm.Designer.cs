namespace _300904358_Nahapetyan__ASS1
{
    partial class NotificationForm
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
            this.ManageSubBut = new System.Windows.Forms.Button();
            this.ClosseBut = new System.Windows.Forms.Button();
            this.PublishNoteBut = new System.Windows.Forms.Button();
            this.listBoxEmails = new System.Windows.Forms.ListBox();
            this.listBoxPhoneNums = new System.Windows.Forms.ListBox();
            this.labelListEmails = new System.Windows.Forms.Label();
            this.labelListMobile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ManageSubBut
            // 
            this.ManageSubBut.Location = new System.Drawing.Point(35, 96);
            this.ManageSubBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ManageSubBut.Name = "ManageSubBut";
            this.ManageSubBut.Size = new System.Drawing.Size(160, 48);
            this.ManageSubBut.TabIndex = 0;
            this.ManageSubBut.Text = "Manage Subscription";
            this.ManageSubBut.UseVisualStyleBackColor = true;
            this.ManageSubBut.Click += new System.EventHandler(this.ManageSubBut_Click);
            // 
            // ClosseBut
            // 
            this.ClosseBut.Location = new System.Drawing.Point(460, 96);
            this.ClosseBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClosseBut.Name = "ClosseBut";
            this.ClosseBut.Size = new System.Drawing.Size(104, 47);
            this.ClosseBut.TabIndex = 1;
            this.ClosseBut.Text = "Exit";
            this.ClosseBut.UseVisualStyleBackColor = true;
            this.ClosseBut.Click += new System.EventHandler(this.ClosseBut_Click);
            // 
            // PublishNoteBut
            // 
            this.PublishNoteBut.Enabled = false;
            this.PublishNoteBut.Location = new System.Drawing.Point(238, 95);
            this.PublishNoteBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PublishNoteBut.Name = "PublishNoteBut";
            this.PublishNoteBut.Size = new System.Drawing.Size(160, 48);
            this.PublishNoteBut.TabIndex = 2;
            this.PublishNoteBut.Text = "Publish Notification";
            this.PublishNoteBut.UseVisualStyleBackColor = true;
            this.PublishNoteBut.Click += new System.EventHandler(this.PublishNoteBut_Click);
            // 
            // listBoxEmails
            // 
            this.listBoxEmails.FormattingEnabled = true;
            this.listBoxEmails.ItemHeight = 16;
            this.listBoxEmails.Location = new System.Drawing.Point(72, 224);
            this.listBoxEmails.Name = "listBoxEmails";
            this.listBoxEmails.Size = new System.Drawing.Size(218, 84);
            this.listBoxEmails.TabIndex = 3;
            // 
            // listBoxPhoneNums
            // 
            this.listBoxPhoneNums.FormattingEnabled = true;
            this.listBoxPhoneNums.ItemHeight = 16;
            this.listBoxPhoneNums.Location = new System.Drawing.Point(346, 224);
            this.listBoxPhoneNums.Name = "listBoxPhoneNums";
            this.listBoxPhoneNums.Size = new System.Drawing.Size(218, 84);
            this.listBoxPhoneNums.TabIndex = 4;
            // 
            // labelListEmails
            // 
            this.labelListEmails.AutoSize = true;
            this.labelListEmails.Location = new System.Drawing.Point(69, 204);
            this.labelListEmails.Name = "labelListEmails";
            this.labelListEmails.Size = new System.Drawing.Size(53, 17);
            this.labelListEmails.TabIndex = 5;
            this.labelListEmails.Text = "Emails:";
            // 
            // labelListMobile
            // 
            this.labelListMobile.AutoSize = true;
            this.labelListMobile.Location = new System.Drawing.Point(343, 204);
            this.labelListMobile.Name = "labelListMobile";
            this.labelListMobile.Size = new System.Drawing.Size(114, 17);
            this.labelListMobile.TabIndex = 6;
            this.labelListMobile.Text = "Phone Numbers:";
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 351);
            this.Controls.Add(this.labelListMobile);
            this.Controls.Add(this.labelListEmails);
            this.Controls.Add(this.listBoxPhoneNums);
            this.Controls.Add(this.listBoxEmails);
            this.Controls.Add(this.PublishNoteBut);
            this.Controls.Add(this.ClosseBut);
            this.Controls.Add(this.ManageSubBut);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NotificationForm";
            this.Text = "Notification Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ManageSubBut;
        private System.Windows.Forms.Button ClosseBut;
        private System.Windows.Forms.Button PublishNoteBut;
        private System.Windows.Forms.ListBox listBoxEmails;
        private System.Windows.Forms.ListBox listBoxPhoneNums;
        private System.Windows.Forms.Label labelListEmails;
        private System.Windows.Forms.Label labelListMobile;
    }
}

