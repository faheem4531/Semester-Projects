
namespace WindowsForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textStudentName = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.StudentsRecordGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textDegree = new System.Windows.Forms.TextBox();
            this.textRollNumber = new System.Windows.Forms.TextBox();
            this.textFatherName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsRecordGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textStudentName
            // 
            this.textStudentName.Location = new System.Drawing.Point(338, 84);
            this.textStudentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textStudentName.Name = "textStudentName";
            this.textStudentName.Size = new System.Drawing.Size(287, 26);
            this.textStudentName.TabIndex = 1;
            this.textStudentName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(799, 60);
            this.Insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(178, 45);
            this.Insert.TabIndex = 2;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // StudentsRecordGridView
            // 
            this.StudentsRecordGridView.BackgroundColor = System.Drawing.Color.Gray;
            this.StudentsRecordGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsRecordGridView.Location = new System.Drawing.Point(-4, 447);
            this.StudentsRecordGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StudentsRecordGridView.Name = "StudentsRecordGridView";
            this.StudentsRecordGridView.RowHeadersWidth = 51;
            this.StudentsRecordGridView.RowTemplate.Height = 24;
            this.StudentsRecordGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentsRecordGridView.Size = new System.Drawing.Size(1135, 206);
            this.StudentsRecordGridView.TabIndex = 3;
            this.StudentsRecordGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsRecordGridView_CellClick);
            this.StudentsRecordGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(799, 200);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(799, 130);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(799, 270);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 45);
            this.button4.TabIndex = 6;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textDegree
            // 
            this.textDegree.Location = new System.Drawing.Point(338, 260);
            this.textDegree.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textDegree.Name = "textDegree";
            this.textDegree.Size = new System.Drawing.Size(287, 26);
            this.textDegree.TabIndex = 7;
            // 
            // textRollNumber
            // 
            this.textRollNumber.Location = new System.Drawing.Point(338, 202);
            this.textRollNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textRollNumber.Name = "textRollNumber";
            this.textRollNumber.Size = new System.Drawing.Size(287, 26);
            this.textRollNumber.TabIndex = 8;
            // 
            // textFatherName
            // 
            this.textFatherName.Location = new System.Drawing.Point(338, 143);
            this.textFatherName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textFatherName.Name = "textFatherName";
            this.textFatherName.Size = new System.Drawing.Size(287, 26);
            this.textFatherName.TabIndex = 9;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(185, 83);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(87, 25);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "St. Name";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Degree";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "RollNumber";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "FatherName";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1114, 651);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFatherName);
            this.Controls.Add(this.textRollNumber);
            this.Controls.Add(this.textDegree);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.StudentsRecordGridView);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.textStudentName);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentsInformation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsRecordGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textStudentName;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DataGridView StudentsRecordGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textDegree;
        private System.Windows.Forms.TextBox textRollNumber;
        private System.Windows.Forms.TextBox textFatherName;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

