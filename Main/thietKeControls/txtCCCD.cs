using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thietKeControls
{
    public class txtCCCD:TextBox
    {
        ErrorProvider er = new ErrorProvider();
        public txtCCCD()
        {
            this.KeyPress += txtCCCD_KeyPress;
            this.TextChanged += txtCCCD_TextChanged;
        }

        void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Length <= 11)
            {
                er.SetError(this, "CCCD phai du 12 ki tu");
            }
            else
            {
                er.Clear();
            }
        }

        void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }
    }
}
