using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Restosoft.GUIs;

namespace Restosoft
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Pantalla_Principal());
        }
    }
}
