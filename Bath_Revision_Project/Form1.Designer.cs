namespace Bath_Revision_Project
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
            this.label1.Location = new System.Drawing.Point(106, 9);
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
            this.InputBox.Text = "Enter Task you want to add here";
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
            this.ToDoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ToDoList.BackgroundColor = System.Drawing.Color.White;
            this.ToDoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDoList.Location = new System.Drawing.Point(391, 121);
            this.ToDoList.Name = "ToDoList";
            this.ToDoList.Size = new System.Drawing.Size(281, 211);
            this.ToDoList.TabIndex = 9;
            this.ToDoList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ToDoList_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 410);
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
    }
}

