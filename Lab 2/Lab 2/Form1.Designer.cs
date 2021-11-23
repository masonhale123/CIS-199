namespace Lab_2
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
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTip1 = new System.Windows.Forms.Label();
            this.labelTip2 = new System.Windows.Forms.Label();
            this.labelTip3 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxTip1 = new System.Windows.Forms.TextBox();
            this.textBoxTip2 = new System.Windows.Forms.TextBox();
            this.textBoxTip3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(117, 224);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 0;
            this.buttonCalc.Text = "Calculate tip";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(43, 44);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(98, 13);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Enter price of meal:";
            // 
            // labelTip1
            // 
            this.labelTip1.AutoSize = true;
            this.labelTip1.Location = new System.Drawing.Point(114, 85);
            this.labelTip1.Name = "labelTip1";
            this.labelTip1.Size = new System.Drawing.Size(27, 13);
            this.labelTip1.TabIndex = 2;
            this.labelTip1.Text = "15%";
            // 
            // labelTip2
            // 
            this.labelTip2.AutoSize = true;
            this.labelTip2.Location = new System.Drawing.Point(114, 128);
            this.labelTip2.Name = "labelTip2";
            this.labelTip2.Size = new System.Drawing.Size(27, 13);
            this.labelTip2.TabIndex = 3;
            this.labelTip2.Text = "18%";
            // 
            // labelTip3
            // 
            this.labelTip3.AutoSize = true;
            this.labelTip3.Location = new System.Drawing.Point(117, 173);
            this.labelTip3.Name = "labelTip3";
            this.labelTip3.Size = new System.Drawing.Size(27, 13);
            this.labelTip3.TabIndex = 4;
            this.labelTip3.Text = "20%";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(147, 44);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 5;
            // 
            // textBoxTip1
            // 
            this.textBoxTip1.Location = new System.Drawing.Point(147, 85);
            this.textBoxTip1.Name = "textBoxTip1";
            this.textBoxTip1.ReadOnly = true;
            this.textBoxTip1.Size = new System.Drawing.Size(100, 20);
            this.textBoxTip1.TabIndex = 6;
            // 
            // textBoxTip2
            // 
            this.textBoxTip2.Location = new System.Drawing.Point(147, 128);
            this.textBoxTip2.Name = "textBoxTip2";
            this.textBoxTip2.ReadOnly = true;
            this.textBoxTip2.Size = new System.Drawing.Size(100, 20);
            this.textBoxTip2.TabIndex = 7;
            // 
            // textBoxTip3
            // 
            this.textBoxTip3.Location = new System.Drawing.Point(147, 173);
            this.textBoxTip3.Name = "textBoxTip3";
            this.textBoxTip3.ReadOnly = true;
            this.textBoxTip3.Size = new System.Drawing.Size(100, 20);
            this.textBoxTip3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 278);
            this.Controls.Add(this.textBoxTip3);
            this.Controls.Add(this.textBoxTip2);
            this.Controls.Add(this.textBoxTip1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelTip3);
            this.Controls.Add(this.labelTip2);
            this.Controls.Add(this.labelTip1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonCalc);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTip1;
        private System.Windows.Forms.Label labelTip2;
        private System.Windows.Forms.Label labelTip3;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxTip1;
        private System.Windows.Forms.TextBox textBoxTip2;
        private System.Windows.Forms.TextBox textBoxTip3;
    }
}

