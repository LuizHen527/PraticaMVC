using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticaAprendendoMVC.Model
{
    public class Evento
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string DataEvento { get; set; }

        public const string Path = "Database/Eventos.csv";

        public Evento()
        {
            string pasta = Path.Split("/")[0];

            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(Path))
            {
                File.Create(Path);
            }
        }

        private string PrepararCadastro(Evento e)
        {
            return $@"{e.Nome};{e.Descricao};{e.DataEvento}";
        }

        public void SalvarCadastro(Evento evento)
        {
            string[] linhaCadastro = {PrepararCadastro(evento)};

            File.AppendAllLines(Path, linhaCadastro);
        }

        public List<Evento> Ler()
        {
            List<Evento> eventos = new List<Evento>();

            string[] linhas = File.ReadAllLines(Path);

            foreach (var item in linhas)
            {
                
            }
        }
    }
}