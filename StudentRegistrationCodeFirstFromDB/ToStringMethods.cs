using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationCodeFirstFromDB
{
	/// <summary>
	/// For debugging
	/// </summary>
	partial class Student
	{
		public override string ToString()
		{
			return StudentId + ": " + StudentFirstName + " " + StudentLastName + " " + Department.DepartmentCode;
		}
	}

	/// <summary>
	/// For debugging
	/// </summary>
	/// <returns></returns>
	partial class Cours
	{
		public override string ToString()
		{
			return CourseId + ": " + CourseNumber + " " + Department.DepartmentCode;
		}
	}

	/// <summary>
	/// For debugging
	/// </summary>
	/// <returns></returns>
	partial class Department
	{
		public override string ToString()
		{
			return DepartmentId + ": " + DepartmentCode + " " + DepartmentName;
		}
	}
}
