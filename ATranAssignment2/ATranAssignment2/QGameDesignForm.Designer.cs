namespace ATranAssignment2
{
    partial class QGameDesignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QGameDesignForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblToolBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.imgLstToolBox = new System.Windows.Forms.ImageList(this.components);
            this.pnlMainBoard = new System.Windows.Forms.Panel();
            this.btnChick = new System.Windows.Forms.Button();
            this.btnBunny = new System.Windows.Forms.Button();
            this.btnCDoor = new System.Windows.Forms.Button();
            this.btnBDoor = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 30);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(157, 34);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // lblBottom
            // 
            this.lblBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBottom.Location = new System.Drawing.Point(0, 106);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(871, 2);
            this.lblBottom.TabIndex = 1;
            // 
            // lblToolBox
            // 
            this.lblToolBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblToolBox.Location = new System.Drawing.Point(0, 106);
            this.lblToolBox.Name = "lblToolBox";
            this.lblToolBox.Size = new System.Drawing.Size(218, 501);
            this.lblToolBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "ToolBox";
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(102, 62);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(76, 26);
            this.txtRow.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Rows:";
            // 
            // txtColumn
            // 
            this.txtColumn.Location = new System.Drawing.Point(305, 62);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(76, 26);
            this.txtColumn.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Columns:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(410, 41);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(98, 54);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(0, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(868, 2);
            this.label5.TabIndex = 1;
            // 
            // imgLstToolBox
            // 
            this.imgLstToolBox.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstToolBox.ImageStream")));
            this.imgLstToolBox.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstToolBox.Images.SetKeyName(0, "none.jpg");
            this.imgLstToolBox.Images.SetKeyName(1, "wall.png");
            this.imgLstToolBox.Images.SetKeyName(2, "BunnyDoor.png");
            this.imgLstToolBox.Images.SetKeyName(3, "ChickDoor.png");
            this.imgLstToolBox.Images.SetKeyName(4, "BunnyBox.png");
            this.imgLstToolBox.Images.SetKeyName(5, "ChickBox.png");
            // 
            // pnlMainBoard
            // 
            this.pnlMainBoard.AutoSize = true;
            this.pnlMainBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMainBoard.Location = new System.Drawing.Point(225, 112);
            this.pnlMainBoard.Name = "pnlMainBoard";
            this.pnlMainBoard.Size = new System.Drawing.Size(0, 0);
            this.pnlMainBoard.TabIndex = 13;
            // 
            // btnChick
            // 
            this.btnChick.BackColor = System.Drawing.Color.White;
            this.btnChick.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChick.ImageIndex = 5;
            this.btnChick.ImageList = this.imgLstToolBox;
            this.btnChick.Location = new System.Drawing.Point(15, 515);
            this.btnChick.Name = "btnChick";
            this.btnChick.Size = new System.Drawing.Size(140, 70);
            this.btnChick.TabIndex = 12;
            this.btnChick.Text = "Chick";
            this.btnChick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChick.UseVisualStyleBackColor = false;
            // 
            // btnBunny
            // 
            this.btnBunny.BackColor = System.Drawing.Color.White;
            this.btnBunny.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBunny.ImageIndex = 4;
            this.btnBunny.ImageList = this.imgLstToolBox;
            this.btnBunny.Location = new System.Drawing.Point(15, 443);
            this.btnBunny.Name = "btnBunny";
            this.btnBunny.Size = new System.Drawing.Size(140, 70);
            this.btnBunny.TabIndex = 11;
            this.btnBunny.Text = "Bunny";
            this.btnBunny.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBunny.UseVisualStyleBackColor = false;
            // 
            // btnCDoor
            // 
            this.btnCDoor.BackColor = System.Drawing.Color.White;
            this.btnCDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCDoor.ImageIndex = 3;
            this.btnCDoor.ImageList = this.imgLstToolBox;
            this.btnCDoor.Location = new System.Drawing.Point(15, 371);
            this.btnCDoor.Name = "btnCDoor";
            this.btnCDoor.Size = new System.Drawing.Size(140, 70);
            this.btnCDoor.TabIndex = 10;
            this.btnCDoor.Text = "C Door";
            this.btnCDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCDoor.UseVisualStyleBackColor = false;
            // 
            // btnBDoor
            // 
            this.btnBDoor.BackColor = System.Drawing.Color.White;
            this.btnBDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBDoor.ImageIndex = 2;
            this.btnBDoor.ImageList = this.imgLstToolBox;
            this.btnBDoor.Location = new System.Drawing.Point(15, 299);
            this.btnBDoor.Name = "btnBDoor";
            this.btnBDoor.Size = new System.Drawing.Size(140, 70);
            this.btnBDoor.TabIndex = 9;
            this.btnBDoor.Text = "B Door";
            this.btnBDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBDoor.UseVisualStyleBackColor = false;
            // 
            // btnWall
            // 
            this.btnWall.BackColor = System.Drawing.Color.White;
            this.btnWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWall.ImageIndex = 1;
            this.btnWall.ImageList = this.imgLstToolBox;
            this.btnWall.Location = new System.Drawing.Point(15, 227);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(140, 70);
            this.btnWall.TabIndex = 8;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.UseVisualStyleBackColor = false;
            // 
            // btnNone
            // 
            this.btnNone.BackColor = System.Drawing.Color.White;
            this.btnNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNone.ImageIndex = 0;
            this.btnNone.ImageList = this.imgLstToolBox;
            this.btnNone.Location = new System.Drawing.Point(15, 155);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(140, 70);
            this.btnNone.TabIndex = 7;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.UseVisualStyleBackColor = false;
            // 
            // QGameDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(854, 884);
            this.Controls.Add(this.pnlMainBoard);
            this.Controls.Add(this.btnChick);
            this.Controls.Add(this.btnBunny);
            this.Controls.Add(this.btnCDoor);
            this.Controls.Add(this.btnBDoor);
            this.Controls.Add(this.btnWall);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtColumn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToolBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBottom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QGameDesignForm";
            this.Text = "QGameDesign";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.Label lblToolBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnBDoor;
        private System.Windows.Forms.Button btnCDoor;
        private System.Windows.Forms.Button btnBunny;
        private System.Windows.Forms.Button btnChick;
        public System.Windows.Forms.ImageList imgLstToolBox;
        private System.Windows.Forms.Panel pnlMainBoard;
    }
}