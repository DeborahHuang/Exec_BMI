using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_BMI
{//計算BMI
	internal class Program
	{
		static void Main(string[] args)
		{
			double height = 160;
			double weight = 52;
			double BMI = weight / Math.Pow((height / 100),2);
			Console.WriteLine(BMI);
		}
	}
}
