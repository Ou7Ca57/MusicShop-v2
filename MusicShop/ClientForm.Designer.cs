namespace MusicShop
{
    partial class ClientForm
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
            System.Windows.Forms.Label itemNameLabel;
            System.Windows.Forms.Label itemTypeLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label labelCount;
            System.Windows.Forms.Label iD_ItemLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iD_ItemLabel1 = new System.Windows.Forms.Label();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicShopDataSet = new MusicShop.MusicShopDataSet();
            this.costLabel1 = new System.Windows.Forms.Label();
            this.itemTypeLabel1 = new System.Windows.Forms.Label();
            this.itemNameLabel1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.photoLabel1 = new System.Windows.Forms.Label();
            this.itemTableAdapter = new MusicShop.MusicShopDataSetTableAdapters.ItemTableAdapter();
            this.tableAdapterManager = new MusicShop.MusicShopDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            itemNameLabel = new System.Windows.Forms.Label();
            itemTypeLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            labelCount = new System.Windows.Forms.Label();
            iD_ItemLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // itemNameLabel
            // 
            itemNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            itemNameLabel.AutoSize = true;
            itemNameLabel.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            itemNameLabel.ForeColor = System.Drawing.Color.Gray;
            itemNameLabel.Location = new System.Drawing.Point(412, 60);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(127, 60);
            itemNameLabel.TabIndex = 1;
            itemNameLabel.Text = "Наименование:";
            itemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemTypeLabel
            // 
            itemTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            itemTypeLabel.AutoSize = true;
            itemTypeLabel.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            itemTypeLabel.ForeColor = System.Drawing.Color.Gray;
            itemTypeLabel.Location = new System.Drawing.Point(412, 120);
            itemTypeLabel.Name = "itemTypeLabel";
            itemTypeLabel.Size = new System.Drawing.Size(41, 60);
            itemTypeLabel.TabIndex = 3;
            itemTypeLabel.Text = "Тип:";
            itemTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // costLabel
            // 
            costLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            costLabel.AutoSize = true;
            costLabel.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            costLabel.ForeColor = System.Drawing.Color.Gray;
            costLabel.Location = new System.Drawing.Point(412, 180);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(94, 60);
            costLabel.TabIndex = 5;
            costLabel.Text = "Стоимость:";
            costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.ForeColor = System.Drawing.Color.White;
            photoLabel.Location = new System.Drawing.Point(62, 0);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(38, 13);
            photoLabel.TabIndex = 1;
            photoLabel.Text = "Photo:";
            // 
            // labelCount
            // 
            labelCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            labelCount.AutoSize = true;
            labelCount.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelCount.ForeColor = System.Drawing.Color.Gray;
            labelCount.Location = new System.Drawing.Point(412, 240);
            labelCount.Name = "labelCount";
            labelCount.Size = new System.Drawing.Size(102, 60);
            labelCount.TabIndex = 12;
            labelCount.Text = "Количество:";
            labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iD_ItemLabel
            // 
            iD_ItemLabel.AutoSize = true;
            iD_ItemLabel.ForeColor = System.Drawing.Color.White;
            iD_ItemLabel.Location = new System.Drawing.Point(412, 0);
            iD_ItemLabel.Name = "iD_ItemLabel";
            iD_ItemLabel.Size = new System.Drawing.Size(44, 13);
            iD_ItemLabel.TabIndex = 15;
            iD_ItemLabel.Text = "ID Item:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.09685F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.27603F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.54964F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.33898F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.474576F));
            this.tableLayoutPanel1.Controls.Add(iD_ItemLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.iD_ItemLabel1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(costLabel, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.costLabel1, 4, 3);
            this.tableLayoutPanel1.Controls.Add(itemTypeLabel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.itemTypeLabel1, 4, 2);
            this.tableLayoutPanel1.Controls.Add(itemNameLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.itemNameLabel1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxItem, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonBuy, 3, 5);
            this.tableLayoutPanel1.Controls.Add(labelCount, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 4, 4);
            this.tableLayoutPanel1.Controls.Add(photoLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.photoLabel1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(826, 422);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(826, 422);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(826, 422);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // iD_ItemLabel1
            // 
            this.iD_ItemLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "ID_Item", true));
            this.iD_ItemLabel1.ForeColor = System.Drawing.Color.White;
            this.iD_ItemLabel1.Location = new System.Drawing.Point(590, 0);
            this.iD_ItemLabel1.Name = "iD_ItemLabel1";
            this.iD_ItemLabel1.Size = new System.Drawing.Size(100, 23);
            this.iD_ItemLabel1.TabIndex = 16;
            this.iD_ItemLabel1.Text = "label1";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.musicShopDataSet;
            // 
            // musicShopDataSet
            // 
            this.musicShopDataSet.DataSetName = "MusicShopDataSet";
            this.musicShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // costLabel1
            // 
            this.costLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "Cost", true));
            this.costLabel1.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel1.ForeColor = System.Drawing.Color.Gray;
            this.costLabel1.Location = new System.Drawing.Point(590, 180);
            this.costLabel1.Name = "costLabel1";
            this.costLabel1.Size = new System.Drawing.Size(162, 60);
            this.costLabel1.TabIndex = 6;
            this.costLabel1.Text = "-";
            this.costLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemTypeLabel1
            // 
            this.itemTypeLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemTypeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "ItemType", true));
            this.itemTypeLabel1.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemTypeLabel1.ForeColor = System.Drawing.Color.Gray;
            this.itemTypeLabel1.Location = new System.Drawing.Point(590, 120);
            this.itemTypeLabel1.Name = "itemTypeLabel1";
            this.itemTypeLabel1.Size = new System.Drawing.Size(162, 60);
            this.itemTypeLabel1.TabIndex = 4;
            this.itemTypeLabel1.Text = "-";
            this.itemTypeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemNameLabel1
            // 
            this.itemNameLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "ItemName", true));
            this.itemNameLabel1.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemNameLabel1.ForeColor = System.Drawing.Color.Gray;
            this.itemNameLabel1.Location = new System.Drawing.Point(590, 60);
            this.itemNameLabel1.Name = "itemNameLabel1";
            this.itemNameLabel1.Size = new System.Drawing.Size(162, 60);
            this.itemNameLabel1.TabIndex = 2;
            this.itemNameLabel1.Text = "-";
            this.itemNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.Gray;
            this.numericUpDown1.Location = new System.Drawing.Point(590, 255);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(162, 29);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // photoLabel1
            // 
            this.photoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "Photo", true));
            this.photoLabel1.ForeColor = System.Drawing.Color.White;
            this.photoLabel1.Location = new System.Drawing.Point(228, 0);
            this.photoLabel1.Name = "photoLabel1";
            this.photoLabel1.Size = new System.Drawing.Size(100, 23);
            this.photoLabel1.TabIndex = 2;
            this.photoLabel1.Text = "label1";
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ItemTableAdapter = this.itemTableAdapter;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.ShipmentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MusicShop.MusicShopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::MusicShop.Properties.Resources.basket;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 54);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonBasket_Click);
            // 
            // pictureBoxItem
            // 
            this.pictureBoxItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBoxItem, 2);
            this.pictureBoxItem.ErrorImage = global::MusicShop.Properties.Resources.errorPhoto;
            this.pictureBoxItem.Image = global::MusicShop.Properties.Resources.errorPhoto;
            this.pictureBoxItem.Location = new System.Drawing.Point(62, 63);
            this.pictureBoxItem.Name = "pictureBoxItem";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBoxItem, 5);
            this.pictureBoxItem.Size = new System.Drawing.Size(344, 294);
            this.pictureBoxItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxItem.TabIndex = 11;
            this.pictureBoxItem.TabStop = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.BackgroundImage = global::MusicShop.Properties.Resources.buttonNext;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(228, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackgroundImage = global::MusicShop.Properties.Resources.buttonPrev;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(172, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBuy.BackgroundImage")));
            this.buttonBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonBuy, 2);
            this.buttonBuy.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuy.Font = new System.Drawing.Font("Nunito", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuy.ForeColor = System.Drawing.Color.White;
            this.buttonBuy.Location = new System.Drawing.Point(412, 303);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(340, 54);
            this.buttonBuy.TabIndex = 2;
            this.buttonBuy.Text = "КУПИТЬ";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 444);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Музыкальная лавка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MusicShopDataSet musicShopDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private MusicShopDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private MusicShopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label costLabel1;
        private System.Windows.Forms.Label itemTypeLabel1;
        private System.Windows.Forms.Label itemNameLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label photoLabel1;
        private System.Windows.Forms.PictureBox pictureBoxItem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label iD_ItemLabel1;
    }
}