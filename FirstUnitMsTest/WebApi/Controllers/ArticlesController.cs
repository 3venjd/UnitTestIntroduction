using Domain.Service;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly ArticleService? _articlesService;

        public ArticlesController(ArticleService articlesService)
        {
            _articlesService = articlesService;
        }

        [HttpPost]
        [Route("Article")]
        public Article InsertArticle(string content, string title, int autor)
        {
            var result = _articlesService!.InsertArticle(content, title, autor);

            return result;
        }

        [HttpGet]
        [Route("Article/(id)")]
        public Article ConsultArticle(int id)
        {
            var result = _articlesService!.ConsultArticle(id);
            return result!;
        }
    }
}
