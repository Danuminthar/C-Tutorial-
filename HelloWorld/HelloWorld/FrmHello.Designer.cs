namespace HelloWorld
{
    partial class FrmHello
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
            this.LblHelloWorld = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblHelloWorld
            // 
            this.LblHelloWorld.AutoSize = true;
            this.LblHelloWorld.Location = new System.Drawing.Point(30, 67);
            this.LblHelloWorld.Name = "LblHelloWorld";
            this.LblHelloWorld.Size = new System.Drawing.Size(59, 13);
            this.LblHelloWorld.TabIndex = 0;
            this.LblHelloWorld.Text = "HelloWorld";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(106, 67);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 1;
            this.txt.Text = "Hello World";
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(106, 148);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100, 33);
            this.button.TabIndex = 2;
            this.button.Text = "HelloWorld";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // FrmHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 269);
            this.Controls.Add(this.button);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.LblHelloWorld);
            this.Name = "FrmHello";
            this.Text = "HelloWorld";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHelloWorld;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button button;
    }
}

