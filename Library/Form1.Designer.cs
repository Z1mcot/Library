namespace Library
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_LibraryName = new System.Windows.Forms.Label();
            this.button_ShowBooksTable = new System.Windows.Forms.Button();
            this.button_ShowLendersTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_LibraryName
            // 
            this.label_LibraryName.AutoSize = true;
            this.label_LibraryName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_LibraryName.Location = new System.Drawing.Point(213, 67);
            this.label_LibraryName.Name = "label_LibraryName";
            this.label_LibraryName.Size = new System.Drawing.Size(367, 30);
            this.label_LibraryName.TabIndex = 0;
            this.label_LibraryName.Text = "Главное Библиотечное Управление";
            // 
            // button_ShowBooksTable
            // 
            this.button_ShowBooksTable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ShowBooksTable.Location = new System.Drawing.Point(213, 163);
            this.button_ShowBooksTable.Name = "button_ShowBooksTable";
            this.button_ShowBooksTable.Size = new System.Drawing.Size(366, 39);
            this.button_ShowBooksTable.TabIndex = 1;
            this.button_ShowBooksTable.Text = "Открыть ведомость по книгам";
            this.button_ShowBooksTable.UseVisualStyleBackColor = true;
            this.button_ShowBooksTable.Click += new System.EventHandler(this.button_ShowBooksTable_Click);
            // 
            // button_ShowLendersTable
            // 
            this.button_ShowLendersTable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ShowLendersTable.Location = new System.Drawing.Point(213, 238);
            this.button_ShowLendersTable.Name = "button_ShowLendersTable";
            this.button_ShowLendersTable.Size = new System.Drawing.Size(366, 39);
            this.button_ShowLendersTable.TabIndex = 2;
            this.button_ShowLendersTable.Text = "Показать список должников";
            this.button_ShowLendersTable.UseVisualStyleBackColor = true;
            this.button_ShowLendersTable.Click += new System.EventHandler(this.button_ShowLendersTable_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ShowLendersTable);
            this.Controls.Add(this.button_ShowBooksTable);
            this.Controls.Add(this.label_LibraryName);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_LibraryName;
        private Button button_ShowBooksTable;
        private Button button_ShowLendersTable;
    }
}