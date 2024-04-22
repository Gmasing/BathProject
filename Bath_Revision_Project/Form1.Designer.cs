﻿namespace Bath_Revision_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Begin_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.Add_List_Button = new System.Windows.Forms.Button();
            this.ToDoList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.TaskNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ToDoList)).BeginInit();
            this.SuspendLayout();
            // 
            // Begin_Button
            // 
            this.Begin_Button.BackColor = System.Drawing.Color.Gray;
            this.Begin_Button.ForeColor = System.Drawing.Color.White;
            this.Begin_Button.Location = new System.Drawing.Point(258, 370);
            this.Begin_Button.Name = "Begin_Button";
            this.Begin_Button.Size = new System.Drawing.Size(172, 28);
            this.Begin_Button.TabIndex = 1;
            this.Begin_Button.Text = "Begin";
            this.Begin_Button.UseVisualStyleBackColor = false;
            this.Begin_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome!\r\n\r\n This tool is meant to help you with revision by allowing you to crea" +
    "te tasks\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.Silver;
            this.InputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.Location = new System.Drawing.Point(45, 121);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(226, 23);
            this.InputBox.TabIndex = 6;
            this.InputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // Add_List_Button
            // 
            this.Add_List_Button.Location = new System.Drawing.Point(277, 121);
            this.Add_List_Button.Name = "Add_List_Button";
            this.Add_List_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_List_Button.TabIndex = 8;
            this.Add_List_Button.Text = "Add to list";
            this.Add_List_Button.UseVisualStyleBackColor = true;
            this.Add_List_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // ToDoList
            // 
            this.ToDoList.AllowUserToAddRows = false;
            this.ToDoList.AllowUserToDeleteRows = false;
            this.ToDoList.AllowUserToResizeColumns = false;
            this.ToDoList.AllowUserToResizeRows = false;
            this.ToDoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ToDoList.BackgroundColor = System.Drawing.Color.White;
            this.ToDoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskNo,
            this.Subject,
            this.description});
            this.ToDoList.Location = new System.Drawing.Point(45, 153);
            this.ToDoList.Name = "ToDoList";
            this.ToDoList.Size = new System.Drawing.Size(663, 211);
            this.ToDoList.TabIndex = 9;
            this.ToDoList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ToDoList_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Task you want to add here";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TaskNo
            // 
            this.TaskNo.FillWeight = 61.18205F;
            this.TaskNo.HeaderText = "Task No.";
            this.TaskNo.MinimumWidth = 6;
            this.TaskNo.Name = "TaskNo";
            // 
            // Subject
            // 
            this.Subject.FillWeight = 68.52792F;
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            // 
            // description
            // 
            this.description.FillWeight = 170.2901F;
            this.description.HeaderText = "Task Description";
            this.description.Name = "description";
            // 
            // subject_label
            // 
            this.subject_label.AutoSize = true;
            this.subject_label.Location = new System.Drawing.Point(401, 105);
            this.subject_label.Name = "subject_label";
            this.subject_label.Size = new System.Drawing.Size(76, 13);
            this.subject_label.TabIndex = 11;
            this.subject_label.Text = "What subject?";
            this.subject_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 410);
            this.Controls.Add(this.subject_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToDoList);
            this.Controls.Add(this.Add_List_Button);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Begin_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Revision Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToDoList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Begin_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button Add_List_Button;
        private System.Windows.Forms.DataGridView ToDoList;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Label subject_label;
    }
}

