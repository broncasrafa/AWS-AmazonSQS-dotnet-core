using Amazon.SQS;
using Amazon.SQS.Model;
using AmazonSQS.WebApi.Models;

namespace AmazonSQS.WebApi.Services;

public class SqsService : ISqsService
{
    private readonly IAmazonSQS _amazonSQSClient;

    public SqsService(IAmazonSQS amazonSQSClient)
    {
        _amazonSQSClient = amazonSQSClient;
    }


    public async Task<SendMessageResponse> SendMessageToSqsQueueAsync(TicketRequest request)
    {
        var messageRequest = new SendMessageRequest
        {
            QueueUrl = "https://sqs.us-east-1.amazonaws.com/456760725532/TicketRequest",
            MessageBody = TicketRequest.Serialize(request)
        };

        return await _amazonSQSClient.SendMessageAsync(messageRequest);
    }
}
