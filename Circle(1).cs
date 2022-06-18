
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

class Circle : FilledFigure
{
    public int Radius;
    public Circle(Point point, int radius, Pen pen) : base(point, pen)
    {
        Radius = radius;
    }


    public override void Draw(Graphics g)
    {
        g.DrawEllipse(new Pen(Color.FromArgb(Stroke.Color), Stroke.Width), basePoint.X, basePoint.Y, Radius, Radius);
    }

    public override string ToString()
    {
        return ($"Circle {basePoint} {Radius} {Stroke.Color} {Stroke.Width}");
    }
}