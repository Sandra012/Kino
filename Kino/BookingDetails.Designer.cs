namespace Kino
{
    partial class BookingDetails
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSeats = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.tbBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "You have booked the following seats:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(214, 356);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(220, 23);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(332, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "For the show:";
            // 
            // lbSeats
            // 
            this.lbSeats.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeats.FormattingEnabled = true;
            this.lbSeats.ItemHeight = 23;
            this.lbSeats.Location = new System.Drawing.Point(317, 106);
            this.lbSeats.Name = "lbSeats";
            this.lbSeats.Size = new System.Drawing.Size(54, 73);
            this.lbSeats.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Total price:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalPrice.Location = new System.Drawing.Point(377, 308);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(57, 20);
            this.tbTotalPrice.TabIndex = 20;
            this.tbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.Location = new System.Drawing.Point(164, 255);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(324, 23);
            this.lblShow.TabIndex = 21;
            this.lblShow.Text = "Movie Name, Time, Date, Room Number";
            // 
            // tbBack
            // 
            this.tbBack.Location = new System.Drawing.Point(214, 385);
            this.tbBack.Name = "tbBack";
            this.tbBack.Size = new System.Drawing.Size(102, 23);
            this.tbBack.TabIndex = 22;
            this.tbBack.Text = "Back to Seats";
            this.tbBack.UseVisualStyleBackColor = true;
            this.tbBack.Click += new System.EventHandler(this.tbBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kino.Properties.Resources.tape_vertical;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 462);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kino.Properties.Resources.tape_vertical;
            this.pictureBox2.Location = new System.Drawing.Point(591, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 462);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 68;
            this.pictureBox2.TabStop = false;
            // 
            // BookingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(670, 452);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbBack);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSeats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookingDetails";
            this.Text = "Booking details";
            this.Load += new System.EventHandler(this.BookingDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbSeats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button tbBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}