using Microsoft.Win32;
using PrintScreen;
using PrintScreen.Properties;
using System;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Screen_Grab
{
    public partial class frmMain : Form
    {
        int numberOfScreens = 0;
        frmTop[] grabWindow;
        Screen[] screens;

        int index = 0;

        public frmMain()
        {
            screens = Screen.AllScreens;
            numberOfScreens = screens.Length;
            InitializeComponent();
            setStart();

            getSettings();
        }

        private void setStart()
        {
            //determine start location
            int tx, ty;

            try
            {
                tx = 0;
                ty = 0;
                //check if last close position is within first screen
                if (tx < screens[0].Bounds.X || tx > (screens[0].Bounds.X + screens[0].Bounds.Width) || ty < screens[0].Bounds.Y || ty > (screens[0].Bounds.Y + screens[0].Bounds.Height))
                { this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; }
                else
                {
                    this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                    this.Location = new System.Drawing.Point(tx, ty);
                }
            }
            catch { this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; }
        }

        private void getSettings()
        {
            txtFolder.Text = Settings.Default.Path;

            txtPrefix.Text = Settings.Default.Prefix;

            SuffixOptions suffixType = (SuffixOptions)Settings.Default.Suffix;
            switch (suffixType)
            {
                case SuffixOptions.IncrementalNumber:
                    rdbtnNumericalIncremental.Checked = true;
                    break;
                case SuffixOptions.DateTime:
                    rdbtnDateTime.Checked = true;
                    break;
                case SuffixOptions.Guid:
                    rdbtnGuid.Checked = true;
                    break;
                default:
                    break;
            }

            nupIncrementalNumber.Value = Settings.Default.IncrementalNumber;
        }

        private void setSettings()
        {
            Settings.Default.Path = txtFolder.Text;
            Settings.Default.Prefix = txtPrefix.Text;

            if (rdbtnNumericalIncremental.Checked)
                Settings.Default.Suffix = (int)SuffixOptions.IncrementalNumber;
            else if (rdbtnDateTime.Checked)
                Settings.Default.Suffix = (int)SuffixOptions.DateTime;
            else if (rdbtnGuid.Checked)
                Settings.Default.Suffix = (int)SuffixOptions.Guid;

            Settings.Default.IncrementalNumber = (int)nupIncrementalNumber.Value;
            Settings.Default.Save();
        }

        private string FileName()
        {
            string fileName = $"{txtPrefix.Text}";
            if (rdbtnNumericalIncremental.Checked)
            {
                fileName = $"{txtPrefix.Text}{nupIncrementalNumber.Value}.png";
                nupIncrementalNumber.Value++;  
            }
            else if (rdbtnDateTime.Checked)
                fileName = $"{txtPrefix.Text}{DateTime.Now.ToString("yyyyMMddHHmmss")}.png";
            else if (rdbtnGuid.Checked)
                fileName = $"{txtPrefix.Text}{Guid.NewGuid()}.png";

            return fileName;
        }

        public void SaveImageFromClipboard()
        {
            if (Clipboard.ContainsImage())
            {
                if (!Directory.Exists(txtFolder.Text))
                    Directory.CreateDirectory(txtFolder.Text);

                string fullPath = Path.Combine(txtFolder.Text, FileName());
                lblFileName.Text = $"File name: {fullPath}";

                Clipboard.GetImage().Save(fullPath, ImageFormat.Png);
                index++;
            }
        }

        public void GrabWholeScreen(int numberOfScreen)  // called when ALL screen capture; sc is screen number
        {
            for (int j = 0; j < numberOfScreens; j++) { grabWindow[j].Close(); grabWindow[j].Dispose(); }
            Screen_Grab.Capture.CaptureScreentoClipboard(screens[numberOfScreen].Bounds.X, screens[numberOfScreen].Bounds.Y, screens[numberOfScreen].Bounds.Width, screens[numberOfScreen].Bounds.Height);
            this.Visible = true;  //make your original window visible
            
        }
        public void GrabPartOfScreen(int sc, int x, int y, int x1, int y1) // grab part of screen
        {
            for (int j = 0; j < numberOfScreens; j++) { grabWindow[j].Close(); grabWindow[j].Dispose(); }
            int finalx, finaly, finalwidth, finalheight;
            int X1 = Math.Min(x, x1), X2 = Math.Max(x, x1), Y1 = Math.Min(y, y1), Y2 = Math.Max(y, y1);
            finalx = X1 + screens[sc].Bounds.X;
            finaly = Y1 + screens[sc].Bounds.Y;
            finalwidth = X2 - X1 + 1;
            finalheight = Y2 - Y1 + 1;
            Screen_Grab.Capture.CaptureScreentoClipboard(finalx, finaly, finalwidth, finalheight);
            this.Visible = true;
            
        }

        #region Events
        private void btnGrabArea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolder.Text))
            {
                MessageBox.Show("Select a folder to save images");
                return;
            }

            this.Visible = false;
            this.Refresh();
            System.Threading.Thread.Sleep(100);
            numberOfScreens = screens.Length;
            grabWindow = new frmTop[numberOfScreens];
            int i = 0;
            foreach (var screen in Screen.AllScreens)
            {
                grabWindow[i] = new frmTop(this, "", screen.Bounds.X, screen.Bounds.Y, screen.Bounds.Width, screen.Bounds.Height, i);
                grabWindow[i].Show();
                i++;
            }
        }

        private void btnGrabScreen_Click(object sender, EventArgs e) // grab all screen
        {
            if (string.IsNullOrEmpty(txtFolder.Text))
            {
                MessageBox.Show("Select a folder to save images");
                return;
            }

            this.Visible = false;
            this.Refresh();
            System.Threading.Thread.Sleep(100);

            numberOfScreens = screens.Length;
            grabWindow = new frmTop[numberOfScreens];
            int i = 0;

            foreach (var screen in System.Windows.Forms.Screen.AllScreens)
            {
                grabWindow[i] = new frmTop(this, "Click to capture screen " + (i + 1).ToString(), screen.Bounds.X, screen.Bounds.Y, screen.Bounds.Width, screen.Bounds.Height, i);
                grabWindow[i].Show();
                i++;
            }
        }
        private void btnHelp_Click(object sender, EventArgs e)  //help button pressed
        {
            MessageBox.Show("This program is used to capture either the entire screen or part of it and save it into Clipboard. It supports multiple screens. \n\nUSAGE:\n\n FOR CAPTURING ENTIRE SCREEN:\n\n 1. Select second button and then you shall see mouse cursor suggesting to click to capture that screen.\n\n2. Paste the image into any program for usage." +
            "\n\nFOR CAPTURING A SECTION OF THE SCREEN:\n\n1. Select button one and you shall see mouse cursor changing to tilted arrows.\n\n2. Click mouse left key and keeping it pressed, select the area of interest.\n\n3. Leave the left button and the image is saved to clipboard.\n\n FOR CAPTURING ALL SCREENS:\n\n1. Press the 3rd button and All the screens are captured into one image.\n\n\nThanks for using the utility. Send in your feedback or bugs to mittaltarsem@gmail.com"
            , "SCREEN CAPTURE HELP !!");
        }

        private void btnGrabAllWindows_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFolder.Text))
            {
                MessageBox.Show("Select a folder to save images");
                return;
            }

            this.Visible = false;
            System.Threading.Thread.Sleep(100);

            int maxwidth = 0, maxheight = 0;
            for (int i = 0; i < numberOfScreens; i++)
            {
                if (maxwidth < (screens[i].Bounds.X + screens[i].Bounds.Width)) maxwidth = screens[i].Bounds.X + screens[i].Bounds.Width;
                if (maxheight < (screens[i].Bounds.Y + screens[i].Bounds.Height)) maxheight = screens[i].Bounds.Y + screens[i].Bounds.Height;
            }
            Screen_Grab.Capture.CaptureScreentoClipboard(0, 0, maxwidth, maxheight);
            this.Visible = true;
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            var d = folderBrowserDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                txtFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            setSettings();
        }

        #endregion Events
    }
}
