using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSpeed
{
    public partial class Form1 : Form
    {
        public List<Sendung> PaketartenList;
        public List<Sendung> BriefartenList;
        public double porto;
        B1 b1;
        B2 b2;
        P1 p1;
        P2 p2;
        P3 p3;

        Sendung current_sendung;
        public Form1()
        {
            InitializeComponent();
            //cbox_Sendungsart.Enabled = false;

            p1 = new P1();
            p2 = new P2();
            p3 = new P3();

            b1 = new B1();
            b2 = new B2();

        }

        public void check_paket()
        {
            cbox_Sendungsart.Items.Clear();
            cbox_Sendungsart.Text = "";

            int current_gewicht = Convert.ToInt32(nud_Gewicht.Value);

            if (current_gewicht <= 500)
            {
                cbox_Sendungsart.Text = p1.GetType().Name;

            }
            else if (current_gewicht <= 1000 && current_gewicht > 500)
            {
                cbox_Sendungsart.Text = p2.GetType().Name;
            }
            else if (current_gewicht > 1000)
            {
                cbox_Sendungsart.Text = p3.GetType().Name;
            }
        }

        public void activate_brief_list()
        {
            brief_list_box.Items.Clear();
            brief_list_box.Visible = true;
            brief_list_box.Enabled = true;
            brief_list_box.Items.Add("A1");
            brief_list_box.Items.Add("B4");
            brief_list_box.Items.Add("C4");

            nud_Gewicht.Visible = false;
            nud_Gewicht.Enabled = false;



        }
        public void deactivate_brief_list()
        {
            brief_list_box.Items.Clear();
            brief_list_box.Visible = false;
            brief_list_box.Enabled = false;
            nud_Gewicht.Visible = true;
            nud_Gewicht.Enabled = true;
        }


        public void check_brief()
        {
            cbox_Sendungsart.Text = "";
            cbox_Sendungsart.Items.Clear();
            if (brief_list_box.Text == "A1")
            {
                cbox_Sendungsart.Text = b1.GetType().Name;
            }
            if (brief_list_box.Text == "B4" || brief_list_box.Text == "C4")
            {
                cbox_Sendungsart.Text = b2.GetType().Name;
            }
        }

        public Sendung erstelle_Sendung(string sendungs_name)
        {
            Sendung sendung;
            switch (sendungs_name)
            {
                case "B1":
                    sendung = new B1();
                    break;
                case "B2":
                    sendung = new B2();
                    break;
                case "P1":
                    sendung = new P1();
                    break;
                case "P2":
                    sendung = new P2();
                    break;
                case "P3":
                    sendung = new P3();
                    break;
                default:
                    sendung = new Sendung();
                    break;
            }




            return sendung;
        }



        private void btn_Portorechnen_Click(object sender, EventArgs e)
        {
            ListViewItem stats = new ListViewItem();
            if (cbox_Sendungsart.Text != null)
            {
                Sendung current_sendung;
                current_sendung = erstelle_Sendung(cbox_Sendungsart.Text);

                porto = current_sendung.Portoberechnung(Convert.ToDouble(nud_Entfernung.Value));

                stats.SubItems.Add(cbox_Sendungsart.Text);
                stats.SubItems.Add(nud_Entfernung.Value.ToString());
                stats.SubItems.Add(nud_Gewicht.Value.ToString());
                stats.SubItems.Add(porto.ToString());

                listView1.Items.Add(stats);
                //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);






            }

        }

        private void rbtn_Brief_CheckedChanged(object sender, EventArgs e)
        {



            if (rbtn_Brief.Checked == true)
            {
                activate_brief_list();
                check_brief();


            }
            else
            {
                cbox_Sendungsart.Items.Clear();
            }


        }

        private void rbtn_Packet_CheckedChanged(object sender, EventArgs e)
        {


            if (rbtn_Packet.Checked == true)
            {
                check_paket();
                deactivate_brief_list();


            }
            else
            {
                cbox_Sendungsart.Items.Clear();
            }



        }

        private void nud_Gewicht_ValueChanged(object sender, EventArgs e)
        {
            check_paket();

        }

        private void brief_list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            check_brief();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
