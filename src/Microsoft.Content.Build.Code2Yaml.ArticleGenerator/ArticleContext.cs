﻿namespace Microsoft.Content.Build.Code2Yaml.ArticleGenerator
{
    using Microsoft.Content.Build.Code2Yaml.Common;
    using Microsoft.Content.Build.Code2Yaml.Constants;
    using Microsoft.Content.Build.Code2Yaml.DataContracts;

    public class ArticleContext
    {
        private readonly BuildContext _context;

        public ArticleContext(BuildContext context)
        {
            _context = context;
        }

        public BuildContext Context
        {
            get
            {
                return _context;
            }
        }

        public ConfigModel Config
        {
            get
            {
                return (ConfigModel)Context.GetSharedObject(Constants.Config);
            }
        }

        public HierarchyChange CurrentChange
        {
            get
            {
                return (HierarchyChange)Context.GetSharedObject(Constants.CurrentChange);
            }
        }

        public HierarchyChange ParentChange
        {
            get
            {
                return (HierarchyChange)Context.GetSharedObject(Constants.ParentChange);
            }
        }
    }
}
