﻿using EasyCashIdentityProjectDtoLayer.Dtos.AppUserDtos;
using EasyCashIdentityProjectEntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    [Authorize]
    public class MyAccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private object appUserEditDto;

        public MyAccountController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUserEditDto appUserEditDto = new AppUserEditDto();
            appUserEditDto.Name = values.Name;
            appUserEditDto.Surname = values.Surname; 
            appUserEditDto.PhoneNumber = values.PhoneNumber;
            appUserEditDto.Email = values.Email;
            appUserEditDto.City = values.City;
            appUserEditDto.District = values.District;
            appUserEditDto.ImageUrl = values.ImageUrl;
            
            return View(appUserEditDto);
        }

     
        }
    }


