﻿namespace SchoolManagment.Forms
{
    partial class UpsertSubject
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
            textBox1 = new TextBox();
            subjectBindingSource = new BindingSource(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)subjectBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", subjectBindingSource, "SubjectName", true));
            textBox1.Location = new Point(55, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(327, 23);
            textBox1.TabIndex = 0;
            // 
            // subjectBindingSource
            // 
            subjectBindingSource.DataSource = typeof(Models.Subject);
            // 
            // button1
            // 
            button1.Location = new Point(90, 132);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "حفظ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UpsertSubject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 249);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "UpsertSubject";
            Text = "UpsertSubject";
            Load += UpsertSubject_Load;
            ((System.ComponentModel.ISupportInitialize)subjectBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private BindingSource subjectBindingSource;
        private Button button1;
    }
}