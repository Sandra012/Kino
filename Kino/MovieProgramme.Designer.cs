namespace Kino
{
    partial class MovieProgramme
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelReccomend = new System.Windows.Forms.Panel();
            this.tbMovieName = new System.Windows.Forms.TextBox();
            this.lblRecommended = new System.Windows.Forms.Label();
            this.lblLoggedIn = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLogout = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(41, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Location = new System.Drawing.Point(41, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 542);
            this.panel1.TabIndex = 1;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // panelReccomend
            // 
            this.panelReccomend.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelReccomend.Location = new System.Drawing.Point(665, 261);
            this.panelReccomend.Name = "panelReccomend";
            this.panelReccomend.Size = new System.Drawing.Size(176, 199);
            this.panelReccomend.TabIndex = 2;
            // 
            // tbMovieName
            // 
            this.tbMovieName.BackColor = System.Drawing.Color.Honeydew;
            this.tbMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMovieName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbMovieName.Location = new System.Drawing.Point(666, 484);
            this.tbMovieName.Name = "tbMovieName";
            this.tbMovieName.ReadOnly = true;
            this.tbMovieName.Size = new System.Drawing.Size(175, 29);
            this.tbMovieName.TabIndex = 3;
            this.tbMovieName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRecommended
            // 
            this.lblRecommended.AutoSize = true;
            this.lblRecommended.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecommended.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRecommended.Location = new System.Drawing.Point(662, 236);
            this.lblRecommended.Name = "lblRecommended";
            this.lblRecommended.Size = new System.Drawing.Size(137, 13);
            this.lblRecommended.TabIndex = 4;
            this.lblRecommended.Text = "Recommended for you:";
            // 
            // lblLoggedIn
            // 
            this.lblLoggedIn.AutoSize = true;
            this.lblLoggedIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLoggedIn.Location = new System.Drawing.Point(627, 26);
            this.lblLoggedIn.Name = "lblLoggedIn";
            this.lblLoggedIn.Size = new System.Drawing.Size(63, 13);
            this.lblLoggedIn.TabIndex = 5;
            this.lblLoggedIn.Text = "Logged as: ";
            this.lblLoggedIn.Click += new System.EventHandler(this.lblLoggedIn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(665, 581);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 29);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLogout.Location = new System.Drawing.Point(627, 42);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(40, 13);
            this.lblLogout.TabIndex = 10;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            this.lblLogout.MouseEnter += new System.EventHandler(this.lblLogout_MouseEnter);
            this.lblLogout.MouseLeave += new System.EventHandler(this.lblLogout_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::Kino.Properties.Resources.movieClapper1;
            this.pictureBox1.Location = new System.Drawing.Point(666, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MovieProgramme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(847, 621);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblLoggedIn);
            this.Controls.Add(this.lblRecommended);
            this.Controls.Add(this.tbMovieName);
            this.Controls.Add(this.panelReccomend);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "MovieProgramme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MovieProgramme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MovieProgramme_FormClosing);
            this.Load += new System.EventHandler(this.MovieProgramme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelReccomend;
        private System.Windows.Forms.TextBox tbMovieName;
        private System.Windows.Forms.Label lblRecommended;
        private System.Windows.Forms.Label lblLoggedIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}