namespace MedinaCSharpLearing;

public class Aufgabe2 {
    public void test() {
        //Arbeit mit STRINGS
        // VERZWEIGUNGEN ->  IF ABFRAGEN

        //Alles was text ist -> String = text

        //ARRAY -> Feste Menge an Elementen


        Console.WriteLine("Wie viel Uhr ist es?");
        var anwort = Console.ReadLine().Split(" "); // 2 0
        var stunde = anwort[0];
        var minute = anwort[1];


        var diesIstEinString = "Der Text wird geteilt!";

        var befehl = diesIstEinString.Split(" ")[2];

        Console.WriteLine(befehl);
    }
}