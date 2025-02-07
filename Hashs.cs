using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Encription_Creator
{
    public class Hashs
    {
    UTF7Encoding UTF7;
    UTF8Encoding UTF8;
    UTF32Encoding UTF32;
    ASCIIEncoding ASCII;
    UnicodeEncoding Unicode;
    #region MD5
    public string CriptografarMD5(string texto, string Cod)
    {
        try
        {
            MD5 hashMD5 = MD5.Create();
            if (Cod == "UTF-7")
            {
                byte[] valorCriptografado = hashMD5.ComputeHash(Encoding.UTF7.GetBytes(texto));
                StringBuilder strbuilder = new StringBuilder();
                for (int i = 0; i < valorCriptografado.Length; i++)
                {
                    strbuilder.Append(valorCriptografado[i].ToString("X2"));
                }
                return strbuilder.ToString();
            }
            else
                if (Cod == "UTF-8")
            {
                byte[] valorCriptografado = hashMD5.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder strbuilder = new StringBuilder();
                for (int i = 0; i < valorCriptografado.Length; i++)
                {
                    strbuilder.Append(valorCriptografado[i].ToString("X2"));
                }
                return strbuilder.ToString();
            }
            else
                if (Cod == "ASCII")
            {
                byte[] valorCriptografado = hashMD5.ComputeHash(Encoding.ASCII.GetBytes(texto));
                StringBuilder strbuilder = new StringBuilder();
                for (int i = 0; i < valorCriptografado.Length; i++)
                {
                    strbuilder.Append(valorCriptografado[i].ToString("X2"));
                }
                return strbuilder.ToString();
            }
            else
                if (Cod == "Unicode (Little Endian)")
            {
                byte[] valorCriptografado = hashMD5.ComputeHash(Encoding.Unicode.GetBytes(texto));
                StringBuilder strbuilder = new StringBuilder();
                for (int i = 0; i < valorCriptografado.Length; i++)
                {
                    strbuilder.Append(valorCriptografado[i].ToString("X2"));
                }
                return strbuilder.ToString();
            }
            else
                if (Cod == "ANSI")
            {
                byte[] valorCriptografado = hashMD5.ComputeHash(Encoding.Default.GetBytes(texto));
                StringBuilder strbuilder = new StringBuilder();
                for (int i = 0; i < valorCriptografado.Length; i++)
                {
                    strbuilder.Append(valorCriptografado[i].ToString("X2"));
                }
                return strbuilder.ToString();
            }
            else
                if (Cod == "Unicode (Big Endian)")
                {
                    byte[] valorCriptografado = hashMD5.ComputeHash(Encoding.BigEndianUnicode.GetBytes(texto));
                    StringBuilder strbuilder = new StringBuilder();
                    for (int i = 0; i < valorCriptografado.Length; i++)
                    {
                        strbuilder.Append(valorCriptografado[i].ToString("X2"));
                    }
                    return strbuilder.ToString();
            }
            else
            {
                byte[] valorCriptografado = hashMD5.ComputeHash(Encoding.UTF32.GetBytes(texto));
                StringBuilder strbuilder = new StringBuilder();
                for (int i = 0; i < valorCriptografado.Length; i++)
                {
                    strbuilder.Append(valorCriptografado[i].ToString("X2"));
                }
                return strbuilder.ToString();
            }

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public string md5encrypt(string frase)
    {
        UTF8Encoding encoder = new UTF8Encoding();
        MD5CryptoServiceProvider md5hasher = new MD5CryptoServiceProvider();
        byte[] hashedDataBytes = md5hasher.ComputeHash(encoder.GetBytes(frase));
        return byteArrayToString(hashedDataBytes);
    }
    #endregion
    #region Sha1
    public string sha1encrypt(string frase, string Cod)
    {
        SHA1CryptoServiceProvider sha1hasher = new SHA1CryptoServiceProvider();
        if (Cod == "UTF-7")
        {
            UTF7 = new UTF7Encoding();
            byte[] hashedDataBytes = sha1hasher.ComputeHash(UTF7.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "UTF-8")
        {
            UTF8 = new UTF8Encoding();
            byte[] hashedDataBytes = sha1hasher.ComputeHash(UTF8.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "ASCII")
        {
            ASCII = new ASCIIEncoding();
            byte[] hashedDataBytes = sha1hasher.ComputeHash(ASCII.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "ANSI")
        {
            byte[] hashedDataBytes = sha1hasher.ComputeHash(Encoding.Default.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "Unicode (Little Endian)")
        {
            Unicode = new UnicodeEncoding();
            byte[] hashedDataBytes = sha1hasher.ComputeHash(Unicode.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "Unicode (Big Endian)")
        {
            byte[] hashedDataBytes = sha1hasher.ComputeHash(Encoding.BigEndianUnicode.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
        {
            UTF32 = new UTF32Encoding();
            byte[] hashedDataBytes = sha1hasher.ComputeHash(UTF32.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
    }
    #endregion
    #region Sha256
    public string sha256encrypt(string frase, string Cod)
    {
        SHA256Managed sha256hasher = new SHA256Managed();
        if (Cod == "UTF-7")
        {
            UTF7 = new UTF7Encoding();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(UTF7.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "UTF-8")
        {
            UTF8 = new UTF8Encoding();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(UTF8.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "ASCII")
        {
            ASCII = new ASCIIEncoding();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(ASCII.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "ANSI")
        {
            byte[] hashedDataBytes = sha256hasher.ComputeHash(Encoding.Default.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "Unicode (Little Endian)")
        {
            Unicode = new UnicodeEncoding();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(Unicode.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "Unicode (Big Endian)")
        {
            byte[] hashedDataBytes = sha256hasher.ComputeHash(Encoding.BigEndianUnicode.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
        {
            UTF32 = new UTF32Encoding();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(UTF32.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
    }
    #endregion
    #region Sha384
    public string sha384encrypt(string frase, string Cod)
    {
        SHA384Managed sha384hasher = new SHA384Managed();
        if (Cod == "UTF-7")
        {
            UTF7 = new UTF7Encoding();
            byte[] hashedDataBytes = sha384hasher.ComputeHash(UTF7.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "UTF-8")
        {
            UTF8 = new UTF8Encoding();
            byte[] hashedDataBytes = sha384hasher.ComputeHash(UTF8.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "ASCII")
        {
            ASCII = new ASCIIEncoding();
            byte[] hashedDataBytes = sha384hasher.ComputeHash(ASCII.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "ANSI")
        {
            byte[] hashedDataBytes = sha384hasher.ComputeHash(Encoding.Default.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "Unicode (Little Endian)")
        {
            Unicode = new UnicodeEncoding();
            byte[] hashedDataBytes = sha384hasher.ComputeHash(Unicode.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "Unicode (Big Endian)")
        {            
            byte[] hashedDataBytes = sha384hasher.ComputeHash(Encoding.BigEndianUnicode.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else // UTF-32
        {
            UTF32 = new UTF32Encoding();
            byte[] hashedDataBytes = sha384hasher.ComputeHash(UTF32.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
    }
    #endregion
    #region Sha512
    public string sha512encrypt(string frase, string Cod)
    {
        SHA512Managed sha512hasher = new SHA512Managed();
        if (Cod == "UTF-7")
        {
            UTF7 = new UTF7Encoding();
            byte[] hashedDataBytes = sha512hasher.ComputeHash(UTF7.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "UTF-8")
        {
            UTF8 = new UTF8Encoding();
            byte[] hashedDataBytes = sha512hasher.ComputeHash(UTF8.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "ASCII")
        {
            ASCII = new ASCIIEncoding();
            byte[] hashedDataBytes = sha512hasher.ComputeHash(ASCII.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "ANSI")
        {
            byte[] hashedDataBytes = sha512hasher.ComputeHash(Encoding.Default.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "Unicode (Little Endian)")
        {
            Unicode = new UnicodeEncoding();
            byte[] hashedDataBytes = sha512hasher.ComputeHash(Unicode.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else
            if (Cod == "Unicode (Big Endian)")
        {            
            byte[] hashedDataBytes = sha512hasher.ComputeHash(Encoding.BigEndianUnicode.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
        else // UTF-32
        {
            UTF32 = new UTF32Encoding();
            byte[] hashedDataBytes = sha512hasher.ComputeHash(UTF32.GetBytes(frase));
            return byteArrayToString(hashedDataBytes);
        }
    }
    #endregion


    public static string byteArrayToString(byte[] inputArray)
    {
        StringBuilder output = new StringBuilder("");
        for (int i = 0; i < inputArray.Length; i++)
        {
            output.Append(inputArray[i].ToString("X2"));
        }
        return output.ToString();
    }
}
}
