using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_cursus
{
    public partial class OOP1 : Form
    {
        MyCLass ob;
        public OOP1()
        {
            InitializeComponent();
        }
        private void btn_CreateOb_Click(object sender, EventArgs e)
        {
            ob = new MyCLass();
        }

        private void btn_SetString_Click(object sender, EventArgs e)
        {
            if (ob != null)
            {
                ob.SetS("A new string");
            }
        }

        private void btn_GetString_Click(object sender, EventArgs e)
        {
            if (ob != null)
            {
                textBox1.Text = ob.GetS();
            }
        }
    }
    class MyCLass
    {
        
        private string _s;

        public MyCLass()
        {
            _s = "Hello World";
        }
        public string GetS()
        {
            return _s;
        }
        public void SetS(string aString)
        {
            _s = aString;
        }
    }
}
