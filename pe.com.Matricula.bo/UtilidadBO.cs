using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pe.com.Matricula.bo
{
    public class UtilidadBO
    {
        public void MostrarMensaje(string m, string t, int tp, int i)
        {
            MessageBoxIcon icon;
            MessageBoxButtons btn;
            switch (tp)
            {
                case 1:
                    btn = MessageBoxButtons.OK;
                    break;
                case 2:
                    btn = MessageBoxButtons.OKCancel;
                    break;
                case 3:
                    btn = MessageBoxButtons.YesNoCancel;
                    break;
                default:
                    btn = MessageBoxButtons.OK;
                    break;
            }
            switch (i)
            {
                case 1:
                    icon = MessageBoxIcon.Error;
                    break;
                case 2:
                    icon = MessageBoxIcon.Information;
                    break;
                default:
                    icon = MessageBoxIcon.None;
                    break;
            }
            MessageBox.Show(m, t, btn, icon);
        }
    }


}

