namespace Lab3
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
            this.Calculate = new System.Windows.Forms.Button();
            this.radiusTb = new System.Windows.Forms.TextBox();
            this.radiusLbl = new System.Windows.Forms.Label();
            this.diameter = new System.Windows.Forms.Label();
            this.surfacearea = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.Label();
            this.diameterLbl = new System.Windows.Forms.Label();
            this.surfaceareaLbl = new System.Windows.Forms.Label();
            this.volumeLbl = new System.Windows.Forms.Label();
            this.Sphere1 = new System.Windows.Forms.PictureBox();
            this.Sphere2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Sphere1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sphere2)).BeginInit();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(280, 98);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // radiusTb
            // 
            this.radiusTb.Location = new System.Drawing.Point(267, 62);
            this.radiusTb.Name = "radiusTb";
            this.radiusTb.Size = new System.Drawing.Size(100, 20);
            this.radiusTb.TabIndex = 1;
            // 
            // radiusLbl
            // 
            this.radiusLbl.AutoSize = true;
            this.radiusLbl.Location = new System.Drawing.Point(161, 65);
            this.radiusLbl.Name = "radiusLbl";
            this.radiusLbl.Size = new System.Drawing.Size(90, 13);
            this.radiusLbl.TabIndex = 2;
            this.radiusLbl.Text = "Radius of sphere:";
            // 
            // diameter
            // 
            this.diameter.AutoSize = true;
            this.diameter.Location = new System.Drawing.Point(31, 206);
            this.diameter.Name = "diameter";
            this.diameter.Size = new System.Drawing.Size(49, 13);
            this.diameter.TabIndex = 3;
            this.diameter.Text = "Diameter";
            // 
            // surfacearea
            // 
            this.surfacearea.AutoSize = true;
            this.surfacearea.Location = new System.Drawing.Point(12, 262);
            this.surfacearea.Name = "surfacearea";
            this.surfacearea.Size = new System.Drawing.Size(69, 13);
            this.surfacearea.TabIndex = 4;
            this.surfacearea.Text = "Surface Area";
            // 
            // volume
            // 
            this.volume.AutoSize = true;
            this.volume.Location = new System.Drawing.Point(38, 316);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(42, 13);
            this.volume.TabIndex = 5;
            this.volume.Text = "Volume";
            // 
            // diameterLbl
            // 
            this.diameterLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diameterLbl.Location = new System.Drawing.Point(97, 205);
            this.diameterLbl.Name = "diameterLbl";
            this.diameterLbl.Size = new System.Drawing.Size(100, 23);
            this.diameterLbl.TabIndex = 6;
            this.diameterLbl.Text = "\r\n";
            this.diameterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // surfaceareaLbl
            // 
            this.surfaceareaLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surfaceareaLbl.Location = new System.Drawing.Point(97, 262);
            this.surfaceareaLbl.Name = "surfaceareaLbl";
            this.surfaceareaLbl.Size = new System.Drawing.Size(100, 23);
            this.surfaceareaLbl.TabIndex = 7;
            this.surfaceareaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // volumeLbl
            // 
            this.volumeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volumeLbl.Location = new System.Drawing.Point(97, 315);
            this.volumeLbl.Name = "volumeLbl";
            this.volumeLbl.Size = new System.Drawing.Size(100, 23);
            this.volumeLbl.TabIndex = 8;
            this.volumeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sphere1
            // 
            this.Sphere1.Image = global::Lab3.Properties.Resources.Sphere_and_Ball;
            this.Sphere1.InitialImage = null;
            this.Sphere1.Location = new System.Drawing.Point(12, 12);
            this.Sphere1.Name = "Sphere1";
            this.Sphere1.Size = new System.Drawing.Size(143, 134);
            this.Sphere1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Sphere1.TabIndex = 9;
            this.Sphere1.TabStop = false;
            // 
            // Sphere2
            // 
            this.Sphere2.Image = global::Lab3.Properties.Resources.Sphere_and_Ball;
            this.Sphere2.InitialImage = null;
            this.Sphere2.Location = new System.Drawing.Point(232, 235);
            this.Sphere2.Name = "Sphere2";
            this.Sphere2.Size = new System.Drawing.Size(143, 134);
            this.Sphere2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Sphere2.TabIndex = 10;
            this.Sphere2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 381);
            this.Controls.Add(this.Sphere2);
            this.Controls.Add(this.Sphere1);
            this.Controls.Add(this.volumeLbl);
            this.Controls.Add(this.surfaceareaLbl);
            this.Controls.Add(this.diameterLbl);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.surfacearea);
            this.Controls.Add(this.diameter);
            this.Controls.Add(this.radiusLbl);
            this.Controls.Add(this.radiusTb);
            this.Controls.Add(this.Calculate);
            this.Name = "Form1";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.Sphere1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sphere2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox radiusTb;
        private System.Windows.Forms.Label radiusLbl;
        private System.Windows.Forms.Label diameter;
        private System.Windows.Forms.Label surfacearea;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.Label diameterLbl;
        private System.Windows.Forms.Label surfaceareaLbl;
        private System.Windows.Forms.Label volumeLbl;
        private System.Windows.Forms.PictureBox Sphere1;
        private System.Windows.Forms.PictureBox Sphere2;
    }
}

