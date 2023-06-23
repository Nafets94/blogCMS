using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Posts
{
    public class Delete
    {
        public class Command : IRequest<Unit>
        {
            public Guid Id { get; set; }
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
                var account = await _context.Posts.FirstOrDefaultAsync(x => x.Id == request.Id);

                _context.Posts.Remove(account);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
