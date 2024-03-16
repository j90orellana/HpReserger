using System;
using System.Text;
using System.Security.Cryptography;

namespace HpResergerNube
{
    public static class Encriptacion
    {
        public static string Encriptar(string input)
        {
            byte[] IV = Encoding.ASCII.GetBytes("qualityi"); // La clave debe ser de 8 caracteres
            byte[] EncryptionKey = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5"); // No se puede alterar la cantidad de caracteres pero sí la clave
            byte[] buffer = Encoding.UTF8.GetBytes(input);
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = EncryptionKey;
            des.IV = IV;

            return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length));
        }

        public static string Desencriptar(string input)
        {
            byte[] IV = Encoding.ASCII.GetBytes("qualityi"); // La clave debe ser de 8 caracteres
            byte[] EncryptionKey = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5"); // No se puede alterar la cantidad de caracteres pero sí la clave
            byte[] buffer = Convert.FromBase64String(input);
            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Key = EncryptionKey;
            des.IV = IV;
            return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length));
        }
    }
}


