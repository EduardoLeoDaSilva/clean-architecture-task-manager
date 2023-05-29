using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Domain.Entities
{
    public class User : Entity
    {

        public string Name { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string CellPhone { get; private set; }
        public string Document { get; private set; }




        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
