using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

public class MyScript : MonoBehaviour
{
    // This is a class 
    // a collection of varibales and methods (functions)
    // a blueprint for behaviours
    // classes can inherit variables and methods from each other allowing modular code (*polymorphism*)
    // : indicates inheritance 
    // MonoBehaviour is the base class for all scripts we want to attatch to game objects
    // a variable is a container to store data we can compare, change and copy
    // we have to declare a variable before we can use it
    // public/private - whether the variable can be seen from another script
    // data type interger - a whole number 
    // data type - what kind of data the varible will hold 
    // float - number with decimal place
    // string - more than one character
    // char - name of character 
    public int myInterger;
    public float myFloat;
    public string myString;
    public char myChar;
    public Text scoreText;
    //methods let you manipulate variables
    //you can call methods or run them from inside other methods
    // in C# you can define your methods in any order
    public void MyMethod()
    {
        myInterger++;
        //myInterger = myInterger + 1;
        //myInterger += 1;
    }

    private void Start()
    {
        MyMethod();
    }


    private void Update()
    {
        scoreText.text = "Score: " + myInterger.ToString();
        //Score: 1
    }
}
