namespace FuelControl
{
    partial class ManagerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UpdareServiceBtn = new System.Windows.Forms.Button();
            this.UpdateLimitBtn = new System.Windows.Forms.Button();
            this.SetExpenditureBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoTable = new System.Windows.Forms.DataGridView();
            this.ModelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plankNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeFuelCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenditureCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mileageAllCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedServiceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftToServiceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableMileageLimitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIntervalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1083, 100);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = " ";
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.UpdareServiceBtn);
            this.tabPage1.Controls.Add(this.UpdateLimitBtn);
            this.tabPage1.Controls.Add(this.SetExpenditureBtn);
            this.tabPage1.Controls.Add(this.DeleteBtn);
            this.tabPage1.Controls.Add(this.AddBtn);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1075, 72);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Автомобили";
            // 
            // UpdareServiceBtn
            // 
            this.UpdareServiceBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdareServiceBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdareServiceBtn.FlatAppearance.BorderSize = 0;
            this.UpdareServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdareServiceBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdareServiceBtn.Location = new System.Drawing.Point(733, 3);
            this.UpdareServiceBtn.Name = "UpdareServiceBtn";
            this.UpdareServiceBtn.Size = new System.Drawing.Size(96, 66);
            this.UpdareServiceBtn.TabIndex = 8;
            this.UpdareServiceBtn.Text = "Отметка о ТО";
            this.UpdareServiceBtn.UseVisualStyleBackColor = false;
            this.UpdareServiceBtn.Click += new System.EventHandler(this.UpdateService_Click);
            // 
            // UpdateLimitBtn
            // 
            this.UpdateLimitBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateLimitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateLimitBtn.FlatAppearance.BorderSize = 0;
            this.UpdateLimitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateLimitBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateLimitBtn.Location = new System.Drawing.Point(492, 3);
            this.UpdateLimitBtn.Name = "UpdateLimitBtn";
            this.UpdateLimitBtn.Size = new System.Drawing.Size(96, 66);
            this.UpdateLimitBtn.TabIndex = 7;
            this.UpdateLimitBtn.Text = "Выдать лимит на месяц";
            this.UpdateLimitBtn.UseVisualStyleBackColor = false;
            this.UpdateLimitBtn.Click += new System.EventHandler(this.UpdateLimit_Click);
            // 
            // SetExpenditureBtn
            // 
            this.SetExpenditureBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SetExpenditureBtn.FlatAppearance.BorderSize = 0;
            this.SetExpenditureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetExpenditureBtn.ForeColor = System.Drawing.Color.White;
            this.SetExpenditureBtn.Location = new System.Drawing.Point(244, 3);
            this.SetExpenditureBtn.Name = "SetExpenditureBtn";
            this.SetExpenditureBtn.Size = new System.Drawing.Size(96, 66);
            this.SetExpenditureBtn.TabIndex = 6;
            this.SetExpenditureBtn.Text = "Изменить расход (лето/зима)";
            this.SetExpenditureBtn.UseVisualStyleBackColor = true;
            this.SetExpenditureBtn.Click += new System.EventHandler(this.SetExpenditureBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DeleteBtn.Location = new System.Drawing.Point(956, 3);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(96, 66);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Удалить авто";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(21, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(96, 66);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Добавить авто";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1075, 72);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Моторная техника";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(212, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 60);
            this.button6.TabIndex = 6;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(109, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 60);
            this.button7.TabIndex = 5;
            this.button7.Text = "Редактировать";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(97, 60);
            this.button8.TabIndex = 4;
            this.button8.Text = "Добавить";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1075, 72);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отчеты";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(895, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 56);
            this.button2.TabIndex = 13;
            this.button2.Text = "Просмотр отчетов за период";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(457, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 56);
            this.button1.TabIndex = 12;
            this.button1.Text = "Просмотр прмежуточных отчетов авто";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowReport_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(238, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 56);
            this.button5.TabIndex = 9;
            this.button5.Text = "Заполнить дневной отчет(моторная техника)";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(19, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 56);
            this.button4.TabIndex = 4;
            this.button4.Text = "Заполнить дневной отчет (легковые)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AddReportBtn_Click);
            // 
            // num
            // 
            this.num.HeaderText = "№";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // AutoTable
            // 
            this.AutoTable.AllowUserToAddRows = false;
            this.AutoTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.BlueViolet;
            this.AutoTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AutoTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AutoTable.BackgroundColor = System.Drawing.Color.SlateGray;
            this.AutoTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AutoTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.AutoTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AutoTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AutoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModelCol,
            this.plankNumCol,
            this.typeFuelCol,
            this.expenditureCol,
            this.mileageAllCol,
            this.limitCol,
            this.plannedServiceCol,
            this.leftToServiceCol,
            this.availableMileageLimitCol,
            this.serviceIntervalCol});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AutoTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.AutoTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AutoTable.EnableHeadersVisualStyles = false;
            this.AutoTable.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AutoTable.Location = new System.Drawing.Point(0, 100);
            this.AutoTable.Margin = new System.Windows.Forms.Padding(0);
            this.AutoTable.Name = "AutoTable";
            this.AutoTable.ReadOnly = true;
            this.AutoTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AutoTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.AutoTable.RowHeadersVisible = false;
            this.AutoTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Brown;
            this.AutoTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.AutoTable.RowTemplate.Height = 25;
            this.AutoTable.Size = new System.Drawing.Size(1083, 252);
            this.AutoTable.TabIndex = 1;
            // 
            // ModelCol
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            this.ModelCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.ModelCol.HeaderText = "Марка авто";
            this.ModelCol.Name = "ModelCol";
            this.ModelCol.ReadOnly = true;
            // 
            // plankNumCol
            // 
            this.plankNumCol.HeaderText = "ГОС номер";
            this.plankNumCol.Name = "plankNumCol";
            this.plankNumCol.ReadOnly = true;
            // 
            // typeFuelCol
            // 
            this.typeFuelCol.HeaderText = "Вид топлива";
            this.typeFuelCol.Name = "typeFuelCol";
            this.typeFuelCol.ReadOnly = true;
            // 
            // expenditureCol
            // 
            this.expenditureCol.HeaderText = "Расход";
            this.expenditureCol.Name = "expenditureCol";
            this.expenditureCol.ReadOnly = true;
            // 
            // mileageAllCol
            // 
            this.mileageAllCol.HeaderText = "Пробег общий";
            this.mileageAllCol.Name = "mileageAllCol";
            this.mileageAllCol.ReadOnly = true;
            // 
            // limitCol
            // 
            this.limitCol.HeaderText = "Лимит топлива";
            this.limitCol.Name = "limitCol";
            this.limitCol.ReadOnly = true;
            // 
            // plannedServiceCol
            // 
            this.plannedServiceCol.HeaderText = "Провести ТО при пробеге ";
            this.plannedServiceCol.Name = "plannedServiceCol";
            this.plannedServiceCol.ReadOnly = true;
            // 
            // leftToServiceCol
            // 
            this.leftToServiceCol.HeaderText = "До ТО осталось";
            this.leftToServiceCol.Name = "leftToServiceCol";
            this.leftToServiceCol.ReadOnly = true;
            // 
            // availableMileageLimitCol
            // 
            this.availableMileageLimitCol.HeaderText = "Доступный пробег по лимиту";
            this.availableMileageLimitCol.Name = "availableMileageLimitCol";
            this.availableMileageLimitCol.ReadOnly = true;
            // 
            // serviceIntervalCol
            // 
            this.serviceIntervalCol.HeaderText = "Меж сервисный интервал";
            this.serviceIntervalCol.Name = "serviceIntervalCol";
            this.serviceIntervalCol.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(676, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 56);
            this.button3.TabIndex = 14;
            this.button3.Text = "Просмотр прмежуточных отчетов моторная техника";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ManegerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1083, 352);
            this.Controls.Add(this.AutoTable);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "ManegerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контроль ГСМ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AutoTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private Button DeleteBtn;
        private Button AddBtn;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button5;
        private Button button4;
        private DataGridViewTextBoxColumn num;
        private DataGridView AutoTable;
        private Button UpdateLimitBtn;
        private Button SetExpenditureBtn;
        private Button UpdareServiceBtn;
        private DataGridViewTextBoxColumn ModelCol;
        private DataGridViewTextBoxColumn plankNumCol;
        private DataGridViewTextBoxColumn typeFuelCol;
        private DataGridViewTextBoxColumn expenditureCol;
        private DataGridViewTextBoxColumn mileageAllCol;
        private DataGridViewTextBoxColumn limitCol;
        private DataGridViewTextBoxColumn plannedServiceCol;
        private DataGridViewTextBoxColumn leftToServiceCol;
        private DataGridViewTextBoxColumn availableMileageLimitCol;
        private DataGridViewTextBoxColumn serviceIntervalCol;
        public TabPage tabPage1;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}