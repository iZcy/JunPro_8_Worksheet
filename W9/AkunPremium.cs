using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9
{
    internal class AkunPremium : Akun
    {
        public AkunPremium(int saldo, string password) : base (saldo, password) {
            Saldo = saldo;
            this.password = password;

        }

        public new int Saldo { 
            get { return this.saldo; } 
            set 
            {
                if (value < 0) throw new InvalidOperationException("Saldo tidak bisa kurang dari 0");
                else saldo = value;
            } 
        }

        public override void Setor(int jumlah)
        {
            Saldo += jumlah+500;
        }

        public override void Tarik(int jumlah)
        {
            Saldo = Saldo -jumlah +500;
        }
    }
}
