using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Internal;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        ILogger<OrdersController> _logger;
        IOrderService _service;
        public OrdersController(ILogger<OrdersController> logger, IOrderService service)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        [Authorize]
        public IActionResult GetAll() 
        {
            try
            {
                var orders = _service.GetAll();
                _logger.LogInformation($"User with id {User.GetId()} got all orders");
                return Ok(orders);
            }
            catch (Exception ex) 
            {
                _logger.LogInformation($"User with id {User.GetId()} tried getting all orders but failed: {ex.Message}");
                return BadRequest();
            }
        }

        [HttpGet]
        [Authorize]
        public IActionResult Get(int id)
        {
            try
            {
                var order = _service.GetById(id);
                _logger.LogInformation($"User with id {User.GetId()} got order with id {id}");
                return Ok(order);
            }
            catch (InvalidDataException ex)
            {
                _logger.LogInformation($"User with id {User.GetId()} got id wrong of order: {ex.Message}");
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"User with id {User.GetId()} tried getting all orders but failed: {ex.Message}");
                return BadRequest();
            }
        }
    }
}
