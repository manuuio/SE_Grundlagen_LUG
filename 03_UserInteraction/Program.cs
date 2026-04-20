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