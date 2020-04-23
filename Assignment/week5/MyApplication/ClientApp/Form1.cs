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
using WcfMyService;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            ChannelFactory<IMyService> channel = null;

            if(rdHttpBinding.Checked)
            {
                WSHttpBinding wSHttpBinding = new WSHttpBinding();
                EndpointAddress address = new EndpointAddress("http://localhost:8888/MyService");

                channel = new ChannelFactory<IMyService>(wSHttpBinding, address);
            }
            else if(rdTcpBinding.Checked)
            {
                NetTcpBinding tcpBinding = new NetTcpBinding();
                EndpointAddress address = new EndpointAddress("net.tcp://localhost:8989/MyService");

                channel = new ChannelFactory<IMyService>(tcpBinding, address);
            }
            IMyService myService = channel.CreateChannel();
            lbResult.Text = myService.Hello(txtName.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
