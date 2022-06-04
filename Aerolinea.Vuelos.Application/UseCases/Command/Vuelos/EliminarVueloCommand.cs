using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Vuelos.Application.Dto;
using MediatR;

namespace Aerolinea.Vuelos.Application.UseCases.Command.Vuelos
{
    public class EliminarVueloCommand : IRequest<ResulService>
    {
        private EliminarVueloCommand() { }

        public EliminarVueloCommand(VueloDeleteDto detalle)
        {
            Detalle = detalle;
        }

        public VueloDeleteDto Detalle { get; set; }

    
    }
}
