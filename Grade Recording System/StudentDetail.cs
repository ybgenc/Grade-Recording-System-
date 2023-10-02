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
    public partial class StudentDetail : Form
    {
        public StudentDetail()
        {
            InitializeComponent();
        }

        public string  number;
        SqlConnection newConnect = new SqlConnection(@"Data Source=Yusuf;Initial Catalog=DbExamRecord;Integrated Security=True");
        private void StudentDetail_Load(object sender, EventArgs e)
        {
            StdNmbr.Text = number;
            newConnect.Open();
            SqlCommand newCommand = new SqlCommand("Select * From TABLE_LESSON where STUDENT_NUMBER=@p1",newConnect);
            newCommand.Parameters.AddWithValue("@p1", number);
            SqlDataReader reader = newCommand.ExecuteReader();
            while (reader.Read())
            {
                StdNmSrnm.Text = reader[2].ToString() + " " + reader[3].ToString();
                stdExm1.Text = reader[4].ToString();
                stdExm2.Text = reader[5].ToString();
                stdExm3.Text = reader[6].ToString();
                stdAvrg.Text = reader[7].ToString();
                StdStts.Text = reader[8].ToString();
            }
            if (StdStts.Text == "True")
            {
                StdStts.Text = "Passed";
            }
            else
            {
                StdStts.Text = "Failed";
            }
            newConnect.Close();


        }
    }
}
