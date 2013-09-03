using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Classes
{
    public class TextBoxCorretor
    {
        public static string Corretor(string nome)
        {
            string[] palavras = nome.Split(' ');
            for (int i = 0; i < palavras.Length; i++)
            {
                palavras[i] = palavras[i][0].ToString().ToUpper() + palavras[i].ToLower().Substring(1);
                nome = palavras[0].ToString();
                if ("da de di do das dos".Contains(palavras[i].ToLower()))
                {
                    palavras[i] = palavras[i].ToLower();
                }
            }
            return string.Join(" ", palavras);
        }
    }
}
