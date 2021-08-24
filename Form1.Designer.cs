
namespace Auto_Clicker
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
            this.startButton = new System.Windows.Forms.Button();
            this.abortButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.runForeverBox = new System.Windows.Forms.CheckBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SecTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LawnGreen;
            this.startButton.Location = new System.Drawing.Point(12, 47);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // abortButton
            // 
            this.abortButton.BackColor = System.Drawing.Color.Crimson;
            this.abortButton.Location = new System.Drawing.Point(122, 47);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(75, 23);
            this.abortButton.TabIndex = 1;
            this.abortButton.Text = "Abort";
            this.abortButton.UseVisualStyleBackColor = false;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "By Mateusz Peplinski";
            // 
            // runForeverBox
            // 
            this.runForeverBox.AutoSize = true;
            this.runForeverBox.Location = new System.Drawing.Point(12, 76);
            this.runForeverBox.Name = "runForeverBox";
            this.runForeverBox.Size = new System.Drawing.Size(88, 17);
            this.runForeverBox.TabIndex = 3;
            this.runForeverBox.Text = "Run Forever ";
            this.runForeverBox.UseVisualStyleBackColor = true;
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(40, 12);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(58, 20);
            this.minTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mins:";
            // 
            // SecTextBox
            // 
            this.SecTextBox.Location = new System.Drawing.Point(139, 12);
            this.SecTextBox.Name = "SecTextBox";
            this.SecTextBox.Size = new System.Drawing.Size(58, 20);
            this.SecTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Secs:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 129);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.runForeverBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Auto Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox runForeverBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SecTextBox;
        private System.Windows.Forms.Label label3;
    }
}

