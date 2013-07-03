namespace Kino
{
    partial class Administration
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
            this.btnAddNewMovie = new System.Windows.Forms.Button();
            this.btnAddNewShow = new System.Windows.Forms.Button();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.btnViewBookings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddNewMovie
            // 
            this.btnAddNewMovie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNewMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewMovie.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnAddNewMovie.Location = new System.Drawing.Point(152, 80);
            this.btnAddNewMovie.Name = "btnAddNewMovie";
            this.btnAddNewMovie.Size = new System.Drawing.Size(133, 40);
            this.btnAddNewMovie.TabIndex = 0;
            this.btnAddNewMovie.Text = "Add new movie";
            this.btnAddNewMovie.UseVisualStyleBackColor = false;
            this.btnAddNewMovie.Click += new System.EventHandler(this.btnAddNewMovie_Click);
            // 
            // btnAddNewShow
            // 
            this.btnAddNewShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNewShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewShow.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnAddNewShow.Location = new System.Drawing.Point(153, 136);
            this.btnAddNewShow.Name = "btnAddNewShow";
            this.btnAddNewShow.Size = new System.Drawing.Size(133, 40);
            this.btnAddNewShow.TabIndex = 1;
            this.btnAddNewShow.Text = "Add new show";
            this.btnAddNewShow.UseVisualStyleBackColor = false;
            this.btnAddNewShow.Click += new System.EventHandler(this.btnAddNewShow_Click);
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomers.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnViewCustomers.Location = new System.Drawing.Point(153, 188);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(133, 40);
            this.btnViewCustomers.TabIndex = 3;
            this.btnViewCustomers.Text = "View customers";
            this.btnViewCustomers.UseVisualStyleBackColor = false;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // btnViewBookings
            // 
            this.btnViewBookings.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBookings.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnViewBookings.Location = new System.Drawing.Point(152, 240);
            this.btnViewBookings.Name = "btnViewBookings";
            this.btnViewBookings.Size = new System.Drawing.Size(133, 40);
            this.btnViewBookings.TabIndex = 4;
            this.btnViewBookings.Text = "View bookings";
            this.btnViewBookings.UseVisualStyleBackColor = false;
            this.btnViewBookings.Click += new System.EventHandler(this.btnViewBookings_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(348, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kino.Properties.Resources.adminbackground;
            this.ClientSize = new System.Drawing.Size(437, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnViewBookings);
            this.Controls.Add(this.btnViewCustomers);
            this.Controls.Add(this.btnAddNewShow);
            this.Controls.Add(this.btnAddNewMovie);
            this.Name = "Administration";
            this.Text = "Administration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administration_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewMovie;
        private System.Windows.Forms.Button btnAddNewShow;
        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.Button btnViewBookings;
        private System.Windows.Forms.Button button1;
    }
}