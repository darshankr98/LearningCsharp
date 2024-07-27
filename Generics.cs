using System;

class GenericTest
{
    public static void Main()
    {
        //bool Isequal = Compare(10,15);       // this is for non generic comparision


        // Usage Generics in C# and note that 'object' can also be used for this but because of boxing and unboxing it is not an efficient way.
        //As all the data types in C# inherit from System.Object class they can be referred using 'object' data type.
        //In the below line a method has been made generic, note that even a class can also be made generic

        bool Isequal = GenericTest.Compare<string>("A","A");

        //class being made generic
        CompareClass<int>.Compare(10,20);


        if(Isequal)
        {
            Console.WriteLine("Both A & B are equal");
        }
        else
        {
            Console.WriteLine("Both A & B are not equal");
        }
    }

    // public static bool Compare(int a, int b)    // For Non Generic Usage
    // {
    //     return a==b;
    // }



// For Generic Usage (Generic method)
    public static bool Compare<T>(T a, T b)    
    {
         //return a==b; //a==b only works for non generic data type

         return a.Equals(b);
     }

}


// Class being made generic
public class CompareClass<T>
{
    public static bool Compare(T a, T b)    
    {
         //return a==b; //a==b only works for non generic data type

         return a.Equals(b);
     }
}