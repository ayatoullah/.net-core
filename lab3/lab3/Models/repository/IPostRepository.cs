using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3.Models.repository
{
    public interface IPostRepository
    {
        

        List<Post> GetAll();

        Post getByID(int id);


        void Create();
        void Edit(int id);
    
        void Delete(int id);
        
    }
}
