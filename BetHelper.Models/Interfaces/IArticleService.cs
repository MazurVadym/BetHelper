using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BetHelper.Models.Interfaces
{
    public interface IArticleService
    {
        Task<Article> GetById(int id);

        Task<IEnumerable<Article>> Get();

        Task Create(Article article);
    }
}
