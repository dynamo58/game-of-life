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
            timer1.Tick += new EventHandler(newGenButton_Click);
        }

        private void InitialState()
        {
            int size = Variables.size;

            for (int y = 0; y < size; y++)
            {
                for (int z = 0; z < size; z++)
                {
                    Variables.organism[y, z] = new Cell(y, z);
                    Controls.Add(Variables.organism[y, z]);

                    Variables.organism[y, z].Click += new EventHandler(cell_Click);
                }
            }
        }

        private void cell_Click(object sender, EventArgs e)
        {
            Label clickedCell = sender as Label;

            if (clickedCell.BackColor == Variables.aliveColor)
            {
                clickedCell.BackColor = Variables.deadColor;
            }
            else
            {
                clickedCell.BackColor = Variables.aliveColor;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            int panelOffset = Variables.panelOffset;
            int panelSize = Variables.panelSize;

            Pen panelOutline = new Pen(Color.FromArgb(255,255,255), 2);
            Brush panelBackground = new SolidBrush(Color.FromArgb(33, 31, 45));

            canvas.DrawRectangle(panelOutline, panelOffset -1, panelOffset - 1, panelSize + 2, panelSize + 2);
            canvas.FillRectangle(panelBackground, panelOffset, panelOffset, panelSize, panelSize);
        }

        private void newGenButton_Click(object sender, EventArgs e)
        {
            int size = Variables.size;
            int neighbourCount;
            int[,] neighbourCells = new int[,] {
                { -1, -1 },
                { -1, 1 },
                { 1, -1 },
                { 1, 1 },
                { 0, 1 },
                { 1, 0 },
                { 0, -1 },
                { -1, 0 }
            };

            int[,] dummy = new int[size, size];

            for (int y = 0; y < size; y++)
            {
                for (int z = 0; z < size; z++)
                {
                    neighbourCount = 0;

                    for (int w = 0; w < 8; w++)
                    {
                        try
                        {
                            if (Variables.organism[y + neighbourCells[w, 0], z + neighbourCells[w, 1]].BackColor == Variables.aliveColor)
                            {
                                neighbourCount++;
                            }
                        }
                        catch { }
                    }
                    dummy[y, z] = neighbourCount;
                }
            }

            for (int y = 0; y < size; y++)
            {
                for (int z = 0; z < size; z++)
                {
                    if (Variables.organism[y, z].BackColor == Variables.aliveColor && (dummy[y,z] == 2 || dummy[y, z] == 3)) {}
                    else if (Variables.organism[y, z].BackColor == Variables.deadColor && (dummy[y, z] == 3))
                    {
                        Variables.organism[y, z].BackColor = Variables.aliveColor;
                    }
                    else
                    {
                        Variables.organism[y, z].BackColor = Variables.deadColor;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }

    public class Variables
    {
        public static int panelOffset = 100;                    // odsazení panelu s buňkami od levého horního rohu
        public static int panelSize = 500;                      // velikost panelu s buňkami
        public static int size = 20;                            // počet buněk v řádce/sloupci panelu s buňkami
        public static int width = panelSize / size;             // výpočet šířky jedné buňky
        
        public static Cell[,] organism = new Cell[size, size];  // array držící informace o všech buňkách

        public static Color aliveColor = Color.FromArgb(245, 50, 85);
        public static Color deadColor = Color.FromArgb(0, 0, 0, 0);
    }
}

//      the program needs to get optimized it runs like a fucking potato
//      i'll try fixing this by splitting up the 'new generation' process
//      could not be arsed to deal with it now 
//      
//      ⠀⠀⠀⠀⣀⣀⣤⣤⣦⣶⢶⣶⣿⣿⣿⣿⣿⣿⣿⣷⣶⣶⡄⠀⠀⠀⠀⠀⠀⠀
//          ⣿⣿⣿⠿⣿⣿⣾⣿⣿⣿⣿⣿⣿⠟⠛⠛⢿⣿⡇⠀⠀⠀⠀⠀⠀⠀
//          ⣿⡟⠡⠂⠀⢹⣿⣿⣿⣿⣿⣿⡇⠘⠁⠀⠀⣿⡇⠀⢠⣄⠀⠀⠀⠀
//          ⢸⣗⢴⣶⣷⣷⣿⣿⣿⣿⣿⣿⣷⣤⣤⣤⣴⣿⣗⣄⣼⣷⣶⡄⠀⠀
//         ⢀⣾⣿⡅⠐⣶⣦⣶⠀⢰⣶⣴⣦⣦⣶⠴⠀⢠⣿⣿⣿⣿⣼⣿⡇⠀⠀
//      ⠀⠀⢀⣾⣿⣿⣷⣬⡛⠷⣿⣿⣿⣿⣿⣿⣿⠿⠿⣠⣿⣿⣿⣿⣿⠿⠛⠃⠀⠀
//          ⢸⣿⣿⣿⣿⣿⣿⣿⣶⣦⣭⣭⣥⣭⣵⣶⣿⣿⣿⣿⣟⠉⠀⠀⠀⠀⠀⠀
//           ⠙⠇⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠀⠀⠀⠀⠀⠀⠀
//              ⣿⣿⣿⣿⣿⣛⠛⠛⠛⠛⠛⢛⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀
//              ⠿⣿⣿⣿⠿⠿⠀⠀⠀⠀⠀⠸⣿⣿⣿⣿⠿⠇⠀