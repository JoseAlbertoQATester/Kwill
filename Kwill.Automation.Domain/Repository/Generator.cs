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

        public int GenerarNumber(int min,int max)
        {
            Random rnd = new Random();
            return rnd.Next(min,max);
        }

    }
}
