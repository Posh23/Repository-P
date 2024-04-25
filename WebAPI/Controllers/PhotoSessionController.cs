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
    public class PhotoSessionController : Controller
    {
        private readonly IBaseService<PhotoSession> _PhotoSessionService;
        private readonly IMapper _mapper;

        public PhotoSessionController(IBaseService<PhotoSession> PhotoSessionService, IMapper mapper)
        {
            _PhotoSessionService = PhotoSessionService;
            _mapper = mapper;
        }


        [HttpPost(ApiEndpoints.Method.Create)]
        public async Task<IActionResult> Create([FromBody] CreatePhotoSessionRequest request, CancellationToken token)
        {
            var PhotoSession = _mapper.Map<PhotoSession>(request);

            var response = await _PhotoSessionService.CreateAsync(PhotoSession, token);
            return CreatedAtAction(nameof(Create), new { id = response.Id }, response);
        }
        [HttpGet(ApiEndpoints.Method.Get)]
        public async Task<IActionResult> Get(Guid id, CancellationToken token)
        {
            var PhotoSessionExist = await _PhotoSessionService.GetAsync(id);

            if (PhotoSessionExist == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<SinglePhotoSessionResponse>(PhotoSessionExist);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpGet(ApiEndpoints.Method.GetAll)]
        public async Task<IActionResult> GetAll(CancellationToken token)
        {
            var PhotoSession = await _PhotoSessionService.GetAllAsync(token);

            var response = new GetAllPhotoSessionResponse()
            {
                Items = _mapper.Map<IEnumerable<SinglePhotoSessionResponse>>(PhotoSession)
            };

            return Ok(response);
        }


        [HttpPut(ApiEndpoints.Method.Update)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdatePhotoSessionRequest request, CancellationToken token)
        {
            if (request == null)
            {
                return BadRequest("Invalid request data.");
            }

            PhotoSession PhotoSession = _mapper.Map<PhotoSession>(request);

            await _PhotoSessionService.UpdateAsync(PhotoSession, token);

            var response = _mapper.Map<SinglePhotoSessionResponse>(PhotoSession);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpDelete(ApiEndpoints.Method.Delete)]
        public async Task<IActionResult> Delete([FromRoute] Guid id, CancellationToken token)
        {
            var response = await _PhotoSessionService.DeleteAsync(id, token);

            return response ? Ok() : NotFound($"PhotoSession with ID {id} not found.");
        }

    }
}
