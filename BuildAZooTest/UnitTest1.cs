using System;
using Xunit;
using BuildAZoo;
using BuildAZoo.Classes;
using BuildAZoo.Interfaces;

namespace BuildAZooTest
{
    public class UnitTest1
    {
        [Fact]
        public void HouseCatIsTypeAnimalAndFeline()
        {
            HouseCat sox = new HouseCat("Black&White", 10);

            Assert.IsAssignableFrom<Animal>(sox);
            Assert.IsAssignableFrom<Mammal>(sox);
            Assert.IsAssignableFrom<Feline>(sox);
        }
        [Fact]
        public void SnakeIsTypeAnimalAndReptile()
        {
            Snakes sox = new Snakes(false,true);

            Assert.IsAssignableFrom<Animal>(sox);
            Assert.IsAssignableFrom<Reptile>(sox);
        }
        [Fact]
        public void SunfishIsTypeAnimalAndAquatic()
        {
            Sunfish sox = new Sunfish();

            Assert.IsAssignableFrom<Animal>(sox);
            Assert.IsAssignableFrom<Aquatic>(sox);
            Assert.IsAssignableFrom<Fish>(sox);
        }
        [Fact]
        public void DerivedClassesHaveSoundFromAnimalAndIsOverriden()
        {
            HouseCat sox = new HouseCat("Black&White", 10);
            Sunfish sox2 = new Sunfish();
            Snakes sox3 = new Snakes(false, true);
            Tiger socks = new Tiger();
            Bird skcos = new Bird();
            Frog frog = new Frog();

            Assert.Equal("Meow meow", sox.Sound());
            Assert.Equal("glug glug", sox2.Sound());
            Assert.Equal("Croaaaak", frog.Sound());
            Assert.Equal("hissssss", sox3.Sound());
            Assert.Equal("Rawwwwr", socks.Sound());
            Assert.Equal("Tweet tweet", skcos.Sound());
        }
        [Fact]
        public void SnakesImplementsIEatPeopleAndIVenomous()
        {
            Snakes snake = new Snakes(true, true);

            string expected = "I'm just on a plane, minding my own business";

            Assert.True(snake.EatPeople);
            Assert.True(snake.Venomous);
            Assert.Equal(expected,snake.EatingPeople());
        }
        [Fact]
        public void TigerImplementsIEatPeople()
        {
            Tiger tiger = new Tiger();
            string expected = "sometimes things get complicated";

            Assert.Equal(expected, tiger.EatingPeople());
        }
        [Fact]
        public void ProveThatPolymorphismIsApparent()
        {
            Tiger tiger = new Tiger();
            Frog frog = new Frog();
            Animal bird = new Bird();

            string expectedTiger = "food";
            string expectedFrog = "Bugs";
            string expectedBird = "Dirt and stuff";

            Assert.Equal(expectedTiger, tiger.Diet());
            Assert.Equal(expectedFrog, frog.Diet());
            Assert.Equal(expectedBird, bird.Diet());
        }
    }
}
