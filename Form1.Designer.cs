namespace passworgenerator
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
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(247, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 31);
            textBox1.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(305, 183);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 29);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "6 characters";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(305, 218);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(142, 29);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "10 characters";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(305, 253);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(142, 29);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "12 characters";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Location = new Point(548, 297);
            button1.Name = "button1";
            button1.Size = new Size(161, 66);
            button1.TabIndex = 4;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 55);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 5;
            label1.Text = "Password Generator";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Button button1;
        private Label label1;
    }
}