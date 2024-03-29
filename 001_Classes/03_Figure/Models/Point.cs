﻿namespace _03_Figure.Models
{
    internal class Point
    {
        private double x;
        private double y;
        private string name;

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }

        public Point(double x, double y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}
