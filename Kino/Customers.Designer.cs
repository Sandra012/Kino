namespace Kino
{
    partial class Customers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbOverAverage = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.rbFirstName = new System.Windows.Forms.RadioButton();
            this.rbLastName = new System.Windows.Forms.RadioButton();
            this.dgwCustomers = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFavouriteActors = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(6, 29);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(72, 19);
            this.rbAll.TabIndex = 21;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Show All";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbAll_MouseClick);
            // 
            // rbOverAverage
            // 
            this.rbOverAverage.AutoSize = true;
            this.rbOverAverage.Location = new System.Drawing.Point(6, 62);
            this.rbOverAverage.Name = "rbOverAverage";
            this.rbOverAverage.Size = new System.Drawing.Size(132, 19);
            this.rbOverAverage.TabIndex = 22;
            this.rbOverAverage.Text = "Show Over-Average";
            this.rbOverAverage.UseVisualStyleBackColor = true;
            this.rbOverAverage.CheckedChanged += new System.EventHandler(this.rbOverAverage_CheckedChanged);
            this.rbOverAverage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbOverAverage_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Controls.Add(this.rbOverAverage);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(835, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 100);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbID);
            this.groupBox2.Controls.Add(this.rbFirstName);
            this.groupBox2.Controls.Add(this.rbLastName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(835, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 128);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order";
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Location = new System.Drawing.Point(6, 96);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(53, 19);
            this.rbID.TabIndex = 23;
            this.rbID.Text = "By ID";
            this.rbID.UseVisualStyleBackColor = true;
            this.rbID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbID_MouseClick);
            // 
            // rbFirstName
            // 
            this.rbFirstName.AutoSize = true;
            this.rbFirstName.Checked = true;
            this.rbFirstName.Location = new System.Drawing.Point(6, 29);
            this.rbFirstName.Name = "rbFirstName";
            this.rbFirstName.Size = new System.Drawing.Size(101, 19);
            this.rbFirstName.TabIndex = 21;
            this.rbFirstName.TabStop = true;
            this.rbFirstName.Text = "By First Name";
            this.rbFirstName.UseVisualStyleBackColor = true;
            this.rbFirstName.Click += new System.EventHandler(this.rbFirstName_Click);
            // 
            // rbLastName
            // 
            this.rbLastName.AutoSize = true;
            this.rbLastName.Location = new System.Drawing.Point(6, 62);
            this.rbLastName.Name = "rbLastName";
            this.rbLastName.Size = new System.Drawing.Size(101, 19);
            this.rbLastName.TabIndex = 22;
            this.rbLastName.Text = "By Last Name";
            this.rbLastName.UseVisualStyleBackColor = true;
            this.rbLastName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbLastName_MouseClick);
            // 
            // dgwCustomers
            // 
            this.dgwCustomers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomers.GridColor = System.Drawing.Color.Red;
            this.dgwCustomers.Location = new System.Drawing.Point(38, 70);
            this.dgwCustomers.Name = "dgwCustomers";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwCustomers.Size = new System.Drawing.Size(782, 435);
            this.dgwCustomers.TabIndex = 20;
            this.dgwCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCustomers_CellContentClick);
            this.dgwCustomers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwCustomers_CellFormatting);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Kino.Properties.Resources.movieClapper1;
            this.pictureBox3.Location = new System.Drawing.Point(857, 395);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(113, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kino.Properties.Resources.tape2;
            this.pictureBox1.Location = new System.Drawing.Point(2, 511);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kino.Properties.Resources.tape2;
            this.pictureBox2.Location = new System.Drawing.Point(2, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1008, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // btnFavouriteActors
            // 
            this.btnFavouriteActors.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFavouriteActors.BackgroundImage = global::Kino.Properties.Resources.movieClapper;
            this.btnFavouriteActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavouriteActors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFavouriteActors.Location = new System.Drawing.Point(858, 433);
            this.btnFavouriteActors.Name = "btnFavouriteActors";
            this.btnFavouriteActors.Size = new System.Drawing.Size(113, 57);
            this.btnFavouriteActors.TabIndex = 25;
            this.btnFavouriteActors.Text = "Show Favourite Actors";
            this.btnFavouriteActors.UseVisualStyleBackColor = false;
            this.btnFavouriteActors.Click += new System.EventHandler(this.btnFavouriteActors_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1010, 583);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnFavouriteActors);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwCustomers);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbOverAverage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.RadioButton rbFirstName;
        private System.Windows.Forms.RadioButton rbLastName;
        private System.Windows.Forms.Button btnFavouriteActors;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgwCustomers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;



    }
}