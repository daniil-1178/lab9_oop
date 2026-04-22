namespace Lab9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn1 = new Button();
            txtA = new TextBox();
            txtB = new TextBox();
            pictBox1 = new PictureBox();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 189);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 0;
            btn1.Text = "Run";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnDraw_Click;
            // 
            // txtA
            // 
            txtA.Location = new Point(132, 86);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 1;
            // 
            // txtB
            // 
            txtB.Location = new Point(132, 138);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 2;
            // 
            // pictBox1
            // 
            pictBox1.Location = new Point(342, 30);
            pictBox1.Name = "pictBox1";
            pictBox1.Size = new Size(435, 327);
            pictBox1.TabIndex = 3;
            pictBox1.TabStop = false;
            pictBox1.Paint += pbGraph_Paint;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(12, 9);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(100, 15);
            lbl1.TabIndex = 4;
            lbl1.Text = "Задане рівняння:";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(12, 89);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(114, 15);
            lbl2.TabIndex = 5;
            lbl2.Text = "Введіть значення A:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(13, 141);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(113, 15);
            lbl3.TabIndex = 6;
            lbl3.Text = "Введіть значення B:";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(342, 9);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(63, 15);
            lbl4.TabIndex = 7;
            lbl4.Text = "Результат:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 37);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(pictBox1);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private TextBox txtA;
        private TextBox txtB;
        private PictureBox pictBox1;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private PictureBox pictureBox1;
    }
}
