namespace RestaurantManager
{
    partial class FeedbackForm
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
            this.dgv_feedback = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_orderId = new System.Windows.Forms.TextBox();
            this.nud_rating = new System.Windows.Forms.NumericUpDown();
            this.txtb_comment = new System.Windows.Forms.TextBox();
            this.btn_submitFeedback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_feedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rating)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_feedback
            // 
            this.dgv_feedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_feedback.Location = new System.Drawing.Point(16, 310);
            this.dgv_feedback.Name = "dgv_feedback";
            this.dgv_feedback.RowHeadersWidth = 62;
            this.dgv_feedback.RowTemplate.Height = 28;
            this.dgv_feedback.Size = new System.Drawing.Size(772, 244);
            this.dgv_feedback.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Comment";
            // 
            // txtb_orderId
            // 
            this.txtb_orderId.Location = new System.Drawing.Point(16, 32);
            this.txtb_orderId.Name = "txtb_orderId";
            this.txtb_orderId.Size = new System.Drawing.Size(150, 26);
            this.txtb_orderId.TabIndex = 4;
            // 
            // nud_rating
            // 
            this.nud_rating.Location = new System.Drawing.Point(16, 84);
            this.nud_rating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_rating.Name = "nud_rating";
            this.nud_rating.Size = new System.Drawing.Size(120, 26);
            this.nud_rating.TabIndex = 5;
            // 
            // txtb_comment
            // 
            this.txtb_comment.Location = new System.Drawing.Point(16, 136);
            this.txtb_comment.Multiline = true;
            this.txtb_comment.Name = "txtb_comment";
            this.txtb_comment.Size = new System.Drawing.Size(772, 132);
            this.txtb_comment.TabIndex = 6;
            // 
            // btn_submitFeedback
            // 
            this.btn_submitFeedback.Location = new System.Drawing.Point(713, 274);
            this.btn_submitFeedback.Name = "btn_submitFeedback";
            this.btn_submitFeedback.Size = new System.Drawing.Size(75, 30);
            this.btn_submitFeedback.TabIndex = 7;
            this.btn_submitFeedback.Text = "Submit";
            this.btn_submitFeedback.UseVisualStyleBackColor = true;
            this.btn_submitFeedback.Click += new System.EventHandler(this.btn_submitFeedback_Click);
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.btn_submitFeedback);
            this.Controls.Add(this.txtb_comment);
            this.Controls.Add(this.nud_rating);
            this.Controls.Add(this.txtb_orderId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_feedback);
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FeedbackForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_feedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_rating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_feedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_orderId;
        private System.Windows.Forms.NumericUpDown nud_rating;
        private System.Windows.Forms.TextBox txtb_comment;
        private System.Windows.Forms.Button btn_submitFeedback;
    }
}