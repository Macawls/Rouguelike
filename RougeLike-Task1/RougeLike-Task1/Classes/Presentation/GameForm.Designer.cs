
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
            this.components = new System.ComponentModel.Container();
            this.GameMap = new System.Windows.Forms.RichTextBox();
            this.keypressLabel = new System.Windows.Forms.Label();
            this.testMap = new System.Windows.Forms.Label();
            this.testMapHeader = new System.Windows.Forms.Label();
            this.controlsLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameMap
            // 
            this.GameMap.Enabled = false;
            this.GameMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameMap.Location = new System.Drawing.Point(12, 12);
            this.GameMap.Name = "GameMap";
            this.GameMap.Size = new System.Drawing.Size(254, 229);
            this.GameMap.TabIndex = 0;
            this.GameMap.Text = "This is the game map that will be used to hold chars";
            this.GameMap.TextChanged += new System.EventHandler(this.GameMap_TextChanged);
            // 
            // keypressLabel
            // 
            this.keypressLabel.AutoSize = true;
            this.keypressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keypressLabel.Location = new System.Drawing.Point(12, 371);
            this.keypressLabel.Name = "keypressLabel";
            this.keypressLabel.Size = new System.Drawing.Size(280, 37);
            this.keypressLabel.TabIndex = 1;
            this.keypressLabel.Text = "Keypress Indicator";
            this.keypressLabel.Click += new System.EventHandler(this.KeyPress_Click);
            // 
            // testMap
            // 
            this.testMap.AutoSize = true;
            this.testMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testMap.Location = new System.Drawing.Point(536, 109);
            this.testMap.Name = "testMap";
            this.testMap.Size = new System.Drawing.Size(0, 33);
            this.testMap.TabIndex = 2;
            // 
            // testMapHeader
            // 
            this.testMapHeader.AutoSize = true;
            this.testMapHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testMapHeader.Location = new System.Drawing.Point(467, 39);
            this.testMapHeader.Name = "testMapHeader";
            this.testMapHeader.Size = new System.Drawing.Size(257, 25);
            this.testMapHeader.TabIndex = 3;
            this.testMapHeader.Text = "Movement Testing Map";
            // 
            // controlsLabel
            // 
            this.controlsLabel.AutoSize = true;
            this.controlsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsLabel.Location = new System.Drawing.Point(16, 263);
            this.controlsLabel.Name = "controlsLabel";
            this.controlsLabel.Size = new System.Drawing.Size(69, 90);
            this.controlsLabel.TabIndex = 4;
            this.controlsLabel.Text = "Controls:\r\nW: up\r\nA:  left\r\nS:  down\r\nD:  right";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // sick
            // 
            this.sick.AutoSize = true;
            this.sick.Location = new System.Drawing.Point(422, 294);
            this.sick.Name = "sick";
            this.sick.Size = new System.Drawing.Size(43, 13);
            this.sick.TabIndex = 6;
            this.sick.Text = "asdmsd";
            this.sick.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 456);
            this.Controls.Add(this.sick);
            this.Controls.Add(this.controlsLabel);
            this.Controls.Add(this.testMapHeader);
            this.Controls.Add(this.testMap);
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
        private System.Windows.Forms.Label testMap;
        private System.Windows.Forms.Label testMapHeader;
        private System.Windows.Forms.Label controlsLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label sick;
    }
}

