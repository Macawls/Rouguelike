using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RogueLike
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
            this.AttackMsg = new System.Windows.Forms.Label();
            this.ItemMsg = new System.Windows.Forms.Label();
            this.Box = new System.Windows.Forms.GroupBox();
            this.ItemBox = new System.Windows.Forms.GroupBox();
            this.itemSelected = new System.Windows.Forms.Label();
            this.itemListBox = new System.Windows.Forms.GroupBox();
            this.itemDropdown = new System.Windows.Forms.ComboBox();
            this.musicCheckBox = new System.Windows.Forms.CheckBox();
            this.bugLabel = new System.Windows.Forms.Label();
            this.tutorial = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.ShopBox = new System.Windows.Forms.GroupBox();
            this.itemThreeButton = new System.Windows.Forms.Button();
            this.itemTwoButton = new System.Windows.Forms.Button();
            this.itemOneButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.youtubeLink = new System.Windows.Forms.LinkLabel();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MapBox.SuspendLayout();
            this.PlayerBox.SuspendLayout();
            this.movementControlsBox.SuspendLayout();
            this.enemyListBox.SuspendLayout();
            this.enemySelectedBox.SuspendLayout();
            this.attackControlsBox.SuspendLayout();
            this.attackStateBox.SuspendLayout();
            this.Box.SuspendLayout();
            this.ItemBox.SuspendLayout();
            this.itemListBox.SuspendLayout();
            this.ShopBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.AutoSize = true;
            this.map.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.map.Location = new System.Drawing.Point(6, 16);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(134, 33);
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
            this.MapBox.Size = new System.Drawing.Size(146, 65);
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
            this.movementControlsBox.Location = new System.Drawing.Point(906, 19);
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
            this.moveControls.Size = new System.Drawing.Size(153, 154);
            this.moveControls.TabIndex = 0;
            this.moveControls.Text = "Item list:  I\r\nPickup:     P\r\n\r\nUp:     W\r\nDown:   S\r\nLeft:   A\r\nRight:  D";
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
            this.enemyDropdown.Size = new System.Drawing.Size(227, 21);
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
            this.enemyListBox.Size = new System.Drawing.Size(242, 59);
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
            this.enemySelectedBox.Location = new System.Drawing.Point(906, 440);
            this.enemySelectedBox.Name = "enemySelectedBox";
            this.enemySelectedBox.Size = new System.Drawing.Size(340, 101);
            this.enemySelectedBox.TabIndex = 7;
            this.enemySelectedBox.TabStop = false;
            this.enemySelectedBox.Text = "Enemy Inspected:";
            // 
            // attackControlsBox
            // 
            this.attackControlsBox.Controls.Add(this.attackControls);
            this.attackControlsBox.Location = new System.Drawing.Point(906, 211);
            this.attackControlsBox.Name = "attackControlsBox";
            this.attackControlsBox.Size = new System.Drawing.Size(340, 117);
            this.attackControlsBox.TabIndex = 4;
            this.attackControlsBox.TabStop = false;
            this.attackControlsBox.Text = "Attacking";
            // 
            // attackControls
            // 
            this.attackControls.AutoSize = true;
            this.attackControls.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.attackControls.Location = new System.Drawing.Point(10, 20);
            this.attackControls.Name = "attackControls";
            this.attackControls.Size = new System.Drawing.Size(307, 88);
            this.attackControls.TabIndex = 0;
            this.attackControls.Text = "Enemy list:      J\r\nNavigate:        Arrow Keys\r\nInspect enemy:   Enter\r\nAttack: " +
    "         F\r\n";
            this.attackControls.Click += new System.EventHandler(this.attackControls_Click);
            // 
            // attackStateBox
            // 
            this.attackStateBox.Controls.Add(this.AttackMsg);
            this.attackStateBox.Controls.Add(this.ItemMsg);
            this.attackStateBox.Location = new System.Drawing.Point(6, 382);
            this.attackStateBox.Name = "attackStateBox";
            this.attackStateBox.Size = new System.Drawing.Size(460, 159);
            this.attackStateBox.TabIndex = 8;
            this.attackStateBox.TabStop = false;
            this.attackStateBox.Text = "MessageBox";
            // 
            // AttackMsg
            // 
            this.AttackMsg.AutoSize = true;
            this.AttackMsg.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.AttackMsg.Location = new System.Drawing.Point(6, 86);
            this.AttackMsg.Name = "AttackMsg";
            this.AttackMsg.Size = new System.Drawing.Size(76, 22);
            this.AttackMsg.TabIndex = 1;
            this.AttackMsg.Text = "attack";
            // 
            // ItemMsg
            // 
            this.ItemMsg.AutoSize = true;
            this.ItemMsg.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.ItemMsg.Location = new System.Drawing.Point(6, 34);
            this.ItemMsg.Name = "ItemMsg";
            this.ItemMsg.Size = new System.Drawing.Size(54, 22);
            this.ItemMsg.TabIndex = 0;
            this.ItemMsg.Text = "gold\r\n";
            this.ItemMsg.TextChanged += new System.EventHandler(this.msg_TextChanged);
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
            this.Box.Size = new System.Drawing.Size(1357, 557);
            this.Box.TabIndex = 9;
            this.Box.TabStop = false;
            // 
            // ItemBox
            // 
            this.ItemBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ItemBox.Controls.Add(this.itemSelected);
            this.ItemBox.Location = new System.Drawing.Point(906, 346);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(340, 74);
            this.ItemBox.TabIndex = 8;
            this.ItemBox.TabStop = false;
            this.ItemBox.Text = "Item Inspected:";
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
            // itemListBox
            // 
            this.itemListBox.AutoSize = true;
            this.itemListBox.Controls.Add(this.itemDropdown);
            this.itemListBox.Location = new System.Drawing.Point(6, 260);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(242, 59);
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
            this.itemDropdown.Size = new System.Drawing.Size(227, 21);
            this.itemDropdown.TabIndex = 4;
            this.itemDropdown.TabStop = false;
            this.itemDropdown.SelectionChangeCommitted += new System.EventHandler(this.itemDropdown_SelectionChangeCommitted);
            // 
            // musicCheckBox
            // 
            this.musicCheckBox.AutoSize = true;
            this.musicCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musicCheckBox.Location = new System.Drawing.Point(12, 658);
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
            this.bugLabel.Location = new System.Drawing.Point(756, 676);
            this.bugLabel.Name = "bugLabel";
            this.bugLabel.Size = new System.Drawing.Size(624, 128);
            this.bugLabel.TabIndex = 11;
            this.bugLabel.Text = resources.GetString("bugLabel.Text");
            this.bugLabel.Click += new System.EventHandler(this.bugLabel_Click);
            // 
            // tutorial
            // 
            this.tutorial.AutoSize = true;
            this.tutorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tutorial.Location = new System.Drawing.Point(106, 658);
            this.tutorial.Name = "tutorial";
            this.tutorial.Size = new System.Drawing.Size(89, 17);
            this.tutorial.TabIndex = 12;
            this.tutorial.Text = "How to Play?";
            this.tutorial.UseVisualStyleBackColor = true;
            this.tutorial.CheckedChanged += new System.EventHandler(this.tutorial_CheckedChanged);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(12, 732);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(183, 56);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ShopBox
            // 
            this.ShopBox.Controls.Add(this.itemThreeButton);
            this.ShopBox.Controls.Add(this.itemTwoButton);
            this.ShopBox.Controls.Add(this.itemOneButton);
            this.ShopBox.Location = new System.Drawing.Point(656, 12);
            this.ShopBox.Name = "ShopBox";
            this.ShopBox.Size = new System.Drawing.Size(713, 77);
            this.ShopBox.TabIndex = 15;
            this.ShopBox.TabStop = false;
            this.ShopBox.Text = "Shop";
            this.ShopBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // itemThreeButton
            // 
            this.itemThreeButton.Font = new System.Drawing.Font("Courier New", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.itemThreeButton.Location = new System.Drawing.Point(488, 20);
            this.itemThreeButton.Name = "itemThreeButton";
            this.itemThreeButton.Size = new System.Drawing.Size(219, 51);
            this.itemThreeButton.TabIndex = 2;
            this.itemThreeButton.Text = "Item3";
            this.itemThreeButton.UseVisualStyleBackColor = true;
            this.itemThreeButton.Click += new System.EventHandler(this.itemThreeButton_Click);
            // 
            // itemTwoButton
            // 
            this.itemTwoButton.Font = new System.Drawing.Font("Courier New", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.itemTwoButton.Location = new System.Drawing.Point(247, 20);
            this.itemTwoButton.Name = "itemTwoButton";
            this.itemTwoButton.Size = new System.Drawing.Size(235, 51);
            this.itemTwoButton.TabIndex = 1;
            this.itemTwoButton.Text = "Item2";
            this.itemTwoButton.UseVisualStyleBackColor = true;
            this.itemTwoButton.Click += new System.EventHandler(this.itemTwoButton_Click);
            // 
            // itemOneButton
            // 
            this.itemOneButton.Font = new System.Drawing.Font("Courier New", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemOneButton.Location = new System.Drawing.Point(6, 20);
            this.itemOneButton.Name = "itemOneButton";
            this.itemOneButton.Size = new System.Drawing.Size(235, 51);
            this.itemOneButton.TabIndex = 0;
            this.itemOneButton.Text = "Item1";
            this.itemOneButton.UseVisualStyleBackColor = true;
            this.itemOneButton.Click += new System.EventHandler(this.itemOneButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(287, 660);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 144);
            this.label1.TabIndex = 16;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // youtubeLink
            // 
            this.youtubeLink.ActiveLinkColor = System.Drawing.Color.SlateBlue;
            this.youtubeLink.AutoSize = true;
            this.youtubeLink.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youtubeLink.LinkColor = System.Drawing.Color.Red;
            this.youtubeLink.Location = new System.Drawing.Point(940, 811);
            this.youtubeLink.Name = "youtubeLink";
            this.youtubeLink.Size = new System.Drawing.Size(75, 27);
            this.youtubeLink.TabIndex = 17;
            this.youtubeLink.TabStop = true;
            this.youtubeLink.Text = "VIDEO";
            this.youtubeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.youtubeLink_LinkClicked);
            // 
            // githubLink
            // 
            this.githubLink.ActiveLinkColor = System.Drawing.Color.SlateBlue;
            this.githubLink.AutoSize = true;
            this.githubLink.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubLink.LinkColor = System.Drawing.Color.Black;
            this.githubLink.Location = new System.Drawing.Point(1270, 811);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(110, 25);
            this.githubLink.TabIndex = 19;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "My GitHub";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 77);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RougeLike_Task1.Properties.Resources.githubsmall;
            this.pictureBox2.Location = new System.Drawing.Point(1233, 811);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 36);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1392, 845);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.youtubeLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShopBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.musicCheckBox);
            this.Controls.Add(this.tutorial);
            this.Controls.Add(this.bugLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.ItemBox.ResumeLayout(false);
            this.ItemBox.PerformLayout();
            this.itemListBox.ResumeLayout(false);
            this.ShopBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label ItemMsg;
        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox musicCheckBox;
        private System.Windows.Forms.Label bugLabel;
        private System.Windows.Forms.CheckBox tutorial;
        private System.Windows.Forms.GroupBox itemListBox;
        private System.Windows.Forms.ComboBox itemDropdown;
        private System.Windows.Forms.GroupBox ItemBox;
        private System.Windows.Forms.Label itemSelected;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label AttackMsg;
        private System.Windows.Forms.GroupBox ShopBox;
        public System.Windows.Forms.Button itemThreeButton;
        public System.Windows.Forms.Button itemTwoButton;
        public System.Windows.Forms.Button itemOneButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel youtubeLink;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}