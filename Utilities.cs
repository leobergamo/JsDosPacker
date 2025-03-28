using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsDosPacker
{
    public static class Utilities
    {
        private static bool boolCurrentlyFlashing = false;

        public static void vCopyRecursively(string _strSourcePath, string _strDestPath,  Action<String> _delOuputHandler)
        {

            // based on: https://stackoverflow.com/a/55596428 by Lakmal

            foreach (string __strDirPath in Directory.GetDirectories(_strSourcePath, "*", SearchOption.AllDirectories))
            {
                _delOuputHandler("Creating Directory: " + __strDirPath.Replace(_strSourcePath, _strDestPath));
                Directory.CreateDirectory(__strDirPath.Replace(_strSourcePath, _strDestPath));
            }
            foreach (string __strFilePath in Directory.GetFiles(_strSourcePath, "*", SearchOption.AllDirectories))
            {
                _delOuputHandler("Copying file: '" + __strFilePath + "' to '" + __strFilePath.Replace(_strSourcePath, _strDestPath) + "'");
                File.Copy(__strFilePath, __strFilePath.Replace(_strSourcePath, _strDestPath));
            }

            _delOuputHandler("Done...");
        }
        public static string strGetMysqlDateTime()
        {
            DateTime _objDateTime = DateTime.Now;
            return _objDateTime.ToString("yyyy-MM-dd HH:mm");
        }

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

        public static async void vAsyncFlashControl(Control _ctrlControl)
        {
            // based on code from uglycoyote @ https://stackoverflow.com/a/57979708

            Color _clrFlashColor = Color.Yellow;

            float _fltDuration = 500;
            int _intSteps = 10;
            float _fltInterval = _fltDuration / _intSteps;

            if (boolCurrentlyFlashing) return;

            boolCurrentlyFlashing = true;
            Color _clrOriginalColor = _ctrlControl.BackColor;
            float _fltInterpolant = 0.0f;

            while (_fltInterpolant < 1.0f)
            {
                Color _clrColor = clrInterpolateColor(_clrFlashColor, _clrOriginalColor, _fltInterpolant);
                _ctrlControl.BackColor = _clrColor;
                await Task.Delay((int)_fltInterval);
                _fltInterpolant += (1.0f / _intSteps);
            }

            _ctrlControl.BackColor = _clrOriginalColor;

            boolCurrentlyFlashing = false;
        }

        public static Color clrInterpolateColor(Color _clrColorOne, Color _clrColorTwo, float _fltAlpha)
        {
            // based on code from uglycoyote @ https://stackoverflow.com/a/57979708

            float _fltOneMinusAlpha = 1.0f - _fltAlpha;
            float _ftlA = _fltOneMinusAlpha * (float)_clrColorOne.A + _fltAlpha * (float)_clrColorTwo.A;
            float _fltR = _fltOneMinusAlpha * (float)_clrColorOne.R + _fltAlpha * (float)_clrColorTwo.R;
            float _fltG = _fltOneMinusAlpha * (float)_clrColorOne.G + _fltAlpha * (float)_clrColorTwo.G;
            float _fltB = _fltOneMinusAlpha * (float)_clrColorOne.B + _fltAlpha * (float)_clrColorTwo.B;
            return Color.FromArgb((int)_ftlA, (int)_fltR, (int)_fltG, (int)_fltB);
        }
    }
}