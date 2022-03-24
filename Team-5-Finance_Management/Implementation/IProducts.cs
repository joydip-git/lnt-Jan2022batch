using Finance_Management.BusinessAccessLayer;
using System.Collections.Generic;

namespace Finance_Management.DataAccessLayer
{
    public interface IProducts
    {
         Products FetchbyId(int id);
        object FetchbyId();
    }
}
