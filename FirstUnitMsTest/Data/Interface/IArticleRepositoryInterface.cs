using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interface
{
    public interface IArticleRepositoryInterface
    {
        int InsertArticle(string content, string title, int autorId);
        Article GetArticle(int id);
    }
}
