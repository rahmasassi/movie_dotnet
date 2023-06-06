using movie.Data;
using movie.Data.Static;
using movie.Data.ViewModels;
using movie.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AppDbContext _context;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

    //Retrive all users regardless of role
    public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }
        public IActionResult Login() => View(new LoginVM());
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid) return View(loginVM);

            var result = await _signInManager.PasswordSignInAsync(loginVM.EmailAddress, loginVM.Password, false, false);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(loginVM.EmailAddress);
                if (await _userManager.IsInRoleAsync(user, UserRoles.Admin))
                {
                    return RedirectToAction("Index", "Movies");
                }
                else
                {
                    return RedirectToAction("Index", "Movies");
                }
            }
            TempData["Error"] = "Wrong credentials. Please, try again!";
            return View(loginVM);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Movies");
        }
        
        public IActionResult AccessDenied(string ReturnUrl)
        {
            return View();
        }
        
        public IActionResult Register() => View(new RegisterVM());

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View(registerVM);

            // Check if user already exists
            var existingUser = await _userManager.FindByEmailAsync(registerVM.EmailAddress);
            if (existingUser != null)
            {
                ModelState.AddModelError(string.Empty, "A user with this email address already exists.");
                return View(registerVM);
            }

            // Add user to database
            var user = new ApplicationUser
            {
                FullName = registerVM.FullName,
                Email = registerVM.EmailAddress,
                UserName = registerVM.EmailAddress
            };

            // Assign role based on selection from form
            var result = await _userManager.CreateAsync(user, registerVM.Password);
            await _userManager.AddToRoleAsync(user, UserRoles.User);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Movies");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Creating user unsuccessful");
            }

            return View(registerVM);
        }


    }
}
