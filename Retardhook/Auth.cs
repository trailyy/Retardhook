using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Retardhook
{
    public partial class Auth : Form
    {
        bool rememberstate;
        string faggot = "false";
        string _u = Crypt.Decrypt("wwu8C1XAae8BkSW1c6SK7QD+lAuxXtZ2lFVH/cL/VrhURCPS4CTgW/EdtOKbtkGBnRtCHbLHLkAuecGiWpYWFftFdxjrdNoGVOleOolYLNXUOjjgHaFCMiwHXWiB2ZjNVfnnkvEF4mbwIJcamejdWl7bE5H3ku21mIurbjisALlVRrvqrEdCeUwaKW4/ywr7mM1+pa58Aj1GbRSMy0pj6zHZLYO5ge5H++iUdfcnaVY=", "BzIYWuAXCwfkkAsJ");
        string _p = Crypt.Decrypt("j8JnlwmHYjY4l7qNkgvKA0eapKpq8P/BfD3p9CjbzM6on/ewiOgWNvJnYKrUdywuYQraUgEzLsIYptNDjCHltlSdHZQahrjZXULTofGXyNWDzyyexmjapJBUXsaIKiatAB0c6fVybVuYl7wMeTGlwbmJYNmzX+105ZeAXx840jacJjMdX21nbrvmesCEjfMEzZSc6wsMKmH0IO9sfUmvneNiQi7cN6PTqpQHgCWAR28=", "rWXDVjwWzZxSVesw");
        string _r = Crypt.Decrypt("O7er2neYluN2l9BXOGBvm5S0EiMb1UPd4/UrkFrOodHfNLtfzIGahN4PrelxMTvQdQUIhAVhuNDwjnePOdJakduGIiOSYVcLKGUwCvRxcwCZfeGUVWiiKTfzWO9dklTU/tD9Tb2PUxeq7UslkaR5IdeQc5YO92I6Hc1dQBo/vPrsRM8Z132a0Lv9WOtJTw4gBWhaR0OmLbIhEtCRSMzMn4ZNDbS20x0C2ouh90jrtX8=", "yybBdksbyxnbVDkV");
        
        void GetRememberState()
        {
            if (File.Exists(_r))
            {
                if (Crypt.Decrypt(File.ReadAllText(_r), "DillXreFdwEXwTAw") == "true")
                {
                    rememberstate = true;
                }
                else
                {
                    rememberstate = false;
                }
            }
            else
            {
                return;
            }
        }

        public Auth()
        {
            GetRememberState();
            InitializeComponent();
            if (!File.Exists(_u) || !File.Exists(_p))
            {
                usernameText.Text = "";
                passwordText.Text = "";
                rememberCheck.Checked = false;
            }
            else
            {
                usernameText.Text = Crypt.Decrypt(File.ReadAllText(_u), "obTZNcdLZKysMvdR");
                passwordText.Text = Crypt.Decrypt(File.ReadAllText(_p), "wRXlQyxIQKkWhAUi");
                rememberCheck.Checked = rememberstate;
            }

        }

        Timer t1 = new Timer();

        private void Auth_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            t1.Interval = 10;
            t1.Tick += new EventHandler(fadeIn);
            t1.Start();
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();
            else
                Opacity += 0.01;
        }  

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (rememberCheck.Checked)
            {
                faggot = "true";
                using (StreamWriter sw = File.CreateText(_u))
                {
                    sw.Write(Crypt.Encrypt(usernameText.Text, "kbHVMbIaFZMNslsh"));
                }
                using (StreamWriter sw = File.CreateText(_p))
                {
                    sw.Write(Crypt.Encrypt(passwordText.Text, "RmbevNerdLJCrGdY"));
                }
                using (StreamWriter sw = File.CreateText(_r))
                {
                    sw.Write(Crypt.Encrypt(faggot, "pOHjnIETIxgpliPd"));
                }
            }
            else
            {
                faggot = "false";
                using (StreamWriter sw = File.CreateText(_u))
                {
                    sw.Write(Crypt.Encrypt("Username", "RCEuYpnWxQrBRFiy"));
                }
                using (StreamWriter sw = File.CreateText(_p))
                {
                    sw.Write(Crypt.Encrypt("Password", "wmXceIuJiHVxgnFv"));
                }
                using (StreamWriter sw = File.CreateText(_r))
                {
                    sw.Write(Crypt.Encrypt(faggot, "veknCizzajmWRCBC"));
                }
            }

            string url = "k+3N0fahtXmZGsZX2c8wqDEmHEfdnpeDCtI0hfWs3AlkWTtFbyM2F0gIIutL47vfVyyDJd/5vBmOhtyLlyJIvLRTppILwFmUuwNmXCvUXsfFTiyuGiJgafGWhfktdLUwOgTlfKnjDnkFJ5WRKEUAeYTXQzF83Pw5j7nF9nUsIPRcm3LxdV6Qlswui89qYCrqU/P0Rod7TdJklj5EO16clh4+KTgvRmSVXWH+iQT6XUI=";

            WebClient wc = new WebClient();
            string users = wc.DownloadString(Crypt.Decrypt(url, "WbHRlyhMlAZFOihz"));
            if (!users.Contains(usernameText.Text + ":" + passwordText.Text + ":" + HWID.GetHWID()) || usernameText.Text == "" || passwordText.Text == "")
            {
                MessageBox.Show("Error (1)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(users.Contains(usernameText.Text + ":" + passwordText.Text + ":" + HWID.GetHWID()))
            {
                this.Hide();
                Waiting waiting = new Waiting();
                waiting.Show();
            }
        }
    }
}