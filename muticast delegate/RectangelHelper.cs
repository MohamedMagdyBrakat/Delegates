namespace muticast_delegate;

public class RectangelHelper
{
    public delegate void RectangeDelegate(dynamic high, dynamic width);
    public static void GetArea(dynamic high, dynamic width)
    {
        dynamic area = high * width;
        Console.WriteLine($"Area = {high} * {width} = {area}");
    }

    public static void getPerimeter(dynamic high, dynamic width)
    {
        dynamic perimeter = 2 * ( high + width);
        Console.WriteLine($"Perimeter = 2 * ( {high} + {width} ) = {perimeter }");
    }
}
