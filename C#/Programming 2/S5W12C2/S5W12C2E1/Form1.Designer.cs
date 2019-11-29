namespace S5W12C2E1
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
            this.lsbShape = new System.Windows.Forms.ListBox();
            this.lblSelection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbShape
            // 
            this.lsbShape.FormattingEnabled = true;
            this.lsbShape.Items.AddRange(new object[] {
            "Circle",
            "Triangle",
            "Rectengle"});
            this.lsbShape.Location = new System.Drawing.Point(13, 13);
            this.lsbShape.Name = "lsbShape";
            this.lsbShape.Size = new System.Drawing.Size(120, 95);
            this.lsbShape.TabIndex = 0;
            this.lsbShape.SelectedIndexChanged += new System.EventHandler(this.lsbShape_SelectedIndexChanged);
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Location = new System.Drawing.Point(152, 13);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(35, 13);
            this.lblSelection.TabIndex = 1;
            this.lblSelection.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.lsbShape);
            this.Name = "Form1";
            this.Text = "                     ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbShape;
        private System.Windows.Forms.Label lblSelection;
    }
}

