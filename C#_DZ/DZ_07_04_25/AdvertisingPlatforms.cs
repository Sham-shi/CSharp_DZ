

namespace C__DZ.DZ_07_04_25;

public class AdvertisingPlatforms
{
    private Dictionary<string, List<string>> platformsByLocation;

    public AdvertisingPlatforms()
    {
        platformsByLocation = [];
    }

    public void AddAdvertisingPlatform(string advertisingPlatformAndLocations)
    {
        // разделяем строку на платформу и список локаций
        var elements = advertisingPlatformAndLocations.Split(':');

        // разделяем список локаций на отдельные локации (если их несколько)
        var locations = elements[1].Split(',');

        // обозначаем текущую платформу
        var currentPlatform = elements[0];

        // заполняем словарь данными
        if (!platformsByLocation.ContainsKey(currentPlatform))
        {
            platformsByLocation[currentPlatform] = [];
        }

        for (int i = 0; i < locations.Length; i++)
        {
            platformsByLocation[currentPlatform].Add(locations[i]);
        }
    }

    // дял проверки введённой локации
    private static bool CheckInput(string location)
    {
        string specialChars = "abcdefghijklmnopqrstuvwxyz/";

        // если пустая строка
        if (string.IsNullOrEmpty(location))
        {
            return false;
        }

        // первым симолом должен быть /
        if (location[0] !=  '/' || location.Length == 1)
        {
            return false;
        }

        // если символ / повторяется 2 раза подряд
        if (location.IndexOf("//") != -1)
        {
            return false;
        }

        // проверяем все ли символы в location состоят только из specialChars
        var isValid = location.All(c => specialChars.Contains(c));

        return isValid;
    }

    // для ввода локации с клавиатуры
    public static string InputLocation()
    {
        string inputLocation;

        while (true)
        {
            Console.WriteLine("Введите локацию для поиска подходящих рекламных площадок:");
            inputLocation = Console.ReadLine();

            if (CheckInput(inputLocation) && inputLocation != "")
            {
                break;
            }
            else
            {
                Console.WriteLine("Некорректный ввод!");
                Console.WriteLine("Допускаются только латинские буквы в нижнем регистре и символ /");
                Console.WriteLine("Например: /ru или /ru/msk\n");
            }
        }

        return inputLocation;
    }

    public List<string> GetPlatformsByLocation(string location)
    {
        // по мере выполнения программы location будет изменяться
        // чтобы избежать этого заведем временную переменную
        string temp = location;
        // переменная для хранения позиции символа '/'
        int position;
        // сюда будем записывать площадки, которые действуют в заданной location
        var platforms = new List<string>();

        while (temp != "")
        {
            foreach (var platform in platformsByLocation)
            {
                // если входящая локация совпадает с локацией в текущей платформе
                if (platform.Value.Contains(temp))
                {
                    // добавляем в список
                    platforms.Add(platform.Key);
                }
            }

            //if (platforms.Count == 0)
            //{
            //    continue;
            //}
            // т.к. локации могут быть вложенными, необходимо постепенно сокращать temp
            // пример: было - /ru/sverd, стало /ru
            // для этого:
            // находим позицию последнего вхождения символа '/'
            position = temp.LastIndexOf('/');
            // сокращаем temp
            temp = temp.Substring(0, position);
            // далее снова по циклу ищем совпадения по сокращенному temp
        }

        return platforms;
    }
}


