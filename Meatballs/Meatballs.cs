using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Meatballs
{
    public partial class Meatballs : Form
    {
        public Meatballs()
        {
            InitializeComponent();
            InitTimer();
        }

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 60000; //Milliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MeatballsIsReady();
        }

        public void MeatballsIsReady()
        {
            //    PopupNotifier popup = new PopupNotifier();
            //    popup.TitleText = "Meatballs";
            //    popup.ContentText = "Your Meatballs is ready";
            //    popup.Popup(); //shows the notifaction

            notifyIcon1.ShowBalloonTip(1000, "Meatballs", "Your Meatballs is ready", ToolTipIcon.None);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Meatballs_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
