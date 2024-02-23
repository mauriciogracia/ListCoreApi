using Microsoft.AspNetCore.Mvc;

namespace listCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListController : ControllerBase
    {
        //For simplicity we keep the list of texts on memory, this simplify deployment given scope of test (no database needed)
        private static List<string> textLlist = new List<string>();

        public ListController()
        {
        }

        [HttpPost(Name = "Add")]
        public void Add([FromBody] string value)
        {
            textLlist.Add(value);
        }

        [HttpGet(Name = "ListAll")]
        public IEnumerable<string> Get()
        {
            return textLlist;
        }
    }
}
