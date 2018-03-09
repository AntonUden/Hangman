namespace Hangman
{
    partial class gameStart
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
            this.fileStatus = new System.Windows.Forms.Label();
            this.wordListFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.oWordList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loadDefault = new System.Windows.Forms.Button();
            this.startGame = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.noWordlistError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guess = new System.Windows.Forms.TextBox();
            this.stopGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.livesSelector = new System.Windows.Forms.NumericUpDown();
            this.usedLetters = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lifeBar = new System.Windows.Forms.ProgressBar();
            this.wordOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livesSelector)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileStatus
            // 
            this.fileStatus.AutoSize = true;
            this.fileStatus.Location = new System.Drawing.Point(6, 45);
            this.fileStatus.Name = "fileStatus";
            this.fileStatus.Size = new System.Drawing.Size(51, 13);
            this.fileStatus.TabIndex = 0;
            this.fileStatus.Text = "file status";
            // 
            // wordListFileDialog
            // 
            this.wordListFileDialog.FileName = "Select wordlist";
            // 
            // oWordList
            // 
            this.oWordList.Location = new System.Drawing.Point(6, 19);
            this.oWordList.Name = "oWordList";
            this.oWordList.Size = new System.Drawing.Size(188, 23);
            this.oWordList.TabIndex = 1;
            this.oWordList.Text = "Open wordlist";
            this.oWordList.UseVisualStyleBackColor = true;
            this.oWordList.Click += new System.EventHandler(this.oWordList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadDefault);
            this.groupBox1.Controls.Add(this.oWordList);
            this.groupBox1.Controls.Add(this.fileStatus);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wordlist selector";
            // 
            // loadDefault
            // 
            this.loadDefault.Location = new System.Drawing.Point(9, 71);
            this.loadDefault.Name = "loadDefault";
            this.loadDefault.Size = new System.Drawing.Size(185, 23);
            this.loadDefault.TabIndex = 2;
            this.loadDefault.Text = "Load english wordlist";
            this.loadDefault.UseVisualStyleBackColor = true;
            this.loadDefault.Click += new System.EventHandler(this.loadDefault_Click);
            // 
            // startGame
            // 
            this.startGame.Location = new System.Drawing.Point(6, 19);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(188, 23);
            this.startGame.TabIndex = 3;
            this.startGame.Text = "Start game";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.noWordlistError);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.guess);
            this.groupBox2.Controls.Add(this.stopGame);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.livesSelector);
            this.groupBox2.Controls.Add(this.startGame);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 231);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game";
            // 
            // noWordlistError
            // 
            this.noWordlistError.AutoSize = true;
            this.noWordlistError.ForeColor = System.Drawing.Color.Red;
            this.noWordlistError.Location = new System.Drawing.Point(6, 113);
            this.noWordlistError.Name = "noWordlistError";
            this.noWordlistError.Size = new System.Drawing.Size(143, 26);
            this.noWordlistError.TabIndex = 13;
            this.noWordlistError.Text = "You need to select a wordlist\r\nbefore you start the game";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Set max lives";
            // 
            // guess
            // 
            this.guess.Location = new System.Drawing.Point(6, 205);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(188, 20);
            this.guess.TabIndex = 9;
            this.guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guess.TextChanged += new System.EventHandler(this.guess_TextChanged);
            // 
            // stopGame
            // 
            this.stopGame.Location = new System.Drawing.Point(6, 48);
            this.stopGame.Name = "stopGame";
            this.stopGame.Size = new System.Drawing.Size(188, 23);
            this.stopGame.TabIndex = 11;
            this.stopGame.Text = "Stop game";
            this.stopGame.UseVisualStyleBackColor = true;
            this.stopGame.Click += new System.EventHandler(this.stopGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type your guess here";
            // 
            // livesSelector
            // 
            this.livesSelector.Location = new System.Drawing.Point(6, 90);
            this.livesSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.livesSelector.Name = "livesSelector";
            this.livesSelector.Size = new System.Drawing.Size(188, 20);
            this.livesSelector.TabIndex = 9;
            this.livesSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // usedLetters
            // 
            this.usedLetters.Location = new System.Drawing.Point(6, 311);
            this.usedLetters.Name = "usedLetters";
            this.usedLetters.ReadOnly = true;
            this.usedLetters.Size = new System.Drawing.Size(532, 20);
            this.usedLetters.TabIndex = 5;
            this.usedLetters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.result);
            this.groupBox3.Controls.Add(this.lifeBar);
            this.groupBox3.Controls.Add(this.wordOutput);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.usedLetters);
            this.groupBox3.Location = new System.Drawing.Point(228, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 337);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // lifeBar
            // 
            this.lifeBar.Location = new System.Drawing.Point(6, 45);
            this.lifeBar.Name = "lifeBar";
            this.lifeBar.Size = new System.Drawing.Size(532, 23);
            this.lifeBar.TabIndex = 8;
            // 
            // wordOutput
            // 
            this.wordOutput.Location = new System.Drawing.Point(6, 19);
            this.wordOutput.Name = "wordOutput";
            this.wordOutput.ReadOnly = true;
            this.wordOutput.Size = new System.Drawing.Size(532, 20);
            this.wordOutput.TabIndex = 7;
            this.wordOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Used letters";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(6, 71);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(52, 13);
            this.result.TabIndex = 9;
            this.result.Text = "---------------";
            // 
            // gameStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "gameStart";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livesSelector)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fileStatus;
        private System.Windows.Forms.OpenFileDialog wordListFileDialog;
        private System.Windows.Forms.Button oWordList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown livesSelector;
        private System.Windows.Forms.TextBox usedLetters;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar lifeBar;
        private System.Windows.Forms.TextBox wordOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stopGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label noWordlistError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox guess;
        private System.Windows.Forms.Button loadDefault;
        private System.Windows.Forms.Label result;
    }
}

