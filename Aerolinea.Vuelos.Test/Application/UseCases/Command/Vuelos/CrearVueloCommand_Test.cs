using Aerolinea.Vuelos.Application.UseCases.Command.Vuelos;
using Aerolinea.Vuelos.Test.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Aerolinea.Vuelos.Test.Application.UseCases.Command.Vuelos
{
    public class CrearVueloHandler_Test
    {
        [Fact]
        public void IsRequest_Valid()
        {
            var detalle = MockFactory.GetVuelo();
            var command = new CrearVuelosCommand(detalle);

            Assert.NotNull(command.Detalle);
           // Assert.NotNull($"{command.Detalle} no es valido el dto request");
        }

        [Fact]
        public void TestConstructor_IsPrivate()
        {
            var command = (CrearVuelosCommand)Activator.CreateInstance(typeof(CrearVuelosCommand), true);
            Assert.Null(command.Detalle);
        }
    }
}
