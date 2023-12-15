using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ABC_Bakery.Helpers.MDI
{
    public static class MdiProperties
    {
        [DllImport("user32.dll")]
        private static extern int GetWindowLong(nint hWnd, int nIndex);
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(nint hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        private static extern int SetWindowPos(nint hWnd, int hWndInsertAfter, int x, int y, int cx, int cy, uint wFlags);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_CLIENTEDGE = 0x200;
        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_NOZORDER = 0x0004;
        private const uint SWP_NOACTIVATE = 0x0010;
        private const uint SWP_NOREDRAW = 0x0008;
        private const uint SWP_FRAMECHANGED = 0x0020;
        private const uint SWP_NOOWNERZORDER = 0x0200;


        public static bool SetBevel(this Form form, bool value)
        {
            foreach (Control control in form.Controls)
            {
                MdiClient client = control as MdiClient;
                if (client != null)
                {
                    int windowLong = GetWindowLong(client.Handle, GWL_EXSTYLE);
                    if (value)
                    {
                        windowLong |= WS_EX_CLIENTEDGE;
                    }
                    else
                    {
                        windowLong &= ~WS_EX_CLIENTEDGE;
                    }
                    SetWindowLong(client.Handle, GWL_EXSTYLE, windowLong);
                    SetWindowPos(client.Handle, 0, 0, 0, 0, 0, SWP_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER | SWP_FRAMECHANGED);
                    return true;
                }
            }
            return false;
        }
    }
}
