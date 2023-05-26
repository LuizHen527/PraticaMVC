using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PraticaAprendendoMVC.View;
using PraticaAprendendoMVC.Model;

namespace PraticaAprendendoMVC.Control
{
    public class ControlEvento
    {
        EventoView view = new EventoView();
        Evento model = new Evento();
        public void Cadastrar()
        {
            Evento e = view.CadastrarEvento();
            
            model.SalvarCadastro(e);
        }
    }
}