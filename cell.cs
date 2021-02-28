using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace conway2
{
    public class Cell : Label
    {
        public Cell(int x, int y)
        {
            Location = new System.Drawing.Point(
                Variables.panelOffset + x * Variables.width,
                Variables.panelOffset + y * Variables.width
                );
            Size = new System.Drawing.Size(Variables.width, Variables.width);
            BackColor = Variables.deadColor;
            ForeColor = System.Drawing.Color.White;
            TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
