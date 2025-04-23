

using System;
using System.Linq;

namespace C__DZ.DZ_07_04_25;

public class AdvertisingPlatforms
{
    private Dictionary<string, List<string>> platformsByLocation;

    public AdvertisingPlatforms()
    {
        platformsByLocation = [];
    }

    // обновление по вложенности
    // проверяем по каждому ключу могут ли быть вложены в него другие ключи
    private void UpdatingByNesting2()
    {
        foreach (var location in platformsByLocation)
        {
            var currentLocation = location.Key;
            int position;

            position = currentLocation.LastIndexOf("/");
            currentLocation = currentLocation[..position];

            while (currentLocation != "")
            {
                foreach (var location2 in platformsByLocation)
                {
                    if (currentLocation == location2.Key && location.Key.GetHashCode() != location2.Key.GetHashCode())
                    {
                        location.Value.AddRange(location2.Value);
                    }
                }

                position = currentLocation.LastIndexOf("/");
                currentLocation = currentLocation[..position];
            }
        }

        // т.к. значения по ключам могут повторяться, используем Distinct
        foreach (var location in platformsByLocation)
        {
            platformsByLocation[location.Key] = [.. location.Value.Distinct()]; // location.Value.Distinct().ToList()
        }
    }

    // обновление по вложенности
    // после добавления новой локации, проверяем 
    // сначала может ли быть она быть вложена в другие существующие локации
    // затем могут ли в неё быть добавлены существующие локации
    private void UpdatingByNesting(string[] locations, string advertisingPlatform)
    {
        // проверяем вложенность локаций
        for (int i = 0; i < locations.Length; i++)
        {
            // по мере выполнения программы location[i] будет изменяться
            // чтобы избежать этого заведем временную переменную
            var tempLocation = locations[i];
            // переменная для хранения позиции символа '/'
            int position;

            // т.к. локации могут быть вложенными, необходимо постепенно сокращать tempLocation
            // пример: было - /ru/sverd, стало /ru
            // для этого:
            // находим позицию последнего вхождения символа '/'
            position = tempLocation.LastIndexOf('/');
            // сокращаем temp
            tempLocation = tempLocation[..position]; //temp.Substring(0, position)
            // далее по циклу ищем совпадения по сокращенному temp

            // проверяем может ли текущая локация быть вложенной в другую, уже существующую
            // если да, в текущую локацию долбавляем площадки, в локации которых она может быть вложена
            while (tempLocation != "")
            {
                foreach (var location in platformsByLocation)
                {
                    // если tempLocation совпадает с локацией в текущей площадке
                    // (если текущая локация locations[i] вложена в сокращённую локацию tempLocation)
                    if (location.Key == tempLocation)
                    {
                        // добавляем в список текущей локации locations[i] список площадок из сокращёной локации tempLocation
                        platformsByLocation[locations[i]].AddRange(location.Value);
                    }
                }

                position = tempLocation.LastIndexOf('/');

                tempLocation = tempLocation[..position];
            }

            // проверяем могут ли в текущую локацию быть вложены другие, уже существующие
            // если да, в уже существующую локацию добавляем площадку текущей локации
            foreach (var location in platformsByLocation)
            {
                var tempLocation2 = location.Key;
                int position2;

                position2 = tempLocation2.LastIndexOf("/");
                tempLocation2 = tempLocation2[..position2];

                while (tempLocation2 != "")
                {

                    if (tempLocation2 == locations[i])
                    {
                        location.Value.Add(advertisingPlatform);
                    }

                    position2 = tempLocation2.LastIndexOf("/");
                    tempLocation2 = tempLocation2[..position2];
                }
            }
        }
    }

    public void AddAdvertisingPlatform(string advertisingPlatformAndLocations)
    {
        var elements = advertisingPlatformAndLocations.Split(':');

        var locations = elements[1].Split(',');

        for (int i = 0; i < locations.Length; i++)
        {
            if (!platformsByLocation.ContainsKey(locations[i]))
            {
                platformsByLocation[locations[i]] = [];
            }

            platformsByLocation[locations[i]].Add(elements[0]);
        }

        UpdatingByNesting(locations, elements[0]);
        //UpdatingByNesting2();
    }

    public List<string> GetPlatformsByLocation(string location)
    {
        return platformsByLocation[location];
    }
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

            if (CheckInput(inputLocation))
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

    //public List<string> GetPlatformsByLocation(string location)
    //{
    //    // по мере выполнения программы location будет изменяться
    //    // чтобы избежать этого заведем временную переменную
    //    string temp = location;
    //    // переменная для хранения позиции символа '/'
    //    int position;
    //    // сюда будем записывать площадки, которые действуют в заданной location
    //    var platforms = new List<string>();

    //    while (temp != "")
    //    {
    //        foreach (var platform in platformsByLocation)
    //        {
    //            // если входящая локация совпадает с локацией в текущей платформе
    //            if (platform.Value.Contains(temp))
    //            {
    //                // добавляем в список
    //                platforms.Add(platform.Key);
    //            }
    //        }

    //        // т.к. локации могут быть вложенными, необходимо постепенно сокращать temp
    //        // пример: было - /ru/sverd, стало /ru
    //        // для этого:
    //        // находим позицию последнего вхождения символа '/'
    //        position = temp.LastIndexOf('/');
    //        // сокращаем temp
    //        temp = temp[..position]; //temp.Substring(0, position)
    //        // далее снова по циклу ищем совпадения по сокращенному temp
    //    }

    //    return platforms;
    //}

    // дял проверки введённой локации

    //public void AddAdvertisingPlatform(string advertisingPlatformAndLocations)
    //{
    //    // разделяем строку на платформу и список локаций
    //    var elements = advertisingPlatformAndLocations.Split(':');

    //    // разделяем список локаций на отдельные локации (если их несколько)
    //    var locations = elements[1].Split(',');

    //    // обозначаем текущую платформу
    //    var currentPlatform = elements[0];

    //    // заполняем словарь данными
    //    if (!platformsByLocation.ContainsKey(currentPlatform))
    //    {
    //        platformsByLocation[currentPlatform] = [];
    //    }

    //    for (int i = 0; i < locations.Length; i++)
    //    {
    //        platformsByLocation[currentPlatform].Add(locations[i]);
    //    }
    //}
}


