using PatricioSolucao.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatricioSolucao.Infra.Dados.Testes
{
    public static class ObjetoBase
    {
        public static Proprietario criaProprietario()
        {
            Proprietario novoProprietario = new Proprietario();
            novoProprietario.nome = "Alano";
            novoProprietario.cpf = "333.333.333.37";
            novoProprietario.rg = "5.555.555";
            novoProprietario.dataNascimento = new DateTime(1995, 12, 28);
            novoProprietario.dadosBancarios = "abcbolinhas";
            return novoProprietario;
        }

        public static Locatario criaLocatario()
        {
            Locatario novoLocatario = new Locatario();
            novoLocatario.nome = "Alano";
            novoLocatario.cpf = "333.333.333.37";
            novoLocatario.rg = "5.555.555";
            novoLocatario.dataNascimento = new DateTime(1995, 12, 28);
            novoLocatario.renda = 2500;
            novoLocatario.avalista = false;
            novoLocatario.nomeAvalista = "";
            novoLocatario.cpfAvalista = "";
            novoLocatario.rendaAvalista = 0;
            return novoLocatario;
        }
    }
}
