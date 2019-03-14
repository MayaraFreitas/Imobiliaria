using System.Text;

namespace Imobi.Domain.Extensions
{
    public static class StringExtension
    {
        // Criptografar string
        public static string ConvertToMD5(this string senha)
        {
            if (string.IsNullOrEmpty(senha))
            {
                return "";
            }

            string password = (senha += "|2d331cca-f6c0-40c0-bb43-6e32989c2881");
            var md5 = System.Security.Cryptography.MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.Default.GetBytes(password));
            var sbString = new StringBuilder();
            foreach (byte t in data)
            {
                sbString.Append(t.ToString("x2"));
            }

            return sbString.ToString();
        }
    }
}
