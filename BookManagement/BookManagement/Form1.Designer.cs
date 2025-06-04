namespace BookManagement
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txtbx_title = new System.Windows.Forms.TextBox();
            this.txtbx_author = new System.Windows.Forms.TextBox();
            this.txtbx_pages = new System.Windows.Forms.TextBox();
            this.txtbx_genre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.btn_titleSort = new System.Windows.Forms.Button();
            this.btn_authorSort = new System.Windows.Forms.Button();
            this.btn_pagesSort = new System.Windows.Forms.Button();
            this.btn_genreSort = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txtb_search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_report = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(186, 14);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 30);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(186, 50);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 30);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(186, 86);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 30);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txtbx_title
            // 
            this.txtbx_title.Location = new System.Drawing.Point(68, 3);
            this.txtbx_title.Name = "txtbx_title";
            this.txtbx_title.Size = new System.Drawing.Size(100, 26);
            this.txtbx_title.TabIndex = 3;
            // 
            // txtbx_author
            // 
            this.txtbx_author.Location = new System.Drawing.Point(68, 35);
            this.txtbx_author.Name = "txtbx_author";
            this.txtbx_author.Size = new System.Drawing.Size(100, 26);
            this.txtbx_author.TabIndex = 4;
            // 
            // txtbx_pages
            // 
            this.txtbx_pages.Location = new System.Drawing.Point(68, 67);
            this.txtbx_pages.Name = "txtbx_pages";
            this.txtbx_pages.Size = new System.Drawing.Size(100, 26);
            this.txtbx_pages.TabIndex = 5;
            // 
            // txtbx_genre
            // 
            this.txtbx_genre.Location = new System.Drawing.Point(68, 99);
            this.txtbx_genre.Name = "txtbx_genre";
            this.txtbx_genre.Size = new System.Drawing.Size(100, 26);
            this.txtbx_genre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pages";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Genre";
            // 
            // dgv_main
            // 
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Location = new System.Drawing.Point(12, 187);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.RowHeadersWidth = 62;
            this.dgv_main.RowTemplate.Height = 28;
            this.dgv_main.Size = new System.Drawing.Size(970, 397);
            this.dgv_main.TabIndex = 8;
            // 
            // btn_titleSort
            // 
            this.btn_titleSort.Location = new System.Drawing.Point(267, 112);
            this.btn_titleSort.Name = "btn_titleSort";
            this.btn_titleSort.Size = new System.Drawing.Size(75, 53);
            this.btn_titleSort.TabIndex = 9;
            this.btn_titleSort.Text = "Sort by Title";
            this.btn_titleSort.UseVisualStyleBackColor = true;
            this.btn_titleSort.Click += new System.EventHandler(this.btn_titleSort_Click);
            // 
            // btn_authorSort
            // 
            this.btn_authorSort.Location = new System.Drawing.Point(410, 112);
            this.btn_authorSort.Name = "btn_authorSort";
            this.btn_authorSort.Size = new System.Drawing.Size(75, 53);
            this.btn_authorSort.TabIndex = 10;
            this.btn_authorSort.Text = "Sort by Author";
            this.btn_authorSort.UseVisualStyleBackColor = true;
            this.btn_authorSort.Click += new System.EventHandler(this.btn_authorSort_Click);
            // 
            // btn_pagesSort
            // 
            this.btn_pagesSort.Location = new System.Drawing.Point(558, 112);
            this.btn_pagesSort.Name = "btn_pagesSort";
            this.btn_pagesSort.Size = new System.Drawing.Size(75, 53);
            this.btn_pagesSort.TabIndex = 11;
            this.btn_pagesSort.Text = "Sort by Pages";
            this.btn_pagesSort.UseVisualStyleBackColor = true;
            this.btn_pagesSort.Click += new System.EventHandler(this.btn_pagesSort_Click);
            // 
            // btn_genreSort
            // 
            this.btn_genreSort.Location = new System.Drawing.Point(706, 112);
            this.btn_genreSort.Name = "btn_genreSort";
            this.btn_genreSort.Size = new System.Drawing.Size(75, 53);
            this.btn_genreSort.TabIndex = 12;
            this.btn_genreSort.Text = "Sort by Genre";
            this.btn_genreSort.UseVisualStyleBackColor = true;
            this.btn_genreSort.Click += new System.EventHandler(this.btn_genreSort_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(521, 41);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 30);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txtb_search
            // 
            this.txtb_search.Location = new System.Drawing.Point(363, 43);
            this.txtb_search.Name = "txtb_search";
            this.txtb_search.Size = new System.Drawing.Size(152, 26);
            this.txtb_search.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Search";
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(731, 33);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(140, 30);
            this.btn_report.TabIndex = 16;
            this.btn_report.Text = "Generate Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 596);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtb_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_genreSort);
            this.Controls.Add(this.btn_pagesSort);
            this.Controls.Add(this.btn_authorSort);
            this.Controls.Add(this.btn_titleSort);
            this.Controls.Add(this.dgv_main);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_genre);
            this.Controls.Add(this.txtbx_pages);
            this.Controls.Add(this.txtbx_author);
            this.Controls.Add(this.txtbx_title);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txtbx_title;
        private System.Windows.Forms.TextBox txtbx_author;
        private System.Windows.Forms.TextBox txtbx_pages;
        private System.Windows.Forms.TextBox txtbx_genre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.Button btn_titleSort;
        private System.Windows.Forms.Button btn_authorSort;
        private System.Windows.Forms.Button btn_pagesSort;
        private System.Windows.Forms.Button btn_genreSort;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txtb_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_report;
    }
}

