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

        private void RemoveHeaderTextFromButtonColimn(string columnString)
        {
            DataGridViewButtonColumn Column = (DataGridViewButtonColumn)StudentDataGridView.Columns[columnString];
           Column.HeaderText = String.Empty;
            Column.ReadOnly = false;
            if(columnString == "Edit")
            {
                Column.CellTemplate.Style.ForeColor = Color.Blue;
            }
            if(columnString == "Delete")
            {
                Column.CellTemplate.Style.ForeColor = Color.Blue;
            }
        }
        private void StudentListForm_Load(object sender, EventArgs e)
        {
            this.RemoveHeaderTextFromButtonColimn("Details");
            this.RemoveHeaderTextFromButtonColimn("Edit");
            this.RemoveHeaderTextFromButtonColimn("Delete");
        
        }

        private void StudentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if header row not Clicked and Details, Edit or Delete columns are clicked
            if ((e.RowIndex != -1) && (e.ColumnIndex > 3))
            {
                // Create the new studentDetailsForm
                StudentDetailsForm StudentDetails = new StudentDetailsForm();
                StudentDetails.studentListForm = this;//make a reference to this form
                StudentDetails.FormType = e.ColumnIndex; //send over the button that is clicked

                //get the student id from the studentsDataGridView

                StudentDetails.StudentID = Convert.ToInt32(StudentDataGridView.Rows[e.RowIndex].Cells["StudentID"].Value);
                //Debug.WriteLine(StudentDetails.StudentID);

                StudentDetails.Show(); // show the studenDerils FOrm
                this.Hide();//Hide this FOrm
            }
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
            // TODO: This line of code loads data into the 'cOMP123DataSet.Students' table. You can move, or remove it, as needed
            this.studentsTableAdapter.Fill(this.cOMP123DataSet.Students);

            // it has already included  "this.studentsTableAdapter.Fill(this.cOMP123DataSet.Students)"
            StudentDataContext db = new StudentDataContext();
            List<Student> studentList = (from student in db.Students
                                   select student).ToList();
            StudentDataGridView.DataSource = studentList;
           
           
        }
    }
}
