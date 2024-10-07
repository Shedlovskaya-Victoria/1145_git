using System.Diagnostics;
using System.Drawing;
using System.Reflection;

namespace _1145_git
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
