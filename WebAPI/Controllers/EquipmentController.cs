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
    public class EquipmentController : Controller
    {
        private readonly IBaseService<Equipment> _EquipmentService;
        private readonly IMapper _mapper;

        public EquipmentController(IBaseService<Equipment> EquipmentService, IMapper mapper)
        {
            _EquipmentService = EquipmentService;
            _mapper = mapper;
        }


        [HttpPost(ApiEndpoints.Method.Create)]
        public async Task<IActionResult> Create([FromBody] CreateEquipmentRequest request, CancellationToken token)
        {
            var Equipment = _mapper.Map<Equipment>(request);

            var response = await _EquipmentService.CreateAsync(Equipment, token);
            return CreatedAtAction(nameof(Create), new { id = response.Id }, response);
        }
        [HttpGet(ApiEndpoints.Method.Get)]
        public async Task<IActionResult> Get(Guid id, CancellationToken token)
        {
            var EquipmentExist = await _EquipmentService.GetAsync(id);

            if (EquipmentExist == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<SingleEquipmentResponse>(EquipmentExist);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpGet(ApiEndpoints.Method.GetAll)]
        public async Task<IActionResult> GetAll(CancellationToken token)
        {
            var Equipment = await _EquipmentService.GetAllAsync(token);

            var response = new GetAllEquipmentResponse()
            {
                Items = _mapper.Map<IEnumerable<SingleEquipmentResponse>>(Equipment)
            };

            return Ok(response);
        }


        [HttpPut(ApiEndpoints.Method.Update)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateEquipmentRequest request, CancellationToken token)
        {
            if (request == null)
            {
                return BadRequest("Invalid request data.");
            }

            Equipment Equipment = _mapper.Map<Equipment>(request);

            await _EquipmentService.UpdateAsync(Equipment, token);

            var response = _mapper.Map<SingleEquipmentResponse>(Equipment);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpDelete(ApiEndpoints.Method.Delete)]
        public async Task<IActionResult> Delete([FromRoute] Guid id, CancellationToken token)
        {
            var response = await _EquipmentService.DeleteAsync(id, token);

            return response ? Ok() : NotFound($"Equipment with ID {id} not found.");
        }

    }
}
