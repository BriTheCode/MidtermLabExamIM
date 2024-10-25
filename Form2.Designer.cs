namespace DelaCruz_Midterm_Exam
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BookTitle = new System.Windows.Forms.TextBox();
            this.BookAuthor = new System.Windows.Forms.TextBox();
            this.BookGenre = new System.Windows.Forms.TextBox();
            this.BookYearPublished = new System.Windows.Forms.TextBox();
            this.AddingBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(45, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(45, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genre :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Year Published:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BookTitle
            // 
            this.BookTitle.Location = new System.Drawing.Point(162, 161);
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.Size = new System.Drawing.Size(222, 22);
            this.BookTitle.TabIndex = 5;
            this.BookTitle.TextChanged += new System.EventHandler(this.BookTitle_TextChanged);
            // 
            // BookAuthor
            // 
            this.BookAuthor.Location = new System.Drawing.Point(162, 213);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(222, 22);
            this.BookAuthor.TabIndex = 6;
            this.BookAuthor.TextChanged += new System.EventHandler(this.BookAuthor_TextChanged);
            // 
            // BookGenre
            // 
            this.BookGenre.Location = new System.Drawing.Point(162, 260);
            this.BookGenre.Name = "BookGenre";
            this.BookGenre.Size = new System.Drawing.Size(222, 22);
            this.BookGenre.TabIndex = 7;
            this.BookGenre.TextChanged += new System.EventHandler(this.BookGenre_TextChanged);
            // 
            // BookYearPublished
            // 
            this.BookYearPublished.Location = new System.Drawing.Point(162, 309);
            this.BookYearPublished.Name = "BookYearPublished";
            this.BookYearPublished.Size = new System.Drawing.Size(222, 22);
            this.BookYearPublished.TabIndex = 8;
            this.BookYearPublished.TextChanged += new System.EventHandler(this.BookYearPublished_TextChanged);
            // 
            // AddingBook
            // 
            this.AddingBook.BackColor = System.Drawing.Color.PeachPuff;
            this.AddingBook.Location = new System.Drawing.Point(174, 355);
            this.AddingBook.Name = "AddingBook";
            this.AddingBook.Size = new System.Drawing.Size(176, 43);
            this.AddingBook.TabIndex = 9;
            this.AddingBook.Text = "Add Book";
            this.AddingBook.UseVisualStyleBackColor = false;
            this.AddingBook.Click += new System.EventHandler(this.AddingBook_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.AddingBook);
            this.Controls.Add(this.BookYearPublished);
            this.Controls.Add(this.BookGenre);
            this.Controls.Add(this.BookAuthor);
            this.Controls.Add(this.BookTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BookTitle;
        private System.Windows.Forms.TextBox BookAuthor;
        private System.Windows.Forms.TextBox BookGenre;
        private System.Windows.Forms.TextBox BookYearPublished;
        private System.Windows.Forms.Button AddingBook;
    }
}