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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwCustomers = new System.Windows.Forms.DataGridView();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbOverAverage = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFirstName = new System.Windows.Forms.RadioButton();
            this.rbLastName = new System.Windows.Forms.RadioButton();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.btnFavouriteActors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCustomers
            // 
            this.dgwCustomers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomers.GridColor = System.Drawing.Color.YellowGreen;
            this.dgwCustomers.Location = new System.Drawing.Point(28, 12);
            this.dgwCustomers.Name = "dgwCustomers";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwCustomers.Size = new System.Drawing.Size(825, 499);
            this.dgwCustomers.TabIndex = 20;
            this.dgwCustomers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwCustomers_CellFormatting);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(6, 29);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(66, 17);
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
            this.rbOverAverage.Size = new System.Drawing.Size(121, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(871, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 100);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbID);
            this.groupBox2.Controls.Add(this.rbFirstName);
            this.groupBox2.Controls.Add(this.rbLastName);
            this.groupBox2.Location = new System.Drawing.Point(871, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 128);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order";
            // 
            // rbFirstName
            // 
            this.rbFirstName.AutoSize = true;
            this.rbFirstName.Checked = true;
            this.rbFirstName.Location = new System.Drawing.Point(6, 29);
            this.rbFirstName.Name = "rbFirstName";
            this.rbFirstName.Size = new System.Drawing.Size(90, 17);
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
            this.rbLastName.Size = new System.Drawing.Size(91, 17);
            this.rbLastName.TabIndex = 22;
            this.rbLastName.Text = "By Last Name";
            this.rbLastName.UseVisualStyleBackColor = true;
            this.rbLastName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbLastName_MouseClick);
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Location = new System.Drawing.Point(6, 96);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(51, 17);
            this.rbID.TabIndex = 23;
            this.rbID.Text = "By ID";
            this.rbID.UseVisualStyleBackColor = true;
            this.rbID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rbID_MouseClick);
            // 
            // btnFavouriteActors
            // 
            this.btnFavouriteActors.Location = new System.Drawing.Point(871, 360);
            this.btnFavouriteActors.Name = "btnFavouriteActors";
            this.btnFavouriteActors.Size = new System.Drawing.Size(127, 23);
            this.btnFavouriteActors.TabIndex = 25;
            this.btnFavouriteActors.Text = "Show Favourite Actors";
            this.btnFavouriteActors.UseVisualStyleBackColor = true;
            this.btnFavouriteActors.Click += new System.EventHandler(this.btnFavouriteActors_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1010, 523);
            this.Controls.Add(this.btnFavouriteActors);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwCustomers);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCustomers;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbOverAverage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.RadioButton rbFirstName;
        private System.Windows.Forms.RadioButton rbLastName;
        private System.Windows.Forms.Button btnFavouriteActors;



    }
}