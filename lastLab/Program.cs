using MyStack;
namespace Lab3
{
    class Lab
    {
        public static void Main(string[] args)
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("tom");
            stack.Push("Alice");
            stack.Push("ivan");

            Console.WriteLine(stack.Head.Next.Data);
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}