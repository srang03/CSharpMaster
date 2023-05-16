using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace IniTest
{

    public class Ini : IDisposable
    {
        private bool _disposed;
        private enum INIMKEY
        {
            urock2018,
        } 

        public string GetInimkey
        {
            get
            {
                return INIMKEY.urock2018.ToString();
            }
        }


        public Ini()
        {
            _disposed = false;
        }
        public bool SaveIniFile(string Category, string Key, string Value, string path)
        {
            // 파일이 있으면
            if (File.Exists(path))
            {
                try
                {
                    WritePrivateProfileString(Category, Key, Value, path);
                    return true;
                }
                catch { return false; }
            }

            // 파일이 없으면
            else
            {
                return false;
            }
        }

        public string LoadIniFile(string Category, string Key, string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    StringBuilder sb = new StringBuilder(255);
                    GetPrivateProfileString(Category, Key, string.Empty, sb, 255, path);

                    if (sb != null && sb.Length > 0) return sb.ToString();
                    return string.Empty;
                }
                catch { 
                    return string.Empty; 
                }
            }
            else
            {
                return string.Empty;
            }
        }


        public string CreateSalt(int origin)
        {
            try
            {
                var bytes = System.Text.Encoding.Unicode.GetBytes(origin.ToString());
                return Convert.ToBase64String(bytes);
            }
            catch
            {
                return string.Empty;
            }

        }


        public string LoadSalt(string salt)
        {
            try
            {
                var Bytes = Convert.FromBase64String(salt);
                var bynaryString = System.Text.Encoding.Unicode.GetString(Bytes);
                if (long.TryParse(bynaryString, out long result))
                {
                    var origin = DateTime.FromBinary(result);
                    return origin.ToString();
                }
                else return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        #region
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // TODO: dispose managed state (managed objects).
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}

