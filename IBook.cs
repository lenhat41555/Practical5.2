using System;
using System.Collections.Generic;
namespace Practical5._2
{
    internal class IBook
    {
       public int ID{get;set;}
       public string Name{get;set;}
       public DateTime PublishDate{get;set;}
       public string Author {get;set;}
       public string Language{get;set;}
       public float AveragePrice{get;set;}
       public void Display(){

       }
    }
}