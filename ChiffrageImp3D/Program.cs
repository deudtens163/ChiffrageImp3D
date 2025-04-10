using System.Runtime.InteropServices;

namespace ChiffrageImp3D;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]

    
    //[DllImport("kernel32.dll")] //dbg
    //private static extern bool AllocConsole(); //dbg

    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();       
        Application.Run(new FormMain());
    }
}