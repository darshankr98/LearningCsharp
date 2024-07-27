/*using System;
using System.Reflection;
//-- delegate with no return type
//public delegate void SampleDelegate();

//--delegate with return type
//public delegate int SampleDelegate(); 

//delegate with out param
public delegate void SampleDelegate(out int Params);

public class Sample
{

}
class Program
{
    public static void Main()
    {
        //Type 1 of using MultiCast Delegates
        //SampleDelegate d1,d2,d3,d4;
        // d1 = new SampleDelegate(SampleMethodOne);
        // d2 = new SampleDelegate(SampleMethodTwo);
        // d3 = new SampleDelegate(SampleMethodThree);
        // d4 = d1+d2+d3; //MultiCast Delegate Invocation type 1  ----- to delete a delegate => d4 = d1+d2+d3-d2===> '-d2' deletes delegate d2. 
        // d4();


        //Type 2 of using Multicast delegates
        // SampleDelegate del = new SampleDelegate(SampleMethodOne);
        // del += SampleMethodTwo;        // NOTE :  same Instance 'del' is used to add multiple functions
        // del += SampleMethodThree;
        // del -= SampleMethodTwo; //deletes delegate
        // del();



        // //delegates with return types
        // SampleDelegate del = new SampleDelegate(SampleMethodOne);
        // del += SampleMethodTwo;
        // del += SampleMethodThree;
        // int delegateReturnedValue = del();    // value of last function returned to delegate will be recieved

        // Console.WriteLine($"DelegateReturnedValue is {delegateReturnedValue}");


        //delegates with out param
        SampleDelegate del = new SampleDelegate(SampleMethodOne);
        del += SampleMethodTwo;
        del += SampleMethodThree;
        del(out int Params); //returns the value of last out parameter

        Console.WriteLine($"The output value is : {Params}");  


    }
    public static void SampleMethodOne(out int Params)
    {
        Params = 10;
        //Console.WriteLine("Sample One invoked");
       // return 1;
    }

    public static void SampleMethodTwo(out int Params)
    {
        Params = 20;
        //Console.WriteLine("Sample Two invoked");
        //return 2;
    }
    public static void SampleMethodThree(out int Params)
    {
        Params = 30;
        //return 3;
       // Console.WriteLine("Sample Three invoked");
    }
}*/