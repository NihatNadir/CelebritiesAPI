using CelebritiesAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CelebritiesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CelebritiesController : ControllerBase
    {
        private static readonly List<Celebrity> celebrities = new List<Celebrity>()
        {
            new Celebrity{Id=1,Name="Tarkan",Profession="Pop Müzik Sanatçısı"},
            new Celebrity{Id=2,Name="Sıla",Profession="Pop Müzik Sanatçısı"},
            new Celebrity{Id=3,Name="Kenan İmirzalıoğlu",Profession="Oyuncu"},
            new Celebrity{Id=4,Name="Bergüzar Korel",Profession="Oyuncu"}

        };

        [HttpGet("{id}")] // uri kısmında id var
        public ActionResult<Celebrity> Get(int id)
        {
            var celebrity = celebrities.FirstOrDefault(x => x.Id == id);
            // celebrities listesinden linq sorgusu ile id eşleşen nesneyi alırız.
            if (celebrity == null)
            {
                // eşleşen nesne olmadığı zaman bu kısım çalışır.
                return NotFound();
            }
            // eşleşen nesne bulunur ve 200 ile o nesne döner.
            return Ok(celebrity);


        }

        [HttpPost]
        public ActionResult<Celebrity> Post([FromBody] Celebrity celebrity)
        {
            celebrity.Id = celebrities.Max(x => x.Id) + 1;
            // listedeki en yüksek id bulunur yeni oluşturulan nesneye bu id atanır.
            celebrities.Add(celebrity);
            // oluşturulan nesne listeye aktarılır.
            return CreatedAtAction(nameof(Get), new { id = celebrity.Id }, celebrity);
            // Http 201 Created durumu döner ve get metodu ile eklenen nesne getirilir. 
        }

        [HttpPut("{id}")] // uri kısmında id var
        public IActionResult Put(int id, [FromBody] Celebrity updatedCelebrity)
        {
            var celebrity = celebrities.FirstOrDefault(x => x.Id == id);
            // celebrities listesinden linq sorgusu ile id eşleşen nesneyi alırız.
            if (celebrity == null)  // eşleşen nesne olmadığı zaman bu kısım çalışır.
                return NotFound(); // 404 Not Found döner

            // Body gelen nesne propertyleri aktarılır
            celebrity.Name = updatedCelebrity.Name;
            celebrity.Profession = updatedCelebrity.Profession;
            // geriye 204 No Content döner
            return NoContent();
        }

        [HttpDelete("{id}")] // uri kısmında id var
        public IActionResult Delete(int id)
        {
            var celebrity = celebrities.FirstOrDefault(x=>x.Id == id);
            // celebrities listesinden linq sorgusu ile id eşleşen nesneyi alırız.
            if (celebrity == null) // eşleşen nesne olmadığı zaman bu kısım çalışır.
                return NotFound(); // 404 Not Found döner
            celebrities.Remove(celebrity); // celebrities listesinden celebrity nesnesi silinir.
            return NoContent(); // geriye 204 No Content döner
        }


    }
}
