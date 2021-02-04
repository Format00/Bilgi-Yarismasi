using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0;
        string dogru;
        Form2 fr2 = new Form2();
        Form3 fr3 = new Form3();
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button6.Enabled = false;
            button5.Enabled = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

            label3.Visible = false;
            soruno++;
            label1.Text = soruno.ToString();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            
            if (soruno == 1)
            {
                richTextBox1.Text = "Mustafa Kemal Atatürk Kaç Yılında Doğmuştur?";
                button1.Text = "1881";
                button2.Text = "1880";
                button3.Text = "1882";
                button4.Text = "1938";
                dogru = button1.Text;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Trafikte hangi araçların arkasında 'Dolu' ya da 'Boş' yazar?";
                button1.Text="Akaryakıt Tankeri";
                button2.Text = "Öğrenci Servisi";
                button3.Text = "Harfiyat Kanyonu";
                button4.Text = "Yolcu Otobüsü";
                dogru = button1.Text;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Çubuklara geçirilmiş küçük bayraklarla işaretlenmiş bir parkurda, belli kurallara göre ve zikzaklar çizerek yapılan kayak yarışı hangisidir?";
                button1.Text = "Skeleton ";
                button2.Text = "Pentatlon ";
                button3.Text = "Slalom ";
                button4.Text = "Maraton";
                dogru = button4.Text;

            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Sıvıları taşımaya yarayan dar ağızlı, şişkin karınlı, genellikle hasır veya plastik sepet içinde korunan büyük şişişeye ne ad verilir?";
                button1.Text = "Varil";
                button2.Text = "Bidon";
                button3.Text = "Damacana";
                button4.Text = "Fıçı";
                dogru = button3.Text;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Klasik bir çengel bulmacada, bir kutucukta en fazla kaç farklı soru sorulur?";
                button1.Text = "1";
                button2.Text = "2";
                button3.Text = "3";
                button4.Text = "4";
                dogru = button2.Text;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "'İki dirhem bir çekirdek' ifadesi kimler için kullanılır?";
                button1.Text = "Boylu ve kilolu olanlar";
                button2.Text = "Az ve seyrek yiyenler";
                button3.Text = "Güzel ve özenli giyinenler";
                button4.Text = "Güçlü ve kaslı";
                dogru = button3.Text;

            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Genellikle güneşten korunmak için bir yerin üzerine gerilen, bez veya naylondan yapılmış örtüye ne ad verilir?";
                button1.Text = "Tente";
                button2.Text = "Marley";
                button3.Text = "Lambri";
                button4.Text = "Laminant";
                dogru = button1.Text;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Memleketlerinin plaka kodunu forma numarası yapan dört kişiden hangisinin numarası aynı iki rakamdan oluşmaz?";
                button1.Text = "Mersinli Olanın";
                button2.Text = "Zonguldaklı Olanın";
                button3.Text = "Malatyalı Olanın";
                button4.Text = "Samsunlu Olanın";
                dogru = button2.Text;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Patates cipsi paketleri, içinde cipslerin taze kalması için genellikle hangi gazla doldurulur?";
                button1.Text = "Oksijen";
                button2.Text = "Hidrojen";
                button3.Text = "Helyum";
                button4.Text = "Azot";
                dogru = button4.Text;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Halk arasında özellikle hangi yağmurun bereket getirdiğine inanılır?";
                button1.Text = "Şubat Yağmuru";
                button2.Text = "Nsian Yağmuru";
                button3.Text = "Haziran Yağmuru";
                button4.Text = "Ağustos Yağmuru";
                dogru = button2.Text;
            }
            if (soruno == 11)
            {
                richTextBox1.Text= "Hangisi, internetten video izlerken en sık karşılaşılan 'görüntü modlarından' biri değildir?";
                button1.Text = "360p";
                button2.Text = "480p";
                button3.Text = "640p";
                button4.Text = "720p";
                dogru = button3.Text;
            }
            if (soruno == 12)
            {
                richTextBox1.Text= "Hangi kelime 'kalınca bükülmüş ipek iplik' anlamına gelir?";
                button1.Text = "İbrik";
                button2.Text = "İlmik";
                button3.Text = "Meşin";
                button4.Text = "İbrişim";
                dogru = button4.Text;
                
            }
            
            button5.Text = "İleri";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            if (button1.BackColor == Color.Yellow)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            checkBox1.Checked = true;
            if (Color.Green == button1.BackColor)
            {
                label3.Visible = true;
            }
            button6.Enabled = true;
            



            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
            if (button2.BackColor == Color.Yellow)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            checkBox2.Checked = true;
            if (Color.Green == button1.BackColor)
            {
                label3.Visible = true;
            }
            button6.Enabled = true;




        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Yellow;
            if (button3.BackColor == Color.Yellow)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            checkBox3.Checked = true;
            if (Color.Green == button3.BackColor)
            {
                label3.Visible = true;
            }
            button6.Enabled = true;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Yellow;
            if (button4.BackColor == Color.Yellow)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            checkBox4.Checked = true;
            if (Color.Green == button4.BackColor)
            {
                label3.Visible = true;
            }
            button6.Enabled = true;



        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            checkBox1.Text = button1.Text;
            checkBox2.Text = button2.Text;
            checkBox3.Text = button3.Text;
            checkBox4.Text = button4.Text;

            if (button1.Text == dogru)
            {
                button1.BackColor = Color.Green;
                
            }
            if (button2.Text == dogru)
            {
                button2.BackColor = Color.Green;
            }
            if (button3.Text == dogru)
            {
                button3.BackColor = Color.Green;
            }
            if (button4.Text == dogru)
            {
                button4.BackColor = Color.Green;
            }

            if (checkBox1.Checked == true) 
            {
                
                    label3.Visible = true;
                
                if (soruno == 1 )
                {
                    listBox1.SetSelected(11, true);
                }
                if (soruno == 2)
                {
                    listBox1.SetSelected(10, true);
                }
                if (soruno == 3)
                {
                    listBox1.SetSelected(9, true);
                }
                if (soruno == 4)
                {
                    listBox1.SetSelected(8, true);
                }
                if (soruno == 5)
                {
                    listBox1.SetSelected(7, true);
                }
                if (soruno == 6)
                {
                    listBox1.SetSelected(6, true);
                }
                if (soruno == 7)
                {
                    listBox1.SetSelected(5, true);
                }
                if (soruno == 8)
                {
                    listBox1.SetSelected(4, true);
                }
                if (soruno == 9)
                {
                    listBox1.SetSelected(3, true);
                }
                if (soruno == 10)
                {
                    listBox1.SetSelected(2, true);
                }
                if (soruno == 11)
                {
                    listBox1.SetSelected(1, true);
                }
                if (soruno == 12)
                {
                    listBox1.SetSelected(0, true);
                }

            }
            if (checkBox2.Checked == true)
            {
                label3.Visible = true;

                if (soruno == 1)
                {
                    listBox1.SetSelected(11, true);
                }
                if (soruno == 2)
                {
                    listBox1.SetSelected(10, true);
                }
                if (soruno == 3)
                {
                    listBox1.SetSelected(9, true);
                }
                if (soruno == 4)
                {
                    listBox1.SetSelected(8, true);
                }
                if (soruno == 5)
                {
                    listBox1.SetSelected(7, true);
                }
                if (soruno == 6)
                {
                    listBox1.SetSelected(6, true);
                }
                if (soruno == 7)
                {
                    listBox1.SetSelected(5, true);
                }
                if (soruno == 8)
                {
                    listBox1.SetSelected(4, true);
                }
                if (soruno == 9)
                {
                    listBox1.SetSelected(3, true);
                }
                if (soruno == 10)
                {
                    listBox1.SetSelected(2, true);
                }
                if (soruno == 11)
                {
                    listBox1.SetSelected(1, true);
                }
                if (soruno == 12)
                {
                    listBox1.SetSelected(0, true);
                }

            }
            if (checkBox3.Checked == true)
            {
                label3.Visible = true;

                if (soruno == 1)
                {
                    listBox1.SetSelected(11, true);
                }
                if (soruno == 2)
                {
                    listBox1.SetSelected(10, true);
                }
                if (soruno == 3)
                {
                    listBox1.SetSelected(9, true);
                }
                if (soruno == 4)
                {
                    listBox1.SetSelected(8, true);
                }
                if (soruno == 5)
                {
                    listBox1.SetSelected(7, true);
                }
                if (soruno == 6)
                {
                    listBox1.SetSelected(6, true);
                }
                if (soruno == 7)
                {
                    listBox1.SetSelected(5, true);
                }
                if (soruno == 8)
                {
                    listBox1.SetSelected(4, true);
                }
                if (soruno == 9)
                {
                    listBox1.SetSelected(3, true);
                }
                if (soruno == 10)
                {
                    listBox1.SetSelected(2, true);
                }
                if (soruno == 11)
                {
                    listBox1.SetSelected(1, true);
                }
                if (soruno == 12)
                {
                    listBox1.SetSelected(0, true);
                }

            }
            if (checkBox4.Checked == true)
            {
                label3.Visible = true;

                if (soruno == 1)
                {
                    listBox1.SetSelected(11, true);
                }
                if (soruno == 2)
                {
                    listBox1.SetSelected(10, true);
                }
                if (soruno == 3)
                {
                    listBox1.SetSelected(9, true);
                }
                if (soruno == 4)
                {
                    listBox1.SetSelected(8, true);
                }
                if (soruno == 5)
                {
                    listBox1.SetSelected(7, true);
                }
                if (soruno == 6)
                {
                    listBox1.SetSelected(6, true);
                }
                if (soruno == 7)
                {
                    listBox1.SetSelected(5, true);
                }
                if (soruno == 8)
                {
                    listBox1.SetSelected(4, true);
                }
                if (soruno == 9)
                {
                    listBox1.SetSelected(3, true);
                }
                if (soruno == 10)
                {
                    listBox1.SetSelected(2, true);
                }
                if (soruno == 11)
                {
                    listBox1.SetSelected(1, true);
                }
                if (soruno == 12)
                {
                    listBox1.SetSelected(0, true);
                }
            }

            if (checkBox1.Checked == true)
            {
                if(button1.Text != dogru)
                {
                    fr2.Show();
                    this.Hide();
                }
                
                
            }
            if (checkBox2.Checked == true)
            {
                if (button2.Text != dogru)
                {
                    fr2.Show();
                    this.Hide();
                }
                

            }
            if (checkBox3.Checked == true)
            {
                if (button3.Text != dogru)
                {
                    fr2.Show();
                    this.Hide();
                }

            }
            if (checkBox4.Checked == true)
            {
                if (button4.Text != dogru)
                {
                    fr2.Show();
                    this.Hide();
                }
            }
            if (soruno == 12 && checkBox4.Checked == true) 
            {
                fr3.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("12.   1.000.000TL");
            listBox1.Items.Add("11.   250.000TL");
            listBox1.Items.Add("10.   125.000TL");
            listBox1.Items.Add("9.    60.000TL");
            listBox1.Items.Add("8.    30.000TL");
            listBox1.Items.Add("7.    15.000TL");
            listBox1.Items.Add("6.    7.500TL");
            listBox1.Items.Add("5.    5.000TL");
            listBox1.Items.Add("4.    3.000TL");
            listBox1.Items.Add("3.    2.000TL");
            listBox1.Items.Add("2.    1.000TL");
            listBox1.Items.Add("1.    500TL");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkBox1.Text = button1.Text;
            checkBox2.Text = button2.Text;
            checkBox3.Text = button3.Text;
            checkBox4.Text = button4.Text;
        }
    }
}
