using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendMessageService;

        public SendMessageController(ISendMessageService sendMessageService)
        {
            _sendMessageService = sendMessageService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var values = _sendMessageService.TGetList();
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var values = _sendMessageService.TGetByID(id);
            _sendMessageService.TDelete(values);
            return Ok();
        }

        [HttpPost]
        public IActionResult AddStaff(SendMessage sendMessage)
        {
            _sendMessageService.TInsert(sendMessage);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff(SendMessage sendMessage)
        {
            _sendMessageService.TUpdate(sendMessage);
            return Ok();

        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var values = _sendMessageService.TGetByID(id);
            return Ok(values);

        }
    }
}
