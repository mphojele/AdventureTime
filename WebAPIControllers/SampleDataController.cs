namespace AdventureTime.WebAPIControllers
{
    using AdventureTime.Models;
    using DevExtreme.AspNet.Data;
    using DevExtreme.AspNet.Mvc;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class SampleDataController : ControllerBase
    {
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(SampleData.Characters, loadOptions);
        }
    }
}