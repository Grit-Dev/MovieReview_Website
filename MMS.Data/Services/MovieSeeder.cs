using System;
using MMS.Data.Models; //Using data model Models


namespace MMS.Data.Services
{
    public static class MovieSeeder
    {
        public static void Seed(IMovieService svc)
        {
            svc.Initialise();

            // ----------------------------------------------- Thriller Movies -----------------------------------------------------------------

            //Using this class to seed the database with the data below: 
           
            var movie1 = new Movie()
            {
                Title = "OldBoy",
                Director = "Park Chan-Wook",
                Year = 2003,
                Duration = 120,
                Budget = 3000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/pWDtjs568ZfOTMbURQBYuT4Qxka.jpg",
                Genre = Genre.Thriller,
                Cast = "Choi Min - sik, Yoo Ji - tae, Kang Hye - jung, Kim Byung - ok",
                Plot = "With no clue how he came to be imprisoned, drugged and tortured for 15 years, a desperate businessman seeks revenge on his captors."

            };

            svc.AddMovie(movie1); // Adding movie1 to the db

            var movie2 = new Movie()
            {
                Title = "Joker",
                Director = "Todd Philips",
                Year = 2019,
                Duration = 122,
                Budget = 55000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/udDclJoHjfjb8Ekgsd4FDteOkCU.jpg",
                Genre = Genre.Thriller,
                Cast = "Joaquin Phonix, Robert De Niro, Zazie Beetz, Frances Conroy",
                Plot = "During the 1980s, a failed stand-up comedian is driven insane and turns to a life of crime and chaos in Gotham City while becoming an infamous psychopathic crime figure."

            };

            svc.AddMovie(movie2); // Adding movie2 to the db

            var movie3 = new Movie()
            {
                Title = "Donnie Darko",
                Director = "Richard Kelly",
                Year = 2001,
                Duration = 114,
                Budget = 6000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/fhQoQfejY1hUcwyuLgpBrYs6uFt.jpg",
                Genre = Genre.Thriller,
                Cast = "Jake Gyllenhall, Jena Malone, Drew Barrymore, James Duval",
                Plot = "After narrowly escaping a bizarre accident, a troubled teenager is plagued by visions of a large bunny rabbit that manipulates him to commit a series of crimes."

            };

            svc.AddMovie(movie3); // Adding movie3 to the db

            var movie4 = new Movie()
            {
                Title = "The Prestige",
                Director = "Christopher Nolan",
                Year = 2006,
                Duration = 130,
                Budget = 40000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/Ag2B2KHKQPukjH7WutmgnnSNurZ.jpg",
                Genre = Genre.Thriller,
                Cast = "Christian Bale, Hugh Jackman, Michael Caine, Scarleet Johansson",
                Plot = "A mysterious story of two magicians whose intense rivalry leads them on a life-long battle for supremacy -- full of obsession, deceit and jealousy with dangerous and deadly consequences."

            };

            svc.AddMovie(movie4); // Adding movie4 to the db

            var movie5 = new Movie()
            {
                Title = "Hannibal",
                Director = "Ridlewy Scott",
                Year = 2001,
                Duration = 131,
                Budget = 8700000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/v5wAZwRqpGWmyAaaJ8BBHYuNXnj.jpg",
                Genre = Genre.Thriller,
                Cast = "Anythony Hopkins, Julianne Moore, Francesca Neri, Gary Oldman",
                Plot = "After having successfully eluded the authorities for years, Hannibal peacefully lives in Italy in disguise as an art scholar. Trouble strikes again when he's discovered leaving a deserving few dead in the process. He returns to America to make contact with now disgraced Agent Clarice Starling, who is suffering the wrath of a malicious FBI rival as well as the media."

            };

            svc.AddMovie(movie5); // adding movie5 to the db

            // ----------------------------------------------- Action Movies -----------------------------------------------------------------

            var movie6 = new Movie
            {
                Title = "Mad Max: Fury Road",
                Director = "George Miller",
                Year = 2015,
                Duration = 121,
                Budget = 150000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/8tZYtuWezp8JbcsvHYO0O46tFbo.jpg",
                Genre = Genre.Action,
                Cast = "Tom Hardy, Charlize Theron, Nicholas Hoult, Hugh Keays-Byrne",
                Plot = "An apocalyptic story set in the furthest reaches of our planet, in a stark desert landscape where humanity is broken, and most everyone is crazed fighting for the necessities of life. Within this world exist two rebels on the run who just might be able to restore order."
            };

            svc.AddMovie(movie6); //adding movie 7 to the db;

            var Movie7 = new Movie
            {
                Title = "Baby Driver",
                Director = "Edgar Wright",
                Year = 2017,
                Duration = 113,
                Budget = 34000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/rmnQ9jKW72bHu8uKlMjPIb2VLMI.jpg",
                Genre = Genre.Action,
                Cast = "Ansel Elgort, Kevein Spacey, Lily James, Jon Hamm",
                Plot = "After being coerced into working for a crime boss, a young getaway driver finds himself taking part in a heist doomed to fail."
            };

            svc.AddMovie(Movie7); // adding movie7 to the db

            var Movie8 = new Movie
            {
                Title = "Blade Runner 2049",
                Director = "Denis Willeneuve",
                Year = 2017,
                Duration = 164,
                Budget = 150000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/gajva2L0rPYkEWjzgFlBXCAVBE5.jpg",
                Genre = Genre.Action,
                Cast = " Ryan Goslin, Harrison Ford, Ana de Armas, Sylvia Hoeks",
                Plot = " Thirty years after the events of the first film, a new blade runner, LAPD Officer K, unearths a long-buried secret that has the potential to plunge what's left of society into chaos. K's discovery leads him on a quest to find Rick Deckard, a former LAPD blade runner who has been missing for 30 years."
            };

            svc.AddMovie(Movie8); // adding movie8 to the db

            var movie9 = new Movie
            {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Year = 2008,
                Duration = 152,
                Budget = 185000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/qJ2tW6WMUDux911r6m7haRef0WH.jpg",
                Genre = Genre.Action,
                Cast = "Christian Bale, Heath Ledger, Miche Caine, Gary Oldman",
                Plot = "Batman raises the stakes in his war on crime. With the help of Lt. Jim Gordon and District Attorney Harvey Dent, Batman sets out to dismantle the remaining criminal organizations that plague the streets. The partnership proves to be effective, but they soon find themselves prey to a reign of chaos unleashed by a rising criminal mastermind known to the terrified citizens of Gotham as the Joker."


            };

            svc.AddMovie(movie9); // adding movie9 to the db

            var movie10 = new Movie
            {
                Title = "John Wick",
                Director = "David Leitch",
                Year = 2014,
                Duration = 104,
                Budget = 20000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/fZPSd91yGE9fCcCe6OoQr6E3Bev.jpg",
                Genre = Genre.Action,
                Cast = "Keanu Reeves, Michael Nyqvist, Alifie Allen, Willem Dafoe",
                Plot = "Ex-hitman John Wick comes out of retirement to track down the gangsters that took everything from him."
            };

            svc.AddMovie(movie10); //adding movie10 to the db

            //----------------------------------- Sci FI Movies -------------------------------------------------------

            var movie11 = new Movie
            {
                Title = "SnowPiercer",
                Director = "Bong Joon-ho",
                Year = 2013,
                Duration = 127,
                Budget = 39200000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/nzccOvhrLGI0nvAknCEAk8bchD9.jpg",
                Genre = Genre.SciFi,
                Cast = "CHris Evans, Song Kang-ho, Ed Harris, John Hurt, Tilda Swinton",
                Plot = "In a future where a failed global-warming experiment kills off most life on the planet, a class system evolves aboard the Snowpiercer, a train that travels around the globe via a perpetual-motion engine"

            };

            svc.AddMovie(movie11); // adding movie11 to the db

            var movie12 = new Movie
            {
                Title = "Eternal Sunshine Of THe Spotless Mind",
                Director = "Michel Gondry",
                Year = 2004,
                Duration = 108,
                Budget = 20000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/xFuIVB1aPb29vq0G0X9E5p7LuhN.jpg",
                Genre = Genre.SciFi,
                Cast = "Jim Carrey, Kate Winslet, Mark Ruffalo, Eijah Wood",
                Plot = "Joel Barish, heartbroken that his girlfriend underwent a procedure to erase him from her memory, decides to do the same. However, as he watches his memories of her fade away, he realises that he still loves her, and may be too late to correct his mistake."

            };

            svc.AddMovie(movie12); // adding movie12 to the db

            var movie13 = new Movie
            {
                Title = "A.I Artifical Intelligence",
                Director = "Steven Spielberg",
                Year = 2001,
                Duration = 166,
                Budget = 100000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/wnUAcUrMRGPPZUDroLeZhSjLkuu.jpg",
                Genre = Genre.SciFi,
                Cast = " Haley Joel, Francess O`Connor, Sam Robards, Jake Thomas, Jude Law",
                Plot = "David, a robotic boy—the first of his kind programmed to love—is adopted as a test case by a Cybertronics employee and his wife. Though he gradually becomes their child, a series of unexpected circumstances make this life impossible for David. Without final acceptance by humans or machines, David embarks on a journey to discover where he truly belongs, uncovering a world in which the line between robot and machine is both vast and profoundly thin."
            };

            svc.AddMovie(movie13); // adding movie13 to the db

            var movie14 = new Movie
            {
                Title = "Guardians Of The Galaxy",
                Director = "James Gunn",
                Year = 2014,
                Duration = 121,
                Budget = 170000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/r7vmZjiyZw9rpJMQJdXpjgiCOk9.jpg",
                Genre = Genre.SciFi,
                Cast = "Chris Pratt, Zoe Saldana, Dave Bautista, Vin Diesel, Bradley Cooper",
                Plot = "Light years from Earth, 26 years after being abducted, Peter Quill finds himself the prime target of a manhunt after discovering an orb wanted by Ronan the Accuser."
            };

            svc.AddMovie(movie14); // adding movie14 to the db

            var movie15 = new Movie
            {
                Title = "Interstellar",
                Director = "Christopher Nolan",
                Year = 2014,
                Duration = 169,
                Budget = 165000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/gEU2QniE6E77NI6lCU6MxlNBvIx.jpg",
                Genre = Genre.SciFi,
                Cast = "Matthew McConaughey, Jessca Chastain, Anne Hathaway, Michael Caine, Casey Affleck, Machkenzie Foy",
                Plot = "The adventures of a group of explorers who make use of a newly discovered wormhole to surpass the limitations on human space travel and conquer the vast distances involved in an interstellar voyage."
            };

            svc.AddMovie(movie15); // adding movie15 to the db

            //---------------------------- War Movies ---------------------------------------------------------------------------

            var movie16 = new Movie
            {
                Title = "Inglourious Basterds",
                Director = "Quentin Tarantino",
                Year = 2009,
                Duration = 153,
                Budget = 70000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/7sfbEnaARXDDhKm0CZ7D7uc2sbo.jpg",
                Genre = Genre.War,
                Cast = "Vrad Pitt, Melanie Laruent, Christoph Waltz, Eli Roth, Michel Fassbender, Diane Kruger, Daniel Bruhl, Til Schweger",
                Plot = "In Nazi-occupied France during World War II, a group of Jewish-American soldiers known as `The Basterds` are chosen specifically to spread fear throughout the Third Reich by scalping and brutally killing Nazis. The Basterds, lead by Lt. Aldo Raine soon cross paths with a French-Jewish teenage girl who runs a movie theater in Paris which is targeted by the soldiers."
            };

            svc.AddMovie(movie16); // adding movie 16 to the db

            var movie17 = new Movie
            {
                Title = "Full Metal Jacket",
                Director = "Stanley Kubrick",
                Year = 1987,
                Duration = 117,
                Budget = 30000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/kMKyx1k8hWWscYFnPbnxxN4Eqo4.jpg",
                Genre = Genre.War,
                Cast = "Matthew Modine, Adam Baldwin, Vincent D1Onofrio, R.Lee Ermey, Dorian Harewood, Arliss Howard",
                Plot = "A pragmatic U.S. Marine observes the dehumanizing effects the U.S.-Vietnam War has on his fellow recruits from their brutal boot camp training to the bloody street fighting in Hue."
            };

            svc.AddMovie(movie17); // adding movie17 to the db

            var movie18 = new Movie
            {
                Title = "Letters From Iwo Jima",
                Director = "Clint Eastwood",
                Year = 2006,
                Duration = 141,
                Budget = 19000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/kZokxQtzMPURvijWYFuvh1fAvnv.jpg",
                Genre = Genre.War,
                Cast = "Ken Watanabe, Kazunari Ninomiya, Tsuyoshi Ihara, Ryo Kase, Shido Nakamura, Hiroshi Watanabe",
                Plot = "The story of the battle of Iwo Jima between the United States and Imperial Japan during World War II, as told from the perspective of the Japanese who fought it."
            };

            svc.AddMovie(movie18); // adding movie18 to the db

            var movie19 = new Movie
            {
                Title = "1917",
                Director = "Sam Mendes",
                Year = 2019,
                Duration = 119,
                Budget = 100000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/iZf0KyrE25z1sage4SYFLCCrMi9.jpg",
                Genre = Genre.War,
                Cast = "George MacKay, Dean-Charles CHapman, Mark Strong, Andrew Scott, Rishard Madden, Claire Dubruq, Colin Firth, Benedict CumberBatch, Daniel Mays",
                Plot = "At the height of the First World War, two young British soldiers must cross enemy territory and deliver a message that will stop a deadly attack on hundreds of soldiers."
            };

            svc.AddMovie(movie19); // adding movie19 to the db

            var movie20 = new Movie
            {
                Title = "Saving Private Ryan",
                Director = "Steven Spielberg",
                Year = 1998,
                Duration = 169,
                Budget = 70000000.00,
                PosterUrl = "https://www.themoviedb.org/t/p/w1280/1wY4psJ5NVEhCuOYROwLH2XExM2.jpg",
                Genre = Genre.War,
                Cast = "Tom Hanks, Matt Damon, Tom Sizemore, Edward Burns, Barry Pepper, Adam GoldBerg, Vin Diesel, Giovanni Ribisi, Ted Danson",
                Plot = "As U.S. troops storm the beaches of Normandy, three brothers lie dead on the battlefield, with a fourth trapped behind enemy lines. Ranger captain John Miller and seven men are tasked with penetrating German-held territory and bringing the boy home."
            };

            svc.AddMovie(movie20); // adding movie20 to the db




            // ----------------------------------------- Adding Reviews -------------------------------------------------------------

            //Thriller movie revies
     

            Review r1 = new Review //Creating review
            {
                Id = movie1.Id, //For movie1 - using the UniqueID create by the db or movie1 
                Name = "Ely",
                CreatedOn = new DateTime(2013, 06, 14),
                Comment = "I’m sure that all of you can always spot a film with good acting, superb plot and great cinematography easily but when it comes to a thriller that possesses all those above quality, it would be such a rarity. OldBoy here, second installment from The Vengeance Trilogy directed by Park Chan-wook (Sympathy for Mr. Vengeance, OldBoy, Sympathy for Lady Vengeance) really have them all, good story, powerful acting and the most horrifying and clever end twist if not genius. In fact no matter how many times you see this, the twist would still be awesome. The theme of revenge here is taken to the next level, to its supremacy for it’s really carefully-planned." +
                " OldBoy has a mind-bending assortment of drama, thriller, romance and beautifully spiced up with sadistic plot, shocking elements, ultra violence and clever psychological twist. Imagine yourself captured, locked in a room for 15 years, not knowing why and who did it and when you finally escaped and thought it’s all over, you were wrong and here’s the punching line, the direct punch to your stomach. Min-sik Choi as Oh Dae su really acted well, he really got us carried away by dragging us into the mystery that surrounds his life, into the depression he’s been feeling and into the deep well of his curiosity. Once again, OldBoy is a way too remarkable, when “revenge” isn’t merely knife-chopping or gun-battling. " +
                "Enough said",
                Rating = 8


            };

            svc.AddReview(r1); // Adding review 1 to the db

            Review r2 = new Review // Creating review for movie2
            {
                Id = movie2.Id,
                Name = "Per Gunnar Jonsson",
                CreatedOn = new DateTime(2020, 02, 19),
                Comment = "The Joker is similar to the DC Joker character but is not a criminal genius. The movie was a great depiction of how a person who has been mistreated, lied to, and ignored, totally lacking access to human compassion, can snap. " +
                "The acting is top notch, and it puts a spotlight on the importance of mental health in modern times.",
                Rating = 8
            };

            svc.AddReview(r2); // Adding review 2 to db

            Review r3 = new Review
            {
                Id = movie3.Id,
                Name = "Mark B",
                CreatedOn = new DateTime(2020, 10, 28),
                Comment = "A complete mind-bender of a movie that put Jake Gyllenhall on the map, introduced the creepiest rabbit costume of all time, and may make you surprisingly tear up to a remake of Tears for Fears `Mad World.`",
                Rating = 9
            };

            svc.AddReview(r3); // Adding review 3 to db

            Review r4 = new Review
            {
                Id = movie4.Id,
                Name = "Izgzhen",
                CreatedOn = new DateTime(2018, 01, 14),
                Comment = "Perplexed by the storyline at the beginning, deeply attracted to the narratives of the intense rivalry between two actors in the main body of the show, and finally shocked by the revealed truth, or The Prestige in the end. " +
                "This is one of the most mind-blowing mysteries that I've watched in recent years. One of the best part, I think, is how the characters of two young magicians are depicted-- through small but noticeable details like the facial expressions, " +
                " one or two words, the novels et cetera. In fact, the title of the movie, even being explained by Cutter in the beginning, still puzzles me and I can't stopped thinking about the meaning of it. Not to mention other puzzles. But ultimately, I came to realize that the plot structure corresponds to a epic magic show as well.",
                Rating = 9
            };

            svc.AddReview(r4); // Adding review 4 to the db

            Review r5 = new Review
            {
                Id = movie5.Id,
                Name = "Gimly",
                CreatedOn = new DateTime(2020, 06, 10),
                Comment = "Certainly the weakest of the Anthony Hopkins Hannibal movies. Having read the books before I watched the movies, that actually does sort of track, as the first two books were better than the third. Even so, I actually think Hannibal does the worst job of adapting the source material too. " +
                "Looks pretty good and there's quite the cast list (although I don't think many of them are exactly giving career-defining performances here), Julianne Moore is fine as Clarice Starling (although not as good as Jodie Foster), and the story isn't bad, but if I'm being honest, I typically give this one a skip whenever I'm revisiting the Lecter mythos.",
                Rating = 6
            };

            svc.AddReview(r5); //Adding review 5 to the db


            // ----------------------------------- Action Movies Reviews ---------------------------------------------------------------------


            Review r6 = new Review
            {
                Id = movie6.Id,
                Name = "Cineport",
                CreatedOn = new DateTime(2015 - 09 - 6),
                Comment = "Fantastic action that makes up for some plot holes.",
                Rating = 9
            };

            svc.AddReview(r6); // Adding review6 to the db

            Review r7 = new Review
            {
                Id = Movie7.Id,
                Name = "Highhorse",
                CreatedOn = new DateTime(2018, 06, 18),
                Comment = "Extremely stylish, anime inspired superb action film. Edgar Wright knows what he's doing.",
                Rating = 7
            };

            svc.AddReview(r7); // Adding review7 to the db 

            Review r8 = new Review
            {
                Id = Movie8.Id,
                Name = "Gimly",
                CreatedOn = new DateTime(2017,10,27),
                Comment = "Strikes a true balance between new and old. Denis Villeneuve has a perfect filmmaking record in my mind, and Blade Runner 2049 continues that trend with aplomb.",
                Rating = 8

            };

            svc.AddReview(r8); // Adding review8 to the db

            Review r9 = new Review
            {
                Id = movie9.Id,
                Name = "Talisencrw",
                CreatedOn = new DateTime(2016, 05, 25),
                Comment = "This has no competition. It is the very finest comic-book character movie ever made. Knowing the Burton, Donner and Nolan filmic adaptations of Batman and Superman exist helps me to sleep at night. They are Exhibit A of 'How to Make a Comic-Book Movie'. Nothing else has ever come even remotely close. " +
                "These seven films (I include 'Superman II' because it was mostly Donner's work)--and Nolan's trilogy especially--are what I imagine a great director like Kubrick, Hitchcock or Kurosawa would have come up with, if they had ever been asked to make a Superman or Batman movie. They are the easiest for an audience to " +
                "identify with because in these the scripts most approximate human emotions and the typical conundrums of the human experience--in short, are the closest, in a good way, they come to the complexities of the human condition. Peerless.",
                Rating = 10
            };

            svc.AddReview(r9); // Adding review9 to db

            Review r10 = new Review
            {
                Id = movie10.Id,
                Name = "CuriousAstronaut",
                CreatedOn = new DateTime(2017, 02, 25),
                Comment = "John Wick is an excellent revenge action movie that raises the bar with its excellent lighting, cinematography, and martial arts displays from Keanu. Mr Wick spends the rest of the film getting even with a mob boss for the actions of his son who killed his dog and stole his car. As far as the plot goes, its pretty simple but there is a lot of depth to the world. " +
                "Reeves displays a decent amount of acting range here, but his real talent is bringing bad guys down one headshot at a time. Its glorious to see him smack a guy over the head, hold him down while reloading, and then take him out. The best thing about this film is the lack of shaky cam-- you can see all the action happening clearly. This is made possible by the dedication of the actors in their martial arts training. " +
                "Support films like this, they are a rare breed these days!",
                Rating = 9

            };

            svc.AddReview(r10); // Adding review10 to db


            //--------------------------------------- Sci FI Movie reviews -----------------------------------------------------

            Review r11 = new Review
            {
                Id = movie11.Id,
                Name = "Gimly",
                CreatedOn = new DateTime(2018, 10, 8),
                Comment = "Original IP Post-Apocalyptia as well as the 21st century can possibly dish it out.",
                Rating = 8
            };

            svc.AddReview(r11); // Adding review11 to db

            Review r12 = new Review
            {
                Id = movie12.Id,
                Name = "LovingStory",
                CreatedOn = new DateTime(2021, 02, 17),
                Comment = "This was one of the first movies I really loved. Some moments are especially beautiful and I appreciate the folks who put in the labor to make this. Thank you",
                Rating = 10
            };

            svc.AddReview(r12); // Adding review12 to db

            Review r13 = new Review
            {
                Id = movie13.Id,
                Name = " Graham Hanock",
                CreatedOn = new DateTime(2019, 01, 05),
                Comment = "A big salute to Steven Spielberg, Such a great filmmaker he is , one cannot scale down how such a complexive plot could be executed by superb perfection , it takes great directorial skills to depict mother & son's never breaking bonding with deeply emotional touch woven in sci fi background. " +
                "Very few movies have been able to made such a strong impact by script , screenplay , direction , stellar performance .",
                Rating = 7
            };

            svc.AddReview(r13); // Adding review13 to db

            Review r14 = new Review
            {
                Id = movie14.Id,
                Name = "Eazyrda",
                CreatedOn = new DateTime(2014, 08, 25),
                Comment = "I AM GROOT!",
                Rating = 10
            };

            svc.AddReview(r14); // Adding review 14 to db

            Review r15 = new Review
            {
                Id = movie15.Id,
                Name = "Akash Mahajan",
                CreatedOn = new DateTime(2017, 12, 21),
                Comment = "Again hit produced by christopher nolan after batman. Storyline is great and also the science theory is perfectly showcased.",
                Rating = 8
            };

            svc.AddReview(r15); // Adding review 15 to db


            // ===================================== War Movie Reviews -----------------------------------------------------

            Review r16 = new Review
            {
                Id = movie16.Id,
                Name = "Wuchak",
                CreatedOn = new DateTime(2018, 07, 26),
                Comment = "RELEASED IN 2009 and directed by Quentin Tarantino, `Inglourious Basterds` takes place during the German occupation of France in WW2 and revolves around a ruthless “Jew Hunter” Nazi (Christoph Waltz), a beautiful young theater owner dripping with vengeance," +
                " a German war hero who pesters her and a brutal team of Jewish-American guerrilla soldiers led by Lt. Aldo Raine. " +
                "This was my first taste of the popular director's eccentric repertoire, although I've since seen all of his movies except “Death Proof” (2007). The first time I tried to watch `Basterds` I gave up around the 50-minute mark. Don't get me wrong, the dialogue-driven opening sequence is great but the film seemed to bog down with its focus on a French theater during the German occupation and the accompanying interminable dialogue (mostly in subtitles). I just wasn't ready for this because I was expecting a Dirty Dozen-styled WW2 film with lots of action and all that goes with it. What I got instead was a plot that focused on the aforementioned theater accompanied by long sessions of generally subtitled dialogue. I eventually gave it a second chance with the understanding that this wasn't some typical war flick. " +
                "Strangely, the `interminable dialogue` pulled me in and I slowly became engrossed in the story, which isn't hard to follow. The drama is only occasionally interrupted by flashes of extreme violence. Until the end, that is, where all hell literally breaks loose. There ARE elements that bring to mind `The Dirty Dozen` (1967), " +
                "including a group of anti-heroes intent on mercilessly obliterating as many Germans as possible and the fact that the real action doesn't kick-in until the final act, but `Basterds` is hardly a Dirty Dozen clone. It may borrow a bit from notable films of the past but it absolutely possesses its own refreshing originality. All effective films have quality characters and `Basterds` has several: " +
                "The stunning Mélanie Laurent as Shosanna, the cinema proprietor who quietly seethes with retribution; Christoph Waltz as SS Col. Hans Landa, an articulate and suave love-to-hate villain who mercilessly hunts down Jews; Brad Pitt as the almost-comical, but no-nonsense leader of the brutal Basterds; super-sharp Diane Kruger as a German actress & British spy; and Daniel Brühl as a genial German hero with the hots for the beautiful Shosanna. Like Tarantino’s other great movies (“Pulp Fiction,” “Django Unchained” and “Jackie Brown”), `Basterds1 pulsates with confidence, " +
                "style, quirkiness and a sense of the unexpected from beginning to end, the perfect antidote to the idiotic `blockbuster` syndrome that plagues modern cinema with its predictability and overKILL action & CGI, etc. Most movies seem like they’re in a rush and shy away from extended dialogues because they fear losing the viewer’s limited attention whereas Tarantino makes them a highlight because it’s an area where he excels. Instead of pedestrian verbiage that merely advances the plot or conveys the obvious, his interchanges are rich with amusement and mindfood.",
                Rating = 9
            };

            svc.AddReview(r16); // Adding review 16 to db

            Review r17 = new Review
            {
                Id = movie17.Id,
                Name = "Ian Beale",
                CreatedOn = new DateTime(2017, 02, 15),
                Comment = "Great movie. Simply, a must watch!!!",
                Rating = 7
            };

            svc.AddReview(r17); // Adding review 17 to the db

            Review r18 = new Review
            {
                Id = movie18.Id,
                Name = "Plague",
                CreatedOn = new DateTime(2010, 02, 26),
                Comment = "I love WWll movies, and this is very close to being my all time favorite. Eastwood has done it yet again.",
                Rating = 10
            };

            svc.AddReview(r18); // Adding review 18 to the db

            Review r19 = new Review
            {
                Id = movie19.Id,
                Name = "JPV852",
                CreatedOn = new DateTime(2020, 03, 13),
                Comment = "Very well made war-drama all in a one-shot like format. Performance from George MacKay who I guess if nothing else could follow in the footsteps of Tom Cruise for his all-out running ability. Joking aside, really enjoyed this film which manages to provide enough character development for me to care about his well being and task.",
                Rating = 9
            };

            svc.AddReview(r19); // Adding 19 to the db

            Review r20 = new Review
            {
                Id = movie20.Id,
                Name = "E.j. Cummings",
                CreatedOn = new DateTime(2019, 04, 09),
                Comment = "This movie should be known for changing Historical War Dramas as we know them. It was the first to accurately depict the carnage of war, and changed the direction of this genre of movies for all time. The initial D-Day scene was fantastic. Afterwards, Tom Hanks is ordered to chose a team of his men and look for James MacGuffin Ryan from Iowa. In order to achieve this goal, Hanks takes us across the entire back drop of world war 2, all the while making us ask, is all this worth just one man? Honestly it's a must watch and is on my `Difinitive Movie List`",
                Rating = 10
            };

            svc.AddReview(r20); // Adding review20 to the db














    }







    }
}
