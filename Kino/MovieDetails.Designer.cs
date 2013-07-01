namespace Kino
{
    partial class MovieDetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbActors = new System.Windows.Forms.TextBox();
            this.tbActresses = new System.Windows.Forms.TextBox();
            this.tbDirector = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.tbRating = new System.Windows.Forms.TextBox();
            this.tbWriter = new System.Windows.Forms.TextBox();
            this.lbMovieName = new System.Windows.Forms.Label();
            this.btnAddRating = new System.Windows.Forms.Button();
            this.tbAddRating = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rating:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Actors:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Actresses:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Director:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Writer:";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(115, 41);
            this.tbYear.Name = "tbYear";
            this.tbYear.ReadOnly = true;
            this.tbYear.Size = new System.Drawing.Size(111, 20);
            this.tbYear.TabIndex = 8;
            // 
            // tbActors
            // 
            this.tbActors.Location = new System.Drawing.Point(115, 147);
            this.tbActors.Name = "tbActors";
            this.tbActors.ReadOnly = true;
            this.tbActors.Size = new System.Drawing.Size(111, 20);
            this.tbActors.TabIndex = 9;
            // 
            // tbActresses
            // 
            this.tbActresses.Location = new System.Drawing.Point(115, 173);
            this.tbActresses.Name = "tbActresses";
            this.tbActresses.ReadOnly = true;
            this.tbActresses.Size = new System.Drawing.Size(111, 20);
            this.tbActresses.TabIndex = 10;
            // 
            // tbDirector
            // 
            this.tbDirector.Location = new System.Drawing.Point(115, 199);
            this.tbDirector.Name = "tbDirector";
            this.tbDirector.ReadOnly = true;
            this.tbDirector.Size = new System.Drawing.Size(111, 20);
            this.tbDirector.TabIndex = 11;
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(115, 121);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.ReadOnly = true;
            this.tbGenre.Size = new System.Drawing.Size(111, 20);
            this.tbGenre.TabIndex = 12;
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(115, 95);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.ReadOnly = true;
            this.tbDuration.Size = new System.Drawing.Size(111, 20);
            this.tbDuration.TabIndex = 13;
            // 
            // tbRating
            // 
            this.tbRating.Location = new System.Drawing.Point(115, 67);
            this.tbRating.Name = "tbRating";
            this.tbRating.ReadOnly = true;
            this.tbRating.Size = new System.Drawing.Size(111, 20);
            this.tbRating.TabIndex = 14;
            // 
            // tbWriter
            // 
            this.tbWriter.Location = new System.Drawing.Point(115, 226);
            this.tbWriter.Name = "tbWriter";
            this.tbWriter.ReadOnly = true;
            this.tbWriter.Size = new System.Drawing.Size(111, 20);
            this.tbWriter.TabIndex = 15;
            // 
            // lbMovieName
            // 
            this.lbMovieName.AutoSize = true;
            this.lbMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovieName.Location = new System.Drawing.Point(101, 9);
            this.lbMovieName.Name = "lbMovieName";
            this.lbMovieName.Size = new System.Drawing.Size(52, 17);
            this.lbMovieName.TabIndex = 16;
            this.lbMovieName.Text = "label9";
            // 
            // btnAddRating
            // 
            this.btnAddRating.Location = new System.Drawing.Point(58, 261);
            this.btnAddRating.Name = "btnAddRating";
            this.btnAddRating.Size = new System.Drawing.Size(75, 21);
            this.btnAddRating.TabIndex = 17;
            this.btnAddRating.Text = "Add rating";
            this.btnAddRating.UseVisualStyleBackColor = true;
            this.btnAddRating.Click += new System.EventHandler(this.btnAddRating_Click);
            // 
            // tbAddRating
            // 
            this.tbAddRating.Location = new System.Drawing.Point(151, 261);
            this.tbAddRating.Name = "tbAddRating";
            this.tbAddRating.Size = new System.Drawing.Size(75, 20);
            this.tbAddRating.TabIndex = 18;
            // 
            // MovieDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 301);
            this.Controls.Add(this.tbAddRating);
            this.Controls.Add(this.btnAddRating);
            this.Controls.Add(this.lbMovieName);
            this.Controls.Add(this.tbWriter);
            this.Controls.Add(this.tbRating);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.tbDirector);
            this.Controls.Add(this.tbActresses);
            this.Controls.Add(this.tbActors);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MovieDetails";
            this.Text = "Movie details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbActors;
        private System.Windows.Forms.TextBox tbActresses;
        private System.Windows.Forms.TextBox tbDirector;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.TextBox tbRating;
        private System.Windows.Forms.TextBox tbWriter;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label lbMovieName;
        private System.Windows.Forms.Button btnAddRating;
        private System.Windows.Forms.TextBox tbAddRating;
    }
}