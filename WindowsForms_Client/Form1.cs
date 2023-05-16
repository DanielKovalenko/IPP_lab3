using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_Client
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;

        public Form1()
        { 
            InitializeComponent();
            client = new TcpClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client.Connect("127.0.0.1", 8888); // Підключаємося до сервера за IP-адресою та портом
                stream = client.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка підключення до сервера: " + ex.Message);
            }
        }

        private void CursorButton_Click(object sender, EventArgs e)
        {
            string cursorType = CursorComboBox.SelectedItem.ToString();
            byte[] data = Encoding.ASCII.GetBytes(cursorType);
            stream.Write(data, 0, data.Length);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client.Connected)
            {
                client.Close();
                stream.Close();
            }
        }
    }
}