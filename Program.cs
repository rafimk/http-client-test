// See https://aka.ms/new-console-template for more information

using System.Net.Http.Json;
using http_client_test;

Console.WriteLine("Hello, World!");

var membershipCardDto = new MembershipCardDto
{
    MembershipNo = "AUH10001",
    Date = "01/01/2022",
    FullName = "MUHAMMED RAFI",
    District = "KASARAGOAD",
    Mandalam = "TRIKARPUR",
    Panchayath = "TRIKARPUR",
    State = "ABU DHABI",
    Area = "MUSAFFAH",
    CollectedBy = "AGENT"
};

JsonContent content = JsonContent.Create(membershipCardDto);

HttpClient _httpClient = new HttpClient();
var response = await _httpClient.PostAsync("http://localhost:5003/reports/filestream", content);

if (response.IsSuccessStatusCode)
{
    var mybytearray = response.Content.ReadAsByteArrayAsync().Result;
} 

