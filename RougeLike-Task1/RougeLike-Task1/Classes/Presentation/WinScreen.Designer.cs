namespace RougeLike.Classes.Presentation
{
    partial class WinScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dead = new System.Windows.Forms.Label();
            this.restartGame = new System.Windows.Forms.Button();
            this.endGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Font = new System.Drawing.Font("InputMono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 378);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("InputMono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(524, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 247);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // dead
            // 
            this.dead.AutoSize = true;
            this.dead.BackColor = System.Drawing.Color.SeaGreen;
            this.dead.Font = new System.Drawing.Font("InputMono", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dead.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.dead.Location = new System.Drawing.Point(19, 472);
            this.dead.Name = "dead";
            this.dead.Size = new System.Drawing.Size(795, 96);
            this.dead.TabIndex = 3;
            this.dead.Text = "YOU WON\r\nbut something creeps closer....";
            this.dead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restartGame
            // 
            this.restartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.restartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartGame.Font = new System.Drawing.Font("InputMono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartGame.ForeColor = System.Drawing.Color.Gold;
            this.restartGame.Location = new System.Drawing.Point(53, 598);
            this.restartGame.Name = "restartGame";
            this.restartGame.Size = new System.Drawing.Size(133, 41);
            this.restartGame.TabIndex = 6;
            this.restartGame.Text = "Restart";
            this.restartGame.UseVisualStyleBackColor = false;
            this.restartGame.Click += new System.EventHandler(this.restartGame_Click);
            // 
            // endGame
            // 
            this.endGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.endGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endGame.Font = new System.Drawing.Font("InputMono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGame.ForeColor = System.Drawing.Color.Salmon;
            this.endGame.Location = new System.Drawing.Point(636, 598);
            this.endGame.Name = "endGame";
            this.endGame.Size = new System.Drawing.Size(133, 41);
            this.endGame.TabIndex = 7;
            this.endGame.Text = "End Game";
            this.endGame.UseVisualStyleBackColor = false;
            this.endGame.Click += new System.EventHandler(this.endGame_Click);
            // 
            // WinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(826, 689);
            this.Controls.Add(this.endGame);
            this.Controls.Add(this.restartGame);
            this.Controls.Add(this.dead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WinScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinScreen";
            this.Load += new System.EventHandler(this.WinScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dead;
        private System.Windows.Forms.Button restartGame;
        private System.Windows.Forms.Button endGame;
    }
}