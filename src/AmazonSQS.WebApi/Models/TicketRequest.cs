using System.Text.Json;

namespace AmazonSQS.WebApi.Models;

public class TicketRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public static string Serialize(TicketRequest value)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
        };
        return JsonSerializer.Serialize(value, options);
    }
}
