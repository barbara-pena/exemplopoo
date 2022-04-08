using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO
{
    public class Professor : Pessoa
    {
        private string rp;
        private string formacao;

        public Professor()
        {
            this.nome = "";
            this.rg = "";
            this.cpf = "";
            this.email = "";
            this.rp = "";
            this.formacao = "";
        }

        public Professor (string _rp, string _formacao, string _nome, string _rg, string _cpf, string _email)
        {
            this.rp = _rp;
            this.formacao = _formacao;
            this.nome = _nome;
            this.rg = _rg;
            this.cpf = _cpf;
            this.email = _email;
        }

        //getter setters
        public string RP
        {
            get { return this.rp; }
            set { this.rp = value; }
        }

        public string FORMACAO
        {
            get { return this.formacao; }
            set { this.formacao = value; }
        }
    }
}


