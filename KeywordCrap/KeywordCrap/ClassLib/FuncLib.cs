using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Microsoft.VisualBasic;
using SHDocVw;

namespace KeywordCrap.ClassLib
{
    public enum ShowCommands : int
    {
        SW_HIDE         = 0,
        SW_SHOWNORMAL       = 1,
        SW_NORMAL       = 1,
        SW_SHOWMINIMIZED    = 2,
        SW_SHOWMAXIMIZED    = 3,
        SW_MAXIMIZE     = 3,
        SW_SHOWNOACTIVATE   = 4,
        SW_SHOW         = 5,
        SW_MINIMIZE     = 6,
        SW_SHOWMINNOACTIVE  = 7,
        SW_SHOWNA       = 8,
        SW_RESTORE      = 9,
        SW_SHOWDEFAULT      = 10,
        SW_FORCEMINIMIZE    = 11,
        SW_MAX          = 11
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DLLVERSIONINFO
    {
        public int cbSize;
        public int dwMajorVersion;
        public int dwMinorVersion;
        public int dwBuildNumber;
        public int dwPlatformID;
    }

    class FuncLib
    {
        [DllImport("shell32.dll")]
        public static extern IntPtr ShellExecute(
            IntPtr hwnd,
            string lpOperation,
            string lpFile,
            string lpParameters,
            string lpDirectory,
            ShowCommands nShowCmd);

        [DllImport("shlwapi.dll")]
        static extern int DllGetVersion(ref DLLVERSIONINFO pdvi);

        public  static DLLVERSIONINFO GetIEVesion()
        {
            DLLVERSIONINFO DVI = new DLLVERSIONINFO();
            DVI.cbSize = Marshal.SizeOf(typeof(DLLVERSIONINFO));
            int ret = DllGetVersion(ref DVI);
            return DVI;
        }

        [DllImport("shdocvw.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern long DoOrganizeFavDlg(long hWnd, string lpszRootFolder);

        public static string EncryptXOR(string Text, string Password)
        {
            string retVal="";
            foreach (char letter in Password.ToCharArray())
            {
                retVal = retVal + Strings.Chr(Strings.Asc(letter) ^ 255);
            }
            return retVal;
        }

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        public static void CloseAllIEWindows()
        {
            ShellWindows shWin = new ShellWindows();
            for (int i = 0; i < shWin.Count; i++)
            {                
                InternetExplorer ie = (InternetExplorer)shWin.Item(i);
                if (ie.FullName.ToUpper().EndsWith(@"\IEXPLORE.EXE"))
                    ie.Quit();                
            }
        }

        public static void OpenNewIEWindow()
        {
            Process IEProcess = new Process();
            IEProcess.StartInfo.FileName = "IExplore.exe";
            IEProcess.Start();
        }

        public static void OpenURL(string URL)
        {
            Process processURL = new Process();
            processURL.StartInfo.FileName = URL;
            processURL.Start();
        }

        public static bool IsNumeric(string value)
        {
            return Information.IsNumeric(value);
        }

        public static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
        
    }
}
