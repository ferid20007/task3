using System;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 650;
            this.Width = 850;

            if (comboBox1 != null) comboBox1.Items.AddRange(new string[] { "Bakı", "Gəncə", "Sumqayıt", "Şəki", "Qəbələ", "Lənkəran" });
            if (comboBox2 != null) comboBox2.Items.AddRange(new string[] { "Bakı", "Gəncə", "Sumqayıt", "Şəki", "Qəbələ", "Lənkəran" });
        }

        // "Bilet al" Butonu (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(comboBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Lütfən, əsas xanaları doldurun!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bilet = $"Ad: {textBox1.Text} | FIN: {textBox2.Text} | Email: {textBox3.Text} | Tel: {maskedTextBox3.Text} | " +
                          $"Marşrut: {comboBox1.Text} -> {comboBox2.Text} | Tarix: {maskedTextBox1.Text} {maskedTextBox2.Text} | Yer: {textBox4.Text}";

            // ListBox-ın adı 'ff' olduğu üçün bura əlavə olunur
            if (ff != null)
            {
                ff.Items.Add(bilet);
            }

            MessageBox.Show("Bilet uğurla əlavə olundu!", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Rota değiştirme "< >" Butonu (button2)
        private void button2_Click(object sender, EventArgs e)
        {
            string temp = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = temp;
        }

        // "Proqram çıx" Butonu
        private void button3_Click(object sender, EventArgs e)
        {
            CixisEt();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            CixisEt();
        }

        private void CixisEt()
        {
            DialogResult d = MessageBox.Show("Proqramdan çıxış edilsinmi?", "Bildiriş", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // "Bileti sil" Butonu (button4)
        private void button4_Click(object sender, EventArgs e)
        {
            if (ff != null && ff.SelectedIndex != -1)
            {
                ff.Items.RemoveAt(ff.SelectedIndex);
                MessageBox.Show("Seçilmiş bilet silindi.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfən, silmək üçün siyahıdan bir bilet seçin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Tasarımcı kliklərindən yaranan xətalara qarşı boş metodlar
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
    }
}