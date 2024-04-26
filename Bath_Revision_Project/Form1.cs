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
        DataTable dt = new DataTable();
        int a = 0;



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
           
            ToDoList.Rows.Add(ToDoList.Rows.Count + 1,SubjectName.Text,InputBox.Text);
            
        }

        private void RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
       
            for (int i = 0;i < ToDoList.Rows.Count;i++)
            {
                /*Console.WriteLine(i);*/

                ToDoList.Rows[i].Cells[1].Value = ToDoList.Rows.Count;
            }
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
            foreach (DataGridViewCell Cell in ToDoList.SelectedCells)
            {
                if (Cell.Selected)
                    ToDoList.Rows.RemoveAt(Cell.RowIndex);
            }

            

        }
    }
}
