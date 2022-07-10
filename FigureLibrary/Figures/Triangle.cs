namespace FigureLibrary {
    //
    // Сводка:
    //     Provides a triangle and methods for working with it.
    public class Triangle : Figure
    {
        //
        // Сводка:
        //     Represents the side of triangle A in a double format.
        public double A { get; }
        //
        // Сводка:
        //     Represents the side of triangle B in a double format.
        public double B { get; }
        //
        // Сводка:
        //     Represents the side of triangle C in a double format.
        public double C { get; }


        //
        // Сводка:
        //     Returns a new instance of the Triangle class through an integer or double sides A, B and C.
        //
        // Параметры:
        //   a:
        //     An integer or a double number that defines the side A of the triangle being created
        //   b:
        //     An integer or a double number that defines the side B of the triangle being created
        //   c:
        //     An integer or a double number that defines the side C of the triangle being created
        //
        // Возврат:
        //     A new instance of the Triangle class with the specified sides.
        public Triangle(double a, double b, double c)
        {
            if (a + b < c || a + c < b || b + c < a || a < 0 || b < 0 || c < 0)
                throw new ArgumentException("A triangle with such sides does not exist.");
            A = a;
            B = b;
            C = c;
        }


        //
        // Сводка:
        //     Returns a boolean value that characterizes whether a given triangle is rectangular.
        //
        // Возврат:
        //     A boolean value that is the answer to the question whether a given triangle is rectangular.
        public bool isRectangular() =>
            A * A + B * B == C * C || A * A + C * C == B * B || B * B + C * C == A * A;


        //
        // Сводка:
        //     Returns the area of the triangle according to the specified A, B and C sides.
        //
        // Возврат:
        //     The area of the triangle in m^2, a number in double format.
        public override double CalculateArea()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
