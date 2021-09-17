using System;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ok_btn_Click(object sender, EventArgs e)
        {
            var msg = new MessageData("Citrix");
            this.timeLabel.Text = msg.ToString();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var dt = GetCurrent();
            this.timeLabel.Text = dt.ToString();
        }
        static DateTime GetCurrent()
        {
            return DateTime.Now;
        }
    }
    public class MessageData
    {
        private readonly string _value;
        public MessageData(string value)
        {
            this._value = value;
        }

        public override string ToString()
        {
            return _value;
        }
    }

}
