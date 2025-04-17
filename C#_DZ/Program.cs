using C__DZ.DZ_07_04_25;

var advertisingPlatforms = new AdvertisingPlatforms();

advertisingPlatforms.AddAdvertisingPlatform("Яндекс.Директ:/ru");
advertisingPlatforms.AddAdvertisingPlatform("Ревдинский рабочий:/ru/svrd/revda,/ru/svrd/pervik");
advertisingPlatforms.AddAdvertisingPlatform("Газета уральских москвичей:/ru/msk,/ru/permobl,/ru/chelobl");
advertisingPlatforms.AddAdvertisingPlatform("Крутая реклама:/ru/svrd");

var platforms = new List<string>();

var location = "/ru/msk";

//var location = AdvertisingPlatforms.InputLocation();

platforms = advertisingPlatforms.GetPlatformsByLocation(location);

if (platforms.Count == 0)
{
    Console.WriteLine($"Рекламных платформ, действующих в локации {location} не найдено");
}
else
{
    Console.WriteLine($"Список рекламных платформ, действующих в локации: {location}");

    foreach (var platform in platforms)
    {
        Console.WriteLine(platform);
    }
}
