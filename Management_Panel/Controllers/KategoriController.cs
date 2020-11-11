using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Management_Panel.Models;
using System.Net.Http;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Text;

namespace Management_Panel.Controllers
{
    public class KategoriController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<IActionResult> KategoriListele()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            HttpResponseMessage streamTask = await client.GetAsync("https://localhost:44363/api/Category");

            var kategoriler = await JsonSerializer.DeserializeAsync<List<Kategori>>(await streamTask.Content.ReadAsStreamAsync());

            return View(kategoriler);
        }

        [HttpGet]
        public IActionResult KategoriEkle()
        {
            @ViewBag.Eklenen = "";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> KategoriEkle(Kategori eklenenKategori)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            HttpResponseMessage streamTask = await client.PostAsync("https://localhost:44363/api/Category/", new StringContent(JsonSerializer.Serialize(eklenenKategori), Encoding.UTF8, "application/json"));

            ViewBag.Eklenen = eklenenKategori.name;
            return View();
        }

        [HttpGet]
        [Route("Kategori/KategoriSil/{id}")]
        public async Task<IActionResult> KategoriSil(int id)
        {
            if (id != 0)
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
                client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

                HttpResponseMessage streamTask = await client.DeleteAsync("https://localhost:44363/api/Category/" + id);

                var kategoriler = await JsonSerializer.DeserializeAsync<Kategori>(await streamTask.Content.ReadAsStreamAsync());

                TempData["Silinen"] = kategoriler.name;
                return RedirectToAction("KategoriListele");
            }

            return RedirectToAction("KategoriListele");
        }

        [HttpGet]
        [Route("Kategori/KategoriGuncelle/{id}")]
        public async Task<IActionResult> UrunGuncelle(int id)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            HttpResponseMessage streamTask = await client.GetAsync("https://localhost:44363/api/Products/" + id);

            var urun = await JsonSerializer.DeserializeAsync<Urun>(await streamTask.Content.ReadAsStreamAsync());

            return View(urun);
        }

    }
}
