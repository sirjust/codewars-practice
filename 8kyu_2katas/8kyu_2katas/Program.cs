using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8kyu_2katas
{
    // 1st kata:
    //    Bob is working as a bus driver.However, he has become extremely popular amongst the city's residents. With so many passengers wanting to get aboard his bus, he sometimes has to face the problem of not enough space left on the bus! He wants you to write a simple program telling him if he will be able to fit all the passengers.
    //Task Overview:
    //You have to write a function that accepts three parameters:

    //cap is the amount of people the bus can hold excluding the driver.
    //on is the number of people on the bus.
    //wait is the number of people waiting to get on to the bus.
    //If there is enough space, return 0, and if there isn't, return the number of passengers he can't take.

    //Usage Examples:
    //Kata.Enough(10, 5, 5);
    //    // 0, He can fit all 5 passengers
    //    Kata.Enough(100, 60, 50);
    //// 10, He can't fit 10 out of 50 waiting


        // 2nd kata:
//    Create a function finalGrade, which calculates the final grade of a student depending on two parameters: a grade for the exam and a number of completed projects.

//    This function should take two arguments: exam - grade for exam (from 0 to 100); projects - number of completed projects(from 0 and above);

//    This function should return a number(final grade). There are four types of final grades:

//100, if a grade for the exam is more than 90 or if a number of completed projects more than 10.
//90, if a grade for the exam is more than 75 and if a number of completed projects is minimum 5.
//75, if a grade for the exam is more than 50 and if a number of completed projects is minimum 2.
//0, in other cases
//Examples:

//FinalGrade(100, 12);  // 100
//    FinalGrade(99, 0);    // 100
//    FinalGrade(10, 15);   // 100

//    FinalGrade(85, 5);    // 90

//    FinalGrade(55, 3);    // 75

//    FinalGrade(55, 0);    // 0
//    FinalGrade(20, 2);    // 0

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
