using System;

namespace Laba3Block2
{
	struct Student
	{
		public string surName;
		public string firstName;
		public string patronymic;
		public char sex;
		public string dateOfBirth;
		public char mathematicsMark;
		public char physicsMark;
		public char informaticsMark;
		public int scholarship;

		public Student(string LineWithAllData)
		{
			string[] dataSplitted = LineWithAllData.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			surName = dataSplitted[0];
			firstName = dataSplitted[1];
			patronymic = dataSplitted[2];
			sex = Convert.ToChar(dataSplitted[3]);
			dateOfBirth = dataSplitted[4];
			mathematicsMark = Convert.ToChar(dataSplitted[5]);
			physicsMark = Convert.ToChar(dataSplitted[6]);
			informaticsMark = Convert.ToChar(dataSplitted[7]);
			scholarship = Convert.ToInt32(dataSplitted[8]);
		}
	}
}
