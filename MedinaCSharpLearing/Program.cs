//Erfahren was sagt uns der Nutzer,
//Die Infos irgendwo speichern
//Die Infos "stukturiert" ausgeben können -> print

using MedinaCSharpLearing;

new Aufgabe2().test();

void NewFunction() {
    Console.WriteLine("Wie heisst du?");

    var wieHeißtDu = Console.ReadLine();

    Console.WriteLine("Wo wohnst du?");

    var woWohnstDu = Console.ReadLine();

    Console.WriteLine("Wie alt bist du?");

    var wieAltBistDu = Console.ReadLine();


//Dein Name ist NAME, du bist ALTER Jahre alt und du wohnst in ADRESSE.
    Console.WriteLine("Dein Name ist " + wieHeißtDu + ", du bist " + wieAltBistDu + " und du wohnst in " + woWohnstDu + ".");
}