namespace Domain.Model;

public class GreenHouse
{
    public int GreenHouseId { get; set; }
    public string GreenHouseName { get; set; }
    public string? Description { get; set; }
    public double Temperature { get; set; }
    public double LightIntensity { get; set; }
    public double Co2Levels { get; set; }
    public double Humidity { get; set; }
    public bool IsWindowOpen { get; set; }


    public GreenHouse(int greenHouseId, string greenHouseName, double temperature, double lightIntensity, double co2Levels, double humidity, bool isWindowOpen)
    {
        GreenHouseId = greenHouseId;
        GreenHouseName = greenHouseName;
        Temperature = temperature;
        LightIntensity = lightIntensity;
        Co2Levels = co2Levels;
        Humidity = humidity;
        IsWindowOpen = isWindowOpen;
    }

    
}