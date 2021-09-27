using System.Text;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Linq;

namespace Controlador
{
    public static class ValidacionesClass
    {
        public static string Encrypt(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        public static bool checkEmailAt(string correo)
        {
            return correo.LastIndexOf("@") > -1 ? true : false;
        }

        public static bool hasNumbers(string text)
        {
            string specialChar = @"1234567890";
            foreach (var item in specialChar)
            {
                if (text.Contains(item)) return true;
            }

            return false;
        }
        public static bool hasSpecialChars(string text)
        {
            string specialChar = "-+/= ";
            foreach (var item in specialChar)
            {
                if (text.Contains(item)) return true;
            }
            return false;
        }



    }
}
