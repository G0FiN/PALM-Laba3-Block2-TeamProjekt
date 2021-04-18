using System;

namespace Laba3Block2
{
    class Variant2
    {
        public static void СonsolOutput(Student student)
        {
            Console.WriteLine("------------------------" +
                "\nПрізвище: {0}\n" +
                "Ім'я: {1}\n" +
                "По батькові: {2}\n" +
                "Стать: {3}\n" +
                "Дата народження: {4}\n" +
                "Оцінка з математики: {5}\n" +
                "Оцінка з фізики: {6}\n" +
                "Оцінка з інформатики: {7}\n" +
                "Стипендія: {8}",
                student.surName, student.firstName, student.patronymic, student.sex, student.dateOfBirth,
                student.mathematicsMark, student.physicsMark, student.informaticsMark, student.scholarship);
        }

        public static void Audit(Student student)
        {            
            if ((student.sex == 'M' || student.sex == 'М' || student.sex == 'Ч') &&
                ((student.mathematicsMark == '-') && (student.physicsMark == '-') ||
                 (student.physicsMark == '-') && (student.informaticsMark == '-') ||
                 (student.mathematicsMark == '-') && (student.informaticsMark == '-')))
            {
                СonsolOutput(student);
            }
        }
    }
}