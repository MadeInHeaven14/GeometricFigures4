
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;

class Line : Figure
{
    public Point A
    {
        get { return basePoint; }
        set { basePoint = value; }
    }

    

    public Point B;

    public StrokeData Stroke;

    public Line(Point a, Point b, Pen color) : base(a)
    {
        B = b;
        Stroke.Color = color.Color.ToArgb();
        Stroke.Width = Convert.ToInt32(color.Width);
    }

    public Line(int x1, int y1, int x2, int y2, Pen color) : base(x1, y1)
    {
        B = new Point(x2, y2);
        Stroke.Color = color.Color.ToArgb();
        Stroke.Width = Convert.ToInt32(color.Width);
    }

    

    public override void Draw(Graphics g)
    {
        g.DrawLine(new Pen(Color.FromArgb(Stroke.Color), Stroke.Width), base.basePoint.X, base.basePoint.Y, B.X, B.Y);
    }

    public override string ToString()
    {
        return ($"Line {A} {B} {Stroke.Color} {Stroke.Width}");
    }
}