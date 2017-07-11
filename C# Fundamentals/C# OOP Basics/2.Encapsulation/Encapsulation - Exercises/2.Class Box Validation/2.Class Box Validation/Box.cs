using System;

namespace _2.Class_Box_Validation
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return this.length; }
            private set
            {
                if (value < 1)
                {
                    throw new Exception("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }
        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value < 1)
                {
                    throw new Exception("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value < 1)
                {
                    throw new Exception("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }
        public double GetSurfaceArea()
        {
            //Surface Area = 2lw + 2lh + 2wh
            return (2 * this.Length * this.Width) + (2 * this.Width * this.Height) + (2 * this.Length * this.Height);
        }

        public double GetLateralSurfaceArea()
        {
            //Lateral Surface Area = 2lh + 2wh
            return (2 * this.Length * this.Height) + (2 * Width * Height);
        }

        public double GetVolume()
        {
            //Volume = lwh
            return this.Length * this.Width * this.Height;
        }
    }
}
