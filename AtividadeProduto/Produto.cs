using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeProduto
{
    internal class Produto
    {
        //Atributos
        public string nome;
        public string descricao;
        public int quantidade;
        public double preço;
        public bool status;

        //Métodos
        public void mostra()
        {
            Console.WriteLine($"{nome}\n {descricao}\n {quantidade} unidades em estoque\n R$ {preço}\n Status: {status}\n");
        }

        public void desativa()
        {
            quantidade = 0;
            status = false;
        }
    }
}
