//Erste Zeile
Console.WriteLine("Meine erste eigene Zeile!");


//Int-Variable
int ganzzahl = 101;
Console.WriteLine("Die Variable 'ganzzahl' hat den Typ " + ganzzahl.GetType()); 
Console.WriteLine("Die Variable 'ganzzahl' hat den Wert " + ganzzahl);


//Deziemal-Variable
decimal kommazahl = 10.1m;
Console.WriteLine("Die Variable 'kommazahl' hat den Typ " + kommazahl.GetType());
Console.WriteLine("Die Variable 'kommazahl' hat den Wert " + kommazahl);


//String-Variable
string text = "Einhunderteins";
Console.WriteLine("Die Variable 'text' hat den Typ " + text.GetType());
Console.WriteLine("Die Variable 'text' hat den Wert " + text);


//Benutzereingaben
Console.Write("Wie heisst du? ");
string name = Console.ReadLine();
Console.WriteLine("Herzlich willkommen, " + name + "!");


//Addition
Console.Write("Was ist die 1. Zahl der Addition? ");
decimal input1 = decimal.Parse(Console.ReadLine());
Console.Write("Was ist die 2. Zahl der Addition? ");
decimal input2 = decimal.Parse(Console.ReadLine());
decimal summe = input1 + input2;
Console.WriteLine("Das Ergebnis der Addition ist " + summe);


//Grossbuchstaben
Console.WriteLine("Dein Name wird unten in Grossbuchstaben angegeben.");
Console.WriteLine(name.ToUpper());


//Wortkombination
Console.WriteLine("Was ist das 1. Wort der Wortkombination?");
string wort1 = Console.ReadLine();
Console.WriteLine("Was ist das 2. Wort der Wortkombination?");
string wort2 = Console.ReadLine();
string kombination = wort1 + wort2;
Console.WriteLine("Die Kombination der Wörter ist: " + kombination);


//Nettolohn berechnen
Console.Write("Wie hoch ist dein Bruttolohn? ");
decimal bruttolohn = decimal.Parse(Console.ReadLine());
Console.Write("Wie hoch ist der Steuersatz in Prozent? ");
decimal steuerProzent = decimal.Parse(Console.ReadLine());
decimal steuerBetrag = bruttolohn * steuerProzent / 100;
decimal netto = bruttolohn - steuerBetrag;
Console.WriteLine("Dein Nettolohn beträgt " + netto);


//Rechenaufgaben
Console.WriteLine("Wir werden eine Addition, eine Subtraktion, eine Multiplikation und eine Division durchführen.");
Console.Write("Gib die 1. Zahl ein: ");
decimal zahl1 = decimal.Parse(Console.ReadLine());
Console.Write("Gib die 2. Zahl ein: ");
decimal zahl2 = decimal.Parse(Console.ReadLine());
decimal addition = zahl1 + zahl2;
decimal subtraktion = zahl1 - zahl2;
decimal multiplikation = zahl1 * zahl2;
decimal division = zahl1 / zahl2;
Console.WriteLine("Die Addition von " + zahl1 + " und " + zahl2 + " ergibt: " + addition);
Console.WriteLine("Die Subtraktion von " + zahl1 + " und " + zahl2 + " ergibt: " + subtraktion);
Console.WriteLine("Die Multiplikation von " + zahl1 + " und " + zahl2 + " ergibt: " + multiplikation);
Console.WriteLine("Die Division von " + zahl1 + " und " + zahl2 + " ergibt: " + division);


//Variable x erhöhen und erniedrigen
decimal x = 5m;
x++;
Console.WriteLine("Die Variable 'x' um 1 erhöht ist " + x);
x--;
x--;
Console.WriteLine("Die Variable 'x' um 2 erniedrigt ist " + x);
x++;
Console.WriteLine("Wie hoch ist die Variable 'x'? ");
decimal xEingabe = decimal.Parse(Console.ReadLine());
if (xEingabe == x)
Console.WriteLine("Die Variable 'x' ist korrekt.");
else
Console.WriteLine("Die Variable 'x' ist nicht korrekt.");
Console.WriteLine("Möchtest du die Lösung sehen? (ja/nein)");
string antwort = Console.ReadLine();
if (antwort.ToLower() == "ja")
Console.WriteLine("Die Variable 'x' ist " + x);
else
Console.WriteLine("Okay, die Lösung wird nicht angezeigt.");


//Protein-Schokoriegel Aufgabe
Console.WriteLine("Ein Protein-Schokoriegel kostet 3.20 Franken.");
Console.Write("Wie hoch ist dein Budget in Franken? ");
decimal budget = decimal.Parse(Console.ReadLine());
decimal preisRiegel = 3.20m;
decimal anzahlRiegel = Math.Floor(budget / preisRiegel);
Console.WriteLine("Du kannst " + anzahlRiegel + " Protein-Schokoriegel kaufen.");
decimal restgeld = budget % preisRiegel;
decimal restgeldGerundet = Math.Round(restgeld, 2);
Console.WriteLine("Nach dem Kauf von " + anzahlRiegel + " Protein-Schokoriegeln hast du noch " + restgeldGerundet + " Franken übrig.");


//End of the program