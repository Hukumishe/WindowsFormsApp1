using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void func()
        {
            var drivelist = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drivelist)
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    string path = drive.ToString();
                    System.Diagnostics.Process.Start("explorer", path);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (Directory.Exists("c:\\NewFiles"))
            {
                func();
            }
            else
            {
                try
                {
                    Directory.CreateDirectory("c:\\NewFiles");
                    func();
                }
                catch
                {
                    MessageBox.Show("error");
                }
            }

        }
    }
}
