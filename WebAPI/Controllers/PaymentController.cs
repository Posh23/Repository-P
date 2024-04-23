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
    public class PaymentController : Controller
    {
        private readonly IBaseService<Payment> _PaymentService;
        private readonly IMapper _mapper;

        public PaymentController(IBaseService<Payment> PaymentService, IMapper mapper)
        {
            _PaymentService = PaymentService;
            _mapper = mapper;
        }


        [HttpPost(ApiEndpoints.Method.Create)]
        public async Task<IActionResult> Create([FromBody] CreatePaymentRequest request, CancellationToken token)
        {
            var Payment = _mapper.Map<Payment>(request);

            var response = await _PaymentService.CreateAsync(Payment, token);
            return CreatedAtAction(nameof(Create), new { id = response.Id }, response);
        }
        [HttpGet(ApiEndpoints.Method.Get)]
        public async Task<IActionResult> Get(Guid id, CancellationToken token)
        {
            var PaymentExist = await _PaymentService.GetAsync(id);

            if (PaymentExist == null)
            {
                return NotFound();
            }

            var response = _mapper.Map<SinglePaymentResponse>(PaymentExist);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpGet(ApiEndpoints.Method.GetAll)]
        public async Task<IActionResult> GetAll(CancellationToken token)
        {
            var Payment = await _PaymentService.GetAllAsync(token);

            var response = new GetAllPaymentResponse()
            {
                Items = _mapper.Map<IEnumerable<SinglePaymentResponse>>(Payment)
            };

            return Ok(response);
        }


        [HttpPut(ApiEndpoints.Method.Update)]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdatePaymentRequest request, CancellationToken token)
        {
            if (request == null)
            {
                return BadRequest("Invalid request data.");
            }

            Payment Payment = _mapper.Map<Payment>(request);

            await _PaymentService.UpdateAsync(Payment, token);

            var response = _mapper.Map<SinglePaymentResponse>(Payment);

            return response == null ? NotFound() : Ok(response);
        }

        [HttpDelete(ApiEndpoints.Method.Delete)]
        public async Task<IActionResult> Delete([FromRoute] Guid id, CancellationToken token)
        {
            var response = await _PaymentService.DeleteAsync(id, token);

            return response ? Ok() : NotFound($"Payment with ID {id} not found.");
        }

    }
}
