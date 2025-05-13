using CareerPortal.Models;
using System.Net.Http.Json;

namespace CareerPortal.Services
{
    public class VacancyDataProvider
    {
        //from API
        private readonly HttpClient _http;

        public VacancyDataProvider(HttpClient http)
        {
            _http = http;
        }

        /*public async Task<List<VacancyItem>> LoadVacanciesAsync()
        {
            
            var vacancies = await _http.GetFromJsonAsync<List<VacancyItem>>("http://172.172.166.174:5042/api/v1/jobs");
            return vacancies ?? new List<VacancyItem>();
        }*/

        //Simulater data
        public async Task<List<VacancyItem>> LoadVacanciesAsync()
        {
            return await Task.FromResult(new List<VacancyItem>
            {
                new VacancyItem
                {
                    _id = "1",
                    title = "Software Developer",
                    contactEmail = "developer@example.com",
                    company = "Tech Corp",
                    location = "Remote",
                    salary = 70000
                },
                new VacancyItem
                {
                    _id = "2",
                    title = "Web Developer",
                    contactEmail = "webdev@example.com",
                    company = "Web Solutions",
                    location = "Randburg, Gauteng",
                    salary = 50000
                }
            });
        }
    }
}
