﻿using System.Windows.Forms;

namespace GenClassesFromDatabase.Controls.Nodes
{
    public class FolderNode : TreeNode
    {
        public FolderNode(string name, int count) : base($"{name} ({count})")
        {
            ImageKey = "folder";
            SelectedImageKey = "folder";
        }
    }
}
