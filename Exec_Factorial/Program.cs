using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_Factorial
			//計算數值的階層

			//欲計算該數字的階層:
			Console.Write("請輸入數字: ");
			int number = Convert.ToInt32(Console.ReadLine());
			
			//確保輸入數字為非負整數
			if (number < 0)
			{
				Console.WriteLine("請輸入大於零的數字。");
				return;
			}

			//宣告階層初始值
			int factorial = 1;

			//計算階層
			for (int i = 1; i <= number; i++)
			{
				factorial *= i;
			}
			Console.WriteLine(factorial);
		}
	}
}
