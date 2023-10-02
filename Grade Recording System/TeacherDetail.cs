using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grade_Recording_System
{
    public partial class TeacherDetail : Form
    {
        public TeacherDetail()
        {
            InitializeComponent();
        }

        SqlConnection newConnect = new SqlConnection(@"Data Source=Yusuf;Initial Catalog=DbExamRecord;Integrated Security=True");


        private void TeacherDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbExamRecordDataSet.TABLE_LESSON' table. You can move, or remove it, as needed.
            this.tABLE_LESSONTableAdapter.Fill(this.dbExamRecordDataSet.TABLE_LESSON);

        }


        private void SaveStudentButton_Click(object sender, EventArgs e)
        {
            newConnect.Open();
            SqlCommand command = new SqlCommand("insert into TABLE_LESSON (STUDENT_NUMBER,STUDENT_NAME,STUDENT_SURNAME) values (@p1,@p2,@p3)", newConnect );
            command.Parameters.AddWithValue("@p1", maskedTextBox1Number.Text);
            command.Parameters.AddWithValue("@p2", textBoxName.Text);
            command.Parameters.AddWithValue("@p3", TextboxSurname.Text);
            command.ExecuteNonQuery();
            newConnect.Close();
            MessageBox.Show("The student has been successfully registered");
            this.tABLE_LESSONTableAdapter.Fill(this.dbExamRecordDataSet.TABLE_LESSON);


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            textBoxExam1.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();    
            textBoxExam2.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            textBoxExam3.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
            maskedTextBox1Number.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            textBoxName.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            TextboxSurname.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
        }
        public string status;
        private void SaveGradeButton_Click(object sender, EventArgs e)
        {
            double average, e1, e2, e3;
            
            e1 = Convert.ToDouble(textBoxExam1.Text);
            e2 = Convert.ToDouble(textBoxExam2.Text);
            e3 = Convert.ToDouble(textBoxExam3.Text);

            average = (e1 + e2 + e3) / 3;
            AverageNumber.Text = average.ToString();

            if (average >= 50)
            {
                status = "True";
                


            }
            else
            {
                status = "False";
            }
        
            newConnect.Open();
            SqlCommand command = new SqlCommand("update TABLE_LESSON set STUDENT_EXAM_1=@p1, STUDENT_EXAM_2=@p2, STUDENT_EXAM_3=@p3, AVERAGE=@p4, " +
                "STATUS=@p5 WHERE STUDENT_NUMBER=@p6", newConnect);
            command.Parameters.AddWithValue("@p1", textBoxExam1.Text);
            command.Parameters.AddWithValue("@p2", textBoxExam2.Text);
            command.Parameters.AddWithValue("@p3", textBoxExam3.Text);
            command.Parameters.AddWithValue("@p4", decimal.Parse(AverageNumber.Text));
            command.Parameters.AddWithValue("@p5", status);
            command.Parameters.AddWithValue("@p6", maskedTextBox1Number.Text);
            command.ExecuteNonQuery();
            newConnect.Close();
            MessageBox.Show("Grades were successfully saved");
            this.tABLE_LESSONTableAdapter.Fill(this.dbExamRecordDataSet.TABLE_LESSON);

        }
    }
}
