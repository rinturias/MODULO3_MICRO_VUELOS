using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Vuelos.Application.Dto;
using Xunit;

namespace Aerolinea.Vuelos.Test.Application.Dto
{
    public class PlanillaAsientosVueloDto_Test
    {

        [Fact]
        public void RequestVueloDto_CheckPropertiesValid()
        {
            Guid codPlanillaAsiento = Guid.NewGuid();
            string asiento = "ASI10";
            string estado = "A";

            PlanillaAsientosVueloDto planillaAsientosVueloDto = new();

            Assert.Equal(Guid.Empty, planillaAsientosVueloDto.codPlanillaAsiento);
            Assert.Null( planillaAsientosVueloDto.asiento);
            Assert.Null(planillaAsientosVueloDto.estado);
  

         
            planillaAsientosVueloDto.codPlanillaAsiento = codPlanillaAsiento;
            planillaAsientosVueloDto.asiento = asiento;
            planillaAsientosVueloDto.estado = estado;


            Assert.Equal(codPlanillaAsiento, planillaAsientosVueloDto.codPlanillaAsiento);
            Assert.Equal(asiento, planillaAsientosVueloDto.asiento);
            Assert.Equal(estado, planillaAsientosVueloDto.estado);
        }
    }
}
