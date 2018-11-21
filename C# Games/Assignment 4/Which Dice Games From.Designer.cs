namespace Assignment_4 {
    partial class Dice_Games_Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.WhichPigGroupBox = new System.Windows.Forms.GroupBox();
            this.TwoDicePigRadioButton = new System.Windows.Forms.RadioButton();
            this.SingleDiePigRadioButton = new System.Windows.Forms.RadioButton();
            this.ExitButton = new System.Windows.Forms.Button();
            this.WhichPigGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WhichPigGroupBox
            // 
            this.WhichPigGroupBox.Controls.Add(this.TwoDicePigRadioButton);
            this.WhichPigGroupBox.Controls.Add(this.SingleDiePigRadioButton);
            this.WhichPigGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhichPigGroupBox.Location = new System.Drawing.Point(30, 33);
            this.WhichPigGroupBox.Name = "WhichPigGroupBox";
            this.WhichPigGroupBox.Size = new System.Drawing.Size(200, 127);
            this.WhichPigGroupBox.TabIndex = 0;
            this.WhichPigGroupBox.TabStop = false;
            this.WhichPigGroupBox.Text = "Select which Pig to play";
            this.WhichPigGroupBox.Enter += new System.EventHandler(this.WhichPigGroupBox_Enter);
            // 
            // TwoDicePigRadioButton
            // 
            this.TwoDicePigRadioButton.AutoSize = true;
            this.TwoDicePigRadioButton.Location = new System.Drawing.Point(25, 79);
            this.TwoDicePigRadioButton.Name = "TwoDicePigRadioButton";
            this.TwoDicePigRadioButton.Size = new System.Drawing.Size(118, 20);
            this.TwoDicePigRadioButton.TabIndex = 1;
            this.TwoDicePigRadioButton.TabStop = true;
            this.TwoDicePigRadioButton.Text = "Two Dice Pig";
            this.TwoDicePigRadioButton.UseVisualStyleBackColor = true;
            this.TwoDicePigRadioButton.Click += new System.EventHandler(this.WhichPigGroupBox_Enter);
            // 
            // SingleDiePigRadioButton
            // 
            this.SingleDiePigRadioButton.AutoSize = true;
            this.SingleDiePigRadioButton.Location = new System.Drawing.Point(25, 36);
            this.SingleDiePigRadioButton.Name = "SingleDiePigRadioButton";
            this.SingleDiePigRadioButton.Size = new System.Drawing.Size(125, 20);
            this.SingleDiePigRadioButton.TabIndex = 0;
            this.SingleDiePigRadioButton.TabStop = true;
            this.SingleDiePigRadioButton.Text = "Single Die Pig";
            this.SingleDiePigRadioButton.UseVisualStyleBackColor = true;
            this.SingleDiePigRadioButton.Click += new System.EventHandler(this.WhichPigGroupBox_Enter);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(63, 192);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(105, 41);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Dice_Games_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.WhichPigGroupBox);
            this.Name = "Dice_Games_Form";
            this.Text = "Dice Games";
            this.WhichPigGroupBox.ResumeLayout(false);
            this.WhichPigGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox WhichPigGroupBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.RadioButton TwoDicePigRadioButton;
        private System.Windows.Forms.RadioButton SingleDiePigRadioButton;
    }
}