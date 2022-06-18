
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
class Rectangle : FilledFigure
{
    public int Height;
    public int Width;

    public Rectangle(Point point, int width, int height, Pen color) : base(point)
    {
        Height = height;
        Width = width;
        Stroke.Color = color.Color.ToArgb();
        Stroke.Width = Convert.ToInt32(color.Width);
    }

    public Rectangle(Point point, int width, int height) : base(point)
    {
        Height = height;
        Width = width;
    }


    public override void Draw(Graphics g)
    {
        g.DrawRectangle(new Pen(Color.FromArgb(Stroke.Color), Stroke.Width), base.basePoint.X, base.basePoint.Y, Width, Height);
    }

    public override string ToString()
    {
        return ($"Rectangle {basePoint} {Width} {Height} {Stroke.Color} {Stroke.Width}");
    }
}