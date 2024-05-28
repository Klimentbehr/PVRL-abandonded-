public class Gun
{
    public string ID { get; set; }
    public string Origin { get; set; }
    public string UpperReceiver { get; set; }
    public string Barrel { get; set; }
    public string LowerReceiver { get; set; }
    public string BufferTube { get; set; }
    public string Stock { get; set; }
    public string Grip { get; set; }
    public string Trigger { get; set; }
    public int Damage { get; set; }
    public int Accuracy { get; set; }

    public static Gun Parse(string gunData)
    {
        var gun = new Gun();
        var lines = gunData.Split(new[] { "\r\n" }, StringSplitOptions.None);

        foreach (var line in lines)
        {
            var parts = line.Split(':');
            if (parts.Length == 2)
            {
                string key = parts[0].Trim();
                string value = parts[1].Trim();

                switch (key)
                {
                    case "ID":
                        gun.ID = value;
                        break;
                    case "Origin":
                        gun.Origin = value;
                        break;
                    case "Upper Receiver":
                        gun.UpperReceiver = value;
                        break;
                    case "Barrel":
                        gun.Barrel = value;
                        break;
                    case "Lower Receiver":
                        gun.LowerReceiver = value;
                        break;
                    case "Buffer Tube":
                        gun.BufferTube = value;
                        break;
                    case "Stock":
                        gun.Stock = value;
                        break;
                    case "Grip":
                        gun.Grip = value;
                        break;
                    case "Trigger":
                        gun.Trigger = value;
                        break;
                    case "Damage":
                        gun.Damage = int.Parse(value);
                        break;
                    case "Accuracy":
                        gun.Accuracy = int.Parse(value);
                        break;
                }
            }
        }

        return gun;
    }

    public override string ToString()
    {
        return $"ID: {ID}\nOrigin: {Origin}\nUpper Receiver: {UpperReceiver}\nBarrel: {Barrel}\nLower Receiver: {LowerReceiver}\nBuffer Tube: {BufferTube}\nStock: {Stock}\nGrip: {Grip}\nTrigger: {Trigger}\nDamage: {Damage}\nAccuracy: {Accuracy}";
    }
}
