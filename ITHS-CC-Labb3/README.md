# Labb 3

Hejsan allihopa!
Hj�rtligt v�lkomna till den tredje och sista labben. Den kommer ocks� att fungera som 
inl�mningsuppgift f�r er som vill ha VG.

## Vad ska vi g�ra?

Vi ska s�tta t�nderna i Dans favorit-patterns. Det �r som ni kanske kommer ih�g �r tv� bygg-patterns

- FluentBuilder, samt
- Factory

Vi ska bygga en fabrik ELLER en fluentbuilder f�r att skapa f�ljande objekt:

```
        public int NoOfRooms { get; set; } = 1;
        public int NoOfWindows { get; set; } = 0;
        public string StreetAdress { get; set; }
        public bool HasSwimmingPool { get; set; }
        public int ParkingSpotsInGarage { get; set; }

        public bool HasGarage => ParkingSpotsInGarage > 0;
```

Denna klass hittar ni i House.cs. Den inneh�ller lite mer roligt, som konstruktorer samt en ToString().

Vi har vissa krav p� det f�rdiga huset:

- Vi m�ste ha minst ett rum.
- Vi f�r inte ha negativt antal f�nster.
- Vi f�r inte ha negativt antal parkeringsplatser.

### FluentBuildern

Var ska vi l�gga logiken f�r att verifiera att kraven ovan �r uppfyllda?

Man skulle kunna l�gga den i antingen Set-metoderna (t.ex. SetNumberOfRooms) eller kanske �nnu 
b�ttre i Build()-metoden. Vi l�gger allts� in logik h�r f�r att st�mma av att 
kraven �r uppfyllda. Om de inte �r uppfyllda kastar vi ett undantag. D� bromsar vi redan
p� detta stadiet att vi g�r vidare i koden med objekt som inte �r korrekt uppbyggt.

### Fabriken

Fabriken fungerar ju lite annorlunda �n FluentBuildern.

Ni f�r h�r definiera upp minst tre olika typer av hus. 
K�per man hus via fabriken f�r man ta vad fabriken erbjuder :)

## Vad kr�vs f�r G?

F�r G kr�vs att ni implementerar minst en av de tv� bygg-patterna n�mnda ovan.

## Vad kr�vs f�r VG?

D� vill jag ha B�GGE patterns implementerade. Dessutom vill jag att det ska testas av. Det 
handlar om en omfattade testning d�r i alla de flesta fallen ska testas av och verifieras.

## Mapp-struktur

Jag tog mig friheten att skapa upp en mappstruktur f�r projektet.

- ITHS-CC-Labb3 inneh�ller i stort sett bara orginalet p� House.cs.
- HouseF ska inneh�lla en eventuell fabrik och dess kod.
- HouseF.Tests ska inneh�lla eventuella tests f�r fabriken.
- HouseFB ska inneh�lla en eventuell FluentBuilders kod.
- HouseFB.Tests ska inneh�lla testen f�r FluentBuildern.

## Hur ska det redovisas?

Lite annorlunda h�r. Eftersom denna uppgiften blir lite st�rre s� vill jag ha en l�nk till 
ett repo p� GitHub. Gl�m d� inte att bjuda in mig till repot om ni har det privat. Skicka sen 
ett mess p� teams med l�nken.

L�gg g�rna till en README.md eller README.txt om ni har n�got ni vill f�rmedla.