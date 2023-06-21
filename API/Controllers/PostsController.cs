using Application.Posts;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers
{
    public class PostsController : BaseApiController
    {
        private readonly IMediator _mediator;
        private readonly DataContext _context;

        public PostsController(IMediator mediator, DataContext context)
        {
            _mediator = mediator;
            _context = context;
        }

        [HttpGet] //api/posts
        public async Task<ActionResult<List<Post>>> GetPosts()
        {
            return await _mediator.Send(new List.Query());
        }

        [HttpGet("{id}")] //api/posts/{guid}
        public async Task<ActionResult<Post>> GetPost(Guid id)
        {
            return await _context.Posts.FindAsync(id);
        }
    }
}
