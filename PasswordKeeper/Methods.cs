using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.IO;


namespace PasswordKeeper
{
    class Methods
    {
        public BindingList<Password> passwordList = new BindingList<Password>();
        private const int Keysize = 256;

        private const string passPhrase = "pussyMonsta"; // Probably dont change later but not important right now;
        // This constant determines the number of iterations for the password bytes generation function.
        private const int DerivationIterations = 1000;

        public Methods()
        {
            fillList(passwordList);
        }

        public BindingList<Password> getPasswordList()
        {
            return passwordList;
        }
        public string genNewPassword()
        {

            Random rand = new Random();
            string newPassword = "";
            int numSymbols = 0;
            int numNumbers = 0;
            int numLower = 0;
            int numUpper = 0;

            char[] safeSymbols = { '!', '@', '#', '$', '-' };
            char[] safeNumbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] safeLowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] safeUpperLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            while (newPassword.Length < 12)
            {
                int r = rand.Next(5);
                if (r == 1 && numSymbols <= 2)
                {
                    int idx = rand.Next(safeSymbols.Length);
                    while (newPassword.Contains(safeSymbols[idx]) == true)
                    {
                        idx = rand.Next(safeSymbols.Length);
                    }
                    newPassword += safeSymbols[idx];
                    numSymbols++;
                }
                if (r == 2 && numNumbers <= 2)
                {
                    int idx = rand.Next(safeNumbers.Length);
                    while (newPassword.Contains(safeNumbers[idx]) == true)
                    {
                        idx = rand.Next(safeNumbers.Length);
                    }
                    newPassword += safeNumbers[idx];
                    numNumbers++;
                }
                if (r == 3 && numLower <= 2)
                {
                    int idx = rand.Next(safeLowerLetters.Length);
                    while (newPassword.Contains(safeLowerLetters[idx]) == true)
                    {
                        idx = rand.Next(safeLowerLetters.Length);
                    }
                    newPassword += safeLowerLetters[idx];
                    numLower++;
                }
                if (r == 4 && numUpper <= 2)
                {
                    int idx = rand.Next(safeUpperLetters.Length);
                    while (newPassword.Contains(safeUpperLetters[idx]) == true)
                    {
                        idx = rand.Next(safeUpperLetters.Length);
                    }
                    newPassword += safeUpperLetters[idx];
                    numUpper++;
                }
            }

            return newPassword;
        }

        public bool checkSymbols(string password)
        {
            char[] safeSymbols = { '!', '@', '#', '$', '-'};

            //for (int i = 0; i < password.Length + 1; i++)
            //{
            //    if (safeSymbols.Contains(password[i]))
            //    {
            //        return true;
            //    }
            //}

            foreach(char c in password)
            {
                if (safeSymbols.Contains(c))
                {
                    return true;
                }
            }

            return false;
        }

        public bool checkNumbers(string password)
        {
            char[] safeNumbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            //for (int i = 0; i < password.Length + 1; i++)
            //{
            //    if (safeNumbers.Contains(password[i]))
            //    {
            //        return true;
            //    }
            //}

            foreach(char c in password)
            {
                if(safeNumbers.Contains(c))
                {
                    return true;
                }
            }

            return false;
        }

        public bool checkLowerCase(string password)
        {
            char[] safeLowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            //for (int i = 0; i < password.Length + 1; i++)
            //{
            //    if (safeLowerLetters.Contains(password[i]))
            //    {
            //        return true;
            //    }
            //}

            foreach (char c in password)
            {
                if (safeLowerLetters.Contains(c))
                {
                    return true;
                }
            }

            return false;
        }

        public bool checkUpperCase(string password)
        {
            char[] safeUpperLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            //for (int i = 0; i < password.Length + 1; i++)
            //{
            //    if (safeUpperLetters.Contains(password[i]))
            //    {
            //        return true;
            //    }
            //}

            foreach (char c in password)
            {
                if (safeUpperLetters.Contains(c))
                {
                    return true;
                }
            }

            return false;
        }

        public bool analyzePassword(string password)
        {
            if (password.Length < 8 || checkSymbols(password) == false || checkNumbers(password) == false || checkLowerCase(password) == false || checkUpperCase(password) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string getPassPhrase()
        {
            return passPhrase;
        }

        public void fillList(BindingList<Password> passwordList)
        {
            string fileName = "PasswordData.txt"; // Fill in whatever we are storing the data in here

            if(File.Exists(fileName))
            {
                StreamReader reader = new StreamReader(fileName);
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] tempArr = line.Split('|');

                    string webName = tempArr[0];
                    string userName = tempArr[1];
                    string password = decrypt(tempArr[2], passPhrase);
                    string notes = tempArr[3];

                    Password tempPassword = new Password(webName, userName, password, notes);

                    passwordList.Add(tempPassword);
                }

                reader.Close();
                reader.Dispose();
            }

        }

        public string encrypt(string plainText, string passPhrase)
        {
            // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
            // so that the same Salt and IV values can be used when decrypting.  
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        public string decrypt(string cipherText, string passPhrase)
        {
            // Get the complete stream of bytes that represent:
            // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }

        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                // Fill the array with cryptographically secure random bytes.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
    }
}
