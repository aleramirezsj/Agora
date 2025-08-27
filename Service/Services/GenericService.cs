﻿using Service.Interfaces;
using Service.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Service.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly HttpClient _httpClient;
        protected readonly JsonSerializerOptions _options;
        protected readonly string _endpoint;


        public GenericService() {
            _httpClient = new HttpClient();
            _options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            _endpoint= Properties.Resources.UrlApi+ApiEndpoints.GetEndpoint(typeof(T).Name);

        }
        public async Task<T?> AddAsync(T? entity)
        {
            var response = await _httpClient.PostAsJsonAsync(_endpoint, entity);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error al agregar el dato: {response.StatusCode} - {content}");
            }
            return JsonSerializer.Deserialize<T>(content, _options);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{_endpoint}/{id}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error al eliminar el dato: {response.StatusCode}");
            }
            return response.IsSuccessStatusCode;

        }

        public async Task<List<T>?> GetAllAsync(string? filtro)
        {
            var response= await _httpClient.GetAsync(_endpoint);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error al obtener los datos: {response.StatusCode}");
            }
            return JsonSerializer.Deserialize<List<T>>(content, _options);

        }

        public async Task<List<T>?> GetAllDeletedsAsync(string? filtro)
        {
            var response = await _httpClient.GetAsync($"{_endpoint}/deleteds");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error al obtener los datos: {response.StatusCode}");
            }
            return JsonSerializer.Deserialize<List<T>>(content, _options);
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{_endpoint}/{id}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error al obtener los datos: {response.StatusCode}");
            }
            return JsonSerializer.Deserialize<T>(content, _options);
        }

        public Task<bool> RestoreAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(T? entity)
        {
            throw new NotImplementedException();
        }
    }
}
