using System.Text;

namespace baitaplonC_
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new QuanLyTaiKhoan());
=======
            Application.Run(new Dangnhap());
>>>>>>> 8ce98215e5edf7d6fa303eea8799a752ce8b96a3
        }
    }
}

