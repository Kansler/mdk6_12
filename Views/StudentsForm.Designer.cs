
namespace StudentsProject.Views
{
    partial class StudentsForm
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
            this.studentsView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsView
            // 
            this.studentsView.AllowUserToAddRows = false;
            this.studentsView.AllowUserToDeleteRows = false;
            this.studentsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsView.BackgroundColor = System.Drawing.Color.White;
            this.studentsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.SurnameColumn,
            this.GroupColumn});
            this.studentsView.Location = new System.Drawing.Point(12, 12);
            this.studentsView.MultiSelect = false;
            this.studentsView.Name = "studentsView";
            this.studentsView.ReadOnly = true;
            this.studentsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentsView.Size = new System.Drawing.Size(686, 302);
            this.studentsView.TabIndex = 0;
            this.studentsView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.studentsView_CellFormatting);
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Имя";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.DataPropertyName = "Surname";
            this.SurnameColumn.HeaderText = "Фамилия";
            this.SurnameColumn.Name = "SurnameColumn";
            this.SurnameColumn.ReadOnly = true;
            // 
            // GroupColumn
            // 
            this.GroupColumn.HeaderText = "Группа";
            this.GroupColumn.Name = "GroupColumn";
            this.GroupColumn.ReadOnly = true;
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Location = new System.Drawing.Point(541, 349);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Location = new System.Drawing.Point(622, 349);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Location = new System.Drawing.Point(541, 320);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(157, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Перезагрузить список";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 382);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.studentsView);
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "StudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentsForm";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentsView;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupColumn;
        private System.Windows.Forms.Button refreshButton;
    }
}