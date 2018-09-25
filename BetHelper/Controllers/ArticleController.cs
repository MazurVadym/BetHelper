using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BetHelper.Models;
using BetHelper.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BetHelper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpPost]
        public async Task Create(Article article)
        {
            await _articleService.Create(article);
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<Article>> Get()
        {
            return await _articleService.Get();
        }
    }
}