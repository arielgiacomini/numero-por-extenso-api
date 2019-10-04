using numero_por_extenso_api.Application.ViewModels;
using System.Collections.Generic;

namespace numero_por_extenso_api.Application
{
    public class NumeroPorExtenso
    {

        public string Numero { get; set; }
        public string Milhar { get; set; }
        public string Centena { get; set; }
        public string Dezena { get; set; }
        public string Unidade { get; set; }
        public string Extenso { get; set; }

        public IEnumerable<string> GetNumeroPorExtenso(string numero)
        {
            PorExtenso porExtenso = new PorExtenso();

            numero = numero.PadLeft(4, '0');

            // DECLARANDO A STRING ZERO

            string zero = "0000";
            if (numero == zero)
            {
                var extensoZero = "Zero";
                yield return extensoZero.ToString();
            }

            // ESCREVER POR EXTENSO MILHAR

            if (numero[0] != '0')
            {
                switch (numero[0])
                {
                    case '1': Milhar = "Um Mil"; break;
                    case '2': Milhar = "Dois Mil"; break;
                    case '3': Milhar = "Três Mil"; break;
                    case '4': Milhar = "Quatro Mil"; break;
                    case '5': Milhar = "Cinco Mil"; break;
                    case '6': Milhar = "Seis Mil"; break;
                    case '7': Milhar = "Sete Mil"; break;
                    case '8': Milhar = "Oito Mil"; break;
                    case '9': Milhar = "Nove Mil"; break;

                }
            }

            // ESCREVER POR EXTENSO CENTENA

            if (numero[1] != '0')
            {

                switch (numero[1])
                {
                    case '1': Centena = "Cento "; break;
                    case '2': Centena = "Duzentos "; break;
                    case '3': Centena = "Trezentos "; break;
                    case '4': Centena = "Quatrocentos "; break;
                    case '5': Centena = "Quinhentos "; break;
                    case '6': Centena = "Seiscentos "; break;
                    case '7': Centena = "Setecentos "; break;
                    case '8': Centena = "Oitocentos "; break;
                    case '9': Centena = "Novecentos "; break;

                }
                if (numero[1] == '1' && numero[2] == '0' && numero[3] == '0')
                {
                    Centena = "Cem";
                }

            }

            //ESCREVER POR EXTENSO DEZENA

            if (numero[2] == '1')
            {
                switch (numero.Substring(2))
                {
                    case "10": Dezena = "e Dez"; break;
                    case "11": Dezena = "e Onze"; break;
                    case "12": Dezena = " e Doze"; break;
                    case "13": Dezena = " e Treze"; break;
                    case "14": Dezena = " e Quatorze"; break;
                    case "15": Dezena = " e Quinze"; break;
                    case "16": Dezena = " e Dezesseis"; break;
                    case "17": Dezena = " e Dezessete"; break;
                    case "18": Dezena = " e Dezoito"; break;
                    case "19": Dezena = " e Dezenove"; break;
                }
            }
            else if (numero[2] != '0')
            {
                switch (numero[2])
                {
                    case '2': Dezena = "e Vinte "; break;
                    case '3': Dezena = "e Trinta "; break;
                    case '4': Dezena = "e Quarenta "; break;
                    case '5': Dezena = "e Cinquenta "; break;
                    case '6': Dezena = "e Secenta "; break;
                    case '7': Dezena = "e Setenta "; break;
                    case '8': Dezena = "e Oitenta "; break;
                    case '9': Dezena = "e Noventa "; break;
                }
            }

            //ESCREVER POR EXTENSO UNIDADE

            if (numero[3] != '0' && numero[2] != '1')
            {
                switch (numero[3])
                {
                    case '1': Unidade = "e Um"; break;
                    case '2': Unidade = "e Doiz"; break;
                    case '3': Unidade = "e Três"; break;
                    case '4': Unidade = "e Quatro"; break;
                    case '5': Unidade = "e Cinco"; break;
                    case '6': Unidade = "e Seis"; break;
                    case '7': Unidade = "e Sete"; break;
                    case '8': Unidade = "e Oito"; break;
                    case '9': Unidade = "e Nove"; break;
                }
            }

            // CRIAR EXTENSO
            var Extenso = Milhar + Centena + Dezena + Unidade;

            // COMANDO DE SAIDA

            if (Extenso[0] == 'e')
            {
                Extenso = Extenso.Substring(2);
            }

            yield return Extenso.ToString();

        }
    }
}
