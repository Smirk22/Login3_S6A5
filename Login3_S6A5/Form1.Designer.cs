namespace Login3_S6A5
{
    partial class Accounts
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ImageBox = new Label();
            Confirm = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(206, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(750, 520);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(25, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(25, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(147, 27);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(25, 280);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 122);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 85);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 147);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // ImageBox
            // 
            ImageBox.AutoSize = true;
            ImageBox.Location = new Point(68, 250);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(54, 20);
            ImageBox.TabIndex = 8;
            ImageBox.Text = "Image:";
            // 
            // Confirm
            // 
            Confirm.Location = new Point(45, 426);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(94, 29);
            Confirm.TabIndex = 9;
            Confirm.Text = "Confirm";
            Confirm.UseVisualStyleBackColor = true;
            // 
            // Accounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 544);
            Controls.Add(Confirm);
            Controls.Add(ImageBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Accounts";
            Text = "Accounts";
            Load += Accounts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label ImageBox;
        private Button Confirm;
    }
}