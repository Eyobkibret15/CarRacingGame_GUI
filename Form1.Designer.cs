
namespace CarRacingGame_GUI
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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.score_display = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dimond = new System.Windows.Forms.PictureBox();
            this.star = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.enemy_car4 = new System.Windows.Forms.PictureBox();
            this.enemy_car3 = new System.Windows.Forms.PictureBox();
            this.enemy_car2 = new System.Windows.Forms.PictureBox();
            this.enemy_car1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_car4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_car1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pb1.Location = new System.Drawing.Point(0, 2);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(389, 550);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.Cornsilk;
            this.pb4.Location = new System.Drawing.Point(269, 143);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(10, 111);
            this.pb4.TabIndex = 2;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.pb4_Click);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Cornsilk;
            this.pb2.Location = new System.Drawing.Point(269, 452);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(10, 118);
            this.pb2.TabIndex = 3;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.Form1_Load);
            // 
            // pb5
            // 
            this.pb5.BackColor = System.Drawing.Color.Cornsilk;
            this.pb5.Location = new System.Drawing.Point(268, -13);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(11, 113);
            this.pb5.TabIndex = 4;
            this.pb5.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.Blue;
            this.start_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_button.ForeColor = System.Drawing.Color.Lime;
            this.start_button.Location = new System.Drawing.Point(417, 76);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(75, 31);
            this.start_button.TabIndex = 6;
            this.start_button.TabStop = false;
            this.start_button.Text = "START";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.Start);
            this.start_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.start_button.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.start_button.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.start_button_PreviewKeyDown);
            // 
            // stop_button
            // 
            this.stop_button.BackColor = System.Drawing.Color.Blue;
            this.stop_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.stop_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stop_button.ForeColor = System.Drawing.Color.Red;
            this.stop_button.Location = new System.Drawing.Point(418, 118);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 29);
            this.stop_button.TabIndex = 6;
            this.stop_button.TabStop = false;
            this.stop_button.Text = "STOP";
            this.stop_button.UseVisualStyleBackColor = false;
            this.stop_button.Click += new System.EventHandler(this.Stop);
            this.stop_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.stop_button.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.stop_button.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.stop_button_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(539, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "SCORE";
            // 
            // score_display
            // 
            this.score_display.AutoSize = true;
            this.score_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.score_display.ForeColor = System.Drawing.Color.Transparent;
            this.score_display.Location = new System.Drawing.Point(539, 100);
            this.score_display.Name = "score_display";
            this.score_display.Size = new System.Drawing.Size(16, 16);
            this.score_display.TabIndex = 11;
            this.score_display.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.pictureBox1.Location = new System.Drawing.Point(378, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(11, 519);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Cornsilk;
            this.pictureBox2.Location = new System.Drawing.Point(0, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(11, 519);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // dimond
            // 
            this.dimond.Image = ((System.Drawing.Image)(resources.GetObject("dimond.Image")));
            this.dimond.Location = new System.Drawing.Point(120, 288);
            this.dimond.Name = "dimond";
            this.dimond.Size = new System.Drawing.Size(30, 30);
            this.dimond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dimond.TabIndex = 18;
            this.dimond.TabStop = false;
            // 
            // star
            // 
            this.star.Image = ((System.Drawing.Image)(resources.GetObject("star.Image")));
            this.star.Location = new System.Drawing.Point(226, 244);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(30, 30);
            this.star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star.TabIndex = 19;
            this.star.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Cornsilk;
            this.pictureBox3.Location = new System.Drawing.Point(173, -8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 539);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pb9
            // 
            this.pb9.BackColor = System.Drawing.Color.Cornsilk;
            this.pb9.Location = new System.Drawing.Point(90, -8);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(10, 108);
            this.pb9.TabIndex = 21;
            this.pb9.TabStop = false;
            // 
            // pb8
            // 
            this.pb8.BackColor = System.Drawing.Color.Cornsilk;
            this.pb8.Location = new System.Drawing.Point(90, 143);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(10, 111);
            this.pb8.TabIndex = 22;
            this.pb8.TabStop = false;
            // 
            // pb7
            // 
            this.pb7.BackColor = System.Drawing.Color.Cornsilk;
            this.pb7.Location = new System.Drawing.Point(90, 298);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(10, 111);
            this.pb7.TabIndex = 23;
            this.pb7.TabStop = false;
            // 
            // pb6
            // 
            this.pb6.BackColor = System.Drawing.Color.Cornsilk;
            this.pb6.Location = new System.Drawing.Point(90, 452);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(10, 112);
            this.pb6.TabIndex = 24;
            this.pb6.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Cornsilk;
            this.pb3.Location = new System.Drawing.Point(268, 298);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(10, 111);
            this.pb3.TabIndex = 25;
            this.pb3.TabStop = false;
            // 
            // car
            // 
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(201, 426);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(62, 92);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 26;
            this.car.TabStop = false;
            // 
            // enemy_car4
            // 
            this.enemy_car4.Image = ((System.Drawing.Image)(resources.GetObject("enemy_car4.Image")));
            this.enemy_car4.Location = new System.Drawing.Point(322, 204);
            this.enemy_car4.Name = "enemy_car4";
            this.enemy_car4.Size = new System.Drawing.Size(50, 90);
            this.enemy_car4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy_car4.TabIndex = 27;
            this.enemy_car4.TabStop = false;
            // 
            // enemy_car3
            // 
            this.enemy_car3.Image = ((System.Drawing.Image)(resources.GetObject("enemy_car3.Image")));
            this.enemy_car3.Location = new System.Drawing.Point(173, 282);
            this.enemy_car3.Name = "enemy_car3";
            this.enemy_car3.Size = new System.Drawing.Size(46, 70);
            this.enemy_car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy_car3.TabIndex = 28;
            this.enemy_car3.TabStop = false;
            // 
            // enemy_car2
            // 
            this.enemy_car2.Image = ((System.Drawing.Image)(resources.GetObject("enemy_car2.Image")));
            this.enemy_car2.Location = new System.Drawing.Point(106, 118);
            this.enemy_car2.Name = "enemy_car2";
            this.enemy_car2.Size = new System.Drawing.Size(46, 70);
            this.enemy_car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy_car2.TabIndex = 29;
            this.enemy_car2.TabStop = false;
            this.enemy_car2.Click += new System.EventHandler(this.enemy_car2_Click);
            // 
            // enemy_car1
            // 
            this.enemy_car1.Image = ((System.Drawing.Image)(resources.GetObject("enemy_car1.Image")));
            this.enemy_car1.Location = new System.Drawing.Point(12, 255);
            this.enemy_car1.Name = "enemy_car1";
            this.enemy_car1.Size = new System.Drawing.Size(62, 50);
            this.enemy_car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy_car1.TabIndex = 30;
            this.enemy_car1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(106, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "WELCOME ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(684, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enemy_car1);
            this.Controls.Add(this.enemy_car2);
            this.Controls.Add(this.enemy_car3);
            this.Controls.Add(this.enemy_car4);
            this.Controls.Add(this.car);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.star);
            this.Controls.Add(this.dimond);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.score_display);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Location = new System.Drawing.Point(0, -800);
            this.Name = "Form1";
            this.Text = "EYOB KIBRET CAR  GAME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_car4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy_car1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score_display;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox dimond;
        private System.Windows.Forms.PictureBox star;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pb9;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox enemy_car4;
        private System.Windows.Forms.PictureBox enemy_car3;
        private System.Windows.Forms.PictureBox enemy_car2;
        private System.Windows.Forms.PictureBox enemy_car1;
        private System.Windows.Forms.Label label2;
    }
}


