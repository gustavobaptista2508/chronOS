using Chronos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoManutencaoComputadores
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin2 frm = new FormLogin2();
            frm.ShowDialog();
            if (frm.logado)
            {
                Application.Run(new FormPrincipal2());
            }
        }
    }
}
