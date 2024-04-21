using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bath_Revision_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
   
        }
        DataTable dt = new DataTable();
        

        private void button1_Click(object sender, EventArgs e)
        {
             if (Application.OpenForms.OfType<Form2>().Any())
             {
                 Application.OpenForms.OfType<Form2>().First().BringToFront();
             }
             else
             {
                 var newform = new Form2();
                 newform.Show();
             }
             Application.OpenForms.OfType<Form1>().First().Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Task = InputBox.Text;
            /*ToDoList.Text
             
             testing if git works
            testing
             */
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaskList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ToDoList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dt.Columns.Add("Task Number");
            dt.Columns.Add("Task Name");

            ToDoList.DataSource = dt;
        }
    }
}
