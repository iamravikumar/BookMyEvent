﻿using AutoMapper;
using BookMyEvent.Services.Discount.DTOs;
using BookMyEvent.Services.Discount.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BookMyEvent.Services.Discount.Controllers
{
    [ApiController]
    [Route("api/discount")]
    public class DiscountController : Controller
    {
        private readonly ICouponRepository _couponRepository;
        private readonly IMapper _mapper;

        public DiscountController(ICouponRepository couponRepository, IMapper mapper)
        {
            _couponRepository = couponRepository;
            _mapper = mapper;
        }

        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpGet("code/{code}")]
        public async Task<IActionResult> GetDiscountForCode(string code)
        {
            var coupon = await _couponRepository.GetCouponByCode(code);

            if (coupon == null)
                return NotFound();

            return Ok(_mapper.Map<CouponDTO>(coupon));
        }

        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpGet("{couponId}")]
        public async Task<IActionResult> GetDiscountForCode(Guid couponId)
        {
            var coupon = await _couponRepository.GetCouponById(couponId);

            if (coupon == null)
                return NotFound();

            return Ok(_mapper.Map<CouponDTO>(coupon));
        }

        [HttpPut("use/{couponId}")]
        public async Task<IActionResult> UseCoupon(Guid couponId)
        {
            await _couponRepository.UseCoupon(couponId);
            return Ok();
        }

        //Used for testing resiliency
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpGet("error/{couponId}")]
        public async Task<IActionResult> GetDiscountForCode2(Guid couponId)
        {

            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
        }
    }
}