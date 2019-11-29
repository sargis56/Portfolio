namespace ShapesGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.lsbShapes = new System.Windows.Forms.ListBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnAddShape = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shapes";
            // 
            // lsbShapes
            // 
            this.lsbShapes.FormattingEnabled = true;
            this.lsbShapes.Location = new System.Drawing.Point(13, 30);
            this.lsbShapes.Name = "lsbShapes";
            this.lsbShapes.Size = new System.Drawing.Size(121, 147);
            this.lsbShapes.TabIndex = 1;
            this.lsbShapes.SelectedIndexChanged += new System.EventHandler(this.lsbShapes_SelectedIndexChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(158, 30);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 13);
            this.lblArea.TabIndex = 2;
            // 
            // btnAddShape
            // 
            this.btnAddShape.Location = new System.Drawing.Point(13, 194);
            this.btnAddShape.Name = "btnAddShape";
            this.btnAddShape.Size = new System.Drawing.Size(75, 23);
            this.btnAddShape.TabIndex = 3;
            this.btnAddShape.Text = "Add Shape";
            this.btnAddShape.UseVisualStyleBackColor = true;
            this.btnAddShape.Click += new System.EventHandler(this.btnAddShape_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 290);
            this.Controls.Add(this.btnAddShape);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lsbShapes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbShapes;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnAddShape;
    }
}

