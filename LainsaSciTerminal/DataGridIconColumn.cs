using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace LainsaSciTerminal
{
    public class DataGridIconColumn : DataGridColumnStyle
    {
        public Icon ColumnIcon
        {
            get;
            set;
        }

        protected override void Paint(Graphics g, Rectangle bounds, CurrencyManager source, int rowNum, Brush backBrush, Brush foreBrush, bool alignToRight)
        {

            // Fill in background color
            g.FillRectangle(backBrush, bounds);

            // Draw the appropriate icon
            if (this.ColumnIcon != null)
            {
                g.DrawIcon(this.ColumnIcon, bounds.X, bounds.Y);
            }
        }
    }
}
