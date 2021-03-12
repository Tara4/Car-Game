namespace CarRacing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.over = new System.Windows.Forms.Label();
            this.Car = new System.Windows.Forms.PictureBox();
            this.RandomCar1 = new System.Windows.Forms.PictureBox();
            this.RandomCar2 = new System.Windows.Forms.PictureBox();
            this.RandomCar3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.BackColor = System.Drawing.Color.Red;
            this.over.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.over.Location = new System.Drawing.Point(118, 22);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(135, 27);
            this.over.TabIndex = 0;
            this.over.Text = "GAME OVER";
            // 
            // Car
            // 
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.Location = new System.Drawing.Point(166, 334);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(60, 107);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car.TabIndex = 1;
            this.Car.TabStop = false;
            // 
            // RandomCar1
            // 
            this.RandomCar1.Image = ((System.Drawing.Image)(resources.GetObject("RandomCar1.Image")));
            this.RandomCar1.Location = new System.Drawing.Point(315, 272);
            this.RandomCar1.Name = "RandomCar1";
            this.RandomCar1.Size = new System.Drawing.Size(55, 110);
            this.RandomCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RandomCar1.TabIndex = 2;
            this.RandomCar1.TabStop = false;
            // 
            // RandomCar2
            // 
            this.RandomCar2.Image = ((System.Drawing.Image)(resources.GetObject("RandomCar2.Image")));
            this.RandomCar2.Location = new System.Drawing.Point(91, 294);
            this.RandomCar2.Name = "RandomCar2";
            this.RandomCar2.Size = new System.Drawing.Size(55, 110);
            this.RandomCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RandomCar2.TabIndex = 3;
            this.RandomCar2.TabStop = false;
            // 
            // RandomCar3
            // 
            this.RandomCar3.Image = ((System.Drawing.Image)(resources.GetObject("RandomCar3.Image")));
            this.RandomCar3.Location = new System.Drawing.Point(12, 149);
            this.RandomCar3.Name = "RandomCar3";
            this.RandomCar3.Size = new System.Drawing.Size(55, 110);
            this.RandomCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RandomCar3.TabIndex = 4;
            this.RandomCar3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(184, -33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 153);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(184, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(14, 147);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(184, 403);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(14, 135);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(184, 294);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(14, 88);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.RandomCar3);
            this.Controls.Add(this.RandomCar2);
            this.Controls.Add(this.RandomCar1);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.over);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Car Racing";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RandomCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.PictureBox RandomCar1;
        private System.Windows.Forms.PictureBox RandomCar2;
        private System.Windows.Forms.PictureBox RandomCar3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

