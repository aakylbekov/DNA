using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClientApi
{
    [Flags]
    public enum AccessRight : long
    {
        DESKTOP_READOBJECTS = 0x00000001,
        DESKTOP_CREATEWINDOW = 0x00000002,
        DESKTOP_CREATEMENU = 0x00000004,
        DESKTOP_HOOKCONTROL = 0x00000008,
        DESKTOP_JOURNALRECORD = 0x00000010,
        DESKTOP_JOURNALPLAYBACK = 0x00000020,
        DESKTOP_ENUMERATE = 0x00000040,
        DESKTOP_WRITEOBJECTS = 0x00000080,
        DESKTOP_SWITCHDESKTOP = 0x00000100,

        GENERIC_ALL = (DESKTOP_READOBJECTS | DESKTOP_CREATEWINDOW | DESKTOP_CREATEMENU |
            DESKTOP_HOOKCONTROL | DESKTOP_JOURNALRECORD | DESKTOP_JOURNALPLAYBACK |
            DESKTOP_ENUMERATE | DESKTOP_WRITEOBJECTS | DESKTOP_SWITCHDESKTOP)
    };
    static class UnmanagedCodeCall
    {
        [DllImport("Bridge.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double DistanceFromZeroToBasePoint
            (double baseOx, double baseOy, double baseOz);

        [DllImport("Bridge.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetSomeRandomPointer();

        [DllImport("Bridge.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetSomeString(StringBuilder str, int len);
        [DllImport("Bridge.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr GetIntArray();

        [DllImport("wininet.dll", SetLastError = true)]
        public static extern bool InternetCheckConnection(string lpszUrl, int dwFlags, int dwReserved);

        [DllImport("Advapi32.dll")]
        public static extern bool GetUserName(StringBuilder lpBuffer, ref int nSize);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool LockWorkStation();

    }
    class Program
    {
        static void Main(string[] args)
        {
            UnmanagedCodeCall.LockWorkStation();
            Console.ReadLine();
        }
    }
}
