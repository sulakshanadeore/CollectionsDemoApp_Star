using CollectionsLibraryDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        //int[,] arr = new int[4, 5];//Multi-dimensional

        //JaggedDemo();

        StackWorking sw=new StackWorking();
        sw.AddToStack(10);
        sw.AddToStack(20.56f);
        sw.AddToStack('H');
        sw.AddToStack("Welcome");

        sw.Display();
        sw.RemoveFromStack();
        Console.WriteLine("---------------");
        sw.Display();
        Console.WriteLine("---");
        object[] o=sw.ConvertToArray();
        foreach (var item in o)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        object[]  showCopied=sw.CopyAll();
        Console.WriteLine("copied ...");
        foreach (var item in showCopied)
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