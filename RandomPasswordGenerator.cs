using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPasswordGenerator_ConsoleApp
{
    public class RandomPasswordGenerator
    {
        // Creating some constant strings of special characters, uppercases, numbers , lowercases
        // which will be picked randomly and put together to generate the random passwords.

        const string SpecialCharacter = @"#()$%^-*=&!_+<>";
        const string Numbers = "0123456789";
        const string Lowercase = "abcdefghijklmnopqrstuvwxyz";
        const string Uppercase = "ABCDEFGHIJKLMOPQRSTUVWXYZ";

        // Creating an array of character to generate random passwords. 

        public string RandomPassword(bool SPECIALCHARACTER, bool NUMBERS, bool LOWERCASE, bool UPPERCASE, int Lengthofpassword)
        {
            char[] password = new char[Lengthofpassword];
            string RPassword = "";
            System.Random random = new Random();
            int i;

            if (SPECIALCHARACTER) RPassword += SpecialCharacter;

            if (NUMBERS) RPassword += Numbers;

            if (LOWERCASE) RPassword += Lowercase;

            if (UPPERCASE) RPassword += Uppercase;

            for (i = 0; i < Lengthofpassword; i++)
            {
                password[i] = RPassword[random.Next(RPassword.Length - 1)];
            }

            return string.Join(null, password);


        }
    }
}
