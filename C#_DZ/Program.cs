using C__DZ.DZ_11_04_25;
using C__DZ.DZ_11_04_25.Persons;

var client1 = new Client
(
    "Пётр",
    "Петров",
    new ContactInfo
    (
        "petrov@mail.ru",
        "888-888-88-88"
    ),
    MembershipType.DropIn
);
var client2 = new Client
(
    "Анна",
    "Иванова",
    new ContactInfo
    (
        "ivAnna@mail.ru",
        "777-777-77-77"
    ),
    MembershipType.Yearly
);

var trainer1 = new Trainer
(
    "Иван",
    "Сидоров",
    new ContactInfo
    (
        "sid999@gmail.com",
        "999-999-99-99"
    ),
    new List<string>
    {
        "Набор мышечной массы",
        "Реабилитация и восстановление",
        "Увеличение силовых показателей",
        "Увеличение выносливости"
    }
);

var trainer2 = new Trainer
(
    "Светлана",
    "Полякова",
    new ContactInfo
    (
        "svetapol@yandex.ru",
        "666-666-66-66"
    ),
    new List<string>
    {
        "Силовой тренинг",
        "Коррекция осанки",
        "ОФП (общая физическая подготовка)",
        "Йога"
    }
);

var fitnessCentr = new FitnessCentr();

fitnessCentr.AddTrainer(trainer1);
fitnessCentr.AddTrainer(trainer2);

fitnessCentr.AddClient(client1);
fitnessCentr.AddClient(client2);

fitnessCentr.DisplayAllPerson();

var contactInfo = new ContactInfo("vasvas@list.ru", "444-444-44-44");

var client3 = new Client
(
    "Василий",
    "Васильев",
    MembershipType.Monthly
);

client3.Contact = contactInfo;

fitnessCentr.AddClient(client3);

fitnessCentr.DisplayAllPerson();