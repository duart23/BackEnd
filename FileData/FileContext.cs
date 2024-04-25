using System.Text.Json;
using Domain.Model;

namespace FileData;

public class FileContext
{
    private const string filePath = "data.json";
    private DataContainer? dataContainer;

    public ICollection<Window> Windows
    {
        get
        {
            LoadData();
            return dataContainer!.Windows;
        }
    }

    public ICollection<GreenHouse> GreenHouses
    {
        get
        {
            LoadData();
            return dataContainer!.GreenHouses;
        }
    }
    
    
    private void LoadData()
    {
        if (dataContainer != null) return;
    
        if (!File.Exists(filePath))
        {
            dataContainer = new ()
            {
                Windows = new List<Window>(),
                GreenHouses = new List<GreenHouse>()
            };
            return;
        }
        string content = File.ReadAllText(filePath);
        dataContainer = JsonSerializer.Deserialize<DataContainer>(content);
    }
    
    public void SaveChanges()
    {
        string serialized = JsonSerializer.Serialize(dataContainer);
        File.WriteAllText(filePath, serialized);
        dataContainer = null;
    }
}