# GitHub link
https://github.com/Ryuggu/mobile-dev-exam

# mobile-dev-exam projekt beskrivelse

* Appen kan vise data fra et API.
* Man kan oprette kontakter.
* Kontakterne bliver gemt i en SQLite DB to store data on a phone.
* Der er 3 sider: MainPage, ApiData, og AddContactPage og man kan navigere rundt i dem ved hjælp af en navbar.
* Jeg prøvede at appen til at tjekke om der er internet, men det virker ikke for mig - Model.NetworkCheck.cs og ApiData.xaml.cs

## Demo video
https://www.dropbox.com/s/41bwkfn32afs0fc/xb0YL7WsnG.mp4?dl=0

## Projekt krav:

##### 1. Databinding
    Både MainPage.xaml er bundet med Contact.cs og ApiData.xaml er bundet med ApiContacts.cs
    
##### 2. Opkobling til API (her kan det være en fil man loader, et link til eksisterende API eller et API man selv har lavet)
    ApiData.xaml viser data fra et API - https://jsonplaceholder.typicode.com/users.
    
##### 3. Design implementering (Man må gerne “låne” et flot design fra nettet. Det er implementeringen af designet der giver point)
    Jeg har lavet min egen design. Det er måske ikke lige så smukt som noget man kan finde på nettet, men det er min!
    
##### 4. Brugen af XAML i projektet
    MainPage, ApiData, og AddContactPage
    
##### 5. Crossplatform Udvikling (så man let på et senere tidspunkt kan tilføje endnu en platform)
    Det punkt er lidt forvirrende og jeg er ikke helt sikkert, hvad ud mente med den, men jeg har tilføjet koden til Android - MainActivity.cs og IOS - AppDelegate.cs for at få telefonen til at gemme data i den rigtige folder siden er ikke ens på Android og IOS.
    Jeg ved ikke om det virker siden jeg kunne ikke teste det.
    
##### 6. Navigation (vælg imellem følgende https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/navigation
    MainPage, ApiData, og AddContactPage
