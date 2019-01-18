namespace _2.CircleArea
{
    partial class AreaOfCircle
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
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.LblArea = new System.Windows.Forms.Label();
            this.btm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(107, 23);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(199, 20);
            this.txtRadius.TabIndex = 0;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(107, 64);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(199, 20);
            this.txtArea.TabIndex = 1;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(29, 23);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(62, 13);
            this.lblRadius.TabIndex = 2;
            this.lblRadius.Text = "Radius(mm)";
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Location = new System.Drawing.Point(32, 70);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(65, 13);
            this.LblArea.TabIndex = 3;
            this.LblArea.Text = "Area(sq mm)";
            // 
            // btm
            // 
            this.btm.Location = new System.Drawing.Point(144, 101);
            this.btm.Name = "btm";
            this.btm.Size = new System.Drawing.Size(118, 23);
            this.btm.TabIndex = 4;
            this.btm.Text = "Calculate Area";
            this.btm.UseVisualStyleBackColor = true;
            this.btm.Click += new System.EventHandler(this.btm_Click);
            // 
            // AreaOfCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 157);
            this.Controls.Add(this.btm);
            this.Controls.Add(this.LblArea);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtRadius);
            this.Name = "AreaOfCircle";
            this.Text = "AreaOfCircle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.Button btm;
    }
}

