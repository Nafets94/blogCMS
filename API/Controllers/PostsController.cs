using Application.Posts;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PostsController : BaseApiController
    {
        [HttpGet] //api/posts
        public async Task<ActionResult<List<Post>>> GetPosts()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")] //api/posts/{guid}
        public async Task<ActionResult<Post>> GetPost(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost([FromBody]Post post)
        {
            return Ok(await Mediator.Send(new Create.Command { Post = post }));
        }
    }
}
