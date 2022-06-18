using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


    public partial class Draw_Redactor : Form
    {
    Directory Figura;
    Bitmap bitmap;
    Graphics g;
    Pen pen;
    public Draw_Redactor()
        {
            InitializeComponent();
            Figura = new Directory();
            bitmap = new Bitmap(picBox_Draw.Size.Width, picBox_Draw.Size.Height);
            g = Graphics.FromImage(bitmap);
            pen = new Pen(Color.Black);
            picBox_Draw.Image = bitmap;
            g = picBox_Draw.CreateGraphics();
        }

    private void FigureChoice_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(FigureChoice.Text == "Rectangle")
        {
            X1.Text = null;
            Y1.Text = null;
            X2.Text = null;
            Y2.Text = null;
            Width.Text = null;
            Height.Text = null;
            trackBar_Width.Value = 0;
            openColorDialog.BackColor = Color.White;
            labelX1.Visible = true;
            X1.Visible = true;
            labelY1.Visible = true;
            Y1.Visible = true;
            labelX2.Visible = false;
            X2.Visible = false;
            labelY2.Visible = false;
            Y2.Visible = false;
            labelX3.Visible = false;
            X3.Visible = false;
            labelY3.Visible = false;
            Y3.Visible = false;
            labelRadius.Visible = false;
            Radius.Visible = false;
            labelWidth.Visible = true;
            Width.Visible = true;
            labelHeight.Visible = true;
            Height.Visible = true;
            Choice_Color.Visible = true;
            red_color.Visible = true;
            yellow_color.Visible = true;
            blue_color.Visible = true;
            openColorDialog.Visible = true;
            Choice_Width.Visible = true;
            trackBar_Width.Visible = true;
        }
        if (FigureChoice.Text == "Line")
        {
            X1.Text = null;
            Y1.Text = null;
            X2.Text = null;
            Y2.Text = null;
            trackBar_Width.Value = 0;
            openColorDialog.BackColor = Color.White;
            labelX1.Visible = true;
            X1.Visible = true;
            labelY1.Visible = true;
            Y1.Visible = true;
            labelX2.Visible = true;
            X2.Visible = true;
            labelY2.Visible = true;
            Y2.Visible = true;
            labelX3.Visible = false;
            X3.Visible = false;
            labelY3.Visible = false;
            Y3.Visible = false;
            labelRadius.Visible = false;
            Radius.Visible = false;
            labelWidth.Visible = false;
            Width.Visible = false;
            labelHeight.Visible = false;
            Height.Visible = false;
            Choice_Color.Visible = true;
            red_color.Visible = true;
            yellow_color.Visible = true;
            blue_color.Visible = true;
            openColorDialog.Visible = true;
            Choice_Width.Visible = true;
            trackBar_Width.Visible = true;
        }
        if (FigureChoice.Text == "Circle")
        {
            X1.Text = null;
            Y1.Text = null;
            Radius.Text = null;
            trackBar_Width.Value = 0;
            openColorDialog.BackColor = Color.White;
            labelX1.Visible = true;
            X1.Visible = true;
            labelY1.Visible = true;
            Y1.Visible = true;
            labelX2.Visible = false;
            X2.Visible = false;
            labelY2.Visible = false;
            Y2.Visible = false;
            labelX3.Visible = false;
            X3.Visible = false;
            labelY3.Visible = false;
            Y3.Visible = false;
            labelRadius.Visible = true;
            Radius.Visible = true;
            labelWidth.Visible = false;
            Width.Visible = false;
            labelHeight.Visible = false;
            Height.Visible = false;
            Choice_Color.Visible = true;
            red_color.Visible = true;
            yellow_color.Visible = true;
            blue_color.Visible = true;
            openColorDialog.Visible = true;
            Choice_Width.Visible = true;
            trackBar_Width.Visible = true;
        }
        if (FigureChoice.Text == "Triangle")
        {
            X1.Text = null;
            Y1.Text = null;
            X2.Text = null;
            Y2.Text = null;
            X3.Text = null;
            Y3.Text = null;
            trackBar_Width.Value = 0;
            openColorDialog.BackColor = Color.White;
            labelX1.Visible = true;
            X1.Visible = true;
            labelY1.Visible = true;
            Y1.Visible = true;
            labelX2.Visible = true;
            X2.Visible = true;
            labelY2.Visible = true;
            Y2.Visible = true;
            labelX3.Visible = true;
            X3.Visible = true;
            labelY3.Visible = true;
            Y3.Visible = true;
            labelRadius.Visible = false;
            Radius.Visible = false;
            labelWidth.Visible = false;
            Width.Visible = false;
            labelHeight.Visible = false;
            Height.Visible = false;
            Choice_Color.Visible = true;
            red_color.Visible = true;
            yellow_color.Visible = true;
            blue_color.Visible = true;
            openColorDialog.Visible = true;
            Choice_Width.Visible = true;
            trackBar_Width.Visible = true;
        }
    }

    private void X1_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!(Char.IsDigit(e.KeyChar)))
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }

    private void Draw_Click(object sender, EventArgs e)
    {
        switch (FigureChoice.Text)
        {
            case "Rectangle":
                Figura.Add(new Rectangle(new Point(Convert.ToInt32(X1.Text), Convert.ToInt32(Y1.Text)), Convert.ToInt32(Width.Text), Convert.ToInt32(Height.Text), pen));
                Figura.Draw(g);
                break;
            case "Line":
                Figura.Add(new Line(Convert.ToInt32(X1.Text), Convert.ToInt32(Y1.Text), Convert.ToInt32(X2.Text), Convert.ToInt32(Y2.Text), pen));
                Figura.Draw(g);
                break;
            case "Circle":
                Figura.Add(new Circle(new Point(Convert.ToInt32(X1.Text), Convert.ToInt32(Y1.Text)), Convert.ToInt32(Radius.Text), pen));
                Figura.Draw(g);
                break;
            case "Triangle":
                Figura.Add(new Triangle(Convert.ToInt32(X1.Text), Convert.ToInt32(Y1.Text), Convert.ToInt32(X2.Text), Convert.ToInt32(Y2.Text), Convert.ToInt32(X3.Text), Convert.ToInt32(Y3.Text), pen));
                break;
        }
    }

    private void Clear_Click(object sender, EventArgs e)
    {
        picBox_Draw.Image = null;
        FigureChoice.Text = null;
        labelX1.Visible = false;
        X1.Visible = false;
        labelY1.Visible = false;
        Y1.Visible = false;
        labelX2.Visible = false;
        X2.Visible = false;
        labelY2.Visible = false;
        Y2.Visible = false;
        labelX3.Visible = false;
        X3.Visible = false;
        labelY3.Visible = false;
        Y3.Visible = false;
        labelRadius.Visible = false;
        Radius.Visible = false;
        labelWidth.Visible = false;
        Width.Visible = false;
        labelHeight.Visible = false;
        Height.Visible = false;
        Choice_Color.Visible = false;
        red_color.Visible = false;
        yellow_color.Visible = false;
        blue_color.Visible = false;
        openColorDialog.Visible = false;
        openColorDialog.BackColor = Color.White;
        Choice_Width.Visible = false;
        trackBar_Width.Visible = false;
        trackBar_Width.Value = 0;
        Figura = new Directory();
    }

    private void Save_Click(object sender, EventArgs e)
    {
        if (saveFileDialog.ShowDialog() == DialogResult.Cancel) 
        { return; }
        string path = saveFileDialog.FileName; 
        Figura.Save(path);
    }

    private void Load_Click(object sender, EventArgs e)
    {
        if (openFileDialog_Color.ShowDialog() == DialogResult.Cancel)
        { return; }
        string path = openFileDialog_Color.FileName;
        Figura.Load(path);
        Figura.Draw(g);
    }

    private void pictureBox1_ClientSizeChanged(object sender, EventArgs e)
    {
        picBox_Draw.Size = new System.Drawing.Size(1000, 1000);
        g.Dispose();
        g = picBox_Draw.CreateGraphics();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
        Figura.Draw(g);
    }

    private void red_color_Click(object sender, EventArgs e)
    {
        pen = new Pen(Color.Red);
    }

    private void yellow_color_Click(object sender, EventArgs e)
    {
        pen = new Pen(Color.Yellow);
    }

    private void blue_color_Click(object sender, EventArgs e)
    {
        pen = new Pen(Color.Blue);
    }

    private void openColorDialog_Click(object sender, EventArgs e)
    {
        if(colorDialog.ShowDialog() == DialogResult.OK)
        {
            pen = new Pen(colorDialog.Color);
            ((PictureBox)sender).BackColor = colorDialog.Color;
        }
    }

    private void trackBar1_ValueChanged(object sender, EventArgs e)
    {
        pen.Width = trackBar_Width.Value;
    }
}

