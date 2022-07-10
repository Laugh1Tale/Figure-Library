namespace FigureLibrary
{
    //
    // Сводка:
    //     Provides a circle and methods for working with it.
    public class Circle : Figure
    {
        //
        // Сводка:
        //     Represents the radius of the circle in double format.
        public double Radius { get; }


        //
        // Сводка:
        //     Returns a new instance of the Circle class through an integer or double radius.
        //
        // Параметры:
        //   radius:
        //     An integer or double number that defines the radius of the circle being created.
        //
        // Возврат:
        //     A new instance of the Сircle class with the specified radius.
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("A Circle with such radius does not exist.");
            Radius = radius;
        }


        //
        // Сводка:
        //     Returns the area of the circle according to the specified radius.
        //
        // Возврат:
        //     The area of the circle in m^2, a number in double format.
        public override double CalculateArea() => Math.PI * Radius * Radius;
    }
}