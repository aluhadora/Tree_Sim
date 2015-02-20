using System;
using System.Drawing;

namespace Tree_Sim
{
  public class Process
  {
    private TreeArgs _args;
    public Bitmap Bmp;
    private Graphics _g;
    private Random _r;
    private Brush _brush = Brushes.Black;

    private const double AngleOffset = .1d;

    private double XPixelWidth
    {
      get
      {
        return 60d / _args.Width;
      }
    }
    private double YPixelWidth
    {
      get
      {
        return 60d / _args.Height;
      }
    }

    public void Go(TreeArgs args)
    {
      _args = args;
      _args.Dx = .5d;
      _r = new Random();
      Bmp = new Bitmap(_args.Width, _args.Height);
      _g = Graphics.FromImage(Bmp);
      

      var root = new Branch
        {
          Length = 40,
          Start = new Position(0d, 20d, -Math.PI /2),
          Width = 5f,
        };

      DrawBranch(root);
    }

    private void DrawBranch(Branch branch)
    {
      var drawnLength = 0d;
      var x = branch.Start.X;
      var y = branch.Start.Y;
      var t = branch.Start.Theta;

      while (drawnLength < branch.Length)
      {
        double dx = _args.Dx + E(_args.Dx / 20);
        drawnLength += dx;
        t += E(AngleOffset);
        var oX = x;
        var oY = y;
        x += dx * Math.Cos(t);
        y += dx * Math.Sin(t);
        var width = (float)(branch.Width * (branch.Length - drawnLength) / branch.Length);
        if (width > branch.Width) width = 1;

        _brush = branch.Depth == _args.N ? Brushes.Green : Brushes.Black;

        Draw(oX,oY,x,y,width);

        if (branch.Depth < _args.N && _r.NextDouble() < 3 / branch.Length)
        {
          double rv = E(Math.PI / 2);
          double variation = Math.Sign(rv) * (Math.Cos(rv)) /2;
          //double variation = (-Math.Cos(E(Math.PI / 2)) + 1) /2;
          var childBranch = new Branch
            {
              Depth = branch.Depth + 1,
              Length = branch.Length * .66d / (branch.Depth + 1),
              Width = width,
              Start = new Position(x, y, t + variation)
            };
          DrawBranch(childBranch);
        }
      }
    }

    private double E(double e)
    {
      return R(-e, e);
    }

    private double R(double min, double max)
    {
      var r = _r.NextDouble();
      r *= max - min;
      r += min;
      return r;
    }

    private void Draw(double x1, double y1, double x2, double y2, float width)
    {
      const int offset = 30;
      var i1 = (int)(x1 / XPixelWidth + offset / XPixelWidth);
      var j1 = (int)(y1 / YPixelWidth + offset / YPixelWidth);
      var i2 = (int)(x2 / XPixelWidth + offset / XPixelWidth);
      var j2 = (int)(y2 / YPixelWidth + offset / YPixelWidth);

      var pen = new Pen(_brush, width);
      _g.DrawLine(pen, i1, j1, i2, j2);
    }
  }
}
