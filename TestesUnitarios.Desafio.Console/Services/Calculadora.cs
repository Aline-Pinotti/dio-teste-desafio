using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestesUnitarios.Desafio.Console.Services
{
    public class Calculadora
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        private List<String> _historico;
        public Calculadora()
        {
            _historico = new List<string>();
        }

        private void RegistrarHistorico(string operacao)
        {
            _historico.Insert(0, operacao);
            if (_historico.Count > 3) _historico.RemoveRange(3, _historico.Count - 3);
        }

        public int Somar(int num1, int num2)
        {
            var soma = num1 + num2;
            RegistrarHistorico($"Soma entre {num1} e {num2} = {soma}");
            return soma;
        }
        public int Subtrair(int num1, int num2)
        {
            var subtracao = num1 - num2;
            RegistrarHistorico($"Subtração entre {num1} e {num2} = {subtracao}");
            return subtracao;
        }
        public int Multiplicar(int num1, int num2)
        {
            var produto = num1 * num2;
            RegistrarHistorico($"Multiplicação entre {num1} e {num2} = {produto}");
            return produto;
        }
        public int Dividir(int num1, int num2)
        {
            var divisao = num1 / num2;
            RegistrarHistorico($"Divisão entre {num1} e {num2} = {divisao}");
            return divisao;
        }
        public List<String> RetornarHistorico()
        {
            return _historico;
        }
    }
}