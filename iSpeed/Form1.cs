using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSpeed
{
    public partial class Form1 : Form
    {

        public List<Sendung> sendungsartenList;


        

        public Form1()
        {
            InitializeComponent();
            sendungsartenList= new List<Sendung>();
            P1 p1 = new P1();
            P2 p2 = new P2();
            P3 p3 = new P3();
            B1 b1 = new B1();
            B2 b2 = new B2();

            sendungsartenList.Add(b1);
            sendungsartenList.Add(b2);
            sendungsartenList.Add(p1);
            sendungsartenList.Add(p2);
            sendungsartenList.Add(p3);

            
        }
        

        private void btn_Portorechnen_Click(object sender, EventArgs e)
        {
            

        }

        private void rbtn_Brief_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Brief.Checked == true)
            {
                cbox_Sendungsart.Items.Add("B1");
                cbox_Sendungsart.Items.Add("B2");
            }
            else
            {
                cbox_Sendungsart.Items.Clear();
            }
           

        }

        private void rbtn_Packet_CheckedChanged(object sender, EventArgs e)
        {
            cbox_Sendungsart.Items.Clear();
            if (rbtn_Packet.Checked == true)
            {
                foreach (Sendung s in sendungsartenList)
                {
                    cbox_Sendungsart.Items.Add(s.GetType().Name);
                }

            }
            else
            {
                cbox_Sendungsart.Items.Clear();
            }
        }
    }
}
