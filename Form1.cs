using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibertyX
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormMoveable_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SelectApi_Click(object sender, EventArgs e)
        {
            if (panel.Size == panel.MaximumSize)
            {
                panel.Size = panel.MinimumSize;
            }
            else
            {
                panel.Size = panel.MaximumSize;
            }
        }

        private void b13_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet('https://pastebin.com/raw/GtudyLtE'))();";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet('https://raw.githubusercontent.com/opBandwidth/_Paragon_/main/main.lua%27))()";
        }

        private void b_Click(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox_Load(object sender, EventArgs e)
        {

        }

        private void b3_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:GetObjects('rbxassetid://1461971147')[1].Source)()";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet('https://raw.githubusercontent.com/1201for/V.G-Hub/main/V.Ghub'))()";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet('http://void-scripts.com/Scripts/islands_new.lua'))()";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet(('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source%27),true))()";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet('https://raw.githubusercontent.com/TwomadJR/hub/main/Nto%20(2).Lua'))()";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //wassup
            OpenFileDialog opendialogfile = new OpenFileDialog();
            opendialogfile.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
            opendialogfile.FilterIndex = 2;
            opendialogfile.RestoreDirectory = true;
            if (opendialogfile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                fastColoredTextBox1.Text = "";
                System.IO.Stream stream;
                if ((stream = opendialogfile.OpenFile()) == null)
                    return;
                using (stream)
                    this.fastColoredTextBox1.Text = System.IO.File.ReadAllText(opendialogfile.FileName);
            }
            catch (Exception)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured", "OOF!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream s = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(s);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void b8_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet(('https://raw.githubusercontent.com/RandomAdamYT/DarkHub/master/Init'), true))()";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet('https://raw.githubusercontent.com/iiProductionz/Floater-Scripts/main/WaifuEdition/Tower%20Of%20Hell'))()";
        }

        private void b10_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet('https://thisstuff.xyz/Api/WOAHSCRIPTS/1257821635-9356095531/oOAfkpCWzDWsn4CjuLZLZOs3vCf4rgUMhXaJd32VyHSs2tojOCTUKINNTbAuTTCGFrYTyMeBDEIfdo7C0Sp5EnCyxN80pHf5jpqk2xU7f1LAcx2Nt1cZe', true))()";
        }

        private void b11_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game: GetObjects('rbxassetid://4001118261')[1].Source)()";
        }

        private void b12_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "loadstring(game:HttpGet('https://pastebin.com/raw/5NzJb65w%27))()";
        }
    }
}
