namespace DelaCruz_Midterm_Exam
{
    partial class Form7
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
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteTransaction = new System.Windows.Forms.TextBox();
            this.LinkDelBook = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.PeachPuff;
            this.DeleteButton.Location = new System.Drawing.Point(147, 230);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(189, 46);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "Delete Transaction";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 57);
            this.label1.TabIndex = 10;
            this.label1.Text = "Delete Transaction";
            // 
            // DeleteTransaction
            // 
            this.DeleteTransaction.Location = new System.Drawing.Point(186, 171);
            this.DeleteTransaction.Name = "DeleteTransaction";
            this.DeleteTransaction.Size = new System.Drawing.Size(222, 22);
            this.DeleteTransaction.TabIndex = 21;
            this.DeleteTransaction.TextChanged += new System.EventHandler(this.DeleteTransaction_TextChanged);
            // 
            // LinkDelBook
            // 
            this.LinkDelBook.AutoSize = true;
            this.LinkDelBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkDelBook.ForeColor = System.Drawing.Color.Black;
            this.LinkDelBook.Location = new System.Drawing.Point(51, 171);
            this.LinkDelBook.Name = "LinkDelBook";
            this.LinkDelBook.Size = new System.Drawing.Size(129, 20);
            this.LinkDelBook.TabIndex = 20;
            this.LinkDelBook.Text = "Transaction ID :";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(460, 372);
            this.Controls.Add(this.DeleteTransaction);
            this.Controls.Add(this.LinkDelBook);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeleteTransaction;
        private System.Windows.Forms.Label LinkDelBook;
    }
}