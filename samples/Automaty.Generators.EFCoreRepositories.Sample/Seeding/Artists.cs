namespace Automaty.Generators.EFCoreRepositories.Sample.Seeding
{
	using System.Collections.Generic;
	using System.Linq;
	using Automaty.Generators.EFCoreRepositories.Sample.Entities;

	public static class Artists
	{
		public static IDictionary<string, Artist> Get()
		{
			Artist[] artists =
			{
				new Artist
				{
					Name = "65daysofstatic"
				},
				new Artist
				{
					Name = "Aaron Goldberg"
				},
				new Artist
				{
					Name = "Above & Beyond"
				},
				new Artist
				{
					Name = "Above the Fold"
				},
				new Artist
				{
					Name = "AC/DC"
				},
				new Artist
				{
					Name = "Accept"
				},
				new Artist
				{
					Name = "Adicts"
				},
				new Artist
				{
					Name = "Adrian Leaper & Doreen de Feis"
				},
				new Artist
				{
					Name = "Aerosmith"
				},
				new Artist
				{
					Name = "Aisha Duo"
				},
				new Artist
				{
					Name = "Al di Meola"
				},
				new Artist
				{
					Name = "Alabama Shakes"
				},
				new Artist
				{
					Name = "Alanis Morissette"
				},
				new Artist
				{
					Name = "Alberto Turco & Nova Schola Gregoriana"
				},
				new Artist
				{
					Name = "Alice in Chains"
				},
				new Artist
				{
					Name = "Alison Krauss"
				},
				new Artist
				{
					Name = "Amon Amarth"
				},
				new Artist
				{
					Name = "Amon Tobin"
				},
				new Artist
				{
					Name = "Amr Diab"
				},
				new Artist
				{
					Name = "Amy Winehouse"
				},
				new Artist
				{
					Name = "Anita Ward"
				},
				new Artist
				{
					Name = "Anthrax"
				},
				new Artist
				{
					Name = "Antônio Carlos Jobim"
				},
				new Artist
				{
					Name = "Apocalyptica"
				},
				new Artist
				{
					Name = "Aqua"
				},
				new Artist
				{
					Name = "Armand Van Helden"
				},
				new Artist
				{
					Name = "Arcade Fire"
				},
				new Artist
				{
					Name = "Audioslave"
				},
				new Artist
				{
					Name = "Bad Religion"
				},
				new Artist
				{
					Name = "Barenaked Ladies"
				},
				new Artist
				{
					Name = "BBC Concert Orchestra"
				},
				new Artist
				{
					Name = "Bee Gees"
				},
				new Artist
				{
					Name = "Before the Dawn"
				},
				new Artist
				{
					Name = "Berliner Philharmoniker"
				},
				new Artist
				{
					Name = "Billy Cobham"
				},
				new Artist
				{
					Name = "Black Label Society"
				},
				new Artist
				{
					Name = "Black Sabbath"
				},
				new Artist
				{
					Name = "BLØF"
				},
				new Artist
				{
					Name = "Blues Traveler"
				},
				new Artist
				{
					Name = "Boston Symphony Orchestra & Seiji Ozawa"
				},
				new Artist
				{
					Name = "Britten Sinfonia, Ivor Bolton & Lesley Garrett"
				},
				new Artist
				{
					Name = "Bruce Dickinson"
				},
				new Artist
				{
					Name = "Buddy Guy"
				},
				new Artist
				{
					Name = "Burial"
				},
				new Artist
				{
					Name = "Butch Walker & The Black Widows"
				},
				new Artist
				{
					Name = "Caetano Veloso"
				},
				new Artist
				{
					Name = "Cake"
				},
				new Artist
				{
					Name = "Calexico"
				},
				new Artist
				{
					Name = "Carly Rae Jepsen"
				},
				new Artist
				{
					Name = "Carreras, Pavarotti, Domingo"
				},
				new Artist
				{
					Name = "Cássia Eller"
				},
				new Artist
				{
					Name = "Cayouche"
				},
				new Artist
				{
					Name = "Chic"
				},
				new Artist
				{
					Name = "Chicago "
				},
				new Artist
				{
					Name = "Chicago Symphony Orchestra & Fritz Reiner"
				},
				new Artist
				{
					Name = "Chico Buarque"
				},
				new Artist
				{
					Name = "Chico Science & Nação Zumbi"
				},
				new Artist
				{
					Name = "Choir Of Westminster Abbey & Simon Preston"
				},
				new Artist
				{
					Name = "Chris Cornell"
				},
				new Artist
				{
					Name = "Christopher O'Riley"
				},
				new Artist
				{
					Name = "Cidade Negra"
				},
				new Artist
				{
					Name = "Cláudio Zoli"
				},
				new Artist
				{
					Name = "Coldplay"
				},
				new Artist
				{
					Name = "Creedence Clearwater Revival"
				},
				new Artist
				{
					Name = "Crosby, Stills, Nash, and Young"
				},
				new Artist
				{
					Name = "Daft Punk"
				},
				new Artist
				{
					Name = "Danielson Famile"
				},
				new Artist
				{
					Name = "David Bowie"
				},
				new Artist
				{
					Name = "David Coverdale"
				},
				new Artist
				{
					Name = "David Guetta"
				},
				new Artist
				{
					Name = "deadmau5"
				},
				new Artist
				{
					Name = "Deep Purple"
				},
				new Artist
				{
					Name = "Def Leppard"
				},
				new Artist
				{
					Name = "Deftones"
				},
				new Artist
				{
					Name = "Dennis Chambers"
				},
				new Artist
				{
					Name = "Deva Premal"
				},
				new Artist
				{
					Name = "Dio"
				},
				new Artist
				{
					Name = "Djavan"
				},
				new Artist
				{
					Name = "Dolly Parton"
				},
				new Artist
				{
					Name = "Donna Summer"
				},
				new Artist
				{
					Name = "Dr. Dre"
				},
				new Artist
				{
					Name = "Dread Zeppelin"
				},
				new Artist
				{
					Name = "Dream Theater"
				},
				new Artist
				{
					Name = "Duck Sauce"
				},
				new Artist
				{
					Name = "Earl Scruggs"
				},
				new Artist
				{
					Name = "Ed Motta"
				},
				new Artist
				{
					Name = "Edo de Waart & San Francisco Symphony"
				},
				new Artist
				{
					Name = "Elis Regina"
				},
				new Artist
				{
					Name = "Eminem"
				},
				new Artist
				{
					Name = "English Concert & Trevor Pinnock"
				},
				new Artist
				{
					Name = "Enya"
				},
				new Artist
				{
					Name = "Epica"
				},
				new Artist
				{
					Name = "Eric B. and Rakim"
				},
				new Artist
				{
					Name = "Eric Clapton"
				},
				new Artist
				{
					Name = "Eugene Ormandy"
				},
				new Artist
				{
					Name = "Faith No More"
				},
				new Artist
				{
					Name = "Falamansa"
				},
				new Artist
				{
					Name = "Filter"
				},
				new Artist
				{
					Name = "Foo Fighters"
				},
				new Artist
				{
					Name = "Four Tet"
				},
				new Artist
				{
					Name = "Frank Zappa & Captain Beefheart"
				},
				new Artist
				{
					Name = "Fretwork"
				},
				new Artist
				{
					Name = "Funk Como Le Gusta"
				},
				new Artist
				{
					Name = "Garbage"
				},
				new Artist
				{
					Name = "Gerald Moore"
				},
				new Artist
				{
					Name = "Gilberto Gil"
				},
				new Artist
				{
					Name = "Godsmack"
				},
				new Artist
				{
					Name = "Gonzaguinha"
				},
				new Artist
				{
					Name = "Göteborgs Symfoniker & Neeme Järvi"
				},
				new Artist
				{
					Name = "Guns N' Roses"
				},
				new Artist
				{
					Name = "Gustav Mahler"
				},
				new Artist
				{
					Name = "In This Moment"
				},
				new Artist
				{
					Name = "Incognito"
				},
				new Artist
				{
					Name = "INXS"
				},
				new Artist
				{
					Name = "Iron Maiden"
				},
				new Artist
				{
					Name = "Jagjit Singh"
				},
				new Artist
				{
					Name = "James Levine"
				},
				new Artist
				{
					Name = "Jamiroquai"
				},
				new Artist
				{
					Name = "Jimi Hendrix"
				},
				new Artist
				{
					Name = "Jimmy Buffett"
				},
				new Artist
				{
					Name = "Jimmy Smith"
				},
				new Artist
				{
					Name = "Joe Satriani"
				},
				new Artist
				{
					Name = "John Digweed"
				},
				new Artist
				{
					Name = "John Mayer"
				},
				new Artist
				{
					Name = "Jorge Ben"
				},
				new Artist
				{
					Name = "Jota Quest"
				},
				new Artist
				{
					Name = "Journey"
				},
				new Artist
				{
					Name = "Judas Priest"
				},
				new Artist
				{
					Name = "Julian Bream"
				},
				new Artist
				{
					Name = "Justice"
				},
				new Artist
				{
					Name = "Orchestre de l'Opéra de Lyon"
				},
				new Artist
				{
					Name = "King Crimson"
				},
				new Artist
				{
					Name = "Kiss"
				},
				new Artist
				{
					Name = "LCD Soundsystem"
				},
				new Artist
				{
					Name = "Le Tigre"
				},
				new Artist
				{
					Name = "Led Zeppelin"
				},
				new Artist
				{
					Name = "Legião Urbana"
				},
				new Artist
				{
					Name = "Lenny Kravitz"
				},
				new Artist
				{
					Name = "Les Arts Florissants & William Christie"
				},
				new Artist
				{
					Name = "Limp Bizkit"
				},
				new Artist
				{
					Name = "Linkin Park"
				},
				new Artist
				{
					Name = "Live"
				},
				new Artist
				{
					Name = "Lokua Kanza"
				},
				new Artist
				{
					Name = "London Symphony Orchestra"
				},
				new Artist
				{
					Name = "Los Tigres del Norte"
				},
				new Artist
				{
					Name = "Luciana Souza/Romero Lubambo"
				},
				new Artist
				{
					Name = "Lulu Santos"
				},
				new Artist
				{
					Name = "Lura"
				},
				new Artist
				{
					Name = "Marcos Valle"
				},
				new Artist
				{
					Name = "Marillion"
				},
				new Artist
				{
					Name = "Marisa Monte"
				},
				new Artist
				{
					Name = "Mark Knopfler"
				},
				new Artist
				{
					Name = "Martin Roscoe"
				},
				new Artist
				{
					Name = "Massive Attack"
				},
				new Artist
				{
					Name = "Maurizio Pollini"
				},
				new Artist
				{
					Name = "Megadeth"
				},
				new Artist
				{
					Name = "Mela Tenenbaum, Pro Musica Prague & Richard Kapp"
				},
				new Artist
				{
					Name = "Melanie Fiona"
				},
				new Artist
				{
					Name = "Men At Work"
				},
				new Artist
				{
					Name = "Metallica"
				},
				new Artist
				{
					Name = "M-Flo"
				},
				new Artist
				{
					Name = "Michael Bolton"
				},
				new Artist
				{
					Name = "Michael Tilson Thomas"
				},
				new Artist
				{
					Name = "Miles Davis"
				},
				new Artist
				{
					Name = "Milton Nascimento"
				},
				new Artist
				{
					Name = "Mobile"
				},
				new Artist
				{
					Name = "Modest Mouse"
				},
				new Artist
				{
					Name = "Mötley Crüe"
				},
				new Artist
				{
					Name = "Motörhead"
				},
				new Artist
				{
					Name = "Mumford & Sons"
				},
				new Artist
				{
					Name = "Munkle"
				},
				new Artist
				{
					Name = "Nash Ensemble"
				},
				new Artist
				{
					Name = "Neil Young"
				},
				new Artist
				{
					Name = "New York Dolls"
				},
				new Artist
				{
					Name = "Nick Cave and the Bad Seeds"
				},
				new Artist
				{
					Name = "Nicolaus Esterhazy Sinfonia"
				},
				new Artist
				{
					Name = "Nine Inch Nails"
				},
				new Artist
				{
					Name = "Nirvana"
				},
				new Artist
				{
					Name = "Norah Jones"
				},
				new Artist
				{
					Name = "Nujabes"
				},
				new Artist
				{
					Name = "O Terço"
				},
				new Artist
				{
					Name = "Oasis"
				},
				new Artist
				{
					Name = "Olodum"
				},
				new Artist
				{
					Name = "Opeth"
				},
				new Artist
				{
					Name = "Orchestra of The Age of Enlightenment"
				},
				new Artist
				{
					Name = "Os Paralamas Do Sucesso"
				},
				new Artist
				{
					Name = "Ozzy Osbourne"
				},
				new Artist
				{
					Name = "Paddy Casey"
				},
				new Artist
				{
					Name = "Page & Plant"
				},
				new Artist
				{
					Name = "Papa Wemba"
				},
				new Artist
				{
					Name = "Paul D'Ianno"
				},
				new Artist
				{
					Name = "Paul Oakenfold"
				},
				new Artist
				{
					Name = "Paul Van Dyk"
				},
				new Artist
				{
					Name = "Pearl Jam"
				},
				new Artist
				{
					Name = "Pet Shop Boys"
				},
				new Artist
				{
					Name = "Pink Floyd"
				},
				new Artist
				{
					Name = "Plug"
				},
				new Artist
				{
					Name = "Porcupine Tree"
				},
				new Artist
				{
					Name = "Portishead"
				},
				new Artist
				{
					Name = "Prince"
				},
				new Artist
				{
					Name = "Projected"
				},
				new Artist
				{
					Name = "PSY"
				},
				new Artist
				{
					Name = "Public Enemy"
				},
				new Artist
				{
					Name = "Queen"
				},
				new Artist
				{
					Name = "Queensrÿche"
				},
				new Artist
				{
					Name = "R.E.M."
				},
				new Artist
				{
					Name = "Radiohead"
				},
				new Artist
				{
					Name = "Rancid"
				},
				new Artist
				{
					Name = "Raul Seixas"
				},
				new Artist
				{
					Name = "Raunchy"
				},
				new Artist
				{
					Name = "Red Hot Chili Peppers"
				},
				new Artist
				{
					Name = "Rick Ross"
				},
				new Artist
				{
					Name = "Robert James"
				},
				new Artist
				{
					Name = "London Classical Players"
				},
				new Artist
				{
					Name = "Royal Philharmonic Orchestra"
				},
				new Artist
				{
					Name = "Run DMC"
				},
				new Artist
				{
					Name = "Rush"
				},
				new Artist
				{
					Name = "Santana"
				},
				new Artist
				{
					Name = "Sara Tavares"
				},
				new Artist
				{
					Name = "Sarah Brightman"
				},
				new Artist
				{
					Name = "Sasha"
				},
				new Artist
				{
					Name = "Scholars Baroque Ensemble"
				},
				new Artist
				{
					Name = "Scorpions"
				},
				new Artist
				{
					Name = "Sergei Prokofiev & Yuri Temirkanov"
				},
				new Artist
				{
					Name = "Sheryl Crow"
				},
				new Artist
				{
					Name = "Sir Georg Solti & Wiener Philharmoniker"
				},
				new Artist
				{
					Name = "Skank"
				},
				new Artist
				{
					Name = "Skrillex"
				},
				new Artist
				{
					Name = "Slash"
				},
				new Artist
				{
					Name = "Slayer"
				},
				new Artist
				{
					Name = "Soul-Junk"
				},
				new Artist
				{
					Name = "Soundgarden"
				},
				new Artist
				{
					Name = "Spyro Gyra"
				},
				new Artist
				{
					Name = "Stevie Ray Vaughan & Double Trouble"
				},
				new Artist
				{
					Name = "Stevie Ray Vaughan"
				},
				new Artist
				{
					Name = "Sting"
				},
				new Artist
				{
					Name = "Stone Temple Pilots"
				},
				new Artist
				{
					Name = "Styx"
				},
				new Artist
				{
					Name = "Sufjan Stevens"
				},
				new Artist
				{
					Name = "Supreme Beings of Leisure"
				},
				new Artist
				{
					Name = "System Of A Down"
				},
				new Artist
				{
					Name = "T&N"
				},
				new Artist
				{
					Name = "Talking Heads"
				},
				new Artist
				{
					Name = "Tears For Fears"
				},
				new Artist
				{
					Name = "Ted Nugent"
				},
				new Artist
				{
					Name = "Temple of the Dog"
				},
				new Artist
				{
					Name = "Terry Bozzio, Tony Levin & Steve Stevens"
				},
				new Artist
				{
					Name = "The 12 Cellists of The Berlin Philharmonic"
				},
				new Artist
				{
					Name = "The Axis of Awesome"
				},
				new Artist
				{
					Name = "The Beatles"
				},
				new Artist
				{
					Name = "The Black Crowes"
				},
				new Artist
				{
					Name = "The Black Keys"
				},
				new Artist
				{
					Name = "The Carpenters"
				},
				new Artist
				{
					Name = "The Cat Empire"
				},
				new Artist
				{
					Name = "The Cult"
				},
				new Artist
				{
					Name = "The Cure"
				},
				new Artist
				{
					Name = "The Decemberists"
				},
				new Artist
				{
					Name = "The Doors"
				},
				new Artist
				{
					Name = "The Eagles of Death Metal"
				},
				new Artist
				{
					Name = "The Go! Team"
				},
				new Artist
				{
					Name = "The Head and the Heart"
				},
				new Artist
				{
					Name = "The Jezabels"
				},
				new Artist
				{
					Name = "The King's Singers"
				},
				new Artist
				{
					Name = "The Lumineers"
				},
				new Artist
				{
					Name = "The Offspring"
				},
				new Artist
				{
					Name = "The Police"
				},
				new Artist
				{
					Name = "The Posies"
				},
				new Artist
				{
					Name = "The Prodigy"
				},
				new Artist
				{
					Name = "The Rolling Stones"
				},
				new Artist
				{
					Name = "The Rubberbandits"
				},
				new Artist
				{
					Name = "The Smashing Pumpkins"
				},
				new Artist
				{
					Name = "The Stone Roses"
				},
				new Artist
				{
					Name = "The Who"
				},
				new Artist
				{
					Name = "Them Crooked Vultures"
				},
				new Artist
				{
					Name = "TheStart"
				},
				new Artist
				{
					Name = "Thievery Corporation"
				},
				new Artist
				{
					Name = "Tiësto"
				},
				new Artist
				{
					Name = "Tim Maia"
				},
				new Artist
				{
					Name = "Ton Koopman"
				},
				new Artist
				{
					Name = "Tool"
				},
				new Artist
				{
					Name = "Tori Amos"
				},
				new Artist
				{
					Name = "Trampled By Turtles"
				},
				new Artist
				{
					Name = "Trans-Siberian Orchestra"
				},
				new Artist
				{
					Name = "Tygers of Pan Tang"
				},
				new Artist
				{
					Name = "U2"
				},
				new Artist
				{
					Name = "UB40"
				},
				new Artist
				{
					Name = "Uh Huh Her "
				},
				new Artist
				{
					Name = "Van Halen"
				},
				new Artist
				{
					Name = "Various Artists"
				},
				new Artist
				{
					Name = "Velvet Revolver"
				},
				new Artist
				{
					Name = "Venus Hum"
				},
				new Artist
				{
					Name = "Vicente Fernandez"
				},
				new Artist
				{
					Name = "Vinícius De Moraes"
				},
				new Artist
				{
					Name = "Weezer"
				},
				new Artist
				{
					Name = "Weird Al"
				},
				new Artist
				{
					Name = "Wendy Carlos"
				},
				new Artist
				{
					Name = "Wilhelm Kempff"
				},
				new Artist
				{
					Name = "Yano"
				},
				new Artist
				{
					Name = "Yehudi Menuhin"
				},
				new Artist
				{
					Name = "Yes"
				},
				new Artist
				{
					Name = "Yo-Yo Ma"
				},
				new Artist
				{
					Name = "Zeca Pagodinho"
				},
				new Artist
				{
					Name = "אריק אינשטיין"
				}
			};

			return artists.ToDictionary(x => x.Name, x => x);
		}
	}
}