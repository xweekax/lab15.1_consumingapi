using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab15._1_ConsumingAnAPI.Models;

namespace Lab15._1_ConsumingAnAPI.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetTheDraw()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://deckofcardsapi.com");
            var response = await client.GetAsync("/api/deck/new/shuffle/?deck_count=1");
            Cards newDeck = await response.Content.ReadAsAsync<Cards>();

            response = await client.GetAsync($"/api/deck/{newDeck.Deck_id}/draw/?count=5");
            TheDraw newDeck1 = await response.Content.ReadAsAsync<TheDraw>();

            return View(newDeck1);
        }
        /*
        public async Task<IActionResult> GetTheDraw(string deck_id)
        {
            Cards deckid = new Cards() {Deck_id = deck_id};
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://deckofcardsapi.com");
            var response = await client.GetAsync($"/api/deck/{deck_id}/draw/?count=5");
            Cards newDeck = await response.Content.ReadAsAsync<Cards>();
            return View(newDeck);
        }
        */
    }
}
