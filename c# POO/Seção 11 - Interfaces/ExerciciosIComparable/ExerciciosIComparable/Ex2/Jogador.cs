using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosIComparable.Ex2
{
    sealed class Jogador : IComparable
    {
        

        public string NickName { get; set; }

        public int Pontucao { get; set; }

        public double TempoDeFase { get; set; }

        public Jogador(string name,int pontuacao,double tempo)
        {
            NickName = name;
            Pontucao = pontuacao;
            TempoDeFase = tempo;
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Jogador)) { throw new ArgumentException("O objeto deve ser um jogador"); }
            Jogador jogador = (Jogador)obj;

            if (Pontucao == jogador.Pontucao) { return TempoDeFase.CompareTo(jogador.TempoDeFase); }
            else { return jogador.Pontucao.CompareTo(Pontucao); }
        }
        public override string ToString()
        {
            return $"Jogador : {NickName}, pontuação: {Pontucao}, tempo: {TempoDeFase.ToString("F2", CultureInfo.InvariantCulture)} min";
        }
    }
}
