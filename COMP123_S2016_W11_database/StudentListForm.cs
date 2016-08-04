using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace COMP123_S2016_W11_database
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
           

        }

        private void StudentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Create the new studentDetailsForm
           StudentDetailsForm StudentDetails = new StudentDetailsForm();
           StudentDetails.studentListForm = this;//make a reference to this form
           StudentDetails.FormType = e.ColumnIndex; //send over the button that is clicked

            //get the student id from the studentsDataGridView

           StudentDetails.StudentID = Convert.ToInt32(StudentDataGridView.Rows[e.RowIndex].Cells["StudentsId"].Value);
            Debug.WriteLine(StudentDetails.StudentID);

            //StudentDetails.Show(); // show the studenDerils FOrm
            //this.Hide();//Hide this FOrm
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            StudentDetailsForm addStudentForm = new StudentDetailsForm();
            addStudentForm.studentListForm = this;
            addStudentForm.Show();
            this.Hide();
        }

        private void StudentListForm_Activated(object sender, EventArgs e)
        {
           

            // TODO: This line of code loads data into the 'cOMP123DataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.cOMP123DataSet.Students);
        }
    }
}
