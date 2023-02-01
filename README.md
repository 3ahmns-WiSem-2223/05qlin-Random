# 05qlin-Random

Unterschied System und UnityEngine:

UnityEngine.Random: Unity bietet eine statische Klasse zum Generieren von pseudo-Zufallswerten und ist einfach zu benutzen. Hier muss man kein Objekt von Data Typ Random instanzieren um es benutzen zu können, sondern ich kann einfach auf die Methoden der Klassen Random mit UnityEngine.Random"MethodenName" zugreifen.

System: Dies ist die Klasse, die von der C#-Sprache bereitgestellt wird, und Unity hat sie einfach mit der gesamten Programmiersprache geerbt. Hier allerdings muss man eine Variable von Data Typ Random instanzieren um darauf zuzugreifen. Der seed Value wird als Anfangswert für die pseudo-Zufallszahl benutzt. Dieser seed Value wird automatisch generiert, damit ich jedes mal andere Zahlen bekomme. 

Beispiel:

UnityEngine:int randomValue = UnityEngine.Random.Range(0, 100);

System:System.Random random = new System.Random();
       int randomNumber = random.Next(0, 100);

Warum könnte man Zufall in Programmieren gebrauchen: Bei Spielen, zum Beispiel: ich habe einen würfel und ich will nach jedem mal würfeln eine andere Zufällige Zahl haben.

Warum ist es sinnvoll den Seed zu setzen: Wenn ich will das jedes mal das Gleiche "zufällige Muster" erzeugt wird. 

Was macht Random.Range: Random.Range gibt mir Zufällige Zahlen zwischen zwei Zahlen, Random.Range(minValue, maxValue), aus.

Unity Version: 2020.3.18f

Visual Studio Version: Visual Studio 2019
