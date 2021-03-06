using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
namespace WindowsFormWCFClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client("NetTcpBinding_IService1");
            label1.Text = client.GetMessage(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CompanyService.CompanyConfidentialServiceClient client = new CompanyService.CompanyConfidentialServiceClient("NetTcpBinding_ICompanyConfidentialService");
            label3.Text = client.GetConfidentialInformation();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CompanyService.CompanyServiceClient client = new CompanyService.CompanyServiceClient("BasicHttpBinding_ICompanyService");
            label2.Text = client.GetPubicInformation();
        }
    }
}
