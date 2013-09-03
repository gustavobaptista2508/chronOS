using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chronos.Classes
{
    public class ToolTipHelper
    {
        public static void ShowToolTip(out ToolTip toolTip, Control control, string title, string message)
        {
            toolTip = new ToolTip();
            toolTip.IsBalloon = true;
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = title;
            toolTip.Show(string.Empty, control, 0);
            toolTip.Show(message, control, control.Width / 2, control.Height, 2000);
        }
    }
}
