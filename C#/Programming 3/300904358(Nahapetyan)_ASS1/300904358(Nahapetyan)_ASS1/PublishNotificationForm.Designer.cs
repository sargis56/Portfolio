namespace _300904358_Nahapetyan__ASS1
{
    partial class PublishNotificationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NoteConTextBox = new System.Windows.Forms.TextBox();
            this.PublishBut = new System.Windows.Forms.Button();
            this.ExitBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notification Content";
            // 
            // NoteConTextBox
            // 
            this.NoteConTextBox.Location = new System.Drawing.Point(134, 62);
            this.NoteConTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NoteConTextBox.Name = "NoteConTextBox";
            this.NoteConTextBox.Size = new System.Drawing.Size(172, 20);
            this.NoteConTextBox.TabIndex = 1;
            // 
            // PublishBut
            // 
            this.PublishBut.Location = new System.Drawing.Point(62, 129);
            this.PublishBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PublishBut.Name = "PublishBut";
            this.PublishBut.Size = new System.Drawing.Size(61, 24);
            this.PublishBut.TabIndex = 2;
            this.PublishBut.Text = "Publish";
            this.PublishBut.UseVisualStyleBackColor = true;
            this.PublishBut.Click += new System.EventHandler(this.PublishBut_Click);
            // 
            // ExitBut
            // 
            this.ExitBut.Location = new System.Drawing.Point(184, 129);
            this.ExitBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(64, 24);
            this.ExitBut.TabIndex = 3;
            this.ExitBut.Text = "Exit";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // PublishNotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 183);
            this.Controls.Add(this.ExitBut);
            this.Controls.Add(this.PublishBut);
            this.Controls.Add(this.NoteConTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PublishNotificationForm";
            this.Text = "Publish Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NoteConTextBox;
        private System.Windows.Forms.Button PublishBut;
        private System.Windows.Forms.Button ExitBut;
    }
}