using System;

namespace Laba3Block2
{
    partial class Variant14
    {
        //Виведення данних з data.txt 
        public static void СonsolOutput(Student student, int studsNum)
        {
            Console.WriteLine("\t___Студент №{9}___\n" +
                "Прізвище: {0}\n" +
                "Ім'я: {1}\n" +
                "По батькові: {2}\n" +
                "Стать: {3}\n" +
                "Дата народження: {4}\n" +
                "Оцінка з математики: {5}\n" +
                "Оцінка з фізики: {6}\n" +
                "Оцінка з інформатики: {7}\n" +
                "Стипендія: {8}",
                student.surName, student.firstName, student.patronymic, student.sex, student.dateOfBirth,
                student.mathematicsMark, student.physicsMark, student.informaticsMark, student.scholarship, studsNum);
        }

        //Середній бал кожного студента особисто
        public static double[] CulcGPA(Student[] studs)
        {
            double[] GPA = new double[studs.Length];
            for (int i = 0; i < GPA.Length; i++)
                GPA[i] = (CharToDoubleConverter(studs[i].mathematicsMark)
                    + CharToDoubleConverter(studs[i].physicsMark)
                    + CharToDoubleConverter(studs[i].informaticsMark)) / 3;

            return GPA;
        }

        //Конвертує числа від 0 до 9 з типу char в тип int
        public static double CharToDoubleConverter(char a)
        {
            if (a == '-')
                a = '2';

            double b = a - '0';
            return b;
        }

        //Середній бал всіх студентів
        public static double CulcGeneralGPA(Student[] studs, double[] GPA)
        {
            double generalGPA = 0;
            for (int i = 0; i < GPA.Length; i++)
                generalGPA += GPA[i];
            generalGPA = generalGPA / studs.Length;
            Console.WriteLine("\n______________________________" +
                "\nСередній бал всіх студентів: {0}", generalGPA);
            return generalGPA;
        }

        //Прізвища студентів, середній бал яких більше, ніж загальний середній бал
        public static void ResultVar14(Student[] studs, double[] GPA, double generalGPA)
        {
            Console.WriteLine("Студенти середній бал яких більше, ніж загальний середній бал:");
            for (int i = 0; i < studs.Length; i++)
                if (GPA[i] > generalGPA)
                    Console.WriteLine("___Студент N{0}___\n" +
                        "Прізвище: {1}\n" +
                        "Середній бал: {2}\n", i + 1, studs[i].surName, GPA[i]);
        }
    }
}