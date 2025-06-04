namespace BookManagementPractice
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
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.textBox_Pages = new System.Windows.Forms.TextBox();
            this.textBox_Genre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox_MovieTitle = new System.Windows.Forms.TextBox();
            this.textBox_Director = new System.Windows.Forms.TextBox();
            this.textBox_Runtime = new System.Windows.Forms.TextBox();
            this.textBox_MovieGenre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_MovieAdd = new System.Windows.Forms.Button();
            this.button_MovieUpdate = new System.Windows.Forms.Button();
            this.button_MovieDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(380, 64);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(380, 93);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(380, 122);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(173, 66);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(118, 20);
            this.textBox_title.TabIndex = 1;
            // 
            // textBox_Author
            // 
            this.textBox_Author.Location = new System.Drawing.Point(173, 95);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(118, 20);
            this.textBox_Author.TabIndex = 1;
            // 
            // textBox_Pages
            // 
            this.textBox_Pages.Location = new System.Drawing.Point(173, 125);
            this.textBox_Pages.Name = "textBox_Pages";
            this.textBox_Pages.Size = new System.Drawing.Size(118, 20);
            this.textBox_Pages.TabIndex = 1;
            // 
            // textBox_Genre
            // 
            this.textBox_Genre.Location = new System.Drawing.Point(173, 151);
            this.textBox_Genre.Name = "textBox_Genre";
            this.textBox_Genre.Size = new System.Drawing.Size(118, 20);
            this.textBox_Genre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pages";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Genre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(109, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 216);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(659, 202);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(439, 216);
            this.dataGridView2.TabIndex = 3;
            // 
            // textBox_MovieTitle
            // 
            this.textBox_MovieTitle.Location = new System.Drawing.Point(806, 32);
            this.textBox_MovieTitle.Name = "textBox_MovieTitle";
            this.textBox_MovieTitle.Size = new System.Drawing.Size(118, 20);
            this.textBox_MovieTitle.TabIndex = 1;
            // 
            // textBox_Director
            // 
            this.textBox_Director.Location = new System.Drawing.Point(806, 61);
            this.textBox_Director.Name = "textBox_Director";
            this.textBox_Director.Size = new System.Drawing.Size(118, 20);
            this.textBox_Director.TabIndex = 1;
            // 
            // textBox_Runtime
            // 
            this.textBox_Runtime.Location = new System.Drawing.Point(806, 91);
            this.textBox_Runtime.Name = "textBox_Runtime";
            this.textBox_Runtime.Size = new System.Drawing.Size(118, 20);
            this.textBox_Runtime.TabIndex = 1;
            // 
            // textBox_MovieGenre
            // 
            this.textBox_MovieGenre.Location = new System.Drawing.Point(806, 117);
            this.textBox_MovieGenre.Name = "textBox_MovieGenre";
            this.textBox_MovieGenre.Size = new System.Drawing.Size(118, 20);
            this.textBox_MovieGenre.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(738, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(738, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Director";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(738, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Runtime";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(738, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Genre";
            // 
            // textBox_Year
            // 
            this.textBox_Year.Location = new System.Drawing.Point(806, 143);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(118, 20);
            this.textBox_Year.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(738, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Year";
            // 
            // button_MovieAdd
            // 
            this.button_MovieAdd.Location = new System.Drawing.Point(962, 30);
            this.button_MovieAdd.Name = "button_MovieAdd";
            this.button_MovieAdd.Size = new System.Drawing.Size(75, 23);
            this.button_MovieAdd.TabIndex = 4;
            this.button_MovieAdd.Text = "Add";
            this.button_MovieAdd.UseVisualStyleBackColor = true;
            this.button_MovieAdd.Click += new System.EventHandler(this.button_MovieAdd_Click);
            // 
            // button_MovieUpdate
            // 
            this.button_MovieUpdate.Location = new System.Drawing.Point(962, 58);
            this.button_MovieUpdate.Name = "button_MovieUpdate";
            this.button_MovieUpdate.Size = new System.Drawing.Size(75, 23);
            this.button_MovieUpdate.TabIndex = 4;
            this.button_MovieUpdate.Text = "Update";
            this.button_MovieUpdate.UseVisualStyleBackColor = true;
            this.button_MovieUpdate.Click += new System.EventHandler(this.button_MovieUpdate_Click);
            // 
            // button_MovieDelete
            // 
            this.button_MovieDelete.Location = new System.Drawing.Point(962, 88);
            this.button_MovieDelete.Name = "button_MovieDelete";
            this.button_MovieDelete.Size = new System.Drawing.Size(75, 23);
            this.button_MovieDelete.TabIndex = 4;
            this.button_MovieDelete.Text = "Delete";
            this.button_MovieDelete.UseVisualStyleBackColor = true;
            this.button_MovieDelete.Click += new System.EventHandler(this.button_MovieDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 450);
            this.Controls.Add(this.button_MovieDelete);
            this.Controls.Add(this.button_MovieUpdate);
            this.Controls.Add(this.button_MovieAdd);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Year);
            this.Controls.Add(this.textBox_MovieGenre);
            this.Controls.Add(this.textBox_Genre);
            this.Controls.Add(this.textBox_Runtime);
            this.Controls.Add(this.textBox_Director);
            this.Controls.Add(this.textBox_Pages);
            this.Controls.Add(this.textBox_MovieTitle);
            this.Controls.Add(this.textBox_Author);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.TextBox textBox_Pages;
        private System.Windows.Forms.TextBox textBox_Genre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox_MovieTitle;
        private System.Windows.Forms.TextBox textBox_Director;
        private System.Windows.Forms.TextBox textBox_Runtime;
        private System.Windows.Forms.TextBox textBox_MovieGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Year;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_MovieAdd;
        private System.Windows.Forms.Button button_MovieUpdate;
        private System.Windows.Forms.Button button_MovieDelete;
    }
}

