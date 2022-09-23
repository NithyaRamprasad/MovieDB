
namespace MovieDB
{
    partial class movie
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_btn_txt = new System.Windows.Forms.TextBox();
            this.director_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.year_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lead_actress_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lead_actor_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.movie_grid = new System.Windows.Forms.DataGridView();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movie_grid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.name_txt);
            this.panel3.Controls.Add(this.search_btn);
            this.panel3.Controls.Add(this.search_btn_txt);
            this.panel3.Controls.Add(this.director_txt);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.year_txt);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lead_actress_txt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lead_actor_txt);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.movie_grid);
            this.panel3.Controls.Add(this.add_btn);
            this.panel3.Location = new System.Drawing.Point(12, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(948, 515);
            this.panel3.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(640, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Movie Name :";
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.name_txt.Location = new System.Drawing.Point(771, 172);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(157, 29);
            this.name_txt.TabIndex = 22;
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.search_btn.Location = new System.Drawing.Point(731, 88);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(81, 29);
            this.search_btn.TabIndex = 21;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_btn_txt
            // 
            this.search_btn_txt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.search_btn_txt.Location = new System.Drawing.Point(616, 37);
            this.search_btn_txt.Name = "search_btn_txt";
            this.search_btn_txt.Size = new System.Drawing.Size(312, 29);
            this.search_btn_txt.TabIndex = 20;
            // 
            // director_txt
            // 
            this.director_txt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.director_txt.Location = new System.Drawing.Point(771, 327);
            this.director_txt.Name = "director_txt";
            this.director_txt.Size = new System.Drawing.Size(157, 29);
            this.director_txt.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(627, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Director Name :";
            // 
            // year_txt
            // 
            this.year_txt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.year_txt.Location = new System.Drawing.Point(771, 285);
            this.year_txt.Name = "year_txt";
            this.year_txt.Size = new System.Drawing.Size(157, 29);
            this.year_txt.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(624, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Year of Release :";
            // 
            // lead_actress_txt
            // 
            this.lead_actress_txt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lead_actress_txt.Location = new System.Drawing.Point(771, 242);
            this.lead_actress_txt.Name = "lead_actress_txt";
            this.lead_actress_txt.Size = new System.Drawing.Size(157, 29);
            this.lead_actress_txt.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(596, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Laed Actress Name :";
            // 
            // lead_actor_txt
            // 
            this.lead_actor_txt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lead_actor_txt.Location = new System.Drawing.Point(771, 207);
            this.lead_actor_txt.Name = "lead_actor_txt";
            this.lead_actor_txt.Size = new System.Drawing.Size(157, 29);
            this.lead_actor_txt.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(612, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lead Actor Name :";
            // 
            // movie_grid
            // 
            this.movie_grid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.movie_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movie_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movie_grid.Location = new System.Drawing.Point(11, 19);
            this.movie_grid.Name = "movie_grid";
            this.movie_grid.RowTemplate.Height = 25;
            this.movie_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movie_grid.Size = new System.Drawing.Size(564, 473);
            this.movie_grid.TabIndex = 10;
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.add_btn.Location = new System.Drawing.Point(731, 394);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(81, 29);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 78);
            this.panel2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 65);
            this.label5.TabIndex = 31;
            this.label5.Text = "Movie Details";
            // 
            // movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(970, 620);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "movie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Movie_FormClosing);
            this.Load += new System.EventHandler(this.Movie_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movie_grid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView movie_grid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox director_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox year_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lead_actress_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lead_actor_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_btn_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_txt;
    }
}