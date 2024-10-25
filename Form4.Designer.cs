namespace DelaCruz_Midterm_Exam
{
    partial class Form4
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
            this.LibraryManagementSystem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataTransactions = new System.Windows.Forms.DataGridView();
            this.updateBook = new System.Windows.Forms.Button();
            this.DeleteBook = new System.Windows.Forms.Button();
            this.ViewTransactions = new System.Windows.Forms.Button();
            this.CreateTransaction = new System.Windows.Forms.Button();
            this.ReturningBook = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureDashboard = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturningBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LibraryManagementSystem
            // 
            this.LibraryManagementSystem.BackColor = System.Drawing.Color.DarkSalmon;
            this.LibraryManagementSystem.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibraryManagementSystem.Location = new System.Drawing.Point(-2, 0);
            this.LibraryManagementSystem.Name = "LibraryManagementSystem";
            this.LibraryManagementSystem.Size = new System.Drawing.Size(382, 130);
            this.LibraryManagementSystem.TabIndex = 13;
            this.LibraryManagementSystem.Text = "    LMS";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Sienna;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(-4, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 494);
            this.label1.TabIndex = 19;
            this.label1.Text = "\r\n\r\nDashboard \r\n\r\n\r\n\r\nBorrowing Book\r\n\r\n\r\n\r\nRetuning Book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 10);
            this.label2.TabIndex = 24;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(489, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(566, 65);
            this.label3.TabIndex = 25;
            this.label3.Text = "Borrowing Book Section";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataTransactions
            // 
            this.dataTransactions.BackgroundColor = System.Drawing.Color.Gray;
            this.dataTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTransactions.Location = new System.Drawing.Point(487, 130);
            this.dataTransactions.Name = "dataTransactions";
            this.dataTransactions.RowHeadersWidth = 51;
            this.dataTransactions.RowTemplate.Height = 24;
            this.dataTransactions.Size = new System.Drawing.Size(642, 240);
            this.dataTransactions.TabIndex = 26;
            this.dataTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTransactions_CellContentClick);
            // 
            // updateBook
            // 
            this.updateBook.BackColor = System.Drawing.Color.PeachPuff;
            this.updateBook.Location = new System.Drawing.Point(802, 399);
            this.updateBook.Name = "updateBook";
            this.updateBook.Size = new System.Drawing.Size(147, 57);
            this.updateBook.TabIndex = 27;
            this.updateBook.Text = "Update";
            this.updateBook.UseVisualStyleBackColor = false;
            this.updateBook.Click += new System.EventHandler(this.updateBook_Click);
            // 
            // DeleteBook
            // 
            this.DeleteBook.BackColor = System.Drawing.Color.PeachPuff;
            this.DeleteBook.Location = new System.Drawing.Point(955, 399);
            this.DeleteBook.Name = "DeleteBook";
            this.DeleteBook.Size = new System.Drawing.Size(156, 57);
            this.DeleteBook.TabIndex = 28;
            this.DeleteBook.Text = "Delete";
            this.DeleteBook.UseVisualStyleBackColor = false;
            this.DeleteBook.Click += new System.EventHandler(this.DeleteBook_Click);
            // 
            // ViewTransactions
            // 
            this.ViewTransactions.BackColor = System.Drawing.Color.PeachPuff;
            this.ViewTransactions.Location = new System.Drawing.Point(501, 399);
            this.ViewTransactions.Name = "ViewTransactions";
            this.ViewTransactions.Size = new System.Drawing.Size(116, 57);
            this.ViewTransactions.TabIndex = 29;
            this.ViewTransactions.Text = "View Transactions";
            this.ViewTransactions.UseVisualStyleBackColor = false;
            this.ViewTransactions.Click += new System.EventHandler(this.ViewTransactions_Click);
            // 
            // CreateTransaction
            // 
            this.CreateTransaction.BackColor = System.Drawing.Color.PeachPuff;
            this.CreateTransaction.Location = new System.Drawing.Point(623, 399);
            this.CreateTransaction.Name = "CreateTransaction";
            this.CreateTransaction.Size = new System.Drawing.Size(117, 57);
            this.CreateTransaction.TabIndex = 30;
            this.CreateTransaction.Text = "Create Transactions";
            this.CreateTransaction.UseVisualStyleBackColor = false;
            this.CreateTransaction.Click += new System.EventHandler(this.CreateTransaction_Click);
            // 
            // ReturningBook
            // 
            this.ReturningBook.BackColor = System.Drawing.Color.Sienna;
            this.ReturningBook.Image = global::DelaCruz_Midterm_Exam.Properties.Resources.Pictogrammers_Material_Book_arrow_left_48;
            this.ReturningBook.Location = new System.Drawing.Point(26, 424);
            this.ReturningBook.Name = "ReturningBook";
            this.ReturningBook.Size = new System.Drawing.Size(48, 50);
            this.ReturningBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReturningBook.TabIndex = 22;
            this.ReturningBook.TabStop = false;
            this.ReturningBook.Click += new System.EventHandler(this.ReturningBook_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Sienna;
            this.pictureBox4.Image = global::DelaCruz_Midterm_Exam.Properties.Resources.Robinweatherall_Library_Books_64;
            this.pictureBox4.Location = new System.Drawing.Point(26, 294);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureDashboard
            // 
            this.pictureDashboard.BackColor = System.Drawing.Color.Sienna;
            this.pictureDashboard.Image = global::DelaCruz_Midterm_Exam.Properties.Resources.Zerode_Plump_Folder_My_documents_48;
            this.pictureDashboard.Location = new System.Drawing.Point(26, 178);
            this.pictureDashboard.Name = "pictureDashboard";
            this.pictureDashboard.Size = new System.Drawing.Size(48, 48);
            this.pictureDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureDashboard.TabIndex = 20;
            this.pictureDashboard.TabStop = false;
            this.pictureDashboard.Click += new System.EventHandler(this.pictureDashboard_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DelaCruz_Midterm_Exam.Properties.Resources.Ionic_Ionicons_Book_512;
            this.pictureBox2.Location = new System.Drawing.Point(1052, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1262, 618);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CreateTransaction);
            this.Controls.Add(this.ViewTransactions);
            this.Controls.Add(this.DeleteBook);
            this.Controls.Add(this.updateBook);
            this.Controls.Add(this.dataTransactions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReturningBook);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureDashboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LibraryManagementSystem);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturningBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LibraryManagementSystem;
        private System.Windows.Forms.PictureBox ReturningBook;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataTransactions;
        private System.Windows.Forms.Button updateBook;
        private System.Windows.Forms.Button DeleteBook;
        private System.Windows.Forms.Button ViewTransactions;
        private System.Windows.Forms.Button CreateTransaction;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}