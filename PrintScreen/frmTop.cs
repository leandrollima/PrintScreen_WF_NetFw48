﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PrintScreen
{
    public partial class frmTop : Form  //these form are used for selected screen grabing
    {
        frmMain parentFrm;
        int xMouse = 0, yMouse = 0, newX = 0, newY = 0, mouseDown = 0, penWidth = 3;
        int screenNumber = 0; // parameter to save its screen number for easy reference later
        int grabMode = 0;

        public struct IconInfo
        {
            public bool fIcon;
            public int xHotspot;
            public int yHotspot;
            public IntPtr hbmMask;
            public IntPtr hbmColor;
        }

        public frmTop(frmMain parentForm, string cursorText, int xStart, int yStart, int xWidth, int yWidth, int screen)
        {  //(Parent Form2, string for cursor , X bound, Y bound, Width, Height, Screen number)
            InitializeComponent(parentForm, cursorText, xStart, yStart, xWidth, yWidth, screen);
        }

        private void InitializeComponent(frmMain parentForm, string cursorText, int xStart, int yStart, int xWidth, int yWidth, int screen)
        {
            screenNumber = screen;
            parentFrm = parentForm;

            // Set Mouse cursor based on screen grab or Area Grab
            if (cursorText.Length != 0)  //text string cursor for area select forms
            {
                Bitmap bitmap = new Bitmap(230, 25);
                Graphics g = Graphics.FromImage(bitmap);
                using (Font f = new Font("Arial", 15))
                    g.DrawString(cursorText, f, Brushes.Red, 0, 0);
                Pen pen = new Pen(Color.Red);
                g.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
                pen.Dispose();
                this.Cursor = CreateCursor(bitmap, 0, 0);
                bitmap.Dispose();
                grabMode = 0;  //parameter to show if area grab mode or not; 0 is full screen grab
            }
            else
            {
                this.Cursor = Cursors.Cross;
                grabMode = 1;
            }
            this.SuspendLayout();
            this.WindowState = FormWindowState.Maximized;
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ShowInTaskbar = false;
            this.ClientSize = new Size(xWidth, yWidth);

            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "Child Form";
            this.Opacity = 0.3;
            this.StartPosition = FormStartPosition.Manual; //important in mutiple monitor environment
            this.Location = new Point(xStart, yStart);
            this.Text = "ChildForm";
            this.TopMost = true;

            this.MouseUp += new MouseEventHandler(this.OnMouseUp);
            this.MouseDown += new MouseEventHandler(this.OnMouseDown);
            this.MouseMove += new MouseEventHandler(this.OnMouseMove);
            this.ResumeLayout(false);
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            //if full screen capture is ON, just detect any click and return
            if (grabMode == 0)
            { //Call parent funstion to close child window and grab screen
                parentFrm.GrabWholeScreen(screenNumber);
                parentFrm.SaveImageFromClipboard();
                return;
            }

            switch (e.Button)
            {
                case MouseButtons.Left:
                    mouseDown = 1;
                    xMouse = e.X; // first click position stored in xMouse,yMouse
                    yMouse = e.Y;
                    newX = xMouse;
                    newY = yMouse;

                    Graphics gfx = CreateGraphics();
                    Pen linePen = new Pen(Color.Black);
                    linePen.Width = penWidth;

                    gfx.DrawLine(linePen, xMouse, yMouse, xMouse, newY); // Draw rectangle, used rectangle function also but was giving errors
                    gfx.DrawLine(linePen, xMouse, yMouse, newX, yMouse);
                    gfx.DrawLine(linePen, newX, newY, newX, yMouse);
                    gfx.DrawLine(linePen, newX, newY, xMouse, newY);

                    linePen.Dispose();
                    gfx.Dispose();

                    break;

                case MouseButtons.None:
                default:
                    break;
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown != 1) return; //check if the left button is pressed, if not return

            //  this.Cursor = new Cursor(Cursor.Current.Handle);
            //     Cursor.Clip = new Rectangle(this.Location, this.ClientSize);  //limit cursor to this screen

            Graphics gfx = CreateGraphics();

            Pen erasePen = new Pen(Color.White);
            erasePen.Width = penWidth;

            gfx.DrawLine(erasePen, xMouse, yMouse, xMouse, newY); //remove the old rectangle
            gfx.DrawLine(erasePen, xMouse, yMouse, newX, yMouse);
            gfx.DrawLine(erasePen, newX, newY, newX, yMouse);
            gfx.DrawLine(erasePen, newX, newY, xMouse, newY);

            Pen linePen = new Pen(Color.Black);
            linePen.Width = penWidth;
            newX = e.X;
            newY = e.Y;

            gfx.DrawLine(linePen, xMouse, yMouse, xMouse, newY); //draw new rectangle on the Form
            gfx.DrawLine(linePen, xMouse, yMouse, newX, yMouse);
            gfx.DrawLine(linePen, newX, newY, newX, yMouse);
            gfx.DrawLine(linePen, newX, newY, xMouse, newY);

            erasePen.Dispose();
            linePen.Dispose();
            gfx.Dispose();
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    mouseDown = 0;
                    //call the parent function to close child windows and grab screen
                    parentFrm.GrabPartOfScreen(screenNumber, xMouse, yMouse, newX, newY);
                    parentFrm.SaveImageFromClipboard();
                    break;

                case MouseButtons.None:
                default:
                    break;
            }
        }

        #region Make cursor from bitmap: Use CreateCursor
        [DllImport("user32.dll")]
        public static extern IntPtr CreateIconIndirect(ref IconInfo icon);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo(IntPtr hIcon, ref IconInfo pIconInfo);

        public static Cursor CreateCursor(Bitmap bmp, int xHotSpot, int yHotSpot)
        {
            IconInfo tmp = new IconInfo();
            GetIconInfo(bmp.GetHicon(), ref tmp);
            tmp.xHotspot = xHotSpot;
            tmp.yHotspot = yHotSpot;
            tmp.fIcon = false;
            return new Cursor(CreateIconIndirect(ref tmp));
        }

        #endregion

    }
}
