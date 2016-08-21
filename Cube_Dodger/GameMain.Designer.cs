namespace Cube_Dodger
{
    partial class GameMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMain));
            this.scoreTxt_label = new System.Windows.Forms.Label();
            this.scoreDynamic_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerEnemy = new System.Windows.Forms.Timer(this.components);
            this.gameOverTxt_label = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.dubstepTxt_label = new System.Windows.Forms.Label();
            this.timerEnemy2 = new System.Windows.Forms.Timer(this.components);
            this.timerEnemy3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // scoreTxt_label
            // 
            this.scoreTxt_label.AutoSize = true;
            this.scoreTxt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreTxt_label.Location = new System.Drawing.Point(13, 13);
            this.scoreTxt_label.Name = "scoreTxt_label";
            this.scoreTxt_label.Size = new System.Drawing.Size(107, 31);
            this.scoreTxt_label.TabIndex = 0;
            this.scoreTxt_label.Text = "Score: ";
            // 
            // scoreDynamic_label
            // 
            this.scoreDynamic_label.AutoSize = true;
            this.scoreDynamic_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreDynamic_label.Location = new System.Drawing.Point(113, 13);
            this.scoreDynamic_label.Name = "scoreDynamic_label";
            this.scoreDynamic_label.Size = new System.Drawing.Size(30, 31);
            this.scoreDynamic_label.TabIndex = 1;
            this.scoreDynamic_label.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timerMoving);
            // 
            // timerEnemy
            // 
            this.timerEnemy.Enabled = true;
            this.timerEnemy.Interval = 1;
            this.timerEnemy.Tick += new System.EventHandler(this.timerMoving_Enemy);
            // 
            // gameOverTxt_label
            // 
            this.gameOverTxt_label.AutoSize = true;
            this.gameOverTxt_label.Font = new System.Drawing.Font("Roboto Slab", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameOverTxt_label.Location = new System.Drawing.Point(84, 215);
            this.gameOverTxt_label.Name = "gameOverTxt_label";
            this.gameOverTxt_label.Size = new System.Drawing.Size(210, 43);
            this.gameOverTxt_label.TabIndex = 2;
            this.gameOverTxt_label.Text = "GAME OVER";
            this.gameOverTxt_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameOverTxt_label.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(92, 270);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(195, 270);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 4;
            this.btnQuit.Text = "Quit game";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Visible = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // dubstepTxt_label
            // 
            this.dubstepTxt_label.AutoSize = true;
            this.dubstepTxt_label.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dubstepTxt_label.Location = new System.Drawing.Point(27, 97);
            this.dubstepTxt_label.Name = "dubstepTxt_label";
            this.dubstepTxt_label.Size = new System.Drawing.Size(336, 45);
            this.dubstepTxt_label.TabIndex = 5;
            this.dubstepTxt_label.Text = "DUBSTEP MODE!!!!";
            this.dubstepTxt_label.Visible = false;
            // 
            // timerEnemy2
            // 
            this.timerEnemy2.Enabled = true;
            this.timerEnemy2.Interval = 1;
            this.timerEnemy2.Tick += new System.EventHandler(this.timerMoving_Enemy2);
            // 
            // timerEnemy3
            // 
            this.timerEnemy3.Enabled = true;
            this.timerEnemy3.Interval = 1;
            this.timerEnemy3.Tick += new System.EventHandler(this.timerMoving_Enemy3);
            // 
            // GameMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 662);
            this.Controls.Add(this.dubstepTxt_label);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.gameOverTxt_label);
            this.Controls.Add(this.scoreDynamic_label);
            this.Controls.Add(this.scoreTxt_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 700);
            this.Name = "GameMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game by SKocur";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameMain_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameMain_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreTxt_label;
        private System.Windows.Forms.Label scoreDynamic_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerEnemy;
        private System.Windows.Forms.Label gameOverTxt_label;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label dubstepTxt_label;
        private System.Windows.Forms.Timer timerEnemy2;
        private System.Windows.Forms.Timer timerEnemy3;
    }
}

