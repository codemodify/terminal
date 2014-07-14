using Fourty6et2.KeyboardHooks;
using Fourty6et2.ThirdParty.CmdExe.ConsoleControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fourty6et2.Terminal.Ui
{
    public partial class Main : Form
    {
        private int _tabCount;

        public Main()
        {
            InitializeComponent();

            _tabCount = 0;
        }

        private void ShortCutDelegate()
        {
            this.Visible = !this.Visible;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height/2;

            TheCustomTabControl.ContextMenuStrip = new ContextMenuStrip();
            TheCustomTabControl.ContextMenuStrip.Items.Add("+ Tab", null, NewTabEventHandler);
            TheCustomTabControl.ContextMenuStrip.Items.Add("Quit", null, delegate { Close(); });
            TheCustomTabControl.TabClosing += TheCustomTabControl_TabClosing;

            this.ContextMenuStrip = ContextMenuStrip;

            while (TheCustomTabControl.TabPages.Count != 0)
                TheCustomTabControl.TabPages.RemoveAt(0);
            
            OpenNewTabIfNeeded();

            KeyboardHookManager.Instance.SetShortCutDelegate(new Keys[] { Keys.Oemtilde }, ShortCutDelegate);
        }

        void TheCustomTabControl_TabClosing(object sender, TabControlCancelEventArgs e)
        {
            var consoleControl = (e.TabPage.Controls[0] as ConsoleControl);
                consoleControl.ExeTerminated -= ExeTerminated;

            OpenNewTabIfNeeded();
        }

        void NewTabEventHandler(object sender, EventArgs e)
        {
            var cmdExe = new ConsoleControl();
                cmdExe.IsInputEnabled = true;
                cmdExe.ExeTerminated += ExeTerminated;
                cmdExe.StartProcess("cmd", null);
                cmdExe.Font = this.Font;

            var tabPage = new TabPage(string.Format("Term {0}", ++_tabCount));
                tabPage.Controls.Add(cmdExe);
                tabPage.ContextMenuStrip = this.ContextMenuStrip;
                tabPage.Margin = new Padding(0);
                tabPage.Padding = new Padding(0);

            cmdExe.Dock = DockStyle.Fill;

            TheCustomTabControl.TabPages.Add(tabPage);
        }

        void ExeTerminated(object sender, EventArgs e)
        {
            Invoke((Action)(() =>
            {
                var tabPage = (sender as ConsoleControl).Parent as TabPage;
                TheCustomTabControl.TabPages.Remove(tabPage);

                OpenNewTabIfNeeded();
            }));
        }

        private void OpenNewTabIfNeeded()
        {
            if (TheCustomTabControl.TabPages.Count == 0)
                NewTabEventHandler(this, EventArgs.Empty);
        }
    }
}
