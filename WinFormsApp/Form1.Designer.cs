namespace FormsProj
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
            menuStrip1 = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            accessToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            richTextBox1 = new RichTextBox();
            button7 = new Button();
            button8 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(931, 23);
            textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, accessToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(110, 22);
            addToolStripMenuItem.Text = "Add";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // accessToolStripMenuItem
            // 
            accessToolStripMenuItem.Name = "accessToolStripMenuItem";
            accessToolStripMenuItem.Size = new Size(110, 22);
            accessToolStripMenuItem.Text = "Access";
            accessToolStripMenuItem.Click += accessToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(949, 49);
            button1.Name = "button1";
            button1.Size = new Size(230, 23);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter Your Name:";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(949, 94);
            button2.Name = "button2";
            button2.Size = new Size(230, 23);
            button2.TabIndex = 4;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(931, 23);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 6;
            label2.Text = "Enter Your Age:";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 168);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(931, 23);
            textBox3.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(949, 168);
            button3.Name = "button3";
            button3.Size = new Size(230, 23);
            button3.TabIndex = 8;
            button3.Text = "Submit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 150);
            label3.Name = "label3";
            label3.Size = new Size(152, 15);
            label3.TabIndex = 9;
            label3.Text = "Enter Your Number Of Pets:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(12, 221);
            label4.Name = "label4";
            label4.Size = new Size(73, 37);
            label4.TabIndex = 10;
            label4.Text = "PETS";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(1056, 75);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 11;
            label5.Text = ":(";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(1056, 120);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 12;
            label6.Text = ":(";
            label6.Visible = false;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(1056, 194);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 13;
            label7.Text = ":(";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 277);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 14;
            label8.Text = "Name:";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 310);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 15;
            label9.Text = "Species:";
            label9.Visible = false;
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 346);
            label10.Name = "label10";
            label10.Size = new Size(21, 15);
            label10.TabIndex = 16;
            label10.Text = "ID:";
            label10.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(83, 277);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(183, 23);
            textBox4.TabIndex = 17;
            textBox4.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(83, 310);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(183, 23);
            textBox5.TabIndex = 18;
            textBox5.Visible = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(83, 343);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(183, 23);
            textBox6.TabIndex = 19;
            textBox6.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(83, 381);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 20;
            button4.Text = "Submit";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F);
            button5.Location = new Point(1007, 514);
            button5.Name = "button5";
            button5.Size = new Size(165, 63);
            button5.TabIndex = 21;
            button5.Text = "Add Another";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 20F);
            button6.Location = new Point(505, 278);
            button6.Name = "button6";
            button6.Size = new Size(186, 84);
            button6.TabIndex = 22;
            button6.Text = "Access Data";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 27);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1001, 565);
            richTextBox1.TabIndex = 23;
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 30F);
            button7.Location = new Point(995, 27);
            button7.Name = "button7";
            button7.Size = new Size(189, 285);
            button7.TabIndex = 24;
            button7.Text = "Next";
            button7.UseVisualStyleBackColor = true;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 30F);
            button8.Location = new Point(995, 306);
            button8.Name = "button8";
            button8.Size = new Size(189, 286);
            button8.TabIndex = 25;
            button8.Text = "Previous";
            button8.UseVisualStyleBackColor = true;
            button8.Visible = false;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 636);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(richTextBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1200, 675);
            MinimumSize = new Size(1200, 675);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem accessToolStripMenuItem;
        private Button button1;
        private Label label1;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Button button3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button4;
        private Button button5;
        private Button button6;
        private RichTextBox richTextBox1;
        private Button button7;
        private Button button8;
    }
}
