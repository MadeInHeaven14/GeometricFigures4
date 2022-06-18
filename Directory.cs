
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

class Directory : Figure
{
    List<Figure> Figura;

    public Directory()
    {
        Figura = new List<Figure>();
    }

    public void Add(Figure figure)
    {
        Figura.Add(figure);
    }
    public void Save(string path)
    {
        using (StreamWriter sw = new StreamWriter(path))
        {
            foreach (Figure f in Figura)
            {
                sw.WriteLine(f);
            }
        }
    }

    public void Load(string path)
    {
        using (StreamReader reader = new StreamReader(path))
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                string[] figurka = line.Split(" ");
            
                switch (figurka[0])
                {
                    case "Line":
                        Add(new Line(int.Parse(figurka[1]), int.Parse(figurka[2]), int.Parse(figurka[3]), int.Parse(figurka[4]), new Pen(Color.FromArgb(int.Parse(figurka[5])), int.Parse(figurka[6]))));
                        break;

                    case "Triangle":
                        Add(new Triangle(int.Parse(figurka[1]), int.Parse(figurka[2]), int.Parse(figurka[3]), int.Parse(figurka[4]), int.Parse(figurka[5]), int.Parse(figurka[6]), new Pen(Color.FromArgb(int.Parse(figurka[7])), int.Parse(figurka[8]))));
                        break;

                    case "Circle":
                        Add(new Circle(new Point(int.Parse(figurka[1]), int.Parse(figurka[2])), int.Parse(figurka[3]), new Pen(Color.FromArgb(int.Parse(figurka[4])), int.Parse(figurka[5]))));
                        break;

                    case "Rectangle":
                        Add(new Rectangle(new Point(int.Parse(figurka[1]), int.Parse(figurka[2])), int.Parse(figurka[3]), int.Parse(figurka[4]), new Pen(Color.FromArgb(int.Parse(figurka[5])), int.Parse(figurka[6]))));
                        break;

                    default: throw new Exception("Unknown figure");
                }
                line = reader.ReadLine();
            }
        }
    }
    public override void Draw(Graphics g)
    {
        foreach (var i in Figura)
        {
            i.Draw(g);
        }
    }
}