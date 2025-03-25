using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsDosPacker
{
    public static class Utilities
    {
        public static string strTrimStartMultiLineString(string _strOriginalString)
        {
            StringBuilder _sbModifiedString = new StringBuilder();

            using (StringReader __objStringReader = new StringReader(_strOriginalString))
            {
                string __strLineBuffer;
                while ((__strLineBuffer = __objStringReader.ReadLine()) != null)
                {
                    _sbModifiedString.Append(__strLineBuffer.TrimStart() + Environment.NewLine);
                }
            }

            return _sbModifiedString.ToString();
        }

        public static void vDeleteDirectory(string _strTargetPath)
        {
            string[] _str_arrFiles = Directory.GetFiles(_strTargetPath);
            string[] _str_arr_Dirs = Directory.GetDirectories(_strTargetPath);

            foreach (string __strFile in _str_arrFiles)
            {
                File.SetAttributes(__strFile, FileAttributes.Normal);
                File.Delete(__strFile);
            }

            foreach (string __strDir in _str_arr_Dirs)
            {
                vDeleteDirectory(__strDir);
            }

            Directory.Delete(_strTargetPath, false);
        }

        public static void vConLog(string _strMessage)
        {
            System.Diagnostics.Debug.WriteLine(_strMessage);
        }
    }
}