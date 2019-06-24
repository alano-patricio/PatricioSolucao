using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PatricioSolucao.Dominio
{
    public class Locatario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public DateTime dataNascimento { get; set; }
        public float renda { get; set; }
        public bool avalista { get; set; }
        public string nomeAvalista { get; set; }
        public string cpfAvalista { get; set; }
        public float rendaAvalista { get; set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(nome))
                throw new Exception("Nome é obrigatório!");
            if (string.IsNullOrEmpty(cpf))
                throw new Exception("CPF é obrigatório!");
            if (string.IsNullOrEmpty(rg))
                throw new Exception("RG é obrigatório!");
            if (dataNascimento == new DateTime(0001))
                throw new Exception("Deve possuir uma data valida!");
            if (dataNascimento <= new DateTime(2001))
                throw new Exception("Deve possuir maior idade");
            if (renda == 0)
                throw new Exception("Deve possuir uma renda!");
            if (avalista == true && string.IsNullOrEmpty(nomeAvalista))
               throw new Exception("Avalista deve possuir um nome!");
            if (avalista && string.IsNullOrEmpty(cpfAvalista))
                throw new Exception("Avalista deve possuir um cpf!");
            if (avalista && rendaAvalista == 0)
                throw new Exception("Avalista deve possuir renda!");
        }
    }
}
