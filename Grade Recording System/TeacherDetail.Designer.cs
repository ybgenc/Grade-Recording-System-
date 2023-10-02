namespace Grade_Recording_System
{
    partial class TeacherDetail
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
            this.StudentRegisterGB = new System.Windows.Forms.GroupBox();
            this.SaveStudentButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.TextboxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.maskedTextBox1Number = new System.Windows.Forms.MaskedTextBox();
            this.GradeEntryGB = new System.Windows.Forms.GroupBox();
            this.textBoxExam1 = new System.Windows.Forms.TextBox();
            this.SaveGradeButton = new System.Windows.Forms.Button();
            this.Exam2L = new System.Windows.Forms.Label();
            this.Exam1L = new System.Windows.Forms.Label();
            this.textBoxExam3 = new System.Windows.Forms.TextBox();
            this.textBoxExam2 = new System.Windows.Forms.TextBox();
            this.Exam3L = new System.Windows.Forms.Label();
            this.PassedStudentLabel = new System.Windows.Forms.Label();
            this.PassedStudentNumber = new System.Windows.Forms.Label();
            this.FailedStudentLabel = new System.Windows.Forms.Label();
            this.FailedStudentNumber = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.AverageNumber = new System.Windows.Forms.Label();
            this.GradesGB = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sTUDENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTEXAM1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTEXAM2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTEXAM3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVERAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tABLELESSONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbExamRecordDataSet = new Grade_Recording_System.DbExamRecordDataSet();
            this.tABLE_LESSONTableAdapter = new Grade_Recording_System.DbExamRecordDataSetTableAdapters.TABLE_LESSONTableAdapter();
            this.StudentRegisterGB.SuspendLayout();
            this.GradeEntryGB.SuspendLayout();
            this.GradesGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLELESSONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbExamRecordDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentRegisterGB
            // 
            this.StudentRegisterGB.Controls.Add(this.SaveStudentButton);
            this.StudentRegisterGB.Controls.Add(this.NameLabel);
            this.StudentRegisterGB.Controls.Add(this.NumberLabel);
            this.StudentRegisterGB.Controls.Add(this.TextboxSurname);
            this.StudentRegisterGB.Controls.Add(this.textBoxName);
            this.StudentRegisterGB.Controls.Add(this.SurnameLabel);
            this.StudentRegisterGB.Controls.Add(this.maskedTextBox1Number);
            this.StudentRegisterGB.Location = new System.Drawing.Point(21, 20);
            this.StudentRegisterGB.Margin = new System.Windows.Forms.Padding(5);
            this.StudentRegisterGB.Name = "StudentRegisterGB";
            this.StudentRegisterGB.Padding = new System.Windows.Forms.Padding(5);
            this.StudentRegisterGB.Size = new System.Drawing.Size(1201, 94);
            this.StudentRegisterGB.TabIndex = 0;
            this.StudentRegisterGB.TabStop = false;
            this.StudentRegisterGB.Text = "Student Register";
            // 
            // SaveStudentButton
            // 
            this.SaveStudentButton.Location = new System.Drawing.Point(1000, 38);
            this.SaveStudentButton.Name = "SaveStudentButton";
            this.SaveStudentButton.Size = new System.Drawing.Size(193, 41);
            this.SaveStudentButton.TabIndex = 1;
            this.SaveStudentButton.Text = "Save Student";
            this.SaveStudentButton.UseVisualStyleBackColor = true;
            this.SaveStudentButton.Click += new System.EventHandler(this.SaveStudentButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(323, 45);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(80, 27);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name:";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(8, 42);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(103, 27);
            this.NumberLabel.TabIndex = 0;
            this.NumberLabel.Text = "Number:";
            // 
            // TextboxSurname
            // 
            this.TextboxSurname.Location = new System.Drawing.Point(765, 42);
            this.TextboxSurname.Name = "TextboxSurname";
            this.TextboxSurname.Size = new System.Drawing.Size(201, 34);
            this.TextboxSurname.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(430, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(201, 34);
            this.textBoxName.TabIndex = 2;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(637, 45);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(111, 27);
            this.SurnameLabel.TabIndex = 3;
            this.SurnameLabel.Text = "Surname:";
            // 
            // maskedTextBox1Number
            // 
            this.maskedTextBox1Number.Location = new System.Drawing.Point(121, 42);
            this.maskedTextBox1Number.Mask = "0000";
            this.maskedTextBox1Number.Name = "maskedTextBox1Number";
            this.maskedTextBox1Number.Size = new System.Drawing.Size(196, 34);
            this.maskedTextBox1Number.TabIndex = 1;
            this.maskedTextBox1Number.ValidatingType = typeof(int);
            // 
            // GradeEntryGB
            // 
            this.GradeEntryGB.Controls.Add(this.textBoxExam1);
            this.GradeEntryGB.Controls.Add(this.SaveGradeButton);
            this.GradeEntryGB.Controls.Add(this.Exam2L);
            this.GradeEntryGB.Controls.Add(this.Exam1L);
            this.GradeEntryGB.Controls.Add(this.textBoxExam3);
            this.GradeEntryGB.Controls.Add(this.textBoxExam2);
            this.GradeEntryGB.Controls.Add(this.Exam3L);
            this.GradeEntryGB.Location = new System.Drawing.Point(21, 129);
            this.GradeEntryGB.Margin = new System.Windows.Forms.Padding(5);
            this.GradeEntryGB.Name = "GradeEntryGB";
            this.GradeEntryGB.Padding = new System.Windows.Forms.Padding(5);
            this.GradeEntryGB.Size = new System.Drawing.Size(1204, 94);
            this.GradeEntryGB.TabIndex = 5;
            this.GradeEntryGB.TabStop = false;
            this.GradeEntryGB.Text = "Grade Entry";
            // 
            // textBoxExam1
            // 
            this.textBoxExam1.Location = new System.Drawing.Point(121, 32);
            this.textBoxExam1.Name = "textBoxExam1";
            this.textBoxExam1.Size = new System.Drawing.Size(201, 34);
            this.textBoxExam1.TabIndex = 5;
            // 
            // SaveGradeButton
            // 
            this.SaveGradeButton.Location = new System.Drawing.Point(1003, 28);
            this.SaveGradeButton.Name = "SaveGradeButton";
            this.SaveGradeButton.Size = new System.Drawing.Size(193, 41);
            this.SaveGradeButton.TabIndex = 1;
            this.SaveGradeButton.Text = "Save Grades";
            this.SaveGradeButton.UseVisualStyleBackColor = true;
            this.SaveGradeButton.Click += new System.EventHandler(this.SaveGradeButton_Click);
            // 
            // Exam2L
            // 
            this.Exam2L.AutoSize = true;
            this.Exam2L.Location = new System.Drawing.Point(328, 39);
            this.Exam2L.Name = "Exam2L";
            this.Exam2L.Size = new System.Drawing.Size(97, 27);
            this.Exam2L.TabIndex = 2;
            this.Exam2L.Text = "Exam 2:";
            // 
            // Exam1L
            // 
            this.Exam1L.AutoSize = true;
            this.Exam1L.Location = new System.Drawing.Point(11, 35);
            this.Exam1L.Name = "Exam1L";
            this.Exam1L.Size = new System.Drawing.Size(94, 27);
            this.Exam1L.TabIndex = 0;
            this.Exam1L.Text = "Exam 1:";
            // 
            // textBoxExam3
            // 
            this.textBoxExam3.Location = new System.Drawing.Point(765, 32);
            this.textBoxExam3.Name = "textBoxExam3";
            this.textBoxExam3.Size = new System.Drawing.Size(201, 34);
            this.textBoxExam3.TabIndex = 4;
            // 
            // textBoxExam2
            // 
            this.textBoxExam2.Location = new System.Drawing.Point(444, 32);
            this.textBoxExam2.Name = "textBoxExam2";
            this.textBoxExam2.Size = new System.Drawing.Size(201, 34);
            this.textBoxExam2.TabIndex = 2;
            // 
            // Exam3L
            // 
            this.Exam3L.AutoSize = true;
            this.Exam3L.Location = new System.Drawing.Point(651, 39);
            this.Exam3L.Name = "Exam3L";
            this.Exam3L.Size = new System.Drawing.Size(97, 27);
            this.Exam3L.TabIndex = 3;
            this.Exam3L.Text = "Exam 3:";
            // 
            // PassedStudentLabel
            // 
            this.PassedStudentLabel.AutoSize = true;
            this.PassedStudentLabel.Location = new System.Drawing.Point(29, 228);
            this.PassedStudentLabel.Name = "PassedStudentLabel";
            this.PassedStudentLabel.Size = new System.Drawing.Size(295, 27);
            this.PassedStudentLabel.TabIndex = 5;
            this.PassedStudentLabel.Text = "Number Of Passed Student:";
            // 
            // PassedStudentNumber
            // 
            this.PassedStudentNumber.AutoSize = true;
            this.PassedStudentNumber.Location = new System.Drawing.Point(344, 228);
            this.PassedStudentNumber.Name = "PassedStudentNumber";
            this.PassedStudentNumber.Size = new System.Drawing.Size(40, 27);
            this.PassedStudentNumber.TabIndex = 5;
            this.PassedStudentNumber.Text = "00";
            // 
            // FailedStudentLabel
            // 
            this.FailedStudentLabel.AutoSize = true;
            this.FailedStudentLabel.Location = new System.Drawing.Point(403, 228);
            this.FailedStudentLabel.Name = "FailedStudentLabel";
            this.FailedStudentLabel.Size = new System.Drawing.Size(289, 27);
            this.FailedStudentLabel.TabIndex = 6;
            this.FailedStudentLabel.Text = "Number Of Failed Student:";
            // 
            // FailedStudentNumber
            // 
            this.FailedStudentNumber.AutoSize = true;
            this.FailedStudentNumber.Location = new System.Drawing.Point(698, 228);
            this.FailedStudentNumber.Name = "FailedStudentNumber";
            this.FailedStudentNumber.Size = new System.Drawing.Size(40, 27);
            this.FailedStudentNumber.TabIndex = 7;
            this.FailedStudentNumber.Text = "00";
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Location = new System.Drawing.Point(755, 228);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(100, 27);
            this.AverageLabel.TabIndex = 8;
            this.AverageLabel.Text = "Average:";
            // 
            // AverageNumber
            // 
            this.AverageNumber.AutoSize = true;
            this.AverageNumber.Location = new System.Drawing.Point(861, 228);
            this.AverageNumber.Name = "AverageNumber";
            this.AverageNumber.Size = new System.Drawing.Size(40, 27);
            this.AverageNumber.TabIndex = 9;
            this.AverageNumber.Text = "00";
            // 
            // GradesGB
            // 
            this.GradesGB.Controls.Add(this.dataGridView1);
            this.GradesGB.Location = new System.Drawing.Point(34, 267);
            this.GradesGB.Name = "GradesGB";
            this.GradesGB.Size = new System.Drawing.Size(1191, 425);
            this.GradesGB.TabIndex = 10;
            this.GradesGB.TabStop = false;
            this.GradesGB.Text = "Grades";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTUDENTIDDataGridViewTextBoxColumn,
            this.sTUDENTNUMBERDataGridViewTextBoxColumn,
            this.sTUDENTNAMEDataGridViewTextBoxColumn,
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn,
            this.sTUDENTEXAM1DataGridViewTextBoxColumn,
            this.sTUDENTEXAM2DataGridViewTextBoxColumn,
            this.sTUDENTEXAM3DataGridViewTextBoxColumn,
            this.aVERAGEDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tABLELESSONBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1185, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sTUDENTIDDataGridViewTextBoxColumn
            // 
            this.sTUDENTIDDataGridViewTextBoxColumn.DataPropertyName = "STUDENT_ID";
            this.sTUDENTIDDataGridViewTextBoxColumn.HeaderText = "STUDENT_ID";
            this.sTUDENTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUDENTIDDataGridViewTextBoxColumn.Name = "sTUDENTIDDataGridViewTextBoxColumn";
            this.sTUDENTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTUDENTIDDataGridViewTextBoxColumn.Width = 190;
            // 
            // sTUDENTNUMBERDataGridViewTextBoxColumn
            // 
            this.sTUDENTNUMBERDataGridViewTextBoxColumn.DataPropertyName = "STUDENT_NUMBER";
            this.sTUDENTNUMBERDataGridViewTextBoxColumn.HeaderText = "STUDENT_NUMBER";
            this.sTUDENTNUMBERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUDENTNUMBERDataGridViewTextBoxColumn.Name = "sTUDENTNUMBERDataGridViewTextBoxColumn";
            this.sTUDENTNUMBERDataGridViewTextBoxColumn.Width = 266;
            // 
            // sTUDENTNAMEDataGridViewTextBoxColumn
            // 
            this.sTUDENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUDENT_NAME";
            this.sTUDENTNAMEDataGridViewTextBoxColumn.HeaderText = "STUDENT_NAME";
            this.sTUDENTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUDENTNAMEDataGridViewTextBoxColumn.Name = "sTUDENTNAMEDataGridViewTextBoxColumn";
            this.sTUDENTNAMEDataGridViewTextBoxColumn.Width = 233;
            // 
            // sTUDENTSURNAMEDataGridViewTextBoxColumn
            // 
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "STUDENT_SURNAME";
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn.HeaderText = "STUDENT_SURNAME";
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn.Name = "sTUDENTSURNAMEDataGridViewTextBoxColumn";
            this.sTUDENTSURNAMEDataGridViewTextBoxColumn.Width = 279;
            // 
            // sTUDENTEXAM1DataGridViewTextBoxColumn
            // 
            this.sTUDENTEXAM1DataGridViewTextBoxColumn.DataPropertyName = "STUDENT_EXAM_1";
            this.sTUDENTEXAM1DataGridViewTextBoxColumn.HeaderText = "STUDENT_EXAM_1";
            this.sTUDENTEXAM1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUDENTEXAM1DataGridViewTextBoxColumn.Name = "sTUDENTEXAM1DataGridViewTextBoxColumn";
            this.sTUDENTEXAM1DataGridViewTextBoxColumn.Width = 256;
            // 
            // sTUDENTEXAM2DataGridViewTextBoxColumn
            // 
            this.sTUDENTEXAM2DataGridViewTextBoxColumn.DataPropertyName = "STUDENT_EXAM_2";
            this.sTUDENTEXAM2DataGridViewTextBoxColumn.HeaderText = "STUDENT_EXAM_2";
            this.sTUDENTEXAM2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUDENTEXAM2DataGridViewTextBoxColumn.Name = "sTUDENTEXAM2DataGridViewTextBoxColumn";
            this.sTUDENTEXAM2DataGridViewTextBoxColumn.Width = 259;
            // 
            // sTUDENTEXAM3DataGridViewTextBoxColumn
            // 
            this.sTUDENTEXAM3DataGridViewTextBoxColumn.DataPropertyName = "STUDENT_EXAM_3";
            this.sTUDENTEXAM3DataGridViewTextBoxColumn.HeaderText = "STUDENT_EXAM_3";
            this.sTUDENTEXAM3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUDENTEXAM3DataGridViewTextBoxColumn.Name = "sTUDENTEXAM3DataGridViewTextBoxColumn";
            this.sTUDENTEXAM3DataGridViewTextBoxColumn.Width = 259;
            // 
            // aVERAGEDataGridViewTextBoxColumn
            // 
            this.aVERAGEDataGridViewTextBoxColumn.DataPropertyName = "AVERAGE";
            this.aVERAGEDataGridViewTextBoxColumn.HeaderText = "AVERAGE";
            this.aVERAGEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aVERAGEDataGridViewTextBoxColumn.Name = "aVERAGEDataGridViewTextBoxColumn";
            this.aVERAGEDataGridViewTextBoxColumn.Width = 149;
            // 
            // sTATUSDataGridViewCheckBoxColumn
            // 
            this.sTATUSDataGridViewCheckBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewCheckBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.sTATUSDataGridViewCheckBoxColumn.Name = "sTATUSDataGridViewCheckBoxColumn";
            this.sTATUSDataGridViewCheckBoxColumn.Width = 104;
            // 
            // tABLELESSONBindingSource
            // 
            this.tABLELESSONBindingSource.DataMember = "TABLE_LESSON";
            this.tABLELESSONBindingSource.DataSource = this.dbExamRecordDataSet;
            // 
            // dbExamRecordDataSet
            // 
            this.dbExamRecordDataSet.DataSetName = "DbExamRecordDataSet";
            this.dbExamRecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tABLE_LESSONTableAdapter
            // 
            this.tABLE_LESSONTableAdapter.ClearBeforeFill = true;
            // 
            // TeacherDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 722);
            this.Controls.Add(this.GradesGB);
            this.Controls.Add(this.AverageNumber);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.FailedStudentNumber);
            this.Controls.Add(this.FailedStudentLabel);
            this.Controls.Add(this.PassedStudentNumber);
            this.Controls.Add(this.PassedStudentLabel);
            this.Controls.Add(this.GradeEntryGB);
            this.Controls.Add(this.StudentRegisterGB);
            this.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TeacherDetail";
            this.Text = "Student Grade Recording System";
            this.Load += new System.EventHandler(this.TeacherDetail_Load);
            this.StudentRegisterGB.ResumeLayout(false);
            this.StudentRegisterGB.PerformLayout();
            this.GradeEntryGB.ResumeLayout(false);
            this.GradeEntryGB.PerformLayout();
            this.GradesGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tABLELESSONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbExamRecordDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox StudentRegisterGB;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1Number;
        private System.Windows.Forms.Button SaveStudentButton;
        private System.Windows.Forms.TextBox TextboxSurname;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.GroupBox GradeEntryGB;
        private System.Windows.Forms.Button SaveGradeButton;
        private System.Windows.Forms.Label Exam2L;
        private System.Windows.Forms.Label Exam1L;
        private System.Windows.Forms.TextBox textBoxExam3;
        private System.Windows.Forms.TextBox textBoxExam2;
        private System.Windows.Forms.Label Exam3L;
        private System.Windows.Forms.Label PassedStudentLabel;
        private System.Windows.Forms.Label PassedStudentNumber;
        private System.Windows.Forms.Label FailedStudentLabel;
        private System.Windows.Forms.Label FailedStudentNumber;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.Label AverageNumber;
        private System.Windows.Forms.GroupBox GradesGB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbExamRecordDataSet dbExamRecordDataSet;
        private System.Windows.Forms.BindingSource tABLELESSONBindingSource;
        private DbExamRecordDataSetTableAdapters.TABLE_LESSONTableAdapter tABLE_LESSONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTEXAM1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTEXAM2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTEXAM3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVERAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sTATUSDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox textBoxExam1;
    }
}