
namespace RougeLike_Task1
{
    partial class Game
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
            this.map = new System.Windows.Forms.Label();
            this.MapBox = new System.Windows.Forms.GroupBox();
            this.PlayerBox = new System.Windows.Forms.GroupBox();
            this.playerStats = new System.Windows.Forms.Label();
            this.movementControlsBox = new System.Windows.Forms.GroupBox();
            this.moveControls = new System.Windows.Forms.Label();
            this.enemyDropdown = new System.Windows.Forms.ComboBox();
            this.enemyListBox = new System.Windows.Forms.GroupBox();
            this.enemySelected = new System.Windows.Forms.Label();
            this.enemySelectedBox = new System.Windows.Forms.GroupBox();
            this.attackControlsBox = new System.Windows.Forms.GroupBox();
            this.attackControls = new System.Windows.Forms.Label();
            this.attackStateBox = new System.Windows.Forms.GroupBox();
            this.attackState = new System.Windows.Forms.Label();
            this.helpBox = new System.Windows.Forms.GroupBox();
            this.helpLabel = new System.Windows.Forms.Label();
            this.MapBox.SuspendLayout();
            this.PlayerBox.SuspendLayout();
            this.movementControlsBox.SuspendLayout();
            this.enemyListBox.SuspendLayout();
            this.enemySelectedBox.SuspendLayout();
            this.attackControlsBox.SuspendLayout();
            this.attackStateBox.SuspendLayout();
            this.helpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.AutoSize = true;
            this.map.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.map.Location = new System.Drawing.Point(6, 16);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(87, 22);
            this.map.TabIndex = 0;
            this.map.Text = "GameMap";
            // 
            // MapBox
            // 
            this.MapBox.AutoSize = true;
            this.MapBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MapBox.BackColor = System.Drawing.SystemColors.Menu;
            this.MapBox.Controls.Add(this.map);
            this.MapBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MapBox.Location = new System.Drawing.Point(388, 12);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(99, 54);
            this.MapBox.TabIndex = 1;
            this.MapBox.TabStop = false;
            this.MapBox.Text = "Map";
            // 
            // PlayerBox
            // 
            this.PlayerBox.AutoSize = true;
            this.PlayerBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlayerBox.Controls.Add(this.playerStats);
            this.PlayerBox.Location = new System.Drawing.Point(13, 12);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(77, 54);
            this.PlayerBox.TabIndex = 2;
            this.PlayerBox.TabStop = false;
            this.PlayerBox.Text = "Player";
            // 
            // playerStats
            // 
            this.playerStats.AutoSize = true;
            this.playerStats.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.playerStats.Location = new System.Drawing.Point(6, 16);
            this.playerStats.Name = "playerStats";
            this.playerStats.Size = new System.Drawing.Size(65, 22);
            this.playerStats.TabIndex = 0;
            this.playerStats.Text = "Stats";
            // 
            // movementControlsBox
            // 
            this.movementControlsBox.Controls.Add(this.moveControls);
            this.movementControlsBox.Location = new System.Drawing.Point(13, 300);
            this.movementControlsBox.Name = "movementControlsBox";
            this.movementControlsBox.Size = new System.Drawing.Size(139, 128);
            this.movementControlsBox.TabIndex = 3;
            this.movementControlsBox.TabStop = false;
            this.movementControlsBox.Text = "Movement Controls";
            // 
            // moveControls
            // 
            this.moveControls.AutoSize = true;
            this.moveControls.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.moveControls.Location = new System.Drawing.Point(10, 20);
            this.moveControls.Name = "moveControls";
            this.moveControls.Size = new System.Drawing.Size(109, 88);
            this.moveControls.TabIndex = 0;
            this.moveControls.Text = "Up:     W\r\nDown:   S\r\nLeft:   A\r\nRight:  D\r\n";
            // 
            // enemyDropdown
            // 
            this.enemyDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enemyDropdown.Items.AddRange(new object[] {
            "bob ",
            "jack",
            "jill"});
            this.enemyDropdown.Location = new System.Drawing.Point(6, 19);
            this.enemyDropdown.MaxDropDownItems = 20;
            this.enemyDropdown.Name = "enemyDropdown";
            this.enemyDropdown.Size = new System.Drawing.Size(121, 21);
            this.enemyDropdown.TabIndex = 4;
            this.enemyDropdown.TabStop = false;
            this.enemyDropdown.SelectedIndexChanged += new System.EventHandler(this.enemyDropdown_SelectedIndexChanged);
            this.enemyDropdown.SelectionChangeCommitted += new System.EventHandler(this.enemyDropdown_SelectionChangeCommitted);
            // 
            // enemyListBox
            // 
            this.enemyListBox.AutoSize = true;
            this.enemyListBox.Controls.Add(this.enemyDropdown);
            this.enemyListBox.Location = new System.Drawing.Point(676, 141);
            this.enemyListBox.Name = "enemyListBox";
            this.enemyListBox.Size = new System.Drawing.Size(133, 59);
            this.enemyListBox.TabIndex = 5;
            this.enemyListBox.TabStop = false;
            this.enemyListBox.Text = "List of Enemies";
            // 
            // enemySelected
            // 
            this.enemySelected.AutoSize = true;
            this.enemySelected.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.enemySelected.Location = new System.Drawing.Point(6, 16);
            this.enemySelected.Name = "enemySelected";
            this.enemySelected.Size = new System.Drawing.Size(54, 22);
            this.enemySelected.TabIndex = 6;
            this.enemySelected.Text = "none";
            // 
            // enemySelectedBox
            // 
            this.enemySelectedBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enemySelectedBox.Controls.Add(this.enemySelected);
            this.enemySelectedBox.Location = new System.Drawing.Point(676, 206);
            this.enemySelectedBox.Name = "enemySelectedBox";
            this.enemySelectedBox.Size = new System.Drawing.Size(340, 74);
            this.enemySelectedBox.TabIndex = 7;
            this.enemySelectedBox.TabStop = false;
            this.enemySelectedBox.Text = "Enemy Selected:";
            // 
            // attackControlsBox
            // 
            this.attackControlsBox.Controls.Add(this.attackControls);
            this.attackControlsBox.Location = new System.Drawing.Point(676, 12);
            this.attackControlsBox.Name = "attackControlsBox";
            this.attackControlsBox.Size = new System.Drawing.Size(340, 123);
            this.attackControlsBox.TabIndex = 4;
            this.attackControlsBox.TabStop = false;
            this.attackControlsBox.Text = "Attack Controls";
            // 
            // attackControls
            // 
            this.attackControls.AutoSize = true;
            this.attackControls.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.attackControls.Location = new System.Drawing.Point(10, 20);
            this.attackControls.Name = "attackControls";
            this.attackControls.Size = new System.Drawing.Size(296, 88);
            this.attackControls.TabIndex = 0;
            this.attackControls.Text = "Open selection: J\r\nNavigate:       Arrow Keys\r\nSelect enemy:   Enter\r\nAttack:    " +
    "     F";
            // 
            // attackStateBox
            // 
            this.attackStateBox.Controls.Add(this.attackState);
            this.attackStateBox.Location = new System.Drawing.Point(676, 286);
            this.attackStateBox.Name = "attackStateBox";
            this.attackStateBox.Size = new System.Drawing.Size(491, 124);
            this.attackStateBox.TabIndex = 8;
            this.attackStateBox.TabStop = false;
            this.attackStateBox.Text = "Attack State";
            // 
            // attackState
            // 
            this.attackState.AutoSize = true;
            this.attackState.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.attackState.Location = new System.Drawing.Point(7, 20);
            this.attackState.Name = "attackState";
            this.attackState.Size = new System.Drawing.Size(186, 22);
            this.attackState.TabIndex = 0;
            this.attackState.Text = "Attack an enemy!";
            // 
            // helpBox
            // 
            this.helpBox.AutoSize = true;
            this.helpBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpBox.Controls.Add(this.helpLabel);
            this.helpBox.Location = new System.Drawing.Point(13, 182);
            this.helpBox.Name = "helpBox";
            this.helpBox.Size = new System.Drawing.Size(220, 98);
            this.helpBox.TabIndex = 3;
            this.helpBox.TabStop = false;
            this.helpBox.Text = "Help";
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.helpLabel.Location = new System.Drawing.Point(6, 16);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(208, 66);
            this.helpLabel.TabIndex = 0;
            this.helpLabel.Text = "[rows, collums]\r\nrows = horizontal\r\ncollums = vertical\r\n";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1179, 440);
            this.Controls.Add(this.helpBox);
            this.Controls.Add(this.attackStateBox);
            this.Controls.Add(this.attackControlsBox);
            this.Controls.Add(this.enemySelectedBox);
            this.Controls.Add(this.enemyListBox);
            this.Controls.Add(this.movementControlsBox);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.MapBox);
            this.Name = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
            this.MapBox.ResumeLayout(false);
            this.MapBox.PerformLayout();
            this.PlayerBox.ResumeLayout(false);
            this.PlayerBox.PerformLayout();
            this.movementControlsBox.ResumeLayout(false);
            this.movementControlsBox.PerformLayout();
            this.enemyListBox.ResumeLayout(false);
            this.enemySelectedBox.ResumeLayout(false);
            this.enemySelectedBox.PerformLayout();
            this.attackControlsBox.ResumeLayout(false);
            this.attackControlsBox.PerformLayout();
            this.attackStateBox.ResumeLayout(false);
            this.attackStateBox.PerformLayout();
            this.helpBox.ResumeLayout(false);
            this.helpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label map;
        private System.Windows.Forms.GroupBox MapBox;
        private System.Windows.Forms.GroupBox PlayerBox;
        private System.Windows.Forms.Label playerStats;
        private System.Windows.Forms.GroupBox movementControlsBox;
        private System.Windows.Forms.Label moveControls;
        private System.Windows.Forms.ComboBox enemyDropdown;
        private System.Windows.Forms.GroupBox enemyListBox;
        private System.Windows.Forms.Label enemySelected;
        private System.Windows.Forms.GroupBox enemySelectedBox;
        private System.Windows.Forms.GroupBox attackControlsBox;
        private System.Windows.Forms.Label attackControls;
        private System.Windows.Forms.GroupBox attackStateBox;
        private System.Windows.Forms.Label attackState;
        private System.Windows.Forms.GroupBox helpBox;
        private System.Windows.Forms.Label helpLabel;
    }
}