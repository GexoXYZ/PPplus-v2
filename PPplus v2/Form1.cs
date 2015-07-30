using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using MetroFramework.Forms;
using Newtonsoft.Json;


namespace PPplus_v2
{
    public partial class Form1 : MetroForm
    {
        private Bancho banchochat;

        private bool checkedValues;

        public static bool connected;

        private double pp_raw = 0, pp_rank = 0;

        public static string _Username, _Password;

        private string changedMode, changedMode_old, newBest;

        private bool modeChanged = false;

        private ContextMenu m_menu;



        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Inicio_FormClosing_1);
            
                    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSettings();
            }
            catch { }

            m_menu = new ContextMenu();
            m_menu.MenuItems.Add(0, new MenuItem("Exit", new System.EventHandler(Exit_Click)));
            notifyIcon1.ContextMenu = m_menu;


            radio_std.Checked = true;

            changedMode = "std";



        }
        private void Exit_Click(Object sender, EventArgs e)
        {
            try
            {
                if (connected == true)
                {
                    banchochat.Disconnect();
                }
            }
            catch { }
            Application.Exit();
            
        }

        private void Inicio_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            try
            {
                banchochat.Disconnect();
            }
            catch
            {

            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://osu.ppy.sh/p/ircauth");
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://osu.ppy.sh/p/api");
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            _Username = txt_Username.Text;
            if (_Username.Contains(" "))
            {
                _Username = _Username.Replace(' ', '_');
            }

            _Password = txt_IRCpass.Text;

            SaveSettings();

            if (txt_APIkey.Text != "" || txt_IRCpass.Text != "" || txt_Username.Text != "")
            {
                if (validate(txt_Username.Text, txt_APIkey.Text) == "correct")
                {
                    
                   try{
                        banchochat = new Bancho();

                        banchochat.start();

                        btn_Connect.Enabled = false;

                        timer1.Enabled = true;

                        connected = true;
                       
                    }
                    catch
                    {
                        btn_Connect.Enabled = true;
                        timer1.Enabled = false;
                        connected = false;
                    }
                }
                else if (validate(txt_Username.Text, txt_APIkey.Text) == "wrongU")
                {
                    MessageBox.Show("Please make sure you entered the right username!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (validate(txt_Username.Text, txt_APIkey.Text) == "wrongAPI")
                {
                    MessageBox.Show("Please make sure you entered the right API Key!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Please enter your credentials!", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }

        private string validate(string username, string apikey)
        {
            WebClient JSONFetch = new WebClient();

            string RawJSON;

            string usernameFixed = username;
            if (username.Contains(" "))
            {
                usernameFixed = username.Replace(" ", "%20");
            }

            RawJSON = JSONFetch.DownloadString("https://osu.ppy.sh/api/get_user?k=" + apikey + "&u=" + usernameFixed + "&m=0&type=string");

            if (RawJSON == "Please provide a valid API key.")
            {
                return "wrongAPI";
            }
            else if (RawJSON == "[]")
            {
                return "wrongU";
            }
            else
            {
                return "correct";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="type">You can choose between two types: "pp" and "rank"</param>
        /// <param name="apikey"></param>
        /// <returns></returns>
        private double getUser(string username, string type, string apikey)
        {
            //mode (0 = osu!, 1 = Taiko, 2 = CtB, 3 = osu!mania).
            string usernameFixed = username;
            if (username.Contains(" "))
            {
                usernameFixed = username.Replace(" ", "%20");
            }
            #region osu!std

            if (radio_std.Checked)
            {
                try
                {
                    WebClient JSONFetch = new WebClient();

                    string RawJSON;
                    double rawPP;
                    double rankPP;


                    RawJSON =
                        JSONFetch.DownloadString("https://osu.ppy.sh/api/get_user?k=" + apikey + "&u=" + usernameFixed +
                                                 "&m=0&type=string");

                    if (type == "pp")
                    {
                        rawPP = ((dynamic) JsonConvert.DeserializeObject(RawJSON))[0].pp_raw;
                        return rawPP;
                    }
                    else if (type == "rank")
                    {
                        rankPP = ((dynamic) JsonConvert.DeserializeObject(RawJSON))[0].pp_rank;
                        return rankPP;
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch
                {
                    return 0;
                }
            }

            #endregion

            #region osu!mania
            else if (radio_mania.Checked)
            {
                try
                {
                    WebClient JSONFetch = new WebClient();

                    string RawJSON;
                    double rawPP;
                    double rankPP;


                    RawJSON =
                        JSONFetch.DownloadString("https://osu.ppy.sh/api/get_user?k=" + apikey + "&u=" + usernameFixed +
                                                 "&m=3&type=string");

                    if (type == "pp")
                    {
                        rawPP = ((dynamic) JsonConvert.DeserializeObject(RawJSON))[0].pp_raw;
                        return rawPP;
                    }
                    else if (type == "rank")
                    {
                        rankPP = ((dynamic) JsonConvert.DeserializeObject(RawJSON))[0].pp_rank;
                        return rankPP;
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch
                {
                    return 0;
                }
            }

            #endregion

            #region Taiko
            else if (radio_taiko.Checked)
            {
                try
                {
                    WebClient JSONFetch = new WebClient();

                    string RawJSON;
                    double rawPP;
                    double rankPP;


                    RawJSON =
                        JSONFetch.DownloadString("https://osu.ppy.sh/api/get_user?k=" + apikey + "&u=" + usernameFixed +
                                                 "&m=1&type=string");

                    if (type == "pp")
                    {
                        rawPP = ((dynamic)JsonConvert.DeserializeObject(RawJSON))[0].pp_raw;
                        return rawPP;
                    }
                    else if (type == "rank")
                    {
                        rankPP = ((dynamic)JsonConvert.DeserializeObject(RawJSON))[0].pp_rank;
                        return rankPP;
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch
                {
                    return 0;
                }
            }
            #endregion

            #region CtB
            try
            {
                WebClient JSONFetch = new WebClient();

                string RawJSON;
                double rawPP;
                double rankPP;


                RawJSON =
                    JSONFetch.DownloadString("https://osu.ppy.sh/api/get_user?k=" + apikey + "&u=" + usernameFixed +
                                             "&m=2&type=string");

                if (type == "pp")
                {
                    rawPP = ((dynamic)JsonConvert.DeserializeObject(RawJSON))[0].pp_raw;
                    return rawPP;
                }
                else if (type == "rank")
                {
                    rankPP = ((dynamic)JsonConvert.DeserializeObject(RawJSON))[0].pp_rank;
                    return rankPP;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return 0;
            }
            #endregion
        }

        private string getUserBest(string username, string apikey)
        {
            //mode (0 = osu!, 1 = Taiko, 2 = CtB, 3 = osu!mania).
            string usernameFixed = username;
            if (username.Contains(" "))
            {
                usernameFixed = username.Replace(" ", "%20");
            }

            #region osu!std

            if (radio_std.Checked)
            {
                try
                {
                    WebClient JSONFetch = new WebClient();

                    string RawJSON;
                    


                    RawJSON =
                        JSONFetch.DownloadString("https://osu.ppy.sh/api/get_user?k=" + apikey + "&u=" + usernameFixed +
                                                 "&m=0&limit=50&type=string");
                    return RawJSON;


                }
                catch
                {
                    return " ";
                }
            }

                #endregion

                #region osu!mania

            else if (radio_mania.Checked)
            {
                try
                {
                    WebClient JSONFetch = new WebClient();

                    string RawJSON;
                   


                    RawJSON =
                        JSONFetch.DownloadString("https://osu.ppy.sh/api/get_user?k=" + apikey + "&u=" + usernameFixed +
                                                 "&m=3&limit=50&type=string");
                    return RawJSON;


                }
                catch
                {
                    return " ";
                }
            }

                #endregion

                #region Taiko

            else if (radio_taiko.Checked)
            {
                try
                {
                    WebClient JSONFetch = new WebClient();

                    string RawJSON;
                    


                    RawJSON =
                        JSONFetch.DownloadString("https://osu.ppy.sh/api/get_user?k=" + apikey + "&u=" + usernameFixed +
                                              "&m=1&limit=50&type=string");
                    return RawJSON;
                }
                catch
                {
                    return " ";
                }
            }
                #endregion

                #region CtB

            else
            {
                try
                {
                    WebClient JSONFetch = new WebClient();

                    string RawJSON;
                    


                    RawJSON =
                        JSONFetch.DownloadString("https://osu.ppy.sh/api/get_user?k=" + apikey + "&u=" + usernameFixed +
                                                 "&m=2&type=string");
                    return RawJSON;


                }
                catch
                {
                    return "";
                }

                #endregion
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (modeChanged)
            {
                #region PP Change

                if (checkedValues == true)
                {

                    if (getUser(_Username, "pp", txt_APIkey.Text) != pp_raw)
                    {
                        double newPP = getUser(_Username, "pp", txt_APIkey.Text);
                        double pp = newPP - pp_raw;
                        banchochat.SendMessage("+" +
                                               (Math.Round(pp, 2).ToString() + "PP!" + " (" +
                                                (Math.Round(pp_raw, 2).ToString() + " -> " +
                                                 (Math.Round(newPP, 2).ToString() + ")"))));
                    }

                    if (getUser(_Username, "rank", txt_APIkey.Text) != pp_rank)
                    {

                        if (getUser(_Username, "rank", txt_APIkey.Text) > pp_rank)
                        {
                            double newPP = getUser(_Username, "rank", txt_APIkey.Text);
                            double pp = newPP - pp_rank;

                            if (!(pp_rank == 0) || !(newPP == 0))
                            {
                                if (pp == 1)
                                {
                                    banchochat.SendMessage(pp.ToString() + " rank down! (" + pp_rank + " -> " + newPP +
                                                           ")");
                                }
                                else
                                {
                                    banchochat.SendMessage(pp.ToString() + " ranks down! (" + pp_rank + " -> " + newPP +
                                                           ")");
                                }

                            }

                        }
                        else if (getUser(_Username, "rank", txt_APIkey.Text) < pp_rank)
                        {
                            double newPP = getUser(_Username, "rank", txt_APIkey.Text);
                            double pp = pp_rank - newPP;

                            if (!(pp_rank == 0) || !(newPP == 0))
                            {
                                if (pp == 1)
                                {
                                    banchochat.SendMessage(pp.ToString() + " rank up! (" + pp_rank + " -> " + newPP +
                                                           ")");
                                }
                                else
                                {
                                    banchochat.SendMessage(pp.ToString() + " ranks up! (" + pp_rank + " -> " + newPP +
                                                           ")");
                                }

                            }
                        }

                        if (newBest != getUserBest(_Username, txt_APIkey.Text))
                        {
                            MessageBox.Show(newBest.Replace(getUserBest(_Username, txt_APIkey.Text), ""));
                        }

                    }

                }
                else
                {
                    checkedValues = true;
                }

                #endregion
            }
            else
            {
                modeChanged = false;
            }

            newBest = getUserBest(_Username, txt_APIkey.Text);
            pp_rank = getUser(_Username, "rank", txt_APIkey.Text);
            pp_raw = getUser(_Username, "pp", txt_APIkey.Text);

            if(connected == false)
            {
                MessageBox.Show("Error: IRC password does not match!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btn_Connect.Enabled = true;
                timer1.Enabled = false;
                
            }
            


        }

        private void SaveSettings()
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("PPplus");
            if (txt_Username.Text == "" && txt_IRCpass.Text == "" && txt_APIkey.Text == "")
            {
                key.SetValue("Username", "");
                key.SetValue("Password", "");
                key.SetValue("APIkey", "");
            }
            else
            {
                key.SetValue("Username", txt_Username.Text);
                key.SetValue("Password", txt_IRCpass.Text);
                key.SetValue("APIkey", txt_APIkey.Text);
            }

            
            key.Close();
        }

        private void LoadSettings()
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("PPplus");
            txt_Username.Text = (string)key.GetValue("Username");
            txt_IRCpass.Text = (string)key.GetValue("Password");
            txt_APIkey.Text = (string)key.GetValue("APIkey");
          
            key.Close();
        }

        private void Form1_Resize_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://gexo.xyz");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (radio_std.Checked)
            {
                changedMode = "std";
            }
            else if (radio_mania.Checked)
            {
                changedMode = "mania";
            }
            else if (radio_taiko.Checked)
            {
                changedMode = "taiko";
            }
            else if (radio_ctb.Checked)
            {
                changedMode = "ctb";
            }


            if (changedMode != changedMode_old)
            {
                modeChanged = true;
            }

            changedMode_old = changedMode;
        }


    }
}
