namespace DelegateFunction;

internal class Program
{
    //custom delegate 
    // delegate void MDelegate();
    static void Main(string[] args)
    {
        M1();
        M2(M1);
    }
    static void M1() =>
        Console.WriteLine("method 1");
    //static void M2(MDelegate mDelegate)
    //{
    //    //two ways to execute function 
    //    mDelegate.Invoke();
    //    mDelegate();
    //    Console.WriteLine("\nMethod 2");
    //}

    //built in delegate 
    //Action : has no parameter , has no return type (void )
    static void M2(Action mDelegate)
    {
        //two ways to execute function 
        mDelegate.Invoke();
        mDelegate();
        Console.WriteLine("\nMethod 2");
    }
}