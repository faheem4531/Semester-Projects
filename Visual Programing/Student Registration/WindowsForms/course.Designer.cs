namespace WindowsForms
{
    partial class course
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textcoursecode = new System.Windows.Forms.TextBox();
            this.textcoursetitle = new System.Windows.Forms.TextBox();
            this.textcredithours = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.dataGridViewCourse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CourseCode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CourseTitle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "CreditHours";
            // 
            // textcoursecode
            // 
            this.textcoursecode.Location = new System.Drawing.Point(259, 127);
            this.textcoursecode.Name = "textcoursecode";
            this.textcoursecode.Size = new System.Drawing.Size(255, 26);
            this.textcoursecode.TabIndex = 4;
            // 
            // textcoursetitle
            // 
            this.textcoursetitle.Location = new System.Drawing.Point(259, 190);
            this.textcoursetitle.Name = "textcoursetitle";
            this.textcoursetitle.Size = new System.Drawing.Size(255, 26);
            this.textcoursetitle.TabIndex = 5;
            // 
            // textcredithours
            // 
            this.textcredithours.Location = new System.Drawing.Point(259, 257);
            this.textcredithours.Name = "textcredithours";
            this.textcredithours.Size = new System.Drawing.Size(255, 26);
            this.textcredithours.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(687, 171);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 58);
            this.button3.TabIndex = 9;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(687, 241);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 58);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(687, 101);
            this.Insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(190, 58);
            this.Insert.TabIndex = 7;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // dataGridViewCourse
            // 
            this.dataGridViewCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourse.Location = new System.Drawing.Point(12, 397);
            this.dataGridViewCourse.Name = "dataGridViewCourse";
            this.dataGridViewCourse.RowTemplate.Height = 28;
            this.dataGridViewCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCourse.Size = new System.Drawing.Size(921, 220);
            this.dataGridViewCourse.TabIndex = 10;
            this.dataGridViewCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourse_CellClick_1);
            this.dataGridViewCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourse_CellContentClick);
            // 
            // course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 629);
            this.Controls.Add(this.dataGridViewCourse);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.textcredithours);
            this.Controls.Add(this.textcoursetitle);
            this.Controls.Add(this.textcoursecode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "course";
            this.Load += new System.EventHandler(this.course_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textcoursecode;
        private System.Windows.Forms.TextBox textcoursetitle;
        private System.Windows.Forms.TextBox textcredithours;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DataGridView dataGridViewCourse;
    }
}