using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace menuavanzado
{
    internal class encriptacion
    {
        List<string> list = new List<string>();

        //estos son los encriptadores no los toquen

        private static byte[] sal = Encoding.ASCII.GetBytes("MiSaltDe16Bytes");


        public void encriptar()
        {
            string archivoxml = "Datos.xml";
            string archivoaes = "Datos.xml.enc";
            string clave = "$%548AS.d{a´a2SUS3ADD5/?¡saas";

            using (RijndaelManaged aes = new RijndaelManaged())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Mode = CipherMode.CBC;
                byte[] llave = new Rfc2898DeriveBytes(clave, sal).GetBytes(32);
                byte[] vector = new byte[aes.BlockSize / 8];
                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(vector);
                }

                aes.Key = llave;
                aes.IV = vector;

                using (FileStream fsInput = new FileStream(archivoxml, FileMode.Open))
                {
                    using (FileStream fsOutput = new FileStream(archivoaes, FileMode.Create))
                    {
                        fsOutput.Write(vector, 0, vector.Length);
                        using (CryptoStream cs = new CryptoStream(fsOutput, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            byte[] buffer = new byte[1024];
                            int read;
                            while ((read = fsInput.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                cs.Write(buffer, 0, read);
                            }
                        }
                    }
                }
            }
        }

        public void desencriptar()
        {
            string archivoaes = "Datos.xml.enc";
            string archivoxml = "Datos.xml";
            string clave = "$%548AS.d{a´a2SUS3ADD5/?¡saas";

            using (RijndaelManaged aes = new RijndaelManaged())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Mode = CipherMode.CBC;
                byte[] llave = new Rfc2898DeriveBytes(clave, sal).GetBytes(32);
                byte[] vector = new byte[aes.BlockSize / 8];

                using (FileStream fsInput = new FileStream(archivoaes, FileMode.Open))
                {
                    fsInput.Read(vector, 0, vector.Length);

                    aes.Key = llave;
                    aes.IV = vector;

                    using (CryptoStream cs = new CryptoStream(fsInput, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (FileStream fsOutput = new FileStream(archivoxml, FileMode.Create))
                        {
                            byte[] buffer = new byte[1024];
                            int read;
                            while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                fsOutput.Write(buffer, 0, read);
                            }
                        }
                    }
                }
            }
        }
    }
}
