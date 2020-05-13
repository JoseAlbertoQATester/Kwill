using System;
using System.Text;

namespace PunditLeagueAutomation.Domain.Repository
{
    public class Generator
    {
        public string GeneratorString()
        {
            const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder token = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                token.Append(alfabeto[rnd.Next(alfabeto.Length)]);
            }
            return token.ToString();
        }

        public string GenerarNumber()
        {
            Random rnd = new Random();
            return rnd.Next().ToString();
        }

    }
}
