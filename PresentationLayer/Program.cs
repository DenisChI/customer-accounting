using System;
using System.Windows.Forms;
using PresentationLayer.Presenters;
using PresentationLayer.Views;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var authPres = new AuthPresenter(new AuthView()); //избавиться от "new", мб при помощи Unity
            IAuthView view = authPres.GetAuthView();
            Application.Run((AuthView)view);
        }
    }
}