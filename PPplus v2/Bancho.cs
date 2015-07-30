using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sharkbite.Irc;

namespace PPplus_v2
{
    class Bancho
    {
        public Connection connection; 

        public Bancho()
        {
            CreateConnection();

            connection.Listener.OnPrivate += new PrivateMessageEventHandler(OnPrivate);

            connection.Listener.OnError +=   new ErrorMessageEventHandler(OnError);

            connection.Listener.OnRegistered += new RegisteredEventHandler(OnRegistered);

        }

        private void CreateConnection()
        {
            string server = "irc.ppy.sh";

            string nick = Form1._Username.ToLower();
            string password = Form1._Password;

            ConnectionArgs cargs = new ConnectionArgs(nick, server) { Nick = nick, UserName = nick, ServerPassword = password };

            connection = new Connection(cargs, false, false);
        }



        public void OnRegistered()
        {
            connection.Sender.PrivateMessage(Form1._Username, "Connected!");
        }
        public void start()
        {
            
            try
            {
                connection.Connect();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error during connection to bancho!: " + e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OnPrivate(UserInfo info, string message)
        {
            if (message.ToLower() == "hi")
            {
                connection.Sender.PrivateMessage(info.Nick, "Nobody loves you");
            }
        }

        public void OnError(ReplyCode code, string messaeg)
        {
            Form1.connected = false;
        }

        public void SendMessage(string message)
        {
            connection.Sender.PrivateMessage(Form1._Username.ToLower(), message);
        }

        public void Disconnect()
        {
            connection.Disconnect("Disconnected");
        }

    }
}
