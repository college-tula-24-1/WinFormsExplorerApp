namespace WinFormsExplorerApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStripMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStripMain = new ToolStrip();
            createToolStripButton = new ToolStripButton();
            statusStripMain = new StatusStrip();
            infoStripStatusLabel = new ToolStripStatusLabel();
            splitContainerContent = new SplitContainer();
            treeViewDirectories = new TreeView();
            imageListIcons16 = new ImageList(components);
            listViewExplorer = new ListView();
            imageListIcons64 = new ImageList(components);
            menuStripMain.SuspendLayout();
            toolStripMain.SuspendLayout();
            statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerContent).BeginInit();
            splitContainerContent.Panel1.SuspendLayout();
            splitContainerContent.Panel2.SuspendLayout();
            splitContainerContent.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(940, 24);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem, deleteToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            createToolStripMenuItem.Size = new Size(150, 22);
            createToolStripMenuItem.Text = "Create";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            deleteToolStripMenuItem.Size = new Size(150, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(147, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(150, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStripMain
            // 
            toolStripMain.Items.AddRange(new ToolStripItem[] { createToolStripButton });
            toolStripMain.Location = new Point(0, 24);
            toolStripMain.Name = "toolStripMain";
            toolStripMain.Size = new Size(940, 25);
            toolStripMain.TabIndex = 1;
            toolStripMain.Text = "toolStrip1";
            // 
            // createToolStripButton
            // 
            createToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            createToolStripButton.Image = (Image)resources.GetObject("createToolStripButton.Image");
            createToolStripButton.ImageTransparentColor = Color.Magenta;
            createToolStripButton.Name = "createToolStripButton";
            createToolStripButton.Size = new Size(23, 22);
            createToolStripButton.Text = "toolStripButton1";
            // 
            // statusStripMain
            // 
            statusStripMain.Items.AddRange(new ToolStripItem[] { infoStripStatusLabel });
            statusStripMain.Location = new Point(0, 555);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(940, 22);
            statusStripMain.TabIndex = 2;
            statusStripMain.Text = "statusStrip1";
            // 
            // infoStripStatusLabel
            // 
            infoStripStatusLabel.Name = "infoStripStatusLabel";
            infoStripStatusLabel.Size = new Size(118, 17);
            infoStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // splitContainerContent
            // 
            splitContainerContent.BorderStyle = BorderStyle.FixedSingle;
            splitContainerContent.Dock = DockStyle.Fill;
            splitContainerContent.Location = new Point(0, 49);
            splitContainerContent.Name = "splitContainerContent";
            // 
            // splitContainerContent.Panel1
            // 
            splitContainerContent.Panel1.Controls.Add(treeViewDirectories);
            // 
            // splitContainerContent.Panel2
            // 
            splitContainerContent.Panel2.Controls.Add(listViewExplorer);
            splitContainerContent.Size = new Size(940, 506);
            splitContainerContent.SplitterDistance = 313;
            splitContainerContent.TabIndex = 3;
            // 
            // treeViewDirectories
            // 
            treeViewDirectories.Dock = DockStyle.Fill;
            treeViewDirectories.ImageIndex = 0;
            treeViewDirectories.ImageList = imageListIcons16;
            treeViewDirectories.Location = new Point(0, 0);
            treeViewDirectories.Name = "treeViewDirectories";
            treeViewDirectories.SelectedImageIndex = 0;
            treeViewDirectories.Size = new Size(311, 504);
            treeViewDirectories.TabIndex = 0;
            treeViewDirectories.BeforeExpand += treeViewDirectories_BeforeExpand;
            treeViewDirectories.BeforeSelect += treeViewDirectories_BeforeExpand;
            // 
            // imageListIcons16
            // 
            imageListIcons16.ColorDepth = ColorDepth.Depth32Bit;
            imageListIcons16.ImageStream = (ImageListStreamer)resources.GetObject("imageListIcons16.ImageStream");
            imageListIcons16.TransparentColor = Color.Transparent;
            imageListIcons16.Images.SetKeyName(0, "FOLDER.png");
            imageListIcons16.Images.SetKeyName(1, "ANY.png");
            imageListIcons16.Images.SetKeyName(2, "CPP.png");
            imageListIcons16.Images.SetKeyName(3, "CS.png");
            imageListIcons16.Images.SetKeyName(4, "CSS.png");
            imageListIcons16.Images.SetKeyName(5, "EXCEL.png");
            imageListIcons16.Images.SetKeyName(6, "HTML.png");
            imageListIcons16.Images.SetKeyName(7, "JPG.png");
            imageListIcons16.Images.SetKeyName(8, "JS.png");
            imageListIcons16.Images.SetKeyName(9, "PDF.png");
            imageListIcons16.Images.SetKeyName(10, "PNG.png");
            imageListIcons16.Images.SetKeyName(11, "POWER POINT.png");
            imageListIcons16.Images.SetKeyName(12, "TXT.png");
            imageListIcons16.Images.SetKeyName(13, "WORD.png");
            // 
            // listViewExplorer
            // 
            listViewExplorer.Dock = DockStyle.Fill;
            listViewExplorer.LargeImageList = imageListIcons64;
            listViewExplorer.Location = new Point(0, 0);
            listViewExplorer.Name = "listViewExplorer";
            listViewExplorer.Size = new Size(621, 504);
            listViewExplorer.SmallImageList = imageListIcons16;
            listViewExplorer.TabIndex = 0;
            listViewExplorer.UseCompatibleStateImageBehavior = false;
            // 
            // imageListIcons64
            // 
            imageListIcons64.ColorDepth = ColorDepth.Depth32Bit;
            imageListIcons64.ImageStream = (ImageListStreamer)resources.GetObject("imageListIcons64.ImageStream");
            imageListIcons64.TransparentColor = Color.Transparent;
            imageListIcons64.Images.SetKeyName(0, "FOLDER.png");
            imageListIcons64.Images.SetKeyName(1, "ANY.png");
            imageListIcons64.Images.SetKeyName(2, "CPP.png");
            imageListIcons64.Images.SetKeyName(3, "CS.png");
            imageListIcons64.Images.SetKeyName(4, "CSS.png");
            imageListIcons64.Images.SetKeyName(5, "EXCEL.png");
            imageListIcons64.Images.SetKeyName(6, "HTML.png");
            imageListIcons64.Images.SetKeyName(7, "JPG.png");
            imageListIcons64.Images.SetKeyName(8, "JS.png");
            imageListIcons64.Images.SetKeyName(9, "PDF.png");
            imageListIcons64.Images.SetKeyName(10, "PNG.png");
            imageListIcons64.Images.SetKeyName(11, "POWER POINT.png");
            imageListIcons64.Images.SetKeyName(12, "TXT.png");
            imageListIcons64.Images.SetKeyName(13, "WORD.png");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 577);
            Controls.Add(splitContainerContent);
            Controls.Add(statusStripMain);
            Controls.Add(toolStripMain);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            Name = "MainForm";
            Text = "Explorer";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            toolStripMain.ResumeLayout(false);
            toolStripMain.PerformLayout();
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            splitContainerContent.Panel1.ResumeLayout(false);
            splitContainerContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerContent).EndInit();
            splitContainerContent.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStrip toolStripMain;
        private ToolStripButton createToolStripButton;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel infoStripStatusLabel;
        private SplitContainer splitContainerContent;
        private TreeView treeViewDirectories;
        private ListView listViewExplorer;
        private ImageList imageListIcons64;
        private ImageList imageListIcons16;
    }
}
