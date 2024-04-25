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
    public class MagazineController : Controller
    {
        private readonly IBaseService<Magazine> _MagazineService;
        private readonly IMapper _mapper;

        public MagazineController(IBaseService<Magazine> MagazineService, IMapper mapper)
        {
            _MagazineService = MagazineService;
            _mapper = mapper;
        }


        [HttpPost(ApiEndpoints.Method.Create)]
        public async Task<IActionResult> Create([FromBody] CreateMagazineRequest request, CancellationToken token)
        {
            var Magazine = _mapper.Map<Magazine>(request);

            var response = await _MagazineService.CreateAsync(Magazine, token);
            return CreatedAtAction(nameof(Create), new { id = response.Id }, response);
        }
        [HttpGet(ApiEndpoints.Method.Get)]
        public async Task<IActionResult> Get(Guid id, CancellationToken token)
        {
            var MagazineExist = await _MagazineService.GetAsync(id);

            if (MagazineExist == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<SingleMagazineResponse>(MagazineExist);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpGet(ApiEndpoints.Method.GetAll)]
        public async Task<IActionResult> GetAll(CancellationToken token)
        {
            var Magazine = await _MagazineService.GetAllAsync(token);

            var response = new GetAllMagazineResponse()
            {
                Items = _mapper.Map<IEnumerable<SingleMagazineResponse>>(Magazine)
            };

            return Ok(response);
        }


        [HttpPut(ApiEndpoints.Method.Update)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateMagazineRequest request, CancellationToken token)
        {
            if (request == null)
            {
                return BadRequest("Invalid request data.");
            }

            Magazine Magazine = _mapper.Map<Magazine>(request);

            await _MagazineService.UpdateAsync(Magazine, token);

            var response = _mapper.Map<SingleMagazineResponse>(Magazine);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpDelete(ApiEndpoints.Method.Delete)]
        public async Task<IActionResult> Delete([FromRoute] Guid id, CancellationToken token)
        {
            var response = await _MagazineService.DeleteAsync(id, token);

            return response ? Ok() : NotFound($"Magazine with ID {id} not found.");
        }

    }
}
