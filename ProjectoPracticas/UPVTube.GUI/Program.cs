﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.Persistence;
using UPVTube.Services;

namespace UPVTube.GUI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IUPVTubeService service = new UPVTubeService(new EntityFrameworkDAL(new UPVTubeDbContext()));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UPVTubeApp(service));
        }
    }
}
