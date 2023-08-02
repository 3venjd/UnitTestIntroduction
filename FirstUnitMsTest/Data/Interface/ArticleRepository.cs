using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interface
{
    public class ArticleRepository : IArticleRepositoryInterface
    {
        public Article GetArticle(int id)
        {
            throw new NotImplementedException();
        }

        public int InsertArticle(string content, string title, int autorId)
        {
            throw new NotImplementedException();
        }
    }
}
