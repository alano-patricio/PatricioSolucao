using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PatricioSolucao.Dominio
{
    public class Imovel
    {

        public int id { get; set; }
        public string bairro { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string pontoReferencia { get; set; }
        public string observacoes { get; set; }
        public bool tipo { get; set; }
        public float valor { get; set; }
        public char situacao { get; set; }
        public int id_proprietario { get; set; }
        public int? id_locatario { get; set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(bairro))
                throw new Exception("O campo bairro não pode ficar em branco!");
            if (string.IsNullOrEmpty(rua))
                throw new Exception("O campo rua não pode ficar em branco!");
            if (numero <= 0)
                throw new Exception("O campo numero não pode ser zero!");
            if (id_proprietario <= 0)
                throw new Exception("Id inválido!");
            if (valor == 0)
                throw new Exception("O campo valor não pode ficar em branco!");
            if (situacao >= '4' || situacao < 0)
                throw new Exception("O campo situação incorreto!");
            if (tipo == true)
                throw new Exception("Selecione uma opção no campo tipo!");
        }
    }
}
