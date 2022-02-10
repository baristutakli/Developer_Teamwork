using System.Collections.Generic;

namespace DbPractices.DataAccess.Dapper.Abstract
{
    public interface IDpRepostioryBase<T>
   {
       List<T> GetAll();
       T Get(int id);
   }
}
