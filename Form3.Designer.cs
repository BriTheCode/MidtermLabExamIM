namespace DelaCruz_Midterm_Exam
{
    partial class Form3
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
            this.MemberEmail = new System.Windows.Forms.TextBox();
            this.MemberFirsName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MemberLastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddingMember = new System.Windows.Forms.Button();
            this.MemberLast = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MemberEmail
            // 
            this.MemberEmail.Location = new System.Drawing.Point(162, 287);
            this.MemberEmail.Name = "MemberEmail";
            this.MemberEmail.Size = new System.Drawing.Size(222, 22);
            this.MemberEmail.TabIndex = 16;
            this.MemberEmail.TextChanged += new System.EventHandler(this.MemberEmail_TextChanged);
            // 
            // MemberFirsName
            // 
            this.MemberFirsName.Location = new System.Drawing.Point(162, 188);
            this.MemberFirsName.Name = "MemberFirsName";
            this.MemberFirsName.Size = new System.Drawing.Size(222, 22);
            this.MemberFirsName.TabIndex = 14;
            this.MemberFirsName.TextChanged += new System.EventHandler(this.MemberFirsName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(45, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email :";
            // 
            // MemberLastName
            // 
            this.MemberLastName.AutoSize = true;
            this.MemberLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberLastName.ForeColor = System.Drawing.Color.Black;
            this.MemberLastName.Location = new System.Drawing.Point(45, 240);
            this.MemberLastName.Name = "MemberLastName";
            this.MemberLastName.Size = new System.Drawing.Size(96, 20);
            this.MemberLastName.TabIndex = 11;
            this.MemberLastName.Text = "LastName :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(45, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "FirstName :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 76);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add Member";
            // 
            // AddingMember
            // 
            this.AddingMember.BackColor = System.Drawing.Color.PeachPuff;
            this.AddingMember.Location = new System.Drawing.Point(191, 340);
            this.AddingMember.Name = "AddingMember";
            this.AddingMember.Size = new System.Drawing.Size(153, 40);
            this.AddingMember.TabIndex = 17;
            this.AddingMember.Text = "Add Member";
            this.AddingMember.UseVisualStyleBackColor = false;
            this.AddingMember.Click += new System.EventHandler(this.AddingMember_Click);
            // 
            // MemberLast
            // 
            this.MemberLast.Location = new System.Drawing.Point(162, 238);
            this.MemberLast.Name = "MemberLast";
            this.MemberLast.Size = new System.Drawing.Size(222, 22);
            this.MemberLast.TabIndex = 18;
            this.MemberLast.TextChanged += new System.EventHandler(this.MemberLast_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.MemberLast);
            this.Controls.Add(this.AddingMember);
            this.Controls.Add(this.MemberEmail);
            this.Controls.Add(this.MemberFirsName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MemberLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MemberEmail;
        private System.Windows.Forms.TextBox MemberFirsName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MemberLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddingMember;
        private System.Windows.Forms.TextBox MemberLast;
    }
}