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
            this.components = new System.ComponentModel.Container();
            this.SleepButton = new System.Windows.Forms.Button();
            this.timerUpDown = new System.Windows.Forms.NumericUpDown();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.timerUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SleepButton
            // 
            this.SleepButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SleepButton.Location = new System.Drawing.Point(12, 42);
            this.SleepButton.Name = "SleepButton";
            this.SleepButton.Size = new System.Drawing.Size(136, 62);
            this.SleepButton.TabIndex = 0;
            this.SleepButton.Text = "Sleep";
            this.SleepButton.UseVisualStyleBackColor = true;
            this.SleepButton.Click += new System.EventHandler(this.SleepButton_Click);
            // 
            // timerUpDown
            // 
            this.timerUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerUpDown.Location = new System.Drawing.Point(84, 7);
            this.timerUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.timerUpDown.Name = "timerUpDown";
            this.timerUpDown.Size = new System.Drawing.Size(64, 29);
            this.timerUpDown.TabIndex = 1;
            this.timerUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.Location = new System.Drawing.Point(12, 9);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(66, 21);
            this.timerLabel.TabIndex = 2;
            this.timerLabel.Text = "Таймер:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 118);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.timerUpDown);
            this.Controls.Add(this.SleepButton);
            this.Name = "MainForm";
            this.Text = "Sleeper";
            ((System.ComponentModel.ISupportInitialize)(this.timerUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SleepButton;
        private NumericUpDown timerUpDown;
        private Label timerLabel;
        private System.Windows.Forms.Timer timer1;
    }
}