using System;

class Rect
{
    public int Width;
    public int Height;

    public Rect(int w, int h)
    {
        this.Width = w;
        this.Height = h;
    }

    public int Area()
    {
        return this.Width * this.Height;
    }
}
