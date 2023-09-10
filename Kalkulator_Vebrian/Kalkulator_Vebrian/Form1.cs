namespace Kalkulator_Vebrian
{
    public partial class Form1 : Form
    {
        int angkaSatu = 0;
        int angkaDua = 0;
        double hasilKalkulator;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelAritmatika.Text = "";
            cetakAngka.Text = "";
            textHasil.Visible = false;
        }

        private void satu_Click(object sender, EventArgs e)
        {

            Button Btn = (Button)sender;
            cetakAngka.Text = cetakAngka.Text + Btn.Text;

            if(angkaSatu != 0)
            {
                angkaDua = int.Parse(cetakAngka.Text);
            }
            else
            {
                angkaSatu = int.Parse(cetakAngka.Text);
            }
     
        }
        private void dua_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            cetakAngka.Text = cetakAngka.Text + Btn.Text;

            if (angkaSatu != 0)
            {
                angkaDua = int.Parse(cetakAngka.Text);
            }
            else
            {
                angkaSatu = int.Parse(cetakAngka.Text);
            }
        }

        private void tiga_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            cetakAngka.Text = cetakAngka.Text + Btn.Text;

            if (angkaSatu != 0)
            {
                angkaDua = int.Parse(cetakAngka.Text);
            }
            else
            {
                angkaSatu = int.Parse(cetakAngka.Text);
            }
        }
        private void empat_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            cetakAngka.Text = cetakAngka.Text + Btn.Text;

            if (angkaSatu != 0)
            {
                angkaDua = int.Parse(cetakAngka.Text);
            }
        }

        private void lima_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            cetakAngka.Text = cetakAngka.Text + Btn.Text;

            if (angkaSatu != 0)
            {
                angkaDua = int.Parse(cetakAngka.Text);
            }
        }

        private void enam_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            cetakAngka.Text = cetakAngka.Text + Btn.Text;

            if (angkaSatu != 0)
            {
                angkaDua = int.Parse(cetakAngka.Text);
            }
        }

        private void tujuh_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            cetakAngka.Text = cetakAngka.Text + Btn.Text;

            if (angkaSatu != 0)
            {
                angkaDua = int.Parse(cetakAngka.Text);
            }
        }

        private void delapan_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            cetakAngka.Text = cetakAngka.Text + Btn.Text;

            if (angkaSatu != 0)
            {
                angkaDua = int.Parse(cetakAngka.Text);
            }
        }

        private void sembilan_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            cetakAngka.Text = cetakAngka.Text + Btn.Text;

            if (angkaSatu != 0)
            {
                angkaDua = int.Parse(cetakAngka.Text);
            }
        }

        private void nol_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            cetakAngka.Text = cetakAngka.Text + Btn.Text;

            if (angkaSatu != 0)
            {
                angkaDua = int.Parse(cetakAngka.Text);
            }
        }

        private void Btntambah_Click(object sender, EventArgs e)
        {
            labelAritmatika.Text = "";

            if (angkaSatu != 0)
            {
                labelAritmatika.Text = "+";
                cetakAngka.Text = "";
            }
            else
            {
                MessageBox.Show("Maaf Angka 1 Harus Di Isi!");
            }
        }

        private void Btnkurang_Click(object sender, EventArgs e)
        {
            labelAritmatika.Text = "";

            if (angkaSatu != 0)
            {
                labelAritmatika.Text = "-";
                cetakAngka.Text = "";

            }
            else
            {
                MessageBox.Show("Maaf Angka 1 Harus Di Isi!");
            }
        }

        private void Btnkali_Click(object sender, EventArgs e)
        {
            labelAritmatika.Text = "";

            if (angkaSatu != 0)
            {
                labelAritmatika.Text = "x";
                cetakAngka.Text = "";

            }
            else
            {
                MessageBox.Show("Maaf Angka 1 Harus Di Isi!");
            }
        }

        private void Btnbagi_Click(object sender, EventArgs e)
        {
            labelAritmatika.Text = "";

            if (angkaSatu != 0)
            {
                labelAritmatika.Text = "÷";
                cetakAngka.Text = "";

            }
            else
            {
                MessageBox.Show("Maaf Angka 1 Harus Di Isi!");
            }
        }

        private void Btnhasil_Click(object sender, EventArgs e)
        {
            if(angkaSatu != 0 && angkaDua != 0 && labelAritmatika.Text != "")
            {
                if(hasilKalkulator == 0)
                {
                    if(labelAritmatika.Text == "÷")
                    {
                        hasilKalkulator = angkaSatu / angkaDua;
                    } 

                    else if (labelAritmatika.Text == "+")
                    {
                        hasilKalkulator = angkaSatu + angkaDua;
                    } 

                    else if (labelAritmatika.Text == "-")
                    {
                        hasilKalkulator = angkaSatu - angkaDua;
                    } 

                    else if (labelAritmatika.Text == "x")
                    {
                        hasilKalkulator = angkaSatu * angkaDua;
                    }
                    labelAritmatika.Text = "";
                    textHasil.Visible = true;
                    textHasil.Text = hasilKalkulator.ToString();
                }
                else
                {
                    MessageBox.Show("Maaf Anda Tidak Bisa Melakukan Operasi Lagi, Mohon Untuk Clear!!!");
                }

            }
            else
            {
                MessageBox.Show("Maaf Anda Harus Mengisi Semua Inputan");
            }
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            angkaSatu = 0;
            angkaDua = 0;
            cetakAngka.Text = "";
            labelAritmatika.Text = "";
            textHasil.Text = "";
            textHasil.Visible = false;

        }
    }
}