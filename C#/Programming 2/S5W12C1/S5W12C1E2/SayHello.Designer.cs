namespace S5W12C1E2
{
    partial class SayHello
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.butSayHello = new System.Windows.Forms.Button();
            this.lblGretting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // butSayHello
            // 
            this.butSayHello.Location = new System.Drawing.Point(13, 43);
            this.butSayHello.Name = "butSayHello";
            this.butSayHello.Size = new System.Drawing.Size(75, 23);
            this.butSayHello.TabIndex = 2;
            this.butSayHello.Text = "Say Hello";
            this.butSayHello.UseVisualStyleBackColor = true;
            this.butSayHello.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGretting
            // 
            this.lblGretting.AutoSize = true;
            this.lblGretting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGretting.Location = new System.Drawing.Point(16, 82);
            this.lblGretting.Name = "lblGretting";
            this.lblGretting.Size = new System.Drawing.Size(0, 20);
            this.lblGretting.TabIndex = 3;
            // 
            // SayHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblGretting);
            this.Controls.Add(this.butSayHello);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "SayHello";
            this.Text = "SayHello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button butSayHello;
        private System.Windows.Forms.Label lblGretting;
    }
}