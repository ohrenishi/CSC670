namespace WindowsFormsApp3
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
            this.sumButton = new System.Windows.Forms.Button();
            this.differenceButton = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputTextBox1 = new System.Windows.Forms.TextBox();
            this.inputTextBox2 = new System.Windows.Forms.TextBox();
            this.resultRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(96, 182);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(75, 23);
            this.sumButton.TabIndex = 0;
            this.sumButton.Text = "Sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // differenceButton
            // 
            this.differenceButton.Location = new System.Drawing.Point(177, 182);
            this.differenceButton.Name = "differenceButton";
            this.differenceButton.Size = new System.Drawing.Size(75, 23);
            this.differenceButton.TabIndex = 1;
            this.differenceButton.Text = "Difference";
            this.differenceButton.UseVisualStyleBackColor = true;
            this.differenceButton.Click += new System.EventHandler(this.differenceButton_Click);
            // 
            // productButton
            // 
            this.productButton.Location = new System.Drawing.Point(261, 182);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(75, 23);
            this.productButton.TabIndex = 2;
            this.productButton.Text = "Product";
            this.productButton.UseVisualStyleBackColor = true;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(96, 211);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 23);
            this.divideButton.TabIndex = 3;
            this.divideButton.Text = "Divide";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(177, 211);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear ";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter 1st Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter 2nd Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Show Results";
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.Location = new System.Drawing.Point(128, 12);
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox1.TabIndex = 8;
            this.inputTextBox1.TextChanged += new System.EventHandler(this.inputTextBox1_TextChanged);
            // 
            // inputTextBox2
            // 
            this.inputTextBox2.Location = new System.Drawing.Point(128, 48);
            this.inputTextBox2.Name = "inputTextBox2";
            this.inputTextBox2.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox2.TabIndex = 9;
            // 
            // resultRichTextBox1
            // 
            this.resultRichTextBox1.Location = new System.Drawing.Point(128, 84);
            this.resultRichTextBox1.Name = "resultRichTextBox1";
            this.resultRichTextBox1.Size = new System.Drawing.Size(180, 92);
            this.resultRichTextBox1.TabIndex = 10;
            this.resultRichTextBox1.Text = "";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(258, 211);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 262);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resultRichTextBox1);
            this.Controls.Add(this.inputTextBox2);
            this.Controls.Add(this.inputTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.productButton);
            this.Controls.Add(this.differenceButton);
            this.Controls.Add(this.sumButton);
            this.Name = "Form1";
            this.Text = "CSC670 Week 1: Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button differenceButton;
        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputTextBox1;
        private System.Windows.Forms.TextBox inputTextBox2;
        private System.Windows.Forms.RichTextBox resultRichTextBox1;
        private System.Windows.Forms.Button exitButton;
    }
}

