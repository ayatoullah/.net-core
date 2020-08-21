using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab3.Models.repository
{
    public class PostRepository:IPostRepository
    {
        plogDbContext db;
        public PostRepository(plogDbContext _db)
        {
            db = _db;

        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAll()
        {
            return db.Posts.ToList();
        }

        

        Post IPostRepository.getByID(int id)
        {
            return db.Posts.Find(id);
        }
    }
}
