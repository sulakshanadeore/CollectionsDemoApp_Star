using System.Collections;

namespace CollectionsLibraryDemo
{
    public class StackWorking
    {

        static Stack s=new Stack();

        static StackWorking()
        {
            s.Push(100);
            s.Push(200);
            s.Push(300);
        
        }

        public void AddToStack(object o)
        { 
        s.Push(o);
        }

        public object[] ConvertToArray()
        {
            object[] obj=s.ToArray();
            
            return obj;

        }


        public object[] CopyAll()
        {
            object[] o=new object[s.Count];
            s.CopyTo(o, 0);
            return o;
        }




        public void RemoveFromStack()
        {
            s.Pop();
        }

        public void Display()
        {
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }

    }
}
