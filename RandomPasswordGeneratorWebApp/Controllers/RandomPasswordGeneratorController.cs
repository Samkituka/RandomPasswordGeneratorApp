using Microsoft.AspNetCore.Mvc;
using RandomPasswordGeneratorWebApp.Models;


namespace RandomPasswordGeneratorWebApp.Controllers
{
    public class RandomPasswordGeneratorController : Controller
    {
        //Create an instance of the model
        private RandomPasswordModels randompasswordModels = new RandomPasswordModels();

        public IActionResult Index()
        {
            return View(randompasswordModels);
        }
        public IActionResult RandomPassword(int length, bool UPPERCASE, bool SPECIALCHARACTER)
        {
            const string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string DefaultPassword = "abcdefghijklmnopqrstuvwxyz01234567899876543210";
            const string SpecialCharacter = "@\"#()$%.?[]{}^-*=&!_+<>\"";

            string password = "";
            string RandomPassword = "";

            if (UPPERCASE && SPECIALCHARACTER)
            {
                password = DefaultPassword + Uppercase + SpecialCharacter;
            }
            
            else if (SPECIALCHARACTER)
            {
                password = DefaultPassword + SpecialCharacter;
            }

            else if (UPPERCASE)
            {
                password = DefaultPassword + Uppercase;
            }

            else
            {
                password = DefaultPassword;
            }
                        
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                char letter = password[random.Next(0, password.Length)];
                RandomPassword += letter;
            }
            randompasswordModels.RPassword = RandomPassword;
            return View("Index", randompasswordModels);

        }
    }
}
