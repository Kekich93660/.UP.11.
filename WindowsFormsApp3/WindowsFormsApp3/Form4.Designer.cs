namespace WindowsFormsApp3
{
    partial class Print_form
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
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print_form));
            this.st08DataSet = new WindowsFormsApp3.St08DataSet();
            this.printerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printerTableAdapter = new WindowsFormsApp3.St08DataSetTableAdapters.PrinterTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp3.St08DataSetTableAdapters.TableAdapterManager();
            this.printerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            modelLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.st08DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerBindingNavigator)).BeginInit();
            this.printerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(65, 91);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(46, 13);
            modelLabel.TabIndex = 3;
            modelLabel.Text = "Модель";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(85, 117);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(26, 13);
            typeLabel.TabIndex = 5;
            typeLabel.Text = "Тип";
            typeLabel.Click += new System.EventHandler(this.typeLabel_Click);
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(78, 143);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(33, 13);
            priceLabel.TabIndex = 7;
            priceLabel.Text = "Цена";
            // 
            // st08DataSet
            // 
            this.st08DataSet.DataSetName = "St08DataSet";
            this.st08DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printerBindingSource
            // 
            this.printerBindingSource.DataMember = "Printer";
            this.printerBindingSource.DataSource = this.st08DataSet;
            // 
            // printerTableAdapter
            // 
            this.printerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LaptopTableAdapter = null;
            this.tableAdapterManager.PCTableAdapter = null;
            this.tableAdapterManager.PrinterTableAdapter = this.printerTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp3.St08DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // printerBindingNavigator
            // 
            this.printerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.printerBindingNavigator.BindingSource = this.printerBindingSource;
            this.printerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.printerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.printerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.printerBindingNavigatorSaveItem});
            this.printerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.printerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.printerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.printerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.printerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.printerBindingNavigator.Name = "printerBindingNavigator";
            this.printerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.printerBindingNavigator.Size = new System.Drawing.Size(320, 25);
            this.printerBindingNavigator.TabIndex = 0;
            this.printerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // printerBindingNavigatorSaveItem
            // 
            this.printerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("printerBindingNavigatorSaveItem.Image")));
            this.printerBindingNavigatorSaveItem.Name = "printerBindingNavigatorSaveItem";
            this.printerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.printerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.printerBindingNavigatorSaveItem.Click += new System.EventHandler(this.printerBindingNavigatorSaveItem_Click);
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.printerBindingSource, "model", true));
            this.modelTextBox.Location = new System.Drawing.Point(117, 88);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 4;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.printerBindingSource, "type", true));
            this.typeTextBox.Location = new System.Drawing.Point(117, 114);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.typeTextBox.TabIndex = 6;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.printerBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(117, 140);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Принтеры";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(81, 291);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(156, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(162, 249);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(75, 249);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(238, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Следующая";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(75, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Print_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 326);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.printerBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Print_form";
            this.Text = "Принтеры";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.st08DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerBindingNavigator)).EndInit();
            this.printerBindingNavigator.ResumeLayout(false);
            this.printerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private St08DataSet st08DataSet;
        private System.Windows.Forms.BindingSource printerBindingSource;
        private St08DataSetTableAdapters.PrinterTableAdapter printerTableAdapter;
        private St08DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator printerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton printerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}