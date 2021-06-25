using System;
using System.Collections.Generic;
using System.Text;

namespace _250621
{
	class Generic<T>
	{
		public T[] arr = new T[20];

		public void AddElement(int index,T element)
		{
			arr[index] = element;
		}
	}
}
