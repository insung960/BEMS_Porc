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

        private void Form1_Load(object sender, EventArgs e)
        {
            //DB 연결 (XML 추가)

            //DB내의 값 읽어오는 부분

            //실제 데이터 읽어오는부분

            //실데이터 입력부분
        }

        // -------------------------------------------------------------------------------

        //Hide 버튼 클릭
        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
