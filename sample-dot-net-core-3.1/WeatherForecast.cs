using System;
using Microsoft.EntityFrameworkCore;

namespace sample_dot_net_core_3._1
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public bool db_connection { get; set; }
    }

    public class TestModel
    {
        public long Id { get; set; }
    }

    public class TestModelContext: DbContext
    {
        public DbSet<TestModel> TestModels { get; set; }
    }

}
