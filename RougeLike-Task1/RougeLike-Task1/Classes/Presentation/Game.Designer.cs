
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
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
            this.msg = new System.Windows.Forms.Label();
            this.Box = new System.Windows.Forms.GroupBox();
            this.itemListBox = new System.Windows.Forms.GroupBox();
            this.itemDropdown = new System.Windows.Forms.ComboBox();
            this.musicCheckBox = new System.Windows.Forms.CheckBox();
            this.bugLabel = new System.Windows.Forms.Label();
            this.tutorial = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ItemBox = new System.Windows.Forms.GroupBox();
            this.itemSelected = new System.Windows.Forms.Label();
            this.MapBox.SuspendLayout();
            this.PlayerBox.SuspendLayout();
            this.movementControlsBox.SuspendLayout();
            this.enemyListBox.SuspendLayout();
            this.enemySelectedBox.SuspendLayout();
            this.attackControlsBox.SuspendLayout();
            this.attackStateBox.SuspendLayout();
            this.Box.SuspendLayout();
            this.itemListBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ItemBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.AutoSize = true;
            this.map.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.map.Location = new System.Drawing.Point(6, 16);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(110, 27);
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
            this.MapBox.Location = new System.Drawing.Point(492, 19);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(122, 59);
            this.MapBox.TabIndex = 1;
            this.MapBox.TabStop = false;
            this.MapBox.Text = "Map";
            // 
            // PlayerBox
            // 
            this.PlayerBox.AutoSize = true;
            this.PlayerBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlayerBox.Controls.Add(this.playerStats);
            this.PlayerBox.Location = new System.Drawing.Point(6, 19);
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
            this.movementControlsBox.Location = new System.Drawing.Point(958, 19);
            this.movementControlsBox.Name = "movementControlsBox";
            this.movementControlsBox.Size = new System.Drawing.Size(243, 186);
            this.movementControlsBox.TabIndex = 3;
            this.movementControlsBox.TabStop = false;
            this.movementControlsBox.Text = "Player Controls";
            // 
            // moveControls
            // 
            this.moveControls.AutoSize = true;
            this.moveControls.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.moveControls.Location = new System.Drawing.Point(10, 20);
            this.moveControls.Name = "moveControls";
            this.moveControls.Size = new System.Drawing.Size(197, 154);
            this.moveControls.TabIndex = 0;
            this.moveControls.Text = "Item selection: I\r\nPickup:         P\r\n\r\nUp:     W\r\nDown:   S\r\nLeft:   A\r\nRight:  " +
    "D";
            this.moveControls.Click += new System.EventHandler(this.moveControls_Click);
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
            this.enemyDropdown.SelectionChangeCommitted += new System.EventHandler(this.enemyDropdown_SelectionChangeCommitted);
            // 
            // enemyListBox
            // 
            this.enemyListBox.AutoSize = true;
            this.enemyListBox.Controls.Add(this.enemyDropdown);
            this.enemyListBox.Location = new System.Drawing.Point(6, 317);
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
            this.enemySelectedBox.Location = new System.Drawing.Point(958, 416);
            this.enemySelectedBox.Name = "enemySelectedBox";
            this.enemySelectedBox.Size = new System.Drawing.Size(340, 74);
            this.enemySelectedBox.TabIndex = 7;
            this.enemySelectedBox.TabStop = false;
            this.enemySelectedBox.Text = "Enemy Selected:";
            // 
            // attackControlsBox
            // 
            this.attackControlsBox.Controls.Add(this.attackControls);
            this.attackControlsBox.Location = new System.Drawing.Point(958, 211);
            this.attackControlsBox.Name = "attackControlsBox";
            this.attackControlsBox.Size = new System.Drawing.Size(340, 117);
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
            this.attackControls.Size = new System.Drawing.Size(307, 88);
            this.attackControls.TabIndex = 0;
            this.attackControls.Text = "Enemy selection: J\r\nNavigate:        Arrow Keys\r\nSelect enemy:    Enter\r\nAttack: " +
    "         F\r\n";
            this.attackControls.Click += new System.EventHandler(this.attackControls_Click);
            // 
            // attackStateBox
            // 
            this.attackStateBox.Controls.Add(this.msg);
            this.attackStateBox.Location = new System.Drawing.Point(6, 382);
            this.attackStateBox.Name = "attackStateBox";
            this.attackStateBox.Size = new System.Drawing.Size(436, 124);
            this.attackStateBox.TabIndex = 8;
            this.attackStateBox.TabStop = false;
            this.attackStateBox.Text = "MessageBox";
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.msg.Location = new System.Drawing.Point(7, 20);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(406, 88);
            this.msg.TabIndex = 0;
            this.msg.Text = "Attack an enemy or pickup something!\r\n\r\nRemember to select something\r\nfirst!";
            // 
            // Box
            // 
            this.Box.Controls.Add(this.ItemBox);
            this.Box.Controls.Add(this.enemySelectedBox);
            this.Box.Controls.Add(this.itemListBox);
            this.Box.Controls.Add(this.attackControlsBox);
            this.Box.Controls.Add(this.attackStateBox);
            this.Box.Controls.Add(this.enemyListBox);
            this.Box.Controls.Add(this.PlayerBox);
            this.Box.Controls.Add(this.movementControlsBox);
            this.Box.Controls.Add(this.MapBox);
            this.Box.Location = new System.Drawing.Point(12, 95);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(1308, 515);
            this.Box.TabIndex = 9;
            this.Box.TabStop = false;
            // 
            // itemListBox
            // 
            this.itemListBox.AutoSize = true;
            this.itemListBox.Controls.Add(this.itemDropdown);
            this.itemListBox.Location = new System.Drawing.Point(6, 252);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(133, 59);
            this.itemListBox.TabIndex = 6;
            this.itemListBox.TabStop = false;
            this.itemListBox.Text = "List of Items";
            // 
            // itemDropdown
            // 
            this.itemDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemDropdown.Items.AddRange(new object[] {
            "bob ",
            "jack",
            "jill"});
            this.itemDropdown.Location = new System.Drawing.Point(6, 19);
            this.itemDropdown.MaxDropDownItems = 20;
            this.itemDropdown.Name = "itemDropdown";
            this.itemDropdown.Size = new System.Drawing.Size(121, 21);
            this.itemDropdown.TabIndex = 4;
            this.itemDropdown.TabStop = false;
            this.itemDropdown.SelectionChangeCommitted += new System.EventHandler(this.itemDropdown_SelectionChangeCommitted);
            // 
            // musicCheckBox
            // 
            this.musicCheckBox.AutoSize = true;
            this.musicCheckBox.Location = new System.Drawing.Point(16, 616);
            this.musicCheckBox.Name = "musicCheckBox";
            this.musicCheckBox.Size = new System.Drawing.Size(88, 17);
            this.musicCheckBox.TabIndex = 11;
            this.musicCheckBox.Text = "Stop Music? ";
            this.musicCheckBox.UseVisualStyleBackColor = true;
            this.musicCheckBox.CheckedChanged += new System.EventHandler(this.musicCheckBox_CheckedChanged);
            // 
            // bugLabel
            // 
            this.bugLabel.AutoSize = true;
            this.bugLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugLabel.Location = new System.Drawing.Point(703, 616);
            this.bugLabel.Name = "bugLabel";
            this.bugLabel.Size = new System.Drawing.Size(628, 80);
            this.bugLabel.TabIndex = 11;
            this.bugLabel.Text = resources.GetString("bugLabel.Text");
            // 
            // tutorial
            // 
            this.tutorial.AutoSize = true;
            this.tutorial.Location = new System.Drawing.Point(110, 616);
            this.tutorial.Name = "tutorial";
            this.tutorial.Size = new System.Drawing.Size(89, 17);
            this.tutorial.TabIndex = 12;
            this.tutorial.Text = "How to Play?";
            this.tutorial.UseVisualStyleBackColor = true;
            this.tutorial.CheckedChanged += new System.EventHandler(this.tutorial_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::RougeLike_Task1.Properties.Resources.game;
            this.pictureBox1.Location = new System.Drawing.Point(317, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 77);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ItemBox
            // 
            this.ItemBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ItemBox.Controls.Add(this.itemSelected);
            this.ItemBox.Location = new System.Drawing.Point(958, 336);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(340, 74);
            this.ItemBox.TabIndex = 8;
            this.ItemBox.TabStop = false;
            this.ItemBox.Text = "Item Selected:";
            // 
            // itemSelected
            // 
            this.itemSelected.AutoSize = true;
            this.itemSelected.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.itemSelected.Location = new System.Drawing.Point(6, 16);
            this.itemSelected.Name = "itemSelected";
            this.itemSelected.Size = new System.Drawing.Size(54, 22);
            this.itemSelected.TabIndex = 6;
            this.itemSelected.Text = "none";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1339, 710);
            this.Controls.Add(this.musicCheckBox);
            this.Controls.Add(this.tutorial);
            this.Controls.Add(this.bugLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Box);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.Box.ResumeLayout(false);
            this.Box.PerformLayout();
            this.itemListBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ItemBox.ResumeLayout(false);
            this.ItemBox.PerformLayout();
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
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox musicCheckBox;
        private System.Windows.Forms.Label bugLabel;
        private System.Windows.Forms.CheckBox tutorial;
        private System.Windows.Forms.GroupBox itemListBox;
        private System.Windows.Forms.ComboBox itemDropdown;
        private System.Windows.Forms.GroupBox ItemBox;
        private System.Windows.Forms.Label itemSelected;
    }
}