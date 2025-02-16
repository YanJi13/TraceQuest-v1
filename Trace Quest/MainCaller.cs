﻿using System;
using System.Windows.Forms;

namespace Trace_Quest {
    internal static class MainCaller {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuGUI());
        }
    }
}
