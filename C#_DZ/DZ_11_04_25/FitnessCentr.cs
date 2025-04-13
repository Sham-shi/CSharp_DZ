
using C__DZ.DZ_11_04_25.Persons;

namespace C__DZ.DZ_11_04_25;

public class FitnessCentr
{
    private List<Client> clients;
    private List<Trainer> trainers;

    public FitnessCentr()
    {
        clients = new List<Client>();
        trainers = new List<Trainer>();
    }

    public void AddClient(Client client)
    {
        clients.Add(client);
    }

    public void RemoveClient(Client client)
    {
        clients.Remove(client);
    }

    public void AddTrainer(Trainer trainer)
    {
        trainers.Add(trainer);
    }

    public void RemoveTrainer(Trainer trainer)
    {
        trainers.Remove(trainer);
    }

    //public void DisplayClients()
    //{
    //    Console.WriteLine("Клиенты:");

    //    foreach (Trainer trainer in trainers)
    //    {
    //        trainer.DisplayInfo();
    //    }
    //}

    //public void DisplayTrainers()
    //{
    //    Console.WriteLine("Тренера:");

    //    foreach (Trainer trainer in trainers)
    //    {
    //        trainer.DisplayInfo();
    //    }
    //}

    public void DisplayAllPerson()
    {
        foreach (Trainer trainer in trainers)
        {
            trainer.DisplayInfo();
        }

        foreach (Client client in clients)
        {
            client.DisplayInfo();
        }
    }
}
