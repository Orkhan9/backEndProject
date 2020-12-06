using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiorelloFrontToBack.Models;
using FiorelloFrontToBack.Service;
using FiorelloFrontToBack.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloFrontToBack.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View();


            var user = await _userManager.FindByNameAsync(login.Email);
            if (user != null)
            {

                if (!await _userManager.IsEmailConfirmedAsync(user))
                {
                    ModelState.AddModelError(string.Empty, "emailinizi tesdiq etmemisiniz");
                    return View(login);
                }
            }

            AppUser loginUser = await _userManager.FindByEmailAsync(login.Email);
            if (loginUser == null)
            {
                ModelState.AddModelError("", "Email or password is wrong!");
                return View(login);
            }

            if (loginUser.Status)
            {
                ModelState.AddModelError("", "Email is blocked");
                return View(login);
            }

            var signInResult = await _signInManager.PasswordSignInAsync(loginUser, login.Password, login.Ischecked, true);
            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError("", "The account is locked out for 10 minutes");
                return View(login);
            }
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or password is wrong!");
                return View(login);
            }

            //string role = (await _userManager.GetRolesAsync(loginUser))[0];
            //if (role == "Admin")
            //{
            //    return RedirectToAction("Index", "Dashboard", new { area = "AdminF" });
            //}


            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return NotFound();
            AppUser newUser = new AppUser
            {
                FullName = register.FullName,
                UserName = register.UserName,
                Email = register.Email,
                //Status=true
            };

            IdentityResult identityResult = await _userManager.CreateAsync(newUser, register.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }

            await _userManager.AddToRoleAsync(newUser, "Member");


            var code = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
            var href = Url.Action("ConfirmEmail", "Account", new { userId = newUser.Id, code = code }, protocol: Request.Scheme);
            EmailService emailService = new EmailService();
            await emailService.SendEmailAsync(newUser.Email,
            "Confirm your Account", $"Qeydiyyati tamamlamaq ucun linkden kecid edin <a href='{href}'>click link</a>");

            await _signInManager.SignInAsync(newUser, true);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Error");
            }
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
                return RedirectToAction("Index", "Home");
            else
                return View("Error");
        }

        public async Task CreateRole()
        {
            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
            }

            if (!await _roleManager.RoleExistsAsync("Member"))
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = "Member" });
            }
        }
    }
}
