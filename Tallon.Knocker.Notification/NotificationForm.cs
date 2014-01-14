using System;
using System.Windows.Forms;

namespace Tallon.Knocker.Notification
{
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();
        }

        private void cmdDismiss_Click(object sender, EventArgs e)
        {
            FinishUp();
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            FinishUp();
        }

        private void FinishUp()
        {
            tmrMain.Stop();
            Close();
        }
    }
}
