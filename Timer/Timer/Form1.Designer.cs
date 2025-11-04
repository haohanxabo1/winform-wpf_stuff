namespace Timer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(363, 28);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 0;
            label1.Text = "Sec";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(363, 71);
            numericUpDown1.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(114, 31);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(363, 138);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(226, 71);
            numericUpDown2.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(114, 31);
            numericUpDown2.TabIndex = 4;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(89, 71);
            numericUpDown3.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(114, 31);
            numericUpDown3.TabIndex = 5;
            numericUpDown3.TabStop = false;
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 28);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 6;
            label3.Text = "Minute";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 28);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 7;
            label4.Text = "Hour";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Times Up !!!";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipShown += notifyIcon1_BalloonTipShown;
            // 
            // button2
            // 
            button2.Location = new Point(226, 138);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 8;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(89, 138);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 9;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 221);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label label3;
        private Label label4;
        private NotifyIcon notifyIcon1;
        private Button button2;
        private Button button3;
    }
}
