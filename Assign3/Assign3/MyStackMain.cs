using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
    internal class MyStackMain
    {
		static void Main()
		{
			MyStack myStack = new MyStack();

			myStack.Push(10);
			myStack.Push(20);
			myStack.Push(30);
			myStack.Push(40);
			myStack.PrintStack();
			myStack.Peek();



			Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
			myStack.Pop();
			myStack.Pop();
			myStack.Pop();


			myStack.PrintStack();
			Console.ReadLine();
		}

	}
}
