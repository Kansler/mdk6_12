
namespace StudentsProject.Views
{
    partial class MainForm
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
            this.showStudents = new System.Windows.Forms.Button();
            this.showSpecialtyButton = new System.Windows.Forms.Button();
            this.fullInfoStudentView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fullInfoStudentView)).BeginInit();
            this.SuspendLayout();
            // 
            // showStudents
            // 
            this.showStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showStudents.Location = new System.Drawing.Point(682, 41);
            this.showStudents.Name = "showStudents";
            this.showStudents.Size = new System.Drawing.Size(109, 23);
            this.showStudents.TabIndex = 4;
            this.showStudents.Text = "Студенты";
            this.showStudents.UseVisualStyleBackColor = true;
            this.showStudents.Click += new System.EventHandler(this.showStudents_Click);
            // 
            // showSpecialtyButton
            // 
            this.showSpecialtyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSpecialtyButton.Location = new System.Drawing.Point(682, 12);
            this.showSpecialtyButton.Name = "showSpecialtyButton";
            this.showSpecialtyButton.Size = new System.Drawing.Size(109, 23);
            this.showSpecialtyButton.TabIndex = 5;
            this.showSpecialtyButton.Text = "Специальности";
            this.showSpecialtyButton.UseVisualStyleBackColor = true;
            this.showSpecialtyButton.Click += new System.EventHandler(this.showSpecialtyButton_Click);
            // 
            // fullInfoStudentView
            // 
            this.fullInfoStudentView.AllowUserToAddRows = false;
            this.fullInfoStudentView.AllowUserToDeleteRows = false;
            this.fullInfoStudentView.BackgroundColor = System.Drawing.Color.White;
            this.fullInfoStudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fullInfoStudentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.SurnameColumn,
            this.GroupColumn});
            this.fullInfoStudentView.Location = new System.Drawing.Point(12, 12);
            this.fullInfoStudentView.MultiSelect = false;
            this.fullInfoStudentView.Name = "fullInfoStudentView";
            this.fullInfoStudentView.ReadOnly = true;
            this.fullInfoStudentView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fullInfoStudentView.Size = new System.Drawing.Size(664, 342);
            this.fullInfoStudentView.TabIndex = 6;
            this.fullInfoStudentView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.fullInfoStudentView_CellFormatting);
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.Name = "NameColumn";
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.DataPropertyName = "Surname";
            this.SurnameColumn.HeaderText = "Фамилия";
            this.SurnameColumn.Name = "SurnameColumn";
            // 
            // GroupColumn
            // 
            this.GroupColumn.DataPropertyName = "Group";
            this.GroupColumn.HeaderText = "Группа";
            this.GroupColumn.Name = "GroupColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fullInfoStudentView);
            this.Controls.Add(this.showSpecialtyButton);
            this.Controls.Add(this.showStudents);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fullInfoStudentView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showStudents;
        private System.Windows.Forms.Button showSpecialtyButton;
        private System.Windows.Forms.DataGridView fullInfoStudentView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupColumn;
    }
}