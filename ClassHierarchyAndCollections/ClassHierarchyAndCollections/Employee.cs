using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHeirarchy
{
	public class Employee : Individual
	{
		public double HourlyWage { get; set; }
		public int EmployeeID { get; set; }

		public interface IEmployee
		{
			void DepositToBank();
		}

	}
}
