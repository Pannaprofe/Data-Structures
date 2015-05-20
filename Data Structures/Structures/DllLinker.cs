using Data_Structures.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Data_Structures.Structures
{
    public class DllLinker
    {
        public static void SaveStructureToFile(myCollection x, string path)
        {
            using (Stream stream = new FileStream(path, FileMode.Create))
            {

                BinaryFormatter bf = new BinaryFormatter();

                //Create a new instance of the RijndaelManaged class
                // and encrypt the stream.
                RijndaelManaged RMCrypto = new RijndaelManaged();

                byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
                byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };

                //Create a CryptoStream, pass it the NetworkStream, and encrypt 
                //it with the Rijndael class.
                CryptoStream CryptStream = new CryptoStream(stream, RMCrypto.CreateEncryptor(Key, IV), CryptoStreamMode.Write);

                bf.Serialize(CryptStream, x);
                CryptStream.Close();

            }
        }

        public static myCollection getStructureFromFile(string path)
        {
            using (Stream stream = new FileStream(path, FileMode.Open))
            {

                BinaryFormatter bf = new BinaryFormatter();

                RijndaelManaged RMCrypto = new RijndaelManaged();

                byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
                byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };

                //Create a CryptoStream, pass it the NetworkStream, and encrypt 
                //it with the Rijndael class.
                CryptoStream CryptStream = new CryptoStream(stream, RMCrypto.CreateDecryptor(Key, IV), CryptoStreamMode.Read);

                return bf.Deserialize(CryptStream) as myCollection;

               // CryptStream.Close();
            }
        }
    }
}
