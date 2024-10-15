using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicelayer.cs;

namespace Lab2_Grupp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    public static bool Login()
        {
            int searchID;
            Console.Write("AnvändarID: ");

            // Felsäkring då användarID är en int
            try
            {
                searchID = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Felaktig inmatning. Mata in ett giltigt AnvändarID.");
                return false;
            }

            // Create an instance of Anvandare
            AnvandareRepository anvandareRepository = new AnvandareRepository();

            // Fetch all users
            List<AnvandareData> anvandareLista = anvandareRepository.GetAllAnvandare();

            // Search for the user by ID
            var foundUser = anvandareLista.FirstOrDefault(u => u.AnvandarID == searchID);

            if (foundUser != null)
            {
                // User found, get first and last name
                string firstName = foundUser.Fornamn;
                string lastName = foundUser.Efternamn;

                // Prompt for the password
                Console.Write("Lösenord: ");
                string password = Console.ReadLine();

                // Validate the password
                if (foundUser.Lösenord == password)
                {
                    // Password is correct, user is logged in
                    Console.WriteLine($"{firstName} {lastName} är nu inloggad.");
                    Behörighetsgradinloggad = foundUser.Behörighetsgrad; // Assuming Behörighetsgrad is a property in AnvandareData
                    Meny();
                    return true; // Return true for successful login
                }
                else
                {
                    // Incorrect password
                    Console.WriteLine("Felaktigt lösenord!");
                    return false; // Return false for failed login
                }
            }
            else
            {
                // No user found with the given ID
                Console.WriteLine($"{searchID} hittades inte!");
                return false; // Return false if user not found
            }
        }
        }
    }
}
