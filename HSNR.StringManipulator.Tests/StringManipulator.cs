using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSNR.StringManipulator.Tests
{
    public class StringManipulator
    {
        public string ReverseString(string input)
        {
            //Implementa la inversion de la cadena
            if (input == null) return null; // Manejo de entrada nula
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public string RemoveSpaces(string input)
        {
            //Implementa la eliminacion de espacios en blanco
            if (input == null) return null; // Manejo de entrada nula
            return input.Replace(" ", string.Empty);
        }
    }
}
