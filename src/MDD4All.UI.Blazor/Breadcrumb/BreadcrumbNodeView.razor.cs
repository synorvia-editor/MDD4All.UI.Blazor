using Microsoft.AspNetCore.Components;
using MDD4All.UI.DataModels.Tree;

namespace MDD4All.UI.Breadcrumb
{
    public partial class BreadcrumbNodeView : ComponentBase
    {
        public BreadcrumbNodeView() { }

        [Parameter]
        public ITreeNode TreeNode { get; set; } = null!;

        [Parameter]
        public string Title { get; set; } = "";

        [Parameter]
        public bool IsLast { get; set; }

        private void OnSelectNode()
        {
            if (this.TreeNode != null && this.TreeNode.Tree != null)
            {
                this.TreeNode.Tree.SelectedNode = this.TreeNode;
            }
        }
    }
}