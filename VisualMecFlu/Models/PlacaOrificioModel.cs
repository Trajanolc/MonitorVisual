using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualMecFlu.Interfaces;

namespace VisualMecFlu.Models
{
    public class PlacaOrificioModel : IEquipamentoMedicao
    {


        //Diametro Menor
        public double D2 { get; set; } = 1;


        //Area Menor
        public double A2 { get; set; } = 1;
        public double DensidadeLiquido { get; set; } = 1;

        public double CoeficienteEscoamento { get; set; } = 1;

        public List<CargaDados> CargaDados { get; set; } = new List<CargaDados>();

        public PlacaOrificioModel() { }

        public void CalcularAreas()
        {
            A2 = Math.Pow(D2 / 2 / 100, 2) * Math.PI;
        }

        public double CalculoPontual(double P1, double P2)
        {
            double DeltaP = P1 - P2;

            return CoeficienteEscoamento * A2 * Math.Sqrt((2 * DeltaP) / DensidadeLiquido);
        }

        public List<VazaoTempo> CalculoArray()
        {

            var vazaoTempo = new List<VazaoTempo>();

            foreach (var dado in CargaDados)
            {
                var vazao = CoeficienteEscoamento * A2 * Math.Sqrt((2 * (dado.P1 - dado.P2)) / DensidadeLiquido);

                vazaoTempo.Add(new VazaoTempo()
                {
                    Vazao = vazao,
                    Tempo = dado.Id
                });
            }

            return vazaoTempo;

        }
    }
}
