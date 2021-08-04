using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Citizen:IEntity
    {
        public string CitizenId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int BirhYear { get; set; }
    }
}
