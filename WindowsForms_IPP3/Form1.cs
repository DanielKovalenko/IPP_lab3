using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_IPP3
{
    public partial class Form1 : Form
    {
        private TcpListener listener;

        public Form1()
        {
            InitializeComponent();
            listener = new TcpListener(IPAddress.Any, 8888);
        }

        private void AcceptClient()
        {
            listener.BeginAcceptTcpClient(HandleClient, null); // Приймаємо підключення в асинхронному режимі
        }

        private void HandleClient(IAsyncResult ar)
        {
            TcpClient client = listener.EndAcceptTcpClient(ar); // Отримуємо клієнтський сокет
            byte[] buffer = new byte[1024];
            StringBuilder data = new StringBuilder();
            NetworkStream stream = client.GetStream();

            while (true)
            {
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                data.Append(Encoding.ASCII.GetString(buffer, 0, bytesRead));
                string cursorType = data.ToString();

                // Змінити курсор на сервері на основі вибраного типу
                switch (cursorType)
                {
                    case "CursorType1":
                        Cursor = new Cursor("Resources\\Cursor1.cur");
                        break;
                    case "CursorType2":
                        Cursor = new Cursor("Resources\\Cursor2.cur");
                        break;
                    case "CursorType3":
                        Cursor = new Cursor("Resources\\Cursor3.cur");
                        break;
                }

                data.Clear();
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listener != null && listener.Server.Connected)
            {
                listener.Stop();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            listener.Start(); // Починаємо прослуховування підключень
            AcceptClient();
        }
    }
}