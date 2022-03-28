
namespace Maket_2._0
{
    partial class Projects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projects));
            this.CloseButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.индексDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерПроектаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авансDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оплатаПоЗавершениюDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНачалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗавершенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ежемесячныеТратыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.рабочаяГруппаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ежемесячныйДоходDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.прибыльDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.проектBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Модульное_МД_Финал_1_0DataSet = new Maket_2._0._Модульное_МД_Финал_1_0DataSet();
            this.модульноеМДФинал10DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.проектTableAdapter = new Maket_2._0._Модульное_МД_Финал_1_0DataSetTableAdapters.ПроектTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.проектBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Модульное_МД_Финал_1_0DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.модульноеМДФинал10DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(132, 302);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(96, 82);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 82);
            this.button1.TabIndex = 14;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.проектBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1313, 27);
            this.bindingNavigator1.TabIndex = 13;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.индексDataGridViewTextBoxColumn,
            this.номерПроектаDataGridViewTextBoxColumn,
            this.авансDataGridViewTextBoxColumn,
            this.оплатаПоЗавершениюDataGridViewTextBoxColumn,
            this.датаНачалаDataGridViewTextBoxColumn,
            this.датаЗавершенияDataGridViewTextBoxColumn,
            this.ежемесячныеТратыDataGridViewTextBoxColumn,
            this.рабочаяГруппаDataGridViewTextBoxColumn,
            this.ежемесячныйДоходDataGridViewTextBoxColumn,
            this.прибыльDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.проектBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1294, 245);
            this.dataGridView1.TabIndex = 12;
            // 
            // индексDataGridViewTextBoxColumn
            // 
            this.индексDataGridViewTextBoxColumn.DataPropertyName = "Индекс";
            this.индексDataGridViewTextBoxColumn.HeaderText = "Индекс";
            this.индексDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.индексDataGridViewTextBoxColumn.Name = "индексDataGridViewTextBoxColumn";
            this.индексDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерПроектаDataGridViewTextBoxColumn
            // 
            this.номерПроектаDataGridViewTextBoxColumn.DataPropertyName = "Номер проекта";
            this.номерПроектаDataGridViewTextBoxColumn.HeaderText = "Номер проекта";
            this.номерПроектаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерПроектаDataGridViewTextBoxColumn.Name = "номерПроектаDataGridViewTextBoxColumn";
            this.номерПроектаDataGridViewTextBoxColumn.Width = 125;
            // 
            // авансDataGridViewTextBoxColumn
            // 
            this.авансDataGridViewTextBoxColumn.DataPropertyName = "Аванс";
            this.авансDataGridViewTextBoxColumn.HeaderText = "Аванс";
            this.авансDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.авансDataGridViewTextBoxColumn.Name = "авансDataGridViewTextBoxColumn";
            this.авансDataGridViewTextBoxColumn.Width = 125;
            // 
            // оплатаПоЗавершениюDataGridViewTextBoxColumn
            // 
            this.оплатаПоЗавершениюDataGridViewTextBoxColumn.DataPropertyName = "Оплата по завершению";
            this.оплатаПоЗавершениюDataGridViewTextBoxColumn.HeaderText = "Оплата по завершению";
            this.оплатаПоЗавершениюDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.оплатаПоЗавершениюDataGridViewTextBoxColumn.Name = "оплатаПоЗавершениюDataGridViewTextBoxColumn";
            this.оплатаПоЗавершениюDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаНачалаDataGridViewTextBoxColumn
            // 
            this.датаНачалаDataGridViewTextBoxColumn.DataPropertyName = "Дата начала";
            this.датаНачалаDataGridViewTextBoxColumn.HeaderText = "Дата начала";
            this.датаНачалаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаНачалаDataGridViewTextBoxColumn.Name = "датаНачалаDataGridViewTextBoxColumn";
            this.датаНачалаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаЗавершенияDataGridViewTextBoxColumn
            // 
            this.датаЗавершенияDataGridViewTextBoxColumn.DataPropertyName = "Дата завершения";
            this.датаЗавершенияDataGridViewTextBoxColumn.HeaderText = "Дата завершения";
            this.датаЗавершенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаЗавершенияDataGridViewTextBoxColumn.Name = "датаЗавершенияDataGridViewTextBoxColumn";
            this.датаЗавершенияDataGridViewTextBoxColumn.Width = 125;
            // 
            // ежемесячныеТратыDataGridViewTextBoxColumn
            // 
            this.ежемесячныеТратыDataGridViewTextBoxColumn.DataPropertyName = "Ежемесячные траты";
            this.ежемесячныеТратыDataGridViewTextBoxColumn.HeaderText = "Ежемесячные траты";
            this.ежемесячныеТратыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ежемесячныеТратыDataGridViewTextBoxColumn.Name = "ежемесячныеТратыDataGridViewTextBoxColumn";
            this.ежемесячныеТратыDataGridViewTextBoxColumn.Width = 125;
            // 
            // рабочаяГруппаDataGridViewTextBoxColumn
            // 
            this.рабочаяГруппаDataGridViewTextBoxColumn.DataPropertyName = "Рабочая группа";
            this.рабочаяГруппаDataGridViewTextBoxColumn.HeaderText = "Рабочая группа";
            this.рабочаяГруппаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.рабочаяГруппаDataGridViewTextBoxColumn.Name = "рабочаяГруппаDataGridViewTextBoxColumn";
            this.рабочаяГруппаDataGridViewTextBoxColumn.Width = 125;
            // 
            // ежемесячныйДоходDataGridViewTextBoxColumn
            // 
            this.ежемесячныйДоходDataGridViewTextBoxColumn.DataPropertyName = "Ежемесячный доход";
            this.ежемесячныйДоходDataGridViewTextBoxColumn.HeaderText = "Ежемесячный доход";
            this.ежемесячныйДоходDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ежемесячныйДоходDataGridViewTextBoxColumn.Name = "ежемесячныйДоходDataGridViewTextBoxColumn";
            this.ежемесячныйДоходDataGridViewTextBoxColumn.Width = 125;
            // 
            // прибыльDataGridViewTextBoxColumn
            // 
            this.прибыльDataGridViewTextBoxColumn.DataPropertyName = "Прибыль";
            this.прибыльDataGridViewTextBoxColumn.HeaderText = "Прибыль";
            this.прибыльDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.прибыльDataGridViewTextBoxColumn.Name = "прибыльDataGridViewTextBoxColumn";
            this.прибыльDataGridViewTextBoxColumn.Width = 125;
            // 
            // проектBindingSource
            // 
            this.проектBindingSource.DataMember = "Проект";
            this.проектBindingSource.DataSource = this._Модульное_МД_Финал_1_0DataSet;
            // 
            // _Модульное_МД_Финал_1_0DataSet
            // 
            this._Модульное_МД_Финал_1_0DataSet.DataSetName = "_Модульное_МД_Финал_1_0DataSet";
            this._Модульное_МД_Финал_1_0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // модульноеМДФинал10DataSetBindingSource
            // 
            this.модульноеМДФинал10DataSetBindingSource.DataSource = this._Модульное_МД_Финал_1_0DataSet;
            this.модульноеМДФинал10DataSetBindingSource.Position = 0;
            // 
            // проектTableAdapter
            // 
            this.проектTableAdapter.ClearBeforeFill = true;
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Projects";
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.Projects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.проектBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Модульное_МД_Финал_1_0DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.модульноеМДФинал10DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource модульноеМДФинал10DataSetBindingSource;
        private _Модульное_МД_Финал_1_0DataSet _Модульное_МД_Финал_1_0DataSet;
        private System.Windows.Forms.BindingSource проектBindingSource;
        private _Модульное_МД_Финал_1_0DataSetTableAdapters.ПроектTableAdapter проектTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn индексDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПроектаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авансDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оплатаПоЗавершениюDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗавершенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ежемесячныеТратыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn рабочаяГруппаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ежемесячныйДоходDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn прибыльDataGridViewTextBoxColumn;
    }
}