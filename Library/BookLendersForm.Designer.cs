namespace Library
{
    partial class BookLendersForm
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
            this.listView_Lenders = new System.Windows.Forms.ListView();
            this.LenderID = new System.Windows.Forms.ColumnHeader();
            this.LenderName = new System.Windows.Forms.ColumnHeader();
            this.BookName = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView_Lenders
            // 
            this.listView_Lenders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LenderID,
            this.LenderName,
            this.BookName});
            this.listView_Lenders.GridLines = true;
            this.listView_Lenders.Location = new System.Drawing.Point(19, 16);
            this.listView_Lenders.Name = "listView_Lenders";
            this.listView_Lenders.Size = new System.Drawing.Size(769, 388);
            this.listView_Lenders.TabIndex = 0;
            this.listView_Lenders.UseCompatibleStateImageBehavior = false;
            this.listView_Lenders.View = System.Windows.Forms.View.Details;
            this.listView_Lenders.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Lenders_ColumnClick);
            // 
            // LenderID
            // 
            this.LenderID.Text = "Номер читательского билета";
            this.LenderID.Width = 200;
            // 
            // LenderName
            // 
            this.LenderName.Text = "ФИО";
            this.LenderName.Width = 250;
            // 
            // BookName
            // 
            this.BookName.Text = "Книга";
            this.BookName.Width = 250;
            // 
            // BookLendersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 423);
            this.Controls.Add(this.listView_Lenders);
            this.Name = "BookLendersForm";
            this.Text = "BookLendersForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView_Lenders;
        private ColumnHeader LenderName;
        private ColumnHeader BookName;
        private ColumnHeader LenderID;
    }
}