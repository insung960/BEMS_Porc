using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BEMS_Porc
{
    public partial class Form1 : Form
    {
        public bool m_bBreak = false;


        public Form1()
        {
            InitializeComponent();
        }

        // -------------------------------------------------------------------------------

        //Hide 버튼 클릭
        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
