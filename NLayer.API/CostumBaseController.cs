using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;

namespace NLayer.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostumBaseController : ControllerBase
    {

        [NonAction]// no endpoint
        public IActionResult CreateActionResult<T>( CostumResponseDto<T> responseDto )
        {
            if (responseDto.StatusCode == 204)
            {
                return new ObjectResult(null)
                {
                    StatusCode = responseDto.StatusCode
                };
            }
            return new ObjectResult(responseDto)
            {
                StatusCode = responseDto.StatusCode
            };

        }
    }
}
