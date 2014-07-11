using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            if (string.IsNullOrEmpty(txtToken.Text.Trim()))
                return;

            using (var wb = new WebClient())
            {

                var data = new NameValueCollection();

                string token = txtToken.Text;
                string url = "http://api.justyo.co/yoall/";
                data["api_token"] = token;


                var response = wb.UploadValues(url, "POST", data);

                //todo: json parse need in here
                lblErr.Text = string.Format("\nResponse received was :\n{0}", Encoding.ASCII.GetString(response));
            }
        }


        //not tested yet
        private void btnYoIndividual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtYoUserName.Text.Trim()) & string.IsNullOrEmpty(txtToken.Text.Trim()))
                return;

            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();

                string token = txtToken.Text;
                string url = "http://api.justyo.co/yo/";
                data["api_token"] = token;
                data["username"] = txtYoUserName.Text.Trim();

                var response = wb.UploadValues(url, "POST", data);

                //todo: json parse need in here
                lblErr.Text = string.Format("\nResponse received was :\n{0}", Encoding.ASCII.GetString(response));
            }

        }

        private void CountTotal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtToken.Text.Trim()))
                return;

            using (var wb = new WebClient())
            {

                var token = txtToken.Text;

                var uri = @"http://api.justyo.co/subscribers_count/?api_token="+ token;

                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(uri);
                request.Method = "GET";
                String test = String.Empty;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    test = reader.ReadToEnd();

                    //todo: json parse need in here
                    test = test.Split(':')[1].Replace("}", "");

                    reader.Close();
                    dataStream.Close();

                    lblCount.Text = test;
                }

            }
        }
    }
}
