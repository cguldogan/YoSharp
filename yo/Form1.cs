using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendYo_Click(object sender, EventArgs e)
        {
            using (var wb = new WebClient())
            {

                var data = new NameValueCollection();

                string token = txtToken.Text;
                string url = "http://api.justyo.co/yoall/";
                data["api_token"] = token;


                var response = wb.UploadValues(url, "POST", data);
            }
        }
    }
}
