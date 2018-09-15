namespace GameOfNim
{
    partial class GamePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePanel));
            this.lblWelcomeTItle = new System.Windows.Forms.Label();
            this.lblGameIntro = new System.Windows.Forms.Label();
            this.blWelcomeMessage = new System.Windows.Forms.Label();
            this.lblFirstPlayerName = new System.Windows.Forms.Label();
            this.lblSecondPlayerName = new System.Windows.Forms.Label();
            this.txtFirstPlayerName = new System.Windows.Forms.TextBox();
            this.txtSecondPlayerName = new System.Windows.Forms.TextBox();
            this.btnFirstPlayerOK = new System.Windows.Forms.Button();
            this.btnSecondPlayerOK = new System.Windows.Forms.Button();
            this.lblReadyMessage = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblCurrentTurn = new System.Windows.Forms.Label();
            this.txtCurrentTurn = new System.Windows.Forms.TextBox();
            this.pnlGameBoard = new System.Windows.Forms.Panel();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.txtGamesPlayed = new System.Windows.Forms.TextBox();
            this.lblGamesPlayed = new System.Windows.Forms.Label();
            this.pnlGameBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeTItle
            // 
            this.lblWelcomeTItle.AutoSize = true;
            this.lblWelcomeTItle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeTItle.Location = new System.Drawing.Point(38, 35);
            this.lblWelcomeTItle.Name = "lblWelcomeTItle";
            this.lblWelcomeTItle.Size = new System.Drawing.Size(433, 33);
            this.lblWelcomeTItle.TabIndex = 0;
            this.lblWelcomeTItle.Text = "Welcome to the Game of Nim!";
            // 
            // lblGameIntro
            // 
            this.lblGameIntro.AutoSize = true;
            this.lblGameIntro.Location = new System.Drawing.Point(38, 98);
            this.lblGameIntro.Name = "lblGameIntro";
            this.lblGameIntro.Size = new System.Drawing.Size(0, 20);
            this.lblGameIntro.TabIndex = 1;
            // 
            // blWelcomeMessage
            // 
            this.blWelcomeMessage.AutoSize = true;
            this.blWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blWelcomeMessage.Location = new System.Drawing.Point(39, 92);
            this.blWelcomeMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blWelcomeMessage.Name = "blWelcomeMessage";
            this.blWelcomeMessage.Size = new System.Drawing.Size(915, 116);
            this.blWelcomeMessage.TabIndex = 1;
            this.blWelcomeMessage.Text = resources.GetString("blWelcomeMessage.Text");
            // 
            // lblFirstPlayerName
            // 
            this.lblFirstPlayerName.AutoSize = true;
            this.lblFirstPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstPlayerName.Location = new System.Drawing.Point(38, 209);
            this.lblFirstPlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstPlayerName.Name = "lblFirstPlayerName";
            this.lblFirstPlayerName.Size = new System.Drawing.Size(205, 29);
            this.lblFirstPlayerName.TabIndex = 2;
            this.lblFirstPlayerName.Text = "First Player Name";
            // 
            // lblSecondPlayerName
            // 
            this.lblSecondPlayerName.AutoSize = true;
            this.lblSecondPlayerName.Enabled = false;
            this.lblSecondPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondPlayerName.Location = new System.Drawing.Point(38, 271);
            this.lblSecondPlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondPlayerName.Name = "lblSecondPlayerName";
            this.lblSecondPlayerName.Size = new System.Drawing.Size(241, 29);
            this.lblSecondPlayerName.TabIndex = 5;
            this.lblSecondPlayerName.Text = "Second Player Name";
            this.lblSecondPlayerName.Visible = false;
            // 
            // txtFirstPlayerName
            // 
            this.txtFirstPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstPlayerName.Location = new System.Drawing.Point(310, 206);
            this.txtFirstPlayerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstPlayerName.Name = "txtFirstPlayerName";
            this.txtFirstPlayerName.Size = new System.Drawing.Size(205, 33);
            this.txtFirstPlayerName.TabIndex = 3;
            // 
            // txtSecondPlayerName
            // 
            this.txtSecondPlayerName.Enabled = false;
            this.txtSecondPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondPlayerName.Location = new System.Drawing.Point(310, 268);
            this.txtSecondPlayerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSecondPlayerName.Name = "txtSecondPlayerName";
            this.txtSecondPlayerName.Size = new System.Drawing.Size(205, 33);
            this.txtSecondPlayerName.TabIndex = 6;
            this.txtSecondPlayerName.Visible = false;
            // 
            // btnFirstPlayerOK
            // 
            this.btnFirstPlayerOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFirstPlayerOK.Location = new System.Drawing.Point(570, 202);
            this.btnFirstPlayerOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFirstPlayerOK.Name = "btnFirstPlayerOK";
            this.btnFirstPlayerOK.Size = new System.Drawing.Size(112, 48);
            this.btnFirstPlayerOK.TabIndex = 4;
            this.btnFirstPlayerOK.Text = "Ready";
            this.btnFirstPlayerOK.UseVisualStyleBackColor = false;
            this.btnFirstPlayerOK.Click += new System.EventHandler(this.btnFirstPlayerOK_Click);
            // 
            // btnSecondPlayerOK
            // 
            this.btnSecondPlayerOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSecondPlayerOK.Enabled = false;
            this.btnSecondPlayerOK.Location = new System.Drawing.Point(570, 263);
            this.btnSecondPlayerOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSecondPlayerOK.Name = "btnSecondPlayerOK";
            this.btnSecondPlayerOK.Size = new System.Drawing.Size(112, 48);
            this.btnSecondPlayerOK.TabIndex = 7;
            this.btnSecondPlayerOK.Text = "Ready";
            this.btnSecondPlayerOK.UseVisualStyleBackColor = false;
            this.btnSecondPlayerOK.Visible = false;
            this.btnSecondPlayerOK.Click += new System.EventHandler(this.btnSecondPlayerOK_Click);
            // 
            // lblReadyMessage
            // 
            this.lblReadyMessage.AutoSize = true;
            this.lblReadyMessage.Enabled = false;
            this.lblReadyMessage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblReadyMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadyMessage.Location = new System.Drawing.Point(282, 340);
            this.lblReadyMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReadyMessage.Name = "lblReadyMessage";
            this.lblReadyMessage.Size = new System.Drawing.Size(193, 29);
            this.lblReadyMessage.TabIndex = 8;
            this.lblReadyMessage.Text = "Ready to Play? ";
            this.lblReadyMessage.Visible = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(543, 334);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(214, 45);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "Let\'s Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblCurrentTurn
            // 
            this.lblCurrentTurn.AutoSize = true;
            this.lblCurrentTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTurn.Location = new System.Drawing.Point(20, 14);
            this.lblCurrentTurn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentTurn.Name = "lblCurrentTurn";
            this.lblCurrentTurn.Size = new System.Drawing.Size(238, 29);
            this.lblCurrentTurn.TabIndex = 11;
            this.lblCurrentTurn.Text = "Current Player\'s Turn";
            // 
            // txtCurrentTurn
            // 
            this.txtCurrentTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentTurn.Location = new System.Drawing.Point(292, 9);
            this.txtCurrentTurn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurrentTurn.Name = "txtCurrentTurn";
            this.txtCurrentTurn.ReadOnly = true;
            this.txtCurrentTurn.Size = new System.Drawing.Size(205, 33);
            this.txtCurrentTurn.TabIndex = 12;
            // 
            // pnlGameBoard
            // 
            this.pnlGameBoard.Controls.Add(this.btnEndTurn);
            this.pnlGameBoard.Controls.Add(this.lblInstructions);
            this.pnlGameBoard.Controls.Add(this.lblCurrentTurn);
            this.pnlGameBoard.Controls.Add(this.txtCurrentTurn);
            this.pnlGameBoard.Enabled = false;
            this.pnlGameBoard.Location = new System.Drawing.Point(2, 398);
            this.pnlGameBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlGameBoard.Name = "pnlGameBoard";
            this.pnlGameBoard.Size = new System.Drawing.Size(1005, 483);
            this.pnlGameBoard.TabIndex = 13;
            this.pnlGameBoard.Visible = false;
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Enabled = false;
            this.btnEndTurn.Location = new System.Drawing.Point(832, 388);
            this.btnEndTurn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(120, 77);
            this.btnEndTurn.TabIndex = 34;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(20, 62);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(658, 25);
            this.lblInstructions.TabIndex = 13;
            this.lblInstructions.Text = "Click on a Row button. Select any one or more marbles to take. Click Done.";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.DarkRed;
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(811, 913);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(143, 52);
            this.btnQuit.TabIndex = 35;
            this.btnQuit.Text = "Quit the Game";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Enabled = false;
            this.btnPlayAgain.Location = new System.Drawing.Point(27, 905);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(233, 69);
            this.btnPlayAgain.TabIndex = 15;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // txtGamesPlayed
            // 
            this.txtGamesPlayed.Location = new System.Drawing.Point(545, 926);
            this.txtGamesPlayed.Name = "txtGamesPlayed";
            this.txtGamesPlayed.ReadOnly = true;
            this.txtGamesPlayed.Size = new System.Drawing.Size(55, 26);
            this.txtGamesPlayed.TabIndex = 36;
            // 
            // lblGamesPlayed
            // 
            this.lblGamesPlayed.AutoSize = true;
            this.lblGamesPlayed.Location = new System.Drawing.Point(423, 929);
            this.lblGamesPlayed.Name = "lblGamesPlayed";
            this.lblGamesPlayed.Size = new System.Drawing.Size(116, 20);
            this.lblGamesPlayed.TabIndex = 37;
            this.lblGamesPlayed.Text = "Games Played:";
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 994);
            this.Controls.Add(this.lblGamesPlayed);
            this.Controls.Add(this.txtGamesPlayed);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.pnlGameBoard);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblReadyMessage);
            this.Controls.Add(this.btnSecondPlayerOK);
            this.Controls.Add(this.btnFirstPlayerOK);
            this.Controls.Add(this.txtSecondPlayerName);
            this.Controls.Add(this.txtFirstPlayerName);
            this.Controls.Add(this.lblSecondPlayerName);
            this.Controls.Add(this.lblFirstPlayerName);
            this.Controls.Add(this.blWelcomeMessage);
            this.Controls.Add(this.lblGameIntro);
            this.Controls.Add(this.lblWelcomeTItle);
            this.Name = "GamePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Nim";
            this.pnlGameBoard.ResumeLayout(false);
            this.pnlGameBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeTItle;
        private System.Windows.Forms.Label lblGameIntro;
        private System.Windows.Forms.Label blWelcomeMessage;
        private System.Windows.Forms.Label lblFirstPlayerName;
        private System.Windows.Forms.Label lblSecondPlayerName;
        private System.Windows.Forms.TextBox txtFirstPlayerName;
        private System.Windows.Forms.TextBox txtSecondPlayerName;
        private System.Windows.Forms.Button btnFirstPlayerOK;
        private System.Windows.Forms.Button btnSecondPlayerOK;
        private System.Windows.Forms.Label lblReadyMessage;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblCurrentTurn;
        private System.Windows.Forms.TextBox txtCurrentTurn;
        private System.Windows.Forms.Panel pnlGameBoard;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.TextBox txtGamesPlayed;
        private System.Windows.Forms.Label lblGamesPlayed;
    }
}

