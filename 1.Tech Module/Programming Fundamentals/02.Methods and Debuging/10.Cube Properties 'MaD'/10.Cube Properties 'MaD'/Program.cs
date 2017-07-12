using System;

namespace _10.Cube_Properties__MaD_
{
    public class Program
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            
            if (parameter == "face")
            {
                Face(a);
            }
            else if ( parameter == "volume")
            {
                Volume(a);
            }else if ( parameter == "space")
            {
                Space(a);
            }else if( parameter == "area")
            {
                Area(a);
            }
            
        }
        public static void Face(double a)
        {
            double face = Math.Round(Math.Sqrt(2*a*a),2);
            string displayString = face.ToString("0.00");
            Console.WriteLine(displayString);

        }
        public static void Volume (double a)
        {
            double volume = Math.Round((a * a * a),2);
            string displayString = volume.ToString("0.00");
            Console.WriteLine(displayString);
        }
        public static void Space (double a)
        {
            double space = Math.Round(Math.Sqrt(3 * a*a ), 2);
            string displayString = space.ToString("0.00");
            Console.WriteLine(displayString);

        }
        public static void Area (double a)
        {
            double area = Math.Round(6*a*a,2);
            string displayString = area.ToString("0.00");
            Console.WriteLine(displayString);

        }


    }
}


