namespace S5W12C2E2
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
            this.lsbShapes = new System.Windows.Forms.ListBox();
            this.lblSelection = new System.Windows.Forms.Label();
            this.labal1 = new System.Windows.Forms.Label();
            this.txtShapeName = new System.Windows.Forms.TextBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.butRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbShapes
            // 
            this.lsbShapes.FormattingEnabled = true;
            this.lsbShapes.Location = new System.Drawing.Point(13, 13);
            this.lsbShapes.Name = "lsbShapes";
            this.lsbShapes.Size = new System.Drawing.Size(120, 121);
            this.lsbShapes.TabIndex = 0;
            this.lsbShapes.SelectedIndexChanged += new System.EventHandler(this.lsbShapes_SelectedIndexChanged);
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Location = new System.Drawing.Point(13, 237);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(35, 13);
            this.lblSelection.TabIndex = 1;
            this.lblSelection.Text = "label1";
            this.lblSelection.Click += new System.EventHandler(this.lblSelection_Click);
            // 
            // labal1
            // 
            this.labal1.AutoSize = true;
            this.labal1.Location = new System.Drawing.Point(157, 13);
            this.labal1.Name = "labal1";
            this.labal1.Size = new System.Drawing.Size(81, 13);
            this.labal1.TabIndex = 2;
            this.labal1.Text = "Enter a Shape: ";
            // 
            // txtShapeName
            // 
            this.txtShapeName.Location = new System.Drawing.Point(244, 10);
            this.txtShapeName.Name = "txtShapeName";
            this.txtShapeName.Size = new System.Drawing.Size(134, 20);
            this.txtShapeName.TabIndex = 3;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(160, 40);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 23);
            this.butAdd.TabIndex = 4;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butRemove
            // 
            this.butRemove.Location = new System.Drawing.Point(16, 141);
            this.butRemove.Name = "butRemove";
            this.butRemove.Size = new System.Drawing.Size(117, 23);
            this.butRemove.TabIndex = 5;
            this.butRemove.Text = "Remove Item";
            this.butRemove.UseVisualStyleBackColor = true;
            this.butRemove.Click += new System.EventHandler(this.butRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 279);
            this.Controls.Add(this.butRemove);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.txtShapeName);
            this.Controls.Add(this.labal1);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.lsbShapes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbShapes;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Label labal1;
        private System.Windows.Forms.TextBox txtShapeName;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butRemove;
    }
}

