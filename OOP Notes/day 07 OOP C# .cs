using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp7
{
    #region Generic2
    //class Build_Arr
    //{
		
    //    public int[] Arr { get; set; }
    //    public int item { get; set; }
    //    public Build_Arr(int size)
    //    {
    //        Arr = new int[size];
    //    }
    //    public void Add(int item)
    //    {
    //        Arr[item] = item;
    //        item++;
    //    }
    //    public void display()
    //    {
    //        foreach (int item in Arr)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}
    //class Build_Array<t>
    //{
    //    public t[] Arr { get; set; }
    //    public int item { get; set; }

    //    public Build_Array(int size)
    //    {
    //        Arr = new t[size];
    //        item = 0;
    //    }

    //    public void Add(t item)
    //    {
    //        Arr[item] = item;
    //        item++;
    //    }

    //    public void display()
    //    {
    //        for (int item = 0; item < this.item; item++)
    //        {
    //            Console.WriteLine(Arr[item]);
    //        }
    //    }
    //}
    //class Operation
    //{
    //    public static void Swap<t>(ref t One, ref t Two)
    //    {
    //        t temp = One;
    //        One = Two;
    //        Two = temp;
    //    }
    //} 
    #endregion
    #region Generic.Collection
    ////class student
    ////{
    ////    public int id { get; set; }
    ////    public string name { get; set; }
    ////    public int age { get; set; }
    ////    public student(int _id = 0, string _name = null, int _age = 0)
    ////    {
    ////        this.id = _id;
    ////        this.name = _name;
    ////        this.age = _age;
    ////    }

    ////    public string getString()
    ////    {
    ////        return $"{id}\t{name.PadRight(15)}\t{age} Years Old";
    ////    }
    ////    public override string ToString()
    ////    {
    ////        return $"{id}\t{name.PadRight(15)}\t{age} Years Old";
    ////    }

    ////    public override bool Equals(object? S1)
    ////    {
    ////        student s = (student)S1;
    ////        return (id == s.id && name == s.name && age == s.age);
    ////    }

    ////}
    #endregion
    enum gender
    {
        //enum is Value DataType
        male, female
    }
    enum Prev : byte
    {
        admin=10,
        supervisoer,//11 by Defulat
        DataBase_Design=15,
        DataBase_Developer,//16 by Defulat
        Web_Developer,
        student

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic 
            //Build_Array<string> Obj1 = new Build_Array<string>(5);
            //Obj1.Add("Ashraf");
            //Obj1.Add("Ashraf");
            //Obj1.Add("Ashraf");
            //Obj1.Add("Ashraf");
            //Obj1.Add("Ashraf");


            //Build_Array<int> Obj2 = new Build_Array<int>(5);
            //Obj2.Add(1);
            //Obj2.Add(1);
            //Obj2.Add(1);
            //Obj2.Add(1);
            //Obj2.Add(1);

            //Obj1.display();
            //Console.WriteLine();
            //Obj2.display(); 

            //string one = "Ashraf";
            //string two = "Ahmmed";

            //Operation.Swap<string>(ref one, ref two);
            //Console.WriteLine(one);
            //Console.WriteLine(two);

            //int onee = 25;
            //int twoo = 26;

            //Operation.Swap<int>(ref onee, ref twoo);
            //Console.WriteLine(onee);
            //Console.WriteLine(twoo);

            #endregion

            #region Generic.Collection
            ////int[] Arr = new int[] { 10, 20, 30, 40, 50, 60 };

            ////List<int> lst1 = new List<int>();
            ////lst1.Add(1);
            ////lst1.Add(2);
            ////lst1.Add(3);
            ////lst1.AddRange(Arr);

            //////foreach (int item in lst1)
            //////{
            //////    Console.WriteLine(item);
            //////}

            ////for (int i = 0;i != lst1.Count;i++)
            ////{
            ////    Console.WriteLine(lst1[i]);
            ////}

            ////lst1.Remove(1);
            ////lst1.RemoveAt(0);
            ////lst1.RemoveRange(0, lst1.Count);


            ////Dictionary<string, string> dic = new Dictionary<string, string>();

            ////dic.Add("Ahmed1", "Adderess 1 ");
            ////dic.Add("Ahmed2", "Adderess 1 ");
            ////dic.Add("Ahmed3", "Adderess 1 ");
            ////dic.Add("Ahmed4", "Adderess 1 ");
            //////Key -> Must Be Uniqe 
            ////dic["Ashraf"] = "Adderess 2";

            //////dic.Remove("Ashraf");

            ////foreach (KeyValuePair<string, string> item in dic)
            ////{
            ////    Console.WriteLine($"{item.Key}\t{item.Value}");
            ////}
            ///


            ////List<student> BI_Std = new List<student>()
            ////{
            ////new student(1,"Ashraf",22),
            ////new student(2,"Ahmed",21),
            ////new student(3,"Sara",19),
            ////new student(4,"Abdelrahman",18),
            ////new student(5,"Nour",16)
            ////};

            ////List<student> dotNET_Std = new List<student>()
            ////{
            ////new student(1,"Ashraf",22),
            ////new student(2,"Ahmed",21),
            ////new student(3,"Sara",19),
            ////new student(4,"Abdelrahman",18),
            ////new student(5,"Nour",16)
            ////};

            ////Dictionary<string, List<student>> DIC = new Dictionary<string, List<student>>();
            ////DIC.Add("BI Students", BI_Std);
            ////DIC.Add("dotNET Students", dotNET_Std);


            ////foreach (KeyValuePair<string, List<student>> item in DIC)
            ////{
            ////    Console.WriteLine("\n"+item.Key+"\n");
            ////    foreach (student Item2 in item.Value)
            ////    {
            ////        Console.WriteLine(Item2.getString());
            ////    }
            ////}

            #endregion

            #region system.Object
            /////////Boxing Vs UnBoxing


            ////object o = 1;

            ////int x = (int)o;// unboxing

            ////object z = x;//Boxing

            ////Console.WriteLine(o);
            ////Console.WriteLine(z);
            ///

            //student s1 = new student(1, "Ashraf Gad", 22);
            //student s2 = new student(1, "Ashraf Gad", 22);
            //student s3 = new student(2, "Ahmeed Gad", 22);

            //////Console.WriteLine(s1.ToString());//important
            //////Console.WriteLine(s1.getString());


            //if (s1.Equals(s3))
            //{
            //    Console.WriteLine(  "EQIALS.....");
            //}
            //else
            //{
            //    Console.WriteLine("NOT EQIALS.....");
            //}


            #endregion

            #region Enum 



            gender g = gender.male;
            Console.WriteLine(g);
            #endregion

        }
    }
}