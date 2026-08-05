using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using MDD4All.UI.DataModels.Tree;

namespace MDD4All.UI.Breadcrumb
{
    public partial class BreadcrumbView : ComponentBase
    {
        #region Constructors
        public BreadcrumbView()
        {
        }
        #endregion

        #region Properties
        [Parameter]
        public List<ITreeNode>? Path { get; set; }

        [Parameter]
        public Func<ITreeNode, string>? TitleSelector { get; set; }
        #endregion

        #region Protected Methods
        protected List<ITreeNode> GetSafePath()
        {
            List<ITreeNode> result = new List<ITreeNode>();

            if (this.Path != null)
            {
                result = this.Path;
            }

            return result;
        }

        protected string GetTitle(ITreeNode node)
        {
            return TitleSelector != null ? TitleSelector(node) : node.ToString() ?? string.Empty;
        }
        #endregion
    }
}