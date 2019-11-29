namespace S5W12C2E4
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
            this.cbtnHappy = new System.Windows.Forms.CheckBox();
            this.lblFeel = new System.Windows.Forms.Label();
            this.lblHow = new System.Windows.Forms.Label();
            this.rbtnCouldBeBetter = new System.Windows.Forms.RadioButton();
            this.rbtnGood = new System.Windows.Forms.RadioButton();
            this.rbtnExcellent = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbtnHappy
            // 
            this.cbtnHappy.AutoSize = true;
            this.cbtnHappy.Location = new System.Drawing.Point(13, 13);
            this.cbtnHappy.Name = "cbtnHappy";
            this.cbtnHappy.Size = new System.Drawing.Size(57, 17);
            this.cbtnHappy.TabIndex = 0;
            this.cbtnHappy.Text = "Happy";
            this.cbtnHappy.UseVisualStyleBackColor = true;
            this.cbtnHappy.CheckedChanged += new System.EventHandler(this.cbtnHappy_CheckedChanged);
            // 
            // lblFeel
            // 
            this.lblFeel.AutoSize = true;
            this.lblFeel.Location = new System.Drawing.Point(7, 212);
            this.lblFeel.Name = "lblFeel";
            this.lblFeel.Size = new System.Drawing.Size(0, 13);
            this.lblFeel.TabIndex = 1;
            // 
            // lblHow
            // 
            this.lblHow.AutoSize = true;
            this.lblHow.Location = new System.Drawing.Point(9, 239);
            this.lblHow.Name = "lblHow";
            this.lblHow.Size = new System.Drawing.Size(0, 13);
            this.lblHow.TabIndex = 5;
            // 
            // rbtnCouldBeBetter
            // 
            this.rbtnCouldBeBetter.AutoSize = true;
            this.rbtnCouldBeBetter.Location = new System.Drawing.Point(20, 67);
            this.rbtnCouldBeBetter.Name = "rbtnCouldBeBetter";
            this.rbtnCouldBeBetter.Size = new System.Drawing.Size(97, 17);
            this.rbtnCouldBeBetter.TabIndex = 4;
            this.rbtnCouldBeBetter.TabStop = true;
            this.rbtnCouldBeBetter.Text = "Could be better";
            this.rbtnCouldBeBetter.UseVisualStyleBackColor = true;
            this.rbtnCouldBeBetter.CheckedChanged += new System.EventHandler(this.rbtnExcellent_CheckedChanged);
            // 
            // rbtnGood
            // 
            this.rbtnGood.AutoSize = true;
            this.rbtnGood.Location = new System.Drawing.Point(20, 43);
            this.rbtnGood.Name = "rbtnGood";
            this.rbtnGood.Size = new System.Drawing.Size(51, 17);
            this.rbtnGood.TabIndex = 3;
            this.rbtnGood.TabStop = true;
            this.rbtnGood.Text = "Good";
            this.rbtnGood.UseVisualStyleBackColor = true;
            this.rbtnGood.CheckedChanged += new System.EventHandler(this.rbtnExcellent_CheckedChanged);
            // 
            // rbtnExcellent
            // 
            this.rbtnExcellent.AutoSize = true;
            this.rbtnExcellent.Location = new System.Drawing.Point(20, 19);
            this.rbtnExcellent.Name = "rbtnExcellent";
            this.rbtnExcellent.Size = new System.Drawing.Size(68, 17);
            this.rbtnExcellent.TabIndex = 2;
            this.rbtnExcellent.TabStop = true;
            this.rbtnExcellent.Text = "Excellent";
            this.rbtnExcellent.UseVisualStyleBackColor = true;
            this.rbtnExcellent.CheckedChanged += new System.EventHandler(this.rbtnExcellent_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnExcellent);
            this.groupBox1.Controls.Add(this.rbtnGood);
            this.groupBox1.Controls.Add(this.rbtnCouldBeBetter);
            this.groupBox1.Location = new System.Drawing.Point(10, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "How do you feel?";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHow);
            this.Controls.Add(this.lblFeel);
            this.Controls.Add(this.cbtnHappy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CursorChanged += new System.EventHandler(this.rbtnExcellent_CheckedChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbtnHappy;
        private System.Windows.Forms.Label lblFeel;
        private System.Windows.Forms.Label lblHow;
        private System.Windows.Forms.RadioButton rbtnCouldBeBetter;
        private System.Windows.Forms.RadioButton rbtnGood;
        private System.Windows.Forms.RadioButton rbtnExcellent;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

