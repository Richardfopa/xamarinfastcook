using System.Collections.Generic;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class BearData
    {
        public static IList<Foods> Bears { get; private set; }

        static BearData()
        {
            Bears = new List<Foods>();

            Bears.Add(new Foods
            {
                Name = "Poisson braizer",
                Location = "Deido Rue de la joie",
                Details = "The American black bear is a medium-sized bear native to North America. It is the continent's smallest and most widely distributed bear species. American black bears are omnivores, with their diets varying greatly depending on season and location. They typically live in largely forested areas, but do leave forests in search of food. Sometimes they become attracted to human communities because of the immediate availability of food. The American black bear is the world's most common bear species.",
                ImageUrl = "image10.jpg",
                Numbertelephone = "+237651391762",
                Gmail = "richfopa@gmail.com",
            });

            Bears.Add(new Foods
            {
                Name = "Okok",
                Location = "Dakar",
                Details = "In this tutorial,you'll createa scrollablelist of country names thatareread from a string array.When a list itemis selected,              a toast message will display the position of theitem in thelist.",
                ImageUrl = "image8.jpg"
            });

            Bears.Add(new Foods
            {
                Name = "Plat 1",
                Location = "Logpom",
                Details = "In this tutorial,you'll createa scrollablelist of country names thatareread from a string array.When a list itemis selected,              a toast message will display the position of theitem in thelist.",
                ImageUrl = "image9.jpg"
            });

            Bears.Add(new Foods
            {
                Name = "Plat 2",
                Location = "Logpom",
                Details = "The giant panda, also known as panda bear or simply panda, is a bear native to south central China. It is easily recognized by the large, distinctive black patches around its eyes, over the ears, and across its round body. The name giant panda is sometimes used to distinguish it from the unrelated red panda. Though it belongs to the order Carnivora, the giant panda's diet is over 99% bamboo. Giant pandas in the wild will occasionally eat other grasses, wild tubers, or even meat in the form of birds, rodents, or carrion. In captivity, they may receive honey, eggs, fish, yams, shrub leaves, oranges, or bananas along with specially prepared food.",
                ImageUrl = "image6.jpg"
            });

            Bears.Add(new Foods
            {
                Name = "Ndole",
                Location = "Douala",
                Details = "In this tutorial,you'll createa scrollablelist of country names thatareread from a string array.When a list itemis selected,              a toast message will display the position of theitem in thelist.",
                ImageUrl = "image3.jpg"
            });

            Bears.Add(new Foods
            {
                Name = "Fufu",
                Location = "PK 14",
                Details = "In this tutorial,you'll createa scrollablelist of country names thatareread from a string array.When a list itemis selected,              a toast message will display the position of theitem in thelist.",
                ImageUrl = "images4.jpg"
            });

            Bears.Add(new Foods
            {
                Name = "Couscous",
                Location = "Bonaberie",
                Details = "In this tutorial,you'll createa scrollablelist of country names thatareread from a string array.When a list itemis selected,              a toast message will display the position of theitem in thelist.",
                ImageUrl = "images5.lpg"
            });

            for (int i = 0; i < Bears.Count; i++) {

                Bears[i].Numbertelephone = "+237653364747";
                Bears[i].Gmail = "richfopa@gmail.com";

            }

            /*
            Bears.Add(new Animal
            {
                Name = "Polar Bear",
                Location = "Artic Circle",
                Details = "The polar bear is a hypercarnivorous bear whose native range lies largely within the Arctic Circle, encompassing the Arctic Ocean, its surrounding seas and surrounding land masses. It is a large bear, approximately the same size as the omnivorous Kodiak bear. A boar (adult male) weighs around 350–700 kg (772–1,543 lb), while a sow (adult female) is about half that size. Although it is the sister species of the brown bear, it has evolved to occupy a narrower ecological niche, with many body characteristics adapted for cold temperatures, for moving across snow, ice and open water, and for hunting seals, which make up most of its diet. Although most polar bears are born on land, they spend most of their time on the sea ice. Their scientific name means maritime bear and derives from this fact. Polar bears hunt their preferred food of seals from the edge of sea ice, often living off fat reserves when no sea ice is present. Because of their dependence on the sea ice, polar bears are classified as marine mammals.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/66/Polar_Bear_-_Alaska_%28cropped%29.jpg"
            });

            Bears.Add(new Animal
            {
                Name = "Spectacled Bear",
                Location = "South America",
                Details = "The spectacled bear, also known as the Andean bear or Andean short-faced bear and locally as jukumari (Aymara), ukumari (Quechua) or ukuku, is the last remaining short-faced bear. Its closest relatives are the extinct Florida spectacled bear, and the giant short-faced bears of the Middle to Late Pleistocene age. Spectacled bears are the only surviving species of bear native to South America, and the only surviving member of the subfamily Tremarctinae. The species is classified as Vulnerable by the IUCN because of habitat loss.",
                ImageUrl = "image1.jpg"
            });

            Bears.Add(new Animal
            {
                Name = "Cave Bear",
                Location = "Extinct",
                Details = "The cave bear was a species of bear that lived in Europe and Asia during the Pleistocene and became extinct about 24,000 years ago during the Last Glacial Maximum. Both the word cave and the scientific name spelaeus are used because fossils of this species were mostly found in caves. This reflects the views of experts that cave bears may have spent more time in caves than the brown bear, which uses caves only for hibernation.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6a/Teufelshöhle-Höhlenbär-Dreiviertelprofil.jpg/320px-Teufelshöhle-Höhlenbär-Dreiviertelprofil.jpg"
            });

            Bears.Add(new Animal
            {
                Name = "Short-faced Bear",
                Location = "Extinct",
                Details = "The short-faced bears is an extinct bear genus that inhabited North America during the Pleistocene epoch from about 1.8 Mya until 11,000 years ago. It was the most common early North American bear and was most abundant in California. There are two recognized species: Arctodus pristinus and Arctodus simus, with the latter considered to be one of the largest known terrestrial mammalian carnivores that has ever existed. It has been hypothesized that their extinction coincides with the Younger Dryas period of global cooling commencing around 10,900 BC.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/ArctodusSimusSkeleton.jpg/320px-ArctodusSimusSkeleton.jpg"
            });

            Bears.Add(new Animal
            {
                Name = "California Grizzly Bear",
                Location = "Extinct",
                Details = "The California grizzly bear is an extinct subspecies of the grizzly bear, the very large North American brown bear. Grizzly could have meant grizzled (that is, with golden and grey tips of the hair) or fear-inspiring. Nonetheless, after careful study, naturalist George Ord formally classified it in 1815 – not for its hair, but for its character – as Ursus horribilis (terrifying bear). Genetically, North American grizzlies are closely related; in size and coloring, the California grizzly bear was much like the grizzly bear of the southern coast of Alaska. In California, it was particularly admired for its beauty, size and strength. The grizzly became a symbol of the Bear Flag Republic, a moniker that was attached to the short-lived attempt by a group of American settlers to break away from Mexico in 1846. Later, this rebel flag became the basis for the state flag of California, and then California was known as the Bear State.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/d/de/Monarch_the_bear.jpg"
            }); */
        }
    }
}
