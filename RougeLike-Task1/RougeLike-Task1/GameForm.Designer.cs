
namespace RougeLike_Task1
{
    partial class GameForm
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
            this.GameMap = new System.Windows.Forms.RichTextBox();
            this.keypressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameMap
            // 
            this.GameMap.Enabled = false;
            this.GameMap.Location = new System.Drawing.Point(12, 12);
            this.GameMap.Name = "GameMap";
            this.GameMap.Size = new System.Drawing.Size(348, 429);
            this.GameMap.TabIndex = 0;
            this.GameMap.Text = "This is the game map to hold ascii chars";
            this.GameMap.TextChanged += new System.EventHandler(this.GameMap_TextChanged);
            // 
            // keypressLabel
            // 
            this.keypressLabel.AutoSize = true;
            this.keypressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keypressLabel.Location = new System.Drawing.Point(444, 404);
            this.keypressLabel.Name = "keypressLabel";
            this.keypressLabel.Size = new System.Drawing.Size(280, 37);
            this.keypressLabel.TabIndex = 1;
            this.keypressLabel.Text = "Keypress Indicator";
            this.keypressLabel.Click += new System.EventHandler(this.KeyPress_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.keypressLabel);
            this.Controls.Add(this.GameMap);
            this.Name = "GameForm";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GameKeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox GameMap;
        private System.Windows.Forms.Label keypressLabel;
    }
}

