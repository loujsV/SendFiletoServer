using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace SendFiletoServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //string sourceDir = @"C:\AutoMail\AutoMail.xls";
            //string desDir = @"\\scpfs01\Shared\AutoMail\AutoMail.xls";
            //string desDir = @"C:\Test_Folder\AutoMail.xls";
            //string sourceDir = @"\\scpfs01\Shared\AutoMail\AutoMail.xls";
            //File.Copy(sourceDir, desDir, true);

            //string desDir_gage = @"C:\Test_Folder\AutoGage.xls";
            //string sourceDir_gage = @"\\scpfs01\Shared\AutoMail\AutoGage.xls";
            //File.Copy(sourceDir_gage, desDir_gage, true);

            //string sourceDir = @"C:\AutoMail\AutoMail.xls";
            //string desDir = @"\\scpfs01\Shared\AutoMail\AutoMail.xls";
            string desDir = @"E:\AutoMail\AutoMail.xls";
            string sourceDir = @"\\scpfs01\Shared\AutoMail\AutoMail.xls";
            File.Copy(sourceDir, desDir, true);

            string desDir_gage = @"E:\AutoMail\AutoGage.xls";
            string sourceDir_gage = @"\\scpfs01\Shared\AutoMail\AutoGage.xls";
            File.Copy(sourceDir_gage, desDir_gage, true);

            Application.Exit();
        }

    }
}
