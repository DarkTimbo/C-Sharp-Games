namespace Assignment_4 {
    partial class Games {
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.GameGroupBox = new System.Windows.Forms.GroupBox();
            this.cardRadioButton = new System.Windows.Forms.RadioButton();
            this.DiceRadioButton = new System.Windows.Forms.RadioButton();
            this.titleLabel = new System.Windows.Forms.Label();
            this.GameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(69, 304);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(123, 31);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(69, 236);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(123, 31);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // GameGroupBox
            // 
            this.GameGroupBox.Controls.Add(this.cardRadioButton);
            this.GameGroupBox.Controls.Add(this.DiceRadioButton);
            this.GameGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameGroupBox.Location = new System.Drawing.Point(55, 76);
            this.GameGroupBox.Name = "GameGroupBox";
            this.GameGroupBox.Size = new System.Drawing.Size(173, 126);
            this.GameGroupBox.TabIndex = 3;
            this.GameGroupBox.TabStop = false;
            this.GameGroupBox.Text = "Select Game Type";
            this.GameGroupBox.Enter += new System.EventHandler(this.GameGroupBox_Enter);
            // 
            // cardRadioButton
            // 
            this.cardRadioButton.AutoSize = true;
            this.cardRadioButton.Location = new System.Drawing.Point(14, 80);
            this.cardRadioButton.Name = "cardRadioButton";
            this.cardRadioButton.Size = new System.Drawing.Size(95, 20);
            this.cardRadioButton.TabIndex = 5;
            this.cardRadioButton.TabStop = true;
            this.cardRadioButton.Text = "Card Game";
            this.cardRadioButton.UseVisualStyleBackColor = true;
            this.cardRadioButton.CheckedChanged += new System.EventHandler(this.GameGroupBox_Enter);
            // 
            // DiceRadioButton
            // 
            this.DiceRadioButton.AutoSize = true;
            this.DiceRadioButton.Location = new System.Drawing.Point(14, 35);
            this.DiceRadioButton.Name = "DiceRadioButton";
            this.DiceRadioButton.Size = new System.Drawing.Size(94, 20);
            this.DiceRadioButton.TabIndex = 4;
            this.DiceRadioButton.TabStop = true;
            this.DiceRadioButton.Text = "Dice Game";
            this.DiceRadioButton.UseVisualStyleBackColor = true;
            this.DiceRadioButton.CheckedChanged += new System.EventHandler(this.GameGroupBox_Enter);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(26, 38);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(202, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Interactive Games";
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 388);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.GameGroupBox);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ExitButton);
            this.Name = "Games";
            this.Text = "Games";
            this.GameGroupBox.ResumeLayout(false);
            this.GameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox GameGroupBox;
        private System.Windows.Forms.RadioButton cardRadioButton;
        private System.Windows.Forms.RadioButton DiceRadioButton;
        private System.Windows.Forms.Label titleLabel;
    }
}

