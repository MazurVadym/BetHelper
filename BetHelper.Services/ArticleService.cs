using BetHelper.DAL;
using BetHelper.Models;
using BetHelper.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetHelper.Services
{
    public class ArticleService : IArticleService
    {
        private readonly BetHelperContext _context;

        public ArticleService(BetHelperContext context)
        {
            _context = context;
        }

        public async Task<Article> GetById(int id)
        {
            return _context.Articles.FirstOrDefault(x => x.Id == id);
        }

        public async Task<IEnumerable<Article>> Get()
        {
            return _context.Articles;
        }

        public async Task Create(Article article)
        {
            _context.Articles.Add(article);

            await _context.SaveChangesAsync();
        }

    }
}
