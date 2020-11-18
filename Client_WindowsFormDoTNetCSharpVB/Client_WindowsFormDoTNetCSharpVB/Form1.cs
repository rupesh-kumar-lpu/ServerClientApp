using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Client_WindowsFormDoTNetCSharpVB
{

    public partial class Form1 : Form
    {

        TcpClient client;
        readonly NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;
        string username;
       

        public object ToastNotificationManager { get; private set; }
        public object ToastActivationType { get; private set; }
        public object DesktopNotificationManagerCompat { get; private set; }

        public Form1()
        {
            InitializeComponent();

            client = new TcpClient("127.0.0.1", 8888);
            ns = client.GetStream();
            sr = new StreamReader(ns);
            sw = new StreamWriter(ns);
            sw.AutoFlush = true;

            username = "Honey";
            sw.WriteLine("Entered" + ">> " + username);
            msgstb.AppendText("\n"+sr.ReadLine() + "\n");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sendbt_Click(object sender, EventArgs e)
        {
            string msg = tosendtb.Text.Trim();
            sw.WriteLine(username + ">> " + msg);
            tosendtb.Clear();
            msgstb.AppendText( sr.ReadLine() + "\n");
            

        }
    }
}
