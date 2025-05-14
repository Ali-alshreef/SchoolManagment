namespace SchoolManagment.Forms
{
    partial class FrmUpsertStudent
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
            label1 = new Label();
            txtFullName = new TextBox();
            studentBindingSource = new BindingSource(components);
            txtId = new TextBox();
            label2 = new Label();
            DTPBithDate = new DateTimePicker();
            label3 = new Label();
            CBGenderType = new ComboBox();
            btnNew = new Button();
            btnSave = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 95);
            label1.Name = "label1";
            label1.Size = new Size(51, 16);
            label1.TabIndex = 0;
            label1.Text = "الاسم";
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFullName.DataBindings.Add(new Binding("Text", studentBindingSource, "FullName", true));
            txtFullName.Location = new Point(166, 92);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(292, 24);
            txtFullName.TabIndex = 1;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Models.Student);
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtId.DataBindings.Add(new Binding("Text", studentBindingSource, "Id", true));
            txtId.Location = new Point(166, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(110, 24);
            txtId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 46);
            label2.Name = "label2";
            label2.Size = new Size(21, 16);
            label2.TabIndex = 2;
            label2.Text = "Id";
            // 
            // DTPBithDate
            // 
            DTPBithDate.CustomFormat = "MM-yyyy-dd";
            DTPBithDate.DataBindings.Add(new Binding("Text", studentBindingSource, "BirthDate", true));
            DTPBithDate.DataBindings.Add(new Binding("Value", studentBindingSource, "BirthDate", true));
            DTPBithDate.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DTPBithDate.Format = DateTimePickerFormat.Short;
            DTPBithDate.Location = new Point(166, 139);
            DTPBithDate.Name = "DTPBithDate";
            DTPBithDate.Size = new Size(163, 26);
            DTPBithDate.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 147);
            label3.Name = "label3";
            label3.Size = new Size(85, 16);
            label3.TabIndex = 5;
            label3.Text = "تاريخ الميلاد";
            // 
            // CBGenderType
            // 
            CBGenderType.FormattingEnabled = true;
            CBGenderType.Location = new Point(166, 189);
            CBGenderType.Name = "CBGenderType";
            CBGenderType.Size = new Size(220, 24);
            CBGenderType.TabIndex = 6;
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
            btnNew.Location = new Point(130, 243);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(84, 41);
            btnNew.TabIndex = 9;
            btnNew.Text = "جديد";
            btnNew.TextAlign = ContentAlignment.MiddleRight;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.White;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseDownBackColor = Color.White;
            btnSave.FlatAppearance.MouseOverBackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Image = Properties.Resources.saveicon;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(348, 243);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(84, 41);
            btnSave.TabIndex = 10;
            btnSave.Text = "حفظ";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 192);
            label4.Name = "label4";
            label4.Size = new Size(50, 16);
            label4.TabIndex = 11;
            label4.Text = "الجنس";
            // 
            // FrmUpsertStudent
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(536, 314);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(CBGenderType);
            Controls.Add(label3);
            Controls.Add(DTPBithDate);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5, 3, 5, 3);
            Name = "FrmUpsertStudent";
            Text = "FrmUpsertStudent";
            Load += FrmUpsertStudent_Load;
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFullName;
        private TextBox txtId;
        private Label label2;
        private DateTimePicker DTPBithDate;
        private Label label3;
        private ComboBox CBGenderType;
        private Button btnNew;
        private Button btnSave;
        private Label label4;
        private BindingSource studentBindingSource;
    }
}