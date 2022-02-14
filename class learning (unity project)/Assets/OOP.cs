using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//monobehaviours can be attached to Unity game objects 
public class OOP : MonoBehaviour
{
    private void Start()
    {
        Red t = new Red(50);
        t.Drive();

    }
    //private void Start()
    //{
    //    Fish fish;//create an empty varible that stores fish data type 
    //    //instantiate fish and store in variable
    //    fish = new Fish("Goldfish", 7);
    //    fish.PrintAnimal(); //call PrintAnimal method from fish 
    //}
}

//abstract class can only be omherited from, not instantiated
public abstract class Animal
{
    //encapsulated data can only be changed from within the class
    private string name;   
    private int age;

    //class constructor for instantiating the object
    public Animal(string _name,int _age) 
    {
        name = _name;
        age = _age;
    }
    
    //Abstract method must be implemented in al serived (child) classes
    public abstract void Eat();
    public abstract void Eat(string food);

    //Virtual method may have implementation overriden
    public virtual void PrintAnimal() 
    { 
      Debug.Log("name: " + name);
      Debug.Log("age: " + age);
    }
 }  
  
public class Fish: Animal//fish class inherits the animal class
{
    //Fish constructor
    //passes parameters to base class constructor
    public Fish(string _name,int _age) : base(_name, _age)
    {
        
    }

    //Override version of Animal's Eat method
    public override void Eat() { }


    public override void Eat(string food)
    {
        Debug.Log("fish has eaten" + food);
    }

    //Extended version of anime's PrintAnimal method
    public override void PrintAnimal()
    {
        base.PrintAnimal();
        Debug.Log("this is a fish");
    }
}

public abstract class Vechicle
{
    private int speed;


    public Vechicle(int _speed)
    {
        speed = _speed;
    }

    public virtual void Drive()
    {
        Debug.Log("Driving at " + speed + "KMpH"); 
    }
}


public class Red : Vechicle 
{
    public Red(int _speed) : base(_speed)
    {
    }

    public override void Drive()
    {
        base.Drive();
        Debug.Log("We be crusing");
    }

}
