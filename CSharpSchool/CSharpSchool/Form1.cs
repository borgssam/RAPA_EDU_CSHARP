using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSchool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {

            ClearResult();
        }

        private void ClearResult()
        {
            this.tbox_result.Clear();
        }

        private void WriteLine(object obj)
        {
             Write(string.Format("{0}\r\n", obj));
        }
        private void Write(string aText)
        {
            this.tbox_result.AppendText(aText);
        }

        private void Write(object obj)
        {
            Write(string.Format("{0}", obj));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Write(1234);
            WriteLine(1234);
            WriteLine(5678);
        }
    }
}
