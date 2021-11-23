namespace Program_2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textWght = new System.Windows.Forms.TextBox();
            this.textDay = new System.Windows.Forms.TextBox();
            this.textDis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAcost = new System.Windows.Forms.Label();
            this.lblBcost = new System.Windows.Forms.Label();
            this.lblCcost = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distance (Miles)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Delivery Days";
            // 
            // textWght
            // 
            this.textWght.Location = new System.Drawing.Point(199, 99);
            this.textWght.Name = "textWght";
            this.textWght.Size = new System.Drawing.Size(100, 20);
            this.textWght.TabIndex = 3;
            // 
            // textDay
            // 
            this.textDay.Location = new System.Drawing.Point(199, 241);
            this.textDay.Name = "textDay";
            this.textDay.Size = new System.Drawing.Size(100, 20);
            this.textDay.TabIndex = 4;
            // 
            // textDis
            // 
            this.textDis.Location = new System.Drawing.Point(199, 172);
            this.textDis.Name = "textDis";
            this.textDis.Size = new System.Drawing.Size(100, 20);
            this.textDis.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Company A Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Company B Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Company C Cost";
            // 
            // lblAcost
            // 
            this.lblAcost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAcost.Location = new System.Drawing.Point(181, 31);
            this.lblAcost.Name = "lblAcost";
            this.lblAcost.Size = new System.Drawing.Size(100, 23);
            this.lblAcost.TabIndex = 9;
            this.lblAcost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBcost
            // 
            this.lblBcost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBcost.Location = new System.Drawing.Point(181, 109);
            this.lblBcost.Name = "lblBcost";
            this.lblBcost.Size = new System.Drawing.Size(100, 23);
            this.lblBcost.TabIndex = 10;
            this.lblBcost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCcost
            // 
            this.lblCcost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCcost.Location = new System.Drawing.Point(181, 178);
            this.lblCcost.Name = "lblCcost";
            this.lblCcost.Size = new System.Drawing.Size(100, 23);
            this.lblCcost.TabIndex = 11;
            this.lblCcost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLow
            // 
            this.lblLow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLow.Location = new System.Drawing.Point(51, 256);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(230, 31);
            this.lblLow.TabIndex = 12;
            this.lblLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calculate Cost";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLow);
            this.groupBox1.Controls.Add(this.lblCcost);
            this.groupBox1.Controls.Add(this.lblBcost);
            this.groupBox1.Controls.Add(this.lblAcost);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(381, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 323);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textDis);
            this.Controls.Add(this.textDay);
            this.Controls.Add(this.textWght);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Program 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textWght;
        private System.Windows.Forms.TextBox textDay;
        private System.Windows.Forms.TextBox textDis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAcost;
        private System.Windows.Forms.Label lblBcost;
        private System.Windows.Forms.Label lblCcost;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

