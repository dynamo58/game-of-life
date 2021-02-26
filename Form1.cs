using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conway2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitialState();
        }

        private void InitialState()
        {
            int panelOffset = Variables.panelOffset;
            int width = Variables.width;
            int size = Variables.size;

            cell test = new cell(panelOffset + 0, panelOffset + 0);
            Controls.Add(test);

            for (int i = 1; i < size; i++)
            {
                cell test2 = new cell(panelOffset + i*width, panelOffset + i*width);
                Controls.Add(test2);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            int panelOffset = Variables.panelOffset;
            int panelSize = Variables.panelSize;

            Pen panelOutline = new Pen(Color.FromArgb(255, 255, 255, 0), 2);

            canvas.DrawRectangle(panelOutline, panelOffset -1, panelOffset - 1, panelSize + 2, panelSize + 2);
            canvas.FillRectangle(Brushes.Orange, panelOffset, panelOffset, panelSize, panelSize);
        }
    }

    public class Variables
    {
        public static int panelOffset = 100;            // odsazení panelu s buňkami od levého horního rohu
        public static int panelSize = 500;              // velikost panelu s buňkami
        public static int size = 10;                    // počet buněk v řádce/sloupci panelu s buňkami
        public static int width = panelSize / size;     // výpočet šířky jedné buňky
        static cell[] organism = new cell[size * size]; // array držící informace o všech buňkách
    }
}
