//Шакиров Эльмир, Группа 221П, Геометрические фигуры - 2, 05.05.22.
using System;
using System.Collections.Generic;
using System.IO;
struct Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"{X} {Y}";
    }
}

struct StrokeData
{
    public int Width;
    public int Color;
}

struct FillData
{
    public int Color;
}