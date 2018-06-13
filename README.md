# Lab05-Built-A-Zoo

This project is practice in the fundamental Object-Oriented Programming(OOP) principles and how class inheritance and interface implementations are treated within the C# programming language. This README will guide you through the zoo that was designed with class inheritance as its main purpose.


## Visual
here
***

There are four fundamental OOP principals that we follow:
* Inheritance
* Abstraction
* Polymorphism
* Encaspulation

### Inheritance

Inheritance is the process in which a class can utilize what lives inside of a previous class while implementing additional properties and methods. The class inherting is known as a Derived Class and the class being inherited from is known as the Base Class

A derived class can only have one direct base class however that does not mean that it can't have multiple class functionalities. If ClassAnimal is inherited by ClassCanine which is then inherited by ClassHusky, ClassHusky has the same functionality as ClassCanine and ClassAnimal. Inheritence is transitive.

* example

```C#
public abstract Class Animal 
{
    public virtual bool Eyes {get; set;}
    public abstract int Legs {get; set;}

    public virtual string Diet() 
    {
        return "diet";
    }
    public abstract string Sound()
}
//---first layer
public abstract Class Mammal : Animal
{
    public virtual bool Hair { get; set; }
    public virtual bool Fur { get; set; }   
}
//--Second Layer
public abstract class Feline : Mammal
{
    public abstract int Size { get; set; }
    public override bool Fur { get; set; } = true;
    public override bool Eyes { get; set; } = true;

    public abstract bool Affection();
}
//--Third and Final Layer, making this class concrete
class HouseCat : Feline
{
    public override int Size { get; set; }
    public override int Legs { get; set; }
    public string FurColor { get; set; }

    public HouseCat(string furColor, int weight)
    {
        Legs = 4;
        FurColor = furColor;
        Size = weight;
    }

    public override string Diet()
    {
        return "Carnovoire";
    }

    public override string Sound()
    {
        return "Meow meow";
    }

    public override bool Affection()
    {
        return true;
    }
}
```

If you noticed, in my previous layers, anything that was labled abstract now has to have a definition. If it was labeled virtual, I have the choice to override it or use the default implementation.

### Abstraction

Abstraction is the the ability to provide a common definition that is utilized by multiple classes. You cannot instantiate an abstract class however these are useful for creating templates that have to be followed.

An Abstract Class is like a template whereas a Concrete Class is a blueprint.

If we take the previous example, you can see that I can instantiate the HouseCat class but I can't instantiate the Feline class. However, HouseCat is of type Feline as well.

```c#
HouseCat sox = new HouseCat("black&white", 10);

if(sox is Feline) Console.WriteLine(sox.Sound());
```

### Polymorphism

Polymorphism is the ability to change a property or method within a class that is used in different ways by multiple classes. We can use keywords such as virtual and override to implement this concept.

For example in our ClassAnimal, we have a virtual method called Sound() that returns a string "moo". Not every animal makes this moo sound, so a derived ClassDog wants to override this method to make sure that our ClassDog goes bark instead;

* example
```c#
public abstract Class Animal 
{
    public virtual bool Eyes {get; set;}
    public abstract int Legs {get; set;}

    public virtual string Diet() 
    {
        return "diet";
    }
    public abstract string Sound()
}
//--- HouseCat changed the return string for Diet
// as well as changed eyes from a bool to int
class HouseCat : Animal
{
    public override int Eyes {get; set;} = 1;
    public override int Size { get; set; }
    public override int Legs { get; set; }
    public string FurColor { get; set; }

    public override string Diet()
    {
        return "Carnovoire";
    }

    public override string Sound()
    {
        return "Meow meow";
    }
}
//-- Doggo has also changed the diet and sound methods
class Doggo : Animal
{
    public override bool Eyes {get; set; } = true;
    public override int Size { get; set; }
    public override int Legs { get; set; }
    public string FurColor { get; set; }

    public override string Diet()
    {
        return "Bacon Strips";
    }

    public override string Sound()
    {
        return "woof woof";
    }
}
```
### Encaspulation
We have accessor keywords that can determine the availabilty of properties or methods.
The main three we utilize -
* Public - Accessed by any and everyone
* Private - Accessible within that specific class
* Protected - Accessible to classes and derived class

Two important ones to keep in mind - 
* Internal - Useful when working within the project 
* Protected Internal - This deals directly with the SLN file

* example
```c#
class Doggo : Animal
{
    //Public means it can be accessed outside of the class
    public override bool Eyes {get; set; } = true;
    public override int Size { get; set; }
    public override int Legs { get; set; }
    private string FurColor { get; set; } //methods and properties
                                          //default
                                          //to private but using the keyword is
                                          //helps with visability 

    public override string Diet()
    {
        return "Bacon Strips";
    }
    public override string Sound()
    {
        return "woof woof";
    }
}
```
## Interfaces

An interface contains definitions of properties and methods that can be implemented by a class. These are very similar to abstract classes but the defining feature is that while a class and only have one direct base class, it can implement multiple interfaces.

This is useful since C# doesn't allow for multiple inheritance. For this Zoo I have implemented two interfaces: IEatPeople, IVenomous. IEatPeople is used to determine if the animal will eat a person and IVenomous is used for an animal that has poison.

* example
```c#
//This Tiger Class inherits from Feline and implements IEatPeople
class Tiger : Feline, IEatPeople
    {
        public override int Size { get; set; }
        public override int Legs { get; set; }
        public string FurColor { get; set; }
        public bool EatPeople { get; set; } = true;

        public override bool Affection()
        {
            return false;
        }

        public override string Diet()
        {
            return "Carnovoire";
        }

        public string EatingPeople()
        {
            return "sometimes things get complicated";
        }

        public override string Sound()
        {
            return "Rawwwwr";
        }
    }
//This Snakes Class inherits from Reptile and implements IEatPeople and
//IVenomous
public class Snakes : Reptile, IEatPeople, IVenomous
    {
        public override bool Scales { get; set; } = true;
        public override bool Feathers { get; set; } = false;
        public override bool Eyes { get; set; } = true;
        public override int Legs { get; set; } = 0;
        public bool EatPeople { get; set; }
        public bool Venomous { get; set; }

        public Snakes(bool eatPeople, bool venom)
        {
            Venomous = venom;
            EatPeople = eatPeople;
        }

        public string EatingPeople()
        {
            return "I'm just on a plane, minding my own business";
        }

        public string HowDeadly(int scale)
        {
            return $"Rated: {scale} on the posion scale";
        }

        public bool OnPlane()
        {
            return true;
        }

        public override string Sound()
        {
            return "hissssss";
        }
    }
```
## Updated Visual with Interfaces
here

