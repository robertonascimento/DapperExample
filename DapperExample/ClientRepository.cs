using System.Collections.Generic;

namespace DapperExample
{
    public class ClientRepository : SqlRepositoryBase
    {
        public IEnumerable<Client> Get(ClientCriteria criteria) => Query<Client>(criteria);
        
    }
}
