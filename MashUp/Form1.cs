using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mashUp
{
    public partial class Form1 : Form
    {
        static Figure f;
        Point ptX, ptY, mouse;
        Bitmap bmpX, bmpY;
        Graphics gX, gY;
        bool IsMouseDownX = false;
        bool IsMouseDownY = false;
        Canvas canvas;
        float deltaX = 0;
        float deltaY = 1;
        Scene scene;
        bool isMouseDown = false;
        bool sliderLimit = false;
        
        private bool play = false;
        int counter = 0;


        public Form1()
        {
            InitializeComponent();
            Init();
            IsMouseDownX = false;
        }

        private void Init()
        {
            bmpX = new Bitmap(PCT_SLIDEER_X.Width, PCT_SLIDEER_X.Height);
            bmpY = new Bitmap(PCT_SLIDEER_Y.Width, PCT_SLIDEER_Y.Height);

            gX = Graphics.FromImage(bmpX);
            gY = Graphics.FromImage(bmpY);

            PCT_SLIDEER_X.Image = bmpX;
            PCT_SLIDEER_Y.Image = bmpY;

            gX.DrawLine(Pens.DimGray, 0, bmpX.Height / 2, bmpX.Width, bmpX.Height / 2);
            gX.FillEllipse(Brushes.HotPink, bmpX.Width / 2, bmpX.Height / 4, bmpX.Height / 2, bmpX.Height / 2);

            gY.DrawLine(Pens.DimGray, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
            gY.FillEllipse(Brushes.HotPink, bmpY.Width / 4, bmpY.Height / 2, bmpX.Height / 2, bmpX.Height / 2);

            scene = new Scene();
            canvas = new Canvas(PCT_CANVAS);
            

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            canvas = new Canvas(PCT_CANVAS);
        }

        
        private void PCT_CANVAS_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                f.UpdateAttributes();
        }

        private void PCT_CANVAS_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (f != null)
            {
                f.Add(new PointF(e.X, e.Y));
            }
        }

        private void PCT_CANVAS_MouseDown(object sender, MouseEventArgs e) 
        {
            mouse = e.Location;
            isMouseDown = true;
        }

        private void PCT_CANVAS_MouseUp(object sender, MouseEventArgs e) 
        {
            isMouseDown = false;
            PCT_CANVAS.Select();
        }

        private void PCT_CANVAS_MouseMove(object sender, MouseEventArgs e) 
        {
            if (isMouseDown)
            {
                mouse.X -= e.X;
                mouse.Y -= e.Y;
                f.TranslatePoints(new Point(-mouse.X, -mouse.Y));
                f.UpdateAttributes();
                mouse = e.Location;
            }
        }


        
        private void sliderY_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDownY = false;
            gY.Clear(Color.Transparent);
            gY.DrawLine(Pens.DimGray, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
            gY.FillEllipse(Brushes.HotPink, bmpY.Width / 4, bmpY.Height / 2, bmpX.Height / 2, bmpX.Height / 2);

            PCT_SLIDEER_Y.Invalidate();
        }

        private void sliderY_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDownY)
            {
                gY.Clear(Color.Transparent);
                gY.DrawLine(Pens.DimGray, bmpY.Width / 2, 0, bmpY.Width / 2, bmpY.Height);
                gY.FillEllipse(Brushes.HotPink, bmpY.Width / 4, e.Y, bmpX.Height / 2, bmpX.Height / 2);

                PCT_SLIDEER_Y.Invalidate();
                deltaY += (float)(ptY.Y - e.Location.Y) / 500;
                ptY.Y = e.Location.Y;
            }
        }

        private void sliderY_MouseDown(object sender, MouseEventArgs e)
        {
            ptY = e.Location;
            IsMouseDownY = true;
        }

       
        private void sliderX_MouseDown(object sender, MouseEventArgs e)
        {
            ptX = e.Location;
            IsMouseDownX = true;
        }

        private void sliderX_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDownX)
            {
                gX.Clear(Color.Transparent);
                gX.DrawLine(Pens.DimGray, 0, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Width, PCT_SLIDEER_X.Height / 2);
                gX.FillEllipse(Brushes.HotPink, e.X, PCT_SLIDEER_X.Height / 4, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Height / 2);

                PCT_SLIDEER_X.Invalidate();
                deltaX += (float)(e.Location.X - ptX.X) / 3;
                f.Arotation += deltaX;
                ptX.X = e.Location.X;
            }
        }

        private void sliderX_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDownX = false;
            gX.Clear(Color.Transparent);
            gX.DrawLine(Pens.DimGray, 0, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Width, PCT_SLIDEER_X.Height / 2);
            gX.FillEllipse(Brushes.HotPink, PCT_SLIDEER_X.Width / 2, PCT_SLIDEER_X.Height / 4, PCT_SLIDEER_X.Height / 2, PCT_SLIDEER_X.Height / 2);

            PCT_SLIDEER_X.Invalidate();
        }


        //Updates
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (f != null) 
            {
                f.TranslateToOrigin();
                f.Scale(deltaY);
                f.Rotate(deltaX);
                f.TranslatePoints(f.Centroid);
                f.Ascale *= deltaY;
            }
            deltaX = 0;
            deltaY = 1;
            canvas.Render(scene); 

            if (play)
            {
                if (trackBar1.Value < trackBar1.Maximum && !sliderLimit)
                {
                    if (counter == 0) {
                        counter = 1;
                        trackBar1.Value = trackBar1.Minimum; // esto hace que el trackbar o la animacion comience desde el inicio
                    }
                    trackBar1.Value++;
                    RunAnimation();
                }
                else if (trackBar1.Value > 0 && sliderLimit)
                {
                    trackBar1.Value=trackBar1.Minimum; //esto hace que el track bar comience desde el inicio
                    RunAnimation();
                }
                else sliderLimit = !sliderLimit;
            }
        }

        private void refresh(Figure figs, float x, float y) 
        {

            if (figs != null)
            {
                figs.TranslateToOrigin();
                figs.Scale(1 / figs.Ascale); 
                figs.Ascale *= 1 / figs.Ascale;
                figs.Scale(y); 
                figs.Rotate(-figs.Arotation + x); 
                figs.Arotation = x; 
                figs.Ascale = y; 
                figs.TranslatePoints(figs.Centroid);
            }
        }

        private void RunAnimation()
        {
            if (checkBox1.Checked) foreach (Figure figure in scene.Figures) FigureAnimation(figure);
            else FigureAnimation(f);
        }

        private void FigureAnimation(Figure figs)
        {
            int firstSavedFrame = -1;
            int finalSavedFrame = -1; 
            float difference; 

            float rotAngle; 
            float scaleFactor; 

            if (scene.Figures.Count == 0 || figs.frames[trackBar1.Value]) return; 
            else
            {
                for (int i = trackBar1.Value; i >= 0; i--)
                {
                    if (figs.frames[i])
                    {
                        firstSavedFrame = i;
                        break;
                    }
                }

                for (int i = trackBar1.Value; i <= figs.positions.Length - 1; i++)
                {
                    if (figs.frames[i])
                    {
                        finalSavedFrame = i;
                        break;
                    }
                }
            }
            if (firstSavedFrame != -1 && finalSavedFrame != -1) 
            {

                difference = ((float)trackBar1.Value - firstSavedFrame) / (finalSavedFrame - firstSavedFrame); 

                rotAngle = ((figs.rotations[finalSavedFrame] - figs.rotations[firstSavedFrame]) * difference) + figs.rotations[firstSavedFrame]; 
                scaleFactor = ((figs.sizes[finalSavedFrame] - figs.sizes[firstSavedFrame]) * difference) + figs.sizes[firstSavedFrame];

                figs.Follow(figs.positions[firstSavedFrame], figs.positions[finalSavedFrame], difference); 
                refresh(figs, rotAngle, scaleFactor); 
            }
        }
        //Add figure Method
        private void ADD_Click(object sender, EventArgs e)
        {
            f = new Figure(trackBar1.Maximum);
            scene.Figures.Add(f);
            TreeNode node = new TreeNode("Fig" + (treeView1.Nodes.Count + 1));
            node.Tag = f;
            treeView1.Nodes.Add(node);
        }

        private void PLAY_Click(object sender, EventArgs e)
        {
            play = !play;

            if (play)
                PLAY.Text = "PAUSE";
            else
                PLAY.Text = "PLAY ANIMATION";
        }

        private void RECORD_Click(object sender, EventArgs e)
        {
            f.frames[trackBar1.Value] = true;
            f.positions[trackBar1.Value] = f.Centroid;
            f.rotations[trackBar1.Value] = f.Arotation;
            f.sizes[trackBar1.Value] = f.Ascale;
            //trackBar1.Value = trackBar1.Value + 10; //hace que el track bar avance 10 frames cada que le des click
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            f = (Figure)treeView1.SelectedNode.Tag;
            ADD.Select();
        }

        public static bool IsControlDown()
        {
            return (Control.ModifierKeys & Keys.Control) == Keys.Control;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (f == null)
                return false;

            switch (keyData)
            {
                case Keys.Left:
                    f.Centroid.X -= 3;
                    break;
                case Keys.Right:
                    f.Centroid.X += 3;
                    break;
                case Keys.Up:
                    f.Centroid.Y += -3;
                    break;
                case Keys.Down:
                    f.Centroid.Y += 3;
                    break;
                case Keys.Space:
                    break;
            }
            PCT_CANVAS.Select();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void treeView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            return;
        }

        const int WM_KEYDOWN = 0x0100;

        //Animation scroll
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            RunAnimation();
        }
    }
}
