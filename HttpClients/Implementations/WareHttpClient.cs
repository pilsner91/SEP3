using System.Net.Http.Json;
using System.Text.Json;
using HttpClients.ClientInterfaces;
using Shared.DTOs;
using Shared.Model;

namespace HttpClients.Implementations; 

public class WareHttpClient : IWareService {
    
    private HttpClient client;

    public WareHttpClient(HttpClient client) {
        this.client = client;
    }

    public async Task<Ware> Create(WareCreationDto dto) {
        HttpResponseMessage response = await client.PostAsJsonAsync("/wares", dto);
        string result = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(result);
        }

        Ware ware = JsonSerializer.Deserialize<Ware>(result, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return ware;
    }
}