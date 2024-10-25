namespace DelaCruz_Midterm_Exam
{
    partial class Form8
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
            this.DateBorrowed = new System.Windows.Forms.TextBox();
            this.IdMember = new System.Windows.Forms.TextBox();
            this.IdBook = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Member_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateBorrowed
            // 
            this.DateBorrowed.CausesValidation = false;
            this.DateBorrowed.Location = new System.Drawing.Point(187, 270);
            this.DateBorrowed.Name = "DateBorrowed";
            this.DateBorrowed.Size = new System.Drawing.Size(222, 22);
            this.DateBorrowed.TabIndex = 17;
            // 
            // IdMember
            // 
            this.IdMember.CausesValidation = false;
            this.IdMember.Location = new System.Drawing.Point(187, 223);
            this.IdMember.Name = "IdMember";
            this.IdMember.Size = new System.Drawing.Size(222, 22);
            this.IdMember.TabIndex = 16;
            this.IdMember.TextChanged += new System.EventHandler(this.IdMember_TextChanged);
            // 
            // IdBook
            // 
            this.IdBook.CausesValidation = false;
            this.IdBook.Location = new System.Drawing.Point(187, 171);
            this.IdBook.Name = "IdBook";
            this.IdBook.Size = new System.Drawing.Size(222, 22);
            this.IdBook.TabIndex = 15;
            this.IdBook.TextChanged += new System.EventHandler(this.IdBook_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "DateBorrowed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(70, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 12;
            // 
            // Member_id
            // 
            this.Member_id.AutoSize = true;
            this.Member_id.CausesValidation = false;
            this.Member_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Member_id.ForeColor = System.Drawing.Color.Black;
            this.Member_id.Location = new System.Drawing.Point(62, 171);
            this.Member_id.Name = "Member_id";
            this.Member_id.Size = new System.Drawing.Size(79, 20);
            this.Member_id.TabIndex = 11;
            this.Member_id.Text = "Book ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(59, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Creating Transactions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(47, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Member ID :";
            // 
            // CreateTransaction
            // 
            this.CreateTransaction.BackColor = System.Drawing.Color.PeachPuff;
            this.CreateTransaction.CausesValidation = false;
            this.CreateTransaction.Location = new System.Drawing.Point(134, 323);
            this.CreateTransaction.Name = "CreateTransaction";
            this.CreateTransaction.Size = new System.Drawing.Size(187, 51);
            this.CreateTransaction.TabIndex = 21;
            this.CreateTransaction.Text = "Create Transaction";
            this.CreateTransaction.UseVisualStyleBackColor = false;
            this.CreateTransaction.Click += new System.EventHandler(this.CreateTransaction_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.CreateTransaction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateBorrowed);
            this.Controls.Add(this.IdMember);
            this.Controls.Add(this.IdBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Member_id);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DateBorrowed;
        private System.Windows.Forms.TextBox IdMember;
        private System.Windows.Forms.TextBox IdBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Member_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateTransaction;
    }
}