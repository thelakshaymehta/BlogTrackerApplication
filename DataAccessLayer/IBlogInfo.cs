using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface IBlogInfo
    {
        IEnumerable<BlogInfo> GetAllBlogInfo();
        void Insert(BlogInfo blogInfo);
        void Delete(int id);
        void Update(BlogInfo blogInfo);
        void Save();
        BlogInfo GetBlogId(int id);

    }
}
