using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatricioSolucao.Dominio
{
    public class Financeiro
    {
        public int id { get; set; }
        public float valor { get; set; }
        public bool operacao { get; set; }
        public float balanco { get; set; }

        public void Validar()
        {
            if (valor <= 0)
                throw new Exception("O campo numero não pode ser zero!");
            if (operacao)
                throw new Exception("Selecione uma operação!");
        }

    }
}
