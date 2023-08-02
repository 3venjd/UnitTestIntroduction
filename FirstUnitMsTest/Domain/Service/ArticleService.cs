using Data.Interface;
using Data.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class ArticleService
    {
        private readonly IAutorRepositoryInterface? _autorRepository;
        private readonly IArticleRepositoryInterface? _articleRepository;

        public ArticleService(IArticleRepositoryInterface articleRepositoryInterface,
                              IAutorRepositoryInterface autorRepositoryInterface  )
        {
            _articleRepository = articleRepositoryInterface;
            _autorRepository = autorRepositoryInterface;
        }

        public Article InsertArticle(string content, string title, int autorId)
        {
            if (!_autorRepository!.ValidAutor(autorId))
            {
                throw new Exception("Autor not valid");
            }

            var articleId = _articleRepository!.InsertArticle(content, title, autorId);

            return ConsultArticle(articleId);

        }

        public Article ConsultArticle(int id)
        {
            return _articleRepository!.GetArticle(id);
        }

    }
}
