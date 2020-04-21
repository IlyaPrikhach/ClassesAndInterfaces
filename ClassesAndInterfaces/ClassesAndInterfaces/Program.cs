using System;
using System.IO;
using System.Text;

namespace ClassesAndInterfaces
{
    
    class Program
    {
        static Circle circle;
        static Rectangle rectangle;
        static Triangle triangle;
        static Rhombus rhombus;
        static Polygon polygon;
        static WriteFigure figure = new WriteFigure();
        static void Main()
        {
            startChois(out double[] mass, out string marker, out string firstLine);
            write( mass, marker);
            contin();
            Console.ReadLine();
        }

        static void startChois(out double[] mass, out string marker, out string firstLine)
        {
            mass = null;
            marker = "";
            firstLine = "";
            Console.WriteLine("1) Из файла\n2) Из консоли?");
            string ch = Console.ReadLine();
            if(ch == "1")
            {
                string[] strmass = File.ReadAllLines("classesAndInterfaces.txt");
                firstLine = strmass[0];
                figureFromFile(firstLine, out  mass, out marker);
            }
            else if (ch == "2")
            {
                chois(out mass, out marker);
            }
            else
            {
                Console.WriteLine("Возможно ваш вариант неверный, попробуйте снова");
                startChois(out  mass, out  marker, out firstLine);
            }
        }

        static void figureFromFile(string firstLine, out double[] mass, out string marker)
        {       
            string[] checkMark = firstLine.Split(' ');
            marker = checkMark[0];
            if (marker == "ci")
            {
                circle = new Circle();
                mass = new double[3];
                mass[0] = Convert.ToDouble(checkMark[1]);
                mass[1] = circle.perimeter(mass);
                mass[2] = circle.square(mass);
                Console.WriteLine("Окружность:\nПериметр: " + circle.perimeter(mass) + "\nПлощадь: " + circle.square(mass));
            }
            else if (marker == "rc")
            {
                rectangle = new Rectangle();
                mass = new double[4];
                mass[0] = Convert.ToDouble(checkMark[1]);
                mass[1] = Convert.ToDouble(checkMark[2]);
                mass[2] = rectangle.perimeter(mass);
                mass[3] = rectangle.square(mass);
                Console.WriteLine("Прямоугольник:\nПериметр: " + rectangle.perimeter(mass) + "\nПлощадь: " + rectangle.square(mass));
            }
            else if (marker == "tr")
            {
                triangle = new Triangle();
                mass = new double[6];
                mass[0] = Convert.ToDouble(checkMark[1]);
                mass[1] = Convert.ToDouble(checkMark[2]);
                mass[2] = Convert.ToDouble(checkMark[3]);
                mass[3] = Convert.ToDouble(checkMark[4]);
                mass[4] = triangle.perimeter(mass);
                mass[5] = triangle.square(mass);
                Console.WriteLine("Треугольник:\nПериметр: " + triangle.perimeter(mass) + "\nПлощадь: " + triangle.square(mass));
            }
            else if (marker == "rh")
            {
                rhombus = new Rhombus();
                mass = new double[4];
                mass[0] = Convert.ToDouble(checkMark[1]);
                mass[1] = Convert.ToDouble(checkMark[2]);
                mass[2] = rhombus.perimeter(mass);
                mass[3] = rhombus.square(mass);
                Console.WriteLine("Ромб:\nПериметр: " + rhombus.perimeter(mass) + "\nПлощадь: " + rhombus.square(mass));
            }
            else if (marker == "pl")
            {
                polygon = new Polygon();
                mass = new double[5];
                mass[0] = Convert.ToDouble(checkMark[1]);
                mass[1] = Convert.ToDouble(checkMark[2]);
                mass[2] = Convert.ToDouble(checkMark[3]);
                mass[3] = polygon.perimeter(mass);
                mass[4] = polygon.square(mass);
                Console.WriteLine("Многоугольник:\nПериметр: " + polygon.perimeter(mass) + "\nПлощадь: " + polygon.square(mass));
            }
            else
            {
                mass = null;
            }
        }

        static void chois(out double[] mass, out string marker)
        {

            try
            {
                string[] strs;
                Console.WriteLine("Выберите фигуру:\n 1) Окружность\n 2) Прямоугольник\n 3) Треугольник\n 4) Ромб\n 5) Многоугольник");
                string ch = Console.ReadLine();
                if (ch == "1")
                {
                    circle = new Circle();
                    mass = new double[3];
                    strs = new string[1];
                    marker = "ci";
                    Console.WriteLine("Введите радиус окружности");
                    strs = Console.ReadLine().Split(' ');
                    mass[0] = Convert.ToDouble(strs[0]);
                    mass[1] = circle.perimeter(mass);
                    mass[2] = circle.square(mass);
                    Console.WriteLine("Периметр: " + circle.perimeter(mass) + "\nПлощадь: " + circle.square(mass));

                }
                else if (ch == "2")
                {
                    rectangle = new Rectangle();
                    mass = new double[4];
                    strs = new string[2];
                    marker = "rc";
                    Console.WriteLine("Введите длину a, и длину b");
                    strs = Console.ReadLine().Split(' ');
                    mass[0] = Convert.ToDouble(strs[0]);
                    mass[1] = Convert.ToDouble(strs[1]);
                    mass[2] = rectangle.perimeter(mass);
                    mass[3] = rectangle.square(mass);
                    Console.WriteLine("Периметр: " + rectangle.perimeter(mass) + "\nПлощадь: " + rectangle.square(mass));
                }
                else if (ch == "3")
                {
                    triangle = new Triangle();
                    marker = "tr";
                    mass = new double[6];
                    strs = new string[4];
                    Console.WriteLine("Введите длину a,  длину b, длину с и высоту ");
                    strs = Console.ReadLine().Split(' ');
                    mass[0] = Convert.ToDouble(strs[0]);
                    mass[1] = Convert.ToDouble(strs[1]);
                    mass[2] = Convert.ToDouble(strs[2]);
                    mass[3] = Convert.ToDouble(strs[3]);
                    mass[4] = triangle.perimeter(mass);
                    mass[5] = triangle.square(mass);
                    Console.WriteLine("Периметр: " + triangle.perimeter(mass) + "\nПлощадь: " + triangle.square(mass));
                }
                else if (ch == "4")
                {
                    rhombus = new Rhombus();
                    marker = "rh";
                    mass = new double[4];
                    strs = new string[2];
                    Console.WriteLine("Введите длину стороны ромба, и высоту");
                    strs = Console.ReadLine().Split(' ');
                    mass[0] = Convert.ToDouble(strs[0]);
                    mass[1] = Convert.ToDouble(strs[1]);
                    mass[2] = rhombus.perimeter(mass);
                    mass[3] = rhombus.square(mass);
                    Console.WriteLine("Периметр: " + rhombus.perimeter(mass) + "\nПлощадь: " + rhombus.square(mass));

                }
                else if (ch == "5")
                {
                    polygon = new Polygon();
                    marker = "pl";
                    mass = new double[5];
                    strs = new string[3];
                    Console.WriteLine("Введите длину количество граней, длину стороны и радиус вписанной окружности");
                    strs = Console.ReadLine().Split(' ');
                    mass[0] = Convert.ToDouble(strs[0]);
                    mass[1] = Convert.ToDouble(strs[1]);
                    mass[2] = Convert.ToDouble(strs[2]);
                    mass[3] = polygon.perimeter(mass);
                    mass[4] = polygon.square(mass);
                    Console.WriteLine("Периметр: " + polygon.perimeter(mass) + "\nПлощадь: " + polygon.square(mass));
                }
                else
                {
                    marker = "";
                    Console.WriteLine("Возможно вы указали фигуру неверно, попробуйте ещё раз");
                    chois(out mass, out marker);
                }
            }
            catch
            {
                marker = "";
                Console.WriteLine("Возможно вы указали фигуру неверно, попробуйте ещё раз");
                chois(out mass, out marker);
            }

        }

        static void write(double[] mass, string marker)
        {
            Console.WriteLine("Хотите записать результат в файл?(yes/no)");
            string ch = Console.ReadLine();
            if(ch == "yes")
            {
                figure.writeFigure(mass, marker);
            }
            else if(ch == "no")
            {
            }
            else
            {
                Console.WriteLine("Возможно ваш вариант неверный, попробуйте снова");
                write(mass, marker);
            }
        }
        static void contin()
        {
            Console.WriteLine("Хотите продолжить?(yes/no)");
            string ch = Console.ReadLine();
            if (ch == "yes")
            {
                Main();
            }
            else if (ch == "no")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Возможно ваш выбранный вариант, отличается от предложенного, попробуйте снова");
                contin();
            }
        }
    }

    interface ICount
    {
        double perimeter(double[] mass);
        double square(double[] mass);
    }

    interface IWrite
    {
        void writeFigure(double[] mass, string marker);
    }

    class WriteFigure : IWrite
    {
        public void writeFigure(double[] mass, string marker)
        {
            string mst = marker + " ";
            int i;
            for (i = 0; i < mass.Length - 2; i++)
            {
                mst += mass[i] + " ";
            }
            mst += "\nP: " + mass[i];
            i++;
            mst += "\nS: " + mass[i];
            File.WriteAllText("classesAndInterfaces.txt", mst.ToString());
            Console.WriteLine("Данные записаны в файл");
        }
    }


    class Circle : WriteFigure, ICount
    {
        public double perimeter(double[] mass)
        {
            double P = 2 * Math.PI * mass[0];
            return P;
        }

        public double square(double[] mass)
        {
            return Math.PI * mass[0] * mass[0];
        }
    }

    class Rectangle : WriteFigure, ICount
    {
        public double perimeter(double[] mass)
        {
            return mass[0] + mass[1];
        }

        public double square(double[] mass)
        {
            return mass[0] * mass[1];
        }
    }

    class Triangle : WriteFigure, ICount
    {
        public double perimeter(double[] mass)
        {
            return mass[0] + mass[1] + mass[2];
        }

        public double square(double[] mass)
        {
            return 0.5 * mass[0] * mass[3];
        }
    }

    class Rhombus : WriteFigure, ICount
    {
        public double perimeter(double[] mass)
        {
            return mass[0] * 4;
        }

        public double square(double[] mass)
        {
            return mass[0] * mass[1];
        }
    }

    class Polygon : WriteFigure, ICount
    {
        public double perimeter(double[] mass)
        {
            return mass[0] * mass[1];
        }

        public double square(double[] mass)
        {
            return 0.5 * mass[0] * mass[1] * mass[2];
        }
    }
}
