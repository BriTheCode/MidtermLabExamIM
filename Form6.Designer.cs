namespace DelaCruz_Midterm_Exam
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookID = new System.Windows.Forms.TextBox();
            this.memberID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updatingBook = new System.Windows.Forms.Button();
            this.DateBorrowed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borrowing Book";
            // 
            // bookID
            // 
            this.bookID.Location = new System.Drawing.Point(169, 239);
            this.bookID.Name = "bookID";
            this.bookID.Size = new System.Drawing.Size(222, 22);
            this.bookID.TabIndex = 10;
            this.bookID.TextChanged += new System.EventHandler(this.bookID_TextChanged);
            // 
            // memberID
            // 
            this.memberID.Location = new System.Drawing.Point(169, 189);
            this.memberID.Name = "memberID";
            this.memberID.Size = new System.Drawing.Size(222, 22);
            this.memberID.TabIndex = 9;
            this.memberID.TextChanged += new System.EventHandler(this.memberID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Book ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Member ID:";
            // 
            // updatingBook
            // 
            this.updatingBook.BackColor = System.Drawing.Color.PeachPuff;
            this.updatingBook.Location = new System.Drawing.Point(142, 354);
            this.updatingBook.Name = "updatingBook";
            this.updatingBook.Size = new System.Drawing.Size(193, 49);
            this.updatingBook.TabIndex = 11;
            this.updatingBook.Text = "Update Book";
            this.updatingBook.UseVisualStyleBackColor = false;
            this.updatingBook.Click += new System.EventHandler(this.updatingBook_Click);
            // 
            // DateBorrowed
            // 
            this.DateBorrowed.AutoSize = true;
            this.DateBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBorrowed.ForeColor = System.Drawing.Color.Black;
            this.DateBorrowed.Location = new System.Drawing.Point(29, 298);
            this.DateBorrowed.Name = "DateBorrowed";
            this.DateBorrowed.Size = new System.Drawing.Size(127, 20);
            this.DateBorrowed.TabIndex = 12;
            this.DateBorrowed.Text = "Date Borrowed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "YYYY-MM-DD ";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(162, 298);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(245, 22);
            this.datePicker.TabIndex = 15;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateBorrowed);
            this.Controls.Add(this.updatingBook);
            this.Controls.Add(this.bookID);
            this.Controls.Add(this.memberID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookID;
        private System.Windows.Forms.TextBox memberID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updatingBook;
        private System.Windows.Forms.Label DateBorrowed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}