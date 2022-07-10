namespace FigureLibrary
{
    //
    // Сводка:
    //     Defines common methods for working with different types of figures.
    internal interface IFigure
    {
        //
        // Сводка:
        //     calculates the area of a figure in double format according to the definition
        //     of the area of a particular figure.
        //
        // Возврат:
        //     A value in double format that characterizes the area of the figure in m^2.
        //     The implementation depends on the specific type of shape.
        public abstract double CalculateArea();
    }
}
