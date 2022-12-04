using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOCKingProofOfConcept.Models
{
    public class EmployeeRepository : IGetDataRepository
    {
        public string GetNameById(int id)
        {
            string name;
            if (id == 1)
            {
                name = "Ragini";
            }
            else if (id == 2)
            {
                name = "Ragini Singh";
            }
            else
            {
                name = "Not Found";
            }
            return name;
        }
    }
}


