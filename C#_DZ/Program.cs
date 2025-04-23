using C__DZ.DZ_07_04_25;

var advertisingPlatforms = new AdvertisingPlatforms();

advertisingPlatforms.AddAdvertisingPlatform("Ревдинский рабочий:/ru/svrd/revda,/ru/svrd/pervik");
advertisingPlatforms.AddAdvertisingPlatform("Газета уральских москвичей:/ru/msk,/ru/permobl,/ru/chelobl");
advertisingPlatforms.AddAdvertisingPlatform("Крутая реклама:/ru/svrd");
advertisingPlatforms.AddAdvertisingPlatform("Яндекс.Директ:/ru");

var platforms = new List<string>();

var location = "/ru/chelobl";

//var location = AdvertisingPlatforms.InputLocation();

platforms = advertisingPlatforms.GetPlatformsByLocation(location);

Console.WriteLine($"Список рекламных платформ, действующих в локации: {location}");

foreach (var platform in platforms)
{
    Console.WriteLine(platform);
}