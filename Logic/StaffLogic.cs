using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Gen_App.Entities;
namespace CS_Gen_App.Logic
{
    public interface StaffLogic<TEntity, in TPk> where TEntity : Staff
    {
        Dictionary<int,TEntity> GetAll();
        void Get(TPk id);
        void Create();
        void Update(TPk id);
        void Delete(TPk id);

        
    }
}
