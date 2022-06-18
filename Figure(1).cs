//Шакиров Эльмир, Группа 221П, Геометрические фигуры - 2, 05.05.22.
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;

class Figure
{
    protected Point basePoint;

    public Figure(Point point)
    {
        basePoint = point;
    }

    public Figure(int x = 0, int y = 0)
    {
        basePoint = new Point(x, y);
    }

    public virtual void Draw(Graphics g)
    { }
}