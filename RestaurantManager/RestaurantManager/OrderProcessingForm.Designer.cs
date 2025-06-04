namespace RestaurantManager
{
    partial class OrderProcessingForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_menu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_addToOrder = new System.Windows.Forms.Button();
            this.btn_removeFromOrder = new System.Windows.Forms.Button();
            this.txtb_selectedItemName = new System.Windows.Forms.TextBox();
            this.txtb_selectedItemPrice = new System.Windows.Forms.TextBox();
            this.dgv_currentOrderItems = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_orderTotalValue = new System.Windows.Forms.Label();
            this.btn_placeOrder = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_customerOrders = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_selectedOrderStatus = new System.Windows.Forms.Label();
            this.btn_refreshOrderStatus = new System.Windows.Forms.Button();
            this.btn_cancelSelectedOrder = new System.Windows.Forms.Button();
            this.nud_quantity = new System.Windows.Forms.NumericUpDown();
            this.orderStatusTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_currentOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customerOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // dgv_menu
            // 
            this.dgv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menu.Location = new System.Drawing.Point(17, 37);
            this.dgv_menu.Name = "dgv_menu";
            this.dgv_menu.RowHeadersWidth = 62;
            this.dgv_menu.RowTemplate.Height = 28;
            this.dgv_menu.Size = new System.Drawing.Size(771, 182);
            this.dgv_menu.TabIndex = 1;
            this.dgv_menu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_menu_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected Item:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity:";
            // 
            // btn_addToOrder
            // 
            this.btn_addToOrder.Location = new System.Drawing.Point(21, 398);
            this.btn_addToOrder.Name = "btn_addToOrder";
            this.btn_addToOrder.Size = new System.Drawing.Size(75, 30);
            this.btn_addToOrder.TabIndex = 5;
            this.btn_addToOrder.Text = "Add";
            this.btn_addToOrder.UseVisualStyleBackColor = true;
            this.btn_addToOrder.Click += new System.EventHandler(this.btn_addToOrder_Click_1);
            // 
            // btn_removeFromOrder
            // 
            this.btn_removeFromOrder.Location = new System.Drawing.Point(166, 398);
            this.btn_removeFromOrder.Name = "btn_removeFromOrder";
            this.btn_removeFromOrder.Size = new System.Drawing.Size(85, 30);
            this.btn_removeFromOrder.TabIndex = 6;
            this.btn_removeFromOrder.Text = "Remove";
            this.btn_removeFromOrder.UseVisualStyleBackColor = true;
            this.btn_removeFromOrder.Click += new System.EventHandler(this.btn_removeFromOrder_Click);
            // 
            // txtb_selectedItemName
            // 
            this.txtb_selectedItemName.Location = new System.Drawing.Point(21, 249);
            this.txtb_selectedItemName.Name = "txtb_selectedItemName";
            this.txtb_selectedItemName.Size = new System.Drawing.Size(150, 26);
            this.txtb_selectedItemName.TabIndex = 7;
            // 
            // txtb_selectedItemPrice
            // 
            this.txtb_selectedItemPrice.Location = new System.Drawing.Point(21, 301);
            this.txtb_selectedItemPrice.Name = "txtb_selectedItemPrice";
            this.txtb_selectedItemPrice.Size = new System.Drawing.Size(150, 26);
            this.txtb_selectedItemPrice.TabIndex = 8;
            // 
            // dgv_currentOrderItems
            // 
            this.dgv_currentOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_currentOrderItems.Location = new System.Drawing.Point(21, 476);
            this.dgv_currentOrderItems.Name = "dgv_currentOrderItems";
            this.dgv_currentOrderItems.RowHeadersWidth = 62;
            this.dgv_currentOrderItems.RowTemplate.Height = 28;
            this.dgv_currentOrderItems.Size = new System.Drawing.Size(767, 210);
            this.dgv_currentOrderItems.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Current Items";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 693);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Order Total:";
            // 
            // lbl_orderTotalValue
            // 
            this.lbl_orderTotalValue.AutoSize = true;
            this.lbl_orderTotalValue.Location = new System.Drawing.Point(119, 693);
            this.lbl_orderTotalValue.Name = "lbl_orderTotalValue";
            this.lbl_orderTotalValue.Size = new System.Drawing.Size(40, 20);
            this.lbl_orderTotalValue.TabIndex = 13;
            this.lbl_orderTotalValue.Text = "total";
            // 
            // btn_placeOrder
            // 
            this.btn_placeOrder.Location = new System.Drawing.Point(25, 716);
            this.btn_placeOrder.Name = "btn_placeOrder";
            this.btn_placeOrder.Size = new System.Drawing.Size(128, 30);
            this.btn_placeOrder.TabIndex = 14;
            this.btn_placeOrder.Text = "Place Order";
            this.btn_placeOrder.UseVisualStyleBackColor = true;
            this.btn_placeOrder.Click += new System.EventHandler(this.btn_placeOrder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 753);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Your Orders:";
            // 
            // dgv_customerOrders
            // 
            this.dgv_customerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customerOrders.Location = new System.Drawing.Point(25, 776);
            this.dgv_customerOrders.Name = "dgv_customerOrders";
            this.dgv_customerOrders.RowHeadersWidth = 62;
            this.dgv_customerOrders.RowTemplate.Height = 28;
            this.dgv_customerOrders.Size = new System.Drawing.Size(763, 211);
            this.dgv_customerOrders.TabIndex = 16;
            this.dgv_customerOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_customerOrders_CellDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 994);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Selected Order Status:";
            // 
            // lbl_selectedOrderStatus
            // 
            this.lbl_selectedOrderStatus.AutoSize = true;
            this.lbl_selectedOrderStatus.Location = new System.Drawing.Point(194, 994);
            this.lbl_selectedOrderStatus.Name = "lbl_selectedOrderStatus";
            this.lbl_selectedOrderStatus.Size = new System.Drawing.Size(53, 20);
            this.lbl_selectedOrderStatus.TabIndex = 18;
            this.lbl_selectedOrderStatus.Text = "status";
            // 
            // btn_refreshOrderStatus
            // 
            this.btn_refreshOrderStatus.Location = new System.Drawing.Point(25, 1017);
            this.btn_refreshOrderStatus.Name = "btn_refreshOrderStatus";
            this.btn_refreshOrderStatus.Size = new System.Drawing.Size(75, 30);
            this.btn_refreshOrderStatus.TabIndex = 19;
            this.btn_refreshOrderStatus.Text = "Refresh";
            this.btn_refreshOrderStatus.UseVisualStyleBackColor = true;
            this.btn_refreshOrderStatus.Click += new System.EventHandler(this.btn_refreshOrderStatus_Click);
            // 
            // btn_cancelSelectedOrder
            // 
            this.btn_cancelSelectedOrder.Location = new System.Drawing.Point(139, 1017);
            this.btn_cancelSelectedOrder.Name = "btn_cancelSelectedOrder";
            this.btn_cancelSelectedOrder.Size = new System.Drawing.Size(112, 30);
            this.btn_cancelSelectedOrder.TabIndex = 20;
            this.btn_cancelSelectedOrder.Text = "Cancel Order";
            this.btn_cancelSelectedOrder.UseVisualStyleBackColor = true;
            this.btn_cancelSelectedOrder.Click += new System.EventHandler(this.btn_cancelSelectedOrder_Click);
            // 
            // nud_quantity
            // 
            this.nud_quantity.Location = new System.Drawing.Point(21, 353);
            this.nud_quantity.Name = "nud_quantity";
            this.nud_quantity.Size = new System.Drawing.Size(120, 26);
            this.nud_quantity.TabIndex = 21;
            // 
            // orderStatusTimer
            // 
            this.orderStatusTimer.Interval = 10000;
            this.orderStatusTimer.Tick += new System.EventHandler(this.orderStatusTimer_Tick);
            // 
            // OrderProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1056);
            this.Controls.Add(this.nud_quantity);
            this.Controls.Add(this.btn_cancelSelectedOrder);
            this.Controls.Add(this.btn_refreshOrderStatus);
            this.Controls.Add(this.lbl_selectedOrderStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_customerOrders);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_placeOrder);
            this.Controls.Add(this.lbl_orderTotalValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_currentOrderItems);
            this.Controls.Add(this.txtb_selectedItemPrice);
            this.Controls.Add(this.txtb_selectedItemName);
            this.Controls.Add(this.btn_removeFromOrder);
            this.Controls.Add(this.btn_addToOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_menu);
            this.Controls.Add(this.label1);
            this.Name = "OrderProcessingForm";
            this.Text = "OrderProcessingForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderPlacementForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_currentOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customerOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_addToOrder;
        private System.Windows.Forms.Button btn_removeFromOrder;
        private System.Windows.Forms.TextBox txtb_selectedItemName;
        private System.Windows.Forms.TextBox txtb_selectedItemPrice;
        private System.Windows.Forms.DataGridView dgv_currentOrderItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_orderTotalValue;
        private System.Windows.Forms.Button btn_placeOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_customerOrders;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_selectedOrderStatus;
        private System.Windows.Forms.Button btn_refreshOrderStatus;
        private System.Windows.Forms.Button btn_cancelSelectedOrder;
        private System.Windows.Forms.NumericUpDown nud_quantity;
        private System.Windows.Forms.Timer orderStatusTimer;
    }
}