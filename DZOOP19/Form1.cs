using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZOOP19
{
    public partial class Form1 : Form
    {
        public delegate void Message(string message);

        public event Message SendMessageAllForms;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            //listBoxHistory.Items.Add(richTextBox.Text);
            SendMessageAllForms?.Invoke(richTextBox.Text);
        }

        private void buttonCreareForm_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            SendMessageAllForms += SendMessage;
            newForm.Show();
        }

        private void SendMessage(string text)
        {
            listBoxHistory.Items.Add(text);
        }
    }
}
