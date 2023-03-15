using Amazon.SQS.Model;
using AmazonSQS.WebApi.Models;

namespace AmazonSQS.WebApi.Services;

public interface ISqsService
{
    Task<SendMessageResponse> SendMessageToSqsQueueAsync(TicketRequest request);
}
