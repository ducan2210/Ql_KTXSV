using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace thietKeControls
{
    public class btnDoiMau:Button
    {
        public btnDoiMau()
        {
            this.MouseHover += btnDoiMau_MouseHover;
            this.MouseLeave += btnDoiMau_MouseLeave;
        }

        void btnDoiMau_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        void btnDoiMau_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}
