namespace Kino
{
    partial class NewShow
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
            this.tbMovie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRoom = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.mtbTime = new System.Windows.Forms.MaskedTextBox();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbMovie
            // 
            this.tbMovie.Location = new System.Drawing.Point(116, 66);
            this.tbMovie.Name = "tbMovie";
            this.tbMovie.Size = new System.Drawing.Size(100, 20);
            this.tbMovie.TabIndex = 0;
            this.tbMovie.TextChanged += new System.EventHandler(this.tbMovie_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Time:";
            // 
            // tbRoom
            // 
            this.tbRoom.Location = new System.Drawing.Point(116, 119);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Size = new System.Drawing.Size(100, 20);
            this.tbRoom.TabIndex = 5;
            this.tbRoom.TextChanged += new System.EventHandler(this.tbRoom_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(116, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add show";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(67, 233);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 9;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // mtbTime
            // 
            this.mtbTime.Location = new System.Drawing.Point(116, 176);
            this.mtbTime.Mask = "00:00";
            this.mtbTime.Name = "mtbTime";
            this.mtbTime.Size = new System.Drawing.Size(33, 20);
            this.mtbTime.TabIndex = 10;
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbTime.Location = new System.Drawing.Point(174, 175);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(42, 21);
            this.cbTime.TabIndex = 11;
            // 
            // NewShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 331);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.mtbTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMovie);
            this.Name = "NewShow";
            this.Text = "Add new show";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRoom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.MaskedTextBox mtbTime;
        private System.Windows.Forms.ComboBox cbTime;
    }
}