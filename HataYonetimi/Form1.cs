using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataYonetimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHataYonetimsiz_Click(object sender, EventArgs e)
        {
            int telefonNumarasi = Convert.ToInt32(TextBox1.Text);
            MessageBox.Show("Tebrikler, Telefon Numaranı sisteme girebildin! ");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnHataYonetimli_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(TextBox1.Text);
                MessageBox.Show("Tebrikler, Telefon Numaranı sisteme girebildin! ");
            }
            catch
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatta giriniz\nTelefon Formatı : 02123334455");

            }
        }

        private void BtnOrnek3_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(TextBox1.Text);
                MessageBox.Show("Tebrikler, Telefon Numaranı sisteme girebildin! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatta giriniz\nTelefon Formatı : 02123334455");
            }
        }

        private void BtnOrnek4_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(TextBox1.Text);
                MessageBox.Show("Tebrikler, Telefon Numaranı sisteme girebildin! ");
            }
            catch (DuplicateWaitObjectException)
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatta giriniz\nTelefon Formatı : 02123334455");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatta giriniz\nTelefon Formatı : 02123334455");
            }
            catch (DeletedRowInaccessibleException)
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatta giriniz\nTelefon Formatı : 02123334455");
            }
            catch (DllNotFoundException)
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatta giriniz\nTelefon Formatı : 02123334455");
            }
        }

        private void BtnHataYonetimliFinally_Click(object sender, EventArgs e)
        {
            try
            {
                int telefonNumarasi = Convert.ToInt32(TextBox1.Text);
                MessageBox.Show("Tebrikler, Telefon Numaranı sisteme girebildin! ");
            }
            catch 
            {
                MessageBox.Show("Lütfen telefon numaranızı eksiksiz ve sadece sayısal verilerden oluşan bir formatta giriniz\nTelefon Formatı : 02123334455");
            }
            finally
            {
                MessageBox.Show("Bu alan içerisinde yer alan kod blokları her zaman çalışacaktır.");
            }
        }
    