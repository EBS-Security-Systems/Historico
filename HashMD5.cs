using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encript_Master_v2._0
{
    public class HashMD5
    {
        public string Criptografar(string texto)
        {
            try
            {
                MD5 hashMD5 = MD5.Create();
                byte[] valorCriptografado = hashMD5.ComputeHash(Encoding.Default.GetBytes(texto));
                StringBuilder strbuilder = new StringBuilder();
                for (int i = 0; i < valorCriptografado.Length; i++)
                {
                    strbuilder.Append(valorCriptografado[i].ToString("X2"));
                }
                return strbuilder.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string MultiEncodHashMD5(string texto, string valueCript)
        {
            try
            {
                MD5 hashMD5 = MD5.Create();

                byte[] valorCriptografado = hashMD5.ComputeHash(Encoding.Default.GetBytes(texto));
                StringBuilder strbuilder = new StringBuilder();

                for (int i = 0; i < valorCriptografado.Length; i++)
                {
                    strbuilder.Append(valorCriptografado[i].ToString("X" + Convert.ToString(valueCript)));
                }

                return strbuilder.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
