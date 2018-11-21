namespace Assignment_4 {
    partial class TwentyOne_Game_Form {
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
            this.dealerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dealerNumWinsLabel = new System.Windows.Forms.Label();
            this.playerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DealButton = new System.Windows.Forms.Button();
            this.playerBustedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GameWonPlayerLabel = new System.Windows.Forms.Label();
            this.dealerPointsLabel = new System.Windows.Forms.Label();
            this.dealerBustedLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.playerPointsLabel = new System.Windows.Forms.Label();
            this.DealerWonGamesLabel = new System.Windows.Forms.Label();
            this.playerNumWinsLabel = new System.Windows.Forms.Label();
            this.HitButton = new System.Windows.Forms.Button();
            this.StandButton = new System.Windows.Forms.Button();
            this.CancelGameButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.NumberOfAcesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dealerTableLayoutPanel
            // 
            this.dealerTableLayoutPanel.ColumnCount = 8;
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.dealerTableLayoutPanel.Location = new System.Drawing.Point(16, 69);
            this.dealerTableLayoutPanel.Name = "dealerTableLayoutPanel";
            this.dealerTableLayoutPanel.RowCount = 1;
            this.dealerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dealerTableLayoutPanel.Size = new System.Drawing.Size(576, 95);
            this.dealerTableLayoutPanel.TabIndex = 0;
            // 
            // dealerNumWinsLabel
            // 
            this.dealerNumWinsLabel.AutoSize = true;
            this.dealerNumWinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerNumWinsLabel.Location = new System.Drawing.Point(571, 28);
            this.dealerNumWinsLabel.Name = "dealerNumWinsLabel";
            this.dealerNumWinsLabel.Size = new System.Drawing.Size(14, 15);
            this.dealerNumWinsLabel.TabIndex = 20;
            this.dealerNumWinsLabel.Text = "0";
            // 
            // playerTableLayoutPanel
            // 
            this.playerTableLayoutPanel.ColumnCount = 8;
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.playerTableLayoutPanel.Location = new System.Drawing.Point(16, 192);
            this.playerTableLayoutPanel.Name = "playerTableLayoutPanel";
            this.playerTableLayoutPanel.RowCount = 1;
            this.playerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.playerTableLayoutPanel.Size = new System.Drawing.Size(576, 95);
            this.playerTableLayoutPanel.TabIndex = 1;
            // 
            // DealButton
            // 
            this.DealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealButton.Location = new System.Drawing.Point(82, 373);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(66, 23);
            this.DealButton.TabIndex = 0;
            this.DealButton.Text = "Deal";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // playerBustedLabel
            // 
            this.playerBustedLabel.AutoSize = true;
            this.playerBustedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerBustedLabel.ForeColor = System.Drawing.Color.Red;
            this.playerBustedLabel.Location = new System.Drawing.Point(148, 322);
            this.playerBustedLabel.Name = "playerBustedLabel";
            this.playerBustedLabel.Size = new System.Drawing.Size(91, 24);
            this.playerBustedLabel.TabIndex = 6;
            this.playerBustedLabel.Text = "BUSTED";
            this.playerBustedLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player";
            // 
            // GameWonPlayerLabel
            // 
            this.GameWonPlayerLabel.AutoSize = true;
            this.GameWonPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameWonPlayerLabel.Location = new System.Drawing.Point(490, 322);
            this.GameWonPlayerLabel.Name = "GameWonPlayerLabel";
            this.GameWonPlayerLabel.Size = new System.Drawing.Size(75, 15);
            this.GameWonPlayerLabel.TabIndex = 9;
            this.GameWonPlayerLabel.Text = "Games Won";
            // 
            // dealerPointsLabel
            // 
            this.dealerPointsLabel.AutoSize = true;
            this.dealerPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerPointsLabel.Location = new System.Drawing.Point(338, 30);
            this.dealerPointsLabel.Name = "dealerPointsLabel";
            this.dealerPointsLabel.Size = new System.Drawing.Size(85, 24);
            this.dealerPointsLabel.TabIndex = 13;
            this.dealerPointsLabel.Text = "POINTS";
            this.dealerPointsLabel.Visible = false;
            // 
            // dealerBustedLabel
            // 
            this.dealerBustedLabel.AutoSize = true;
            this.dealerBustedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerBustedLabel.ForeColor = System.Drawing.Color.Red;
            this.dealerBustedLabel.Location = new System.Drawing.Point(135, 28);
            this.dealerBustedLabel.Name = "dealerBustedLabel";
            this.dealerBustedLabel.Size = new System.Drawing.Size(91, 24);
            this.dealerBustedLabel.TabIndex = 16;
            this.dealerBustedLabel.Text = "BUSTED";
            this.dealerBustedLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(251, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Dealer";
            // 
            // playerPointsLabel
            // 
            this.playerPointsLabel.AutoSize = true;
            this.playerPointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerPointsLabel.Location = new System.Drawing.Point(338, 322);
            this.playerPointsLabel.Name = "playerPointsLabel";
            this.playerPointsLabel.Size = new System.Drawing.Size(85, 24);
            this.playerPointsLabel.TabIndex = 18;
            this.playerPointsLabel.Text = "POINTS";
            this.playerPointsLabel.Visible = false;
            // 
            // DealerWonGamesLabel
            // 
            this.DealerWonGamesLabel.AutoSize = true;
            this.DealerWonGamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerWonGamesLabel.Location = new System.Drawing.Point(490, 28);
            this.DealerWonGamesLabel.Name = "DealerWonGamesLabel";
            this.DealerWonGamesLabel.Size = new System.Drawing.Size(75, 15);
            this.DealerWonGamesLabel.TabIndex = 19;
            this.DealerWonGamesLabel.Text = "Games Won";
            // 
            // playerNumWinsLabel
            // 
            this.playerNumWinsLabel.AutoSize = true;
            this.playerNumWinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNumWinsLabel.Location = new System.Drawing.Point(571, 322);
            this.playerNumWinsLabel.Name = "playerNumWinsLabel";
            this.playerNumWinsLabel.Size = new System.Drawing.Size(14, 15);
            this.playerNumWinsLabel.TabIndex = 21;
            this.playerNumWinsLabel.Text = "0";
            // 
            // HitButton
            // 
            this.HitButton.Enabled = false;
            this.HitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HitButton.Location = new System.Drawing.Point(198, 372);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(66, 23);
            this.HitButton.TabIndex = 22;
            this.HitButton.Text = "Hit";
            this.HitButton.UseVisualStyleBackColor = true;
            this.HitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // StandButton
            // 
            this.StandButton.Enabled = false;
            this.StandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StandButton.Location = new System.Drawing.Point(313, 372);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(66, 23);
            this.StandButton.TabIndex = 23;
            this.StandButton.Text = "Stand";
            this.StandButton.UseVisualStyleBackColor = true;
            this.StandButton.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // CancelGameButton
            // 
            this.CancelGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelGameButton.Location = new System.Drawing.Point(416, 372);
            this.CancelGameButton.Name = "CancelGameButton";
            this.CancelGameButton.Size = new System.Drawing.Size(66, 23);
            this.CancelGameButton.TabIndex = 24;
            this.CancelGameButton.Text = "Cancel";
            this.CancelGameButton.UseVisualStyleBackColor = true;
            this.CancelGameButton.Click += new System.EventHandler(this.CancelGameButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 300);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Number of Aces with value 1";
            // 
            // NumberOfAcesLabel
            // 
            this.NumberOfAcesLabel.AutoSize = true;
            this.NumberOfAcesLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumberOfAcesLabel.Location = new System.Drawing.Point(294, 300);
            this.NumberOfAcesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberOfAcesLabel.Name = "NumberOfAcesLabel";
            this.NumberOfAcesLabel.Size = new System.Drawing.Size(13, 13);
            this.NumberOfAcesLabel.TabIndex = 26;
            this.NumberOfAcesLabel.Text = "0";
            // 
            // TwentyOne_Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 421);
            this.Controls.Add(this.NumberOfAcesLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CancelGameButton);
            this.Controls.Add(this.StandButton);
            this.Controls.Add(this.HitButton);
            this.Controls.Add(this.playerNumWinsLabel);
            this.Controls.Add(this.dealerNumWinsLabel);
            this.Controls.Add(this.DealerWonGamesLabel);
            this.Controls.Add(this.playerPointsLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dealerBustedLabel);
            this.Controls.Add(this.dealerPointsLabel);
            this.Controls.Add(this.GameWonPlayerLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerBustedLabel);
            this.Controls.Add(this.DealButton);
            this.Controls.Add(this.playerTableLayoutPanel);
            this.Controls.Add(this.dealerTableLayoutPanel);
            this.Name = "TwentyOne_Game_Form";
            this.Text = "Twenty One";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel dealerTableLayoutPanel;
        private System.Windows.Forms.Label dealerNumWinsLabel;
        private System.Windows.Forms.TableLayoutPanel playerTableLayoutPanel;
        private System.Windows.Forms.Button DealButton;
        private System.Windows.Forms.Label playerBustedLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label GameWonPlayerLabel;
        private System.Windows.Forms.Label dealerPointsLabel;
        private System.Windows.Forms.Label dealerBustedLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label playerPointsLabel;
        private System.Windows.Forms.Label DealerWonGamesLabel;
        private System.Windows.Forms.Label playerNumWinsLabel;
        private System.Windows.Forms.Button HitButton;
        private System.Windows.Forms.Button StandButton;
        private System.Windows.Forms.Button CancelGameButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label NumberOfAcesLabel;
    }
}