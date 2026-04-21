//Casting ist die Umwandlung von einem Datentyp in einen anderen. 
short a = 10; // Ein short-Wert wird deklariert und mit dem Wert 10 initialisiert.
int b = a; // Der short-Wert a wird implizit in einen int-Wert umgewandelt und in der Variable b gespeichert. Dies ist eine implizite Konvertierung, da int einen größeren Wertebereich als short hat und keine Daten verloren gehen können.

short c = (short)b;
Console.WriteLine(c);

double d = 5.5;
int e = (int)d; // Der double-Wert d wird explizit in einen int-Wert umgewandelt und in der Variable e gespeichert. Dies ist eine explizite Konvertierung, da double einen größeren Wertebereich als int hat und es zu einem Datenverlust kommen kann (die Nachkommastellen gehen verloren).
Console.WriteLine(e);

//casting birgt immer die Gefahr von Datenverlust mit sich, wenn der Zieltyp einen kleineren Wertebereich hat als der Quelltyp. Es ist wichtig, vorsichtig zu sein und sicherzustellen, dass die Werte, die konvertiert werden, innerhalb des gültigen Bereichs des Zieltyps liegen, um unerwartete Ergebnisse oder Fehler zu vermeiden.

//Casting kann zudem zur Laufzeit Fehler verursachen, wenn die Werte nicht kompatibel sind. Zum Beispiel kann das Casten von einem Eltern Objekt zu einem Kind-Objekt zu einem InvalidCastException führen, wenn das Objekt tatsächlich nicht vom Kind-Typ ist. Es ist wichtig, sicherzustellen, dass die Objekte, die gecastet werden, tatsächlich kompatibel sind, um solche Fehler zu vermeiden.

//Die Convert -Klasse bietet Methoden zur sicheren Umwandlung von Datentypen, die eine Ausnahmebehandlung ermöglichen, um Fehler zu vermeiden. Zum Beispiel kann Convert.ToInt32(d) verwendet werden, um einen double-Wert in einen int-Wert umzuwandeln, wobei eine FormatException ausgelöst wird, wenn der Wert nicht konvertierbar ist. Es ist ratsam, die Convert-Klasse zu verwenden, wenn Unsicherheit über die Kompatibilität der Werte besteht, um eine robustere Fehlerbehandlung zu gewährleisten.

//e = (int)"265"; //mit nornmalen casting können wir keine Zeichenfolge in einen int umwandeln, da dies zu einem InvalidCastException führen würde. Um eine Zeichenfolge in einen int umzuwandeln, sollten wir die Convert-Klasse oder die int.Parse-Methode verwenden, die speziell für die Umwandlung von Zeichenfolgen in numerische Werte entwickelt wurden. Zum Beispiel könnte Convert.ToInt32("265") oder int.Parse("265") verwendet werden, um die Zeichenfolge "265" erfolgreich in den int-Wert 265 umzuwandeln.
e = Convert.ToInt32("265");
e = int.Parse("265");

Console.WriteLine(e+5);

//die Try Parse methode erlaubt es uns einen Wert sicher in einen anderen Typ umzuwandeln, ohne dass eine Ausnahme ausgelöst wird, wenn die Umwandlung fehlschlägt. Zum Beispiel könnte int.TryParse("265", out e) verwendet werden, um zu versuchen, die Zeichenfolge "265" in einen int-Wert umzuwandeln. Wenn die Umwandlung erfolgreich ist, wird der konvertierte Wert in der Variable e gespeichert und die Methode gibt true zurück. Wenn die Umwandlung fehlschlägt (z.B. wenn die Zeichenfolge nicht numerisch ist), bleibt der Wert von e unverändert und die Methode gibt false zurück. Dies ermöglicht eine sichere Fehlerbehandlung, ohne dass eine Ausnahme ausgelöst wird.

bool wahrOderFalsch = int.TryParse("jkjkjkj", out int f); // Versucht, die Zeichenfolge "265" in einen int-Wert umzuwandeln. Wenn die Umwandlung erfolgreich ist, wird der konvertierte Wert in der Variable e gespeichert und die Methode gibt true zurück. Wenn die Umwandlung fehlschlägt, bleibt der Wert von e unverändert und die Methode gibt false zurück.
Console.WriteLine(f);
Console.WriteLine(wahrOderFalsch);

//Aufgabe es soll eine zweite Person Name und Alter angeben
//Das Programm soll das Durchschnittsalter der beiden Personen (Person1 aus Aufgabe 1 und Person2) berechnen und ausgeben.

string firstName, lastName, age, email;

Console.WriteLine("Hallo User, bitte gib deinen Vornamen ein: ");
firstName = Console.ReadLine() ?? ""; // Liest die Benutzereingabe für den Vornamen ein und speichert sie in der Variable firstName. Wenn die Eingabe null ist, wird eine leere Zeichenfolge verwendet.
Console.WriteLine("Gib als nächstes deinen Nachnamen ein: ");
lastName = Console.ReadLine() ?? ""; // Liest die Benutzereingabe für den Nachnamen ein und speichert sie in der Variable lastName. Wenn die Eingabe null ist, wird eine leere Zeichenfolge verwendet.
Console.WriteLine("Gib dein Alter ein: ");
age = Console.ReadLine() ?? ""; // Liest die Benutzereingabe für das Alter ein und speichert sie in der Variable age. Wenn die Eingabe null ist, wird eine leere Zeichenfolge verwendet.
Console.WriteLine("Gib deine E-Mail ein: ");
email = Console.ReadLine() ?? ""; // Liest die Benutzereingabe für die E-Mail-Adresse ein und speichert sie in der Variable email. Wenn die Eingabe null ist, wird eine leere Zeichenfolge verwendet.

string firstName2, lastName2, age2, email2;

Console.WriteLine("Hallo User, bitte gib deinen Vornamen ein: ");
firstName2 = Console.ReadLine() ?? ""; // Liest die Benutzereingabe für den Vornamen ein und speichert sie in der Variable firstName. Wenn die Eingabe null ist, wird eine leere Zeichenfolge verwendet.
Console.WriteLine("Gib als nächstes deinen Nachnamen ein: ");
lastName2 = Console.ReadLine() ?? ""; // Liest die Benutzereingabe für den Nachnamen ein und speichert sie in der Variable lastName. Wenn die Eingabe null ist, wird eine leere Zeichenfolge verwendet.
Console.WriteLine("Gib dein Alter ein: ");
age2 = Console.ReadLine() ?? ""; // Liest die Benutzereingabe für das Alter ein und speichert sie in der Variable age. Wenn die Eingabe null ist, wird eine leere Zeichenfolge verwendet.
Console.WriteLine("Gib deine E-Mail ein: ");
email2 = Console.ReadLine() ?? ""; // Liest die Benutzereingabe für die E-Mail-Adresse ein und speichert sie in der Variable email. Wenn die Eingabe null ist, wird eine leere Zeichenfolge verwendet.

double.TryParse(age, out double person1Alter);
double.TryParse(age2, out double person2Alter);
Console.WriteLine("Das Druschnitsalter ist: " + (person1Alter + person2Alter) / 2);
Console.WriteLine("Eine Ändrung");