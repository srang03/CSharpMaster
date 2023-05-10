using Enc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IniTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ian\source\repos\CSharpMaster\IniTest\system.ini";
            ConsoleKeyInfo KeyInfo;

            string encryptionKey = "DOMAINUROCKINC";

            do
            {
                KeyInfo = Console.ReadKey();

                // [1] 로그인
                if (KeyInfo.Key == ConsoleKey.D1)
                {
                    var res = InputPassword(path, encryptionKey);
                }



                // [2] 비밀번호 변경
                if (KeyInfo.Key == ConsoleKey.D2)
                {
                    using (var ini = new Ini())
                    {
                        string loadFile = ini.LoadIniFile("system", "nimdatals", path);
                        string oldpassword = ini.LoadIniFile("system", "password", path);
                        if (string.IsNullOrEmpty(loadFile))
                        {
                            return;
                        }

                        if(InputPassword(path, encryptionKey))
                        {
                            Console.WriteLine();
                            Console.WriteLine("새로운 비밀번호를 입력해주세요.");

                            var newPassword = Console.ReadLine();
                            var origin = DateTime.Now;
                            var newSalt = ini.CreateSalt(origin);
                            AESEncryption aes = new AESEncryption();
                            var EncryptedNewPassword = aes.EncryptString(newPassword, encryptionKey, origin.ToString());

                            ini.SaveIniFile("system", "nimdatals", newSalt, path);
                            ini.SaveIniFile("system", "password", EncryptedNewPassword, path);

                        }
                    }

                }
            } while (KeyInfo.Key != ConsoleKey.Escape);

        }

        static bool InputPassword(string path, string encryptionKey)
        {
            Console.WriteLine();
            Console.WriteLine("비밀번호를 입력해주세요.");
            string loadPassword = string.Empty;
            string loadSalt = string.Empty;
            string loadmKey = string.Empty;
            var strInputPassword = Console.ReadLine();
            AESEncryption aes = new AESEncryption();         
            
            using (var ini = new Ini())
            {
                loadSalt = ini.LoadSalt(ini.LoadIniFile("system", "nimdatals", path));
                loadPassword = ini.LoadIniFile("system", "password", path);
                if (string.IsNullOrEmpty(loadPassword) || string.IsNullOrEmpty(loadSalt))
                {
                    Console.WriteLine("관리자 로그인을 수행할 수 없습니다.");
                    return false;
                }
            }

            var encryption = aes.EncryptString(strInputPassword, encryptionKey, loadSalt);

            if (encryption.Equals(loadPassword))
            {
                Console.WriteLine();
                Console.WriteLine("로그인 성공");
                return true;
            }
            else
            {
                Console.WriteLine("로그인 실패");
                return false;
            }
        }
           
    }
}
