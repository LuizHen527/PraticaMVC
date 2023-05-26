using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PraticaAprendendoMVC.Model;

namespace PraticaAprendendoMVC.View
{
    public class EventoView
    {
        public Evento CadastrarEvento()
        {
            Evento e = new Evento();

            Console.WriteLine($"Digite a nome do evento:");
            e.Nome = Console.ReadLine();
            
            Console.WriteLine($"Digite a descricao do evento:");
            e.Descricao = Console.ReadLine();
            
            Console.WriteLine($"Digite quando o evento vai ocorrer:");
            e.DataEvento = Console.ReadLine();
            
            return e;
        }
    }
}