using Mediator_Example.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediator_Example.Application.Articles.Queries
{
    public class GetArticleQuery : IRequest<Article>
    {
        public int Id { get; set; }
    }
}