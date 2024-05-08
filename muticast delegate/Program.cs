using static muticast_delegate.RectangelHelper;

namespace muticast_delegate;

internal class Program
{
    static void Main(string[] args)
    {
        //use delegate 2 time to execute the two functions 
        RectangelHelper.GetArea(10, 20);
        RectangelHelper.getPerimeter(7, 8);

        //use the delegate to refer to two function , then it execute the 2 function when just call once 
        RectangeDelegate rectangeDelegate;
        rectangeDelegate = GetArea;
        rectangeDelegate += getPerimeter;

        //we can subscribe the function many time so it will be executed with the subscribed count , when unsubscribed it ( minus 1 ) from the count not all 
        //rectangeDelegate += getPerimeter;
        //rectangeDelegate += getPerimeter;


        Console.WriteLine("\nrectangle 1 ");
        rectangeDelegate(5, 6);;

        Console.WriteLine("\nrectangle 2");
        rectangeDelegate(10, 4);;

        Console.WriteLine("\nrectangle 3");
        rectangeDelegate(8, 5);;

        Console.WriteLine("\nrectangle 4");
        rectangeDelegate(15, 10);;

        Console.WriteLine("\nrectangle 5");
        rectangeDelegate(4, 12);;

        Console.WriteLine("\nafter unsubscribe  get area ");

        rectangeDelegate -= getPerimeter;
        rectangeDelegate(5, 5);

    }
}