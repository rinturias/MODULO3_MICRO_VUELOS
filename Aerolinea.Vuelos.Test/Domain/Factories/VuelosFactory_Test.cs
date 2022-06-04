using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Vuelos.Domain.Factories;
using Xunit;

namespace Aerolinea.Vuelos.Test.Domain.Factories
{
    public class VuelosFactory_Test
    {
        [Fact]
        public void Create_Correctly()
        { 
         DateTime horaSalida = DateTime.Now;
         DateTime horaLLegada = DateTime.Now;
         string estado = "A";
         decimal precio = new decimal(40.0);
         int StockAsientos = 10;
         DateTime fecha = new DateTime(2022, 01, 01);
         Guid codDestino = Guid.NewGuid();
         Guid codOrigen = Guid.NewGuid();
         Guid codAeronave = Guid.NewGuid();
         int activo = 0;

        var factory = new VuelosFactory();
        var vuelo = factory.Create(horaSalida, horaLLegada, estado, precio, fecha, codDestino, codOrigen, codAeronave, activo, StockAsientos);

            Assert.NotNull(vuelo);
            Assert.Equal(StockAsientos,(decimal) vuelo.stockAsientos);
            Assert.Equal(precio, (decimal)vuelo.precio);
            Assert.Equal(codDestino, vuelo.codDestino);
            Assert.Equal(codOrigen,vuelo.codOrigen);
            Assert.Equal(estado, vuelo.estado);
        }
    }
}
