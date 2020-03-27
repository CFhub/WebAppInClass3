using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppInClass3.Pages
{
    public partial class StudentForm : System.Web.UI.Page
    {
        private static List<Student> People = new List<Student>();

        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
        }
        protected void Add_Click(object sender, EventArgs e)
        {
            //MessageLabel.Text = "SIN = " + SIN.Text + " Name = " + Name.Text;
            if (Page.IsValid)
            {
                bool found = false;
                foreach (var item in People)
                {
                    if (item.StudentID == StudentID.Text)
                    {
                        found = true;
                    }
                }
                if (found)
                {
                    MessageLabel.Text = "Student record already exists.";
                }
                else
                {
                    Student newitem = new Student(StudentID.Text, StudentName.Text, double.Parse(Credits.Text), EmergencyPhoneNumber.Text);
                    People.Add(newitem);
                    PeopleGridView.DataSource = People;
                    PeopleGridView.DataBind();
                }
            }
        }
        protected void Clear_Click(object sender, EventArgs e)
        {
            StudentID.Text = "";
            StudentName.Text = "";
            Credits.Text = "";
            EmergencyPhoneNumber.Text = "";
        }
    }
}