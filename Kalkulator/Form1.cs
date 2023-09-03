namespace Kalkulator
{
    public partial class Form1 : Form
    {

        double? x = null;
        double? y = null;
        double hasil;
        string artmatika = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void boxhasil_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // check variable x, y artmatika
            if(x == null)
            {
                angkaX.Text = "";
            }
          
            if (y == null)
            {
                angkaY.Text = "";
            }
            
            if (artmatika == "")
            {
                aritmatika.Text = "";
            }
            
            hasiloperasi.Text = "";
            hasiloperasi.Visible = false;
            
        }

        private void satu_Click(object sender, EventArgs e)
        {
            // metrigger ketika button di klik
            Button btn = (Button)sender;

            // jika x sudah ada value selain null maka dia akan menambahkan data y
            if(x != null && artmatika != "")
            {

                angkaY.Visible = true;
                angkaY.Text = angkaY.Text + btn.Text;
                y = int.Parse(angkaY.Text);
            }
            else
            {
                angkaY.Visible = false;
                angkaX.Text = angkaX.Text + btn.Text;
                x = int.Parse(angkaX.Text);

            }

        }

        private void dua_Click(object sender, EventArgs e)
        {
            // metrigger ketika button di klik
            Button btn = (Button)sender;

            // jika x sudah ada value selain null maka dia akan menambahkan data y
            if (x != null && artmatika != "")
            {
                angkaY.Visible = true;
                angkaY.Text = angkaY.Text + btn.Text;
                y = int.Parse(angkaY.Text);
            }
            else
            {
                angkaY.Visible = false;
                angkaX.Text = angkaX.Text + btn.Text;
                x = int.Parse(angkaX.Text);

            }
        }
        private void tiga_Click(object sender, EventArgs e)
        {
            // metrigger ketika button di klik
            Button btn = (Button)sender;

            // jika x sudah ada value selain null maka dia akan menambahkan data y
            if (x != null && artmatika != "")
            {
                angkaY.Visible = true;
                angkaY.Text = angkaY.Text + btn.Text;
                y = int.Parse(angkaY.Text);
            }
            else
            {
                angkaY.Visible = false;
                angkaX.Text = angkaX.Text + btn.Text;
                x = int.Parse(angkaX.Text);

            }
        }
        private void empat_Click(object sender, EventArgs e)
        {
            // metrigger ketika button di klik
            Button btn = (Button)sender;

            // jika x sudah ada value selain null maka dia akan menambahkan data y
            if (x != null && artmatika != "")
            {
                angkaY.Visible = true;
                angkaY.Text = angkaY.Text + btn.Text;
                y = int.Parse(angkaY.Text);
            }
            else
            {
                angkaY.Visible = false;
                angkaX.Text = angkaX.Text + btn.Text;
                x = int.Parse(angkaX.Text);

            }
        }
        private void lima_Click(object sender, EventArgs e)
        {
            // metrigger ketika button di klik
            Button btn = (Button)sender;

            // jika x sudah ada value selain null maka dia akan menambahkan data y
            if (x != null && artmatika != "")
            {
                angkaY.Visible = true;
                angkaY.Text = angkaY.Text + btn.Text;
                y = int.Parse(angkaY.Text);
            }
            else
            {
                angkaY.Visible = false;
                angkaX.Text = angkaX.Text + btn.Text;
                x = int.Parse(angkaX.Text);

            }
        }

        private void enam_Click(object sender, EventArgs e)
        {
            // metrigger ketika button di klik
            Button btn = (Button)sender;

            // jika x sudah ada value selain null maka dia akan menambahkan data y
            if (x != null && artmatika != "")
            {
                angkaY.Visible = true;
                angkaY.Text = angkaY.Text + btn.Text;
                y = int.Parse(angkaY.Text);
            }
            else
            {
                angkaY.Visible = false;
                angkaX.Text = angkaX.Text + btn.Text;
                x = int.Parse(angkaX.Text);

            }
        }

        private void tujuh_Click(object sender, EventArgs e)
        {
            // metrigger ketika button di klik
            Button btn = (Button)sender;

            // jika x sudah ada value selain null maka dia akan menambahkan data y
            if (x != null && artmatika != "")
            {
                angkaY.Visible = true;
                angkaY.Text = angkaY.Text + btn.Text;
                y = int.Parse(angkaY.Text);
            }
            else
            {
                angkaY.Visible = false;
                angkaX.Text = angkaX.Text + btn.Text;
                x = int.Parse(angkaX.Text);

            }
        }

        private void delapan_Click(object sender, EventArgs e)
        {
            // metrigger ketika button di klik
            Button btn = (Button)sender;

            // jika x sudah ada value selain null maka dia akan menambahkan data y
            if (x != null && artmatika != "")
            {
                angkaY.Visible = true;
                angkaY.Text = angkaY.Text + btn.Text;
                y = int.Parse(angkaY.Text);
            }
            else
            {
                angkaY.Visible = false;
                angkaX.Text = angkaX.Text + btn.Text;
                x = int.Parse(angkaX.Text);

            }
        }

        private void sembilan_Click(object sender, EventArgs e)
        {
            // metrigger ketika button di klik
            Button btn = (Button)sender;

            // jika x sudah ada value selain null maka dia akan menambahkan data y
            if (x != null && artmatika != "")
            {
                angkaY.Visible = true;
                angkaY.Text = angkaY.Text + btn.Text;
                y = int.Parse(angkaY.Text);
            }
            else
            {
                angkaY.Visible = false;
                angkaX.Text = angkaX.Text + btn.Text;
                x = int.Parse(angkaX.Text);

            }
        }

        private void enol_Click(object sender, EventArgs e)
        {
            // metrigger ketika button di klik
            Button btn = (Button)sender;

            // jika x sudah ada value selain null maka dia akan menambahkan data y
            if (x != null && artmatika != "")
            {
                angkaY.Visible = true;
                angkaY.Text = angkaY.Text + btn.Text;
                y = int.Parse(angkaY.Text);
            }
            else
            {
                angkaY.Visible = false;
                angkaX.Text = angkaX.Text + btn.Text;
                x = int.Parse(angkaX.Text);

            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if(x != null && y != null && artmatika != "")
            {
                hasiloperasi.Visible = true;
                if(artmatika == "+")
                {
                    
                    hasil = (double)x + (double)y;
                } 
                else if (artmatika == "-") {
                    hasil = (double)x - (double)y;
                }
                else
                {
                    hasil = (double)x * (double)y;
                }
                hasiloperasi.Text = hasil.ToString();
    
            }
            else
            {
                MessageBox.Show("Maaf Anda Harus Menyelesaikan Inputan Terlebih Dahulu!");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            x = null;
            y = null;
            artmatika = "";
            angkaX.Text = "";
            angkaY.Text = "";
            aritmatika.Text = "";
            hasiloperasi.Text = "";
            hasiloperasi.Visible = false;
        }


        private void plus_Click(object sender, EventArgs e)
        {
            artmatika = "+";
            aritmatika.Text = artmatika;
        }

        private void min_Click(object sender, EventArgs e)
        {
            artmatika = "-";
            aritmatika.Text = artmatika;
        }

        private void kali_Click(object sender, EventArgs e)
        {
            artmatika = "x";
            aritmatika.Text = artmatika;
        }


        private void angkaX_Click(object sender, EventArgs e)
        {

        }

        private void angkaY_Click(object sender, EventArgs e)
        {

        }

        private void hasiloperasi_Click(object sender, EventArgs e)
        {

        }


    }
}