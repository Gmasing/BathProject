namespace Bath_Revision_Project //This file is created by VS (Ignore)
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
            this.subject_label = new System.Windows.Forms.Label();
            this.SubjectName = new System.Windows.Forms.TextBox();
            this.DeleteRowButton = new System.Windows.Forms.Button();
            this.TaskNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ToDoList)).BeginInit();
            this.SuspendLayout();
            // 
            // Begin_Button
            // 
            this.Begin_Button.BackColor = System.Drawing.Color.Gray;
            this.Begin_Button.ForeColor = System.Drawing.Color.White;
            this.Begin_Button.Location = new System.Drawing.Point(648, 6);
            this.Begin_Button.Name = "Begin_Button";
            this.Begin_Button.Size = new System.Drawing.Size(94, 28);
            this.Begin_Button.TabIndex = 1;
            this.Begin_Button.Text = "Begin";
            this.Begin_Button.UseVisualStyleBackColor = false;
            this.Begin_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 6);
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
            this.InputBox.BackColor = System.Drawing.Color.White;
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
            this.Add_List_Button.Location = new System.Drawing.Point(305, 375);
            this.Add_List_Button.Name = "Add_List_Button";
            this.Add_List_Button.Size = new System.Drawing.Size(147, 23);
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
            this.ToDoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ToDoList.BackgroundColor = System.Drawing.Color.White;
            this.ToDoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskNo,
            this.Subject,
            this.description});
            this.ToDoList.Location = new System.Drawing.Point(45, 153);
            this.ToDoList.Name = "ToDoList";
            this.ToDoList.RowHeadersVisible = false;
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
            // subject_label
            // 
            this.subject_label.AutoSize = true;
            this.subject_label.Location = new System.Drawing.Point(455, 105);
            this.subject_label.Name = "subject_label";
            this.subject_label.Size = new System.Drawing.Size(76, 13);
            this.subject_label.TabIndex = 11;
            this.subject_label.Text = "What subject?";
            this.subject_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // SubjectName
            // 
            this.SubjectName.Location = new System.Drawing.Point(458, 121);
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Size = new System.Drawing.Size(127, 20);
            this.SubjectName.TabIndex = 12;
            this.SubjectName.TextChanged += new System.EventHandler(this.SubjectName_TextChanged);
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.Location = new System.Drawing.Point(530, 375);
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.Size = new System.Drawing.Size(145, 23);
            this.DeleteRowButton.TabIndex = 13;
            this.DeleteRowButton.Text = "Delete Row";
            this.DeleteRowButton.UseVisualStyleBackColor = true;
            this.DeleteRowButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TaskNo
            // 
            this.TaskNo.FillWeight = 35F;
            this.TaskNo.HeaderText = "Task No.";
            this.TaskNo.MaxInputLength = 0;
            this.TaskNo.MinimumWidth = 25;
            this.TaskNo.Name = "TaskNo";
            this.TaskNo.ReadOnly = true;
            this.TaskNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Subject
            // 
            this.Subject.FillWeight = 65F;
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            // 
            // description
            // 
            this.description.FillWeight = 185.8351F;
            this.description.HeaderText = "Task Description";
            this.description.Name = "description";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(754, 410);
            this.Controls.Add(this.DeleteRowButton);
            this.Controls.Add(this.SubjectName);
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
        private System.Windows.Forms.Label subject_label;
        private System.Windows.Forms.TextBox SubjectName;
        private System.Windows.Forms.Button DeleteRowButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
    }
}

