using System.Security.Cryptography;
using System.Text;

namespace ATM.Util
{
    public abstract class HashUtil
    {
        public string computeHash(string pin)
        {
            using (SHA256 SHA =  SHA256.Create())
            {
                //Computing a Hash byte hash
                byte[] tmpHash = SHA.ComputeHash(Encoding.UTF8.GetBytes(pin));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < tmpHash.Length; i++)
                {
                    builder.Append(tmpHash[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool comparePin(string pin)
        {
            using (SHA256 SHA = SHA256.Create())
            {
                byte[] tmpHash = SHA.ComputeHash(Encoding.UTF8.GetBytes(pin));
            }
        }

    }
}