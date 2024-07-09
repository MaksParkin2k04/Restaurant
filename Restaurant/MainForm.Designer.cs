namespace Restaurant
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl = new TabControl();
            Menu = new TabPage();
            groupBox1 = new GroupBox();
            OrderButton = new Button();
            SumOrder = new TextBox();
            SumPrice = new Label();
            tabControl1 = new TabControl();
            tabPagesCategories = new TabPage();
            dataGridViewBreakfast = new DataGridView();
            Order1 = new DataGridViewCheckBoxColumn();
            taPagesPizzas = new TabPage();
            dataGridViewPizzas = new DataGridView();
            Order2 = new DataGridViewCheckBoxColumn();
            tabPageSnacks = new TabPage();
            dataGridSnacks = new DataGridView();
            Order3 = new DataGridViewCheckBoxColumn();
            Order = new TabPage();
            groupBox2 = new GroupBox();
            buttonOrder = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            Price = new Label();
            groupBoxProduct = new GroupBox();
            NameBox = new GroupBox();
            textBoxPhone = new TextBox();
            Phone = new Label();
            textBoxName = new TextBox();
            FirstName = new Label();
            MyOrders = new TabPage();
            dataGridOrderItem = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl.SuspendLayout();
            Menu.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPagesCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBreakfast).BeginInit();
            taPagesPizzas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPizzas).BeginInit();
            tabPageSnacks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridSnacks).BeginInit();
            Order.SuspendLayout();
            groupBox2.SuspendLayout();
            NameBox.SuspendLayout();
            MyOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOrderItem).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(Menu);
            tabControl.Controls.Add(Order);
            tabControl.Controls.Add(MyOrders);
            tabControl.Location = new Point(14, 16);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1188, 591);
            tabControl.TabIndex = 0;
            // 
            // Menu
            // 
            Menu.Controls.Add(groupBox1);
            Menu.Controls.Add(tabControl1);
            Menu.Location = new Point(4, 29);
            Menu.Name = "Menu";
            Menu.Padding = new Padding(3);
            Menu.Size = new Size(1180, 558);
            Menu.TabIndex = 0;
            Menu.Text = "Меню";
            Menu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(OrderButton);
            groupBox1.Controls.Add(SumOrder);
            groupBox1.Controls.Add(SumPrice);
            groupBox1.Location = new Point(10, 506);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1143, 52);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // OrderButton
            // 
            OrderButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderButton.Location = new Point(322, 19);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(233, 29);
            OrderButton.TabIndex = 2;
            OrderButton.Text = "Добавить в корзину";
            OrderButton.UseVisualStyleBackColor = true;
            // 
            // SumOrder
            // 
            SumOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SumOrder.Location = new Point(163, 21);
            SumOrder.Name = "SumOrder";
            SumOrder.Size = new Size(125, 27);
            SumOrder.TabIndex = 1;
            // 
            // SumPrice
            // 
            SumPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SumPrice.AutoSize = true;
            SumPrice.Location = new Point(6, 21);
            SumPrice.Name = "SumPrice";
            SumPrice.Size = new Size(133, 20);
            SumPrice.TabIndex = 0;
            SumPrice.Text = "Общая стоимость";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPagesCategories);
            tabControl1.Controls.Add(taPagesPizzas);
            tabControl1.Controls.Add(tabPageSnacks);
            tabControl1.Location = new Point(6, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1151, 504);
            tabControl1.TabIndex = 1;
            // 
            // tabPagesCategories
            // 
            tabPagesCategories.Controls.Add(dataGridViewBreakfast);
            tabPagesCategories.Location = new Point(4, 29);
            tabPagesCategories.Name = "tabPagesCategories";
            tabPagesCategories.Padding = new Padding(3);
            tabPagesCategories.Size = new Size(1143, 471);
            tabPagesCategories.TabIndex = 0;
            tabPagesCategories.Text = "Завтраки";
            tabPagesCategories.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBreakfast
            // 
            dataGridViewBreakfast.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewBreakfast.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBreakfast.Columns.AddRange(new DataGridViewColumn[] { Order1 });
            dataGridViewBreakfast.Location = new Point(6, 6);
            dataGridViewBreakfast.Name = "dataGridViewBreakfast";
            dataGridViewBreakfast.RowHeadersWidth = 51;
            dataGridViewBreakfast.Size = new Size(1131, 459);
            dataGridViewBreakfast.TabIndex = 0;
            // 
            // Order1
            // 
            Order1.HeaderText = "Заказать";
            Order1.MinimumWidth = 6;
            Order1.Name = "Order1";
            Order1.Width = 125;
            // 
            // taPagesPizzas
            // 
            taPagesPizzas.Controls.Add(dataGridViewPizzas);
            taPagesPizzas.Location = new Point(4, 29);
            taPagesPizzas.Name = "taPagesPizzas";
            taPagesPizzas.Padding = new Padding(3);
            taPagesPizzas.Size = new Size(1143, 471);
            taPagesPizzas.TabIndex = 1;
            taPagesPizzas.Text = "Пиццы";
            taPagesPizzas.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPizzas
            // 
            dataGridViewPizzas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPizzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPizzas.Columns.AddRange(new DataGridViewColumn[] { Order2 });
            dataGridViewPizzas.Location = new Point(6, 6);
            dataGridViewPizzas.Name = "dataGridViewPizzas";
            dataGridViewPizzas.RowHeadersWidth = 51;
            dataGridViewPizzas.Size = new Size(1134, 462);
            dataGridViewPizzas.TabIndex = 0;
            // 
            // Order2
            // 
            Order2.HeaderText = "Заказать";
            Order2.MinimumWidth = 6;
            Order2.Name = "Order2";
            Order2.Width = 125;
            // 
            // tabPageSnacks
            // 
            tabPageSnacks.Controls.Add(dataGridSnacks);
            tabPageSnacks.Location = new Point(4, 29);
            tabPageSnacks.Name = "tabPageSnacks";
            tabPageSnacks.Padding = new Padding(3);
            tabPageSnacks.Size = new Size(1143, 471);
            tabPageSnacks.TabIndex = 2;
            tabPageSnacks.Text = "Закуски";
            tabPageSnacks.UseVisualStyleBackColor = true;
            // 
            // dataGridSnacks
            // 
            dataGridSnacks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSnacks.Columns.AddRange(new DataGridViewColumn[] { Order3 });
            dataGridSnacks.Location = new Point(6, 6);
            dataGridSnacks.Name = "dataGridSnacks";
            dataGridSnacks.RowHeadersWidth = 51;
            dataGridSnacks.Size = new Size(1131, 459);
            dataGridSnacks.TabIndex = 0;
            // 
            // Order3
            // 
            Order3.HeaderText = "Заказать";
            Order3.MinimumWidth = 6;
            Order3.Name = "Order3";
            Order3.Width = 125;
            // 
            // Order
            // 
            Order.Controls.Add(groupBox2);
            Order.Controls.Add(groupBoxProduct);
            Order.Controls.Add(NameBox);
            Order.Location = new Point(4, 29);
            Order.Name = "Order";
            Order.Padding = new Padding(3);
            Order.Size = new Size(1180, 558);
            Order.TabIndex = 1;
            Order.Text = "Корзина";
            Order.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(buttonOrder);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(Price);
            groupBox2.Location = new Point(6, 389);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1168, 163);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Заказ";
            // 
            // buttonOrder
            // 
            buttonOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonOrder.BackColor = Color.Gray;
            buttonOrder.Location = new Point(12, 109);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(1150, 48);
            buttonOrder.TabIndex = 3;
            buttonOrder.Text = "Сделать заказ";
            buttonOrder.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "С собой", "В ресторане" });
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "С собой", "В ресторане" });
            comboBox1.Location = new Point(11, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(1151, 28);
            comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(126, 38);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1036, 27);
            textBox1.TabIndex = 1;
            // 
            // Price
            // 
            Price.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Price.AutoSize = true;
            Price.Location = new Point(11, 41);
            Price.Name = "Price";
            Price.Size = new Size(45, 20);
            Price.TabIndex = 0;
            Price.Text = "Цена";
            // 
            // groupBoxProduct
            // 
            groupBoxProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxProduct.Location = new Point(9, 158);
            groupBoxProduct.Name = "groupBoxProduct";
            groupBoxProduct.Size = new Size(1168, 215);
            groupBoxProduct.TabIndex = 1;
            groupBoxProduct.TabStop = false;
            // 
            // NameBox
            // 
            NameBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameBox.Controls.Add(textBoxPhone);
            NameBox.Controls.Add(Phone);
            NameBox.Controls.Add(textBoxName);
            NameBox.Controls.Add(FirstName);
            NameBox.Location = new Point(6, 6);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(1168, 136);
            NameBox.TabIndex = 0;
            NameBox.TabStop = false;
            NameBox.Text = "Заказчик";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPhone.Location = new Point(126, 76);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(1036, 27);
            textBoxPhone.TabIndex = 3;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Location = new Point(11, 76);
            Phone.Name = "Phone";
            Phone.Size = new Size(76, 20);
            Phone.TabIndex = 2;
            Phone.Text = "Телефон: ";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Location = new Point(126, 38);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(1036, 27);
            textBoxName.TabIndex = 1;
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(11, 41);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(46, 20);
            FirstName.TabIndex = 0;
            FirstName.Text = "Имя: ";
            // 
            // MyOrders
            // 
            MyOrders.Controls.Add(dataGridOrderItem);
            MyOrders.Location = new Point(4, 29);
            MyOrders.Name = "MyOrders";
            MyOrders.Size = new Size(1180, 558);
            MyOrders.TabIndex = 2;
            MyOrders.Text = "Мои заказы";
            MyOrders.UseVisualStyleBackColor = true;
            // 
            // dataGridOrderItem
            // 
            dataGridOrderItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridOrderItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOrderItem.Location = new Point(3, 3);
            dataGridOrderItem.Name = "dataGridOrderItem";
            dataGridOrderItem.RowHeadersWidth = 51;
            dataGridOrderItem.Size = new Size(1174, 552);
            dataGridOrderItem.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 615);
            Controls.Add(tabControl);
            Name = "MainForm";
            Text = "Ресторан";
            tabControl.ResumeLayout(false);
            Menu.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPagesCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBreakfast).EndInit();
            taPagesPizzas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPizzas).EndInit();
            tabPageSnacks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridSnacks).EndInit();
            Order.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            NameBox.ResumeLayout(false);
            NameBox.PerformLayout();
            MyOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridOrderItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage Menu;
        private TabPage Order;
        private TabPage MyOrders;
        private TabControl tabControl1;
        private TabPage tabPagesCategories;
        private TabPage taPagesPizzas;
        private DataGridView dataGridViewBreakfast;
        private TabPage tabPageSnacks;
        private DataGridView dataGridViewPizzas;
        private DataGridView dataGridSnacks;
        private DataGridViewCheckBoxColumn Order1;
        private DataGridViewCheckBoxColumn Order2;
        private DataGridViewCheckBoxColumn Order3;
        private GroupBox groupBox1;
        private Label SumPrice;
        private TextBox SumOrder;
        private Button OrderButton;
        private GroupBox NameBox;
        private TextBox textBoxName;
        private Label FirstName;
        private Label Phone;
        private TextBox textBoxPhone;
        private GroupBox groupBoxProduct;
        private GroupBox groupBox2;
        private Label Price;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBox1;
        private Button buttonOrder;
        private DataGridView dataGridOrderItem;
    }
}
