namespace WindowsForms
{
    partial class payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payment));
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.texts1 = new System.Windows.Forms.TextBox();
            this.textp = new System.Windows.Forms.TextBox();
            this.texts2 = new System.Windows.Forms.TextBox();
            this.dataGridViewpayment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpayment)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(666, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 61);
            this.button4.TabIndex = 1;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(666, 165);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 61);
            this.button5.TabIndex = 2;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Subject1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Payment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(120, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Subject2";
            // 
            // texts1
            // 
            this.texts1.Location = new System.Drawing.Point(274, 118);
            this.texts1.Name = "texts1";
            this.texts1.Size = new System.Drawing.Size(221, 26);
            this.texts1.TabIndex = 7;
            // 
            // textp
            // 
            this.textp.Location = new System.Drawing.Point(274, 219);
            this.textp.Name = "textp";
            this.textp.Size = new System.Drawing.Size(221, 26);
            this.textp.TabIndex = 8;
            // 
            // texts2
            // 
            this.texts2.Location = new System.Drawing.Point(274, 165);
            this.texts2.Name = "texts2";
            this.texts2.Size = new System.Drawing.Size(221, 26);
            this.texts2.TabIndex = 10;
            // 
            // dataGridViewpayment
            // 
            this.dataGridViewpayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpayment.Location = new System.Drawing.Point(1, 428);
            this.dataGridViewpayment.Name = "dataGridViewpayment";
            this.dataGridViewpayment.RowTemplate.Height = 28;
            this.dataGridViewpayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewpayment.Size = new System.Drawing.Size(902, 192);
            this.dataGridViewpayment.TabIndex = 11;
            this.dataGridViewpayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewpayment_CellClick);
            // 
            // payment
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 622);
            this.Controls.Add(this.dataGridViewpayment);
            this.Controls.Add(this.texts2);
            this.Controls.Add(this.textp);
            this.Controls.Add(this.texts1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Name = "payment";
            this.Load += new System.EventHandler(this.payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textsubject1;
        private System.Windows.Forms.TextBox textpayment;
        private System.Windows.Forms.TextBox textsubject3;
        private System.Windows.Forms.TextBox textsubject2;
        private System.Windows.Forms.DataGridView dataGridViewCourse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox texts1;
        private System.Windows.Forms.TextBox textp;
        private System.Windows.Forms.TextBox texts2;
        private System.Windows.Forms.DataGridView dataGridViewpayment;
    }
}