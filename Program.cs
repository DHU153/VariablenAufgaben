using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        bool programmLaeuft = true;

        while (programmLaeuft)
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("          HAUPTMENÜ");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Variablen und Datentypen");
            Console.WriteLine("2. Benutzer begrüßen");
            Console.WriteLine("3. Addition durchführen");
            Console.WriteLine("4. Namen in Grossbuchstaben");
            Console.WriteLine("5. Wörter kombinieren");
            Console.WriteLine("6. Nettolohn berechnen");
            Console.WriteLine("7. Grundrechenarten");
            Console.WriteLine("8. Variable erhöhen und erniedrigen");
            Console.WriteLine("9. Protein-Schokoriegel kaufen");
            Console.WriteLine("0. Programm beenden");
            Console.WriteLine("=================================");

            Console.Write("Wähle ein Programm: ");
            string auswahl = Console.ReadLine() ?? "";

            Console.Clear();

            switch (auswahl)
            {
                case "1":
                    VariablenUndDatentypen();
                    break;

                case "2":
                    BenutzerBegruessen();
                    break;

                case "3":
                    Addition();
                    break;

                case "4":
                    NameGrossbuchstaben();
                    break;

                case "5":
                    WoerterKombinieren();
                    break;

                case "6":
                    NettolohnBerechnen();
                    break;

                case "7":
                    Grundrechenarten();
                    break;

                case "8":
                    VariableVeraendern();
                    break;

                case "9":
                    SchokoriegelKaufen();
                    break;

                case "0":
                    programmLaeuft = false;
                    Console.WriteLine("Das Programm wird beendet.");
                    break;

                default:
                    Console.WriteLine(
                        "Ungültige Auswahl. Bitte wähle eine Zahl aus dem Menü."
                    );
                    break;
            }

            if (programmLaeuft)
            {
                Console.WriteLine();
                Console.WriteLine(
                    "Drücke ENTER, um zum Hauptmenü zurückzukehren."
                );
                Console.ReadLine();
            }
        }
    }

    static void VariablenUndDatentypen()
    {
        Console.WriteLine("Meine erste eigene Zeile!");
        Console.WriteLine();

        int ganzzahl = 101;

        Console.WriteLine(
            $"Die Variable 'ganzzahl' hat den Typ {ganzzahl.GetType().Name}."
        );

        Console.WriteLine(
            $"Die Variable 'ganzzahl' hat den Wert {ganzzahl}."
        );

        Console.WriteLine();

        decimal kommazahl = 10.1m;

        Console.WriteLine(
            $"Die Variable 'kommazahl' hat den Typ {kommazahl.GetType().Name}."
        );

        Console.WriteLine(
            $"Die Variable 'kommazahl' hat den Wert {kommazahl}."
        );

        Console.WriteLine();

        string text = "Einhunderteins";

        Console.WriteLine(
            $"Die Variable 'text' hat den Typ {text.GetType().Name}."
        );

        Console.WriteLine(
            $"Die Variable 'text' hat den Wert {text}."
        );
    }

    static void BenutzerBegruessen()
    {
        Console.Write("Wie heisst du? ");

        string name = TextEingeben(
            "Der Name darf nicht leer sein: "
        );

        Console.WriteLine($"Herzlich willkommen, {name}!");
    }

    static void Addition()
    {
        Console.WriteLine("Addition von zwei Zahlen");
        Console.WriteLine();

        decimal zahl1 = DezimalzahlEingeben(
            "Was ist die 1. Zahl der Addition? "
        );

        decimal zahl2 = DezimalzahlEingeben(
            "Was ist die 2. Zahl der Addition? "
        );

        decimal summe = zahl1 + zahl2;

        Console.WriteLine(
            $"Das Ergebnis der Addition ist {summe}."
        );
    }

    static void NameGrossbuchstaben()
    {
        Console.Write("Wie heisst du? ");

        string name = TextEingeben(
            "Der Name darf nicht leer sein: "
        );

        Console.WriteLine();
        Console.WriteLine(
            "Dein Name wird unten in Grossbuchstaben angegeben."
        );

        Console.WriteLine(name.ToUpper());
    }

    static void WoerterKombinieren()
    {
        Console.Write(
            "Was ist das 1. Wort der Wortkombination? "
        );

        string wort1 = TextEingeben(
            "Das Wort darf nicht leer sein: "
        );

        Console.Write(
            "Was ist das 2. Wort der Wortkombination? "
        );

        string wort2 = TextEingeben(
            "Das Wort darf nicht leer sein: "
        );

        string kombination = wort1 + wort2;

        Console.WriteLine(
            $"Die Kombination der Wörter ist: {kombination}"
        );
    }

    static void NettolohnBerechnen()
    {
        Console.Write("Wie hoch ist dein Bruttolohn? ");

        decimal bruttolohn = DezimalzahlEingeben(
            "Bitte gib einen gültigen Bruttolohn ein: ",
            darfNegativSein: false
        );

        Console.Write("Wie hoch ist der Steuersatz in Prozent? ");

        decimal steuerProzent = DezimalzahlEingeben(
            "Bitte gib einen gültigen Steuersatz ein: ",
            darfNegativSein: false
        );

        if (steuerProzent > 100)
        {
            Console.WriteLine(
                "Der Steuersatz darf höchstens 100 % betragen."
            );

            return;
        }

        decimal steuerBetrag =
            bruttolohn * steuerProzent / 100;

        decimal netto =
            bruttolohn - steuerBetrag;

        Console.WriteLine(
            $"Steuerbetrag: {steuerBetrag:F2} Franken"
        );

        Console.WriteLine(
            $"Dein Nettolohn beträgt: {netto:F2} Franken"
        );
    }

    static void Grundrechenarten()
    {
        Console.WriteLine(
            "Addition, Subtraktion, Multiplikation und Division"
        );

        Console.WriteLine();

        decimal zahl1 = DezimalzahlEingeben(
            "Gib die 1. Zahl ein: "
        );

        decimal zahl2 = DezimalzahlEingeben(
            "Gib die 2. Zahl ein: "
        );

        decimal addition = zahl1 + zahl2;
        decimal subtraktion = zahl1 - zahl2;
        decimal multiplikation = zahl1 * zahl2;

        Console.WriteLine(
            $"Die Addition von {zahl1} und {zahl2} ergibt: {addition}"
        );

        Console.WriteLine(
            $"Die Subtraktion von {zahl1} und {zahl2} ergibt: {subtraktion}"
        );

        Console.WriteLine(
            $"Die Multiplikation von {zahl1} und {zahl2} ergibt: {multiplikation}"
        );

        if (zahl2 == 0)
        {
            Console.WriteLine(
                "Eine Division durch 0 ist nicht möglich."
            );
        }
        else
        {
            decimal division = zahl1 / zahl2;

            Console.WriteLine(
                $"Die Division von {zahl1} und {zahl2} ergibt: {division}"
            );
        }
    }

    static void VariableVeraendern()
    {
        decimal x = 5m;

        x++;

        Console.WriteLine(
            $"Die Variable 'x' um 1 erhöht ist {x}."
        );

        x--;
        x--;

        Console.WriteLine(
            $"Die Variable 'x' um 2 erniedrigt ist {x}."
        );
    }

    static void SchokoriegelKaufen()
    {
        const decimal preisRiegel = 3.20m;

        Console.WriteLine(
            $"Ein Protein-Schokoriegel kostet {preisRiegel:F2} Franken."
        );

        decimal budget = DezimalzahlEingeben(
            "Wie hoch ist dein Budget in Franken? ",
            darfNegativSein: false
        );

        int maximaleAnzahl =
            (int)Math.Floor(budget / preisRiegel);

        if (maximaleAnzahl == 0)
        {
            Console.WriteLine(
                "Dein Budget reicht leider für keinen Protein-Schokoriegel."
            );

            return;
        }

        Console.WriteLine(
            $"Du kannst höchstens {maximaleAnzahl} "
            + "Protein-Schokoriegel kaufen."
        );

        int anzahlRiegel = GanzeZahlEingeben(
            "Wie viele Protein-Schokoriegel möchtest du kaufen? ",
            1,
            maximaleAnzahl
        );

        decimal gesamtkosten =
            anzahlRiegel * preisRiegel;

        decimal restgeld =
            budget - gesamtkosten;

        Console.WriteLine();

        Console.WriteLine(
            $"Anzahl Riegel: {anzahlRiegel}"
        );

        Console.WriteLine(
            $"Gesamtkosten: {gesamtkosten:F2} Franken"
        );

        Console.WriteLine(
            $"Restgeld: {restgeld:F2} Franken"
        );
    }

    static string TextEingeben(string fehlermeldung)
    {
        while (true)
        {
            string eingabe = Console.ReadLine() ?? "";

            if (!string.IsNullOrWhiteSpace(eingabe))
            {
                return eingabe.Trim();
            }

            Console.Write(fehlermeldung);
        }
    }

    static decimal DezimalzahlEingeben(
        string frage,
        bool darfNegativSein = true
    )
    {
        while (true)
        {
            Console.Write(frage);

            string eingabe = Console.ReadLine() ?? "";

            eingabe = eingabe
                .Trim()
                .Replace(',', '.');

            bool istZahl = decimal.TryParse(
                eingabe,
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out decimal zahl
            );

            if (istZahl && (darfNegativSein || zahl >= 0))
            {
                return zahl;
            }

            Console.WriteLine(
                "Ungültige Eingabe. Bitte gib eine gültige Zahl ein."
            );
        }
    }

    static int GanzeZahlEingeben(
        string frage,
        int minimum,
        int maximum
    )
    {
        while (true)
        {
            Console.Write(frage);

            string eingabe = Console.ReadLine() ?? "";

            bool istGanzeZahl =
                int.TryParse(eingabe, out int zahl);

            if (istGanzeZahl &&
                zahl >= minimum &&
                zahl <= maximum)
            {
                return zahl;
            }

            Console.WriteLine(
                $"Bitte gib eine ganze Zahl zwischen "
                + $"{minimum} und {maximum} ein."
            );
        }
    }
}