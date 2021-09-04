using System;
using System.Collections.Generic;
using NUnit.Framework;


[TestFixture]
public class HeroRepositoryTests
{
    private Hero hero;
    private HeroRepository repo;

    [SetUp]
    public void Setup()
    {
        repo = new HeroRepository();
        hero = new Hero("Pesho", 1);
    }

    [Test]
    public void CtorInitializesCollectionOfHeroes()
    {
        Assert.That(repo, Is.Not.Null);
    }


    [Test]
    public void WhenCreateHeroIsNull_ShouldThrowException()
    {
        Hero hero1 = null;  
        
        Assert.Throws<ArgumentNullException>(() =>
        {
            repo.Create(hero1);
        });       
    }

    [Test]
    public void WhenCreateHeroNameAlreadyExists_ShouldThrowException()
    {
        repo.Create(hero);

        Hero hero1 = new Hero("Pesho", 3); // Same name

        Assert.Throws<InvalidOperationException>(() =>
        {
            repo.Create(hero1);
        });       
    }

    [Test]
    public void WhenHeroIsAddedSuccessfuly_ShouldReturnCorrectMessage()
    {
        string result = repo.Create(hero);

        Assert.AreEqual(result, $"Successfully added hero {hero.Name} with level {hero.Level}");
    }

    [Test]
    public void WhenRemoveCalledAndCellDoesNotExist_ShouldThrowException()
    {
        Assert.Throws<ArgumentNullException>(() =>
        {
            repo.Remove("");
        });
    }

    [Test]
    public void WhenHeroIsRemovedSuccessfuly_ShouldReturnCorrectMessage()
    {
        repo.Create(hero); //  
        bool result = repo.Remove(hero.Name); 

        Assert.AreEqual(result, true);
    }

    [Test]
    public void GetHeroWithHighestLevel_ShouldReturnCorrectHero()
    {
        Hero hero1 = new Hero("Pesho", 1);
        Hero hero2 = new Hero("Gosho", 2);
        Hero hero3 = new Hero("Misho", 3);

        repo.Create(hero1); 
        repo.Create(hero2); 
        repo.Create(hero3);
        
        Hero result = repo.GetHeroWithHighestLevel(); 

        Assert.AreEqual(result, hero3);
    }

    [Test]
    public void GetHeroByName_ShouldReturnCorrectHero()
    {
        Hero hero1 = new Hero("Pesho", 1);
        Hero hero2 = new Hero("Gosho", 2);
        Hero hero3 = new Hero("Misho", 3);

        repo.Create(hero1);
        repo.Create(hero2);
        repo.Create(hero3);

        Hero result = repo.GetHero("Gosho");

        Assert.AreEqual(result, hero2);
    }

    //[Test]
    //public void Heroes_AsreadOnlyCollection()
    //{
    //    Hero hero1 = new Hero("Pesho", 1);
    //    Hero hero2 = new Hero("Gosho", 2);
    //    Hero hero3 = new Hero("Misho", 3);

    //    repo.Create(hero1);
    //    repo.Create(hero2);
    //    repo.Create(hero3);

    //    foreach (var item in repo.Heroes)
    //    {
    //        Assert.That(item, Is.InstanceOf<IReadOnlyCollection<Hero>>());
    //    }    
    //}

}