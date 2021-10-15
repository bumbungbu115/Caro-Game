using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Tạo_Bàn_Cờ
{
    public partial class cachchoi : Form
    {
        Thread th;
        public cachchoi()
        {
            InitializeComponent();
        }
        
        void reopendn(object obj)
        {
            Application.Run(new Đangnhap());
        }
        private void cachchoi_FormClosing(object sender, FormClosingEventArgs e)
        {
           /* th = new Thread(reopendn);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
           */
        }

    }
}
