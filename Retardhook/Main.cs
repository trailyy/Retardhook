/*
 * 
 * This is the source code of Retardhook, a Growtopia external trainer made in C#.
 * 
 * The whole thing was supposed to be a small project as back then i recently started cheating in Growtopia.
 * Project started in November 2020, then i met latrom/mortal and arky which helped me with the trainer.
 * 
 * You may be wondering, why am i releasing the source code of this trainer?
 * The answer is that i simply dont care and the overall code sucks cock.
 * 
 * I don't recommend selling this as your product because the protection is really poor and the whole program
 * is really easy to reverse.
 * 
 * It was fun working on the project but you gotta move on.
 * 
 * Cheat features:
 *      - shit code
 *      - basic trainer features
 *      - shit wannabe p2c auth
 *      - overall the project is fucking garbage
 *      - antipaste ;DD
 * 
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Collections.Generic;
using System.IO;
using Memory;
using Microsoft.Win32;
using DiscordRPC;
#pragma warning disable CS0414

namespace Retardhook
{
    public partial class Main : Form
    {
        #region Retardhook
        #region Opcodes

        /*
         *
         * Uh oh, looks like romanian jews stole the signatures...
         *
         */

        #region Main Hacks
        string op_noban = "Growtopia.exe+2B7C73";
        string op_nosetback = "Growtopia.exe+3ABB4E";
        string op_nointegrity = "Growtopia.exe+39FCF3";
        string op_antibounce = "Growtopia.exe+40A2E3";
        string op_antispike = "Growtopia.exe+3AA50E";
        string op_antilava = "Growtopia.exe+3A693C";
        string op_anticactus = "Growtopia.exe+3A601C";
        string op_antipunch = "Growtopia.exe+3B4509";
        string op_antislide = "Growtopia.exe+3AE342";
        string op_antirespawn = "Growtopia.exe+595CEB";
        string op_antirespawnv2 = "Growtopia.exe+8D8E4";
        string op_spikeantirespawn = "Growtopia.exe+5963BB";
        string op_antigravity = "Growtopia.exe+3B88A4";
        string op_antiportal = "Growtopia.exe+3AF29C";
        string op_anticheckpoint = "Growtopia.exe+3F998A";
        string op_autorespawn = "Growtopia.exe+3F99AA";
        string op_airpinball = "Growtopia.exe+3AA314";
        string op_climbmode1 = "Growtopia.exe+3AA129";
        string op_climbmode2 = "Growtopia.exe+3AA0D0";
        string op_doublejump = "Growtopia.exe+3AE3C5";
        string op_unlimitedjump = "Growtopia.exe+3AE3E7";
        string op_moonwalk = "Growtopia.exe+3AD288";
        string op_moonwalk2 = "Growtopia.exe+3AD28A";
        string op_lockeddoor = "Growtopia.exe+3B056C";
        string op_dancemove = "Growtopia.exe+FCD60";
        string op_dancemove2 = "Growtopia.exe+3A44EF";
        string op_dancemove3 = "Growtopia.exe+FCD67";
        string op_deathplat = "Growtopia.exe+3F99C8";
        string op_walkinair = "Growtopia.exe+409297";
        string op_modzoom = "Growtopia.exe+2A955F";
        string op_devmode = "Growtopia.exe+2BAD51";
        string op_ghost = "Growtopia.exe+3ACA72";
        string op_ghostpunch = "Growtopia.exe+3A122D";
        string op_fastpunch = "Growtopia.exe+2C4AD5";
        string op_lockedchest = "Growtopia.exe+417F18";
        string op_fastfall = "Growtopia.exe+4092FD";
        string op_fastfall2 = "Growtopia.exe+3B85E6";
        string op_growz = "Growtopia.exe+3AD311";
        string op_gravity = "Growtopia.exe+3B8425";
        string op_gravityv2 = "Growtopia.exe+3B83C5";
        string op_slidewalk = "Growtopia.exe+3AE344";
        string op_slime = "Growtopia.exe+3AE088";
        string op_slimeloop = "Growtopia.exe+3AE096";
        string op_fly = "Growtopia.exe+3B7DE9";
        string op_tutbypass = "Growtopia.exe+3ACB56";
        string op_noclip = "Growtopia.exe+3F99B7";
        string op_frogmode = "Growtopia.exe+3AC62C";
        string op_timemachine = "Growtopia.exe+3FADA3";
        string op_seeghost = "Growtopia.exe+3DC6A6";
        string op_modspawn = "Growtopia.exe+584EFC";
        string op_slowwalk = "Growtopia.exe+3AD288";
        string op_slowwalk2 = "Growtopia.exe+3AD322";
        string op_slowmotion = "Growtopia.exe+8D889";
        string op_speedymode = "Growtopia.exe+3AD37D";
        string op_pickup_up = "Growtopia.exe+3B9E16";
        string op_dicehack = "Growtopia.exe+3F67D0";
        string op_tractormode = "Growtopia.exe+3AEF06";
        string op_plowmode = "Growtopia.exe+3AEA46";
        string op_holddownseed = "Growtopia.exe+2C4C65";
        string op_seed_in_air = "Growtopia.exe+2C55AF";
        string op_placeinblock = "Growtopia.exe+2C51CB";
        string op_nightvision = "Growtopia.exe+3EA2C9";
        string op_fast_drop_take = "Growtopia.exe+4059BF";
        string op_deadmove = "Growtopia.exe+3A9243";
        string op_giveaway1 = "Growtopia.exe+3F99B7";
        string op_giveaway2 = "Growtopia.exe+2D4302";
        string op_giveaway3 = "Growtopia.exe+3ACA72";
        string op_giveaway4 = "Growtopia.exe+409297";
        string op_waterhack = "Growtopia.exe+3AB294";
        string op_chatcheck = "Growtopia.exe+6AB2B4";
        string op_watermark = "Growtopia.exe+552448";
        string op_forcefps = "Growtopia.exe+18D43";
        string op_versionbypass = "Growtopia.exe+56435C";
        string op_inflives_client = "Growtopia.exe+3A74A5";
        string op_anti_everything = "Growtopia.exe+3AF357";
        string op_cantmove = "Growtopia.exe+406510";
        string op_anti_oneway1 = "Growtopia.exe+406548";
        string op_anti_oneway2 = "Growtopia.exe+406559";
        #endregion

        #region Visuals
        string op_darkmode = "Growtopia.exe+420BC4";
        string op_nochat = "Growtopia.exe+40BE50";
        string op_blockfuck = "Growtopia.exe+41FB21";
        string op_rainbowblocks = "Growtopia.exe+41FD56";
        string op_cummode = "Growtopia.exe+4247D3";
        string op_noname = "Growtopia.exe+3A1F62";
        string op_noshadow = "Growtopia.exe+42411D";
        string op_autismmode = "Growtopia.exe+A2AC0";
        string op_goblinname = "Growtopia.exe+3A1B3C";
        string op_virginmode = "Growtopia.exe+19941F";
        string op_mirroreff = "Growtopia.exe+FCB00";
        string op_playersize_1 = "Growtopia.exe+FCB36";
        string op_playersize_2 = "Growtopia.exe+FCB55";
        string op_playersize_3 = "Growtopia.exe+FCB73";
        string op_playersize_4 = "Growtopia.exe+FCBA8";
        string op_nomouth = "Growtopia.exe+F587E";
        string op_putinmode = "Growtopia.exe+FCB36";
        string op_smallplayer = "Growtopia.exe+FCB55";
        string op_bigplayer = "Growtopia.exe+FCB73";
        string op_snowman = "Growtopia.exe+19D1FD";
        string op_cancermode = "Growtopia.exe+19D211";
        string op_invischars = "Growtopia.exe+19D1E2";
        string op_explodingblocks = "Growtopia.exe+E2183";
        string op_rainbowinventory = "Growtopia.exe+3981B6";
        string op_seefruits = "Growtopia.exe+3E32BC";
        string op_freezeitems = "Growtopia.exe+419BD5";
        string op_noborder = "Growtopia.exe+4195B2";
        string op_burningheads = "Growtopia.exe+D0E17";
        #endregion

        #region Pointers
        string pointer_spin = "Growtopia.exe+006A8678,AA8,198,60";//
        string pointer_devzoom = "Growtopia.exe+006A8678,AA8,198,17A";//
        string pointer_playercount = "Growtopia.exe+006A8678,AA8,170";//
        string pointer_status = "Growtopia.exe+006A8678,AA8,198,188";//
        string pointer_zoom = "Growtopia.exe+006A8678,AA8,198,179";//
        string pointer_freeze = "Growtopia.exe+006A8678,AA8,198,138";//

        string pointer_xpos = "Growtopia.exe+006A8678,AA8,198,8";//
        string pointer_ypos = "Growtopia.exe+006A8678,AA8,198,C";//
        string pointer_xpunchpos = "Growtopia.exe+006A8678,AA8,198,2BE";//
        string pointer_ypunchpos = "Growtopia.exe+006A8678,AA8,198,1A4";//
        string pointer_xdroppedpos = "Growtopia.exe+00791CF0,8";//
        string pointer_ydroppedpos = "Growtopia.exe+00791CF0,C";//

        string pointer_name = "Growtopia.exe+006A8678,AA8,198,28";//
        string pointer_hair = "Growtopia.exe+006A8678,AA8,198,2C2";//
        string pointer_hat = "Growtopia.exe+006A8678,AA8,198,2B4";//
        string pointer_face = "Growtopia.exe+006A8678,AA8,198,2BC";//
        string pointer_neck = "Growtopia.exe+006A8678,AA8,198,2C4";//
        string pointer_shirt = "Growtopia.exe+006A8678,AA8,198,2B6";//
        string pointer_pants = "Growtopia.exe+006A8678,AA8,198,2B8";//
        string pointer_hand = "Growtopia.exe+006A8678,AA8,198,2BE";//
        string pointer_wings = "Growtopia.exe+006A8678,AA8,198,2C0";//
        string pointer_feet = "Growtopia.exe+006A8678,AA8,198,2BA";//
        string pointer_punch = "Growtopia.exe+006A8678,AA8,198,1A4";//
        string pointer_selected_item = "Growtopia.exe+006A8678,AA8,248";//
        string pointer_gems = "Growtopia.exe+006A8678,AA8,250";//
        //string pointer_skin = "Growtopia.exe+006A8678,aa8,198,328";
        #endregion
        #endregion

        #region General Code
        public Main()
        {
            InitializeComponent();
        }

        public static string g_secret_path = Crypt.Decrypt("wwu8C1XAae8BkSW1c6SK7QD+lAuxXtZ2lFVH/cL/VrhURCPS4CTgW/EdtWiB2ZjNVfnnkvEF4mbwIJcamejdWl7bE5H3ku21mIurbjisALlVRrvqrEdCeUwaKW4/ywr7mM1+pa58Aj1GbRSMy0pj6zHZLYO5ge5H++iUdfcnaVY=", "BgJNUjLyGYjHusml");
        public static string g_retardhook_path = @"C:\Retardhook";
        public static string g_current_version = "3.56";
        public static string g_spoofed_version = "4.20";

        bool fakelag = false;
        bool spinbot = false;

        public Mem m = new Mem();

        int r = 244, g = 65, b = 65;
        int rgbState = 0;

        public const uint WM_KEYDOWN = 0x100;
        public const uint WM_KEYUP = 0x0101;

        public TypeConverter converter = TypeDescriptor.GetConverter(typeof(Keys));
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, uint vlc);
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id); 
        [DllImport("user32.dll")]
        public static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        public void Spam(IntPtr Handle, string Text)
        {
            PostMessage(Handle, WM_KEYDOWN, (IntPtr)(Keys.Enter), IntPtr.Zero);
            PostMessage(Handle, WM_KEYUP, (IntPtr)(Keys.Enter), IntPtr.Zero);
            for (int i = 0; i < Text.Length; i++)
            {
                Keys keys1;
                switch (Text[i].ToString())
                {
                    case " ":
                        keys1 = Keys.Space;
                        break;
                    case ".":
                        keys1 = (Keys)0xBE;
                        break;
                    case "`":
                        keys1 = (Keys)0xC0;
                        break;
                    case @"":
                        keys1 = (Keys)0xDC;
                        break;
                    case "b":
                        keys1 = (Keys)0x42;
                        break;
                    case "a":
                        keys1 = (Keys)0x41;
                        break;
                    case "n":
                        keys1 = (Keys)0x4E;
                        break;
                    case "[":
                        keys1 = (Keys)0xDB;
                        break;
                    case "]":
                        keys1 = (Keys)0xDD;
                        break;
                    case "/":
                        keys1 = (Keys)0xBF;
                        break;
                    case "\t":
                    case "\n":
                        keys1 = Keys.Space;
                        break;
                    default:
                        keys1 = (Keys)converter.ConvertFromString(Text[i].ToString());
                        break;
                }
                PostMessage(Handle, WM_KEYDOWN, (IntPtr)keys1, IntPtr.Zero);
                PostMessage(Handle, WM_KEYUP, (IntPtr)keys1, IntPtr.Zero);
            }
            PostMessage(Handle, WM_KEYDOWN, (IntPtr)Keys.Enter, IntPtr.Zero);
            PostMessage(Handle, WM_KEYUP, (IntPtr)Keys.Enter, IntPtr.Zero);
        }
        
        int red()
        {
            if (b >= 250)
            {
                r -= 1;

                if (r <= 65)
                {
                    rgbState = 1;
                }
            }

            if (b <= 65)
            {
                r += 1;

                if (r >= 250)
                {
                    rgbState = 1;
                }
            }
            return r;
        }

        int green()
        {
            if (r <= 65)
            {
                g += 2;

                if (g >= 250)
                {
                    rgbState = 2;
                }
            }

            if (r >= 250)
            {
                g -= 2;

                if (g <= 65)
                {
                    rgbState = 2;
                }
            }
            return g;
        }

        int blue()
        {
            if (g <= 65)
            {
                b += 2;

                if (b >= 250)
                {
                    rgbState = 0;
                }
            }

            if (g >= 250)
            {
                b -= 2;

                if (b <= 65)
                {
                    rgbState = 0;
                }
            }
            return b;
        }

        void rgbshit()
        {
            while (true)
            {
                switch (rgbState)
                {
                    case 0:
                        niggerlabel.ForeColor = Color.FromArgb(red(), g, b);
                        break;
                    case 1:
                        niggerlabel.ForeColor = Color.FromArgb(r, green(), b);
                        break;
                    case 2:
                        niggerlabel.ForeColor = Color.FromArgb(r, g, blue());
                        break;
                }
                Thread.Sleep(30);
            }
        }

        static string GetBeta()
        {
            string e = "here goes the getbeta function";
            return e;
        }

        static string GetAdmin()
        {
            string e = "here goes the getadmin function";
            return e;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            gameTimer.Start();
            localPlayerTimer.Start();

            Task.Run(() => rgbshit());
            string username = Crypt.Decrypt(File.ReadAllText(g_secret_path), "nigger");
            metroLabel25.Text = "Username: " + username;
            metroLabel26.Text = "Beta access: " + GetBeta();
            metroLabel27.Text = "Rank: " + GetAdmin();

            m.OpenProcess("ZurgUwvJMTbtekcHkFoZvGYuQhMHSlkWJkzIvgIgrEzrOlcmuNwfJRZSUxQlimpa");
            m.WriteMemory(op_noban, "bytes", "74 08");
            m.WriteMemory(op_nosetback, "bytes", "E9 19 01 00 00 90");
            m.WriteMemory(op_nointegrity, "bytes", "90 90");
            metroLabel2.Text = "Growtopia attached";
            metroLabel2.ForeColor = Color.Green;
            metroTextBox11.Text = m.Read2Byte(pointer_hair).ToString();
            metroTextBox12.Text = m.Read2Byte(pointer_hat).ToString();
            metroTextBox13.Text = m.Read2Byte(pointer_face).ToString();
            metroTextBox14.Text = m.Read2Byte(pointer_neck).ToString();
            metroTextBox15.Text = m.Read2Byte(pointer_shirt).ToString();
            metroTextBox16.Text = m.Read2Byte(pointer_pants).ToString();
            metroTextBox17.Text = m.Read2Byte(pointer_wings).ToString();
            metroTextBox18.Text = m.Read2Byte(pointer_feet).ToString();
            metroTextBox19.Text = m.Read2Byte(pointer_hand).ToString();
            metroTextBox20.Text = m.Read2Byte(pointer_punch).ToString();
            metroTextBox21.Text = m.Read2Byte(pointer_gems).ToString();
            metroTextBox22.Text = m.Read2Byte(pointer_selected_item).ToString();
            metroTextBox23.Text = m.ReadString(pointer_name, "", 100);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("uiCPhTREesdbdLhZyfpxulKeuzhSMJSjkwplenTWVBGZClOcdlOLLpeIYWVhkysU");
            if (pname.Length == 0)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
        }

        private void metroButton28_Click(object sender, EventArgs e)
        {
        }

        #endregion

        #region Cheats
        #region Hotkeys
        private void hotkeyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (hotkeyCheckbox.Checked == true)
            {
                metroLabel30.Visible = true;
                metroLabel30.ForeColor = Color.Red;
                metroLabel32.Visible = true;
                metroLabel32.ForeColor = Color.Red;
                metroLabel33.Visible = true;
                metroLabel33.ForeColor = Color.Red;
                metroLabel34.Visible = true;
                metroLabel34.ForeColor = Color.Red;
                metroLabel35.Visible = true;
                metroLabel35.ForeColor = Color.Red;
                metroLabel36.Visible = true;
                metroLabel36.ForeColor = Color.Red;
                metroLabel37.Visible = true;
                metroLabel37.ForeColor = Color.Red;
                metroLabel38.Visible = true;
                metroLabel38.ForeColor = Color.Red;
                metroLabel39.Visible = true;
                metroLabel39.ForeColor = Color.Red;
                metroLabel40.Visible = true;
                metroLabel40.ForeColor = Color.Red;
                RegisterHotKey(this.Handle, 1, 0, (int)Keys.F1);
                RegisterHotKey(this.Handle, 2, 0, (int)Keys.F2);
                RegisterHotKey(this.Handle, 3, 0, (int)Keys.F3);
                RegisterHotKey(this.Handle, 4, 0, (int)Keys.F4);
                RegisterHotKey(this.Handle, 5, 0, (int)Keys.F5);
                RegisterHotKey(this.Handle, 6, 0, (int)Keys.F6);
                RegisterHotKey(this.Handle, 7, 0, (int)Keys.F7);
                RegisterHotKey(this.Handle, 8, 0, (int)Keys.F8);
                RegisterHotKey(this.Handle, 9, 0, (int)Keys.F9);
                RegisterHotKey(this.Handle, 10, 0, (int)Keys.F10);
            } 
            else
            {
                metroLabel30.Visible = false;
                metroLabel31.Visible = false;
                metroLabel32.Visible = false;
                metroLabel33.Visible = false;
                metroLabel34.Visible = false;
                metroLabel35.Visible = false;
                metroLabel36.Visible = false;
                metroLabel37.Visible = false;
                metroLabel38.Visible = false;
                metroLabel39.Visible = false;
                metroLabel40.Visible = false;
                UnregisterHotKey(this.Handle, 1);
                UnregisterHotKey(this.Handle, 2);
                UnregisterHotKey(this.Handle, 3);
                UnregisterHotKey(this.Handle, 4);
                UnregisterHotKey(this.Handle, 5);
                UnregisterHotKey(this.Handle, 6);
                UnregisterHotKey(this.Handle, 7);
                UnregisterHotKey(this.Handle, 8);
                UnregisterHotKey(this.Handle, 9);
                UnregisterHotKey(this.Handle, 10);
            }
        }
        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == 0x0312)
            {
                int id = msg.WParam.ToInt32();
                if (id == 1)
                {
                    if (m.ReadByte(op_antibounce) == 117)
                    {
                        metroLabel30.Text = "(F1) Antibounce - On";
                        metroLabel30.ForeColor = Color.Green;
                        m.WriteMemory(op_antibounce, "bytes", "90 90");
                    }
                    else
                    {
                        metroLabel30.Text = "(F1) Antibounce - Off";
                        metroLabel30.ForeColor = Color.Red;
                        m.WriteMemory(op_antibounce, "bytes", "75 10");
                    }
                }
                else if (id == 2)
                {
                    if (m.ReadByte(op_gravityv2) == 117)
                    {
                        metroLabel32.Text = "(F2) Gravity v2 - On";
                        metroLabel32.ForeColor = Color.Green;
                        m.WriteMemory(op_gravityv2, "bytes", "74 27");
                    }
                    else
                    {
                        metroLabel32.Text = "(F2) Gravity v2 - Off";
                        metroLabel32.ForeColor = Color.Red;
                        m.WriteMemory(op_gravityv2, "bytes", "75 27");
                    }
                }
                else if (id == 3)
                {
                    if (m.ReadByte(op_giveaway1) == 117 && m.ReadByte(op_giveaway2) == 232 && m.ReadByte(op_giveaway3) == 116 && m.ReadByte(op_giveaway4) == 116)
                    {
                        metroLabel33.Text = "(F3) Giveaway Mode - On";
                        metroLabel33.ForeColor = Color.Green;
                        m.WriteMemory(op_giveaway1, "bytes", "90 90");
                        m.WriteMemory(op_giveaway2, "bytes", "90 90 90 90 90");
                        m.WriteMemory(op_giveaway3, "bytes", "73 05");
                        m.WriteMemory(op_giveaway4, "bytes", "90 90");
                        gModeTimer.Interval = 25;
                        gModeTimer.Tick += GModeTimer_Tick;
                        gModeTimer.Start();
                    }
                    else
                    {
                        metroLabel33.Text = "(F3) Giveaway Mode - Off";
                        metroLabel33.ForeColor = Color.Red;
                        m.WriteMemory(op_giveaway1, "bytes", "75 0C");
                        m.WriteMemory(op_giveaway2, "bytes", "E8 69 0F 00 00");
                        m.WriteMemory(op_giveaway3, "bytes", "74 05");
                        m.WriteMemory(op_giveaway4, "bytes", "74 5D");
                        gModeTimer.Stop();
                    }
                }
                else if (id == 4)
                {
                    if (m.ReadByte(op_walkinair) == 116)
                    {
                        metroLabel34.Text = "(F4) Modfly - On";
                        metroLabel34.ForeColor = Color.Green;
                        m.WriteMemory(op_walkinair, "bytes", "75 5D");
                        timerModFly.Interval = 25;
                        timerModFly.Tick += TimerModFly_Tick;
                        timerModFly.Start();
                    }
                    else
                    {
                        metroLabel34.Text = "(F4) Modfly - Off";
                        metroLabel34.ForeColor = Color.Red;
                        m.WriteMemory(op_walkinair, "bytes", "74 5D");
                        timerModFly.Stop();
                    }
                }
                else if (id == 5)
                {
                    if (m.ReadByte(op_modzoom) == 128)
                    {
                        metroLabel35.Text = "(F5) Unlimited Zoom - On";
                        metroLabel35.ForeColor = Color.Green;
                        m.WriteMemory(op_modzoom, "bytes", "90 90 90 90 90 90 90");
                    }
                    else
                    {
                        metroLabel35.Text = "(F5) Unlimited Zoom - Off";
                        metroLabel35.ForeColor = Color.Red;
                        m.WriteMemory(op_modzoom, "bytes", "80 B8 79 01 00 00 00");
                    }
                }
                else if (id == 6)
                {
                    if (m.ReadByte(op_ghost) == 116)
                    {
                        metroLabel36.Text = "(F6) Ghost - On";
                        metroLabel36.ForeColor = Color.Green;
                        m.WriteMemory(op_ghost, "bytes", "73 05");
                    }
                    else
                    {
                        metroLabel36.Text = "(F6) Ghost - Off";
                        metroLabel36.ForeColor = Color.Red;
                        m.WriteMemory(op_ghost, "bytes", "74 05");
                    }
                }
                else if (id == 7)
                {
                    if (m.ReadByte(op_slime) == 117 && m.ReadByte(op_slimeloop) == 117)
                    {
                        metroLabel37.Text = "(F7) Slime Spammer - On";
                        metroLabel37.ForeColor = Color.Green;
                        m.WriteMemory(op_slime, "bytes", "90 90");
                        m.WriteMemory(op_slimeloop, "bytes", "90 90");
                    }
                    else
                    {
                        metroLabel37.Text = "(F7) Slime Spammer - Off";
                        metroLabel37.ForeColor = Color.Red;
                        m.WriteMemory(op_slime, "bytes", "75 2A");
                        m.WriteMemory(op_slimeloop, "bytes", "75 1C");
                    }
                }
                else if (id == 8)
                {
                    if (m.ReadByte(op_unlimitedjump) == 116)
                    {
                        metroLabel38.Text = "(F8) Unlimited Jump - On";
                        metroLabel38.ForeColor = Color.Green;
                        m.WriteMemory(op_unlimitedjump, "bytes", "75 09");
                    }
                    else
                    {
                        metroLabel38.Text = "(F8) Unlimited Jump - Off";
                        metroLabel38.ForeColor = Color.Red;
                        m.WriteMemory(op_unlimitedjump, "bytes", "74 09");
                    }
                }
                else if (id == 9)
                {
                    if (m.ReadByte(op_growz) == 243)
                    {
                        metroLabel39.Text = "(F9) Growz Speed - On";
                        metroLabel39.ForeColor = Color.Green;
                        m.WriteMemory(op_growz, "bytes", "90 90 90 90");
                    }
                    else
                    {
                        metroLabel39.Text = "(F9) Growz Speed - Off";
                        metroLabel39.ForeColor = Color.Red;
                        m.WriteMemory(op_growz, "bytes", "F3 0F 5C D1");
                    }
                }
                else if (id == 10)
                {
                    if (m.ReadByte(op_fast_drop_take) == 232)
                    {
                        metroLabel40.Text = "(F10) Fast Drop/Pickup - On";
                        metroLabel40.ForeColor = Color.Green;
                        m.WriteMemory(op_fast_drop_take, "bytes", "E8 EC 38 C1 FF");
                    }
                    else
                    {
                        metroLabel40.Text = "(F10) Fast Drop/Pickup - Off";
                        metroLabel40.ForeColor = Color.Red;
                        m.WriteMemory(op_fast_drop_take, "bytes", "E8 EC 38 C1 FF");
                    }
                }
            }
            base.WndProc(ref msg);
        }
        #endregion

        #region General Hacks
        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked == true)
            {
                m.WriteMemory(op_antibounce, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_antibounce, "bytes", "75 10");
            }
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox2.Checked == true)
            {
                m.WriteMemory(op_antipunch, "bytes", "0F 84 C0 00 00 00");
            }
            else
            {
                m.WriteMemory(op_antipunch, "bytes", "0F 85 C0 00 00 00");
            }
        }

        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox3.Checked == true)
            {
                m.WriteMemory(op_antirespawn, "bytes", "90 90 90");
            }
            else
            {
                m.WriteMemory(op_antirespawn, "bytes", "65 74 50");
            }
        }

        private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox4.Checked == true)
            {
                m.WriteMemory(op_antirespawnv2, "bytes", "90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_antirespawnv2, "bytes", "80 7B 24 00");
            }
        }

        private void metroCheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox5.Checked == true)
            {
                m.WriteMemory(op_autorespawn, "bytes", "90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_autorespawn, "bytes", "80 79 12 00");
            }
        }

        private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox6.Checked == true)
            {
                m.WriteMemory(op_anticactus, "bytes", "74 0A");
            }
            else
            {
                m.WriteMemory(op_anticactus, "bytes", "75 0A");
            }
        }

        private void metroCheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox7.Checked == true)
            {
                m.WriteMemory(op_antispike, "bytes", "0F 84 67 05 00 00");
            }
            else
            {
                m.WriteMemory(op_antispike, "bytes", "0F 85 67 05 00 00");
            }
        }

        private void metroCheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox8.Checked == true)
            {
                m.WriteMemory(op_antilava, "bytes", "74 07");
            }
            else
            {
                m.WriteMemory(op_antilava, "bytes", "75 07");
            }
        }

        private void metroCheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox9.Checked == true)
            {
                m.WriteMemory(op_antislide, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_antislide, "bytes", "75 03");
            }
        }

        private void metroCheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox10.Checked == true)
            {
                m.WriteMemory(op_antiportal, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_antiportal, "bytes", "75 67");
            }
        }

        private void metroCheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox11.Checked == true)
            {
                m.WriteMemory(op_anticheckpoint, "bytes", "90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_anticheckpoint, "bytes", "83 7C 02 04 1B");
            }
        }

        private void metroCheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox12.Checked == true)
            {
                m.WriteMemory(op_antigravity, "bytes", "0F 85 F2 00 00 00");
            }
            else
            {
                m.WriteMemory(op_antigravity, "bytes", "0F 84 F2 00 00 00");
            }
        }

        private void metroCheckBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox13.Checked == true)
            {
                m.WriteMemory(op_doublejump, "bytes", "75 07");
            }
            else
            {
                m.WriteMemory(op_doublejump, "bytes", "74 07");
            }
        }

        private void metroCheckBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox14.Checked == true)
            {
                m.WriteMemory(op_unlimitedjump, "bytes", "75 09");
            }
            else
            {
                m.WriteMemory(op_unlimitedjump, "bytes", "74 09");
            }
        }

        private void metroCheckBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox15.Checked == true)
            {
                m.WriteMemory(op_moonwalk, "bytes", "90 90");
                m.WriteMemory(op_moonwalk2, "bytes", "F3 0F 59 C7");
            }
            else
            {
                m.WriteMemory(op_moonwalk, "bytes", "74 0D");
                m.WriteMemory(op_moonwalk2, "bytes", "F3 0F 59 D7");
            }
        }

        private void metroCheckBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox16.Checked == true)
            {
                m.WriteMemory(op_dancemove, "bytes", "90 90 90 90");
                m.WriteMemory(op_dancemove2, "bytes", "90 90 90 90 90");
                m.WriteMemory(op_dancemove3, "bytes", "90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_dancemove, "bytes", "F3 0F 11 11");
                m.WriteMemory(op_dancemove2, "bytes", "F3 0F 11 53 20");
                m.WriteMemory(op_dancemove3, "bytes", "F3 0F 11 41 04");
            }
        }

        private void metroCheckBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox17.Checked == true)
            {
                m.WriteMemory(op_walkinair, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_walkinair, "bytes", "74 5D");
            }
        }

        private void metroCheckBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox18.Checked == true)
            {
                m.WriteMemory(op_lockeddoor, "bytes", "75 69");
            }
            else
            {
                m.WriteMemory(op_lockeddoor, "bytes", "74 69");
            }
        }

        private void metroCheckBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox19.Checked == true)
            {
                m.WriteMemory(op_lockedchest, "bytes", "90 90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_lockedchest, "bytes", "0F 82 42 19 00 00");
            }
        }

        private void metroCheckBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox20.Checked == true)
            {
                m.WriteMemory(op_growz, "bytes", "90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_growz, "bytes", "F3 0F 5C D1");
            }
        }

        private void metroCheckBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox21.Checked == true)
            {
                m.WriteMemory(op_ghost, "bytes", "73 05");
            }
            else
            {
                m.WriteMemory(op_ghost, "bytes", "74 05");
            }
        }

        private void metroCheckBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox22.Checked == true)
            {
                m.WriteMemory(op_ghostpunch, "bytes", "75 0E");
            }
            else
            {
                m.WriteMemory(op_ghostpunch, "bytes", "74 0E");
            }
        }

        private void metroCheckBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox23.Checked == true)
            {
                m.WriteMemory(op_fastpunch, "bytes", "90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_fastpunch, "bytes", "E8 A6 AA E2 FF");
            }
        }

        private void metroCheckBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox24.Checked == true)
            {
                m.WriteMemory(op_gravity, "bytes", "0F 85 16 01 00 00");
            }
            else
            {
                m.WriteMemory(op_gravity, "bytes", "0F 84 16 01 00 00");
            }
        }

        private void metroCheckBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox25.Checked == true)
            {
                m.WriteMemory(op_gravityv2, "bytes", "74 27");
            }
            else
            {
                m.WriteMemory(op_gravityv2, "bytes", "75 27");
            }
        }

        private void metroCheckBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox26.Checked == true)
            {
                m.WriteMemory(op_fly, "bytes", "0F 85 88 00 00 00");
            }
            else
            {
                m.WriteMemory(op_fly, "bytes", "0F 84 88 00 00 00");
            }
        }

        private void metroCheckBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox27.Checked == true)
            {
                m.WriteMemory(op_fastfall, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_fastfall, "bytes", "75 81");
            }
        }

        private void metroCheckBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox28.Checked == true)
            {
                m.WriteMemory(op_fastfall2, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_fastfall2, "bytes", "74 08");
            }
        }

        private void metroCheckBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox29.Checked == true)
            {
                m.WriteMemory(op_modzoom, "bytes", "90 90 90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_modzoom, "bytes", "80 B8 79 01 00 00 00");
            }
        }

        private void metroCheckBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox30.Checked == true)
            {
                m.WriteMemory(op_devmode, "bytes", "75 5F");
            }
            else
            {
                m.WriteMemory(op_devmode, "bytes", "74 5F");
            }
        }

        private void metroCheckBox31_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox31.Checked == true)
            {
                m.WriteMemory(op_modspawn, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_modspawn, "bytes", "70 6F");
            }
        }

        System.Windows.Forms.Timer timerModFly = new System.Windows.Forms.Timer();
        private void metroCheckBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox32.Checked == true)
            {
                m.WriteMemory(op_walkinair, "bytes", "75 5D");
                timerModFly.Interval = 25;
                timerModFly.Tick += TimerModFly_Tick;
                timerModFly.Start();
            }
            else
            {
                m.WriteMemory(op_walkinair, "bytes", "74 5D");
                timerModFly.Stop();
            }
        }

        private void TimerModFly_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.S))
            {
                int chatcheck = m.ReadInt(op_chatcheck);
                if (chatcheck == 0)
                {
                    m.WriteMemory(op_walkinair, "bytes", "74 5D");
                }
                else
                {
                    return;
                }
            }
            else
            {
                m.WriteMemory(op_walkinair, "bytes", "75 5D");
            }
        }

        System.Windows.Forms.Timer gModeTimer = new System.Windows.Forms.Timer();
        private void metroCheckBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox33.Checked == true)
            {
                m.WriteMemory(op_giveaway1, "bytes", "90 90");
                m.WriteMemory(op_giveaway2, "bytes", "90 90 90 90 90");
                m.WriteMemory(op_giveaway3, "bytes", "73 05");
                m.WriteMemory(op_giveaway4, "bytes", "90 90");
                gModeTimer.Interval = 25;
                gModeTimer.Tick += GModeTimer_Tick;
                gModeTimer.Start();
            }
            else
            {
                m.WriteMemory(op_giveaway1, "bytes", "75 0C");
                m.WriteMemory(op_giveaway2, "bytes", "E8 69 0F 00 00");
                m.WriteMemory(op_giveaway3, "bytes", "74 05");
                m.WriteMemory(op_giveaway4, "bytes", "74 5D");
                gModeTimer.Stop();
            }
        }

        private void GModeTimer_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.S))
            {
                int chatcheck = m.ReadInt(op_chatcheck);
                if (chatcheck == 0)
                {
                    m.WriteMemory(op_walkinair, "bytes", "74 5D");
                }
                else
                {
                    return;
                }
            }
            else
            {
                m.WriteMemory(op_walkinair, "bytes", "75 5D");
            }
        }

        private void metroCheckBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox34.Checked == true)
            {
                m.WriteMemory(op_slime, "bytes", "90 90");
                m.WriteMemory(op_slimeloop, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_slime, "bytes", "75 2A");
                m.WriteMemory(op_slimeloop, "bytes", "75 1C");
            }
        }

        private void metroCheckBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox35.Checked == true)
            {
                m.WriteMemory(op_tutbypass, "bytes", "75 41");
            }
            else
            {
                m.WriteMemory(op_tutbypass, "bytes", "74 41");
            }
        }

        private void metroCheckBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox36.Checked == true)
            {
                m.WriteMemory(op_noclip, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_noclip, "bytes", "75 0C");
            }
        }

        private void metroCheckBox37_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox37.Checked == true)
            {
                m.WriteMemory(op_frogmode, "bytes", "90 90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_frogmode, "bytes", "0F 84 EF 00 00 00");
            }
        }

        private void metroCheckBox38_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox38.Checked == true)
            {
                m.WriteMemory(op_deadmove, "bytes", "75 7D");
            }
            else
            {
                m.WriteMemory(op_deadmove, "bytes", "74 7D");
            }
        }

        private void metroCheckBox39_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox39.Checked == true)
            {
                m.WriteMemory(op_slidewalk, "bytes", "90 90 90");
            }
            else
            {
                m.WriteMemory(op_slidewalk, "bytes", "45 8B FC");
            }
        }

        private void metroCheckBox40_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox40.Checked == true)
            {
                m.WriteMemory(op_slowwalk, "bytes", "75 0D");
            }
            else
            {
                m.WriteMemory(op_slowwalk, "bytes", "74 0D");
            }
        }

        private void metroCheckBox41_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox41.Checked == true)
            {
                m.WriteMemory(op_slowwalk2, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_slowwalk2, "bytes", "74 22");
            }
        }

        private void metroCheckBox42_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox42.Checked == true)
            {
                m.WriteMemory(op_timemachine, "bytes", "75 0A");
            }
            else
            {
                m.WriteMemory(op_timemachine, "bytes", "74 0A");
            }
        }

        private void metroCheckBox43_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox43.Checked == true)
            {
                m.WriteMemory(op_pickup_up, "bytes", "90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_pickup_up, "bytes", "F3 0F 11 4A 04");
            }
        }

        private void metroCheckBox44_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox44.Checked == true)
            {
                m.WriteMemory(op_tractormode, "bytes", "0F 84 F2 00 00 00");
            }
            else
            {
                m.WriteMemory(op_tractormode, "bytes", "0F 85 F2 00 00 00");
            }
        }

        private void metroCheckBox45_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox45.Checked == true)
            {
                m.WriteMemory(op_plowmode, "bytes", "0F 84 D5 00 00 00");
            }
            else
            {
                m.WriteMemory(op_plowmode, "bytes", "0F 85 D5 00 00 00");
            }
        }

        private void metroCheckBox46_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox46.Checked == true)
            {
                m.WriteMemory(op_dicehack, "bytes", "90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_dicehack, "bytes", "0F 87 47 04");
            }
        }

        private void metroCheckBox47_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox47.Checked == true)
            {
                m.WriteMemory(op_fast_drop_take, "bytes", "90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_fast_drop_take, "bytes", "E8 5C EE C2 FF");
            }
        }

        async void doFakelag()
        {
            while (fakelag)
            {
                m.WriteMemory(op_ghost, "bytes", "73 05");
                await Task.Delay(350);
                m.WriteMemory(op_ghost, "bytes", "74 05");
                await Task.Delay(350);
            }
        }

        async void doSpinbot()
        {
            while (spinbot)
            {
                m.WriteMemory(pointer_spin, "int", "257");
                await Task.Delay(125);
                m.WriteMemory(pointer_spin, "int", "1");
                await Task.Delay(125);
            }
        }

        private void metroCheckBox48_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox48.Checked == true)
            {
                fakelag = true;
                doFakelag();
            }
            else
            {
                fakelag = false;
                m.WriteMemory(op_ghost, "bytes", "74 05");
            }
        }

        private void metroCheckBox49_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox49.Checked == true)
            {
                spinbot = true;
                doSpinbot();
            }
            else
            {
                spinbot = false;
            }
        }

        private void metroCheckBox50_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox50.Checked == true)
            {
                string username = Crypt.Decrypt(File.ReadAllText(g_secret_path), "nigger");
                string retard = "`4retardhook `w| `4user: " + username + " `w| `4fps: %d";
                m.WriteMemory(op_watermark, "string", retard);
                m.WriteMemory(op_forcefps, "bytes", "90 90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_watermark, "string", "fps: %d - M: %.2f, T: %.2f A: %.2f F: %.2f");
                m.WriteMemory(op_forcefps, "bytes", "0F 84 9E 01 00 00");
            }
        }

        private void metroCheckBox51_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox51.Checked == true)
            {
                m.WriteMemory(op_versionbypass, "float", g_spoofed_version);
            }
            else
            {
                m.WriteMemory(op_versionbypass, "float", g_current_version);
            }
        }

        private void metroCheckBox52_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox52.Checked == true)
            {
                m.WriteMemory(op_waterhack, "bytes", "90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_waterhack, "bytes", "E8 B7 66 00 00");
            }
        }

        private void metroCheckBox53_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox53.Checked == true)
            {
                m.WriteMemory(op_climbmode1, "bytes", "75 46");
                m.WriteMemory(op_climbmode2, "bytes", "75 47");
            }
            else
            {
                m.WriteMemory(op_climbmode1, "bytes", "74 46");
                m.WriteMemory(op_climbmode2, "bytes", "74 47");
            }
        }

        private void metroCheckBox54_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox54.Checked == true)
            {
                m.FreezeValue(pointer_freeze, "int", "0");
                m.WriteMemory(op_autorespawn, "bytes", "90 90 90 90");
            }
            else
            {
                m.UnfreezeValue(pointer_freeze);
                m.WriteMemory(op_autorespawn, "bytes", "80 79 12 00");
            }
        }

        private void metroCheckBox55_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox55.Checked == true)
            {
                m.WriteMemory(op_placeinblock, "bytes", "90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_placeinblock, "bytes", "E8 20 14 13 00");
            }
        }

        private void metroCheckBox56_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox56.Checked == true)
            {
                m.WriteMemory(op_nightvision, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_nightvision, "bytes", "75 06");
            }
        }

        private void metroCheckBox57_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox57.Checked == true)
            {
                m.WriteMemory(op_slowmotion, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_slowmotion, "bytes", "72 A7");
            }
        }

        private void metroCheckBox58_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox58.Checked == true)
            {
                m.WriteMemory(op_speedymode, "bytes", "75 26");
            }
            else
            {
                m.WriteMemory(op_speedymode, "bytes", "74 26");
            }
        }

        private void metroCheckBox59_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox59.Checked == true)
            {
                m.WriteMemory(op_placeinblock, "bytes", "90 90 90 90 90");
                m.WriteMemory(op_holddownseed, "bytes", "90 90");
                m.WriteMemory(op_seed_in_air, "bytes", "0F 83 3C FE FF FF");
                m.WriteMemory(pointer_devzoom, "int", "1");
            }
            else
            {
                m.WriteMemory(op_placeinblock, "bytes", "E8 10 24 13 00");
                m.WriteMemory(op_holddownseed, "bytes", "74 11");
                m.WriteMemory(op_seed_in_air, "bytes", "0F 85 3C FE FF FF");
                m.WriteMemory(pointer_devzoom, "int", "0");
            }
        }

        private void metroCheckBox60_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBox60.Checked == true)
            {
                randomCrystalTimer.Start();
            }
            else
            {
                randomCrystalTimer.Stop();
            }
        }

        private void randomCrystalTimer_Tick(object sender, EventArgs e)
        {
            int random_crystal = new Random().Next(2242, 2250);
            if(random_crystal%2 == 0)
            {
                m.WriteMemory(pointer_selected_item, "int", random_crystal.ToString());
            }
            else
            {
                m.WriteMemory(pointer_selected_item, "int", random_crystal + 1.ToString());
            }
        }

        private void metroCheckBox61_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox61.Checked == true)
            {
                randomSeedTimer.Start();
            }
            else
            {
                randomSeedTimer.Stop();
            }
        }

        private void randomSeedTimer_Tick(object sender, EventArgs e)
        {
            int random_seed = new Random().Next(0, 10000);
            if (random_seed % 2 == 0)
            {
                Console.WriteLine(random_seed + 1);
                m.WriteMemory(pointer_selected_item, "int", random_seed + 1.ToString());
            }
            else
            {
                Console.WriteLine(random_seed);
                m.WriteMemory(pointer_selected_item, "int", random_seed.ToString());
            }
        }

        private void metroCheckBox62_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox62.Checked == true)
            {
                m.WriteMemory(op_spikeantirespawn, "bytes", "90");
            }
            else
            {
                m.WriteMemory(op_spikeantirespawn, "bytes", "61");
            }
        }

        private void metroCheckBox63_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox63.Checked == true)
            {
                m.WriteMemory(op_deathplat, "bytes", "75 0D");
            }
            else
            {
                m.WriteMemory(op_deathplat, "bytes", "74 0D");
            }
        }

        private void metroCheckBox64_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox64.Checked == true)
            {
                m.WriteMemory(op_seeghost, "bytes", "75 08");
            }
            else
            {
                m.WriteMemory(op_seeghost, "bytes", "74 08");
            }
        }

        private void metroCheckBox94_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBox94.Checked == true)
            {
                float xdroppeditem = m.ReadFloat(pointer_xdroppedpos);
                float ydroppeditem = m.ReadFloat(pointer_ydroppedpos);
                bool flag = xdroppeditem == 0f;
                if (flag)
                {
                    return;
                } 
                else
                {
                    m.WriteMemory(op_fast_drop_take, "bytes", "90 90 90 90 90");
                    m.WriteMemory(pointer_xpos, "float", xdroppeditem.ToString());
                    m.WriteMemory(pointer_ypos, "float", ydroppeditem.ToString());
                }
            }
            else
            {
                m.WriteMemory(op_fast_drop_take, "bytes", "E8 EC 38 C1 FF");
            }
        }

        private void metroCheckBox65_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBox65.Checked == true)
            {
                m.WriteMemory(op_anti_oneway1, "bytes", "90 90");
                m.WriteMemory(op_anti_oneway2, "bytes", "90 90 90");
            } 
            else
            {
                m.WriteMemory(op_anti_oneway1, "bytes", "79 0F");
                m.WriteMemory(op_anti_oneway2, "bytes", "45 85 F6");
            }
        }

        private void metroCheckBox66_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox66.Checked == true)
            {
                m.WriteMemory(op_inflives_client, "bytes", "90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_inflives_client, "bytes", "E8 F6 89 01 00");
            }
        }

        private void metroCheckBox95_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox95.Checked == true)
            {
                m.WriteMemory(op_anti_everything, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_anti_everything, "bytes", "75 74");
            }
        }

        private void metroCheckBox96_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox96.Checked == true)
            {
                m.WriteMemory(op_cantmove, "bytes", "74 50");
            }
            else
            {
                m.WriteMemory(op_cantmove, "bytes", "75 50");
            }
        }

        private void metroCheckBox97_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox97.Checked == true)
            {
                m.WriteMemory(op_holddownseed, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_holddownseed, "bytes", "74 11");
            }
        }

        private void metroCheckBox98_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox98.Checked == true)
            {
                m.WriteMemory(op_airpinball, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_airpinball, "bytes", "75 18");
            }
        }
        #endregion

        #region Visuals
        private void metroCheckBox67_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox67.Checked == true)
            {
                m.WriteMemory(op_rainbowblocks, "bytes", "0F 84 83 00 00 00");
            }
            else
            {
                m.WriteMemory(op_rainbowblocks, "bytes", "0F 85 83 00 00 00");
            }
        }
        private void metroCheckBox68_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox68.Checked == true)
            {
                m.WriteMemory(op_blockfuck, "bytes", "0F 84 44 01 00 00");
            }
            else
            {
                m.WriteMemory(op_blockfuck, "bytes", "0F 85 44 01 00 00");
            }
        }

        private void metroCheckBox69_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox69.Checked == true)
            {
                m.WriteMemory(op_cummode, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_cummode, "bytes", "74 29");
            }
        }

        private void metroCheckBox70_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox70.Checked == true)
            {
                m.WriteMemory(op_autismmode, "bytes", "90 90 90");
            }
            else
            {
                m.WriteMemory(op_autismmode, "bytes", "0F 28 DF");
            }
        }

        private void metroCheckBox71_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox71.Checked == true)
            {
                m.WriteMemory(op_nochat, "bytes", "74 11");
            }
            else
            {
                m.WriteMemory(op_nochat, "bytes", "75 11");
            }
        }

        private void metroCheckBox72_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox72.Checked == true)
            {
                m.WriteMemory(op_noname, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_noname, "bytes", "76 21");
            }
        }

        private void metroCheckBox73_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox73.Checked == true)
            {
                m.WriteMemory(op_noshadow, "bytes", "90 90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_noshadow, "bytes", "0F 85 6D FE FF FF");
            }
        }

        private void metroCheckBox74_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox74.Checked == true)
            {
                m.WriteMemory(op_goblinname, "bytes", "74 16");
            }
            else
            {
                m.WriteMemory(op_goblinname, "bytes", "75 16");
            }
        }

        private void metroCheckBox75_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox75.Checked == true)
            {
                m.WriteMemory(op_virginmode, "bytes", "90 90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_virginmode, "bytes", "0F 84 CB 06 00 00");
            }
        }

        private void metroCheckBox76_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox76.Checked == true)
            {
                m.WriteMemory(op_mirroreff, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_mirroreff, "bytes", "75 27");
            }
        }

        private void metroCheckBox77_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox77.Checked == true)
            {
                m.WriteMemory(op_smallplayer, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_smallplayer, "bytes", "74 16");
            }
        }

        private void metroCheckBox78_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox78.Checked == true)
            {
                m.WriteMemory(op_bigplayer, "bytes", "75 16");
            }
            else
            {
                m.WriteMemory(op_bigplayer, "bytes", "74 16");
            }
        }

        private void metroCheckBox79_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox79.Checked == true)
            {
                m.WriteMemory(op_putinmode, "bytes", "75 16");
            }
            else
            {
                m.WriteMemory(op_putinmode, "bytes", "74 16");
            }
        }

        private void metroCheckBox80_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox80.Checked == true)
            {
                m.WriteMemory(op_nomouth, "bytes", "75 33");
            }
            else
            {
                m.WriteMemory(op_nomouth, "bytes", "74 33");
            }
        }

        private void metroCheckBox81_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox81.Checked == true)
            {
                m.WriteMemory(op_darkmode, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_darkmode, "bytes", "75 2B");
            }
        }

        private void metroCheckBox82_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox82.Checked == true)
            {
                m.WriteMemory(op_snowman, "bytes", "74 09");
            }
            else
            {
                m.WriteMemory(op_snowman, "bytes", "75 09");
            }
        }

        private void metroCheckBox83_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox83.Checked == true)
            {
                m.WriteMemory(op_cancermode, "bytes", "74 11");
            }
            else
            {
                m.WriteMemory(op_cancermode, "bytes", "75 11");
            }
        }

        private void metroCheckBox84_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox84.Checked == true)
            {
                m.WriteMemory(op_invischars, "bytes", "0F 84 1D 01 00 00");
            }
            else
            {
                m.WriteMemory(op_invischars, "bytes", "0F 85 1D 01 00 00");
            }
        }

        private void metroCheckBox85_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox85.Checked == true)
            {
                m.WriteMemory(op_explodingblocks, "bytes", "0F 84 95 00 00 00");
            }
            else
            {
                m.WriteMemory(op_explodingblocks, "bytes", "0F 85 95 00 00 00");
            }
        }

        private void metroCheckBox86_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox86.Checked == true)
            {
                m.WriteMemory(op_rainbowinventory, "bytes", "90 90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_rainbowinventory, "bytes", "0F 85 B7 00 00 00");
            }
        }

        private void metroCheckBox87_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox87.Checked == true)
            {
                m.WriteMemory(op_seefruits, "bytes", "90 90");
            }
            else
            {
                m.WriteMemory(op_seefruits, "bytes", "75 08");
            }
        }

        private void metroCheckBox88_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox88.Checked == true)
            {
                m.WriteMemory(op_freezeitems, "bytes", "90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_freezeitems, "bytes", "E8 D6 F6 BF FF");
            }
        }

        private void metroCheckBox92_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox92.Checked == true)
            {
                m.WriteMemory(op_noborder, "bytes", "90 90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_noborder, "bytes", "F3 41 0F 58 45 00");
            }
        }

        private void metroCheckBox93_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox93.Checked == true)
            {
                m.WriteMemory(op_burningheads, "bytes", "90 90 90 90 90 90");
            }
            else
            {
                m.WriteMemory(op_burningheads, "bytes", "0F 85 AF 00 00 00");
            }
        }
        #endregion

        #region Changers
        /*
         * m.WriteMemory(pointer_hair, "int", metroTextBox11.Text);
         * m.WriteMemory(pointer_hat, "int", metroTextBox12.Text);
         * m.WriteMemory(pointer_face, "int", metroTextBox13.Text);
         * m.WriteMemory(pointer_neck, "int", metroTextBox14.Text);
         * m.WriteMemory(pointer_shirt, "int", metroTextBox15.Text);
         * m.WriteMemory(pointer_pants, "int", metroTextBox16.Text);
         * m.WriteMemory(pointer_wings, "int", metroTextBox17.Text);
         * m.WriteMemory(pointer_feet, "int", metroTextBox18.Text);
         * m.WriteMemory(pointer_hand, "int", metroTextBox19.Text);
         * m.WriteMemory(pointer_punch, "int", metroTextBox20.Text);
         * m.WriteMemory(pointer_selected_item, "int", metroTextBox22.Text);
         * m.WriteMemory(pointer_gems, "int", metroTextBox21.Text);
         * 
         */

        private void metroButton2_Click(object sender, EventArgs e)
        {
            m.WriteMemory(pointer_hair, "int", metroTextBox11.Text);
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            m.WriteMemory(pointer_hat, "int", metroTextBox12.Text);
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            m.WriteMemory(pointer_face, "int", metroTextBox13.Text);
        }

        private void metroButton19_Click(object sender, EventArgs e)
        {
            m.WriteMemory(pointer_neck, "int", metroTextBox14.Text);
        }

        private void metroButton20_Click(object sender, EventArgs e)
        {
            m.WriteMemory(pointer_shirt, "int", metroTextBox15.Text);
        }

        private void metroButton21_Click(object sender, EventArgs e)
        {
            m.WriteMemory(pointer_pants, "int", metroTextBox16.Text);
        }

        private void metroButton22_Click(object sender, EventArgs e)
        {
            m.WriteMemory(pointer_wings, "int", metroTextBox17.Text);
        }

        private void metroButton23_Click(object sender, EventArgs e)
        {
            m.WriteMemory(pointer_feet, "int", metroTextBox18.Text);
        }

        private void metroButton24_Click(object sender, EventArgs e)
        {
            m.WriteMemory(pointer_hand, "int", metroTextBox19.Text);
        }

        private void metroButton25_Click(object sender, EventArgs e)
        {
            m.WriteMemory(pointer_punch, "int", metroTextBox20.Text);
        }

        private void metroButton26_Click(object sender, EventArgs e)
        {
            m.WriteMemory(pointer_selected_item, "int", metroTextBox22.Text);
        }

        private void metroButton27_Click(object sender, EventArgs e)
        {
            m.WriteMemory(pointer_gems, "int", metroTextBox21.Text);
        }
        #endregion

        #region Misc
        private void localPlayerTimer_Tick(object sender, EventArgs e)
        {
            float xpos = m.ReadFloat(pointer_xpos, "", true);
            float ypos = m.ReadFloat(pointer_ypos, "", true);
            metroLabel17.Text = xpos.ToString();
            metroLabel18.Text = ypos.ToString();

            float xpunchpos = m.ReadFloat(pointer_xpunchpos, "", true);
            float ypunchpos = m.ReadFloat(pointer_ypunchpos, "", true);
            metroLabel21.Text = xpunchpos.ToString();
            metroLabel22.Text = ypunchpos.ToString();
        }

        bool spammerenabled = false;

        private void spammer_Tick(object sender, EventArgs e)
        {
            IntPtr winTitle = Process.GetProcessesByName("FJuDHcQvIImmfpGi")[0].MainWindowHandle;
            string spamText = metroTextBox3.Text.ToString();
            Spam(winTitle, spamText.ToUpper());
        }

        private void metroCheckBox89_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBox89.Checked == true)
            {
                punchPosTimer.Start();
            }
            else
            {
                punchPosTimer.Stop();
            }
        }

        private void punchPosTimer_Tick(object sender, EventArgs e)
        {
            float xpunchpos = m.ReadFloat(pointer_xpunchpos, "", true);
            float ypunchpos = m.ReadFloat(pointer_ypunchpos, "", true);
            bool flag = xpunchpos == 0f;
            if (flag)
            {
                return;
            }
            else
            {
                m.WriteMemory(pointer_xpos, "float", xpunchpos.ToString() ?? "", "", null);
                m.WriteMemory(pointer_ypos, "float", ypunchpos.ToString() ?? "", "", null);
            }
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            m.WriteMemory(pointer_xpos, "float", metroTextBox6.Text ?? "", "", null);
            m.WriteMemory(pointer_ypos, "float", metroTextBox7.Text ?? "", "", null);
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            m.WriteMemory(pointer_name, "string", metroTextBox23.Text);
        }

        private void metroTextBox4_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(metroTextBox4.Text, out value))
            {
                if (value > 0)
                {
                    spammer.Interval = value;
                }
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            if (spammerenabled == false)
            {
                spammer.Enabled = true;
                spammerenabled = true;
                metroButton5.Text = "Toggle Off";
            }
            else if (spammerenabled == true)
            {
                spammer.Enabled = false;
                spammerenabled = false;
                metroButton5.Text = "Toggle On";
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            float posx = m.ReadFloat(pointer_xpos);
            float posy = m.ReadFloat(pointer_ypos);
            metroTextBox1.Text = posx.ToString();
            metroTextBox2.Text = posy.ToString();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (metroRadioButton1.Checked)
            {
                int wantedvalue = Int32.Parse(metroTextBox1.Text);
                int wantedy = Int32.Parse(metroTextBox2.Text);
                float posxvalue = m.ReadFloat(pointer_xpos);
                float posyvalue = m.ReadFloat(pointer_ypos);

                if (wantedvalue < posxvalue)
                {
                    while (posxvalue > wantedvalue)
                    {
                        posxvalue -= 9;
                        m.WriteMemory(pointer_xpos, "float", posxvalue.ToString());
                        Thread.Sleep(15);
                    }
                }
                else if (wantedvalue > posxvalue)
                {
                    while (posxvalue < wantedvalue)
                    {
                        posxvalue += 9;
                        m.WriteMemory(pointer_xpos, "float", posxvalue.ToString());
                        Thread.Sleep(15);
                    }
                }

                if (wantedy < posyvalue)
                {
                    while (posyvalue > wantedy)
                    {
                        posyvalue -= 9;
                        m.WriteMemory(pointer_ypos, "float", posyvalue.ToString());
                        Thread.Sleep(5);
                    }
                }
            }
            else if (metroRadioButton2.Checked)
            {
                int wantedvalue = Int32.Parse(metroTextBox1.Text);
                int wantedy = Int32.Parse(metroTextBox2.Text);
                float posxvalue = m.ReadFloat(pointer_xpos);
                float posyvalue = m.ReadFloat(pointer_ypos);

                if (wantedy < posyvalue)
                {
                    while (posyvalue > wantedy)
                    {
                        posyvalue -= 9;
                        m.WriteMemory(pointer_ypos, "float", posyvalue.ToString());
                        Thread.Sleep(15);
                    }
                }

                if (wantedvalue < posxvalue)
                {
                    while (posxvalue > wantedvalue)
                    {
                        posxvalue -= 9;
                        m.WriteMemory(pointer_xpos, "float", posxvalue.ToString());
                        Thread.Sleep(15);
                    }
                }
                else if (wantedvalue > posxvalue)
                {
                    while (posxvalue < wantedvalue)
                    {
                        posxvalue += 9;
                        m.WriteMemory(pointer_xpos, "float", posxvalue.ToString());
                        Thread.Sleep(15);
                    }
                }
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if(metroComboBox1.Text == "Kick")
            {
                IntPtr winTitle = Process.GetProcessesByName("iGjhgIjTBywrGTWY")[0].MainWindowHandle;
                Spam(winTitle, "/kick ".ToUpper() + metroTextBox5.Text.ToUpper());
            }
            if(metroComboBox1.Text == "Ban")
            {
                IntPtr winTitle = Process.GetProcessesByName("whvnyhveNvHUKJLV")[0].MainWindowHandle;
                Spam(winTitle, "/ban ".ToUpper() + metroTextBox5.Text.ToUpper());
            }
            if (metroComboBox1.Text == "Pull")
            {
                IntPtr winTitle = Process.GetProcessesByName("uQpMPFUrhkWgBpxw")[0].MainWindowHandle;
                Spam(winTitle, "/pull ".ToUpper() + metroTextBox5.Text.ToUpper());
            }
            if (metroComboBox1.Text == "Trade")
            {
                IntPtr winTitle = Process.GetProcessesByName("ZgZtNKFxYZBIfZon")[0].MainWindowHandle;
                Spam(winTitle, "/trade ".ToUpper() + metroTextBox5.Text.ToUpper());
            }
            if (metroComboBox1.Text == "Ignore")
            {
                IntPtr winTitle = Process.GetProcessesByName("akNsOAuSdksAwlDSK")[0].MainWindowHandle;
                Spam(winTitle, "/ignore ".ToUpper() + metroTextBox5.Text.ToUpper());
            }
            if (metroComboBox1.Text == "MSG \"Nigger\"")
            {
                IntPtr winTitle = Process.GetProcessesByName("AAQYudLjLsmpDLLI")[0].MainWindowHandle;
                Spam(winTitle, "/msg ".ToUpper() + metroTextBox5.Text.ToUpper() + " Nigger".ToUpper());
            }
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ActiveForm.Opacity = metroTrackBar1.Value / 100.0;
        }

        private void metroCheckBox90_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox90.Checked == true)
            {
                ActiveForm.TopMost = true;
            }
            else
            {
                ActiveForm.TopMost = false;
            }
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            foreach (string shortnum in Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\").GetSubKeyNames())
            {
                if (shortnum.StartsWith("1") || shortnum.StartsWith("2") || shortnum.StartsWith("3") || shortnum.StartsWith("4") || shortnum.StartsWith("5") || shortnum.StartsWith("6") || shortnum.StartsWith("7") || shortnum.StartsWith("8") || shortnum.StartsWith("9"))
                {
                    metroTextBox9.Text = shortnum;
                    break;
                }
            }
            foreach (string longnum in Registry.CurrentUser.GetSubKeyNames())
            {
                if (longnum.StartsWith("1") || longnum.StartsWith("2") || longnum.StartsWith("3") || longnum.StartsWith("4") || longnum.StartsWith("5") || longnum.StartsWith("6") || longnum.StartsWith("7") || longnum.StartsWith("8") || longnum.StartsWith("9"))
                {
                    metroTextBox10.Text = longnum;
                    break;
                }
            }
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            Registry.CurrentUser.DeleteSubKey(metroTextBox10.Text);
            Registry.CurrentUser.DeleteSubKey(@"SOFTWARE\Microsoft\" + metroTextBox9.Text);
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            RegistryKey mach = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Cryptography", true);
            mach.DeleteValue("MachineGuid");
        }

        private void metroButton12_Click(object sender, EventArgs e)
        {
            //GHETTO SHIT
            string tmac_path = "C:\\Program Files (x86)\\Technitium\\TMACv6.0\\TMAC.exe";
            Process.Start(tmac_path);
        }

        DiscordRpcClient clientz;

        private void metroCheckBox91_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox91.Checked == true)
            {
                string retard = "hi";
                string username = Crypt.Decrypt(File.ReadAllText(g_secret_path), "IebiXVcWWmEvVJIb");
                clientz = new DiscordRpcClient("");
                clientz.Initialize();
                clientz.SetPresence(new RichPresence()
                {
                    Details = retard,
                    Timestamps = new Timestamps
                    {
                        Start = DateTime.UtcNow,
                    },
                    Assets = new Assets()
                    {
                        LargeImageKey = "",
                        LargeImageText = "Logged in as " + username
                    }
                });
            }
            else
            {
                clientz.Dispose();
            }
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon", "Ban Times", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroButton16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon", "Hack Combinations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroButton17_Click(object sender, EventArgs e)
        {
        }

        private void metroButton29_Click(object sender, EventArgs e)
        {
            MessageBox.Show("[2020-11-19 -> 2020-12-01]\n- A ton of updates that weren't listed/noted anywhere\n[2020-11-13]\n- Initial Release", "Changelog", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #endregion
        #endregion
    }
}