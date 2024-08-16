﻿using AutoMapper;
using DataAcess.Repo;
using DataAcess.Repo.IRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Models.DTOs.AppUsers;
using Models.MyModels.App;
using Models.MyModels.ProfileModels;
using Models.Response;
using System.Net;
using System.Security.Claims;

namespace TwitterClone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProfileController : ControllerBase
    {
        private readonly IUnitOfWork db;
        private readonly IMapper mapper;
        public ProfileController(IUnitOfWork db , IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        [HttpGet("myProfile")]
        public async Task<IActionResult> GetMyProfile()
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = new APIResponse();
            var userProfile = await db.User.GetAsync(x => x.Id == id, includes: "Posts");

            if (userProfile == null)
            {
                response.SetResponseInfo(HttpStatusCode.Unauthorized, new List<string> { "Unauthorized" }, null, false);
                return Unauthorized(response);
            }
            ApplicationUserDTO userProfileDTO = new ApplicationUserDTO();
            userProfileDTO = mapper.Map<ApplicationUserDTO>(userProfile);

            response.SetResponseInfo(HttpStatusCode.OK, null, userProfileDTO,true);
            return Ok(response);
        }


        //======================> get profile of anthor user


        [HttpGet("searchProfile")]
        public async Task<IActionResult> GetProfileForanotherUser(string userName)
        {
            var myProfileId = User?.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = new APIResponse();

            var myprofile = await db.User.GetAsync(x => x.Id == myProfileId );
            if (userName == myprofile.UserName)
            {
                response.SetResponseInfo(HttpStatusCode.NotFound, new List<string> { "you cant search your profile" }, null, false);
                return Unauthorized(response);
            }
            var searcedProfile = await db.User.GetAsync(x=>x.UserName == userName, includes: "Posts");
            if (searcedProfile == null)
            {
                response.SetResponseInfo(HttpStatusCode.NotFound, new List<string> { "No User" }, null, false);
                return Unauthorized(response);
            }
            var userSearchedProfileDTO = mapper.Map<ApplicationUserDTO>(searcedProfile);

            response.SetResponseInfo(HttpStatusCode.Found, new List<string> { }, userSearchedProfileDTO, true);
            return Ok(response);



        }









            //[HttpGet()]
            //public async Task<IActionResult> GetAllUserProfile()
            //{
            //    var response = new APIResponse();
            //    var userProfileList = await db.User.GetAllAsync();

            //    if (userProfileList == null || !userProfileList.Any())
            //    {
            //        response.SetResponseInfo(HttpStatusCode.NotFound, new List<string> { "No Users" }, null, false);
            //        return NotFound(response);
            //    }

            //    var userProfileForGetAllUsersDTOList = mapper.Map<List<UserProfileForGetAllUsersDTO>>(userProfileList);

            //    response.SetResponseInfo(HttpStatusCode.OK, null, userProfileForGetAllUsersDTOList);
            //    return Ok(response);
            //}


            //[HttpPut("{userName}")]
            //public async Task<IActionResult> UpdateUserData(string userName, [FromBody] UserProfileDTO userProfileDTO)
            //{
            //    var response = new APIResponse();

            //    var userProfile = await db.Profile.GetAsync(x => x.UserName == userName);
            //    if (userProfile == null)
            //    {
            //        response.SetResponseInfo(HttpStatusCode.NotFound, new List<string> { "No user with this UserName" }, null, false);
            //        return NotFound(response);
            //    }

            //    mapper.Map(userProfileDTO, userProfile);

            //    await db.SaveAsync();


            //    response.SetResponseInfo(HttpStatusCode.OK, null, userProfileDTO, true);
            //    return Ok(response);
            //}


            //[HttpDelete]
            //public async Task<IActionResult> DeleteUser(string userName)
            //{
            //    var response = new APIResponse();
            //    var userProfile = await db.User.GetAsync(x => x.UserName == userName);
            //    if (userProfile == null)
            //    {
            //        response.SetResponseInfo(HttpStatusCode.NotFound, new List<string> { "No user With this UserName" }, null, false);
            //        return BadRequest(response);
            //    }
            //    await db.Profile.DeleteAsync(userProfile);
            //    await db.SaveAsync();

            //    response.SetResponseInfo(HttpStatusCode.OK, new List<string> { }, userProfile, true);
            //    return Ok(response);

            //}




        }
}
