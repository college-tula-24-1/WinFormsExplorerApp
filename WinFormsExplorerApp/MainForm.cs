namespace WinFormsExplorerApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CreateMenuItems();
            CreateToolStripButtons();


            FillDrives();

        }

        void FillDrives()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    TreeNode driveNode = new TreeNode() { Text = drive.Name };
                    FillDirectoryNode(driveNode, drive.Name);
                    treeViewDirectories.Nodes.Add(driveNode);
                }
            }
        }

        void FillDirectoryNode(TreeNode parentNode, string path)
        {
            try
            {
                string[] directories = Directory.GetDirectories(path);
                foreach (string directory in directories)
                {
                    TreeNode directoryNode = new TreeNode();
                    directoryNode.Text = directory.Substring(directory.LastIndexOf(@"\") + 1);
                    directoryNode.ImageIndex = 0;
                    parentNode.Nodes.Add(directoryNode);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FillDirectoryList(string path)
        {
            listViewExplorer.Items.Clear();

            string[] directories = Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                ListViewItem directoryItem = new();
                directoryItem.Text = new DirectoryInfo(directory).Name;
                directoryItem.ImageIndex = 0;
                listViewExplorer.Items.Add(directoryItem);
            }

            string[] files = Directory.GetFiles(path);
            foreach(string file in files)
            {
                ListViewItem fileItem = new();
                fileItem.Text = new FileInfo(file).Name;
                fileItem.ImageIndex = 1;
                listViewExplorer.Items.Add(fileItem);
            }
        }

        void CreateMenuItems()
        {
            ToolStripMenuItem viewStripMenuItem = new("View");

            ToolStripMenuItem listStripMenuItem = new("List");
            listStripMenuItem.ShortcutKeys = Keys.Alt | Keys.L;
            viewStripMenuItem.DropDownItems.Add(listStripMenuItem);

            ToolStripMenuItem detailStripMenuItem = new("Detail");
            listStripMenuItem.ShortcutKeys = Keys.Alt | Keys.D;
            viewStripMenuItem.DropDownItems.Add(detailStripMenuItem);

            ToolStripMenuItem smallIconStripMenuItem = new("Small Icon");
            listStripMenuItem.ShortcutKeys = Keys.Alt | Keys.S;
            viewStripMenuItem.DropDownItems.Add(smallIconStripMenuItem);

            ToolStripMenuItem largeIconStripMenuItem = new("Large Icon");
            listStripMenuItem.ShortcutKeys = Keys.Alt | Keys.B;
            viewStripMenuItem.DropDownItems.Add(largeIconStripMenuItem);

            menuStripMain.Items.Add(viewStripMenuItem);
        }

        void CreateToolStripButtons()
        {
            ToolStripButton listToolStripButton = new ToolStripButton();
            listToolStripButton.Text = "List";
            toolStripMain.Items.Add(listToolStripButton);
        }

        private void treeViewDirectories_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node?.Nodes.Clear();

            try
            {
                if (Directory.Exists(e.Node?.FullPath))
                {
                    string[] directories = Directory.GetDirectories(e.Node.FullPath);
                    foreach (string directory in directories)
                    {
                        TreeNode directoryNode = new TreeNode(new DirectoryInfo(directory).Name);
                        FillDirectoryNode(directoryNode, directory);
                        e.Node.Nodes.Add(directoryNode);
                    }
                    FillDirectoryList(e.Node.FullPath);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
