using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoManutencaoComputadores.Service.Local
{
    public class DataBaseInitializer
    {
        public static void CriarPasta()
        {
            DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "App_Data");
            di.Create();
            foreach (FileInfo file in di.GetFiles("*.mdf"));
        }
    }
}
