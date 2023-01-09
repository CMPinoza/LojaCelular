using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaCelular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular cel = new Celular();
            cel.Id = 10;
            cel.Aparelho = "Iphone";
            cel.Modelo = 11;
            cel.Marca = "Apple";
            cel.Cor = "Verde";
            cel.Imei = 654321;

            var resposta = obterdadoscel(cel);

            Console.WriteLine(resposta);
            Console.ReadKey();

        }

        public static Celular obterdadoscel(Celular cel)
        {
            var loja = new Celular();
            loja.Id = cel.Id;
            loja.Aparelho = cel.Aparelho;
            loja.Modelo = cel.Modelo;
            loja.Marca = cel.Marca;
            loja.Cor = cel.Cor  ;
            loja.Imei = cel.Imei;

            return loja;

        }

    }

}
