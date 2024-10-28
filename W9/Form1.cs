using System.Security.AccessControl;

namespace W9
{

    public partial class Form1 : Form
    {
        Akun akun = new AkunPremium(20000, "sapihijau");
        public Form1()
        {
            InitializeComponent();
            SaldoLabel.Text = akun.Saldo.ToString();

        }

        private void TarikSaldo(int total)
        {
            akun.Tarik(total);
            SaldoLabel.Text = akun.Saldo.ToString();
        }

        private void SetorSaldo(int total)
        {
            akun.Setor(total);
            SaldoLabel.Text = akun.Saldo.ToString();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (akun.validatePassword(passwordBox.Text))
            {

                if (setorButton.Checked)
                {
                    SetorSaldo(int.Parse(uangBox.Text));
                    MessageBox.Show("Saldo Berhasil Ditambah");
                }
                else if (tarikButton.Checked) 
                {
                    TarikSaldo(int.Parse(uangBox.Text));
                    MessageBox.Show("Saldo Berhasil Ditarik");

                }
            }
            else
            {
                MessageBox.Show("PasswordSalah");
            }

        }
    }
}
