﻿using Domain;
using MediatR;
using Persistence;

namespace Application.Posts
{
    public class Create
    {
        public class Command : IRequest<Unit>
        {
            public Post Post { get; set; }
        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Posts.Add(request.Post);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
