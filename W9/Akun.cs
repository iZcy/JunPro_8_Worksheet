using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9
{
    public class Akun
    {
        private const int maxSaldo = 2000000;
        protected int saldo;
        protected string password;

        public Akun(int saldo, string password)
        {
            this.saldo = saldo;
            this.password = password;
        }

        public int Saldo
        {
            get { return saldo; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Saldo tidak bisa kurang dari 0 Rupiah");
                }
                else if (value > maxSaldo)
                {
                    throw new InvalidOperationException("Saldo tidak boleh melebihi 2000000");
                }
                else
                {
                    saldo = (int)value;
                }
                saldo = value;
            }
        }

        public virtual void Setor(int jumlah)
        {
            Saldo += jumlah;
        }

        public virtual void Tarik(int jumlah)
        {
            Saldo -= jumlah;
        }

        public bool validatePassword(string password)
        {
            if(this.password == password) return true;
            return false;
        }
    }
}
