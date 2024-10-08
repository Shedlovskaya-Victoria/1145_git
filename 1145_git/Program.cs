using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;

namespace _1145_git
{
    internal class Program
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_MAXIMIZE = 3;

        static void Main(string[] args)
        {

            IntPtr handle = GetConsoleWindow();
            ShowWindow(handle, SW_MAXIMIZE);

            Console.SetBufferSize(2000, 900);
            //Console.SetWindowSize(2000, 900);
            Graphics graphics = Graphics.FromHwnd(Process.GetCurrentProcess().MainWindowHandle);
            var types = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in types)
            {
                if (type.IsPublic && type.IsClass)
                { 
                    var instance = Activator.CreateInstance(type) as IDraw;
                    instance.Draw(graphics);
                }
            }

            Console.ReadLine();
        }
    }
}
