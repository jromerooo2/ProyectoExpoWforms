using System.Text;
using System.Security.Cryptography;

namespace Controlador
{
    public static class ValidacionesClass
    {
        public static string Encrypt(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        public static bool checkEmailAt(string correo)
        {
            return correo.LastIndexOf("@") > -1 ? true : false;
        }
    }
}
