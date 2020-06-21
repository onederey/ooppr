using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_pr
{
	class Program
	{

		public static double[] array(double[] mas)
		{
			double sred = 0;
			for (int i = 0; i < mas.Length; i++)
			{
				sred += mas[i];
			}

			sred /= mas.Length;

			double max = -double.MaxValue, min = double.MaxValue;
			int maxi = 0, mini = 0;

			for(int i = 0; i < mas.Length; i++)
			{
				if(mas[i] > max)
				{
					max = mas[i];
					maxi = i;
				}
				if (mas[i] < min)
				{
					min = mas[i];
					mini = i;
				}
			}

			if (maxi > mini)
				for (int i = mini+1; i < maxi; i++)
					mas[i] = sred;
			else
				for (int i = maxi+1; i < mini; i++)
					mas[i] = sred;

			return mas;
		}

		static void Main(string[] args)
		{
			double[] arr = { 0.1, 5.4, 7.2, 1.5, 19.2 };

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write("{0} ", arr[i]);
			}

			Console.WriteLine();

			arr = array(arr);

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write("{0} ", arr[i]);
			}

			Console.WriteLine();

		}
	}
}