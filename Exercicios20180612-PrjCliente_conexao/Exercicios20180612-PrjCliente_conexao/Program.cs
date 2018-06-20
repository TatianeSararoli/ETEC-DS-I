using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Exercicios20180612_PrjCliente_conexao
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Cadastro());
        }
    }
}
