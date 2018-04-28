using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestFit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
       SortedList s1 = new SortedList();
       string radioname;
       List <Process> P=new List <Process>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void enterdatabtn_Click(object sender, EventArgs e)
        {
            
            UInt64 x, y;
           

            x = Convert.ToUInt64(holedata.Text);
            y = Convert.ToUInt64(addressdata.Text);

          
            holedata.Text = "";
            addressdata.Text = "";
            if (firstfit.Checked == true)
            {
                radioname = "firstfit";
                bestfit.Checked = false;
                worstfit.Checked = false;
            }
            else if (bestfit.Checked == true)
            {
                radioname = "bestfit";
                firstfit.Checked = false;
                worstfit.Checked = false;
            }
            else if (worstfit.Checked == true)
            {
                radioname = "worstfit";
                bestfit.Checked = false;
                firstfit.Checked = false;
            }

            if (radioname == "firstfit")
            //l key howa l hole addr
                s1.Add(y, x);
                else if (radioname == "bestfit")
            
                s1.Add(x, y);
                
              
            
 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void output_Click(object sender, EventArgs e)
        {
            object A;
            object B;
            if (radioname == "firstfit")
            {
                for (int i = 0; i < s1.Count; i++)
                {
                    A = s1.GetKey(i);
                    ListViewItem lv = new ListViewItem(A.ToString());
                    B = s1.GetByIndex(i);
                    lv.SubItems.Add(B.ToString());
                    listView1.Items.Add(lv);
                }
            }
            else if (radioname == "bestfit")
            {
                for (int i = 0; i < s1.Count; i++)
                {
                    A = s1.GetByIndex(i);
                    ListViewItem lv = new ListViewItem(A.ToString());
                    B = s1.GetKey(i);
                    lv.SubItems.Add(B.ToString());
                    listView1.Items.Add(lv);
                }
            }
            
          
        }

        private void enterprocessbtn_Click(object sender, EventArgs e)
        {  
               int counter = 0;
                UInt64 C;
                UInt64 X, y;
                Process P1 = new Process(processid.Text, Convert.ToUInt64(processsize.Text));
                P.Add(P1);
            if (firstfit.Checked == true)
            {
                
                
                    for (int j = 0; j < s1.Count; j++)
                    {
                        if ( Convert.ToUInt64(s1.GetByIndex(j)) >= P1.getProcessSize() && counter == 0)
                        {
                            P1.setStartingAddress(Convert.ToUInt64(s1.GetKey(j)));
                            C = Convert.ToUInt64(s1.GetByIndex(j));
                            X = P1.getProcessSize();
                            y = C - X;
                            s1.SetByIndex(j, y);
                            counter++;
                        }
                    }
               

                ListViewItem lv = new ListViewItem(P1.getProcessID());
                lv.SubItems.Add(P1.getStartingAddress().ToString());
                lv.SubItems.Add(P1.getProcessSize().ToString());
                listView2.Items.Add(lv);
            }

           if (bestfit.Checked == true)
            {
                object O;
               
                    for (int l = 0; l < s1.Count; l++)
                    {
                        if (Convert.ToUInt64(s1.GetKey(l)) >= P1.getProcessSize() && counter == 0)
                        {
                            P1.setStartingAddress(Convert.ToUInt64(s1.GetByIndex(l)));
                            C = Convert.ToUInt64(s1.GetKey(l));
                            X = P1.getProcessSize();
                            y = C - X;
                            O = s1.GetByIndex(l);
                            s1.RemoveAt(l);
                            s1.Add(y,O);
                            counter++;
                        }
                    }
                
                
                ListViewItem lv = new ListViewItem(P1.getProcessID());
                lv.SubItems.Add(P1.getStartingAddress().ToString());
                lv.SubItems.Add(P1.getProcessSize().ToString());
                listView2.Items.Add(lv);
            }
           // if (worstfit.Checked == true)
           // {

           // }

        }
    }
    
}
