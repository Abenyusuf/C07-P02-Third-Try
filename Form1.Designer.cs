namespace C07_P02
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.LabelResults = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(10, 340);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 41);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(375, 340);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 41);
            this.CheckButton.TabIndex = 1;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // LabelResults
            // 
            this.LabelResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelResults.Location = new System.Drawing.Point(10, 9);
            this.LabelResults.Name = "LabelResults";
            this.LabelResults.Size = new System.Drawing.Size(440, 209);
            this.LabelResults.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Click the check button to grade students test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelResults);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.ExitButton);
            this.Name = "Form1";
            this.Text = "DMV Test Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label LabelResults;
        private System.Windows.Forms.Label label1;
    }
}

