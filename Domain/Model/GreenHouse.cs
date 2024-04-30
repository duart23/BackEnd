namespace Domain.Model
{
    using System.ComponentModel.DataAnnotations;

    public class GreenHouse
    {
        [Key]
        public int GreenHouseId { get; set; }
        public string GreenHouseName { get; set; }
        public string? Description { get; set; }
        public double Temperature { get; set; }
        public double LightIntensity { get; set; }
        public double Co2Levels { get; set; }
        public double Humidity { get; set; }
        public Window Window { get; set; } // Make it settable

        // Parameterless constructor
        public GreenHouse() { }

        // Constructor with all properties including Window
        public GreenHouse(int greenHouseId, string greenHouseName, double temperature, double lightIntensity, double co2Levels, double humidity, Window window)
        {
            GreenHouseId = greenHouseId;
            GreenHouseName = greenHouseName;
            Temperature = temperature;
            LightIntensity = lightIntensity;
            Co2Levels = co2Levels;
            Humidity = humidity;
            Window = window;
        }
    }
}