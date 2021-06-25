using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _250621
{
	class Program
	{
		public delegate void CustomDelegate();
		public delegate void AboutNumber(int a);
		public delegate bool Callback(int a);
		static void Main(string[] args)
		{
			#region Generic,Arraylist
			//Generic<int> generic = new Generic<int>();
			//generic.AddElement(0, 10);
			//generic.AddElement(1, 15);
			//generic.AddElement(2, 12);

			//Generic<string> strGeneric = new Generic<string>();
			//strGeneric.AddElement(0, "Qabil");

			//ArrayList arrayList = new ArrayList();
			//arrayList.Add(1);
			//arrayList.Add("Nail");
			//arrayList.Add(generic.arr);
			//arrayList.Add(new int[] { 1, 2, 3, 4, 5 });

			//foreach (var item in arrayList)
			//{
			//	Console.WriteLine(item);
			//}


			//Console.WriteLine();
			//Console.WriteLine();
			//foreach (var item in arrayList)
			//{
			//	Console.WriteLine(item);
			//}
			#endregion

			#region Stack,Queue
			//Stack<int> stack = new Stack<int>();
			//Stack<string> stack1 = new Stack<string>();

			//stack1.Push("test");
			//stack1.Push("Nail");
			//stack1.Push("Cavid");

			//Console.WriteLine(stack1.Peek());

			//stack.Push(1);
			//stack.Push(2);
			//stack.Push(3);
			//stack.Push(4);
			//stack.Clear();

			//int[] test = stack.ToArray();
			//Console.WriteLine(test[0]);


			//Queue<int> queue = new Queue<int>();
			//queue.Enqueue(1);
			//queue.Enqueue(2);
			//queue.Enqueue(3);

			//queue.Dequeue();

			//Console.WriteLine(queue.Peek());
			#endregion

			#region List
			//Student stu1 = new Student() { Id = 1, Name = "Nail" };
			//Student stu2 = new Student() { Id = 2, Name = "Ali" };
			//Student stu3 = new Student() { Id = 4, Name = "Kamil" };
			//Student nar = new Student() { Id = 3, Name = "Nargiz" };


			//List<Student> students = new List<Student>();

			//List<Student> stus = new List<Student>() {
			//	new Student(){ Id = 5, Name="Bill"},
			//	new Student(){ Id = 6, Name="Steve"},
			//	new Student(){ Id = 7, Name="Ram"},
			//	new Student(){ Id = 8, Name="Abdul"}
			//};


			//students.Add(stu1);
			//students.Add(stu2);
			//students.Add(stu3);
			//students.AddRange(stus);

			//students.Insert(2,nar);

			//students.Remove(nar);

			//stus.Clear();
			#endregion
			//foreach (Student stu in students)
			//{
			//	Console.WriteLine(stu);
			//}

			//foreach (var item in stus)
			//{
			//	Console.WriteLine(item);
			//}

			//Predicate<int> pre = n => n > 2;

			//Console.WriteLine(pre(11));

			//CustomDelegate custom = () => Console.WriteLine("World");

			//CustomDelegate custom1 = delegate ()
			//{
			//	Console.WriteLine("Hello");
			//};
			//custom.Invoke();


			//custom1.Invoke();

			//custom += custom1;

			//custom.Invoke();

			//AboutNumber about = IsEvenOrOdd;

			//about += IsGreater;

			//about.Invoke(82);




			//Sum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 },IsEven);
			//Sum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 },IsOdd);
			//Sum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8,20 },IsBigger);



		}

		//public static void IsEvenOrOdd(int a )
		//{
		//	string result = a % 2 == 0 ? "Even" : "Odd";
		//	Console.WriteLine(result);
		//}

		//public static void IsGreater(int n)
		//{
		//	Console.WriteLine($"{n} is {(n>50 ? "bigger" : "smaller")} than 50");
		//}

		//public static void Sum(int[] arr,Callback func)
		//{
		//	int result = 0;

		//	foreach (int number in arr)
		//	{
		//		if(func(number))
		//		{
		//			result += number;
		//		}
		//	}

		//	Console.WriteLine(result);

		//}


		//public static bool IsEven(int a)
		//{
		//	return a % 2 == 0;
		//}
		//public static bool IsOdd(int a)
		//{
		//	return a % 2 != 0;
		//}

		//public static bool IsBigger(int a)
		//{
		//	return a > 15;
		//}
	}
}
