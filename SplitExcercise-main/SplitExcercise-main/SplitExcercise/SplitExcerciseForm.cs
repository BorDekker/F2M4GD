using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace SplitExcercise
{
    public partial class SplitExcerciseForm : Form
    {
        private Image spriteSheet;
        private readonly string exeDir = PathHelper.ExeDir();
        private List<Tile> tiles = new List<Tile>();
        public SplitExcerciseForm()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string imgPath = Path.Join(exeDir, "sprites.png");
            spriteSheet = Bitmap.FromFile(imgPath);

            new Generator().Generate();
            LoadLevel();
        }

        private void LoadLevel()
        {
            tiles.Clear();

            string leveldataPath = Path.Join(exeDir, "leveldata.txt");
            string[] levelData = File.ReadAllLines(leveldataPath);

            //elke regel:
            //placement x,y,w,h dan sprite x,y,w,h
            //0,0,16,16,43,0,16,16
            //is dus placement 0,0,16,16 en sprite 43,0,16,16

            foreach (string line in levelData)
            {
                Tile t = new Tile();
                //split de line en maak de placement en sprite Rectangles (new Rectangle(x,y,w,h));

                string[] data = line.Split(',');
                t.placement = new Rectangle(x.int.Parse(data[0]), (int.Parse(data[1]), (int.Parse(data[2]), (int.Parse(data[3]);
                t.sprite = new Rectangle(int.Parse(data[4]), (int.Parse(data[5]), (int.Parse(data[6]), (int.Parse(data[7]);
                tiles.Add(t);
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            //make nice pixels
            g.SmoothingMode = SmoothingMode.None;
            g.InterpolationMode = InterpolationMode.NearestNeighbor;

            foreach (Tile t in tiles)
            {
                g.DrawImage(spriteSheet, t.placement, t.sprite, GraphicsUnit.Pixel);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            spriteSheet.Dispose();
        }

        private void gen_Click(object sender, EventArgs e)
        {
            new Generator().Generate();
            LoadLevel();
            Invalidate();
        }
    }
}
