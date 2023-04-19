namespace MonExamen3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création d'un hôtel
            Hotel hotel = new Hotel();

            // Ajout de clients
            Clients client1 = new Clients("Serge", "Abdre", "Sergeandre@gmail.com", "9922 5678 9012 ", 001);
            hotel.ajouterClient(client1);

            Clients client2 = new Clients("Adrienne", "Thedy", "Adriennethedy@gmail.com", "9922 5466 1098", 002);
            hotel.ajouterClient(client2);

            // Affichage des clients
            foreach (Clients client in hotel.clients)
            {
                Console.WriteLine("Nom : " + client.nom);
                Console.WriteLine("Prénom : " + client.prenom);
                Console.WriteLine("Courriel : " + client.courriel);
                Console.WriteLine("Carte de crédit : " + client.carteCredit);
                Console.WriteLine("Numéro de chambre : " + client.numChambre);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
        
   
