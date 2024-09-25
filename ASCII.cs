using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encript_Master_v2._0
{
    public class ASCII
    {
        public string Criptografar(string texto)
        {
            try
            {
                byte[] textoBinario = ASCIIEncoding.ASCII.GetBytes(texto);
                string textoCript = Convert.ToBase64String(textoBinario);
                return textoCript;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public string Descriptografar(string texto)
        {
            try
            {
                byte[] textoCript = Convert.FromBase64String(texto);
                string textoBinario = ASCIIEncoding.ASCII.GetString(textoCript);
                return textoBinario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /*public string MultiCriptASCII(string texto, string quant)
        {
            try
            {
                int quanti= Convert.ToInt32(quant);
                for (int i = 0; i < quanti; i ++)
                {
                    byte[] textoBinario = ASCIIEncoding.ASCII.GetBytes(texto);
                    string textoCript = Convert.ToBase64String(textoBinario);
                }

                return textoCript;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }*/
    }
}
