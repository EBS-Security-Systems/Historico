using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Encription_Creator
{
    public class Cripts
    {
        #region Files
        //https://www.youtube.com/watch?v=NLNM5SalEOc
        public void Salvar(string texto, string caminho)
        {
            StreamWriter STW = new StreamWriter(caminho);
            STW.WriteLine(texto);
            STW.Close();
        }
        public string Abrir(string caminho)
        {
            try
            {
                StreamReader STR = new StreamReader(caminho);
                string texto = STR.ReadToEnd();
                STR.Close();
                return texto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Morse
        public string EncriptMoorse(string text)
        {
            string textEncripted = text
            #region Alfabeto
                .Replace("A", "{.-}").Replace("a", "[.-]").Replace("B", "{-...}").Replace("b", "[-...]")
                .Replace("C", "{-.-.}").Replace("c", "[-.-.]").Replace("D", "{-..}").Replace("d", "[-..]").Replace("E", "{.}").Replace("e", "[.]")
                .Replace("F", "{..-.}").Replace("f", "[..-.]").Replace("G", "{--.}").Replace("g", "[--.]").Replace("H", "{....}").Replace("h", "[....]")
                .Replace("I", "{..}").Replace("i", "[..]").Replace("J", "{.---}").Replace("j", "[.---]").Replace("K", "{-.-}").Replace("k", "[-.-]")
                .Replace("L", "{.-..}").Replace("l", "[.-..]").Replace("M", "{--}").Replace("m", "[--]").Replace("N", "{-.}").Replace("n", "[-.]")
                .Replace("O", "{---}").Replace("o", "[---]").Replace("P", "{.--.}").Replace("p", "[.--.]").Replace("Q", "{--.-}").Replace("q", "[--.-]")
                .Replace("R", "{.-.}").Replace("r", "[.-.]").Replace("S", "{...}").Replace("s", "[...]").Replace("T", "{-}").Replace("t", "[-]")
                .Replace("U", "{..-}").Replace("u", "[..-]").Replace("V", "{...-}").Replace("v", "[...-]").Replace("W", "{.--}").Replace("w", "[.--]")
                .Replace("X", "{-..-}").Replace("x", "[-..-]").Replace("Y", "{-.--}").Replace("y", "[-.--]").Replace("Z", "{--..}").Replace("z", "[--..]")
            #endregion
            #region Numeros
                .Replace("0", " ----- ").Replace("1", " .---- ").Replace("2", " ..--- ").Replace("3", " ...-- ").Replace("4", " ....- ").Replace("5", " ..... ")
                .Replace("6", " -.... ").Replace("7", " --... ").Replace("8", " ---.. ").Replace("9", " ----. ");
            #endregion
            return textEncripted;
        }
        public string DescriptMoorse(string textEncripted)
        {
            string textDescripted = textEncripted
            #region Alfabeto
                .Replace("{.-}", "A").Replace("[.-]", "a").Replace("{-...}", "B").Replace("[-...]", "b")
                .Replace("{-.-.}", "C").Replace("[-.-.]", "c").Replace("{-..}", "D").Replace("[-..]", "d").Replace("{.}", "E").Replace("[.]", "e")
                .Replace("{..-.}", "F").Replace("[..-.]", "f").Replace("{--.}", "G").Replace("[--.]", "g").Replace("{....}", "H").Replace("[....]", "h")
                .Replace("{..}", "I").Replace("[..]", "i").Replace("{.---}", "J").Replace("[.---]", "j").Replace("{-.-}", "K").Replace("[-.-]", "k")
                .Replace("{.-..}", "L").Replace("[.-..]", "l").Replace("{--}", "M").Replace("[--]", "m").Replace("{-.}", "N").Replace("[-.]", "n")
                .Replace("{---}", "O").Replace("[---]", "o").Replace("{.--.}", "P").Replace("[.--.]", "p").Replace("{--.-}", "Q").Replace("[--.-]", "q")
                .Replace("{.-.}", "R").Replace("[.-.]", "r").Replace("{...}", "S").Replace("[...]", "s").Replace("{-}", "T").Replace("[-]", "t")
                .Replace("{..-}", "U").Replace("[..-]", "u").Replace("{...-}", "V").Replace("[...-]", "v").Replace("{.--}", "W").Replace("[.--]", "w")
                .Replace("{-..-}", "X").Replace("[-..-]", "x").Replace("{-.--}", "Y").Replace("[-.--]", "y").Replace("{--..}", "Z").Replace("[--..]", "z")
            #endregion
            #region Numeros
                .Replace(" ----- ", "0").Replace(" .---- ", "1").Replace(" ..--- ", "2").Replace(" ...-- ", "3").Replace(" ....- ", "4").Replace(" ..... ", "5")
                .Replace(" -.... ", "6").Replace(" --... ", "7").Replace(" ---.. ", "8").Replace(" ----. ", "9");
            #endregion
            return textDescripted;
        }
        #endregion
        #region Codificações
        //https://marquesfernandes.com/self/o-que-e-base64-para-que-serve-e-como-funciona/
        #region ASCII
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
        #endregion  
        #region ANSI
        public string CriptANSI(string texto)
        {
            try
            {
                byte[] textoBinario = Encoding.Default.GetBytes(texto);
                string textoCript = Convert.ToBase64String(textoBinario);
                return textoCript;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public string DescriptANSI(string texto)
        {
            try
            {
                byte[] textoCript = Convert.FromBase64String(texto);
                string textoBinario = Encoding.Default.GetString(textoCript);
                return textoBinario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region UTF-7
        public string CriptUTF7(string texto)
        {
            try
            {
                byte[] textoBinario = Encoding.UTF7.GetBytes(texto);
                string textoCript = Convert.ToBase64String(textoBinario);
                return textoCript;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public string DescriptUTF7(string texto)
        {
            try
            {
                byte[] textoCript = Convert.FromBase64String(texto);
                string textoBinario = Encoding.UTF7.GetString(textoCript);
                return textoBinario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region UTF-8
        public string CriptUTF8(string texto)
        {
            try
            {
                byte[] textoBinario = Encoding.UTF8.GetBytes(texto);
                string textoCript = Convert.ToBase64String(textoBinario);
                return textoCript;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string DescriptUTF8(string texto)
        {
            try
            {
                byte[] textoCript = Convert.FromBase64String(texto);
                string textoBinario = Encoding.UTF8.GetString(textoCript);
                return textoBinario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region UTF-32
        public string CriptUTF32(string texto)
        {
            try
            {
                byte[] textoBinario = Encoding.UTF32.GetBytes(texto);
                string textoCript = Convert.ToBase64String(textoBinario);
                return textoCript;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public string DescriptUTF32(string texto)
        {
            try
            {
                byte[] textoCript = Convert.FromBase64String(texto);
                string textoBinario = Encoding.UTF32.GetString(textoCript);
                return textoBinario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region Unicode
        public string CriptUnicode(string texto)
        {
            try
            {
                UnicodeEncoding Unicode = new UnicodeEncoding();
                byte[] textoBinario = Unicode.GetBytes(texto);
                string textoCript = Convert.ToBase64String(textoBinario);
                return textoCript;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string DescriptUnicode(string textEncripted)
        {
            try
            {
                UnicodeEncoding Unicode = new UnicodeEncoding();
                byte[] textoCript = Convert.FromBase64String(textEncripted);
                string textoBinario = Unicode.GetString(textoCript);
                return textoBinario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region Big Endian Unicode
        public string CriptUTF16(string texto)
        {
            try
            {

                byte[] textoBinario = Encoding.BigEndianUnicode.GetBytes(texto);
                string textoCript = Convert.ToBase64String(textoBinario);
                return textoCript;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string DescriptUTF16(string textEncripted)
        {
            try
            {

                byte[] textoCript = Convert.FromBase64String(textEncripted);
                string textoBinario = Encoding.BigEndianUnicode.GetString(textoCript);
                return textoBinario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #endregion

        #region Criptografias
        #region AES (Advanced Encryption Standard)
        //https://www.delftstack.com/pt/howto/csharp/encrypt-and-decrypt-a-string-in-csharp/
        public string EncryptAES(string textToEncrypt, string Key, string IV, string Cod, string CodKey, string CodIV)
        {
            try
            {
                string ToReturn = "";
                byte[] secretkeyByte = { };
                byte[] publickeybyte = { };
                if (CodKey == "ASCII")
                {
                    secretkeyByte = Encoding.ASCII.GetBytes(Key);
                }
                else
                    if (CodKey == "ANSI")
                {
                    secretkeyByte = Encoding.Default.GetBytes(Key);
                }
                
                else
                    if (CodKey == "UTF-7")
                {
                    secretkeyByte = Encoding.UTF7.GetBytes(Key);
                }
                else
                    if (CodKey == "UTF-8")
                {
                    secretkeyByte = Encoding.UTF8.GetBytes(Key);
                }
                else
                    if (CodKey == "UTF-32")
                {
                    secretkeyByte = Encoding.UTF32.GetBytes(Key);
                }
                else
                    if (CodKey == "Unicode (Little Endian")
                {
                    secretkeyByte = Encoding.Unicode.GetBytes(Key);
                }
                else
                    if (CodKey == "Unicode (Big Endian")
                {
                    secretkeyByte = Encoding.BigEndianUnicode.GetBytes(Key);
                }

                if (CodIV == "ASCII")
                {
                    publickeybyte = Encoding.ASCII.GetBytes(IV);
                }
                else
                    if (CodIV == "ANSI")
                {
                    publickeybyte = Encoding.Default.GetBytes(IV);
                }

                else
                    if (CodIV == "UTF-7")
                {
                    publickeybyte = Encoding.UTF7.GetBytes(IV);
                }
                else
                    if (CodIV == "UTF-8")
                {
                    publickeybyte = Encoding.UTF8.GetBytes(IV);
                }
                else
                    if (CodIV == "UTF-32")
                {
                    publickeybyte = Encoding.UTF32.GetBytes(IV);
                }
                else
                    if (CodIV == "Unicode (Little Endian")
                {
                    publickeybyte = Encoding.Unicode.GetBytes(IV);
                }
                else
                    if (CodIV == "Unicode (Big Endian")
                {
                    publickeybyte = Encoding.BigEndianUnicode.GetBytes(Key);
                }

                MemoryStream ms = null;
                CryptoStream cs = null;
                using (AesCryptoServiceProvider AES = new AesCryptoServiceProvider())
                {
                    AES.Key = secretkeyByte;
                    AES.IV = publickeybyte;
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, AES.CreateEncryptor(AES.Key, AES.IV), CryptoStreamMode.Write);
                    if (Cod == "UTF-7")
                    {
                        byte[] inputbyteArray = Encoding.UTF7.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "UTF-8")
                    {
                        byte[] inputbyteArray = Encoding.UTF8.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "Unicode (Little Endian)")
                    {
                        UnicodeEncoding Unicode = new UnicodeEncoding();
                        byte[] inputbyteArray = Unicode.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "Unicode (Big Endian)")
                    {
                        byte[] inputbyteArray = Encoding.BigEndianUnicode.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "ASCII")
                    {
                        ASCIIEncoding code = new ASCIIEncoding();
                        byte[] inputbyteArray = code.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "ANSI")
                    {
                        byte[] inputbyteArray = Encoding.Default.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else//(Cod == "UTF-32")
                    {
                        byte[] inputbyteArray = Encoding.UTF32.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                }
                return ToReturn;
                //#endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public string DecryptAES(string textToDecrypt, string Key, string IV, string Cod, string CodKey, string CodIV)
        {
            try
            {
                string ToReturn = "";
                byte[] privatekeyByte = { };
                byte[] publickeybyte = { };

                if (CodKey == "ASCII")
                {
                    privatekeyByte = Encoding.ASCII.GetBytes(Key);
                }
                else
                    if (CodKey == "ANSI")
                {
                    privatekeyByte = Encoding.Default.GetBytes(Key);
                }

                else
                    if (CodKey == "UTF-7")
                {
                    privatekeyByte = Encoding.UTF7.GetBytes(Key);
                }
                else
                    if (CodKey == "UTF-8")
                {
                    privatekeyByte = Encoding.UTF8.GetBytes(Key);
                }
                else
                    if (CodKey == "UTF-32")
                {
                    privatekeyByte = Encoding.UTF32.GetBytes(Key);
                }
                else
                    if (CodKey == "Unicode (Little Endian")
                {
                    privatekeyByte = Encoding.Unicode.GetBytes(Key);
                }
                else
                    if (CodKey == "Unicode (Big Endian")
                {
                    privatekeyByte = Encoding.BigEndianUnicode.GetBytes(Key);
                }

                if (CodIV == "ASCII")
                {
                    publickeybyte = Encoding.ASCII.GetBytes(IV);
                }
                else
                    if (CodIV == "ANSI")
                {
                    publickeybyte = Encoding.Default.GetBytes(IV);
                }

                else
                    if (CodIV == "UTF-7")
                {
                    publickeybyte = Encoding.UTF7.GetBytes(IV);
                }
                else
                    if (CodIV == "UTF-8")
                {
                    publickeybyte = Encoding.UTF8.GetBytes(IV);
                }
                else
                    if (CodIV == "UTF-32")
                {
                    publickeybyte = Encoding.UTF32.GetBytes(IV);
                }
                else
                    if (CodIV == "Unicode (Little Endian")
                {
                    publickeybyte = Encoding.Unicode.GetBytes(IV);
                }
                else
                    if (CodIV == "Unicode (Big Endian")
                {
                    publickeybyte = Encoding.BigEndianUnicode.GetBytes(Key);
                }
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));
                using (AesCryptoServiceProvider AES = new AesCryptoServiceProvider())
                {
                    AES.Key = privatekeyByte;
                    AES.IV = publickeybyte;
                    if (Cod == "UTF-7")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, AES.CreateDecryptor(AES.Key, AES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.UTF7;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "UTF-8")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, AES.CreateDecryptor(AES.Key, AES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.UTF8;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "Unicode (Little Endian)")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, AES.CreateDecryptor(AES.Key, AES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.Unicode;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "Unicode (Big Endian)")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, AES.CreateDecryptor(AES.Key, AES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.BigEndianUnicode;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "ASCII")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, AES.CreateDecryptor(AES.Key, AES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.ASCII;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "ANSI")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, AES.CreateDecryptor(AES.Key, AES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Encoding.Default.GetString(ms.ToArray());
                    }
                    else
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, AES.CreateDecryptor(AES.Key, AES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.UTF32;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                }
                return ToReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region DES (Data Encryption Standard)
        public string EncryptDES(string textToEncrypt, string Key, string IV, string Cod, string CodKey, string CodIV)
        {
            try
            { 
                string ToReturn = "";
                byte[] secretkeyByte = { };
                byte[] publickeybyte = { };

                if (CodKey == "ASCII")
                {
                    secretkeyByte = Encoding.ASCII.GetBytes(Key);
                }
                else
                    if (CodKey == "ANSI")
                {
                    secretkeyByte = Encoding.Default.GetBytes(Key);
                }

                else
                    if (CodKey == "UTF-7")
                {
                    secretkeyByte = Encoding.UTF7.GetBytes(Key);
                }
                else
                    if (CodKey == "UTF-8")
                {
                    secretkeyByte = Encoding.UTF8.GetBytes(Key);
                }
                else
                    if (CodKey == "UTF-32")
                {
                    secretkeyByte = Encoding.UTF32.GetBytes(Key);
                }
                else
                    if (CodKey == "Unicode (Little Endian")
                {
                    secretkeyByte = Encoding.Unicode.GetBytes(Key);
                }
                else
                    if (CodKey == "Unicode (Big Endian")
                {
                    secretkeyByte = Encoding.BigEndianUnicode.GetBytes(Key);
                }

                if (CodIV == "ASCII")
                {
                    publickeybyte = Encoding.ASCII.GetBytes(IV);
                }
                else
                    if (CodIV == "ANSI")
                {
                    publickeybyte = Encoding.Default.GetBytes(IV);
                }

                else
                    if (CodIV == "UTF-7")
                {
                    publickeybyte = Encoding.UTF7.GetBytes(IV);
                }
                else
                    if (CodIV == "UTF-8")
                {
                    publickeybyte = Encoding.UTF8.GetBytes(IV);
                }
                else
                    if (CodIV == "UTF-32")
                {
                    publickeybyte = Encoding.UTF32.GetBytes(IV);
                }
                else
                    if (CodIV == "Unicode (Little Endian")
                {
                    publickeybyte = Encoding.Unicode.GetBytes(IV);
                }
                else
                    if (CodIV == "Unicode (Big Endian")
                {
                    publickeybyte = Encoding.BigEndianUnicode.GetBytes(Key);
                }

                MemoryStream ms = null;
                CryptoStream cs = null;
                using (DESCryptoServiceProvider DES = new DESCryptoServiceProvider())
                {
                    DES.Key = secretkeyByte;
                    DES.IV = publickeybyte;
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, DES.CreateEncryptor(DES.Key, DES.IV), CryptoStreamMode.Write);
                    if (Cod == "UTF-7")
                    {
                        byte[] inputbyteArray = Encoding.UTF7.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "UTF-8")
                    {
                        byte[] inputbyteArray = Encoding.UTF8.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "Unicode (Little Endian)")
                    {
                        UnicodeEncoding Unicode = new UnicodeEncoding();
                        byte[] inputbyteArray = Unicode.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "Unicode (Big Endian)")
                    {
                        byte[] inputbyteArray = Encoding.BigEndianUnicode.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "ASCII")
                    {
                        ASCIIEncoding code = new ASCIIEncoding();
                        byte[] inputbyteArray = code.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "ANSI")
                    {
                        byte[] inputbyteArray = Encoding.Default.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else//(Cod == "UTF-32")
                    {
                        byte[] inputbyteArray = Encoding.UTF32.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                }
                return ToReturn;
                //#endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public string DecryptDES(string textToDecrypt, string Key, string IV, string Cod, string CodKey, string CodIV)
        {
            try
            {
                string ToReturn = "";
                byte[] privatekeyByte = { };
                byte[] publickeybyte = { };

                if (CodKey == "ASCII")
                {
                    privatekeyByte = Encoding.ASCII.GetBytes(Key);
                }
                else
                    if (CodKey == "ANSI")
                {
                    privatekeyByte = Encoding.Default.GetBytes(Key);
                }

                else
                    if (CodKey == "UTF-7")
                {
                    privatekeyByte = Encoding.UTF7.GetBytes(Key);
                }
                else
                    if (CodKey == "UTF-8")
                {
                    privatekeyByte = Encoding.UTF8.GetBytes(Key);
                }
                else
                    if (CodKey == "UTF-32")
                {
                    privatekeyByte = Encoding.UTF32.GetBytes(Key);
                }
                else
                    if (CodKey == "Unicode (Little Endian")
                {
                    privatekeyByte = Encoding.Unicode.GetBytes(Key);
                }
                else
                    if (CodKey == "Unicode (Big Endian")
                {
                    privatekeyByte = Encoding.BigEndianUnicode.GetBytes(Key);
                }

                if (CodIV == "ASCII")
                {
                    publickeybyte = Encoding.ASCII.GetBytes(IV);
                }
                else
                    if (CodIV == "ANSI")
                {
                    publickeybyte = Encoding.Default.GetBytes(IV);
                }

                else
                    if (CodIV == "UTF-7")
                {
                    publickeybyte = Encoding.UTF7.GetBytes(IV);
                }
                else
                    if (CodIV == "UTF-8")
                {
                    publickeybyte = Encoding.UTF8.GetBytes(IV);
                }
                else
                    if (CodIV == "UTF-32")
                {
                    publickeybyte = Encoding.UTF32.GetBytes(IV);
                }
                else
                    if (CodIV == "Unicode (Little Endian")
                {
                    publickeybyte = Encoding.Unicode.GetBytes(IV);
                }
                else
                    if (CodIV == "Unicode (Big Endian")
                {
                    publickeybyte = Encoding.BigEndianUnicode.GetBytes(Key);
                }

                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));
                using (DESCryptoServiceProvider DES = new DESCryptoServiceProvider())
                {
                    DES.Key = privatekeyByte;
                    DES.IV = publickeybyte;
                    if (Cod == "UTF-7")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, DES.CreateDecryptor(DES.Key, DES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.UTF7;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "UTF-8")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, DES.CreateDecryptor(DES.Key, DES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.UTF8;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "Unicode (Little Endian)")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, DES.CreateDecryptor(DES.Key, DES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.Unicode;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "Unicode (Big Endian)")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, DES.CreateDecryptor(DES.Key, DES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.BigEndianUnicode;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "ASCII")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, DES.CreateDecryptor(DES.Key, DES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.ASCII;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "ANSI")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, DES.CreateDecryptor(DES.Key, DES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Encoding.Default.GetString(ms.ToArray());
                    }
                    else
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, DES.CreateDecryptor(DES.Key, DES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.UTF32;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                }
                return ToReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region TripleDES (Triple Data Encryption Standard)
        public string Encrypt3DES(string textToEncrypt, string Key, string IV, string Cod, string CodKey, string CodIV)
        {
            try
            {
                string ToReturn = "";
                byte[] secretkeyByte = { };
                byte[] publickeybyte = { };
                if (CodKey == "ASCII")
                {
                    secretkeyByte = Encoding.ASCII.GetBytes(Key);
                }
                else
                    if (CodKey == "ANSI")
                {
                    secretkeyByte = Encoding.Default.GetBytes(Key);
                }

                else
                    if (CodKey == "UTF-7")
                {
                    secretkeyByte = Encoding.UTF7.GetBytes(Key);
                }
                else
                    if (CodKey == "UTF-8")
                {
                    secretkeyByte = Encoding.UTF8.GetBytes(Key);
                }
                else
                    if (CodKey == "UTF-32")
                {
                    secretkeyByte = Encoding.UTF32.GetBytes(Key);
                }
                else
                    if (CodKey == "Unicode (Little Endian")
                {
                    secretkeyByte = Encoding.Unicode.GetBytes(Key);
                }
                else
                    if (CodKey == "Unicode (Big Endian")
                {
                    secretkeyByte = Encoding.BigEndianUnicode.GetBytes(Key);
                }

                if (CodIV == "ASCII")
                {
                    publickeybyte = Encoding.ASCII.GetBytes(IV);
                }
                else
                    if (CodIV == "ANSI")
                {
                    publickeybyte = Encoding.Default.GetBytes(IV);
                }

                else
                    if (CodIV == "UTF-7")
                {
                    publickeybyte = Encoding.UTF7.GetBytes(IV);
                }
                else
                    if (CodIV == "UTF-8")
                {
                    publickeybyte = Encoding.UTF8.GetBytes(IV);
                }
                else
                    if (CodIV == "UTF-32")
                {
                    publickeybyte = Encoding.UTF32.GetBytes(IV);
                }
                else
                    if (CodIV == "Unicode (Little Endian")
                {
                    publickeybyte = Encoding.Unicode.GetBytes(IV);
                }
                else
                    if (CodIV == "Unicode (Big Endian")
                {
                    publickeybyte = Encoding.BigEndianUnicode.GetBytes(Key);
                }
                MemoryStream ms = null;
                CryptoStream cs = null;
                using (TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider())
                {
                    DES.Key = secretkeyByte;
                    DES.IV = publickeybyte;
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, DES.CreateEncryptor(DES.Key, DES.IV), CryptoStreamMode.Write);
                    if (Cod == "UTF-7")
                    {
                        byte[] inputbyteArray = Encoding.UTF7.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "UTF-8")
                    {
                        byte[] inputbyteArray = Encoding.UTF8.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "Unicode (Little Endian)")
                    {
                        UnicodeEncoding Unicode = new UnicodeEncoding();
                        byte[] inputbyteArray = Unicode.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "Unicode (Big Endian)")
                    {
                        byte[] inputbyteArray = Encoding.BigEndianUnicode.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "ASCII")
                    {
                        ASCIIEncoding code = new ASCIIEncoding();
                        byte[] inputbyteArray = code.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "ANSI")
                    {
                        byte[] inputbyteArray = Encoding.Default.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else//(Cod == "UTF-32")
                    {
                        byte[] inputbyteArray = Encoding.UTF32.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                }
                return ToReturn;
                //#endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public string Decrypt3DES(string textToDecrypt, string Key, string IV, string Cod, string CodKey, string CodIV)
        {
            try
            {
                string ToReturn = "";
                byte[] privatekeyByte = { };
                byte[] publickeybyte = { };

                if (CodKey == "ASCII")
                {
                    privatekeyByte = Encoding.ASCII.GetBytes(Key);
                }
                else
                    if (CodKey == "ANSI")
                {
                    privatekeyByte = Encoding.Default.GetBytes(Key);
                }

                else
                    if (CodKey == "UTF-7")
                {
                    privatekeyByte = Encoding.UTF7.GetBytes(Key);
                }
                else
                    if (CodKey == "UTF-8")
                {
                    privatekeyByte = Encoding.UTF8.GetBytes(Key);
                }
                else
                    if (CodKey == "UTF-32")
                {
                    privatekeyByte = Encoding.UTF32.GetBytes(Key);
                }
                else
                    if (CodKey == "Unicode (Little Endian")
                {
                    privatekeyByte = Encoding.Unicode.GetBytes(Key);
                }
                else
                    if (CodKey == "Unicode (Big Endian")
                {
                    privatekeyByte = Encoding.BigEndianUnicode.GetBytes(Key);
                }

                if (CodIV == "ASCII")
                {
                    publickeybyte = Encoding.ASCII.GetBytes(IV);
                }
                else
                    if (CodIV == "ANSI")
                {
                    publickeybyte = Encoding.Default.GetBytes(IV);
                }

                else
                    if (CodIV == "UTF-7")
                {
                    publickeybyte = Encoding.UTF7.GetBytes(IV);
                }
                else
                    if (CodIV == "UTF-8")
                {
                    publickeybyte = Encoding.UTF8.GetBytes(IV);
                }
                else
                    if (CodIV == "UTF-32")
                {
                    publickeybyte = Encoding.UTF32.GetBytes(IV);
                }
                else
                    if (CodIV == "Unicode (Little Endian")
                {
                    publickeybyte = Encoding.Unicode.GetBytes(IV);
                }
                else
                    if (CodIV == "Unicode (Big Endian")
                {
                    publickeybyte = Encoding.BigEndianUnicode.GetBytes(Key);
                }
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));
                using (TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider())
                {
                    DES.Key = privatekeyByte;
                    DES.IV = publickeybyte;
                    if (Cod == "UTF-7")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, DES.CreateDecryptor(DES.Key, DES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.UTF7;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "UTF-8")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, DES.CreateDecryptor(DES.Key, DES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.UTF8;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "Unicode (Little Endian)")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, DES.CreateDecryptor(DES.Key, DES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.Unicode;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "Unicode (Big Endian)")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, DES.CreateDecryptor(DES.Key, DES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.BigEndianUnicode;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "ASCII")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, DES.CreateDecryptor(DES.Key, DES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.ASCII;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "ANSI")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, DES.CreateDecryptor(DES.Key, DES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Encoding.Default.GetString(ms.ToArray());
                    }
                    else
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, DES.CreateDecryptor(DES.Key, DES.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.UTF32;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                }
                return ToReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #region RC2
        public string EncryptRC2(string textToEncrypt, string Key, string IV, string Cod, string CodKey, string CodIV)
        {
            try
            {
                string ToReturn = "";
                byte[] secretkeyByte = { };
                byte[] publickeybyte = { };
                if (CodKey == "ASCII")
                {
                    secretkeyByte = Encoding.ASCII.GetBytes(Key);
                }
                else
                    if (CodKey == "ANSI")
                {
                    secretkeyByte = Encoding.Default.GetBytes(Key);
                }

                else
                    if (CodKey == "UTF-7")
                {
                    secretkeyByte = Encoding.UTF7.GetBytes(Key);
                }
                else
                    if (CodKey == "UTF-8")
                {
                    secretkeyByte = Encoding.UTF8.GetBytes(Key);
                }
                else
                    if (CodKey == "UTF-32")
                {
                    secretkeyByte = Encoding.UTF32.GetBytes(Key);
                }
                else
                    if (CodKey == "Unicode (Little Endian")
                {
                    secretkeyByte = Encoding.Unicode.GetBytes(Key);
                }
                else
                    if (CodKey == "Unicode (Big Endian")
                {
                    secretkeyByte = Encoding.BigEndianUnicode.GetBytes(Key);
                }

                if (CodIV == "ASCII")
                {
                    publickeybyte = Encoding.ASCII.GetBytes(IV);
                }
                else
                    if (CodIV == "ANSI")
                {
                    publickeybyte = Encoding.Default.GetBytes(IV);
                }

                else
                    if (CodIV == "UTF-7")
                {
                    publickeybyte = Encoding.UTF7.GetBytes(IV);
                }
                else
                    if (CodIV == "UTF-8")
                {
                    publickeybyte = Encoding.UTF8.GetBytes(IV);
                }
                else
                    if (CodIV == "UTF-32")
                {
                    publickeybyte = Encoding.UTF32.GetBytes(IV);
                }
                else
                    if (CodIV == "Unicode (Little Endian")
                {
                    publickeybyte = Encoding.Unicode.GetBytes(IV);
                }
                else
                    if (CodIV == "Unicode (Big Endian")
                {
                    publickeybyte = Encoding.BigEndianUnicode.GetBytes(Key);
                }

                MemoryStream ms = null;
                CryptoStream cs = null;
                using (RC2CryptoServiceProvider RC2 = new RC2CryptoServiceProvider())
                {
                    RC2.Key = secretkeyByte;
                    RC2.IV = publickeybyte;
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, RC2.CreateEncryptor(RC2.Key, RC2.IV), CryptoStreamMode.Write);
                    if (Cod == "UTF-7")
                    {
                        byte[] inputbyteArray = Encoding.UTF7.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "UTF-8")
                    {
                        byte[] inputbyteArray = Encoding.UTF8.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "Unicode (Little Endian)")
                    {
                        UnicodeEncoding Unicode = new UnicodeEncoding();
                        byte[] inputbyteArray = Unicode.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "Unicode (Big Endian)")
                    {
                        byte[] inputbyteArray = Encoding.BigEndianUnicode.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "ASCII")
                    {
                        ASCIIEncoding code = new ASCIIEncoding();
                        byte[] inputbyteArray = code.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else
                        if (Cod == "ANSI")
                    {
                        byte[] inputbyteArray = Encoding.Default.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                    else//(Cod == "UTF-32")
                    {
                        byte[] inputbyteArray = Encoding.UTF32.GetBytes(textToEncrypt);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Convert.ToBase64String(ms.ToArray());
                    }
                }
                return ToReturn;
                //#endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public string DecryptRC2(string textToDecrypt, string Key, string IV, string Cod, string CodKey, string CodIV)
        {
            try
            {
                string ToReturn = "";
                byte[] privatekeyByte = { };
                byte[] publickeybyte = { };

                if (CodKey == "ASCII")
                {
                    privatekeyByte = Encoding.ASCII.GetBytes(Key);
                }
                else
                    if (CodKey == "ANSI")
                {
                    privatekeyByte = Encoding.Default.GetBytes(Key);
                }

                else
                    if (CodKey == "UTF-7")
                {
                    privatekeyByte = Encoding.UTF7.GetBytes(Key);
                }
                else
                    if (CodKey == "UTF-8")
                {
                    privatekeyByte = Encoding.UTF8.GetBytes(Key);
                }
                else
                    if (CodKey == "UTF-32")
                {
                    privatekeyByte = Encoding.UTF32.GetBytes(Key);
                }
                else
                    if (CodKey == "Unicode (Little Endian")
                {
                    privatekeyByte = Encoding.Unicode.GetBytes(Key);
                }
                else
                    if (CodKey == "Unicode (Big Endian")
                {
                    privatekeyByte = Encoding.BigEndianUnicode.GetBytes(Key);
                }

                if (CodIV == "ASCII")
                {
                    publickeybyte = Encoding.ASCII.GetBytes(IV);
                }
                else
                    if (CodIV == "ANSI")
                {
                    publickeybyte = Encoding.Default.GetBytes(IV);
                }

                else
                    if (CodIV == "UTF-7")
                {
                    publickeybyte = Encoding.UTF7.GetBytes(IV);
                }
                else
                    if (CodIV == "UTF-8")
                {
                    publickeybyte = Encoding.UTF8.GetBytes(IV);
                }
                else
                    if (CodIV == "UTF-32")
                {
                    publickeybyte = Encoding.UTF32.GetBytes(IV);
                }
                else
                    if (CodIV == "Unicode (Little Endian")
                {
                    publickeybyte = Encoding.Unicode.GetBytes(IV);
                }
                else
                    if (CodIV == "Unicode (Big Endian")
                {
                    publickeybyte = Encoding.BigEndianUnicode.GetBytes(Key);
                }
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));
                using (RC2CryptoServiceProvider RC2 = new RC2CryptoServiceProvider())
                {
                    RC2.Key = privatekeyByte;
                    RC2.IV = publickeybyte;
                    if (Cod == "UTF-7")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, RC2.CreateDecryptor(RC2.Key, RC2.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.UTF7;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "UTF-8")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, RC2.CreateDecryptor(RC2.Key, RC2.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.UTF8;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "Unicode (Little Endian)")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, RC2.CreateDecryptor(RC2.Key, RC2.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.Unicode;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "Unicode (Big Endian)")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, RC2.CreateDecryptor(RC2.Key, RC2.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.BigEndianUnicode;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "ASCII")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, RC2.CreateDecryptor(RC2.Key, RC2.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.ASCII;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                    else
                        if (Cod == "ANSI")
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, RC2.CreateDecryptor(RC2.Key, RC2.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        ToReturn = Encoding.Default.GetString(ms.ToArray());
                    }
                    else
                    {
                        ms = new MemoryStream();
                        cs = new CryptoStream(ms, RC2.CreateDecryptor(RC2.Key, RC2.IV), CryptoStreamMode.Write);
                        cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                        cs.FlushFinalBlock();
                        Encoding encoding = Encoding.UTF32;
                        ToReturn = encoding.GetString(ms.ToArray());
                    }
                }
                return ToReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
        #endregion
    }
}
