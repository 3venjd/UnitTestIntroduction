using Data.Interface;
using Data.Interfaces;
using Domain.Service;
using DTO;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MsTest1
{
    [TestClass]
    public class MockTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string content = "content1";
            string title = "title1";
            int autorId = 1;

            Mock<IArticleRepositoryInterface> articleRepository = new Mock<IArticleRepositoryInterface>();
            Mock<IAutorRepositoryInterface> autorRepository = new Mock<IAutorRepositoryInterface>();

            autorRepository.Setup(a => a.ValidAutor(autorId)).Returns(true);
            //use It
            //autorRepository.Setup(a => a.ValidAutor(It.IsAny<int>())).Returns(true);
            articleRepository.Setup(a => a.InsertArticle(content, title, autorId)).Returns(1);
            articleRepository.Setup(a => a.GetArticle(1)).Returns(new Article()
            {
                AutorId = new Autor() 
                {
                    Id = autorId,
                    Name = "Autor 1",
                },
                Content = content,
                Date = DateTime.Now,
                Id = 1,
                Title = title,
            }); 


            ArticleService service = new ArticleService(articleRepository.Object, autorRepository.Object);

            

            var article = service.InsertArticle(content,title,autorId);

            Assert.AreEqual(autorId, article.AutorId?.Id);

            //autorRepository.Verify(a => a.ValidAutor(1));

            autorRepository.Verify(a => a.ValidAutor(autorId));
            articleRepository.Verify(a => a.InsertArticle(content, title, autorId));
            articleRepository.Verify(a => a.GetArticle(1));
            
        }
    }
}
