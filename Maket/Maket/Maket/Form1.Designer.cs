
namespace Maket
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this._Модульное_МД_Финал_1_0DataSet = new Maket._Модульное_МД_Финал_1_0DataSet();
            this.офисыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.офисыTableAdapter = new Maket._Модульное_МД_Финал_1_0DataSetTableAdapters.ОфисыTableAdapter();
            this.проектBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.проектTableAdapter = new Maket._Модульное_МД_Финал_1_0DataSetTableAdapters.ПроектTableAdapter();
            this.офисыТребованияПерсоналаИОфисовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запросTableAdapter = new Maket._Модульное_МД_Финал_1_0DataSetTableAdapters.ЗапросTableAdapter();
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
            this.номерОфисаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расположениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоЧеловекDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.арендаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Модульное_МД_Финал_1_0DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.офисыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.проектBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.офисыТребованияПерсоналаИОфисовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1309, 137);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерОфисаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.расположениеDataGridViewTextBoxColumn,
            this.количествоЧеловекDataGridViewTextBoxColumn,
            this.арендаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.офисыBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(228, 220);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(680, 131);
            this.dataGridView2.TabIndex = 1;
            // 
            // _Модульное_МД_Финал_1_0DataSet
            // 
            this._Модульное_МД_Финал_1_0DataSet.DataSetName = "_Модульное_МД_Финал_1_0DataSet";
            this._Модульное_МД_Финал_1_0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // офисыBindingSource
            // 
            this.офисыBindingSource.DataMember = "Офисы";
            this.офисыBindingSource.DataSource = this._Модульное_МД_Финал_1_0DataSet;
            // 
            // офисыTableAdapter
            // 
            this.офисыTableAdapter.ClearBeforeFill = true;
            // 
            // проектBindingSource
            // 
            this.проектBindingSource.DataMember = "Проект";
            this.проектBindingSource.DataSource = this._Модульное_МД_Финал_1_0DataSet;
            // 
            // проектTableAdapter
            // 
            this.проектTableAdapter.ClearBeforeFill = true;
            // 
            // офисыТребованияПерсоналаИОфисовBindingSource
            // 
            this.офисыТребованияПерсоналаИОфисовBindingSource.DataMember = "ОфисыТребования персонала и офисов";
            this.офисыТребованияПерсоналаИОфисовBindingSource.DataSource = this.офисыBindingSource;
            // 
            // запросTableAdapter
            // 
            this.запросTableAdapter.ClearBeforeFill = true;
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
            // номерОфисаDataGridViewTextBoxColumn
            // 
            this.номерОфисаDataGridViewTextBoxColumn.DataPropertyName = "Номер офиса";
            this.номерОфисаDataGridViewTextBoxColumn.HeaderText = "Номер офиса";
            this.номерОфисаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерОфисаDataGridViewTextBoxColumn.Name = "номерОфисаDataGridViewTextBoxColumn";
            this.номерОфисаDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // расположениеDataGridViewTextBoxColumn
            // 
            this.расположениеDataGridViewTextBoxColumn.DataPropertyName = "Расположение";
            this.расположениеDataGridViewTextBoxColumn.HeaderText = "Расположение";
            this.расположениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.расположениеDataGridViewTextBoxColumn.Name = "расположениеDataGridViewTextBoxColumn";
            this.расположениеDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествоЧеловекDataGridViewTextBoxColumn
            // 
            this.количествоЧеловекDataGridViewTextBoxColumn.DataPropertyName = "Количество человек";
            this.количествоЧеловекDataGridViewTextBoxColumn.HeaderText = "Количество человек";
            this.количествоЧеловекDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоЧеловекDataGridViewTextBoxColumn.Name = "количествоЧеловекDataGridViewTextBoxColumn";
            this.количествоЧеловекDataGridViewTextBoxColumn.Width = 125;
            // 
            // арендаDataGridViewTextBoxColumn
            // 
            this.арендаDataGridViewTextBoxColumn.DataPropertyName = "Аренда";
            this.арендаDataGridViewTextBoxColumn.HeaderText = "Аренда";
            this.арендаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.арендаDataGridViewTextBoxColumn.Name = "арендаDataGridViewTextBoxColumn";
            this.арендаDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Модульное_МД_Финал_1_0DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.офисыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.проектBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.офисыТребованияПерсоналаИОфисовBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private _Модульное_МД_Финал_1_0DataSet _Модульное_МД_Финал_1_0DataSet;
        private System.Windows.Forms.BindingSource офисыBindingSource;
        private _Модульное_МД_Финал_1_0DataSetTableAdapters.ОфисыTableAdapter офисыTableAdapter;
        private System.Windows.Forms.BindingSource проектBindingSource;
        private _Модульное_МД_Финал_1_0DataSetTableAdapters.ПроектTableAdapter проектTableAdapter;
        private System.Windows.Forms.BindingSource офисыТребованияПерсоналаИОфисовBindingSource;
        private _Модульное_МД_Финал_1_0DataSetTableAdapters.ЗапросTableAdapter запросTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn номерОфисаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn расположениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоЧеловекDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn арендаDataGridViewTextBoxColumn;
    }
}

