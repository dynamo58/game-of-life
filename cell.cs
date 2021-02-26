using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conway2
{
    class cell : Label
    {
        public cell(int x, int y)
        {
            Location = new System.Drawing.Point(x, y);
            Size = new System.Drawing.Size(Variables.width, Variables.width);
            BackColor = System.Drawing.Color.Green;
        }
    }
}
