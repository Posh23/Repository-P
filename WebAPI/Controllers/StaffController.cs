using Application.Services;
using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StaffController : Controller
    {
        private readonly IBaseService<Staff> _StaffService;
        private readonly IMapper _mapper;

        public StaffController(IBaseService<Staff> StaffService, IMapper mapper)
        {
            _StaffService = StaffService;
            _mapper = mapper;
        }


        [HttpPost(ApiEndpoints.Method.Create)]
        public async Task<IActionResult> Create([FromBody] CreateStaffRequest request, CancellationToken token)
        {
            var Staff = _mapper.Map<Staff>(request);

            var response = await _StaffService.CreateAsync(Staff, token);
            return CreatedAtAction(nameof(Create), new { id = response.Id }, response);
        }
        [HttpGet(ApiEndpoints.Method.Get)]
        public async Task<IActionResult> Get(Guid id, CancellationToken token)
        {
            var StaffExist = await _StaffService.GetAsync(id);

            if (StaffExist == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<SingleStaffResponse>(StaffExist);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpGet(ApiEndpoints.Method.GetAll)]
        public async Task<IActionResult> GetAll(CancellationToken token)
        {
            var Staff = await _StaffService.GetAllAsync(token);

            var response = new GetAllStaffResponse()
            {
                Items = _mapper.Map<IEnumerable<SingleStaffResponse>>(Staff)
            };

            return Ok(response);
        }


        [HttpPut(ApiEndpoints.Method.Update)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateStaffRequest request, CancellationToken token)
        {
            if (request == null)
            {
                return BadRequest("Invalid request data.");
            }

            Staff Staff = _mapper.Map<Staff>(request);

            await _StaffService.UpdateAsync(Staff, token);

            var response = _mapper.Map<SingleStaffResponse>(Staff);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpDelete(ApiEndpoints.Method.Delete)]
        public async Task<IActionResult> Delete([FromRoute] Guid id, CancellationToken token)
        {
            var response = await _StaffService.DeleteAsync(id, token);

            return response ? Ok() : NotFound($"Staff with ID {id} not found.");
        }

    }
}
