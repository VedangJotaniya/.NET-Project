using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace QuestionPaper
{
    public partial class Form1 : Form
    {
        Label[] label;
        public Form1()
        {
            InitializeComponent();

            label = new Label[6];
            for(int i=0;i<6;i++)
            {
                label[i] = new Label();

                label[i].Text = "label" + i; 
                label[i].Top = i * 50 + 50;
                label[i].Left = 40;
                label[i].AutoSize = true;                
                label[i].Visible = true;
                this.Controls.Add(label[i]);
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader FileData = new StreamReader(openFileDialog1.FileName);
                String FileText = FileData.ReadToEnd();
                //label1.Text = FileText;
                string Question = "Q";
                label1.Text = "";
                for( int i = 1; i < 6; i++)
                {
                    string QueCurrNum = Question + i + ".";
                    string QueNextNum = Question + (i+1) + ".";
                    int pos = FileText.IndexOf(QueCurrNum);
                    int next = FileText.IndexOf(QueNextNum);
                    //label1.Text += "Question : " + QueCurrNum + "pos =  " + pos + " length = " + (next - pos) + "\n";
                    label[i-1].Text = FileText.Substring(pos, next - pos);                                                         
                }
                label[5].Text = FileText.Substring(FileText.IndexOf("Q6."));

            }
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
