using System;
using System.IO;
using System.Text.Json;

public class BankTransferData
{ 
public string threshold { get; set; }
public string low_fee { get; set; }
public string high_fee { get; set; }
}

public class BankTransferConfig
{
    private string filepath = "bank_transfer_config.json";
    public int threshold { get; set; }
    public int low_fee { get; set; }
    public int high_fee { get; set; }


    public BankTransferConfig()
    {
        if (File.Exists(filepath))
        {
            string json = File.ReadAllText(filepath);
            BankTransferData data = JsonSerializer.Deserialize<BankTransferData>(json);
            threshold = int.Parse(data.threshold);
            low_fee = int.Parse(data.low_fee);
            high_fee = int.Parse(data.high_fee);
        }
        else
        {
            threshold = 25000000;
            low_fee = 6500;
            high_fee = 15000;
        }
    }
    public void Save()
    {
        var config = new BankTransferData{ 
            threshold = threshold.ToString(),
            low_fee = low_fee.ToString(),
            high_fee = high_fee.ToString()
        };
        string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true});
        File.WriteAllText(filepath, json);
    }

    public string[] methods = { get, set };

    public class TransferConfig (string lang, string method)
    {
  
    }

}