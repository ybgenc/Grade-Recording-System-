namespace Grade_Recording_System
{
    partial class LogIn
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
            this.StudentNumberLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.StudentNumberTB = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // StudentNumberLabel
            // 
            this.StudentNumberLabel.AutoSize = true;
            this.StudentNumberLabel.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F);
            this.StudentNumberLabel.Location = new System.Drawing.Point(25, 47);
            this.StudentNumberLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StudentNumberLabel.Name = "StudentNumberLabel";
            this.StudentNumberLabel.Size = new System.Drawing.Size(165, 26);
            this.StudentNumberLabel.TabIndex = 0;
            this.StudentNumberLabel.Text = "Student Number";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.LoginButton.Location = new System.Drawing.Point(30, 113);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(481, 53);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // StudentNumberTB
            // 
            this.StudentNumberTB.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNumberTB.Location = new System.Drawing.Point(211, 43);
            this.StudentNumberTB.Margin = new System.Windows.Forms.Padding(5);
            this.StudentNumberTB.Mask = "0000";
            this.StudentNumberTB.Name = "StudentNumberTB";
            this.StudentNumberTB.Size = new System.Drawing.Size(300, 34);
            this.StudentNumberTB.TabIndex = 3;
            this.StudentNumberTB.ValidatingType = typeof(int);
            this.StudentNumberTB.TextChanged += new System.EventHandler(this.StudentNumberTB_TextChanged);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 209);
            this.Controls.Add(this.StudentNumberTB);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.StudentNumberLabel);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LogIn";
            this.Text = "Student Grade Recording System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentNumberLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.MaskedTextBox StudentNumberTB;
    }
}