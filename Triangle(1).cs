
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
class Triangle : FilledFigure
{
    public Point A
    {
        get { return basePoint; }
        set { basePoint = value; }
    }
    public Point B;
    public Point C;

    public Triangle(Point a, Point b, Point c, Pen pen) : base(a, pen)
    {
        B = b;
        C = c;
    }

    public Triangle(int x1, int y1, int x2, int y2, int x3, int y3, Pen color) : base(x1, y1)
    {
        B = new Point(x2, y2);
        C = new Point(x3, y3);
        Stroke.Color = color.Color.ToArgb();
        Stroke.Width = Convert.ToInt32(color.Width);
    }

    public override void Draw(Graphics g)
    {
        PointF X1Y1 = new PointF(base.basePoint.X, base.basePoint.Y);
        PointF X2Y2 = new PointF(B.X, B.Y);
        PointF X3Y3 = new PointF(C.X, C.Y);
        PointF[] triangle = { X1Y1, X2Y2, X3Y3 };
        g.DrawPolygon(new Pen(Color.FromArgb(Stroke.Color), Stroke.Width), triangle);
    }

    public override string ToString()
    {
        return ($"Triangle {A} {B} {C} {Stroke.Color} {Stroke.Width}");
    }
}