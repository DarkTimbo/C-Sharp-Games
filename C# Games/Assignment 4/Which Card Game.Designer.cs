namespace Assignment_4 {
    partial class Which_Card_Game {
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.WhichGameComboBox = new System.Windows.Forms.ComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(22, 35);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(227, 24);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Choose a Game to play";
            // 
            // WhichGameComboBox
            // 
            this.WhichGameComboBox.FormattingEnabled = true;
            this.WhichGameComboBox.Items.AddRange(new object[] {
            "Solitaire",
            "Twenty-One"});
            this.WhichGameComboBox.Location = new System.Drawing.Point(66, 79);
            this.WhichGameComboBox.Name = "WhichGameComboBox";
            this.WhichGameComboBox.Size = new System.Drawing.Size(130, 21);
            this.WhichGameComboBox.TabIndex = 1;
            this.WhichGameComboBox.SelectedIndexChanged += new System.EventHandler(this.WhichGameComboBox_SelectedIndexChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(92, 145);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(86, 52);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Which_Card_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 279);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.WhichGameComboBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Which_Card_Game";
            this.Text = "Card Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ComboBox WhichGameComboBox;
        private System.Windows.Forms.Button ExitButton;
    }
}