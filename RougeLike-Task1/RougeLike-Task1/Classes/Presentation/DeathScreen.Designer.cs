namespace RougeLike_Task1.Classes.Presentation
{
    partial class DeathScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeathScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.Skull = new System.Windows.Forms.Label();
            this.dead = new System.Windows.Forms.Label();
            this.endGame = new System.Windows.Forms.Button();
            this.restartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Skull
            // 
            this.Skull.AutoSize = true;
            this.Skull.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Skull.Font = new System.Drawing.Font("InputMono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skull.ForeColor = System.Drawing.Color.Red;
            this.Skull.Location = new System.Drawing.Point(132, 54);
            this.Skull.Name = "Skull";
            this.Skull.Size = new System.Drawing.Size(540, 462);
            this.Skull.TabIndex = 1;
            this.Skull.Text = resources.GetString("Skull.Text");
            // 
            // dead
            // 
            this.dead.AutoSize = true;
            this.dead.Font = new System.Drawing.Font("InputMono", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dead.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.dead.Location = new System.Drawing.Point(261, 552);
            this.dead.Name = "dead";
            this.dead.Size = new System.Drawing.Size(273, 58);
            this.dead.TabIndex = 2;
            this.dead.Text = "YOU DIED";
            this.dead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endGame
            // 
            this.endGame.BackColor = System.Drawing.SystemColors.GrayText;
            this.endGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endGame.Font = new System.Drawing.Font("InputMono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGame.ForeColor = System.Drawing.Color.White;
            this.endGame.Location = new System.Drawing.Point(539, 634);
            this.endGame.Name = "endGame";
            this.endGame.Size = new System.Drawing.Size(133, 41);
            this.endGame.TabIndex = 4;
            this.endGame.Text = "End Game";
            this.endGame.UseVisualStyleBackColor = false;
            this.endGame.Click += new System.EventHandler(this.endGame_Click);
            // 
            // restartGame
            // 
            this.restartGame.BackColor = System.Drawing.SystemColors.GrayText;
            this.restartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartGame.Font = new System.Drawing.Font("InputMono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartGame.ForeColor = System.Drawing.Color.Lime;
            this.restartGame.Location = new System.Drawing.Point(132, 634);
            this.restartGame.Name = "restartGame";
            this.restartGame.Size = new System.Drawing.Size(133, 41);
            this.restartGame.TabIndex = 5;
            this.restartGame.Text = "Restart";
            this.restartGame.UseVisualStyleBackColor = false;
            this.restartGame.Click += new System.EventHandler(this.restartGame_Click);
            // 
            // DeathScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(861, 749);
            this.Controls.Add(this.restartGame);
            this.Controls.Add(this.endGame);
            this.Controls.Add(this.dead);
            this.Controls.Add(this.Skull);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeathScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeathScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeathScreen_FormClosed);
            this.Load += new System.EventHandler(this.DeathScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Skull;
        private System.Windows.Forms.Label dead;
        private System.Windows.Forms.Button endGame;
        private System.Windows.Forms.Button restartGame;
    }
}