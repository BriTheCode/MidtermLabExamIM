namespace DelaCruz_Midterm_Exam
{
    partial class Form1
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
            this.Connect = new System.Windows.Forms.Button();
            this.DataContent = new System.Windows.Forms.DataGridView();
            this.AddBook = new System.Windows.Forms.Button();
            this.AddMember = new System.Windows.Forms.Button();
            this.ViewBook = new System.Windows.Forms.Button();
            this.ViewMember = new System.Windows.Forms.Button();
            this.LibraryManagementSystem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DASHBOARD = new System.Windows.Forms.Label();
            this.DashboardLink = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ReturningBook = new System.Windows.Forms.PictureBox();
            this.PictureboxBook = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturningBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.PeachPuff;
            this.Connect.Location = new System.Drawing.Point(1031, 165);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(152, 58);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // DataContent
            // 
            this.DataContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataContent.Location = new System.Drawing.Point(488, 229);
            this.DataContent.Name = "DataContent";
            this.DataContent.RowHeadersWidth = 60;
            this.DataContent.RowTemplate.Height = 24;
            this.DataContent.Size = new System.Drawing.Size(686, 237);
            this.DataContent.TabIndex = 10;
            this.DataContent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataContent_CellContentClick);
            // 
            // AddBook
            // 
            this.AddBook.BackColor = System.Drawing.Color.PeachPuff;
            this.AddBook.Location = new System.Drawing.Point(646, 472);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(179, 60);
            this.AddBook.TabIndex = 3;
            this.AddBook.Text = "Add Book";
            this.AddBook.UseVisualStyleBackColor = false;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // AddMember
            // 
            this.AddMember.BackColor = System.Drawing.Color.PeachPuff;
            this.AddMember.Location = new System.Drawing.Point(470, 472);
            this.AddMember.Name = "AddMember";
            this.AddMember.Size = new System.Drawing.Size(170, 60);
            this.AddMember.TabIndex = 4;
            this.AddMember.Text = "Add Member";
            this.AddMember.UseVisualStyleBackColor = false;
            this.AddMember.Click += new System.EventHandler(this.AddMember_Click);
            // 
            // ViewBook
            // 
            this.ViewBook.BackColor = System.Drawing.Color.PeachPuff;
            this.ViewBook.Location = new System.Drawing.Point(846, 472);
            this.ViewBook.Name = "ViewBook";
            this.ViewBook.Size = new System.Drawing.Size(179, 60);
            this.ViewBook.TabIndex = 10;
            this.ViewBook.Text = "View Book";
            this.ViewBook.UseVisualStyleBackColor = false;
            this.ViewBook.Click += new System.EventHandler(this.ViewBook_Click);
            // 
            // ViewMember
            // 
            this.ViewMember.BackColor = System.Drawing.Color.PeachPuff;
            this.ViewMember.Location = new System.Drawing.Point(1031, 472);
            this.ViewMember.Name = "ViewMember";
            this.ViewMember.Size = new System.Drawing.Size(179, 60);
            this.ViewMember.TabIndex = 6;
            this.ViewMember.Text = "View Member";
            this.ViewMember.UseVisualStyleBackColor = false;
            this.ViewMember.Click += new System.EventHandler(this.ViewMember_Click);
            // 
            // LibraryManagementSystem
            // 
            this.LibraryManagementSystem.BackColor = System.Drawing.Color.DarkSalmon;
            this.LibraryManagementSystem.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibraryManagementSystem.Location = new System.Drawing.Point(1, -1);
            this.LibraryManagementSystem.Name = "LibraryManagementSystem";
            this.LibraryManagementSystem.Size = new System.Drawing.Size(382, 130);
            this.LibraryManagementSystem.TabIndex = 11;
            this.LibraryManagementSystem.Text = "    LMS";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label1.Location = new System.Drawing.Point(600, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1011, 113);
            this.label1.TabIndex = 14;
            this.label1.Text = "WELCOME, DELA CRUZ";
            // 
            // DASHBOARD
            // 
            this.DASHBOARD.BackColor = System.Drawing.Color.Sienna;
            this.DASHBOARD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DASHBOARD.ForeColor = System.Drawing.Color.SeaShell;
            this.DASHBOARD.Location = new System.Drawing.Point(-1, 129);
            this.DASHBOARD.Name = "DASHBOARD";
            this.DASHBOARD.Size = new System.Drawing.Size(384, 494);
            this.DASHBOARD.TabIndex = 12;
            this.DASHBOARD.Text = "\r\n\r\nDashboard \r\n\r\n\r\n\r\nBorrowing Book\r\n\r\n\r\n\r\nRetuning Book";
            this.DASHBOARD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DashboardLink
            // 
            this.DashboardLink.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DashboardLink.Location = new System.Drawing.Point(16, 247);
            this.DashboardLink.Name = "DashboardLink";
            this.DashboardLink.Size = new System.Drawing.Size(335, 10);
            this.DashboardLink.TabIndex = 27;
            this.DashboardLink.Text = "DashboardLink";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Sienna;
            this.pictureBox3.Image = global::DelaCruz_Midterm_Exam.Properties.Resources.Zerode_Plump_Folder_My_documents_48;
            this.pictureBox3.Location = new System.Drawing.Point(35, 175);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // ReturningBook
            // 
            this.ReturningBook.BackColor = System.Drawing.Color.Sienna;
            this.ReturningBook.Image = global::DelaCruz_Midterm_Exam.Properties.Resources.Pictogrammers_Material_Book_arrow_left_48;
            this.ReturningBook.Location = new System.Drawing.Point(35, 427);
            this.ReturningBook.Name = "ReturningBook";
            this.ReturningBook.Size = new System.Drawing.Size(48, 50);
            this.ReturningBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReturningBook.TabIndex = 18;
            this.ReturningBook.TabStop = false;
            this.ReturningBook.Click += new System.EventHandler(this.ReturningBook_Click);
            // 
            // PictureboxBook
            // 
            this.PictureboxBook.BackColor = System.Drawing.Color.Sienna;
            this.PictureboxBook.Image = global::DelaCruz_Midterm_Exam.Properties.Resources.Robinweatherall_Library_Books_64;
            this.PictureboxBook.Location = new System.Drawing.Point(35, 297);
            this.PictureboxBook.Name = "PictureboxBook";
            this.PictureboxBook.Size = new System.Drawing.Size(48, 52);
            this.PictureboxBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureboxBook.TabIndex = 17;
            this.PictureboxBook.TabStop = false;
            this.PictureboxBook.Click += new System.EventHandler(this.PictureboxBook_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DelaCruz_Midterm_Exam.Properties.Resources.Hopstarter_Rounded_Square_Folder_Profiles_64;
            this.pictureBox2.Location = new System.Drawing.Point(996, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.pictureBox1.Image = global::DelaCruz_Midterm_Exam.Properties.Resources.Robinweatherall_Library_Book1;
            this.pictureBox1.Location = new System.Drawing.Point(19, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1262, 618);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.DashboardLink);
            this.Controls.Add(this.ReturningBook);
            this.Controls.Add(this.PictureboxBook);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DASHBOARD);
            this.Controls.Add(this.LibraryManagementSystem);
            this.Controls.Add(this.ViewMember);
            this.Controls.Add(this.ViewBook);
            this.Controls.Add(this.AddMember);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.DataContent);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturningBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureboxBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.DataGridView DataContent;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button AddMember;
        private System.Windows.Forms.Button ViewBook;
        private System.Windows.Forms.Button ViewMember;
        private System.Windows.Forms.Label LibraryManagementSystem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label DASHBOARD;
        private System.Windows.Forms.PictureBox PictureboxBook;
        private System.Windows.Forms.PictureBox ReturningBook;
        private System.Windows.Forms.Label DashboardLink;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

