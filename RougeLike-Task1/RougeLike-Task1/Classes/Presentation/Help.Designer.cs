
namespace RougeLike_Task1.Classes
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.helpBoxMap = new System.Windows.Forms.GroupBox();
            this.helpLabel = new System.Windows.Forms.Label();
            this.charHelpBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.helpBoxMap.SuspendLayout();
            this.charHelpBox.SuspendLayout();
            this.Info.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpBoxMap
            // 
            this.helpBoxMap.AutoSize = true;
            this.helpBoxMap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpBoxMap.Controls.Add(this.helpLabel);
            this.helpBoxMap.Location = new System.Drawing.Point(775, 160);
            this.helpBoxMap.Name = "helpBoxMap";
            this.helpBoxMap.Size = new System.Drawing.Size(209, 164);
            this.helpBoxMap.TabIndex = 4;
            this.helpBoxMap.TabStop = false;
            this.helpBoxMap.Text = "Map";
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.helpLabel.Location = new System.Drawing.Point(6, 16);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(197, 132);
            this.helpLabel.TabIndex = 0;
            this.helpLabel.Text = "Map format:\r\n[rows, collums]\r\n\r\nstarts at 0 from:\r\n• left to right\r\n• above to be" +
    "low";
            // 
            // charHelpBox
            // 
            this.charHelpBox.AutoSize = true;
            this.charHelpBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.charHelpBox.Controls.Add(this.label1);
            this.charHelpBox.Location = new System.Drawing.Point(12, 12);
            this.charHelpBox.Name = "charHelpBox";
            this.charHelpBox.Size = new System.Drawing.Size(561, 494);
            this.charHelpBox.TabIndex = 5;
            this.charHelpBox.TabStop = false;
            this.charHelpBox.Text = "Characters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 462);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.back.Location = new System.Drawing.Point(393, 513);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(257, 40);
            this.back.TabIndex = 6;
            this.back.Text = "Back to the game!";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Info.Controls.Add(this.label2);
            this.Info.Location = new System.Drawing.Point(775, 12);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(253, 142);
            this.Info.TabIndex = 5;
            this.Info.TabStop = false;
            this.Info.Text = "Goals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 110);
            this.label2.TabIndex = 0;
            this.label2.Text = "• stay alive\r\n• kill enemies\r\n• pickup gold\r\n• buy kickass weapons\r\n• win the gam" +
    "e!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(702, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 164);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menus and Selection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 110);
            this.label3.TabIndex = 0;
            this.label3.Text = "•Pick up weapons and gold\r\nfrom the item list\r\n\r\n•Choose and attack enemies\r\nfrom" +
    " the enemy list";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 565);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.back);
            this.Controls.Add(this.charHelpBox);
            this.Controls.Add(this.helpBoxMap);
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.Help_Load);
            this.helpBoxMap.ResumeLayout(false);
            this.helpBoxMap.PerformLayout();
            this.charHelpBox.ResumeLayout(false);
            this.charHelpBox.PerformLayout();
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox helpBoxMap;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.GroupBox charHelpBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.GroupBox Info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}