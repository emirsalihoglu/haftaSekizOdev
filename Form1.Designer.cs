namespace WinFormsApp1
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            yazdirlbl = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(191, 154);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(110, 50);
            button1.TabIndex = 0;
            button1.Text = "Gönder";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(191, 313);
            button2.Name = "button2";
            button2.Size = new Size(110, 50);
            button2.TabIndex = 1;
            button2.Text = "Çıkış";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // yazdirlbl
            // 
            yazdirlbl.AutoSize = true;
            yazdirlbl.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            yazdirlbl.ForeColor = Color.FromArgb(192, 0, 192);
            yazdirlbl.Location = new Point(175, 47);
            yazdirlbl.Name = "yazdirlbl";
            yazdirlbl.Size = new Size(144, 37);
            yazdirlbl.TabIndex = 3;
            yazdirlbl.Text = "Adı Giriniz";
            yazdirlbl.Click += yazdirlbl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(521, 436);
            Controls.Add(yazdirlbl);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlLight;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label yazdirlbl;
    }
}