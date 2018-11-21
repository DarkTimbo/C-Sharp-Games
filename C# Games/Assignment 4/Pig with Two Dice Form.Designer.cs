namespace Assignment_4 {
    partial class Pig_with_Two_Dice_Form {
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
            this.components = new System.ComponentModel.Container();
            this.playerTwoLabel = new System.Windows.Forms.Label();
            this.playerOneScoreTextBox = new System.Windows.Forms.TextBox();
            this.playerTwoScoreTextBox = new System.Windows.Forms.TextBox();
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.holdButton = new System.Windows.Forms.Button();
            this.rollButton = new System.Windows.Forms.Button();
            this.anotherGameGroupBox = new System.Windows.Forms.GroupBox();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.WhoseTurnLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.anotherGameGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // playerTwoLabel
            // 
            this.playerTwoLabel.AutoSize = true;
            this.playerTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoLabel.Location = new System.Drawing.Point(306, 95);
            this.playerTwoLabel.Name = "playerTwoLabel";
            this.playerTwoLabel.Size = new System.Drawing.Size(95, 15);
            this.playerTwoLabel.TabIndex = 19;
            this.playerTwoLabel.Text = "Player 2 Total";
            // 
            // playerOneScoreTextBox
            // 
            this.playerOneScoreTextBox.Location = new System.Drawing.Point(407, 53);
            this.playerOneScoreTextBox.Name = "playerOneScoreTextBox";
            this.playerOneScoreTextBox.ReadOnly = true;
            this.playerOneScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerOneScoreTextBox.TabIndex = 18;
            // 
            // playerTwoScoreTextBox
            // 
            this.playerTwoScoreTextBox.Location = new System.Drawing.Point(407, 94);
            this.playerTwoScoreTextBox.Name = "playerTwoScoreTextBox";
            this.playerTwoScoreTextBox.ReadOnly = true;
            this.playerTwoScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.playerTwoScoreTextBox.TabIndex = 17;
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneLabel.Location = new System.Drawing.Point(306, 54);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(95, 15);
            this.playerOneLabel.TabIndex = 16;
            this.playerOneLabel.Text = "Player 1 Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "roll or hold";
            // 
            // holdButton
            // 
            this.holdButton.BackColor = System.Drawing.Color.Crimson;
            this.holdButton.Enabled = false;
            this.holdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.holdButton.Location = new System.Drawing.Point(133, 195);
            this.holdButton.Name = "holdButton";
            this.holdButton.Size = new System.Drawing.Size(93, 27);
            this.holdButton.TabIndex = 14;
            this.holdButton.Text = "Hold";
            this.holdButton.UseVisualStyleBackColor = false;
            this.holdButton.Click += new System.EventHandler(this.holdButton_Click);
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.Color.LawnGreen;
            this.rollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rollButton.Location = new System.Drawing.Point(29, 195);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(93, 27);
            this.rollButton.TabIndex = 11;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = false;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // anotherGameGroupBox
            // 
            this.anotherGameGroupBox.Controls.Add(this.noRadioButton);
            this.anotherGameGroupBox.Controls.Add(this.yesRadioButton);
            this.anotherGameGroupBox.Enabled = false;
            this.anotherGameGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anotherGameGroupBox.Location = new System.Drawing.Point(346, 183);
            this.anotherGameGroupBox.Name = "anotherGameGroupBox";
            this.anotherGameGroupBox.Size = new System.Drawing.Size(151, 122);
            this.anotherGameGroupBox.TabIndex = 13;
            this.anotherGameGroupBox.TabStop = false;
            this.anotherGameGroupBox.Text = "Another Game?";
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
            // WhoseTurnLabel
            // 
            this.WhoseTurnLabel.AutoSize = true;
            this.WhoseTurnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhoseTurnLabel.Location = new System.Drawing.Point(26, 65);
            this.WhoseTurnLabel.Name = "WhoseTurnLabel";
            this.WhoseTurnLabel.Size = new System.Drawing.Size(102, 16);
            this.WhoseTurnLabel.TabIndex = 12;
            this.WhoseTurnLabel.Text = "Whose turn to";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(146, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(230, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Pig_with_Two_Dice_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 350);
            this.Controls.Add(this.pictureBox2);
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
            this.Name = "Pig_with_Two_Dice_Form";
            this.Text = "Two Die Pig";
            this.anotherGameGroupBox.ResumeLayout(false);
            this.anotherGameGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerTwoLabel;
        private System.Windows.Forms.TextBox playerOneScoreTextBox;
        private System.Windows.Forms.TextBox playerTwoScoreTextBox;
        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button holdButton;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.GroupBox anotherGameGroupBox;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.Label WhoseTurnLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer;
    }
}