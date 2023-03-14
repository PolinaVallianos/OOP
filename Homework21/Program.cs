using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework21;
class Program
{
    static void Main(string[] args)
    {
        MyStruct myStruct1 = new MyStruct();
        myStruct1.Number = 1;
        myStruct1.Description = "Srtucture 1";

        MyStruct myStruct2 = new MyStruct(2);
        myStruct2.Description = "Srtucture 2";

        MyStruct myStruct3 = new MyStruct { Number = 3, Description = "Srtucture 3" };

        MyStruct myStruct4 = myStruct3 with { Description = "Srtucture 4" };

        SetName(ref myStruct1);
        SetName(ref myStruct2);
        SetName(ref myStruct3);
        SetName(ref myStruct4);

        MyClass myClass1 = new MyClass();
        myClass1.Number = 1;

        MyClass myClass2 = new MyClass(2);

        MyClass myClass3 = new MyClass { Number = 3 };

        PrintSorted(new IComparable[] { myStruct1, myStruct2, myStruct3, myStruct4, myClass1, myClass2, myClass3 });

    }



    static void SetName(ref MyStruct myStruct)
    {
        myStruct.Name = $"Struct{myStruct.Number}";
    }

    
    //string void SetName(MyClass[] myClass)
    //{

    //}

    static void PrintSorted(IComparable[] array)
    {
        int maxI = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxI])
            {
                IComparable saved = array[i];
                array[i] = array[maxI];
                array[maxI] = saved;
            }
        }

        foreach (var item in array)
        {
            ((IPrint)item).Print();
        }
    }
}

