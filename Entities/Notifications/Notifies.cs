using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notifications
{
    public class Notifies
    {
        public Notifies()
        {
            Notitycoes = new List<Notifies>();
        }

        [NotMapped]
        public string NomePropriedade { get; set; }

        [NotMapped]
        public string Mensagem { get; set; }

        [NotMapped]
        public List<Notifies> Notitycoes;



        public bool ValidarPropriedadeString(string valor, string nomepropriedade)
        {
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomepropriedade))
            {
                Notitycoes.Add(new Notifies
                {
                    Mensagem = "Campo Obrigatório",
                    NomePropriedade = nomepropriedade
                });
                return false;
            }

            return true;
        }


        public bool ValidarPropriedadeInt(int valor, string nomepropriedade)

        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomepropriedade))
            {
                Notitycoes.Add(new Notifies
                {
                    Mensagem = "Valor deve ser maior que 0",
                    NomePropriedade = nomepropriedade
                });
                return false;
            }

            return true;
        }


        public bool ValidarPropriedadeDecimal(decimal valor, string nomepropriedade)

        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomepropriedade))
            {
                Notitycoes.Add(new Notifies
                {
                    Mensagem = "Valor deve ser maior que 0",
                    NomePropriedade = nomepropriedade
                });
                return false;
            }

            return true;
        }

    }
}
