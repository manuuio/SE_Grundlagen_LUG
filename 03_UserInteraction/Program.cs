//User Interaction in allgemeinen ist die Kommunikation zwischen einem Benutzer und einem Computerprogramm. Es umfasst alle Methoden und Technologien, die es einem Benutzer ermöglichen, mit einer Softwareanwendung zu interagieren, um Informationen einzugeben, Befehle auszuführen und Ergebnisse zu erhalten.

Console.WriteLine("Hallo User! Bitte gib ein Wort ein: ");
string? userInput = Console.ReadLine(); // Liest die Benutzereingabe von der Konsole ein und speichert sie in der Variable userInput
Console.WriteLine(userInput); //Ausgabe des im Arbeitsspeicher gespeicherten Worts auf der Konsole


var keyInfo = Console.ReadKey(); // Liest eine einzelne Taste von der Konsole ein und speichert die Informationen über die gedrückte Taste in der Variable keyInfo. Das Objekt ist vom typ ConsoleKeyInfo, das Informationen über die gedrückte Taste enthält, einschließlich des Zeichens, der Modifikatortasten (wie Shift oder Alt) und der Konsolentaste selbst.
var y = keyInfo.KeyChar; // Greift auf die Eigenschaft KeyChar des ConsoleKeyInfo-Objekts zu, um das Zeichen der gedrückten Taste zu erhalten, und speichert es in der Variable y. KeyChar gibt das tatsächliche Zeichen zurück, das durch die gedrückte Taste repräsentiert wird, z.B. 'a' für die Taste A oder '1' für die Taste 1.
//Wenn wir Pfeiltasten oder Funktionstasten drücken, gibt KeyChar und nichts zurück.
var x = keyInfo.Key; // Greift auf die Eigenschaft Key des ConsoleKeyInfo-Objekts zu, um die Konsolentaste zu erhalten, die gedrückt wurde, und speichert sie in der Variable x. Key gibt den Namen der gedrückten Taste zurück, z.B. ConsoleKey.A für die Taste A oder ConsoleKey.F1 für die F1-Taste. Es ist wichtig zu beachten, dass KeyChar und Key unterschiedliche Informationen liefern können, insbesondere bei speziellen Tasten wie Pfeiltasten oder Funktionstasten, die möglicherweise kein direktes Zeichen repräsentieren.
Console.WriteLine(x);

//Baue ein formular mit folgenden Feldern: Vorname, Nachname, Alter, E-Mail-Adresse. Sobald der Benutzer alle Informationen eingegeben hat, soll eine Zusammenfassung der eingegebenen Daten auf der Konsole ausgegeben werden.

string firstName, lastName, age, email;

Console.WriteLine("Hallo User, bitte gib deinen Vornamen ein: ");
firstName = Console.ReadLine() ?? ""; // Liest die Benutzereingabe für den Vornamen ein und speichert sie in der Variable firstName. Wenn die Eingabe null ist, wird eine leere Zeichenfolge verwendet.
Console.WriteLine("Gib als nächstes deinen Nachnamen ein: ");
lastName = Console.ReadLine() ?? ""; // Liest die Benutzereingabe für den Nachnamen ein und speichert sie in der Variable lastName. Wenn die Eingabe null ist, wird eine leere Zeichenfolge verwendet.
Console.WriteLine("Gib dein Alter ein: ");
age = Console.ReadLine() ?? ""; // Liest die Benutzereingabe für das Alter ein und speichert sie in der Variable age. Wenn die Eingabe null ist, wird eine leere Zeichenfolge verwendet.
Console.WriteLine("Gib deine E-Mail ein: ");
email = Console.ReadLine() ?? ""; // Liest die Benutzereingabe für die E-Mail-Adresse ein und speichert sie in der Variable email. Wenn die Eingabe null ist, wird eine leere Zeichenfolge verwendet.

Console.WriteLine($"\n\nVorname: {firstName} \nNachname: {lastName} \nAlter: {age} \nE-Mail: {email} \n\n");


string p2firstName, p2lastName, p2age, p2email;

Console.WriteLine("Hallo User, bitte gib deinen Vornamen ein: ");
p2firstName = Console.ReadLine() ?? ""; // Liest die Benutzereingabe für den Vornamen ein und speichert sie in der Variable firstName. Wenn die Eingabe null ist, wird eine leere Zeichenfolge verwendet.
Console.WriteLine("Gib als nächstes deinen Nachnamen ein: ");
p2lastName = Console.ReadLine() ?? ""; // Liest die Benutzereingabe für den Nachnamen ein und speichert sie in der Variable lastName. Wenn die Eingabe null ist, wird eine leere Zeichenfolge verwendet.
Console.WriteLine("Gib dein Alter ein: ");
p2age = Console.ReadLine() ?? ""; // Liest die Benutzereingabe für das Alter ein und speichert sie in der Variable age. Wenn die Eingabe null ist, wird eine leere Zeichenfolge verwendet.
Console.WriteLine("Gib deine E-Mail ein: ");
p2email = Console.ReadLine() ?? ""; // Liest die Benutzereingabe für die E-Mail-Adresse ein und speichert sie in der Variable email. Wenn die Eingabe null ist, wird eine leere Zeichenfolge verwendet.

Console.WriteLine($"\n\nVorname: {p2firstName} \nNachname: {p2lastName} \nAlter: {p2age} \nE-Mail: {p2email} \n\n");

float.TryParse(age, out float agep1);
float.TryParse(p2age, out float agep2);

Console.WriteLine($"Das Durchschnittsalter beider personen beträgt: {(agep1 + agep2) / 2}");