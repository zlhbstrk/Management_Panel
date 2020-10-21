using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Management_Panel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Text;

namespace Management_Panel.Controllers
{
    public class UrunController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        public async Task<IActionResult> UrunListele()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            HttpResponseMessage streamTask = await client.GetAsync("https://localhost:44363/api/Products");

            var urunler = await JsonSerializer.DeserializeAsync<List<Urun>>(await streamTask.Content.ReadAsStreamAsync());

            if (TempData["Silinen"] == null)
            {
                ViewBag.SonucSilinen = false;
                ViewBag.Silinen = null;
            }
            else
            {
                ViewBag.SonucSilinen = true;
                ViewBag.Silinen = TempData["Silinen"];
            }

            if (TempData["AskiyaAl"] == null)
            {
                ViewBag.SonucAskiyaAl = false;
                ViewBag.AskiyaAl = null;
            }
            else
            {
                ViewBag.SonucAskiyaAl = true;
                ViewBag.AskiyaAl = TempData["AskiyaAl"];
            }

            return View(urunler);
        }

        [HttpGet]
        public IActionResult UrunEkle()
        {
            @ViewBag.Eklenen = "";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UrunEkle(Urun eklenenUrun)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            HttpResponseMessage streamTask = await client.PostAsync("https://localhost:44363/api/Products/", new StringContent(JsonSerializer.Serialize(eklenenUrun), Encoding.UTF8, "application/json"));

            ViewBag.Eklenen = eklenenUrun.name;
            return View();
        }

        [HttpGet]
        [Route("Urun/UrunSil/{id}")]
        public async Task<IActionResult> UrunSil(int id)
        {
            if (id != 0)
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
                client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

                HttpResponseMessage streamTask = await client.DeleteAsync("https://localhost:44363/api/Products/" + id);

                var urunler = await JsonSerializer.DeserializeAsync<Urun>(await streamTask.Content.ReadAsStreamAsync());

                TempData["Silinen"] = urunler.name;
                return RedirectToAction("UrunListele");
            }

            return RedirectToAction("UrunListele");

        }

        [HttpGet]
        [Route("Urun/AskiyaAl/{id}")]
        public async Task<IActionResult> AskiyaAl(int id)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            HttpResponseMessage streamTask = await client.PutAsync("https://localhost:44363/api/Products/AskiyaAl/" + id, new StringContent(JsonSerializer.Serialize(new { Status = false }), Encoding.UTF8, "application/json"));

            var urun = await JsonSerializer.DeserializeAsync<Urun>(await streamTask.Content.ReadAsStreamAsync());

            TempData["AskiyaAl"] = id.ToString();
            return RedirectToAction("UrunListele");
        }

        [HttpGet]
        [Route("Urun/UrunGuncelle/{id}")]
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

        [HttpPost]
        public async Task<IActionResult> UrunGuncelle(Urun guncellenenUrun)
        {
            if (guncellenenUrun != null)
            {
                if (guncellenenUrun.id != 0)
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
                    client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

                    HttpResponseMessage streamTask = await client.PutAsync("https://localhost:44363/api/Products/" + guncellenenUrun.id, new StringContent(JsonSerializer.Serialize(guncellenenUrun), Encoding.UTF8, "application/json"));

                    var urun = await JsonSerializer.DeserializeAsync<Urun>(await streamTask.Content.ReadAsStreamAsync());

                    ViewBag.Guncellenen = guncellenenUrun.name;
                    return View(urun);
                }
            }
            ViewBag.Guncellenen = guncellenenUrun.name;
            return View(guncellenenUrun);
        }
    }
}
