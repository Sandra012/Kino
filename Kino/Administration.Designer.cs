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
            this.SuspendLayout();
            // 
            // btnAddNewMovie
            // 
            this.btnAddNewMovie.Location = new System.Drawing.Point(72, 24);
            this.btnAddNewMovie.Name = "btnAddNewMovie";
            this.btnAddNewMovie.Size = new System.Drawing.Size(133, 40);
            this.btnAddNewMovie.TabIndex = 0;
            this.btnAddNewMovie.Text = "Add new movie";
            this.btnAddNewMovie.UseVisualStyleBackColor = true;
            this.btnAddNewMovie.Click += new System.EventHandler(this.btnAddNewMovie_Click);
            // 
            // btnAddNewShow
            // 
            this.btnAddNewShow.Location = new System.Drawing.Point(72, 81);
            this.btnAddNewShow.Name = "btnAddNewShow";
            this.btnAddNewShow.Size = new System.Drawing.Size(133, 40);
            this.btnAddNewShow.TabIndex = 1;
            this.btnAddNewShow.Text = "Add new show";
            this.btnAddNewShow.UseVisualStyleBackColor = true;
            this.btnAddNewShow.Click += new System.EventHandler(this.btnAddNewShow_Click);
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.Location = new System.Drawing.Point(72, 141);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(133, 40);
            this.btnViewCustomers.TabIndex = 3;
            this.btnViewCustomers.Text = "View customers";
            this.btnViewCustomers.UseVisualStyleBackColor = true;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // btnViewBookings
            // 
            this.btnViewBookings.Location = new System.Drawing.Point(72, 197);
            this.btnViewBookings.Name = "btnViewBookings";
            this.btnViewBookings.Size = new System.Drawing.Size(133, 40);
            this.btnViewBookings.TabIndex = 4;
            this.btnViewBookings.Text = "View bookings";
            this.btnViewBookings.UseVisualStyleBackColor = true;
            this.btnViewBookings.Click += new System.EventHandler(this.btnViewBookings_Click);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 260);
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
    }
}