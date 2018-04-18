using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipGameOpenTK
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           using (ShipGame game = new ShipGame()) {
               game.Run(30.0f);
           }
        }
    }
}
