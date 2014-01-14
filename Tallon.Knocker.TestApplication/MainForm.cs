using System;
using System.Windows.Forms;
using Tallon.Knocker.Core;

namespace Tallon.Knocker.TestApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Action<string> resultAction = s => MessageBox.Show(s);
            ComReader.Register(resultAction);
        }
    }
}
