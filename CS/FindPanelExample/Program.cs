using System;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Collections.Generic;

namespace FindPanelExample {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkinManager.EnableFormSkins();
            BonusSkins.Register();
            UserLookAndFeel.Default.SkinName = "Seven";
            Application.Run(new MainForm());
        }
    }
}