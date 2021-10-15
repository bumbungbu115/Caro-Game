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
    public partial class Đangnhap : Form
    {
        Thread th;
        public Đangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #region opencachchoi
        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
            /* th = new Thread(opencachchoi);
             th.SetApartmentState(ApartmentState.STA);
             th.Start();*/
          //this.Hide();
            var cachchoi = new cachchoi();
            //cachchoi.Closed += (s, args) => this.Close();
            cachchoi.Show();
        }
        private void opencachchoi(object obj)
        {
            Application.Run(new cachchoi());
        }
        #endregion

        #region openLogin
        private void button1_Click(object sender, EventArgs e)
        {
            /*this.Close();
            th = new Thread(opennewlogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();*/
            this.Hide();
            var login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }
        private void opennewlogin(object obj)
        {
            Application.Run(new Login());
        }
        #endregion

        #region openRegister
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           /* this.Close();
               th = new Thread(openDK);
               th.SetApartmentState(ApartmentState.STA);
               th.Start();*/
            this.Hide();
            var dangky = new Dangky();
            dangky.Closed += (s, args) => this.Close();
            dangky.Show();
        }
        private void openDK(object obj)
        {
            Application.Run(new Dangky());
        }
        #endregion

        #region aboutgame
         private void button3_Click(object sender, EventArgs e)
        {
           
            CuaSoChinh.Ptbox = 2;
            //this.Hide();
            var aboutgame = new aboutgame();
            //aboutgame.Closed += (s, args) => this.Close();
            aboutgame.Show();
            
        }
        private void openAG(object obj)
        {
            CuaSoChinh.Ptbox = 2;
            Application.Run(new aboutgame());
        }
        #endregion
        private void Đangnhap_Load(object sender, EventArgs e)
        {
           
           
        }
    }
}
