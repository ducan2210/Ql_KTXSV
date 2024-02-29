using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace thietKeControls
{
    public class dtgvDoiMauTheoDong : DataGridView
    {
        public dtgvDoiMauTheoDong()
        {
            this.RowPrePaint += dtgvDoiMauTheoDong_RowPrePaint;
        }

        void dtgvDoiMauTheoDong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if(e.RowIndex%2==0)
            {
                this.DefaultCellStyle.BackColor = Color.Orange;
            }
        }
    }
}
