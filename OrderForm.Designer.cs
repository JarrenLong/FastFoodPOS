namespace FastFoodPOS
{
    partial class OrderForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEntree = new System.Windows.Forms.TabPage();
            this.listViewEntreeMenu = new System.Windows.Forms.ListView();
            this.tabPageSides = new System.Windows.Forms.TabPage();
            this.listViewSideMenu = new System.Windows.Forms.ListView();
            this.tabPageBeverages = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonLarge = new System.Windows.Forms.RadioButton();
            this.radioButtonSmall = new System.Windows.Forms.RadioButton();
            this.listViewDrinkMenu = new System.Windows.Forms.ListView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownOrders = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPageEntree.SuspendLayout();
            this.tabPageSides.SuspendLayout();
            this.tabPageBeverages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrders)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(88, 36);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(90, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Restaurant Name";
            // 
            // labelAddress1
            // 
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Location = new System.Drawing.Point(184, 36);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(68, 13);
            this.labelAddress1.TabIndex = 1;
            this.labelAddress1.Text = "Address Line";
            // 
            // labelAddress2
            // 
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Location = new System.Drawing.Point(88, 49);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(77, 13);
            this.labelAddress2.TabIndex = 2;
            this.labelAddress2.Text = "City, ST 12345";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(171, 49);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(86, 13);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "(XXX)XXX-XXXX";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEntree);
            this.tabControl1.Controls.Add(this.tabPageSides);
            this.tabControl1.Controls.Add(this.tabPageBeverages);
            this.tabControl1.Location = new System.Drawing.Point(12, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(170, 170);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPageEntree
            // 
            this.tabPageEntree.Controls.Add(this.listViewEntreeMenu);
            this.tabPageEntree.Location = new System.Drawing.Point(4, 22);
            this.tabPageEntree.Name = "tabPageEntree";
            this.tabPageEntree.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEntree.Size = new System.Drawing.Size(162, 144);
            this.tabPageEntree.TabIndex = 0;
            this.tabPageEntree.Text = "Entrees";
            this.tabPageEntree.UseVisualStyleBackColor = true;
            // 
            // listViewEntreeMenu
            // 
            this.listViewEntreeMenu.GridLines = true;
            this.listViewEntreeMenu.Location = new System.Drawing.Point(0, 0);
            this.listViewEntreeMenu.Name = "listViewEntreeMenu";
            this.listViewEntreeMenu.Size = new System.Drawing.Size(162, 144);
            this.listViewEntreeMenu.TabIndex = 0;
            this.listViewEntreeMenu.UseCompatibleStateImageBehavior = false;
            this.listViewEntreeMenu.View = System.Windows.Forms.View.List;
            // 
            // tabPageSides
            // 
            this.tabPageSides.Controls.Add(this.listViewSideMenu);
            this.tabPageSides.Location = new System.Drawing.Point(4, 22);
            this.tabPageSides.Name = "tabPageSides";
            this.tabPageSides.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSides.Size = new System.Drawing.Size(162, 144);
            this.tabPageSides.TabIndex = 1;
            this.tabPageSides.Text = "Sides";
            this.tabPageSides.UseVisualStyleBackColor = true;
            // 
            // listViewSideMenu
            // 
            this.listViewSideMenu.GridLines = true;
            this.listViewSideMenu.Location = new System.Drawing.Point(0, 0);
            this.listViewSideMenu.Name = "listViewSideMenu";
            this.listViewSideMenu.Size = new System.Drawing.Size(162, 144);
            this.listViewSideMenu.TabIndex = 12;
            this.listViewSideMenu.UseCompatibleStateImageBehavior = false;
            this.listViewSideMenu.View = System.Windows.Forms.View.List;
            // 
            // tabPageBeverages
            // 
            this.tabPageBeverages.Controls.Add(this.label1);
            this.tabPageBeverages.Controls.Add(this.radioButtonMedium);
            this.tabPageBeverages.Controls.Add(this.radioButtonLarge);
            this.tabPageBeverages.Controls.Add(this.radioButtonSmall);
            this.tabPageBeverages.Controls.Add(this.listViewDrinkMenu);
            this.tabPageBeverages.Location = new System.Drawing.Point(4, 22);
            this.tabPageBeverages.Name = "tabPageBeverages";
            this.tabPageBeverages.Size = new System.Drawing.Size(162, 144);
            this.tabPageBeverages.TabIndex = 2;
            this.tabPageBeverages.Text = "Beverages";
            this.tabPageBeverages.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Size:";
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Location = new System.Drawing.Point(82, 124);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(34, 17);
            this.radioButtonMedium.TabIndex = 5;
            this.radioButtonMedium.Text = "&M";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonLarge
            // 
            this.radioButtonLarge.AutoSize = true;
            this.radioButtonLarge.Checked = true;
            this.radioButtonLarge.Location = new System.Drawing.Point(122, 124);
            this.radioButtonLarge.Name = "radioButtonLarge";
            this.radioButtonLarge.Size = new System.Drawing.Size(31, 17);
            this.radioButtonLarge.TabIndex = 4;
            this.radioButtonLarge.TabStop = true;
            this.radioButtonLarge.Text = "&L";
            this.radioButtonLarge.UseVisualStyleBackColor = true;
            // 
            // radioButtonSmall
            // 
            this.radioButtonSmall.AutoSize = true;
            this.radioButtonSmall.Location = new System.Drawing.Point(46, 124);
            this.radioButtonSmall.Name = "radioButtonSmall";
            this.radioButtonSmall.Size = new System.Drawing.Size(32, 17);
            this.radioButtonSmall.TabIndex = 3;
            this.radioButtonSmall.Text = "&S";
            this.radioButtonSmall.UseVisualStyleBackColor = true;
            // 
            // listViewDrinkMenu
            // 
            this.listViewDrinkMenu.GridLines = true;
            this.listViewDrinkMenu.Location = new System.Drawing.Point(0, 0);
            this.listViewDrinkMenu.Name = "listViewDrinkMenu";
            this.listViewDrinkMenu.Size = new System.Drawing.Size(162, 118);
            this.listViewDrinkMenu.TabIndex = 2;
            this.listViewDrinkMenu.UseCompatibleStateImageBehavior = false;
            this.listViewDrinkMenu.View = System.Windows.Forms.View.List;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(184, 68);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(146, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "&Add Selected Item";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Please Select from our Menu";
            // 
            // numericUpDownOrders
            // 
            this.numericUpDownOrders.Location = new System.Drawing.Point(201, 245);
            this.numericUpDownOrders.Name = "numericUpDownOrders";
            this.numericUpDownOrders.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownOrders.TabIndex = 8;
            this.numericUpDownOrders.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Number of orders:";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(255, 244);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.Text = "&Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // listViewOrder
            // 
            this.listViewOrder.GridLines = true;
            this.listViewOrder.Location = new System.Drawing.Point(184, 97);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(146, 141);
            this.listViewOrder.TabIndex = 1;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.List;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 271);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(342, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(319, 17);
            this.toolStripStatusLabel1.Text = "Contestant #510 - Program #1 - Fast Food Ordering System";
            // 
            // OrderForm
            // 
            this.AcceptButton = this.buttonNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 293);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownOrders);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress2);
            this.Controls.Add(this.labelAddress1);
            this.Controls.Add(this.labelName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(358, 331);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(358, 331);
            this.Name = "OrderForm";
            this.Text = "Fast Food Ordering System";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEntree.ResumeLayout(false);
            this.tabPageSides.ResumeLayout(false);
            this.tabPageBeverages.ResumeLayout(false);
            this.tabPageBeverages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrders)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress1;
        private System.Windows.Forms.Label labelAddress2;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEntree;
        private System.Windows.Forms.TabPage tabPageSides;
        private System.Windows.Forms.TabPage tabPageBeverages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownOrders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewEntreeMenu;
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ListView listViewSideMenu;
        private System.Windows.Forms.ListView listViewDrinkMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonLarge;
        private System.Windows.Forms.RadioButton radioButtonSmall;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}