
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
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pb1.Location = new System.Drawing.Point(0, 2);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(389, 550);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Yellow;
            this.pb3.Location = new System.Drawing.Point(190, 297);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(11, 112);
            this.pb3.TabIndex = 1;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.Form1_Load);
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.Yellow;
            this.pb4.Location = new System.Drawing.Point(190, 142);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(11, 112);
            this.pb4.TabIndex = 2;
            this.pb4.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Yellow;
            this.pb2.Location = new System.Drawing.Point(190, 452);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(11, 120);
            this.pb2.TabIndex = 3;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.Form1_Load);
            // 
            // pb5
            // 
            this.pb5.BackColor = System.Drawing.Color.Yellow;
            this.pb5.Location = new System.Drawing.Point(190, -13);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(11, 112);
            this.pb5.TabIndex = 4;
            this.pb5.TabStop = false;
            // 
            // car
            // 
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(0, 407);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(78, 114);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 5;
            this.car.TabStop = false;
            this.car.Click += new System.EventHandler(this.Form1_Load);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
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
            this.start_button.CursorChanged += new System.EventHandler(this.Form1_Load);
            this.start_button.Click += new System.EventHandler(this.Start);
            this.start_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.start_button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyDown);
            this.start_button.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
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
            this.stop_button.CursorChanged += new System.EventHandler(this.Form1_Load);
            this.stop_button.Click += new System.EventHandler(this.Stop);
            this.stop_button.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.stop_button.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(560, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(684, 521);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.car);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

