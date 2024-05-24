using SisBclinica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisBclinica.CLS
{
    internal class AppManager : ApplicationContext
    {
        private Boolean Splash()
        {
            Boolean Resultado = true;
            GUI.Splash f = new GUI.Splash();
            f.ShowDialog();

            return Resultado;
        }


        private Boolean Login()
        {
            Boolean Resultado = true;
            GUI.Login f = new GUI.Login();
            f.ShowDialog();
            Resultado = f.Autorizado;

            return Resultado;
        }
        public AppManager()
        {

            if (Splash())
            {
                if (Login())
                {
                    GUI.Principal f = new GUI.Principal();
                    f.ShowDialog();
                }
            }

        }


    }
}
