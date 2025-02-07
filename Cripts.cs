using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encription_Master_v3._0
{
    public class Cripts
    {
        public string CriptASCII(string texto)
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

        public string DescriptASCII(string texto)
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
    }
}
