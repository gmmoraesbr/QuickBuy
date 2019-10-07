using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Entidades.Dominio
{
    public abstract class Entidade
    {
        public List<string> _mensagemValidacao { get; set; }

        public List<string> MensagemValidacao
        {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }
        }

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();

        protected bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        } 
    }
}
