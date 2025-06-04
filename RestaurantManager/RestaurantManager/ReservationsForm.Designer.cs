namespace RestaurantManager
{
    partial class ReservationsForm
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
            System.Windows.Forms.Button btn_updateReservation;
            this.btn_addReservation = new System.Windows.Forms.Button();
            this.txtb_numPeople = new System.Windows.Forms.TextBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancelReservation = new System.Windows.Forms.Button();
            this.lb_username = new System.Windows.Forms.Label();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.txtb_tableNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_selectedReservationStatus = new System.Windows.Forms.Label();
            this.btn_refreshStatus = new System.Windows.Forms.Button();
            btn_updateReservation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_updateReservation
            // 
            btn_updateReservation.Location = new System.Drawing.Point(238, 422);
            btn_updateReservation.Name = "btn_updateReservation";
            btn_updateReservation.Size = new System.Drawing.Size(164, 30);
            btn_updateReservation.TabIndex = 17;
            btn_updateReservation.Text = "Update Reservation";
            btn_updateReservation.UseVisualStyleBackColor = true;
            btn_updateReservation.Click += new System.EventHandler(this.btn_updateReservation_Click);
            // 
            // btn_addReservation
            // 
            this.btn_addReservation.Location = new System.Drawing.Point(238, 386);
            this.btn_addReservation.Name = "btn_addReservation";
            this.btn_addReservation.Size = new System.Drawing.Size(139, 30);
            this.btn_addReservation.TabIndex = 0;
            this.btn_addReservation.Text = "Reserve a Table";
            this.btn_addReservation.UseVisualStyleBackColor = true;
            this.btn_addReservation.Click += new System.EventHandler(this.btn_addReservation_Click);
            // 
            // txtb_numPeople
            // 
            this.txtb_numPeople.Location = new System.Drawing.Point(20, 507);
            this.txtb_numPeople.Name = "txtb_numPeople";
            this.txtb_numPeople.Size = new System.Drawing.Size(100, 26);
            this.txtb_numPeople.TabIndex = 4;
            this.txtb_numPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_numPeople_KeyPress);
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(20, 455);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 26);
            this.dtp_date.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Table Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Party Size";
            // 
            // btn_cancelReservation
            // 
            this.btn_cancelReservation.Location = new System.Drawing.Point(238, 458);
            this.btn_cancelReservation.Name = "btn_cancelReservation";
            this.btn_cancelReservation.Size = new System.Drawing.Size(164, 30);
            this.btn_cancelReservation.TabIndex = 10;
            this.btn_cancelReservation.Text = "Cancel Reservation";
            this.btn_cancelReservation.UseVisualStyleBackColor = true;
            this.btn_cancelReservation.Click += new System.EventHandler(this.btn_cancelReservation_Click);
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(12, 9);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(108, 20);
            this.lb_username.TabIndex = 11;
            this.lb_username.Text = "Logged in as: ";
            // 
            // dgv_main
            // 
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Location = new System.Drawing.Point(12, 62);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.RowHeadersWidth = 62;
            this.dgv_main.RowTemplate.Height = 28;
            this.dgv_main.Size = new System.Drawing.Size(735, 297);
            this.dgv_main.TabIndex = 13;
            this.dgv_main.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_main_CellDoubleClick);
            // 
            // txtb_tableNum
            // 
            this.txtb_tableNum.Location = new System.Drawing.Point(20, 402);
            this.txtb_tableNum.Name = "txtb_tableNum";
            this.txtb_tableNum.Size = new System.Drawing.Size(100, 26);
            this.txtb_tableNum.TabIndex = 14;
            this.txtb_tableNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_tableNum_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Reservations:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Reservation Status:";
            // 
            // lbl_selectedReservationStatus
            // 
            this.lbl_selectedReservationStatus.AutoSize = true;
            this.lbl_selectedReservationStatus.Location = new System.Drawing.Point(620, 362);
            this.lbl_selectedReservationStatus.Name = "lbl_selectedReservationStatus";
            this.lbl_selectedReservationStatus.Size = new System.Drawing.Size(51, 20);
            this.lbl_selectedReservationStatus.TabIndex = 19;
            this.lbl_selectedReservationStatus.Text = "label6";
            // 
            // btn_refreshStatus
            // 
            this.btn_refreshStatus.Location = new System.Drawing.Point(469, 386);
            this.btn_refreshStatus.Name = "btn_refreshStatus";
            this.btn_refreshStatus.Size = new System.Drawing.Size(75, 30);
            this.btn_refreshStatus.TabIndex = 20;
            this.btn_refreshStatus.Text = "Refresh";
            this.btn_refreshStatus.UseVisualStyleBackColor = true;
            this.btn_refreshStatus.Click += new System.EventHandler(this.btn_refreshStatus_Click);
            // 
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 723);
            this.Controls.Add(this.btn_refreshStatus);
            this.Controls.Add(this.lbl_selectedReservationStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(btn_updateReservation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtb_tableNum);
            this.Controls.Add(this.dgv_main);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.btn_cancelReservation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.txtb_numPeople);
            this.Controls.Add(this.btn_addReservation);
            this.Name = "ReservationsForm";
            this.Text = "ReservationsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReservationsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addReservation;
        private System.Windows.Forms.TextBox txtb_numPeople;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancelReservation;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.TextBox txtb_tableNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_selectedReservationStatus;
        private System.Windows.Forms.Button btn_refreshStatus;
    }
}