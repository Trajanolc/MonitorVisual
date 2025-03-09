using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualMecFlu.Models
{
    internal class VenturiModel
    {

        //Diametro Maior
        public double D1 { get; set; } = 1;

        //Diametro Menor
        public double D2 { get; set; } = 1;

        //Area Maior
        public double A1 { get; set; } = 1;

        //Area Menor
        public double A2 { get; set; } = 1;
        public double DensidadeLiquido { get; set; } = 1;

        public double CoeficienteDescarga { get; set; } = 1;

        public List<CargaDados> CargaDados { get; set; } = new List<CargaDados>();
        
        public VenturiModel() { }

        //Gera as áreas convertando o diametro de cm para m
        public void CalcularAreas()
        {
            A1 = Math.Pow(D1/2/100,2) * Math.PI;
            A2 = Math.Pow(D2/2/100,2) * Math.PI;
        }

        public double CoeficienteDeEscoamento()
        {
            //Proporcao entre as areas beta elevado a quarta
            var B4 = Math.Pow((A2 / A1), 2);

            return CoeficienteDescarga / Math.Sqrt(1 - B4);
        }

        public double CalculoPontual(double P1, double P2)
        {
            double DeltaP = P1 - P2;

            double escoamento = CoeficienteDeEscoamento();

            return escoamento*A2*Math.Sqrt((2*DeltaP)/DensidadeLiquido);    
        }

        public List<VazaoTempo> CalculoArray()
        {

            double escoamento = CoeficienteDeEscoamento();

            var vazaoTempo = new List<VazaoTempo>();

            foreach(var dado in CargaDados)
            {
                var vazao = escoamento * A2 * Math.Sqrt((2 * (dado.P1-dado.P2)) / DensidadeLiquido);

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
