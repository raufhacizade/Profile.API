using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Profile.API.Base.ViewModels;
using Profile.API.Models;
using Profile.API.ViewModels;
using Profile.Base.Controllers;
using Profile.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Profile.API.Controllers
{
  [Route("api/users")]
  [ApiController]
  public class UserController : BaseController
  {
    private readonly IUserService _userService;
    private readonly IValidator<UserCreateModel> _userCreateModelValidator;
    private readonly IValidator<UserModel> _userUpdateModelValidator;
    public UserController(
      IMapper mapper,
      ILogger<UserController> logger,
      IUserService userService,
      IValidator<UserCreateModel> userCreateModelValidator,
      IValidator<UserModel> userUpdateModelValidator) : base(mapper, logger)
    {
      _userService = userService;
      _userCreateModelValidator = userCreateModelValidator;
      _userUpdateModelValidator = userUpdateModelValidator;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UserModel>> Get(int id)
    {
      var userEntity = await _userService.Get(id);
      if (userEntity == null || userEntity.IsDeleted)
      {
        return NotFound();
      }
      var result = _mapper.Map<UserModel>(userEntity);
      return result;
    }

    [HttpGet()]
    public async Task<IEnumerable<UserModel>> GetList()
    {
      var result = _mapper.Map<IEnumerable<UserModel>>(await _userService.GetList(u => !u.IsDeleted));
      return result;
    }

    [HttpGet("{offset}:{limit}")]
    public async Task<BasePaginatedViewModel<UserModel>> GetList(int offset, int limit)
    {
      var result = _mapper.Map<BasePaginatedViewModel<UserModel>>(await _userService.GetPaginatedList(offset: offset, limit: limit, u => !u.IsDeleted));
      return result;
    }

    [HttpPost]
    public async Task<ActionResult<int>> Create(UserCreateModel user)
    {
      var validationResult = await _userCreateModelValidator.ValidateAsync(user);
      if (!validationResult.IsValid)
      {
        return BadRequest(validationResult.ToDictionary());
      }
      return await _userService.Create(_mapper.Map<User>(user));
    }

    [HttpPut]
    public async Task<ActionResult> Update(UserModel user)
    {
      var validationResult = await _userUpdateModelValidator.ValidateAsync(user);
      if (!validationResult.IsValid)
      {
        return BadRequest(validationResult.ToDictionary());
      }

      var userEntity = await _userService.Get(user.Id);
      if (userEntity == null || userEntity.IsDeleted)
      {
        return NotFound();
      }
      _mapper.Map(user, userEntity);

      await _userService.Update(userEntity);
      return Ok();
    }

    [HttpDelete]
    public async Task<ActionResult> Delete(int id)
    {
      var userEntity = await _userService.Get(id);
      if (userEntity == null || userEntity.IsDeleted)
      {
        return NotFound();
      }
      await _userService.Delete(userEntity);
      return Ok();
    }
  }
}
