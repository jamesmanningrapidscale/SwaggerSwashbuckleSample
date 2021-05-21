using System;

namespace SwaggerSwashbuckleSample
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public SampleEnum1 SomeEnumFieldFoo { get; set; }
        public SampleEnum2 SomeEnumFieldBar { get; set; }
    }

    public enum SampleEnum1
    {
        Unknown = 0,
        SampleValue1Enum1,
        SampleValue2Enum1,
        SampleValue3Enum1,
        SampleValue4Enum1,
    }

    public enum SampleEnum2
    {
        Unknown = 0,
        SampleValue1ForEnum2,
        SampleValue2ForEnum2,
        SampleValue3ForEnum2,
    }
}
