namespace Assignment_4 {
    partial class Pig_Game_Form {
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WhoseTurnLabel = new System.Windows.Forms.Label();
            this.anotherGameGroupBox = new System.Windows.Forms.GroupBox();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.rollButton = new System.Windows.Forms.Button();
            this.holdButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.playerTwoScoreTextBox = new System.Windows.Forms.TextBox();
            this.playerOneScoreTextBox = new System.Windows.Forms.TextBox();
            this.playerTwoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.anotherGameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(136, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // WhoseTurnLabel
            // 
            this.WhoseTurnLabel.AutoSize = true;
            this.WhoseTurnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhoseTurnLabel.Location = new System.Drawing.Point(16, 76);
            this.WhoseTurnLabel.Name = "WhoseTurnLabel";
            this.WhoseTurnLabel.Size = new System.Drawing.Size(102, 16);
            this.WhoseTurnLabel.TabIndex = 1;
            this.WhoseTurnLabel.Text = "Whose turn to";
            // 
            // anotherGameGroupBox
            // 
            this.anotherGameGroupBox.Controls.Add(this.noRadioButton);
            this.anotherGameGroupBox.Controls.Add(this.yesRadioButton);
            this.anotherGameGroupBox.Enabled = false;
            this.anotherGameGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anotherGameGroupBox.Location = new System.Drawing.Point(261, 192);
            this.anotherGameGroupBox.Name = "anotherGameGroupBox";
            this.anotherGameGroupBox.Size = new System.Drawing.Size(151, 122);
            this.anotherGameGroupBox.TabIndex = 2;
            this.anotherGameGroupBox.TabStop = false;
            this.anotherGameGroupBox.Text = "Another Game?";
            this.anotherGameGroupBox.Enter += new System.EventHandler(this.anotherGameGroupBox_Enter);
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(17, 73);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(46, 20);
            this.noRadioButton.TabIndex = 1;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            this.noRadioButton.CheckedChanged += new System.EventHandler(this.anotherGameGroupBox_Enter);
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(17, 36);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(53, 20);
            this.yesRadioButton.TabIndex = 0;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            this.yesRadioButton.CheckedChanged += new System.EventHandler(this.anotherGameGroupBox_Enter);
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.Color.LawnGreen;
            this.rollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rollButton.Location = new System.Drawing.Point(19, 206);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(93, 27);
            this.rollButton.TabIndex = 1;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = false;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // holdButton
            // 
            this.holdButton.BackColor = System.Drawing.Color.Crimson;
            this.holdButton.Enabled = false;
            this.holdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.holdButton.Location = new System.Drawing.Point(123, 206);
            this.holdButton.Name = "holdButton";
            this.holdButton.Size = new System.Drawing.Size(93, 27);
            this.holdButton.TabIndex = 3;
            this.holdButton.Text = "Hold";
            this.holdButton.UseVisualStyleBackColor = false;
            this.holdButton.Click += new System.EventHandler(this.holdButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "roll or hold";
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneLabel.Location = new System.Drawing.Point(231, 59);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(95, 15);
            this.playerOneLabel.TabIndex = 5;
            this.playerOneLabel.Text = "Player 1 Total";
            // 
            // playerTwoScoreTextBox
            // 
            this.playerTwoScoreTextBox.Location = new System.Drawing.Point(332, 99);
            this.playerTwoScoreTextBox.Name = "playerTwoScoreTextBox";
            this.playerTwoScoreTextBox.ReadOnly = true;
            this.playerTwoScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerTwoScoreTextBox.TabIndex = 7;
            // 
            // playerOneScoreTextBox
            // 
            this.playerOneScoreTextBox.Location = new System.Drawing.Point(332, 58);
            this.playerOneScoreTextBox.Name = "playerOneScoreTextBox";
            this.playerOneScoreTextBox.ReadOnly = true;
            this.playerOneScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerOneScoreTextBox.TabIndex = 8;
            // 
            // playerTwoLabel
            // 
            this.playerTwoLabel.AutoSize = true;
            this.playerTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoLabel.Location = new System.Drawing.Point(231, 100);
            this.playerTwoLabel.Name = "playerTwoLabel";
            this.playerTwoLabel.Size = new System.Drawing.Size(95, 15);
            this.playerTwoLabel.TabIndex = 9;
            this.playerTwoLabel.Text = "Player 2 Total";
            // 
            // Pig_Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 339);
            this.Controls.Add(this.playerTwoLabel);
            this.Controls.Add(this.playerOneScoreTextBox);
            this.Controls.Add(this.playerTwoScoreTextBox);
            this.Controls.Add(this.playerOneLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.holdButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.anotherGameGroupBox);
            this.Controls.Add(this.WhoseTurnLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pig_Game_Form";
            this.Text = "One Die Pig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.anotherGameGroupBox.ResumeLayout(false);
            this.anotherGameGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label WhoseTurnLabel;
        private System.Windows.Forms.GroupBox anotherGameGroupBox;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button holdButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.TextBox playerTwoScoreTextBox;
        private System.Windows.Forms.TextBox playerOneScoreTextBox;
        private System.Windows.Forms.Label playerTwoLabel;
    }
}