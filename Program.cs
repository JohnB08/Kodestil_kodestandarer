namespace Kodestil_kodestandarer;

class Program
{
    static void Main(string[] args)
    {
        //Navngi variabler:

        //Vi bruker camelCase for å navni variabler som bare skal eksistere i scopet vi jobber i.

        //Som regel trenger vi bare definere datatypen på en side av deklarasjonstegnet:
        int num = 23;

        //Det er også gyldig å skrive følgende:
        var number = 42;
        //Men da må vi stole på at datamaskinen implicit velger korrekt datatype fra verdien på venstre siden.
        //I tilfellet over, velger datamaskinen at 42 er en integer. 

        //Det samme gjelder når vi definerer kolleksjoner. 
        //Så lenge datatypen kan trygt hentes fra høyre siden av deklarasjonstegnet,
        //Er det helt trygt å bruke var på venstre siden.
        var numList = new List<int>();
        var arr = new int[3];


        //Men hvis vi skal definere en statisk kolleksjon med forhåndsdefinerte verdier,
        //Er det annbefalt fra Microsoft å definere type på venstre side av definisjonstegnet,
        //Så bruke kolleksjonsekpressionen [] for å definere startverdiene av kolleksjonen.
        List<string> names = ["Anders", "John", "Kevin", "Håkon"];

        //Legg merke til at dette kan skape problemer hvis du definerer arrays:
        int[] numArr = [3];
        //I motsettning til arr på linje 23, har vi her definert et array på lengde 1,
        //hvor numArr[0] = 3, 
        //mens på linje 23, definerer vi et array på lengde 3, med default verdier for ints
        //i hver posisjon. 
    }
}
