
namespace Maket_2._0
{
    partial class Editing
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
            this._Модульное_МД_Финал_1_0DataSet = new Maket_2._0._Модульное_МД_Финал_1_0DataSet();
            this.офисыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.офисыTableAdapter = new Maket_2._0._Модульное_МД_Финал_1_0DataSetTableAdapters.ОфисыTableAdapter();
            this.персоналTableAdapter = new Maket_2._0._Модульное_МД_Финал_1_0DataSetTableAdapters.ПерсоналTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.PersonalButton = new System.Windows.Forms.Button();
            this.ProjectsButton = new System.Windows.Forms.Button();
            this.OfficesButton = new System.Windows.Forms.Button();
            this.PartyButton = new System.Windows.Forms.Button();
            this.RequestsButton = new System.Windows.Forms.Button();
            this.TransportButton = new System.Windows.Forms.Button();
            this.GroupsButton = new System.Windows.Forms.Button();
            this.офисыПерсоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._Модульное_МД_Финал_1_0DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.офисыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.офисыПерсоналBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // персоналTableAdapter
            // 
            this.персоналTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите таблицу, которую хотите редактировать";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PersonalButton
            // 
            this.PersonalButton.Location = new System.Drawing.Point(39, 71);
            this.PersonalButton.Name = "PersonalButton";
            this.PersonalButton.Size = new System.Drawing.Size(172, 37);
            this.PersonalButton.TabIndex = 2;
            this.PersonalButton.Text = "Персонал";
            this.PersonalButton.UseVisualStyleBackColor = true;
            this.PersonalButton.Click += new System.EventHandler(this.PersonalButton_Click);
            // 
            // ProjectsButton
            // 
            this.ProjectsButton.Location = new System.Drawing.Point(39, 243);
            this.ProjectsButton.Name = "ProjectsButton";
            this.ProjectsButton.Size = new System.Drawing.Size(172, 37);
            this.ProjectsButton.TabIndex = 3;
            this.ProjectsButton.Text = "Проекты";
            this.ProjectsButton.UseVisualStyleBackColor = true;
            this.ProjectsButton.Click += new System.EventHandler(this.ProjectsButton_Click);
            // 
            // OfficesButton
            // 
            this.OfficesButton.Location = new System.Drawing.Point(39, 200);
            this.OfficesButton.Name = "OfficesButton";
            this.OfficesButton.Size = new System.Drawing.Size(172, 37);
            this.OfficesButton.TabIndex = 4;
            this.OfficesButton.Text = "Офисы";
            this.OfficesButton.UseVisualStyleBackColor = true;
            this.OfficesButton.Click += new System.EventHandler(this.OfficesButton_Click);
            // 
            // PartyButton
            // 
            this.PartyButton.Location = new System.Drawing.Point(39, 157);
            this.PartyButton.Name = "PartyButton";
            this.PartyButton.Size = new System.Drawing.Size(172, 37);
            this.PartyButton.TabIndex = 5;
            this.PartyButton.Text = "Мероприятия";
            this.PartyButton.UseVisualStyleBackColor = true;
            this.PartyButton.Click += new System.EventHandler(this.PartyButton_Click);
            // 
            // RequestsButton
            // 
            this.RequestsButton.Location = new System.Drawing.Point(39, 114);
            this.RequestsButton.Name = "RequestsButton";
            this.RequestsButton.Size = new System.Drawing.Size(172, 37);
            this.RequestsButton.TabIndex = 6;
            this.RequestsButton.Text = "Запросы";
            this.RequestsButton.UseVisualStyleBackColor = true;
            this.RequestsButton.Click += new System.EventHandler(this.RequestsButton_Click);
            // 
            // TransportButton
            // 
            this.TransportButton.Location = new System.Drawing.Point(39, 329);
            this.TransportButton.Name = "TransportButton";
            this.TransportButton.Size = new System.Drawing.Size(172, 37);
            this.TransportButton.TabIndex = 8;
            this.TransportButton.Text = "Транспорт";
            this.TransportButton.UseVisualStyleBackColor = true;
            this.TransportButton.Click += new System.EventHandler(this.TransportButton_Click);
            // 
            // GroupsButton
            // 
            this.GroupsButton.Location = new System.Drawing.Point(39, 286);
            this.GroupsButton.Name = "GroupsButton";
            this.GroupsButton.Size = new System.Drawing.Size(172, 37);
            this.GroupsButton.TabIndex = 9;
            this.GroupsButton.Text = "Рабочие группы";
            this.GroupsButton.UseVisualStyleBackColor = true;
            this.GroupsButton.Click += new System.EventHandler(this.GroupsButton_Click);
            // 
            // офисыПерсоналBindingSource
            // 
            this.офисыПерсоналBindingSource.DataMember = "ОфисыПерсонал";
            this.офисыПерсоналBindingSource.DataSource = this.офисыBindingSource;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(295, 284);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(96, 82);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Editing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.GroupsButton);
            this.Controls.Add(this.TransportButton);
            this.Controls.Add(this.RequestsButton);
            this.Controls.Add(this.PartyButton);
            this.Controls.Add(this.OfficesButton);
            this.Controls.Add(this.ProjectsButton);
            this.Controls.Add(this.PersonalButton);
            this.Controls.Add(this.label2);
            this.Name = "Editing";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Модульное_МД_Финал_1_0DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.офисыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.офисыПерсоналBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private _Модульное_МД_Финал_1_0DataSet _Модульное_МД_Финал_1_0DataSet;
        private System.Windows.Forms.BindingSource офисыBindingSource;
        private _Модульное_МД_Финал_1_0DataSetTableAdapters.ОфисыTableAdapter офисыTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource офисыПерсоналBindingSource;
        private _Модульное_МД_Финал_1_0DataSetTableAdapters.ПерсоналTableAdapter персоналTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PersonalButton;
        private System.Windows.Forms.Button ProjectsButton;
        private System.Windows.Forms.Button OfficesButton;
        private System.Windows.Forms.Button PartyButton;
        private System.Windows.Forms.Button RequestsButton;
        private System.Windows.Forms.Button TransportButton;
        private System.Windows.Forms.Button GroupsButton;
        private System.Windows.Forms.Button CloseButton;
    }
}

