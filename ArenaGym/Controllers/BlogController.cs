using ArenaGym.DTOS;
using AutoMapper;
using BLL.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArenaGym.Controllers
{
    public class BlogController : BaseApiController
    {
        private readonly IRepository<Blog> blogRepository;
        private readonly IMapper mapper;
        public BlogController(IRepository<Blog> blogRepository, IMapper mapper)
        {
            this.blogRepository = blogRepository;
            this.mapper = mapper;
        }

        [HttpGet("getAllBlog")]
        public async Task<IReadOnlyList<Blog>> GetBlogs()
        {
            return await blogRepository.ListAllAsync();
        }


        [HttpGet("{id}")]
        public async Task<Blog> GetBlogAsync(int id)
        {
            return await blogRepository.GetByIdAsync(id);
        }


        [HttpPost("createBlog")]
        public async Task<ActionResult<Blog>> CreateBlog(BlogDTO blogDTO)
        {
            var blog = mapper.Map<BlogDTO, Blog>(blogDTO);
            var createdBlog = await blogRepository.AddAsync(blog);
            return Ok(createdBlog);
        }


        [HttpPost("updateBlog")]
        public async Task<ActionResult<Blog>> UpdateBasket(Blog blog)
        {
            var updated = await blogRepository.UpdateAsync(blog);
            return Ok(updated);
        }

        [HttpDelete]
        public async Task DeleteBlogAsync(int id)
        {
            await blogRepository.DeleteAsync(id);
        }
    }
}
