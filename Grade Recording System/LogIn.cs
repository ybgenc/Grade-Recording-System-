using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_Recording_System
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            StudentDetail frm = new StudentDetail();
            frm.number = StudentNumberTB.Text;
            frm.Show();
            this.Hide();
        }



        private void StudentNumberTB_TextChanged(object sender, EventArgs e)
        {
            if (StudentNumberTB.Text == "7000")
            {
                TeacherDetail frm = new TeacherDetail();
                frm.Show();
                this.Hide();
            }

        }
    }
}
