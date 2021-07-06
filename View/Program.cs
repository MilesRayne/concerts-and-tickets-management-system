using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Exceptions;

namespace View
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            while (true)
            {
                try
                {
                    //Prikaz početnog ekrana klijenta tj. login forme
                    GUICoordinator.Instance.OpenLoginForm();
                    Application.Run();

                } catch (ServerException e)
                {
                    MessageBox.Show(e.Message);
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
