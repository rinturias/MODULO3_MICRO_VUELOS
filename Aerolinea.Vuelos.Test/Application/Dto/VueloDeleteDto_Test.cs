using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Vuelos.Application.Dto;
using Xunit;

namespace Aerolinea.Vuelos.Test.Application.Dto
{
    public class VueloDeleteDto_Test
    {
        [Fact]
        public void VueloDeleteDto_CheckPropertiesValid()
        {
            var codVueloTest = Guid.NewGuid();
            var objVuelo = new VueloDeleteDto();

            Assert.Equal(Guid.Empty, objVuelo.codVuelo);
        }
    }
}
