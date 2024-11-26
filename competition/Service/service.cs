using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using competition.Model;

namespace competition.Service
{
    internal class service
    {
        public List<compite> compites;
        public service()
        {
            compites = new List<compite>();
        }
        public compite AddEvent(compite compite)
        {
            compite.Id = Guid.NewGuid();
            compites.Add(compite);

            return compite;
        }
        public compite GetCarById(Guid compiteId)
        {
            foreach (var copmite in compites)
            {
                if (copmite.Id == compiteId)
                {
                    return copmite;
                }
            }

            return null;
        }
        public compite GetEventsByLocation(compite location)
        {
            

        }
    }
}
