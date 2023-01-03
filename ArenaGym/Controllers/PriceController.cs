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
    public class PriceController : BaseApiController
    {
        private readonly IRepository<Price> priceRepository;
        private readonly IMapper mapper;
        public PriceController(IRepository<Price> priceRepository, IMapper mapper)
        {
            this.priceRepository = priceRepository;
            this.mapper = mapper;
        }


        [HttpPost("createPrice")]
        public async Task<ActionResult<Price>> CreatePrice(PriceDTO priceDTO)
        {
            var price = mapper.Map<PriceDTO, Price>(priceDTO);
            var createdPrice = await priceRepository.AddAsync(price);
            return Ok(createdPrice);
        }


        [HttpGet("getPrice")]
        public async Task<Price> GetPriceyAsync()
        {
            var x = await priceRepository.ListAllAsync();
            return x.First();
        }


        [HttpPost("updatePrice")]
        public async Task<ActionResult<Price>> UpdatePriceAsync(Price price)
        {
            var updated = await priceRepository.UpdateAsync(price);
            return Ok(updated);
        }


    }
}
