using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_W11_database
{
    public partial class AddStudentForm : Form
    {
        //piblic property
        public StudentListForm studentListForm { get; set; }//references previous form 
        public int FormType { get; set; }//what type form do I need?
        public int StudentId { get; set; }//what is the studentID of the row that is clicked?


        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  // creates a reference to the SQL DATABASE 
            StudentListForm db = new StudentListForm();

            //copy data into student object from form TExt Boxes
            //Student newStudent = new Student();

            //newStudent.FirstName = FirstNameTextBox.Text;
            //newStudent.LastName = LastNameTextBox.Text;
            //newStudent.StudentNumber = StudentNumberTextBox.Text

            //Insert the new Student Object into the SQL Database
            //db.GetTable<Student>().InsertOnSubmit(newStudent);

            //save changes 
            //db.SubmitChanges();

            //show the student list form
            //this.studentListForm.show();

            //close this Form
            //this.Close();

         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.studentListForm.Show();
            this.Close();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {    // create a db object
            //StudentDataContext db = new StudentDataCntext();

            //check to ensutre that your are asking for Details Form , a Edit form or a Delete Form
            //if(this.FormType > 3){
           // Student studentDetails = ( form student in db.student
                                     //  where student.studentID == this.sudentID
                                     // select stdent).FirstOrDefault();


            //var studentDetails =(form in db.Students
                                  //Where studet.StudentID == this.StudentID
                                  //select student).FirstOrDefault();

            //Display details int heText Boxes of the Form
            //FirstNameTextBox.Text = studentDetails.FirstName;
            //LastNameTextBox.Text = studentDetails.LastName;
            // StudentNumberTextBox.Text = studentDetails.Number;
        }
        // switch(this.FormType)
   // {
        //case (int)CollumnButton.Details;
        //NewStudentLabel.Text = "Student Details";
        //this.Text = "Student Details";
        //SubmitButton.Visible = false;
        //FirstNameTextBox.ReadOnly = true;
        //LastNameTextBox.ReadOnly = true;
        //StudentNumberTextBox.ReadOnly = true;
        //CancelButton.Text = "Back";
        //break;

        //if the button clicked is the Edit button

        //case (int)ColumnButton.Edit;
        //NewStudetLabel.Text = "Edit Studen";
        //this.Text = "Edit Student";
        //SubmitButton.Text = "Update";
         //break;

        //if the button clicked is the Delete button 

        //case(int)ColumnButton.Delete;
        //NewStudentLable.Text = "Delete Student!";
        //FirstNameTextBox.ReadOnly = true;
        //LastNameTextBox.ReadOnly = true;
        //StudentNumberTextBox.ReadOnly = true;
        //SubmitbButton.TExt = "Delete";
        //SubmitButton.BackColor = Color.Red;
        //break;
   // }
    }
}
