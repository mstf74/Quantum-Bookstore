using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_Bookstore.Interfaces
{
    public interface IShipable
    {
        public void ShipToAddress(string email);
    }
}
