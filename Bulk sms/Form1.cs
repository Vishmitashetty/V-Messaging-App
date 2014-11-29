using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Bulk_sms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                string to, msg;
               
                to = textBoxTo.Text;
                msg = textBoxMsg.Text;

                string baseurl = "http://api.mVaayoo.com/mvaayooapi/MessageCompose?user=vinayakrai9@gmail.com:vinayak&senderID=TEST SMS&receipientno="+to+"&dcs=0&msgtxt='"+msg+"'&state=4 ";
                client.OpenRead(baseurl);
               MessageBox.Show("Successfully Send Message");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
