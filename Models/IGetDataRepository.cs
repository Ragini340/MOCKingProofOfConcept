using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOCKingProofOfConcept.Models
{
   public interface IGetDataRepository
    {
        string GetNameById(int id);
    }
}
