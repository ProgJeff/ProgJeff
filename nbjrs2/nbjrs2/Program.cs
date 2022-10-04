

int jourDepuisDebutAnnee = 0;

const int MoisAnnee = 12;
int[] joursDansMois = new int[MoisAnnee] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

Console.Write("Entrez le mois courant : ");
int moisCourant = Convert.ToInt32(Console.In.ReadLine());

Console.Write("Entrez le jour courant : ");
int jourCourant = Convert.ToInt32(Console.In.ReadLine());

for (int i = moisCourant - 1; i >= 0;)
{
    if (i == moisCourant - 1)
    {
        jourDepuisDebutAnnee += jourCourant;i--;
    }
    else
    {
        jourDepuisDebutAnnee += joursDansMois[i];
        i--;

    }
}
Console.Write("Il s'est ecouler " + jourDepuisDebutAnnee + " jours depuis le debut de l'annee");
Console.ReadKey();

