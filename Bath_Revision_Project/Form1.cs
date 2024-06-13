using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        
        // When the 'Begin' button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
             if (Application.OpenForms.OfType<Form2>().Any()) //Checks if Form2 is open in any instance.
             {
                 Application.OpenForms.OfType<Form2>().First().BringToFront(); //If is open it takes the window and pulls it to the front
             }
             else
             {
                 var newform = new Form2(); //Else creates new instance of form 2
                 newform.Show(); // Displays newly created form
             }
             Application.OpenForms.OfType<Form1>().First().Hide();  //Hides any instance of Form1
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            ToDoList.Rows.Add(ToDoList.Rows.Count + 1,SubjectName.Text,InputBox.Text);
            //Adds new item in the Data Grid View; takes values from the text boxes for Subject and Description
            
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaskList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ToDoList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SubjectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewCell Cell in ToDoList.SelectedCells) //Applies to all cells selected in the DataGridView (the list)
            {
                if (Cell.Selected)
                    ToDoList.Rows.RemoveAt(Cell.RowIndex);
                //If cell is selected it is removed.
            }

            

        }
    }
}
