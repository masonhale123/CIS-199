namespace Program_1
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
            this.maxwidth = new System.Windows.Forms.Label();
            this.maxlength = new System.Windows.Forms.Label();
            this.hardwoodprice = new System.Windows.Forms.Label();
            this.underlayment = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.sqYardslbl = new System.Windows.Forms.Label();
            this.hwCostlbl = new System.Windows.Forms.Label();
            this.underlayCostlbl = new System.Windows.Forms.Label();
            this.laborcostlbl = new System.Windows.Forms.Label();
            this.totallbl = new System.Windows.Forms.Label();
            this.maxWidthtb = new System.Windows.Forms.TextBox();
            this.maxLengthtb = new System.Windows.Forms.TextBox();
            this.hardwoodPricetb = new System.Windows.Forms.TextBox();
            this.underlayTb = new System.Windows.Forms.TextBox();
            this.firstRoomTb = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EZ-Hardwood Flooring Estimator";
            // 
            // maxwidth
            // 
            this.maxwidth.AutoSize = true;
            this.maxwidth.Location = new System.Drawing.Point(40, 52);
            this.maxwidth.Name = "maxwidth";
            this.maxwidth.Size = new System.Drawing.Size(119, 13);
            this.maxwidth.TabIndex = 1;
            this.maxwidth.Text = "Max Width of Room (ft):";
            // 
            // maxlength
            // 
            this.maxlength.AutoSize = true;
            this.maxlength.Location = new System.Drawing.Point(35, 88);
            this.maxlength.Name = "maxlength";
            this.maxlength.Size = new System.Drawing.Size(124, 13);
            this.maxlength.TabIndex = 2;
            this.maxlength.Text = "Max Length of Room (ft):";
            // 
            // hardwoodprice
            // 
            this.hardwoodprice.AutoSize = true;
            this.hardwoodprice.Location = new System.Drawing.Point(35, 125);
            this.hardwoodprice.Name = "hardwoodprice";
            this.hardwoodprice.Size = new System.Drawing.Size(123, 13);
            this.hardwoodprice.TabIndex = 3;
            this.hardwoodprice.Text = "Hardwood Price (sq. yd):";
            // 
            // underlayment
            // 
            this.underlayment.AutoSize = true;
            this.underlayment.Location = new System.Drawing.Point(71, 170);
            this.underlayment.Name = "underlayment";
            this.underlayment.Size = new System.Drawing.Size(75, 13);
            this.underlayment.TabIndex = 4;
            this.underlayment.Text = "Underlayment:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "(1 = YES, 0 = NO)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "(1 = YES, 0 = NO)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "First Room:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Sq. Yards:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Hardwood Cost:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 373);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Underlay Cost:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(97, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Labor Cost:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(100, 447);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Total Cost:";
            // 
            // sqYardslbl
            // 
            this.sqYardslbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sqYardslbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sqYardslbl.Location = new System.Drawing.Point(202, 293);
            this.sqYardslbl.Name = "sqYardslbl";
            this.sqYardslbl.Size = new System.Drawing.Size(100, 23);
            this.sqYardslbl.TabIndex = 19;
            this.sqYardslbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hwCostlbl
            // 
            this.hwCostlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hwCostlbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hwCostlbl.Location = new System.Drawing.Point(202, 331);
            this.hwCostlbl.Name = "hwCostlbl";
            this.hwCostlbl.Size = new System.Drawing.Size(100, 23);
            this.hwCostlbl.TabIndex = 20;
            this.hwCostlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // underlayCostlbl
            // 
            this.underlayCostlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.underlayCostlbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.underlayCostlbl.Location = new System.Drawing.Point(202, 368);
            this.underlayCostlbl.Name = "underlayCostlbl";
            this.underlayCostlbl.Size = new System.Drawing.Size(100, 23);
            this.underlayCostlbl.TabIndex = 21;
            this.underlayCostlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // laborcostlbl
            // 
            this.laborcostlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborcostlbl.Location = new System.Drawing.Point(202, 404);
            this.laborcostlbl.Name = "laborcostlbl";
            this.laborcostlbl.Size = new System.Drawing.Size(100, 23);
            this.laborcostlbl.TabIndex = 22;
            this.laborcostlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totallbl
            // 
            this.totallbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallbl.Location = new System.Drawing.Point(202, 442);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(100, 23);
            this.totallbl.TabIndex = 23;
            this.totallbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxWidthtb
            // 
            this.maxWidthtb.Location = new System.Drawing.Point(202, 49);
            this.maxWidthtb.Name = "maxWidthtb";
            this.maxWidthtb.Size = new System.Drawing.Size(100, 20);
            this.maxWidthtb.TabIndex = 24;
            // 
            // maxLengthtb
            // 
            this.maxLengthtb.Location = new System.Drawing.Point(202, 85);
            this.maxLengthtb.Name = "maxLengthtb";
            this.maxLengthtb.Size = new System.Drawing.Size(100, 20);
            this.maxLengthtb.TabIndex = 25;
            // 
            // hardwoodPricetb
            // 
            this.hardwoodPricetb.Location = new System.Drawing.Point(202, 122);
            this.hardwoodPricetb.Name = "hardwoodPricetb";
            this.hardwoodPricetb.Size = new System.Drawing.Size(100, 20);
            this.hardwoodPricetb.TabIndex = 26;
            // 
            // underlayTb
            // 
            this.underlayTb.Location = new System.Drawing.Point(202, 176);
            this.underlayTb.Name = "underlayTb";
            this.underlayTb.Size = new System.Drawing.Size(100, 20);
            this.underlayTb.TabIndex = 27;
            // 
            // firstRoomTb
            // 
            this.firstRoomTb.Location = new System.Drawing.Point(202, 227);
            this.firstRoomTb.Name = "firstRoomTb";
            this.firstRoomTb.Size = new System.Drawing.Size(100, 20);
            this.firstRoomTb.TabIndex = 28;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(105, 489);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(150, 23);
            this.calculate.TabIndex = 29;
            this.calculate.Text = "Calculate Estimate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 524);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.firstRoomTb);
            this.Controls.Add(this.underlayTb);
            this.Controls.Add(this.hardwoodPricetb);
            this.Controls.Add(this.maxLengthtb);
            this.Controls.Add(this.maxWidthtb);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.laborcostlbl);
            this.Controls.Add(this.underlayCostlbl);
            this.Controls.Add(this.hwCostlbl);
            this.Controls.Add(this.sqYardslbl);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.underlayment);
            this.Controls.Add(this.hardwoodprice);
            this.Controls.Add(this.maxlength);
            this.Controls.Add(this.maxwidth);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label maxwidth;
        private System.Windows.Forms.Label maxlength;
        private System.Windows.Forms.Label hardwoodprice;
        private System.Windows.Forms.Label underlayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label sqYardslbl;
        private System.Windows.Forms.Label hwCostlbl;
        private System.Windows.Forms.Label underlayCostlbl;
        private System.Windows.Forms.Label laborcostlbl;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.TextBox maxWidthtb;
        private System.Windows.Forms.TextBox maxLengthtb;
        private System.Windows.Forms.TextBox hardwoodPricetb;
        private System.Windows.Forms.TextBox underlayTb;
        private System.Windows.Forms.TextBox firstRoomTb;
        private System.Windows.Forms.Button calculate;
    }
}

