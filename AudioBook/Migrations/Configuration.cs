namespace AudioBook.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using AudioBook.Core.Domain;


    internal sealed class Configuration : DbMigrationsConfiguration<AudioBook.Persistence.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "AudioBook.Core.Models.ApplicationDbContext";
        }

        protected override void Seed(AudioBook.Persistence.ApplicationDbContext context)
        {
            var a1 = new Author { FirstName = "Honoré de", LastName = "Balzac", DateOfBirth = 1799, DateOfDeath = 1850 };
            var a2 = new Author { FirstName = "Anatole", LastName = "France", DateOfBirth = 1844, DateOfDeath = 1924 };
            var a3 = new Author { FirstName = "F. Scott", LastName = "Fitzgerald", DateOfBirth = 1896, DateOfDeath = 1940 };
            var a4 = new Author { FirstName = "Frances Hodgson", LastName = "Burnett", DateOfBirth = 1849, DateOfDeath = 1924 };
            var a5 = new Author { FirstName = "Alexandre", LastName = "Dumas", DateOfBirth = 1802, DateOfDeath = 1870 };
            var a6 = new Author { FirstName = "Mark", LastName = "Twain", DateOfBirth = 1835, DateOfDeath = 1910 };
            var a7 = new Author { FirstName = "Joseph", LastName = "Conrad", DateOfBirth = 1857, DateOfDeath = 1924 };
            var a8 = new Author { FirstName = "Samuel", LastName = "Butler", DateOfBirth = 1835, DateOfDeath = 1902 };
            var a9 = new Author { FirstName = "Dante", LastName = "Alighieri", DateOfBirth = 1265, DateOfDeath = 1321 };
            var a10 = new Author { FirstName = "Isabella L.", LastName = "Bird", DateOfBirth = 1831, DateOfDeath = 1904 };
            var a11 = new Author { FirstName = "Oscar", LastName = "Wilde", DateOfBirth = 1854, DateOfDeath = 1900 };
            var a12 = new Author { FirstName = "L. Frank", LastName = "Baum", DateOfBirth = 1856, DateOfDeath = 1919 };
            var a13 = new Author { FirstName = "Harriet Beecher", LastName = "Stowe", DateOfBirth = 1811, DateOfDeath = 1896 };
            var a14 = new Author { FirstName = "M. M.", LastName = "Mangasarian", DateOfBirth = 1859, DateOfDeath = 1943 };
            var a15 = new Author { FirstName = "Charles Wayland", LastName = "Towne", DateOfBirth = 1875, DateOfDeath = 1965 };
            var a16 = new Author { FirstName = "George", LastName = "MacDonald", DateOfBirth = 1824, DateOfDeath = 1905 };
            var a17 = new Author { FirstName = "Sigmund", LastName = "Freud", DateOfBirth = 1856, DateOfDeath = 1939 };
            var a18 = new Author { FirstName = "Mary", LastName = "Wollstonecraft", DateOfBirth = 1759, DateOfDeath = 1797 };
            var a19 = new Author { FirstName = "Henry Handel", LastName = "Richardson", DateOfBirth = 1870, DateOfDeath = 1946 };
            var a20 = new Author { FirstName = "Anicius Manlius Severinus", LastName = "Boethius", DateOfBirth = 0, DateOfDeath = 0 };
            var a21 = new Author { FirstName = "Laura Lee", LastName = "Hope", DateOfBirth = 0, DateOfDeath = 0 };
            var a22 = new Author { FirstName = "Kenneth", LastName = "Grahame", DateOfBirth = 1859, DateOfDeath = 1932 };
            var a23 = new Author { FirstName = "Edgar Allan", LastName = "Poe", DateOfBirth = 1809, DateOfDeath = 1849 };
            var a24 = new Author { FirstName = "Howard", LastName = "Pyle", DateOfBirth = 1853, DateOfDeath = 1911 };
            var a25 = new Author { FirstName = "Mary E.", LastName = "Burt", DateOfBirth = 1850, DateOfDeath = 1918 };
            var a26 = new Author { FirstName = "Sun", LastName = "Tzu", DateOfBirth = 0, DateOfDeath = 0 };
            var a27 = new Author { FirstName = "E. W.", LastName = "Hornung", DateOfBirth = 1866, DateOfDeath = 1921 };
            var a28 = new Author { FirstName = "Gene", LastName = "Stratton-Porter", DateOfBirth = 1863, DateOfDeath = 1924 };
            var a29 = new Author { FirstName = "Douglas William", LastName = "Jerrold", DateOfBirth = 1803, DateOfDeath = 1857 };


            context.Authors.AddOrUpdate(a => a.FirstName, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10,
                a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29);


            var b1 = new Book
            {
                Title = "Letters of Two Brides",
                Description =
                    "Letters of Two Brides is an epistolary novel. The two brides are Louise de Chaulieu (Madame Gaston) and Renée de Maucombe (Madame l'Estorade). The women became friends during their education at a convent and upon leaving began a life-long correspondence. For a 17 year period, they exchange letters describing their lives. Michelle Crandall reads Renee’s letters, and Kara Shallenberg reads Louise’s. Letters from the men in their lives are read by Peter Yearsley, David Barnes, Denny Sayers, and Sean McKinley.",
                Language = "English",
                Price = 24.99M,
                Photo = "http://ia802809.us.archive.org/12/items/LibrivoxCdCoverArt12/Letters_Two_Brides_1110.jpg",
                CopyrightYear = 1902,
                NumSections = 57,
                TotalTime = "9:09:20",
                Author = a1
            };

            var b2 = new Book
            {
                Title = "Penguin Island",
                Description = "The novel (original French title -- L'Île des Pingouins) is a satire on human nature. The first publication was in 1908. These penguins are mistaken for humans by the 97-year-old priest, Father Mael, because of his bad eyesight. He baptizes them, and once baptized, they have no choice but to become human. They take on human traits (build civilizations, go to war, etc.). The book is very funny and powerful.",
                Language = "English",
                Price = 19.99M,
                Photo = "http://ia802609.us.archive.org/31/items/LibrivoxCdCoverArt4/Penguin_Island_1004.jpg",
                CopyrightYear = 1908,
                NumSections = 62,
                TotalTime = "9:04:31",
                Author = a2
            };

            var b3 = new Book
            {
                Title = "This Side of Paradise",
                Description = "This Side of Paradise is the debut novel of F. Scott Fitzgerald. Published in 1920, and taking its title from a line of the Rupert Brooke poem Tiare Tahiti, the book examines the lives and morality of post-World War I youth. Its protagonist, Amory Blaine, is a wealthy and attractive Princeton University student who dabbles in literature and has a series of romances that eventually lead to his disillusionment. In his later novels, Fitzgerald would further develop the book's theme of love warped by greed and status-seeking.",
                Language = "English",
                Price = 21.99M,
                Photo = "http://ia802605.us.archive.org/20/items/LibrivoxCdCoverArt5/this_side_of_paradise_1006.jpg",
                CopyrightYear = 1920,
                NumSections = 22,
                TotalTime = "8:56:24",
                Author = a3
            };
            var b4 = new Book
            {
                Title = "Secret Garden",
                Description = "Mary Lennox is a spoiled,middle -class, self-centred child who has been recently orphaned.She is accepted into the quiet and remote country house of an uncle, who has almost completely withdrawn into himself after the death of his wife.Mary gradually becomes drawn into the hidden side of the house: why does she hear the crying of a unseen child? Why is there an overgrown, walled garden, its door long locked?",
                Language = "English",
                Price = 20.99M,
                Photo = "http://ia802303.us.archive.org/29/items/secret_garden_librivox/Secret_Garden_1003.jpg",
                CopyrightYear = 1909,
                NumSections = 27,
                TotalTime = "9:08:25",
                Author = a4
            };
            var b5 = new Book
            {
                Title = "Twenty Years After",
                Description = "Let's continue the D'Artagnan Romances that we've already started with The Three Musketeers.",
                Language = "English",
                Price = 28.99M,
                Photo = "http://ia800302.us.archive.org/16/items/librivox_cd_covers/twenty_years_after.jpg",
                CopyrightYear = 1856,
                NumSections = 90,
                TotalTime = "25:43:08",
                Author = a5
            };
            var b6 = new Book
            {
                Title = "Adventures of Huckleberry Finn",
                Description = "Adventures of Huckleberry Finn</em> (1884) by Mark Twain is one of the truly great American novels, beloved by children, adults, and literary critics alike.  The book tells the story of “Huck” Finn (first introduced as Tom Sawyer’s sidekick in <em>The Adventures of Tom Sawyer</em>), his friend Jim, and their journey down the Mississippi River on a raft.  Both are on the run, Huck from his drunk and abusive father, and Jim as a runaway slave.</p>\n<p>As Huck and Jim drift down the river, they meet many colorful characters and have many great adventures.  The true heart of the story, however, is the friendship between Huck and Jim.  A constant theme throughout the book is Huck’s internal struggle between what he has been taught, that helping a runaway slave is a sin, and what he truly believes, that Jim is a good man and it couldn’t possibly be wrong to help him.</p>\n<p><em>Adventures of Huckleberry Finn</em> was unique at the time of its publication (1884) because it is narrated by Huck himself and is written in the numerous dialects common in the area and time in which the book is set.  Although the book was originally intended as a sequel to the children’s book <em>The Adventures of Tom Sawyer</em>, as Twain wrote <em>Adventures of Huckleberry Finn</em> it progressed into a more serious work.  Twain’s views on slavery and other social issues of the time become clear through the words, thoughts, and actions of Huck Finn.  The book has always been the subject of great controversy, and according to <a href=\"http://www.ala.org/bbooks/100-most-frequently-challenged-books-1990–1999\" target=\"_blank\">The American Library Association</a> it was fifth on the list of most frequently challenged books in the 1990s.<br />(Summary by Annie Coleman)",
                Language = "English",
                Price = 21.99M,
                Photo = "https://ia802902.us.archive.org/16/items/huck_finn_librivox/Huck_Finn.jpg",
                CopyrightYear = 1884,
                NumSections = 47,
                TotalTime = "10:42:07",
                Author = a6
            };
            var b7 = new Book
            {
                Title = "Heart of Darkness",
                Description = "Set in a time of oppressive colonisation, when large areas of the world were still unknown to Europe, and Africa was literally on maps and minds as a mysterious shadow, Heart of Darkness famously explores the rituals of civilisation and barbarism, and the frighteningly fine line between them. We get the tale through a classic unreliable narrator, relating as Marlow, a ship’s captain, tells how he was sent by the Company to retrieve the wayward Kurtz, and was shaken to discover the true depths of darkness in that creature’s, and in his own, soul. Conrad based the work closely on his own terrible experience in the Congo.  This work has been reinterpreted and adapted into many modern forms, the most well known being the film Apocalypse Now. (Summary written by Marlo Dianne)",
                Language = "English",
                Price = 15.99M,
                Photo = "https://archive.org/download/heart_of_darkness/Heart_of_Darkness.jpg",
                CopyrightYear = 1902,
                NumSections = 6,
                TotalTime = "4:10:12",
                Author = a7
            };
            var b8 = new Book
            {
                Title = "Odyssey",
                Description = "The Odyssey is one of the two major ancient Greek epic poems (the other being the Iliad), attributed to the poet Homer. The poem is commonly dated to between 800 and 600 BC. The poem is, in part, a sequel to the Iliad, and concerns the events that befall the Greek hero Odysseus in his long journey back to his native land Ithaca after the fall of Troy.</p>\n\nIt takes Odysseus ten years to return to his native land of Ithaca after ten years of war; during his 20-year absence, his son Telemachus and his wife Penelope must deal with a group of unruly suitors who have moved into Odysseus' home to compete for Penelope's hand in marriage, since most have assumed that Odysseus has died.</p>\n\nThe poem is a fundamental text in the Western canon and continues to be read in both Homeric Greek and translations around the world. (Summary from Wikipedia",
                Language = "English",
                Price = 27.99M,
                Photo = "https://ia800302.us.archive.org/16/items/librivox_cd_covers/odyssey.jpg",
                CopyrightYear = 1900,
                NumSections = 24,
                TotalTime = "11:18:25",
                Author = a8
            };
            var b9 = new Book
            {
                Title = "Divine Comedy",
                Description = "The Divine Comedy (Italian: Commedia, later christened \"Divina\" by Giovanni Boccaccio), written by Dante Alighieri between 1308 and his death in 1321, is widely considered the central epic poem of Italian literature, the last great work of literature of the Middle Ages and the first great work of the Renaissance. A culmination of the medieval world-view of the afterlife, it establishes the Tuscan dialect in which it is written as the Italian standard, and is seen as one of the greatest works of world literature. - The Divine Comedy is composed of three canticas (or \"cantiche\") — Inferno (Hell), Purgatorio (Purgatory), and Paradiso (Paradise) — composed each of 33 cantos (or \"canti\"). The very first canto serves as an introduction to the poem and is generally not considered to be part of the first cantica, bringing the total number of cantos to 100. - The poet tells in the first person his travel through the three realms of the dead, lasting during the Easter Triduum in the spring of 1300. (Summary from Wikipedia)",
                Language = "English",
                Price = 28M,
                Photo = "https://ia800201.us.archive.org/3/items/divine_comedy_librivox/The_Divine_Comedy_1005.jpg",
                CopyrightYear = 1321,
                NumSections = 19,
                TotalTime = "12:23:25",
                Author = a9
            };
            var b10 = new Book
            {
                Title = "Unbeaten Tracks in Japan",
                Description = "Isabella Lucy Bird was a 19th century English traveller, writer, and natural historian. She was a sickly child, however, while she was travelling she was almost always healthy. Her first trip, in 1854, took her to America, visiting relatives. Her first book, <i>The Englishwoman in America</i> was published anonymously two years later.<br><br>\n<i>Unbeaten Tracks in Japan</i> is compiled of the letters she sent to her sister during her 7 months sojourn in Japan in 1878. Her travels there took her from Edo (now called Tokyo) through the interior - where she was often the first foreigner the locals had met - to Niigata, and from there to Aomori. There she crossed over to Yezo (Hokkaido), and her account on the life of the Ainu, an indigenous people of Japan, provides an interesting glimpse of days long past. (Summary by Availle)",
                Language = "English",
                Price = 30M,
                Photo = "https://ia802600.us.archive.org/5/items/LibrivoxCdCoverArt28/unbeatentracksjapan_1212.jpg",
                CopyrightYear = 1878,
                NumSections = 58,
                TotalTime = "12:56:25",
                Author = a10
            };
            var b11 = new Book
            {
                Title = "Canterville Ghost",
                Description = "The American Minister and his family have bought the English stately home Canterville Chase, complete with the ghost of Sir Simon de Canterville - blood-stains, clanking chains and all. But these modern Americans will have no truck with ghostly goings-on, and set out to beat the spectre at his own game. (Summary by David Barnes)",
                Language = "English",
                Price = 9.99M,
                Photo = "https://ia802605.us.archive.org/13/items/canterville_ghost_librivox/Canterville_Ghost_1106.jpg",
                CopyrightYear = 1906,
                NumSections = 7,
                TotalTime = "1:23:08",
                Author = a11
            };
            var b12 = new Book
            {
                Title = "Mother Goose in Prose",
                Description = "Whether Mother Goose was a real person or a myth, the songs that are attributed to her name are what we remember from our childhood. Some of these nursery rhymes are complete tales in themselves.  There are others which are mere suggestions, leaving the imagination to weave in the details of the story. Many of the rhymes’ origins even at the time of this books writing, could be traced back decades or centuries. L Frank Baum in 1897, while living in Chicago, collected the rhymes and created short stories around them which add context and understanding for children who are drawn to the familiar melodies. (Summary by Westwinds12)<p>",
                Language = "English",
                Price = 10M,
                Photo = "https://ia802608.us.archive.org/7/items/mother_goose_prose_librivox/Mother_Goose_Prose_1107.jpg",
                CopyrightYear = 1897,
                NumSections = 23,
                TotalTime = "4:46:24",
                Author = a12
            };
            var b13 = new Book
            {
                Title = "Uncle Tom's Cabin",
                Description = "Among the most “banned” books in the United States, Uncle Tom’s Cabin; or, Life Among the Lowly is a novel by American author Harriet Beecher Stowe which treats slavery as a central theme. Stowe was a Connecticut-born teacher at the Hartford Female Academy and an active abolitionist. The novel is believed to have had a profound effect on the North’s view of slavery. In fact, when he met Harriet Beecher Stowe, President Lincoln is said to have commented, “So you’re the little lady whose book started the Civil War.” First published on March 20, 1852, the story focuses on the tale of Uncle Tom, a long-suffering black slave, the central character around whose life the other characters—both fellow slaves and slave owners—revolve. The novel depicts the harsh reality of slavery while also showing that Christian love and faith can overcome even something as evil as enslavement of fellow human beings. (summary by Wikipedia and John Greenman)</p>\n\n<p>Note From the Reader: \nThe listener is about to enter a world rich with diverse characters. In order to differentiate between the characters, the reader has given each, his/her own voice. As an adult male reader, however, the reader's representation of women and children will, necessarily be less than adequate. He asks for your indulgence.",
                Language = "English",
                Price = 24.99M,
                Photo = "https://ia800301.us.archive.org/30/items/uncle_toms_cabin_librivox/Uncle_Toms_Cabin_1006.jpg",
                CopyrightYear = 1852,
                NumSections = 45,
                TotalTime = "18:06:33",
                Author = a13
            };
            var b14 = new Book
            {
                Title = "Truth About Jesus.  Is He a Myth?",
                Description = "The following work offers in book form the series of studies on the question of the historicity of Jesus, presented from time to time before the Independent Religious Society in Orchestra Hall, Chicago, 1909. No effort has been made to change the manner of the spoken, into the more regular form of the written, word. (Summary by M.M. Mangasarian (1859-1943) and Joanne Pauwels)<p>",
                Language = "English",
                Price = 24.99M,
                Photo = "https://ia800501.us.archive.org/15/items/LibrivoxCdCoverArt10/Truth_Jesus_Myth_1108.jpg",
                CopyrightYear = 1909,
                NumSections = 18,
                TotalTime = "5:40:15",
                Author = a14
            };
            var b15 = new Book
            {
                Title = "Foolish Dictionary",
                Description = "The Foolish Dictionary was written by Gideon Wurdz (the pen name for Charles Wayland Towne) and was published in 1904. According to the beginning of the book, it is \"An exhausting work of reference to un-certain English words, their origin, meaning, legitimate and illegitimate use...\" \n\nThis a a short but amusing dictionary which \"redefines\" words in some interesting ways. Funny and sometimes bizarre observations are sprinkled throughout. In keeping with LibriVox policy to read, rather than attempt to rewrite, books - even those with offensive content - nothing has been omitted. While many of the definitions may just seem confusing or \"corny\" to modern readers, there are a couple that also might be considered objectionable, particularly in section 10, which contains offensive content of a racial nature. Summary by Maddie",
                Language = "English",
                Price = 24.99M,
                Photo = "https://ia800908.us.archive.org/11/items/foolish_dictionary_librivox/Foolish_Dictionary_1107.jpg",
                CopyrightYear = 1904,
                NumSections = 18,
                TotalTime = "1:45:27",
                Author = a15
            };
            var b16 = new Book
            {
                Title = "Ranald Bannerman's Boyhood",
                Description = "George MacDonald is mainly known for his fantasy works and fairy tales such as At the Back of the North Wind and the Princess and the Goblin. However, during his life he was more famous for many more realistic novels. . . among them the somewhat autobiographical Ranald Bannerman's Boyhood.\n<p>This story of a young motherless boy growing up with his brothers in a Scottish manse is full of delightful characters. There is Kirsty, an enchanting Highland storyteller, Turkey, the intrepid cowherd, the evil Kelpie, and the lovely Elsie Duff. Throughout the twists and turns of his escapades and adventures Ranald learns from his father the important lessons of courage and integrity.</p><p>When Ranald Bannerman's Boyhood came out in 1871 the New York Independent praised it as \"full of sweetness, full of boy-life and true goodness\". Perhaps, but it is also a good story, from the master of storytellers. (Summary by Bookworm)",
                Language = "English",
                Price = 24.99M,
                Photo = "https://ia800501.us.archive.org/15/items/LibrivoxCdCoverArt10/Ranald_Bannermans_Boyhood_1108.jpg",
                CopyrightYear = 1871,
                NumSections = 36,
                TotalTime = "7:04:48",
                Author = a16
            };
            var b17 = new Book
            {
                Title = "Dream Psychology",
                Description = "Not a few serious-minded students, have been discouraged from attempting a study of Freud's dream psychology. The book in which he originally offered to the world his interpretation of dreams was as circumstantial as a legal record to be pondered over by scientists at their leisure, not to be assimilated in a few hours by the average alert reader. In those days, Freud could not leave out any detail likely to make his extremely novel thesis evidentially acceptable to those willing to sift data. - Freud himself, however, realized the magnitude of the task which the reading of his magnum opus imposed upon those who have not been prepared for it by long psychological and scientific training and he abstracted from that gigantic work the parts which constitute the essential of his discoveries.</p>\n<p>The publishers of the present book deserve credit for presenting to the reading public the gist of Freud's psychology in the master's own words, and in a form which shall neither discourage beginners, nor appear too elementary to those who are more advanced in psychoanalytic study. - Dream psychology is the key to Freud's works and to all modern psychology. With a simple, compact manual such as Dream Psychology there shall be no longer any excuse for ignorance of the most revolutionary psychological system of modern times. (From the book introduction, by Andre Tridon)",
                Language = "English",
                Price = 24.99M,
                Photo = "https://ia800705.us.archive.org/9/items/LibrivoxCdCoverArt6/dream_psychology_1101.jpg",
                CopyrightYear = 1920,
                NumSections = 10,
                TotalTime = "6:04:02",
                Author = a17
            };
            var b18 = new Book
            {
                Title = "Vindication of the Rights of Woman",
                Description = "Wollstonecraft (1759-1797) is best known for A Vindication of the Rights of Woman in which she argued that women are not naturally inferior to men, but only appeared to be because they lacked education. She suggested that both men and women should be treated as rational beings and imagined a social order founded on reason. - Today, Wollstonecraft is considered a foundational thinker in feminist philosophy. Her early advocacy of women's equality and her attacks on conventional femininity and the degradation of women presaged the later emergence of the feminist political movement. Feminist scholars and activists have cited both her philosophical ideas and personal struggles as important influences in their work. <br><br>\n<em>This is one of the 12 Books That Changed the World by Melvyn Bragg.</em> (Summary from Wikipedia and Alex Foster)",
                Language = "English",
                Price = 24.99M,
                Photo = "https://ia600501.us.archive.org/6/items/LibrivoxCdCoverArt9/Vindication_Rights_Woman_1107.jpg",
                CopyrightYear = 1792,
                NumSections = 21,
                TotalTime = "9:46:16",
                Author = a18
            };
            var b19 = new Book
            {
                Title = "Getting of Wisdom",
                Description = "The Getting of Wisdom tells the story of Laura Rambotham, a 12-year-old girl who is just starting at her boarding school. This is based on Henry Handel Richardson's experiences of her own school, the Prebysterian Ladies College in central Melbourne. The story goes through her friends and enemies and all the life of a boarding school in early 20th century Australia, and all the subjects and learning too. Laura learns a lot but her education does not satisfy her, and her social life is thrown upon her as very different from her peers. (Summary by Bronwyn Kate)",
                Language = "English",
                Price = 24.99M,
                Photo = "https://ia600501.us.archive.org/6/items/LibrivoxCdCoverArt9/Getting_Wisdom_1108.jpg",
                CopyrightYear = 1910,
                NumSections = 25,
                TotalTime = "7:47:37",
                Author = a19
            };
            var b20 = new Book
            {
                Title = "Consolation of Philosophy",
                Description = "Consolation of Philosophy (Latin: Consolatio Philosophiae) is a philosophical work by Boethius written in about the year 524 AD. It has been described as the single most important and influential work in the West in medieval and early Renaissance Christianity, and is also the last great work that can be called Classical. <br><br> Consolation of Philosophy was written during Boethius' one year imprisonment while awaiting trial, and eventual horrific execution, for the crime of treason by Ostrogothic King Theodoric the Great. Boethius was at the very heights of power in Rome and was brought down by treachery. It was from this experience he was inspired to write a philosophical book from prison reflecting on how a lord's favor could change so quickly and why friends would turn against him. It has been described as “by far the most interesting example of prison literature the world has ever seen.” <br><br> The Consolation of Philosophy stands, by its note of fatalism and its affinities with the Christian doctrine of humility, midway between the heathen philosophy of Seneca the Younger and the later Christian philosophy of consolation represented by Thomas Aquinas. <br><br>The book is heavily influenced by Plato and his dialogues (as was Boethius himself). (Summary from Wikipedia)",
                Language = "English",
                Price = 24.99M,
                Photo = "https://ia800501.us.archive.org/6/items/LibrivoxCdCoverArt9/Consolation_Philosophy_1107.jpg",
                CopyrightYear = 1900,
                NumSections = 41,
                TotalTime = "5:13:04",
                Author = a20
            };
            var b21 = new Book
            {
                Title = "Mrs. Caudle's Curtain Lectures",
                Description = "Douglas William Jerrold (1803-1857) was the son of an actor manager. After some time in the Navy and as an apprentice printer he became a playwright and later a journalist. He was a contemporary and friend of Charles Dickens. As a journalist he worked for Punch magazine in which Mrs Caudle's Curtain Lectures were serialised, to be published in book form in 1846.<br /><br />Job Caudle, the 'hero' of the book is a Victorian shopkeeper whose wife finds she can only talk to him without interruption in bed. Caudle, who outlives his wife, finds he can no longer sleep easily because of his memory of these 'lectures' and resolves to exorcise his wife's memory by recording the lectures, it seems with a view to future publication for the edification of others. Jerrold's humour shines through this insight into Victorian middle class culture. (Summary by Martin Clifton)",
                Language = "English",
                Price = 14.99M,
                Photo = "https://ia902701.us.archive.org/7/items/mrs_caudles_curtain_lectures_librivox/Mrs_Caudles_Curtain_Lectures_1105.jpg",
                CopyrightYear = 1846,
                NumSections = 38,
                TotalTime = "4:21:46",
                Author = a29
            };
            var b22 = new Book
            {
                Title = "Importance of Being Earnest",
                Description = "The Importance of Being Earnest is a classic comedy of manners in which two flippant young men, in order to impress their respected beloveds, pretend that their names are “Ernest,” which both young ladies believe confers magical qualities on the possessor. It was first performed for the public on February 14, 1895 at the St. James’ Theatre in London, and is regarded by many critics and scholars as being the wittiest play in the English language. (Summary from Wikipedia.org) ",
                Language = "English",
                Price = 14.99M,
                Photo = "https://ia802304.us.archive.org/35/items/being_earnest_librivox/Importance_Being_Earnest_1105.jpg",
                CopyrightYear = 1899,
                NumSections = 3,
                TotalTime = "2:18:00",
                Author = a11
            };
            var b23 = new Book
            {
                Title = "Story of a Stuffed Elephant",
                Description = "The Story of a Stuffed Elephant is... well, the story of a Stuffed Elephant and the little boy who owns him, and his sister, and all their adventures. A delightful children's book by the author of The Bobbsey Twins series. (Summary by Vlooi and Kara)",
                Language = "English",
                Price = 14.99M,
                Photo = "https://ia802304.us.archive.org/24/items/stuffed_elephant_solo_librivox/story_of_a_stuffed_elephant_1012.jpg",
                CopyrightYear = 1922,
                NumSections = 10,
                TotalTime = "2:09:50",
                Author = a21
            };
            var b24 = new Book
            {
                Title = "Wind in the Willows",
                Description = "This much-loved story follows a group of animal friends in the English countryside as they pursue adventure … and as adventure pursues them! The chief characters - Mole, Rat, and Toad - generally lead upbeat and happy lives, but their tales are leavened with moments of terror, homesickness, awe, madcap antics, and derring-do.<br />\nAlthough classed as children’s literature, The Wind in the Willows holds a gentle fascination for adults too. The vocabulary is decidedly not “Dick and Jane”, and a reader with a love of words will find new ones to treasure, even if well-equipped for the journey. Parents will appreciate the themes of loyalty, manners, self-restraint, and comradeship which are evident throughout the book. When the characters err, they are prompt to acknowlege it, and so a reading of this book can model good behavior to children, who will otherwise be enchanted with the many ways in which the lives of these bucolic characters differ from modern life.<br />\nThis book was so successful that it enabled the author to retire from banking and take up a country life somewhat like that of his creations. It has been adapted for screen, stage, and even a ride at the original Disneyland.\n(Summary by Mark F. Smith)",
                Language = "English",
                Price = 14.99M,
                Photo = "https://ia802703.us.archive.org/17/items/wind_in_the_willows_collab_librivox/Wind_Willows_1105.jpg",
                CopyrightYear = 1908,
                NumSections = 12,
                TotalTime = "6:30:07",
                Author = a22
            };
            var b25 = new Book
            {
                Title = "Narrative of Arthur Gordon Pym of Nantucket",
                Description = "The Narrative of Arthur Gordon Pym of Nantucket is Edgar Allan Poe’s only complete novel, published in 1838.</p><p>The work relates the tale of the young Arthur Gordon Pym who stows away aboard a whaling ship called Grampus. Various adventures and mis-adventures befall Pym including shipwreck, mutiny and cannibalism. The story starts out as a fairly conventional adventure at sea, but it becomes increasingly strange and hard to classify in later chapters, involving religious symbolism and the Hollow Earth. Summary from Wikipedia",
                Language = "English",
                Price = 14.99M,
                Photo = "https://ia800501.us.archive.org/15/items/LibrivoxCdCoverArt10/Narrative_Arthur_Gordon_Pym_1108.jpg",
                CopyrightYear = 1838,
                NumSections = 27,
                TotalTime = "6:22:12",
                Author = a23
            };
            var b26 = new Book
            {
                Title = "Merry Adventures of Robin Hood",
                Description = "Robin Hood is the archetypal English folk hero; a courteous, pious and swashbuckling outlaw of the mediæval era who, in modern versions of the legend, is famous for robbing the rich to feed the poor and fighting against injustice and tyranny. He operates with his \"seven score\" (140 strong) group of fellow outlawed yeomen – named the Merry Men. He and his band are usually associated with Sherwood Forest, Nottinghamshire.<br><br>The Victorian era generated its own distinct versions of Robin Hood. The traditional tales were often adapted for children, most notably in Howard Pyle's Merry Adventures of Robin Hood. These versions firmly stamp Robin as a staunch philanthropist, a man who takes from the rich to give to the poor.(Summary from Wikipedia)",
                Language = "English",
                Price = 14.99M,
                Photo = "https://ia802305.us.archive.org/31/items/merry_adventures_robin_hood_librivox/Merry_Adventures_of_Robin_Hood_1009.jpg",
                CopyrightYear = 1883,
                NumSections = 22,
                TotalTime = "11:00:49",
                Author = a24
            };
            var b27 = new Book
            {
                Title = "Poems Every Child Should Know",
                Description = "This anthology of poetry, published in 1904, contains such favorites as The Raven, My Shadow, and The Village Blacksmith, as well as many lovely poems that may be unfamiliar. Most of the poems in this collection are short enough for children to memorize.",
                Language = "English",
                Price = 14.99M,
                Photo = "https://ia800209.us.archive.org/13/items/poems_every_child_should_know_librivox/poems_every_child_should_know_1012.jpg",
                CopyrightYear = 1904,
                NumSections = 81,
                TotalTime = "8:07:47",
                Author = a25
            };
            var b28 = new Book
            {
                Title = "Art of War",
                Description = "The Art of War is a Chinese military treatise written during the 6th century BC by Sun Tzu. Composed of 13 chapters, each of which is devoted to one aspect of warfare, it has long been praised as the definitive work on military strategies and tactics of its time. The Art of War is one of the oldest and most famous studies of strategy and has had a huge influence on both military planning and beyond. The Art of War has also been applied, with much success, to business and managerial strategies. (summary from Wikipedia)",
                Language = "English",
                Price = 14.99M,
                Photo = "https://ia600301.us.archive.org/14/items/art_of_war_librivox/Art_War_1107.jpg",
                CopyrightYear = 1910,
                NumSections = 7,
                TotalTime = "1:12:14",
                Author = a26
            };
            var b29 = new Book
            {
                Title = "Amateur Cracksman",
                Description = "I'd tasted blood, and it was all over with me. Why should I work when I could steal? Why settle down to some humdrum uncongenial billet, when excitement, romance, danger and a decent living were all going begging together?\"- A. J. Raffles, The Ides of March.</blockquote>The Amateur Cracksman is the first collection of stories about A. J. Raffles, gentleman, cricketer, and thief. After stopping his old school friend, Bunny Manders, from a desperate attempt at suicide, Raffles introduces the unsuspecting Bunny to a new way of earning a living, burglary. Though frequently horrified by Raffles's actions, the conscience-stricken Bunny stands by him through all their adventures, firm to his promise, \"When you want me, I'm your man!\" (Summary by Kristin Hughes)",
                Language = "English",
                Price = 14.99M,
                Photo = "https://ia902701.us.archive.org/29/items/amateur_cracksman_librivox/Amateur_Cracksman_1004.jpg",
                CopyrightYear = 1899,
                NumSections = 8,
                TotalTime = "5:25:24",
                Author = a27
            };
            var b30 = new Book
            {
                Title = "Girl of the Limberlost",
                Description = "A Girl of the Limberlost, a novel written by the American writer and naturalist Gene Stratton-Porter, was first published in August, 1909. The story takes place in Indiana, in and around the Limberlost Swamp, during the early 20th century. (Summary from Wikipedia)",
                Language = "English",
                Price = 14.99M,
                Photo = "https://ia800207.us.archive.org/19/items/girl_limberlost_librivox/Girl_Limberlost_1107.jpg",
                CopyrightYear = 1909,
                NumSections = 25,
                TotalTime = "11:25:09",
                Author = a28
            };

            context.Books.AddOrUpdate(b => b.Title, b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14,
                b15, b16, b17, b18, b19, b20, b21, b22, b23, b24, b25, b26, b27, b28, b29, b30);

            var ad1 = new Audio
            {
                Name = "Letter of Two Brides Part 1",
                Url = "https://ia802506.us.archive.org/2/items/letters_brides_0709_librivox/letters_of_two_brides_01_debalzac.mp3",
                Book = b1
            };
            var ad2 = new Audio
            {
                Name = "Letter of Two Brides Part 2",
                Url = "https://ia902506.us.archive.org/2/items/letters_brides_0709_librivox/letters_of_two_brides_02_debalzac.mp3",
                Book = b1
            };
            var ad3 = new Audio
            {
                Name = "Letter of Two Brides Part 3",
                Url = "https://ia802506.us.archive.org/2/items/letters_brides_0709_librivox/letters_of_two_brides_03_debalzac.mp3",
                Book = b1
            };
            var ad4 = new Audio
            {
                Name = "Letter of Two Brides Part 4",
                Url = "https://ia802506.us.archive.org/2/items/letters_brides_0709_librivox/letters_of_two_brides_04_debalzac.mp3",
                Book = b1
            };
            var ad5 = new Audio
            {
                Name = "Letter of Two Brides Part 5",
                Url = "https://ia802506.us.archive.org/2/items/letters_brides_0709_librivox/letters_of_two_brides_05_debalzac.mp3",
                Book = b1
            };
            var ad6 = new Audio
            {
                Name = "Penguin Island Part 1",
                Url = "https://ia800309.us.archive.org/4/items/penguin_island_ms_librivox/penguin_island_01_france.mp3",
                Book = b2
            };
            var ad7 = new Audio
            {
                Name = "Penguin Island Part 2",
                Url = "https://ia800309.us.archive.org/4/items/penguin_island_ms_librivox/penguin_island_02_france.mp3",
                Book = b2
            };
            var ad8 = new Audio
            {
                Name = "Penguin Island Part 3",
                Url = "https://ia800309.us.archive.org/4/items/penguin_island_ms_librivox/penguin_island_03_france.mp3",
                Book = b2
            };
            var ad9 = new Audio
            {
                Name = "Penguin Island Part 4",
                Url = "https://ia800309.us.archive.org/4/items/penguin_island_ms_librivox/penguin_island_04_france.mp3",
                Book = b2
            };
            var ad10 = new Audio
            {
                Name = "Penguin Island Part 5",
                Url = "https://ia800309.us.archive.org/4/items/penguin_island_ms_librivox/penguin_island_05_france.mp3",
                Book = b2
            };
            var ad11 = new Audio
            {
                Name = "This side of Paradise Part 1",
                Url = "https://ia802205.us.archive.org/7/items/this_side_paradise_librivox/thissideofparadise_01_fitzgerald.mp3",
                Book = b3
            };
            var ad12 = new Audio
            {
                Name = "This side of Paradise Part 2",
                Url = "https://ia802205.us.archive.org/7/items/this_side_paradise_librivox/thissideofparadise_02_fitzgerald.mp3",
                Book = b3
            };
            var ad13 = new Audio
            {
                Name = "This side of Paradise Part 3",
                Url = "https://ia802205.us.archive.org/7/items/this_side_paradise_librivox/thissideofparadise_03_fitzgerald.mp3",
                Book = b3
            };
            var ad14 = new Audio
            {
                Name = "This side of Paradise Part 4",
                Url = "https://ia802205.us.archive.org/7/items/this_side_paradise_librivox/thissideofparadise_04_fitzgerald.mp3",
                Book = b3
            };
            var ad15 = new Audio
            {
                Name = "This side of Paradise Part 5",
                Url = "https://ia802205.us.archive.org/7/items/this_side_paradise_librivox/thissideofparadise_05_fitzgerald.mp3",
                Book = b3
            };
            var ad16 = new Audio
            {
                Name = "Secret Garden Part 1",
                Url = "https://ia802303.us.archive.org/29/items/secret_garden_librivox/secretgarden_01_burnett.mp3",
                Book = b4
            };
            var ad17 = new Audio
            {
                Name = "Secret Garden Part 2",
                Url = "https://ia802303.us.archive.org/29/items/secret_garden_librivox/secretgarden_02_burnett.mp3",
                Book = b4
            };
            var ad18 = new Audio
            {
                Name = "Secret Garden Part 3",
                Url = "https://ia802303.us.archive.org/29/items/secret_garden_librivox/secretgarden_03_burnett.mp3",
                Book = b4
            };
            var ad19 = new Audio
            {
                Name = "Secret Garden Part 4",
                Url = "https://ia802303.us.archive.org/29/items/secret_garden_librivox/secretgarden_04_burnett.mp3",
                Book = b4
            };
            var ad20 = new Audio
            {
                Name = "Secret Garden Part 5",
                Url = "https://ia802303.us.archive.org/29/items/secret_garden_librivox/secretgarden_05_burnett.mp3",
                Book = b4
            };

            context.Audio.AddOrUpdate(ad => ad.Name, ad1, ad2, ad3, ad4, ad5, ad6, ad7, ad8, ad9, ad10, 
                ad11, ad12, ad13, ad14, ad15, ad16, ad17, ad18, ad19, ad20);
            context.SaveChanges();

        }
    }
}
