using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thietKeControls
{
    public class txtChiNhapChu:TextBox
    {
        public txtChiNhapChu()
        {
            this.KeyPress += txtChiNhapChu_KeyPress;
        }

        void txtChiNhapChu_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
