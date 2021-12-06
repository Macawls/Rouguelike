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
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.itemListBox = new System.Windows.Forms.GroupBox();
            this.itemDropdown = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tutorial = new System.Windows.Forms.CheckBox();
            this.musicCheckBox = new System.Windows.Forms.CheckBox();
            this.bugLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.ShopBox = new System.Windows.Forms.GroupBox();
            this.itemThreeButton = new System.Windows.Forms.Button();
            this.itemTwoButton = new System.Windows.Forms.Button();
            this.itemOneButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.youtubeLink = new System.Windows.Forms.LinkLabel();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.PlayerBox.SuspendLayout();
            this.movementControlsBox.SuspendLayout();
            this.enemyListBox.SuspendLayout();
            this.enemySelectedBox.SuspendLayout();
            this.attackControlsBox.SuspendLayout();
            this.attackStateBox.SuspendLayout();
            this.Box.SuspendLayout();
            this.ItemBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.itemListBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ShopBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.AutoSize = true;
            this.map.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(153)))), ((int)(((byte)(132)))));
            this.map.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.map.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.map.Location = new System.Drawing.Point(454, 35);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(134, 33);
            this.map.TabIndex = 0;
            this.map.Text = "GameMap";
            // 
            // PlayerBox
            // 
            this.PlayerBox.AutoSize = true;
            this.PlayerBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlayerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PlayerBox.Controls.Add(this.playerStats);
            this.PlayerBox.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.PlayerBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.PlayerBox.Location = new System.Drawing.Point(75, 230);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(71, 82);
            this.PlayerBox.TabIndex = 2;
            this.PlayerBox.TabStop = false;
            this.PlayerBox.Text = "Player";
            // 
            // playerStats
            // 
            this.playerStats.AutoSize = true;
            this.playerStats.Font = new System.Drawing.Font("InputMono", 12F, System.Drawing.FontStyle.Bold);
            this.playerStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.playerStats.Location = new System.Drawing.Point(6, 38);
            this.playerStats.Name = "playerStats";
            this.playerStats.Size = new System.Drawing.Size(59, 19);
            this.playerStats.TabIndex = 0;
            this.playerStats.Text = "Stats";
            // 
            // movementControlsBox
            // 
            this.movementControlsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.movementControlsBox.Controls.Add(this.moveControls);
            this.movementControlsBox.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.movementControlsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(187)))), ((int)(((byte)(38)))));
            this.movementControlsBox.Location = new System.Drawing.Point(75, 19);
            this.movementControlsBox.Name = "movementControlsBox";
            this.movementControlsBox.Size = new System.Drawing.Size(189, 197);
            this.movementControlsBox.TabIndex = 3;
            this.movementControlsBox.TabStop = false;
            this.movementControlsBox.Text = "Player Controls";
            // 
            // moveControls
            // 
            this.moveControls.AutoSize = true;
            this.moveControls.Font = new System.Drawing.Font("InputMono", 12F, System.Drawing.FontStyle.Bold);
            this.moveControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.moveControls.Location = new System.Drawing.Point(6, 25);
            this.moveControls.Name = "moveControls";
            this.moveControls.Size = new System.Drawing.Size(139, 152);
            this.moveControls.TabIndex = 0;
            this.moveControls.Text = "Item list:  I\r\nEnemy List: J\r\nAttack: F\r\n\r\nUp:     W\r\nDown:   S\r\nLeft:   A\r\nRight" +
    ":  D";
            // 
            // enemyDropdown
            // 
            this.enemyDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.enemyDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enemyDropdown.Font = new System.Drawing.Font("InputMono", 12F, System.Drawing.FontStyle.Bold);
            this.enemyDropdown.ForeColor = System.Drawing.Color.Black;
            this.enemyDropdown.Items.AddRange(new object[] {
            "bob ",
            "jack",
            "jill"});
            this.enemyDropdown.Location = new System.Drawing.Point(6, 19);
            this.enemyDropdown.MaxDropDownItems = 20;
            this.enemyDropdown.Name = "enemyDropdown";
            this.enemyDropdown.Size = new System.Drawing.Size(402, 27);
            this.enemyDropdown.TabIndex = 4;
            this.enemyDropdown.TabStop = false;
            this.enemyDropdown.SelectionChangeCommitted += new System.EventHandler(this.enemyDropdown_SelectionChangeCommitted);
            // 
            // enemyListBox
            // 
            this.enemyListBox.AutoSize = true;
            this.enemyListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.enemyListBox.Controls.Add(this.enemyDropdown);
            this.enemyListBox.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.enemyListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(134)))), ((int)(((byte)(155)))));
            this.enemyListBox.Location = new System.Drawing.Point(896, 546);
            this.enemyListBox.Name = "enemyListBox";
            this.enemyListBox.Size = new System.Drawing.Size(414, 74);
            this.enemyListBox.TabIndex = 5;
            this.enemyListBox.TabStop = false;
            this.enemyListBox.Text = "List of Enemies";
            // 
            // enemySelected
            // 
            this.enemySelected.AutoSize = true;
            this.enemySelected.Font = new System.Drawing.Font("InputMono", 12F, System.Drawing.FontStyle.Bold);
            this.enemySelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.enemySelected.Location = new System.Drawing.Point(6, 25);
            this.enemySelected.Name = "enemySelected";
            this.enemySelected.Size = new System.Drawing.Size(49, 19);
            this.enemySelected.TabIndex = 6;
            this.enemySelected.Text = "none";
            // 
            // enemySelectedBox
            // 
            this.enemySelectedBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.enemySelectedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.enemySelectedBox.Controls.Add(this.enemySelected);
            this.enemySelectedBox.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.enemySelectedBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(134)))), ((int)(((byte)(155)))));
            this.enemySelectedBox.Location = new System.Drawing.Point(897, 311);
            this.enemySelectedBox.Name = "enemySelectedBox";
            this.enemySelectedBox.Size = new System.Drawing.Size(340, 101);
            this.enemySelectedBox.TabIndex = 7;
            this.enemySelectedBox.TabStop = false;
            this.enemySelectedBox.Text = "Enemy Inspected:";
            // 
            // attackControlsBox
            // 
            this.attackControlsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.attackControlsBox.Controls.Add(this.attackControls);
            this.attackControlsBox.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.attackControlsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(73)))), ((int)(((byte)(52)))));
            this.attackControlsBox.Location = new System.Drawing.Point(896, 207);
            this.attackControlsBox.Name = "attackControlsBox";
            this.attackControlsBox.Size = new System.Drawing.Size(258, 80);
            this.attackControlsBox.TabIndex = 4;
            this.attackControlsBox.TabStop = false;
            this.attackControlsBox.Text = "Menus";
            // 
            // attackControls
            // 
            this.attackControls.AutoSize = true;
            this.attackControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.attackControls.Font = new System.Drawing.Font("InputMono", 12F, System.Drawing.FontStyle.Bold);
            this.attackControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(174)))), ((int)(((byte)(147)))));
            this.attackControls.Location = new System.Drawing.Point(10, 25);
            this.attackControls.Name = "attackControls";
            this.attackControls.Size = new System.Drawing.Size(219, 38);
            this.attackControls.TabIndex = 0;
            this.attackControls.Text = "Navigate:  Arrow Keys\r\nInspect:   Enter\r\n";
            // 
            // attackStateBox
            // 
            this.attackStateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.attackStateBox.Controls.Add(this.AttackMsg);
            this.attackStateBox.Controls.Add(this.ItemMsg);
            this.attackStateBox.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.attackStateBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.attackStateBox.Location = new System.Drawing.Point(897, 37);
            this.attackStateBox.Name = "attackStateBox";
            this.attackStateBox.Size = new System.Drawing.Size(422, 159);
            this.attackStateBox.TabIndex = 8;
            this.attackStateBox.TabStop = false;
            this.attackStateBox.Text = "MessageBox";
            // 
            // AttackMsg
            // 
            this.AttackMsg.AutoSize = true;
            this.AttackMsg.Font = new System.Drawing.Font("InputMono", 12F, System.Drawing.FontStyle.Bold);
            this.AttackMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(73)))), ((int)(((byte)(52)))));
            this.AttackMsg.Location = new System.Drawing.Point(6, 86);
            this.AttackMsg.Name = "AttackMsg";
            this.AttackMsg.Size = new System.Drawing.Size(69, 19);
            this.AttackMsg.TabIndex = 1;
            this.AttackMsg.Text = "attack";
            // 
            // ItemMsg
            // 
            this.ItemMsg.AutoSize = true;
            this.ItemMsg.Font = new System.Drawing.Font("InputMono", 12F, System.Drawing.FontStyle.Bold);
            this.ItemMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(47)))));
            this.ItemMsg.Location = new System.Drawing.Point(6, 34);
            this.ItemMsg.Name = "ItemMsg";
            this.ItemMsg.Size = new System.Drawing.Size(49, 19);
            this.ItemMsg.TabIndex = 0;
            this.ItemMsg.Text = "gold\r\n";
            this.ItemMsg.TextChanged += new System.EventHandler(this.msg_TextChanged);
            // 
            // Box
            // 
            this.Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.Box.Controls.Add(this.map);
            this.Box.Controls.Add(this.ItemBox);
            this.Box.Controls.Add(this.pictureBox6);
            this.Box.Controls.Add(this.pictureBox3);
            this.Box.Controls.Add(this.pictureBox5);
            this.Box.Controls.Add(this.pictureBox4);
            this.Box.Controls.Add(this.enemySelectedBox);
            this.Box.Controls.Add(this.itemListBox);
            this.Box.Controls.Add(this.attackControlsBox);
            this.Box.Controls.Add(this.attackStateBox);
            this.Box.Controls.Add(this.enemyListBox);
            this.Box.Controls.Add(this.PlayerBox);
            this.Box.Controls.Add(this.movementControlsBox);
            this.Box.Controls.Add(this.panel1);
            this.Box.Location = new System.Drawing.Point(45, 79);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(1391, 645);
            this.Box.TabIndex = 9;
            this.Box.TabStop = false;
            // 
            // ItemBox
            // 
            this.ItemBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ItemBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ItemBox.Controls.Add(this.itemSelected);
            this.ItemBox.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.ItemBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(192)))), ((int)(((byte)(124)))));
            this.ItemBox.Location = new System.Drawing.Point(897, 433);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(340, 74);
            this.ItemBox.TabIndex = 8;
            this.ItemBox.TabStop = false;
            this.ItemBox.Text = "Item Inspected:";
            // 
            // itemSelected
            // 
            this.itemSelected.AutoSize = true;
            this.itemSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.itemSelected.Font = new System.Drawing.Font("InputMono", 12F, System.Drawing.FontStyle.Bold);
            this.itemSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.itemSelected.Location = new System.Drawing.Point(6, 25);
            this.itemSelected.Name = "itemSelected";
            this.itemSelected.Size = new System.Drawing.Size(49, 19);
            this.itemSelected.TabIndex = 6;
            this.itemSelected.Text = "none";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::RougeLike.Properties.Resources.torch;
            this.pictureBox6.Location = new System.Drawing.Point(1334, 541);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(51, 93);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RougeLike.Properties.Resources.torch;
            this.pictureBox3.Location = new System.Drawing.Point(1334, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::RougeLike.Properties.Resources.torch;
            this.pictureBox5.Location = new System.Drawing.Point(6, 19);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(51, 93);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::RougeLike.Properties.Resources.torch;
            this.pictureBox4.Location = new System.Drawing.Point(6, 546);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 93);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // itemListBox
            // 
            this.itemListBox.AutoSize = true;
            this.itemListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.itemListBox.Controls.Add(this.itemDropdown);
            this.itemListBox.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.itemListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(192)))), ((int)(((byte)(124)))));
            this.itemListBox.Location = new System.Drawing.Point(75, 483);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(242, 77);
            this.itemListBox.TabIndex = 6;
            this.itemListBox.TabStop = false;
            this.itemListBox.Text = "List of Items";
            // 
            // itemDropdown
            // 
            this.itemDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(131)))), ((int)(((byte)(116)))));
            this.itemDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemDropdown.Font = new System.Drawing.Font("InputMono", 12F, System.Drawing.FontStyle.Bold);
            this.itemDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(174)))), ((int)(((byte)(147)))));
            this.itemDropdown.Items.AddRange(new object[] {
            "bob ",
            "jack",
            "jill"});
            this.itemDropdown.Location = new System.Drawing.Point(6, 19);
            this.itemDropdown.MaxDropDownItems = 20;
            this.itemDropdown.Name = "itemDropdown";
            this.itemDropdown.Size = new System.Drawing.Size(227, 27);
            this.itemDropdown.TabIndex = 4;
            this.itemDropdown.TabStop = false;
            this.itemDropdown.SelectionChangeCommitted += new System.EventHandler(this.itemDropdown_SelectionChangeCommitted);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tutorial);
            this.panel1.Controls.Add(this.musicCheckBox);
            this.panel1.Location = new System.Drawing.Point(75, 566);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 68);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("InputMono", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.label2.Location = new System.Drawing.Point(127, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "(click the box)";
            // 
            // tutorial
            // 
            this.tutorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tutorial.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tutorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tutorial.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.tutorial.FlatAppearance.BorderSize = 50;
            this.tutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutorial.Font = new System.Drawing.Font("InputMono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(187)))), ((int)(((byte)(38)))));
            this.tutorial.Location = new System.Drawing.Point(3, 12);
            this.tutorial.Name = "tutorial";
            this.tutorial.Size = new System.Drawing.Size(197, 27);
            this.tutorial.TabIndex = 12;
            this.tutorial.Text = "How to Play? >";
            this.tutorial.UseVisualStyleBackColor = false;
            this.tutorial.CheckedChanged += new System.EventHandler(this.tutorial_CheckedChanged);
            // 
            // musicCheckBox
            // 
            this.musicCheckBox.AutoSize = true;
            this.musicCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.musicCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.musicCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musicCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicCheckBox.Font = new System.Drawing.Font("InputMono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(73)))), ((int)(((byte)(52)))));
            this.musicCheckBox.Location = new System.Drawing.Point(206, 12);
            this.musicCheckBox.Name = "musicCheckBox";
            this.musicCheckBox.Size = new System.Drawing.Size(182, 27);
            this.musicCheckBox.TabIndex = 11;
            this.musicCheckBox.Text = "Stop Music? >";
            this.musicCheckBox.UseVisualStyleBackColor = false;
            this.musicCheckBox.CheckedChanged += new System.EventHandler(this.musicCheckBox_CheckedChanged);
            // 
            // bugLabel
            // 
            this.bugLabel.AutoSize = true;
            this.bugLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.bugLabel.Font = new System.Drawing.Font("InputMono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.bugLabel.Location = new System.Drawing.Point(773, 728);
            this.bugLabel.Name = "bugLabel";
            this.bugLabel.Size = new System.Drawing.Size(663, 98);
            this.bugLabel.TabIndex = 11;
            this.bugLabel.Text = resources.GetString("bugLabel.Text");
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Black;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("InputMono", 20F, System.Drawing.FontStyle.Bold);
            this.saveButton.ForeColor = System.Drawing.Color.DimGray;
            this.saveButton.Location = new System.Drawing.Point(45, 730);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(229, 56);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ShopBox
            // 
            this.ShopBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShopBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.ShopBox.Controls.Add(this.itemThreeButton);
            this.ShopBox.Controls.Add(this.itemTwoButton);
            this.ShopBox.Controls.Add(this.itemOneButton);
            this.ShopBox.Font = new System.Drawing.Font("Courier New", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.ShopBox.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.ShopBox.Location = new System.Drawing.Point(723, 2);
            this.ShopBox.Name = "ShopBox";
            this.ShopBox.Size = new System.Drawing.Size(713, 84);
            this.ShopBox.TabIndex = 15;
            this.ShopBox.TabStop = false;
            this.ShopBox.Text = "SHOP";
            // 
            // itemThreeButton
            // 
            this.itemThreeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.itemThreeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemThreeButton.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemThreeButton.ForeColor = System.Drawing.Color.DimGray;
            this.itemThreeButton.Location = new System.Drawing.Point(488, 20);
            this.itemThreeButton.Name = "itemThreeButton";
            this.itemThreeButton.Size = new System.Drawing.Size(219, 51);
            this.itemThreeButton.TabIndex = 2;
            this.itemThreeButton.Text = "Item3";
            this.itemThreeButton.UseVisualStyleBackColor = false;
            this.itemThreeButton.Click += new System.EventHandler(this.itemThreeButton_Click);
            // 
            // itemTwoButton
            // 
            this.itemTwoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.itemTwoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemTwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemTwoButton.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTwoButton.ForeColor = System.Drawing.Color.DimGray;
            this.itemTwoButton.Location = new System.Drawing.Point(247, 20);
            this.itemTwoButton.Name = "itemTwoButton";
            this.itemTwoButton.Size = new System.Drawing.Size(235, 51);
            this.itemTwoButton.TabIndex = 1;
            this.itemTwoButton.Text = "Item2";
            this.itemTwoButton.UseVisualStyleBackColor = false;
            this.itemTwoButton.Click += new System.EventHandler(this.itemTwoButton_Click);
            // 
            // itemOneButton
            // 
            this.itemOneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.itemOneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemOneButton.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemOneButton.ForeColor = System.Drawing.Color.DimGray;
            this.itemOneButton.Location = new System.Drawing.Point(6, 20);
            this.itemOneButton.Name = "itemOneButton";
            this.itemOneButton.Size = new System.Drawing.Size(235, 51);
            this.itemOneButton.TabIndex = 0;
            this.itemOneButton.Text = "Item1";
            this.itemOneButton.UseVisualStyleBackColor = false;
            this.itemOneButton.Click += new System.EventHandler(this.itemOneButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.label1.Font = new System.Drawing.Font("InputMono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(280, 728);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 140);
            this.label1.TabIndex = 16;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // youtubeLink
            // 
            this.youtubeLink.ActiveLinkColor = System.Drawing.Color.SlateBlue;
            this.youtubeLink.AutoSize = true;
            this.youtubeLink.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youtubeLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.youtubeLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(73)))), ((int)(((byte)(52)))));
            this.youtubeLink.Location = new System.Drawing.Point(47, 10);
            this.youtubeLink.Name = "youtubeLink";
            this.youtubeLink.Size = new System.Drawing.Size(189, 27);
            this.youtubeLink.TabIndex = 17;
            this.youtubeLink.TabStop = true;
            this.youtubeLink.Text = "Video on youtube";
            this.youtubeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.youtubeLink_LinkClicked);
            // 
            // githubLink
            // 
            this.githubLink.ActiveLinkColor = System.Drawing.Color.SlateBlue;
            this.githubLink.AutoSize = true;
            this.githubLink.BackColor = System.Drawing.Color.Transparent;
            this.githubLink.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.githubLink.LinkColor = System.Drawing.Color.Orange;
            this.githubLink.Location = new System.Drawing.Point(279, 12);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(110, 25);
            this.githubLink.TabIndex = 19;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "My GitHub";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::RougeLike.Properties.Resources.githubwhite;
            this.pictureBox2.Location = new System.Drawing.Point(242, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 36);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(691, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.Black;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("InputMono", 20F, System.Drawing.FontStyle.Bold);
            this.loadButton.ForeColor = System.Drawing.Color.DimGray;
            this.loadButton.Location = new System.Drawing.Point(46, 806);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(228, 56);
            this.loadButton.TabIndex = 21;
            this.loadButton.Text = "LOAD";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.youtubeLink);
            this.panel2.Controls.Add(this.githubLink);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(1030, 829);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 49);
            this.panel2.TabIndex = 22;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::RougeLike.Properties.Resources.youtube_1_;
            this.pictureBox7.Location = new System.Drawing.Point(10, 10);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 36);
            this.pictureBox7.TabIndex = 21;
            this.pictureBox7.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(73)))), ((int)(((byte)(69)))));
            this.BackgroundImage = global::RougeLike.Properties.Resources._fixed;
            this.ClientSize = new System.Drawing.Size(1472, 874);
            this.Controls.Add(this.ShopBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.bugLabel);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.itemListBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ShopBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label map;
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
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}