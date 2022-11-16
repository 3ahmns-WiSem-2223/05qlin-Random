# 05qlin-Random

Unterschied System und UnityEngine:
UnityEngine.Random: Unity bietet eine statische Klasse zum Generieren von Zufallszahlen, was bedeutet, dass Sie kein Objekt in Ihrem Code instanziieren müssen, um es zu verwenden. Verwenden Sie einfach diese Klasse und ihre Methoden, um die Art von Zahlen zu generieren, die Sie für Ihr Spiel benötigen.
System: Dies ist die Klasse, die von der C#-Sprache bereitgestellt wird, und Unity hat sie einfach mit der gesamten Programmiersprache geerbt. In diesem Fall müssen Sie ein Objekt instanziieren und es ähnlich wie Unity verwenden und Zufallszahlen in Ihrem Spiel generieren.

Beispiel:

Warum könnte man Zufall in Programmieren gebrauchen: Bei Spielen zum Beispiel, ich habe einen würfel und ich will nach jedem mal würfeln eine andere Zufällige Zahl haben.

Warum ist es sinnvoll den Seed zu setzen:Wenn ich überprüfen will ob mein Random überhaupt funktioniert oder nicht.

Was macht Random.Range: Random.Range gibt mir Zufällige zahlen von Random.Range(minValue, maxValue) aus.
