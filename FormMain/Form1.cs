using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sourceData = richTextBox1.Text.TrimStart().TrimEnd();
            string[] siplitSource = sourceData.Split(' ');
            if (siplitSource.Length > 0)
            {
                Byte[] convertBytes = new byte[siplitSource.Length];
                for (int i = 0; i < siplitSource.Length; i++)
                {
                    convertBytes[i] = (Byte)Convert.ToInt32(siplitSource[i],16);
                }
                richTextBox2.Text = System.Text.Encoding.Default.GetString(convertBytes);
            }
        }
    }
}
