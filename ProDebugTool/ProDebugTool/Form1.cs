using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProDebugTool
{
    public partial class Form_Main : Form
    {
        int isOpenServer = 0;
        IPAddress ip;
        Socket mySocket;
        IPEndPoint point = new IPEndPoint(IPAddress.Any, 0);
      

        public Form_Main()
        {
            InitializeComponent();
        }
       
        private void Form_Main_Load(object sender, EventArgs e)
        {
            comboBoxPro.SelectedIndex = 0;
            textBoxIP.Text = GetAddressIP();
            textBoxPot.Text = "7890";
        }

        private string GetAddressIP()
        {
            string AddressIP = "";
            IPAddress ipAddr = Dns.Resolve(Dns.GetHostName()).AddressList[0];
            AddressIP = ipAddr.ToString();
            return AddressIP;
        }

        private static string ByteToHex(byte[] comByte,int length)
        {
            string returnStr = "";
            if (comByte != null)
            {
                for (int i = 0; i < length; i++)
                {
                    returnStr += comByte[i].ToString("X2") + " ";
                }
            }
            return returnStr;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxPro.SelectedIndex==0)   //Tcp Server
                {
                    if (isOpenServer == 0)
                    {
                        ip = IPAddress.Parse(textBoxIP.Text);
                        mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        point = new IPEndPoint(ip, Convert.ToInt32(textBoxPot.Text));
                        mySocket.Bind(point);
                        mySocket.Listen(10);
                        labelinfo.ForeColor = Color.SeaGreen;
                        labelinfo.Text = "服务启动成功";
                        isOpenServer = 1;
                        Thread thReceive = new Thread(TSReceive);
                        thReceive.IsBackground = true;
                        thReceive.Start();
                    }
                    else
                    {
                        MessageBox.Show("服务已经启动");
                    }
                }
                else
                {
                    MessageBox.Show("暂时不支持!"); 
                }
            }
            catch (Exception ex)
            {

            }
        }

        private  void TSReceive()
        {
            while (true)
            {
                Socket aimSocket = mySocket.Accept();
                Thread receiveThread = new Thread(ReceiveMessage);
                receiveThread.IsBackground = true;
                receiveThread.Start(aimSocket);
            }
        }
        private void ReceiveMessage(object aimSocket)
        {
            byte[] buffer = new byte[1024];
            Socket myClientSocket = (Socket)aimSocket;
            while (true)
            {
                try
                {
                    int renum = myClientSocket.Receive(buffer);
                    if (renum != 0)
                    {
                        string strRec = Encoding.Default.GetString(buffer, 0, renum);
                        if (checkBoxhex.Checked)textBre.AppendText(myClientSocket.RemoteEndPoint.ToString() + ":" +"["+ ByteToHex(buffer, renum) +"]"+ "\r\n");
                        else textBre.AppendText(myClientSocket.RemoteEndPoint.ToString() + ":" +"["+ strRec +"]"+ "\r\n");
                    }
                }
                catch (Exception ex)
                {
                    myClientSocket.Shutdown(SocketShutdown.Both);
                    myClientSocket.Close();
                    break;  
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBre.Text = "";
        }

    }
}
