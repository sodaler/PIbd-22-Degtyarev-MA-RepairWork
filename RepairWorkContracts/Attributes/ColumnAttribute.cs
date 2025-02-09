﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace RepairWorkContracts.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute : Attribute
    {
        public ColumnAttribute(string title = "", bool visible = true, int width = 0,
            GridViewAutoSize gridViewAutoSize = GridViewAutoSize.None)
        {
            Title = title;
            Visible = visible;
            Width = width;
            GridViewAutoSize = gridViewAutoSize;
        }
        public string Title { get; private set; }
        public bool Visible { get; private set; }
        public int Width { get; private set; }
        public GridViewAutoSize GridViewAutoSize { get; private set; }
    }
}
