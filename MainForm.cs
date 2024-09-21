using Avalonia.Controls;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private Window avaloniaWindow;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonGoClick(object sender, EventArgs e)
        {
            avaloniaWindow = new AvaloniaWindow();
        }
    }
}
