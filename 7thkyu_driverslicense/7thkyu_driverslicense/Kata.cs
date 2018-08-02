using System;
using System.Collections.Generic;
using System.Text;

namespace _7thkyu_driverslicense
{
    class Kata
    {
        public static string Driver(params string[] data)
        {
            // digits [0] - [4]
            char[] licenseNumber = new char[16];
            char[] surname = data[2].ToUpper().ToCharArray();
            char[] newSurname = new char[5] { (char)57, (char)57, (char)57, (char)57, (char)57 };
            for(int i = 0; i < surname.Length; i++)
            {
                newSurname[i] = surname[i];
            }
            for (int i = 0; i < 5; i++)
            {
                licenseNumber[i] = newSurname[i];
            }
            // digit [5]
            string[] extractMonth = data[3].Split('-');
            // in the preceding line i had quotation marks. it worked here but in codewars it couldn't split
            string year = extractMonth[2];
            char[] charYear = year.ToCharArray();
            licenseNumber[5] = charYear[2];
            // digits [6] and [7] month of birth, converted to numbers and if female add 6 to first digit
            string month = extractMonth[1];
            int licenseMonth = 0;
            if (month == "Jan" || month == "January")
            {
                licenseMonth = 1;
            }
            else if (month == "Feb" || month == "February")
            {
                licenseMonth = 2;
            }
            else if (month == "Mar" || month == "March")
            {
                licenseMonth = 3;
            }
            else if (month == "Apr" || month == "April")
            {
                licenseMonth = 4;
            }
            else if (month == "May")
            {
                licenseMonth = 5;
            }
            else if (month == "Jun" || month == "June")
            {
                licenseMonth = 6;
            }
            else if (month == "Jul" || month == "July")
            {
                licenseMonth = 7;
            }
            else if (month == "Aug" || month == "August")
            {
                licenseMonth = 8;
            }
            else if (month == "Sep" || month == "September")
            {
                licenseMonth = 9;
            }
            else if (month == "Oct" || month == "October")
            {
                licenseMonth = 10;
            }
            else if (month == "Nov" || month == "November")
            {
                licenseMonth = 11;
            }
            else if (month == "Dec" || month == "December")
            {
                licenseMonth = 12;
            }
            if (data[4] == "F")
            {
                licenseMonth = licenseMonth + 50;
            }
            if (licenseMonth < 10)
            {
                licenseNumber[6] = '0';
                licenseNumber[7] = (char)(licenseMonth + 48);
            }
            else
            {
                string monthString = licenseMonth.ToString();
                char[] monthChars = monthString.ToCharArray();
                licenseNumber[6] = monthChars[0];
                licenseNumber[7] = monthChars[1];
            }
            // digits [8] and [9]
            string date = extractMonth[0];
            char[] charDate = date.ToCharArray();
            licenseNumber[8] = charDate[0];
            licenseNumber[9] = charDate[1];
            // digit [10] year digit from year of birth
            licenseNumber[10] = charYear[3];
            // digits [11] and [12] first initials of first and middle name, 9 if no middle name
            char[] firstName = data[0].ToCharArray();
            licenseNumber[11] = firstName[0];
            if (data[1] == "")
            {
                licenseNumber[12] = '9';
            }
            else
            {
                char[] middleName = data[1].ToCharArray();
                licenseNumber[12] = middleName[0];
            }
            // digit [13]
            licenseNumber[13] = '9';
            // digits [14] and [15]
            licenseNumber[14] = 'A';
            licenseNumber[15] = 'A';
            string answer = new string(licenseNumber);
            return answer;
        }
    }
}
