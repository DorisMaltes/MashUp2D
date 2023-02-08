using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mashUp
{
    public class Figure
    {
        public List<PointF> Pts;
        public PointF Centroid, Last;

        
        public bool[] frames; //boolean array that represents whether each object is active or inactive
        public float[] rotations; //this array holds the size of each object IN RADIANS
        public float[] sizes; //array that holds the position of each object
        public PointF[] positions;// holds the position of each object as a PointF object, which is a structure that holds an X and Y coordinate

        public float Arotation = 0; //holds the rotation of the entire collection of objects in radians
        public float Ascale = 1; //holds the scale factor that affects the size of the entire collection of objects.
        
        public Figure(int frameSize)
        {
            Pts = new List<PointF>();

            frames = new bool[frameSize + 1];//Initializes a new bool array frames with a size equal to frameSize + 1.
            rotations = new float[frameSize + 1]; //Initializes a new float array rotations with a size equal to frameSize + 1.
            sizes = new float[frameSize + 1];//Initializes a new float array sizes with a size equal to frameSize + 1.
            positions = new PointF[frameSize + 1];//Initializes a new PointF array positions with a size equal to frameSize + 1.

            for (int i = 0; i < frameSize; i++)
            {
                frames[i] = false;//within the loop,  the value of the i-th element of the frames array is set to false.
            }
            //This is the start of a for loop that will repeat frameSize times. The loop variable i is initialized to 0, and will be incremented by 1 for each iteration until i is equal to frameSize - 1.

        }

        public void Add(PointF point)
        {
            Centroid = new PointF();
            Pts.Add(point);

            for (int p = 0; p < Pts.Count; p++)
            {
                Centroid.X += Pts[p].X;
                Centroid.Y += Pts[p].Y;
            }
            Last = point;

            Centroid.X /= Pts.Count;
            Centroid.Y /= Pts.Count;
        }

        public void Scale(float value)
        {
            for (int p = 0; p < Pts.Count; p++)
            {
                Pts[p] = new PointF(Pts[p].X * value, Pts[p].Y * value);
            }
        }

        public void Follow(PointF a, PointF b, float value)
        {
            PointF pos = Util.Ins.NextStep(a, b, value);
            TranslateToOrigin();
            TranslatePoints(pos);
            UpdateAttributes();
        }

        public void TranslatePoints(PointF a)
        {
            for (int p = 0; p < Pts.Count; p++)
            {
                Pts[p] = new PointF(Pts[p].X + a.X, Pts[p].Y + a.Y);
            }
        }

        public void TranslateToOrigin()
        {
            for (int p = 0; p < Pts.Count; p++)
            {
                Pts[p] = new PointF(Pts[p].X - Centroid.X, Pts[p].Y - Centroid.Y);
            }
        }

        public void Rotate(float angle)
        {
            for (int p = 0; p < Pts.Count; p++)
                Pts[p] = Util.Ins.Rotate(Pts[p], angle);
        }

        public void UpdateAttributes()
        {
            Centroid = new PointF();

            for (int p = 0; p < Pts.Count; p++)
            {
                Centroid.X += Pts[p].X;
                Centroid.Y += Pts[p].Y;
            }
            Last = Pts[Pts.Count - 1];

            Centroid.X /= Pts.Count;
            Centroid.Y /= Pts.Count;
        }
    }
}
