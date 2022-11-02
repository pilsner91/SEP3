using System.Net.Http.Json;
using System.Text.Json;
using HttpClients.ClientInterfaces;
using Shared.DTOs;
using Shared.Model;

namespace HttpClients.Implementations; 

public class ItemHttpClient : IItemService {
    
    private HttpClient client;

    public ItemHttpClient(HttpClient client) {
        this.client = client;
    }

    public async Task<Item> Create(ItemCreationDto dto) {
        HttpResponseMessage response = await client.PostAsJsonAsync("/items", dto);
        string result = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result);
        }

        Item item = JsonSerializer.Deserialize<Item>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return item;
    }
}