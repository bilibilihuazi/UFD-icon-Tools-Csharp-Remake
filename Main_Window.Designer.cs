namespace U_U盘图标更换小工具_C_
{
    partial class Main_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Path_Title = new System.Windows.Forms.Label();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.button_Path_Browser = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox_IconPath = new System.Windows.Forms.TextBox();
            this.label_IconPath_Title = new System.Windows.Forms.Label();
            this.button_IconPath_Browser = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label_IconView = new System.Windows.Forms.Label();
            this.button_Set = new System.Windows.Forms.Button();
            this.pictureBox_IconView = new System.Windows.Forms.PictureBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于承ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IconView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(125, 31);
            this.label_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(252, 36);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "U盘图标更换小工具";
            // 
            // label_Path_Title
            // 
            this.label_Path_Title.AutoSize = true;
            this.label_Path_Title.Location = new System.Drawing.Point(12, 85);
            this.label_Path_Title.Name = "label_Path_Title";
            this.label_Path_Title.Size = new System.Drawing.Size(92, 17);
            this.label_Path_Title.TabIndex = 1;
            this.label_Path_Title.Text = "U盘根目录路径:";
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(110, 82);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.ReadOnly = true;
            this.textBox_Path.Size = new System.Drawing.Size(262, 23);
            this.textBox_Path.TabIndex = 2;
            // 
            // button_Path_Browser
            // 
            this.button_Path_Browser.Location = new System.Drawing.Point(378, 82);
            this.button_Path_Browser.Name = "button_Path_Browser";
            this.button_Path_Browser.Size = new System.Drawing.Size(75, 23);
            this.button_Path_Browser.TabIndex = 3;
            this.button_Path_Browser.Text = "浏览...";
            this.button_Path_Browser.UseVisualStyleBackColor = true;
            this.button_Path_Browser.Click += new System.EventHandler(this.button_Path_Browser_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "请选择U盘的根目录，也就是X:\\\\";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // textBox_IconPath
            // 
            this.textBox_IconPath.Location = new System.Drawing.Point(77, 111);
            this.textBox_IconPath.Name = "textBox_IconPath";
            this.textBox_IconPath.ReadOnly = true;
            this.textBox_IconPath.Size = new System.Drawing.Size(295, 23);
            this.textBox_IconPath.TabIndex = 5;
            // 
            // label_IconPath_Title
            // 
            this.label_IconPath_Title.AutoSize = true;
            this.label_IconPath_Title.Location = new System.Drawing.Point(12, 114);
            this.label_IconPath_Title.Name = "label_IconPath_Title";
            this.label_IconPath_Title.Size = new System.Drawing.Size(59, 17);
            this.label_IconPath_Title.TabIndex = 4;
            this.label_IconPath_Title.Text = "图标路径:";
            // 
            // button_IconPath_Browser
            // 
            this.button_IconPath_Browser.Location = new System.Drawing.Point(378, 111);
            this.button_IconPath_Browser.Name = "button_IconPath_Browser";
            this.button_IconPath_Browser.Size = new System.Drawing.Size(75, 23);
            this.button_IconPath_Browser.TabIndex = 6;
            this.button_IconPath_Browser.Text = "浏览...";
            this.button_IconPath_Browser.UseVisualStyleBackColor = true;
            this.button_IconPath_Browser.Click += new System.EventHandler(this.button_IconPath_Browser_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "图标文件|*.ico|所有文件|*.*";
            this.openFileDialog.Title = "打开一个图标";
            // 
            // label_IconView
            // 
            this.label_IconView.AutoSize = true;
            this.label_IconView.Location = new System.Drawing.Point(12, 149);
            this.label_IconView.Name = "label_IconView";
            this.label_IconView.Size = new System.Drawing.Size(59, 17);
            this.label_IconView.TabIndex = 8;
            this.label_IconView.Text = "图标预览:";
            // 
            // button_Set
            // 
            this.button_Set.Location = new System.Drawing.Point(346, 149);
            this.button_Set.Name = "button_Set";
            this.button_Set.Size = new System.Drawing.Size(107, 64);
            this.button_Set.TabIndex = 9;
            this.button_Set.Text = "更换";
            this.button_Set.UseVisualStyleBackColor = true;
            this.button_Set.Click += new System.EventHandler(this.button_Set_Click);
            // 
            // pictureBox_IconView
            // 
            this.pictureBox_IconView.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_IconView.ErrorImage")));
            this.pictureBox_IconView.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_IconView.Image")));
            this.pictureBox_IconView.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_IconView.InitialImage")));
            this.pictureBox_IconView.Location = new System.Drawing.Point(77, 149);
            this.pictureBox_IconView.Name = "pictureBox_IconView";
            this.pictureBox_IconView.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_IconView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_IconView.TabIndex = 11;
            this.pictureBox_IconView.TabStop = false;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(233, 149);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(107, 64);
            this.button_Reset.TabIndex = 12;
            this.button_Reset.Text = "还原";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于承ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.关于ToolStripMenuItem.Text = " 关于";
            // 
            // 关于承ToolStripMenuItem
            // 
            this.关于承ToolStripMenuItem.Name = "关于承ToolStripMenuItem";
            this.关于承ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.关于承ToolStripMenuItem.Text = "关于程序";
            this.关于承ToolStripMenuItem.Click += new System.EventHandler(this.关于程序ToolStripMenuItem_Click);
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 221);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.pictureBox_IconView);
            this.Controls.Add(this.button_Set);
            this.Controls.Add(this.label_IconView);
            this.Controls.Add(this.button_IconPath_Browser);
            this.Controls.Add(this.textBox_IconPath);
            this.Controls.Add(this.label_IconPath_Title);
            this.Controls.Add(this.button_Path_Browser);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.label_Path_Title);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(481, 260);
            this.MinimumSize = new System.Drawing.Size(481, 260);
            this.Name = "Main_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "U盘图标更换小工具";
            this.Load += new System.EventHandler(this.Main_Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IconView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Path_Title;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Button button_Path_Browser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox textBox_IconPath;
        private System.Windows.Forms.Label label_IconPath_Title;
        private System.Windows.Forms.Button button_IconPath_Browser;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label_IconView;
        private System.Windows.Forms.Button button_Set;
        private System.Windows.Forms.PictureBox pictureBox_IconView;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于承ToolStripMenuItem;
    }
}