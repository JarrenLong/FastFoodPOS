namespace FastFoodPOS
{
    partial class RestaurantSelectionForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.radioButtonRonnyDs = new System.Windows.Forms.RadioButton();
            this.radioButtonBurgerJack = new System.Windows.Forms.RadioButton();
            this.radioButtonWendyTime = new System.Windows.Forms.RadioButton();
            this.checkBoxDelivery = new System.Windows.Forms.CheckBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Fast Food Ordering System!";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(52, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(82, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Customer Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(140, 49);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(159, 20);
            this.textBoxName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxName, "What\'s your name, stranger?");
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(140, 74);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(159, 20);
            this.textBoxAddress.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxAddress, "Where can we find you?");
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(89, 77);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 3;
            this.labelAddress.Text = "Address";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(140, 100);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(159, 20);
            this.textBoxPhone.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textBoxPhone, "What\'s your phone number?");
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(86, 103);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(48, 13);
            this.labelPhone.TabIndex = 5;
            this.labelPhone.Text = "Phone #";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(94, 33);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(254, 13);
            this.labelText.TabIndex = 7;
            this.labelText.Text = "To begin, let\'s get some basic information about you:";
            // 
            // radioButtonRonnyDs
            // 
            this.radioButtonRonnyDs.AutoSize = true;
            this.radioButtonRonnyDs.Location = new System.Drawing.Point(305, 50);
            this.radioButtonRonnyDs.Name = "radioButtonRonnyDs";
            this.radioButtonRonnyDs.Size = new System.Drawing.Size(74, 17);
            this.radioButtonRonnyDs.TabIndex = 8;
            this.radioButtonRonnyDs.TabStop = true;
            this.radioButtonRonnyDs.Text = "&Ronny D\'s";
            this.toolTip1.SetToolTip(this.radioButtonRonnyDs, "Kinda like McDonalds, but without the copyright problems...");
            this.radioButtonRonnyDs.UseVisualStyleBackColor = true;
            // 
            // radioButtonBurgerJack
            // 
            this.radioButtonBurgerJack.AutoSize = true;
            this.radioButtonBurgerJack.Location = new System.Drawing.Point(305, 75);
            this.radioButtonBurgerJack.Name = "radioButtonBurgerJack";
            this.radioButtonBurgerJack.Size = new System.Drawing.Size(82, 17);
            this.radioButtonBurgerJack.TabIndex = 9;
            this.radioButtonBurgerJack.TabStop = true;
            this.radioButtonBurgerJack.Text = "&Burger Jack";
            this.toolTip1.SetToolTip(this.radioButtonBurgerJack, "Top rated burger joint");
            this.radioButtonBurgerJack.UseVisualStyleBackColor = true;
            // 
            // radioButtonWendyTime
            // 
            this.radioButtonWendyTime.AutoSize = true;
            this.radioButtonWendyTime.Location = new System.Drawing.Point(305, 101);
            this.radioButtonWendyTime.Name = "radioButtonWendyTime";
            this.radioButtonWendyTime.Size = new System.Drawing.Size(85, 17);
            this.radioButtonWendyTime.TabIndex = 10;
            this.radioButtonWendyTime.TabStop = true;
            this.radioButtonWendyTime.Text = "&Wendy Time";
            this.toolTip1.SetToolTip(this.radioButtonWendyTime, "Not even sure what this one might possibly be...");
            this.radioButtonWendyTime.UseVisualStyleBackColor = true;
            // 
            // checkBoxDelivery
            // 
            this.checkBoxDelivery.AutoSize = true;
            this.checkBoxDelivery.Location = new System.Drawing.Point(159, 126);
            this.checkBoxDelivery.Name = "checkBoxDelivery";
            this.checkBoxDelivery.Size = new System.Drawing.Size(97, 17);
            this.checkBoxDelivery.TabIndex = 11;
            this.checkBoxDelivery.Text = "&Delivery order?";
            this.toolTip1.SetToolTip(this.checkBoxDelivery, "Delivery or carryout? (+$5.00 for delivery)");
            this.checkBoxDelivery.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(263, 123);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = "&Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 151);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(443, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(319, 17);
            this.toolStripStatusLabel1.Text = "Contestant #510 - Program #1 - Fast Food Ordering System";
            // 
            // RestaurantSelectionForm
            // 
            this.AcceptButton = this.buttonNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 173);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.checkBoxDelivery);
            this.Controls.Add(this.radioButtonWendyTime);
            this.Controls.Add(this.radioButtonBurgerJack);
            this.Controls.Add(this.radioButtonRonnyDs);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(459, 211);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(459, 211);
            this.Name = "RestaurantSelectionForm";
            this.Text = "Fast Food Ordering System";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.RadioButton radioButtonRonnyDs;
        private System.Windows.Forms.RadioButton radioButtonBurgerJack;
        private System.Windows.Forms.RadioButton radioButtonWendyTime;
        private System.Windows.Forms.CheckBox checkBoxDelivery;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

