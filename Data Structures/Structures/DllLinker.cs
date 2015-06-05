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
        public static Dictionary<string, Assembly> dct_DllLinker { get; set; }

        public static void updateDllFiles()
        {
            dct_DllLinker = new Dictionary<string, Assembly>();

            String fullPath = Application.StartupPath.ToString();
            var files = Directory.GetFiles(fullPath, "*.dll");
            foreach (var file in files)
            {
                var file2 = file.Substring(0, file.Length - 4);
                int i = file2.Length - 1;
                while (!file2[i].Equals('\\')) i--;
                file2 = file2.Substring(i + 1);

                Assembly a = Assembly.Load(file2);
                dct_DllLinker.Add(file2, a);
            }
        }
        public static void MakeStructure(string nameOfTheStructure)
        {
            
            // Searching for essential library and creating variable, which features for main class in library 
            Type typ = dct_DllLinker[nameOfTheStructure].GetType(nameOfTheStructure + "." + nameOfTheStructure);
            // inst - object of our class
            var inst = Activator.CreateInstance(typ);
            // BuildCollection - method of our class
            var FactoryMethod = typ.GetMethod("FactoryMethod");
            // Calling our method (from our new object)
            typ myMegaColl = (typ)FactoryMethod.Invoke(inst, new object[] { });
            
        }
        public static void SaveStructureToFile(CollectionInfo x, string path)
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

        public static CollectionInfo getStructureFromFile(string path)
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

                return bf.Deserialize(CryptStream) as CollectionInfo;

               // CryptStream.Close();
            }
        }
    }
}
