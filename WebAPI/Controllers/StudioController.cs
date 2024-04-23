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
    public class StudioController : Controller
    {
        private readonly IBaseService<Studio> _StudioService;
        private readonly IMapper _mapper;

        public StudioController(IBaseService<Studio> StudioService, IMapper mapper)
        {
            _StudioService = StudioService;
            _mapper = mapper;
        }


        [HttpPost(ApiEndpoints.Method.Create)]
        public async Task<IActionResult> Create([FromBody] CreateStudioRequest request, CancellationToken token)
        {
            var Studio = _mapper.Map<Studio>(request);

            var response = await _StudioService.CreateAsync(Studio, token);
            return CreatedAtAction(nameof(Create), new { id = response.Id }, response);
        }
        [HttpGet(ApiEndpoints.Method.Get)]
        public async Task<IActionResult> Get(Guid id, CancellationToken token)
        {
            var StudioExist = await _StudioService.GetAsync(id);

            if (StudioExist == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<SingleStudioResponse>(StudioExist);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpGet(ApiEndpoints.Method.GetAll)]
        public async Task<IActionResult> GetAll(CancellationToken token)
        {
            var Studio = await _StudioService.GetAllAsync(token);

            var response = new GetAllStudioResponse()
            {
                Items = _mapper.Map<IEnumerable<SingleStudioResponse>>(Studio)
            };

            return Ok(response);
        }


        [HttpPut(ApiEndpoints.Method.Update)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateStudioRequest request, CancellationToken token)
        {
            if (request == null)
            {
                return BadRequest("Invalid request data.");
            }

            Studio Studio = _mapper.Map<Studio>(request);

            await _StudioService.UpdateAsync(Studio, token);

            var response = _mapper.Map<SingleStudioResponse>(Studio);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpDelete(ApiEndpoints.Method.Delete)]
        public async Task<IActionResult> Delete([FromRoute] Guid id, CancellationToken token)
        {
            var response = await _StudioService.DeleteAsync(id, token);

            return response ? Ok() : NotFound($"Studio with ID {id} not found.");
        }

    }
}
