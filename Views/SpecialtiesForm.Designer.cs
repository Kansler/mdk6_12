
namespace StudentsProject.Views
{
    partial class SpecialtiesForm
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
            this.specialtiesView = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.CodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addSpecialty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesView)).BeginInit();
            this.SuspendLayout();
            // 
            // specialtiesView
            // 
            this.specialtiesView.BackgroundColor = System.Drawing.Color.White;
            this.specialtiesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specialtiesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeColumn,
            this.NameColumn});
            this.specialtiesView.Location = new System.Drawing.Point(9, 9);
            this.specialtiesView.Margin = new System.Windows.Forms.Padding(0);
            this.specialtiesView.MultiSelect = false;
            this.specialtiesView.Name = "specialtiesView";
            this.specialtiesView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.specialtiesView.Size = new System.Drawing.Size(692, 312);
            this.specialtiesView.TabIndex = 0;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Location = new System.Drawing.Point(420, 324);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(136, 23);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Перезагрузить список";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Location = new System.Drawing.Point(562, 324);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(136, 23);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Изменить группу";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // CodeColumn
            // 
            this.CodeColumn.DataPropertyName = "Code";
            this.CodeColumn.HeaderText = "Код группы";
            this.CodeColumn.Name = "CodeColumn";
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "Название группы";
            this.NameColumn.Name = "NameColumn";
            // 
            // addSpecialty
            // 
            this.addSpecialty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSpecialty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSpecialty.Location = new System.Drawing.Point(247, 324);
            this.addSpecialty.Name = "addSpecialty";
            this.addSpecialty.Size = new System.Drawing.Size(167, 23);
            this.addSpecialty.TabIndex = 3;
            this.addSpecialty.Text = "Добавить специальность";
            this.addSpecialty.UseVisualStyleBackColor = true;
            this.addSpecialty.Click += new System.EventHandler(this.addSpecialty_Click);
            // 
            // SpecialtiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 376);
            this.Controls.Add(this.addSpecialty);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.specialtiesView);
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "SpecialtiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpecialtiesForm";
            ((System.ComponentModel.ISupportInitialize)(this.specialtiesView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView specialtiesView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.Button addSpecialty;
    }
}