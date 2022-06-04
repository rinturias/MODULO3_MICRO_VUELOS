using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Vuelos.Application.UseCases.Queries.Vuelos.SearchVuelos;
using Xunit;

namespace Aerolinea.Vuelos.Test.Application.UseCases.Queries.Vuelos.SearchVuelos
{
    public class SearchListVuelosQuery_Test
    {
    

        [Fact]
        public void TestConstructor_IsPrivate()
        {
            var command = (SearchListVuelosQuery)Activator.CreateInstance(typeof(SearchListVuelosQuery), true);
            Assert.NotNull(command);
        }
    }
}
