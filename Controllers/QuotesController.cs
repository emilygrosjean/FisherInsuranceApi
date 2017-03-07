using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/quotes")]

    public class AutoController : Controller 
    {

        //private IMemoryStore db;

        //public AutoController(IMemoryStore repo)
        //{
            //db = repo;
        //}
        
        //POST api/quotes
        [HttpPost]
        public IActionResult Post([FromBody] Quote quote)
        {
            return Ok();//db.CreateQuote(quote));
        }  

        //GET api/quotes/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();//db.RetrieveQuote(id));
        }

        //PUT api/quotes/id
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Quote quote)
        {
            return Ok();//db.UpdateQuote(quote));
        }

        //DELETE api/quotes/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //db.DeleteQuote(id);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetQuotes()
        {
            return Ok();//db.RetrieveAllQuotes);
        }
    }