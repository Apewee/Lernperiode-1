# 1
My repo



**Heute:6.8.2026**

Erstes Arbeitspacket:
- [x] Mit Console.writeline experiementiert. Erstes mal mit Apis experiementirert und erste data requests gemacht.
Zweites Arbeitspacket:
- [x] Mit .net framework einen funktionierenden api data puller erstellen für ein Online Video spiel namens Albion online (gedanken gang ist hier das sie eine öffentliche api haben welche man einfach anfragen kann)
Drittes Arbeitspacket: 
- [x] Herausfinden wie .Json funktioniert und es mit der richtigen api versuchen (gameinfo.albiononline.com/api/gameinfo)



**Heute:04.08.2026**

Was ich heute gemacht habe: Mich für den Test am mittwoch vorbereitet und alle lernziele durchgeschaut ausserdem habe ich es erstmals geschaft eine verbidung mit einer API herzustellen.

Erstes Arbeitpacket:

- [x] nächste woche dringend alles einrichten um via die Konsole auf die Albiononline api zuzugreifen können

- [x] vielleicht noch versuchen ein simples UI zu plannen




**Heute:11.08.2026**

Was ich heute gemacht habe: Der Api puller funktioniert einwandfrei doch ich habe jetzt ein neues problem. Ich will das man den Namen in die Api suche eingeben kann und man dann automatisch sieht ob der spieler in der vergangenheit in einer "verfeindeten" gilde war. Es gibt keine solche api welche direkt von albion online kommt. 
Muss mir dafür etwas einfallen lassen

Erstes Arbeitspacket:

- [ ] muss nächste woche dringend schauen ob es einen weg gibt die vorgeschichte eines spielers durch die API anzuschauen.

- [ ] falls das geht ein analysierungs command als default einbauen welcher vorher noch fragt ob es schlechte gilden in der vorgeschichte gibt.

**Heute:16.08.2026**

Ich habe heute ein Video zu apis geschaut und selbst den code versucht nachzuschreiben: Das Video bietet eine kompakte Anleitung zur Entwicklung einer RESTful API mit ASP.NET 6.0 anhand einer Hotelbuchungsanwendung. Der Prozess umfasst das Aufsetzen eines Web-API-Projekts in Visual Studio, das Definieren eines Datenmodells sowie die Konfiguration einer In-Memory-Datenbank mittels Entity Framework Core. Abschließend implementiert der Entwickler über einen API-Controller die wesentlichen CRUD-Funktionen für das Erstellen, Abrufen, Bearbeiten und Löschen von Datensätzen, die direkt über die automatisch generierte Swagger-Dokumentation getestet werden können.


- [ ] falls noch zeit vieleicht erkundigen ob man ein schönes UI programmieren kann

**Reflektion auf das projekt**
Obwohl ich schon mit anderen Programmiersprachen code geschrieben habe war es das erste mal das ich mit C# gearbeitet habe und ich hätte vieleicht nicht direkt mit API arbeit anfangen sollen. Die meiste zeit habe ich die API anleitungen auf der Albiononline website zu finden sind versucht zu implementieren (die Dokumentation ist bei weitem nicht ausreichend). Ich habe dann andere github Projekte welche mit der API gearbeitet haben in meine KI hochgeladen und sie hat dann die korrekten links gefunden. Alles in allem bin ich zufrieden das ich mit dem Projekt fertig geworden bin.


# Anleitung

Das Programm funktiniert recht simple: 
Es bezieht daten von der offiziellen API von dem Videospiel Albion Online. Als erstes muss man den Namen des Charackters eingeben von welchem man die PVP XP wissen will (Im beispiel ist das "KasperBombaster"). 

<img width="808" height="141" alt="image" src="https://github.com/user-attachments/assets/967f933e-aa8b-4fa6-97d9-aee237df30d7" />

Es gibt einem dann die Gesammte zahl der XP punkte welche der charackter gesammelt hat.




      
