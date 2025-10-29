using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Bai07
{
    public partial class TraversalFolderForm : Form
    {
        public TraversalFolderForm()
        {
            InitializeComponent();
            LoadRootFolders();
            tvFolder.AfterSelect += tvFolder_AfterSelect;
        }

        private void LoadRootFolders()
        {
            tvFolder.Nodes.Clear();

            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode driveNode = new TreeNode(drive.Name);
                driveNode.Tag = drive.RootDirectory.FullName;
                driveNode.Nodes.Add("...");
                tvFolder.Nodes.Add(driveNode);
            }

            tvFolder.BeforeExpand += tvFolder_BeforeExpand;
        }

        private void LoadFilesRecursive(TreeNode parentNode, string path)
        {
            try
            {
                var allowedExtensions = new[] { ".jpg", ".jpeg", ".png"};

                foreach (var file in Directory.GetFiles(path)
                    .Where(f => allowedExtensions.Contains(Path.GetExtension(f).ToLower())))
                {
                    parentNode.Nodes.Add(new TreeNode(Path.GetFileName(file))
                    {
                        Tag = file
                    });
                }

                foreach (var dir in Directory.GetDirectories(path))
                {
                    var dirNode = new TreeNode(Path.GetFileName(dir));
                    parentNode.Nodes.Add(dirNode);
                    LoadFilesRecursive(dirNode, dir);
                }
            }
            catch {  }
        }

        private void tvFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string filePath = e.Node.Tag as string;
            if (filePath == null || !File.Exists(filePath)) return;

            string ext = Path.GetExtension(filePath).ToLower();
            rtBoxShowTxt.Clear();
            rtBoxShowTxt.ReadOnly = true;

            foreach (Control ctrl in splitContainer1.Panel2.Controls.OfType<PictureBox>().ToArray())
                splitContainer1.Panel2.Controls.Remove(ctrl);

            if (ext == ".txt")
            {
                rtBoxShowTxt.Visible = true;
                rtBoxShowTxt.Text = File.ReadAllText(filePath);
            }
            else if (ext == ".jpg" || ext == ".jpeg" || ext == ".png")
            {
                var pic = new PictureBox
                {
                    Image = Image.FromFile(filePath),
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                splitContainer1.Panel2.Controls.Add(pic);
                pic.BringToFront();
                rtBoxShowTxt.Visible = false;
            }
            else
            {
                rtBoxShowTxt.Visible = true;
                rtBoxShowTxt.Text = "Không thể hiển thị định dạng file này.";
            }
        }

        private void tvFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();

            try
            {
                string path = node.Tag.ToString();

                foreach (var dir in Directory.GetDirectories(path))
                {
                    TreeNode subNode = new TreeNode(Path.GetFileName(dir));
                    subNode.Tag = dir;
                    subNode.Nodes.Add("...");
                    node.Nodes.Add(subNode);
                }

                foreach (var file in Directory.GetFiles(path))
                {
                    TreeNode fileNode = new TreeNode(Path.GetFileName(file));
                    fileNode.Tag = file;
                    node.Nodes.Add(fileNode);
                }
            }
            catch { }
        }
    }
}