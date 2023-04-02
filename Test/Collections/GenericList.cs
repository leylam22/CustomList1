using System.Diagnostics.Metrics;
using System.Drawing;
using Test.Interface;

namespace Test.Collections;

public class GenericList<T, L> 
{
    private T[] array;

	public GenericList()
	{
		array= new T[0];
	}

	public void Add(T str)
	{
		Array.Resize(ref array, array.Length+1);
		array[array.Length-1]= str;
	}

	public T GetIndex(int index)
	{
		return array[index];
	}

	public void AddRange(IEnumerable<T> collectiions)
	{
		foreach (T item in collectiions)
		{
			Add(item);
		}
	}

    public void Clear()
	{
		for (int i = 0; i < array.Length; i++)
		{
			//int count = 0;
			//array[i] = default;
			array[i].Equals(null);
		}
	}

	public bool Contains(T item)
	{
		return array.Contains(item);
	}

	public void Reverse()
    {
		int i = 0;
        int j = array.Length - 1;
        while (i < j)
        {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
    }

	public bool Remove(T item)
	{
		for (int i = 0; i < array.Length; i++)
		{
			if (item.Equals(array[i]))
			{
				array[i] = default; return true;
			}
		}
		return false;
	}

    public bool Exist(Predicate<T> predicate)
	{
		for (int i = 0; i < array.Length; i++)
		{
			if (predicate(array[i]))
			{
				return true;
			}
		}
		return false;
	}
	
	public void Sort(Comparison<T> comparison)
	{
		if (comparison==null)
		{
			Array.Sort(array, 0, array.Length);
		}
	}


}
