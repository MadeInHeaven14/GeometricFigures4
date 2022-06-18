//Шакиров Эльмир, Группа 221П, Геометрические фигуры - 2, 05.05.22.
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;

class FilledFigure : Figure
{
    public FillData Fill;
    public StrokeData Stroke;

    public FilledFigure(Point point) : base(point)
    {
        Fill.Color = 0xFFFFFF;
        Stroke.Color = 0x000000;
    }

    public FilledFigure(int x, int y) : base(x, y)
    {
        Fill.Color = 0xFFFFFF;
        Stroke.Color = 0x000000;
    }

    public FilledFigure(int x, int y, Pen color) : base(x, y)
    {
        Stroke.Color = color.Color.ToArgb();
        Stroke.Width = Convert.ToInt32(color.Width);
    }
    public FilledFigure(Point point, Pen color) : base(point)
    {
        Stroke.Color = color.Color.ToArgb();
        Stroke.Width = Convert.ToInt32(color.Width);
    }
}