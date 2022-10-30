namespace Sleeper
{
    partial class MainForm
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
            this.SleepButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SleepButton
            // 
            this.SleepButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SleepButton.Location = new System.Drawing.Point(70, 131);
            this.SleepButton.Name = "SleepButton";
            this.SleepButton.Size = new System.Drawing.Size(121, 62);
            this.SleepButton.TabIndex = 0;
            this.SleepButton.Text = "Sleep";
            this.SleepButton.UseVisualStyleBackColor = true;
            this.SleepButton.Click += new System.EventHandler(this.SleepButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 335);
            this.Controls.Add(this.SleepButton);
            this.Name = "MainForm";
            this.Text = "Sleeper";
            this.ResumeLayout(false);

        }

        #endregion

        private Button SleepButton;
    }
}