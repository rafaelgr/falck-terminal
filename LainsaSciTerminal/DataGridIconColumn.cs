using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using LainsaTerminalLib;

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
            TRevision tr = CntSciTerminal.pLtr[rowNum];
            if (tr.HayIncidencia)
            {
                this.ColumnIcon = Icons.icoInci;
            }
            else
            {
                switch (tr.Estado)
                {
                    case "PROGRAMADA":
                        this.ColumnIcon = Icons.icoProg;
                        break;
                    case "PLANIFICADA":
                        this.ColumnIcon = Icons.icoPlan;
                        break;
                    case "REALIZADA":
                        this.ColumnIcon = Icons.icoReal;
                        break;

                }
            }
            // Draw the appropriate icon
            if (this.ColumnIcon != null)
            {
                g.DrawIcon(this.ColumnIcon, bounds.X, bounds.Y);
            }
        }
    }
}
