namespace Library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd_Click = new Button();
            btnDelete_Click = new Button();
            dataGridView1 = new DataGridView();
            titleBox = new TextBox();
            authorBox = new TextBox();
            yearBox = new TextBox();
            genreBox = new TextBox();
            clientBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd_Click
            // 
            btnAdd_Click.Location = new Point(74, 198);
            btnAdd_Click.Name = "btnAdd_Click";
            btnAdd_Click.Size = new Size(75, 23);
            btnAdd_Click.TabIndex = 0;
            btnAdd_Click.Text = "button1";
            btnAdd_Click.UseVisualStyleBackColor = true;
            btnAdd_Click.Click += button1_Click;
            // 
            // btnDelete_Click
            // 
            btnDelete_Click.Location = new Point(58, 255);
            btnDelete_Click.Name = "btnDelete_Click";
            btnDelete_Click.Size = new Size(75, 23);
            btnDelete_Click.TabIndex = 1;
            btnDelete_Click.Text = "button2";
            btnDelete_Click.UseVisualStyleBackColor = true;
            btnDelete_Click.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // titleBox
            // 
            titleBox.Location = new Point(277, 192);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(100, 23);
            titleBox.TabIndex = 3;
            // 
            // authorBox
            // 
            authorBox.Location = new Point(277, 234);
            authorBox.Name = "authorBox";
            authorBox.Size = new Size(100, 23);
            authorBox.TabIndex = 4;
            authorBox.TextChanged += textBox2_TextChanged;
            // 
            // yearBox
            // 
            yearBox.Location = new Point(282, 303);
            yearBox.Name = "yearBox";
            yearBox.Size = new Size(95, 23);
            yearBox.TabIndex = 5;
            // 
            // genreBox
            // 
            genreBox.Location = new Point(270, 368);
            genreBox.Name = "genreBox";
            genreBox.Size = new Size(100, 23);
            genreBox.TabIndex = 6;
            // 
            // clientBox
            // 
            clientBox.Location = new Point(266, 419);
            clientBox.Name = "clientBox";
            clientBox.Size = new Size(100, 23);
            clientBox.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clientBox);
            Controls.Add(genreBox);
            Controls.Add(yearBox);
            Controls.Add(authorBox);
            Controls.Add(titleBox);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete_Click);
            Controls.Add(btnAdd_Click);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd_Click;
        private Button btnDelete_Click;
        private DataGridView dataGridView1;
        private TextBox titleBox;
        private TextBox authorBox;
        private TextBox yearBox;
        private TextBox genreBox;
        private TextBox clientBox;
    }
}
