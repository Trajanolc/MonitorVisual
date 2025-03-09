using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualMecFlu.Models;

namespace VisualMecFlu.Interfaces
{
    interface IEquipamentoMedicao
    {
        public List<VazaoTempo> CalculoArray()
        {
            return new List<VazaoTempo>();
        }

        public double CalculoPontual(double P1, double P2)
        {
            return 0;
        }
    }
}
