using Mediator_Example.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator_Example.Application.Articles.Queries
{
    public class GetArticleHandler : IRequestHandler<GetArticleQuery, Article>
    {
        private MediatRContext _db;

        public GetArticleHandler(MediatRContext db) => _db = db;

        public Task<Article> Handle(GetArticleQuery request, CancellationToken cancellationToken)
        {
            return this._db.Articles.SingleOrDefaultAsync(f => f.Id == request.Id);
        }
    }
}