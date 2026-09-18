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

            Console.WriteLine("==========================================");
            Console.WriteLine("                 HAUPTMENÜ");
            Console.WriteLine("==========================================");
            Console.WriteLine("1. Variablen und Datentypen");
            Console.WriteLine("2. Benutzer begrüssen");
            Console.WriteLine("3. Addition durchführen");
            Console.WriteLine("4. Namen in Grossbuchstaben");
            Console.WriteLine("5. Wörter kombinieren");
            Console.WriteLine("6. Nettolohn berechnen");
            Console.WriteLine("7. Grundrechenarten");
            Console.WriteLine("8. Variable erhöhen und erniedrigen");
            Console.WriteLine("9. Protein-Schokoriegel kaufen");
            Console.WriteLine("10. Passwort-Stärke testen");
            Console.WriteLine("11. BMI berechnen");
            Console.WriteLine("12. Zahlen vergleichen");
            Console.WriteLine("13. Gerade oder ungerade prüfen");
            Console.WriteLine("14. Passwort generieren");
            Console.WriteLine("15. Zufallszahl generieren");
            Console.WriteLine("0. Programm beenden");
            Console.WriteLine("==========================================");

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

                case "10":
                    PasswortStaerkeTesten();
                    break;

                case "11":
                    BmiBerechnen();
                    break;

                case "12":
                    ZahlenVergleichen();
                    break;

                case "13":
                    GeradeOderUngerade();
                    break;

                case "14":
                    PasswortGenerieren();
                    break;

                case "15":
                    ZufallszahlGenerieren();
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
            $"Die Variable 'ganzzahl' hat den Typ "
            + $"{ganzzahl.GetType().Name}."
        );

        Console.WriteLine(
            $"Die Variable 'ganzzahl' hat den Wert {ganzzahl}."
        );

        Console.WriteLine();

        decimal kommazahl = 10.1m;

        Console.WriteLine(
            $"Die Variable 'kommazahl' hat den Typ "
            + $"{kommazahl.GetType().Name}."
        );

        Console.WriteLine(
            $"Die Variable 'kommazahl' hat den Wert {kommazahl}."
        );

        Console.WriteLine();

        string text = "Einhunderteins";

        Console.WriteLine(
            $"Die Variable 'text' hat den Typ "
            + $"{text.GetType().Name}."
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

        Console.WriteLine(
            $"Herzlich willkommen, {name}!"
        );
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
            "Dein Name wird unten in Grossbuchstaben angegeben:"
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

        Console.WriteLine();

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

        Console.WriteLine();

        Console.WriteLine(
            $"Die Addition von {zahl1} und {zahl2} ergibt: "
            + $"{addition}"
        );

        Console.WriteLine(
            $"Die Subtraktion von {zahl1} und {zahl2} ergibt: "
            + $"{subtraktion}"
        );

        Console.WriteLine(
            $"Die Multiplikation von {zahl1} und {zahl2} ergibt: "
            + $"{multiplikation}"
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
                $"Die Division von {zahl1} und {zahl2} ergibt: "
                + $"{division}"
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

        decimal gesamteAusgaben = 0;
        int gesamteAnzahlRiegel = 0;
        bool weiterEinkaufen = true;

        Console.WriteLine(
            $"Ein Protein-Schokoriegel kostet "
            + $"{preisRiegel:F2} Franken."
        );

        while (weiterEinkaufen)
        {
            Console.WriteLine();

            decimal budget = DezimalzahlEingeben(
                "Wie hoch ist dein Budget in Franken? ",
                darfNegativSein: false
            );

            int maximaleAnzahl =
                (int)Math.Floor(budget / preisRiegel);

            if (maximaleAnzahl == 0)
            {
                Console.WriteLine(
                    "Dein Budget reicht leider für keinen "
                    + "Protein-Schokoriegel."
                );
            }
            else
            {
                Console.WriteLine(
                    $"Du kannst höchstens {maximaleAnzahl} "
                    + "Protein-Schokoriegel kaufen."
                );

                int anzahlRiegel = GanzeZahlEingeben(
                    "Wie viele Protein-Schokoriegel möchtest "
                    + "du kaufen? ",
                    1,
                    maximaleAnzahl
                );

                decimal gesamtkosten =
                    anzahlRiegel * preisRiegel;

                decimal restgeld =
                    budget - gesamtkosten;

                gesamteAusgaben += gesamtkosten;
                gesamteAnzahlRiegel += anzahlRiegel;

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

            Console.WriteLine();

            Console.Write(
                "Möchtest du nochmals Protein-Schokoriegel "
                + "kaufen? (j/n): "
            );

            string antwort =
                (Console.ReadLine() ?? "").Trim().ToLower();

            if (antwort != "j")
            {
                weiterEinkaufen = false;
            }
        }

        Console.WriteLine();

        Console.WriteLine(
            $"Insgesamt gekaufte Riegel: "
            + $"{gesamteAnzahlRiegel}"
        );

        Console.WriteLine(
            $"Gesamtausgaben: "
            + $"{gesamteAusgaben:F2} Franken"
        );
    }

    static void PasswortStaerkeTesten()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("          PASSWORT-STÄRKE-TEST");
        Console.WriteLine("==========================================");

        Console.WriteLine(
            "Beim Eingeben wird das Passwort mit '*' verdeckt."
        );

        Console.WriteLine(
            "Das Passwort wird nicht gespeichert."
        );

        Console.WriteLine();

        string passwort = PasswortEingeben();

        if (string.IsNullOrEmpty(passwort))
        {
            Console.WriteLine(
                "Das Passwort darf nicht leer sein."
            );

            return;
        }

        bool hatKleinbuchstaben = false;
        bool hatGrossbuchstaben = false;
        bool hatZahl = false;
        bool hatSonderzeichen = false;

        foreach (char zeichen in passwort)
        {
            if (char.IsLower(zeichen))
            {
                hatKleinbuchstaben = true;
            }
            else if (char.IsUpper(zeichen))
            {
                hatGrossbuchstaben = true;
            }
            else if (char.IsDigit(zeichen))
            {
                hatZahl = true;
            }
            else
            {
                hatSonderzeichen = true;
            }
        }

        bool istHaeufigesPasswort =
            IstHaeufigesPasswort(passwort);

        bool hatEinfachesMuster =
            HatEinfachesMuster(passwort);

        int punktzahl =
            BerechnePunktzahl(
                passwort,
                hatKleinbuchstaben,
                hatGrossbuchstaben,
                hatZahl,
                hatSonderzeichen,
                istHaeufigesPasswort,
                hatEinfachesMuster
            );

        Console.WriteLine();
        Console.WriteLine("Auswertung:");
        Console.WriteLine();

        Console.WriteLine(
            $"Länge: {passwort.Length} Zeichen"
        );

        Console.WriteLine(
            passwort.Length >= 8
                ? "✓ Mindestens 8 Zeichen."
                : "✗ Kürzer als 8 Zeichen."
        );

        Console.WriteLine(
            passwort.Length >= 12
                ? "✓ Mindestens 12 Zeichen."
                : "✗ Kürzer als 12 Zeichen."
        );

        if (passwort.Length >= 15)
        {
            Console.WriteLine(
                "✓ Mindestens 15 Zeichen."
            );
        }

        Console.WriteLine(
            hatKleinbuchstaben
                ? "✓ Enthält Kleinbuchstaben."
                : "✗ Keine Kleinbuchstaben."
        );

        Console.WriteLine(
            hatGrossbuchstaben
                ? "✓ Enthält Grossbuchstaben."
                : "✗ Keine Grossbuchstaben."
        );

        Console.WriteLine(
            hatZahl
                ? "✓ Enthält eine Zahl."
                : "✗ Keine Zahl."
        );

        Console.WriteLine(
            hatSonderzeichen
                ? "✓ Enthält ein Sonderzeichen."
                : "✗ Kein Sonderzeichen."
        );

        if (istHaeufigesPasswort)
        {
            Console.WriteLine(
                "⚠ Das Passwort ist sehr häufig."
            );
        }

        if (hatEinfachesMuster)
        {
            Console.WriteLine(
                "⚠ Das Passwort enthält ein einfaches Muster."
            );
        }

        Console.WriteLine();
        Console.WriteLine(
            $"Punktzahl: {punktzahl} von 7"
        );

        Console.WriteLine(
            $"Bewertung: {PasswortBewerten(punktzahl)}"
        );

        double log10Versuche =
            BerechneLog10Versuche(
                passwort,
                hatKleinbuchstaben,
                hatGrossbuchstaben,
                hatZahl,
                hatSonderzeichen,
                istHaeufigesPasswort,
                hatEinfachesMuster
            );

        Console.WriteLine();
        Console.WriteLine(
            "Geschätzte Anzahl benötigter Versuche:"
        );

        Console.WriteLine(
            $"Ungefähr 10^{log10Versuche:F1} Versuche."
        );

        Console.WriteLine();
        Console.WriteLine(
            "Geschätzte Knackzeiten:"
        );

        ZeigeKnackzeiten(log10Versuche);

        Console.WriteLine();

        ZeigeVerbesserungsvorschlaege(
            passwort,
            hatKleinbuchstaben,
            hatGrossbuchstaben,
            hatZahl,
            hatSonderzeichen,
            istHaeufigesPasswort,
            hatEinfachesMuster
        );
    }

    static string PasswortEingeben()
    {
        Console.Write("Passwort: ");

        string passwort = "";

        while (true)
        {
            ConsoleKeyInfo taste =
                Console.ReadKey(intercept: true);

            if (taste.Key == ConsoleKey.Enter)
            {
                Console.WriteLine();
                break;
            }

            if (taste.Key == ConsoleKey.Backspace)
            {
                if (passwort.Length > 0)
                {
                    passwort = passwort.Substring(
                        0,
                        passwort.Length - 1
                    );

                    Console.Write("\b \b");
                }
            }
            else if (taste.Key == ConsoleKey.Escape)
            {
                passwort = "";
                Console.WriteLine();
                break;
            }
            else if (!char.IsControl(taste.KeyChar))
            {
                passwort += taste.KeyChar;
                Console.Write("*");
            }
        }

        return passwort;
    }

    static int BerechnePunktzahl(
        string passwort,
        bool hatKleinbuchstaben,
        bool hatGrossbuchstaben,
        bool hatZahl,
        bool hatSonderzeichen,
        bool istHaeufigesPasswort,
        bool hatEinfachesMuster
    )
    {
        int punktzahl = 0;

        if (passwort.Length >= 8)
        {
            punktzahl++;
        }

        if (passwort.Length >= 12)
        {
            punktzahl++;
        }

        if (passwort.Length >= 15)
        {
            punktzahl++;
        }

        if (hatKleinbuchstaben)
        {
            punktzahl++;
        }

        if (hatGrossbuchstaben)
        {
            punktzahl++;
        }

        if (hatZahl)
        {
            punktzahl++;
        }

        if (hatSonderzeichen)
        {
            punktzahl++;
        }

        if (istHaeufigesPasswort)
        {
            punktzahl -= 3;
        }

        if (hatEinfachesMuster)
        {
            punktzahl -= 2;
        }

        if (punktzahl < 0)
        {
            punktzahl = 0;
        }

        if (punktzahl > 7)
        {
            punktzahl = 7;
        }

        return punktzahl;
    }

    static bool IstHaeufigesPasswort(string passwort)
    {
        string passwortKlein =
            passwort.ToLowerInvariant();

        string[] haeufigePasswoerter =
        {
            "password",
            "passwort",
            "123456",
            "12345678",
            "123456789",
            "1234567890",
            "qwerty",
            "qwertz",
            "abc123",
            "111111",
            "000000",
            "admin",
            "welcome",
            "letmein",
            "iloveyou",
            "m319"
        };

        foreach (string haeufigesPasswort
                 in haeufigePasswoerter)
        {
            if (passwortKlein == haeufigesPasswort)
            {
                return true;
            }
        }

        return false;
    }

    static bool HatEinfachesMuster(string passwort)
    {
        if (passwort.Length < 3)
        {
            return false;
        }

        bool alleZeichenGleich = true;

        for (int i = 1; i < passwort.Length; i++)
        {
            if (passwort[i] != passwort[0])
            {
                alleZeichenGleich = false;
                break;
            }
        }

        if (alleZeichenGleich)
        {
            return true;
        }

        string passwortKlein =
            passwort.ToLowerInvariant();

        string[] einfacheMuster =
        {
            "123",
            "1234",
            "12345",
            "123456",
            "321",
            "4321",
            "54321",
            "654321",
            "abc",
            "abcd",
            "abcdef",
            "qwerty",
            "qwertz",
            "asdf",
            "asdfgh"
        };

        foreach (string muster in einfacheMuster)
        {
            if (passwortKlein == muster)
            {
                return true;
            }
        }

        return false;
    }

    static string PasswortBewerten(int punktzahl)
    {
        if (punktzahl <= 2)
        {
            return "Sehr schwach";
        }
        else if (punktzahl <= 4)
        {
            return "Schwach";
        }
        else if (punktzahl <= 6)
        {
            return "Mittel";
        }
        else
        {
            return "Stark";
        }
    }

    static double BerechneLog10Versuche(
        string passwort,
        bool hatKleinbuchstaben,
        bool hatGrossbuchstaben,
        bool hatZahl,
        bool hatSonderzeichen,
        bool istHaeufigesPasswort,
        bool hatEinfachesMuster
    )
    {
        if (istHaeufigesPasswort)
        {
            return 2;
        }

        if (hatEinfachesMuster)
        {
            return 3;
        }

        int zeichenraum = 0;

        if (hatKleinbuchstaben)
        {
            zeichenraum += 26;
        }

        if (hatGrossbuchstaben)
        {
            zeichenraum += 26;
        }

        if (hatZahl)
        {
            zeichenraum += 10;
        }

        if (hatSonderzeichen)
        {
            zeichenraum += 32;
        }

        if (zeichenraum == 0)
        {
            return 0;
        }

        double log10Zeichenraum =
            Math.Log10(zeichenraum);

        return passwort.Length * log10Zeichenraum;
    }

    static void ZeigeKnackzeiten(
        double log10Versuche
    )
    {
        Console.WriteLine();

        Console.WriteLine(
            "1. Online-Angriff mit Login-Begrenzung:"
        );

        ZeigeZeit(
            log10Versuche,
            100,
            "pro Stunde"
        );

        Console.WriteLine();

        Console.WriteLine(
            "2. Offline-Angriff mit langsamer Prüfung:"
        );

        ZeigeZeit(
            log10Versuche,
            100000,
            "pro Sekunde"
        );

        Console.WriteLine();

        Console.WriteLine(
            "3. Sehr schneller Offline-Angriff:"
        );

        ZeigeZeit(
            log10Versuche,
            1000000000,
            "pro Sekunde"
        );

        Console.WriteLine();

        Console.WriteLine(
            "Die Zeiten sind theoretische Schätzungen."
        );
    }

    static void ZeigeZeit(
        double log10Versuche,
        double versucheProEinheit,
        string einheit
    )
    {
        double log10Sekunden;

        if (einheit == "pro Stunde")
        {
            log10Sekunden =
                log10Versuche
                - Math.Log10(versucheProEinheit)
                + Math.Log10(3600);
        }
        else
        {
            log10Sekunden =
                log10Versuche
                - Math.Log10(versucheProEinheit);
        }

        if (log10Sekunden < 0)
        {
            Console.WriteLine(
                "Weniger als eine Sekunde."
            );

            return;
        }

        if (log10Sekunden < Math.Log10(60))
        {
            double sekunden =
                Math.Pow(10, log10Sekunden);

            Console.WriteLine(
                $"Ungefähr {sekunden:F1} Sekunden."
            );
        }
        else if (log10Sekunden < Math.Log10(3600))
        {
            double minuten =
                Math.Pow(10, log10Sekunden) / 60;

            Console.WriteLine(
                $"Ungefähr {minuten:F1} Minuten."
            );
        }
        else if (log10Sekunden < Math.Log10(86400))
        {
            double stunden =
                Math.Pow(10, log10Sekunden) / 3600;

            Console.WriteLine(
                $"Ungefähr {stunden:F1} Stunden."
            );
        }
        else if (log10Sekunden < Math.Log10(31536000))
        {
            double tage =
                Math.Pow(10, log10Sekunden) / 86400;

            Console.WriteLine(
                $"Ungefähr {tage:F1} Tage."
            );
        }
        else if (log10Sekunden < 15)
        {
            double jahre =
                Math.Pow(10, log10Sekunden)
                / 31536000;

            Console.WriteLine(
                $"Ungefähr {jahre:F1} Jahre."
            );
        }
        else
        {
            double log10Jahre =
                log10Sekunden
                - Math.Log10(31536000);

            Console.WriteLine(
                $"Ungefähr 10^{log10Jahre:F1} Jahre."
            );
        }
    }

    static void ZeigeVerbesserungsvorschlaege(
        string passwort,
        bool hatKleinbuchstaben,
        bool hatGrossbuchstaben,
        bool hatZahl,
        bool hatSonderzeichen,
        bool istHaeufigesPasswort,
        bool hatEinfachesMuster
    )
    {
        Console.WriteLine(
            "Verbesserungsvorschläge:"
        );

        bool vorschlagAngezeigt = false;

        if (passwort.Length < 15)
        {
            Console.WriteLine(
                "- Verwende mindestens 15 Zeichen."
            );

            vorschlagAngezeigt = true;
        }

        if (!hatKleinbuchstaben)
        {
            Console.WriteLine(
                "- Füge Kleinbuchstaben hinzu."
            );

            vorschlagAngezeigt = true;
        }

        if (!hatGrossbuchstaben)
        {
            Console.WriteLine(
                "- Füge Grossbuchstaben hinzu."
            );

            vorschlagAngezeigt = true;
        }

        if (!hatZahl)
        {
            Console.WriteLine(
                "- Füge mindestens eine Zahl hinzu."
            );

            vorschlagAngezeigt = true;
        }

        if (!hatSonderzeichen)
        {
            Console.WriteLine(
                "- Füge ein Sonderzeichen hinzu."
            );

            vorschlagAngezeigt = true;
        }

        if (istHaeufigesPasswort)
        {
            Console.WriteLine(
                "- Verwende kein häufiges Passwort."
            );

            vorschlagAngezeigt = true;
        }

        if (hatEinfachesMuster)
        {
            Console.WriteLine(
                "- Vermeide einfache Muster und Zahlenfolgen."
            );

            vorschlagAngezeigt = true;
        }

        if (!vorschlagAngezeigt)
        {
            Console.WriteLine(
                "Das Passwort erfüllt die Kriterien dieses "
                + "Tests gut."
            );
        }
    }

    static void BmiBerechnen()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("                BMI-RECHNER");
        Console.WriteLine("==========================================");

        Console.WriteLine();

        decimal gewicht = DezimalzahlEingeben(
            "Wie viel wiegst du in Kilogramm? ",
            darfNegativSein: false
        );

        decimal groesse = DezimalzahlEingeben(
            "Wie gross bist du in Metern? ",
            darfNegativSein: false
        );

        if (groesse == 0)
        {
            Console.WriteLine(
                "Die Körpergrösse darf nicht 0 sein."
            );

            return;
        }

        decimal bmi =
            gewicht / (groesse * groesse);

        Console.WriteLine();

        Console.WriteLine(
            $"Dein BMI beträgt {bmi:F2}."
        );

        if (bmi < 18.5m)
        {
            Console.WriteLine(
                "Das Ergebnis liegt im Bereich Untergewicht."
            );
        }
        else if (bmi < 25m)
        {
            Console.WriteLine(
                "Das Ergebnis liegt im Normalbereich."
            );
        }
        else if (bmi < 30m)
        {
            Console.WriteLine(
                "Das Ergebnis liegt im Bereich Übergewicht."
            );
        }
        else
        {
            Console.WriteLine(
                "Das Ergebnis liegt im Bereich Adipositas."
            );
        }

        Console.WriteLine();

        Console.WriteLine(
            "Hinweis: Der BMI ist nur ein grober Richtwert."
        );
    }

    static void ZahlenVergleichen()
    {
        decimal zahl1 = DezimalzahlEingeben(
            "Gib die 1. Zahl ein: "
        );

        decimal zahl2 = DezimalzahlEingeben(
            "Gib die 2. Zahl ein: "
        );

        Console.WriteLine();

        if (zahl1 > zahl2)
        {
            Console.WriteLine(
                $"{zahl1} ist grösser als {zahl2}."
            );
        }
        else if (zahl1 < zahl2)
        {
            Console.WriteLine(
                $"{zahl1} ist kleiner als {zahl2}."
            );
        }
        else
        {
            Console.WriteLine(
                "Die beiden Zahlen sind gleich."
            );
        }
    }

    static void GeradeOderUngerade()
    {
        int zahl = GanzeZahlEingeben(
            "Gib eine ganze Zahl ein: ",
            int.MinValue,
            int.MaxValue
        );

        if (zahl % 2 == 0)
        {
            Console.WriteLine(
                "Die Zahl ist gerade."
            );
        }
        else
        {
            Console.WriteLine(
                "Die Zahl ist ungerade."
            );
        }
    }

    static void PasswortGenerieren()
    {
        const string kleinbuchstaben =
            "abcdefghijklmnopqrstuvwxyz";

        const string grossbuchstaben =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        const string zahlen =
            "0123456789";

        const string sonderzeichen =
            "!@#$%&*+-_?";

        string alleZeichen =
            kleinbuchstaben
            + grossbuchstaben
            + zahlen
            + sonderzeichen;

        int laenge = GanzeZahlEingeben(
            "Wie viele Zeichen soll das Passwort haben? ",
            8,
            64
        );

        Random zufall = new Random();
        char[] passwort = new char[laenge];

        for (int i = 0; i < laenge; i++)
        {
            int position =
                zufall.Next(0, alleZeichen.Length);

            passwort[i] =
                alleZeichen[position];
        }

        Console.WriteLine();

        Console.WriteLine(
            "Generiertes Passwort:"
        );

        Console.WriteLine(
            new string(passwort)
        );

        Console.WriteLine();

        Console.WriteLine(
            "Hinweis: Für echte Konten solltest du einen "
            + "Passwortmanager verwenden."
        );
    }

    static void ZufallszahlGenerieren()
    {
        int minimum = GanzeZahlEingeben(
            "Gib den kleinsten möglichen Wert ein: ",
            int.MinValue,
            int.MaxValue - 1
        );

        int maximum = GanzeZahlEingeben(
            "Gib den grössten möglichen Wert ein: ",
            minimum,
            int.MaxValue
        );

        Random zufall = new Random();

        int zufallszahl =
            zufall.Next(
                minimum,
                maximum == int.MaxValue
                    ? maximum
                    : maximum + 1
            );

        Console.WriteLine();

        Console.WriteLine(
            $"Die Zufallszahl lautet: {zufallszahl}"
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

            if (istZahl &&
                (darfNegativSein || zahl >= 0))
            {
                return zahl;
            }

            Console.WriteLine(
                "Ungültige Eingabe. Bitte gib eine gültige "
                + "Zahl ein."
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
                int.TryParse(
                    eingabe,
                    out int zahl
                );

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