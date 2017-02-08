namespace ShopUI
{
    partial class ShopUI
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
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.shoppingCartlistbox = new System.Windows.Forms.ListBox();
            this.addTOCart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.vendorListboxLabel = new System.Windows.Forms.Label();
            this.vendorListbox = new System.Windows.Forms.ListBox();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop";
            // 
            // itemsListbox
            // 
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.Location = new System.Drawing.Point(63, 67);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(264, 212);
            this.itemsListbox.TabIndex = 1;
            // 
            // shoppingCartlistbox
            // 
            this.shoppingCartlistbox.FormattingEnabled = true;
            this.shoppingCartlistbox.Location = new System.Drawing.Point(524, 67);
            this.shoppingCartlistbox.Name = "shoppingCartlistbox";
            this.shoppingCartlistbox.Size = new System.Drawing.Size(312, 212);
            this.shoppingCartlistbox.TabIndex = 2;
            // 
            // addTOCart
            // 
            this.addTOCart.Location = new System.Drawing.Point(388, 168);
            this.addTOCart.Name = "addTOCart";
            this.addTOCart.Size = new System.Drawing.Size(89, 23);
            this.addTOCart.TabIndex = 3;
            this.addTOCart.Text = "Add to cart ->";
            this.addTOCart.UseVisualStyleBackColor = true;
            this.addTOCart.Click += new System.EventHandler(this.addTOCart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(766, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Purchase";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Store Items";
            // 
            // vendorListboxLabel
            // 
            this.vendorListboxLabel.AutoSize = true;
            this.vendorListboxLabel.Location = new System.Drawing.Point(60, 315);
            this.vendorListboxLabel.Name = "vendorListboxLabel";
            this.vendorListboxLabel.Size = new System.Drawing.Size(46, 13);
            this.vendorListboxLabel.TabIndex = 7;
            this.vendorListboxLabel.Text = "Vendors";
            // 
            // vendorListbox
            // 
            this.vendorListbox.FormattingEnabled = true;
            this.vendorListbox.Location = new System.Drawing.Point(63, 331);
            this.vendorListbox.Name = "vendorListbox";
            this.vendorListbox.Size = new System.Drawing.Size(264, 212);
            this.vendorListbox.TabIndex = 6;
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Location = new System.Drawing.Point(521, 315);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(59, 13);
            this.storeProfitLabel.TabIndex = 8;
            this.storeProfitLabel.Text = "Store Profit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Shopping Cart";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Location = new System.Drawing.Point(598, 315);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(34, 13);
            this.storeProfitValue.TabIndex = 10;
            this.storeProfitValue.Text = "$0.00";
            // 
            // ShopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 599);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.vendorListboxLabel);
            this.Controls.Add(this.vendorListbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addTOCart);
            this.Controls.Add(this.shoppingCartlistbox);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.label1);
            this.Name = "ShopUI";
            this.Text = "ShopUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.ListBox shoppingCartlistbox;
        private System.Windows.Forms.Button addTOCart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label vendorListboxLabel;
        private System.Windows.Forms.ListBox vendorListbox;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label storeProfitValue;
    }
}

