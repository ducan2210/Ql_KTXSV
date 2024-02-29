using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace thietKeControls
{
    public class txtEmail:TextBox
    {
        ErrorProvider er = new ErrorProvider();
        public txtEmail()
        {
            this.TextChanged += txtEmail_TextChanged;
        }

        void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if(IsEmail(this.Text.ToString())==false)
            {
                er.SetError(this, "Định dạng email bị sai");
            }
            else
            {
                er.Clear();
            }
            
        }
        public static bool IsEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;
            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
    }
}
