using CollectionsLibraryDemo;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //int[,] arr = new int[4, 5];//Multi-dimensional

        //JaggedDemo();

        //StackWorking sw=new StackWorking();
        //sw.AddToStack(10);
        //sw.AddToStack(20.56f);
        //sw.AddToStack('H');
        //sw.AddToStack("Welcome");

        //sw.Display();
        //sw.RemoveFromStack();
        //Console.WriteLine("---------------");
        //sw.Display();
        //Console.WriteLine("---");
        //object[] o=sw.ConvertToArray();
        //foreach (var item in o)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine();
        //object[]  showCopied=sw.CopyAll();
        //Console.WriteLine("copied ...");
        //foreach (var item in showCopied)
        //{
        //    Console.WriteLine(item);
        //}


        BitArray rooms = new BitArray(5);
        //true means lights on
        rooms[0] = true;
        rooms[1] = true;
        rooms[2] = false;
        rooms[3] = true;
        rooms[4] = false;

        foreach (var item in rooms)
        {
            Console.WriteLine(item);
        }

        BitArray rooms2 = new BitArray(5); 
        rooms2[0] = false;
        rooms.And(rooms2);

        //rooms.Xor(rooms);
        rooms.And(rooms);
        Console.WriteLine("after and");
        Console.WriteLine();
        foreach (var item in rooms)
        {
            Console.WriteLine(item);
        }

    }

    private static void JaggedDemo()
    {
        int[][] studmarksJagged = new int[3][];

        studmarksJagged[0] = new int[4] { 40, 50, 60, 70 };
        studmarksJagged[1] = new int[3] { 50, 60, 70 };
        studmarksJagged[2] = new int[7] { 50, 60, 70, 80, 90, 80, 90 };

        int i = 0;
        foreach (var item in studmarksJagged)
        {

            string rowval = i.ToString();
            Console.WriteLine(rowval + " Row");
            foreach (var item1 in item)
            {
                Console.Write(item1 + "\t");
            }
            i++;
            Console.WriteLine();
        }
    }
}