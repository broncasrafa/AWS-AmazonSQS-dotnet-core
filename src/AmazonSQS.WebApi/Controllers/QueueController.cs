using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AmazonSQS.WebApi.Models;
using AmazonSQS.WebApi.Services;


namespace AmazonSQS.WebApi.Controllers;


[Route("api/[controller]")]
[ApiController]
public class QueueController : ControllerBase
{
    private readonly ISqsService _sqsService;

    public QueueController(ISqsService sqsService)
    {
        _sqsService = sqsService;
    }




    [HttpPost("send-message")]
    public async Task<IActionResult> SendMessageAsync(TicketRequest request)
    {
        var response = await _sqsService.SendMessageToSqsQueueAsync(request);
        if (response == null) return BadRequest();
        return Ok(response);
    }
}

