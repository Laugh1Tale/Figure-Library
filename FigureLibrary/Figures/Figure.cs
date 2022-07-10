namespace FigureLibrary
{
    //
    // Сводка:
    //     Provides a general figure and methods for working with it.
    public abstract class Figure : IFigure
    {
        //
        // Сводка:
        //     Returns the area of a figure according to the area formula of a specific figure.
        //
        // Возврат:
        //     The area of the figure in m^2, a number in double format.
        public abstract double CalculateArea();


        //
        // Сводка:
        //     Compares the current instance's area with another figure's area and returns
        //     an integer that indicates whether the current instance precedes, follows, or
        //     occurs in the same position in the sort order as the other object.
        //
        // Параметры:
        //   figure:
        //     A figure to compare with this instance.
        //
        // Возврат:
        //     A value that indicates the relative order of the objects being compared. The
        //     return value has these meanings:
        //     Value – Meaning
        //     Less than zero – This instance's area precedes figure's area in the sort order.
        //     Zero – This instance's area occurs in the same position in the sort order as figure's area.
        //     Greater than zero – This instance's area follows figure's area in the sort order.
        public int CompareAreaTo(Figure figure) => Math.Round(CalculateArea(), 13).CompareTo(Math.Round(figure.CalculateArea(), 13));
    }
}
