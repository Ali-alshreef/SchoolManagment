namespace SchoolManagment.Forms
{
    partial class FrmListOfStudent
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnEdit = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            btnRefresh = new Button();
            btnAddInThreeTables = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.White;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.White;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.White;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Image = Properties.Resources.customedit;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(279, 47);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(84, 41);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "تعديل";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Cursor = Cursors.Hand;
            btnNew.FlatAppearance.BorderColor = Color.White;
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatAppearance.MouseDownBackColor = Color.White;
            btnNew.FlatAppearance.MouseOverBackColor = Color.White;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Image = Properties.Resources.Addicon;
            btnNew.ImageAlign = ContentAlignment.MiddleLeft;
            btnNew.Location = new Point(595, 47);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(84, 41);
            btnNew.TabIndex = 11;
            btnNew.Text = "جديد";
            btnNew.TextAlign = ContentAlignment.MiddleRight;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = Color.White;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.White;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Image = Properties.Resources.Deleteicon;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(418, 47);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 41);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "حذف";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, birthDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = studentBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SkyBlue;
            dataGridViewCellStyle1.Font = new Font("29LT Bukra", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 127);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(860, 378);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Models.Student);
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.White;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.White;
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.White;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Image = Properties.Resources.Refresh;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(731, 47);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(84, 41);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "تحديث";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAddInThreeTables
            // 
            btnAddInThreeTables.Cursor = Cursors.Hand;
            btnAddInThreeTables.FlatAppearance.BorderColor = Color.White;
            btnAddInThreeTables.FlatAppearance.BorderSize = 0;
            btnAddInThreeTables.FlatAppearance.MouseDownBackColor = Color.White;
            btnAddInThreeTables.FlatAppearance.MouseOverBackColor = Color.White;
            btnAddInThreeTables.FlatStyle = FlatStyle.Flat;
            btnAddInThreeTables.Image = Properties.Resources.Addicon;
            btnAddInThreeTables.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddInThreeTables.Location = new Point(12, 47);
            btnAddInThreeTables.Name = "btnAddInThreeTables";
            btnAddInThreeTables.Size = new Size(224, 41);
            btnAddInThreeTables.TabIndex = 15;
            btnAddInThreeTables.Text = "اضافة طالب و مادة و مدينة";
            btnAddInThreeTables.TextAlign = ContentAlignment.MiddleRight;
            btnAddInThreeTables.UseVisualStyleBackColor = true;
            btnAddInThreeTables.Click += btnAddInThreeTables_Click;
            // 
            // FrmListOfStudent
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 505);
            Controls.Add(btnAddInThreeTables);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnEdit);
            Name = "FrmListOfStudent";
            Text = "ListOfStudent";
            Load += FrmListOfStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnEdit;
        private Button btnNew;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private BindingSource studentBindingSource;
        private Button btnRefresh;
        private Button btnAddInThreeTables;
    }
}