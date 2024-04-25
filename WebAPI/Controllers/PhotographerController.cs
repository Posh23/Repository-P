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
    public class PhotographerController : Controller
    {
        private readonly IBaseService<Photographer> _PhotographerService;
        private readonly IMapper _mapper;

        public PhotographerController(IBaseService<Photographer> PhotographerService, IMapper mapper)
        {
            _PhotographerService = PhotographerService;
            _mapper = mapper;
        }


        [HttpPost(ApiEndpoints.Method.Create)]
        public async Task<IActionResult> Create([FromBody] CreatePhotographerRequest request, CancellationToken token)
        {
            var Photographer = _mapper.Map<Photographer>(request);

            var response = await _PhotographerService.CreateAsync(Photographer, token);
            return CreatedAtAction(nameof(Create), new { id = response.Id }, response);
        }
        [HttpGet(ApiEndpoints.Method.Get)]
        public async Task<IActionResult> Get(Guid id, CancellationToken token)
        {
            var PhotographerExist = await _PhotographerService.GetAsync(id);

            if (PhotographerExist == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<SinglePhotographerResponse>(PhotographerExist);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpGet(ApiEndpoints.Method.GetAll)]
        public async Task<IActionResult> GetAll(CancellationToken token)
        {
            var Photographer = await _PhotographerService.GetAllAsync(token);

            var response = new GetAllPhotographerResponse()
            {
                Items = _mapper.Map<IEnumerable<SinglePhotographerResponse>>(Photographer)
            };

            return Ok(response);
        }


        [HttpPut(ApiEndpoints.Method.Update)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdatePhotographerRequest request, CancellationToken token)
        {
            if (request == null)
            {
                return BadRequest("Invalid request data.");
            }

            Photographer Photographer = _mapper.Map<Photographer>(request);

            await _PhotographerService.UpdateAsync(Photographer, token);

            var response = _mapper.Map<SinglePhotographerResponse>(Photographer);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpDelete(ApiEndpoints.Method.Delete)]
        public async Task<IActionResult> Delete([FromRoute] Guid id, CancellationToken token)
        {
            var response = await _PhotographerService.DeleteAsync(id, token);

            return response ? Ok() : NotFound($"Photographer with ID {id} not found.");
        }

    }
}
