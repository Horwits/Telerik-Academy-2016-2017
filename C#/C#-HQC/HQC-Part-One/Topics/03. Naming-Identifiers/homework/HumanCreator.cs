/*class Hauptklasse
{
  enum Пол { ултра_Батка, Яка_Мацка };
  class чуек
  {
    public Пол пол { get; set; }
    public string име_на_Чуека { get; set; }
    public int Възраст { get; set; }
  }       
  public void Make_Чуек(int магическия_НомерНаЕДИНЧОВЕК)
  {
    чуек new_Чуек = new чуек();
    new_Чуек.Възраст = магическия_НомерНаЕДИНЧОВЕК;
    if (магическия_НомерНаЕДИНЧОВЕК%2 == 0)
    {
      new_Чуек.име_на_Чуека = "Батката";
      new_Чуек.пол = Пол.ултра_Батка;
    }
    else
    {
      new_Чуек.име_на_Чуека = "Мацето";
      new_Чуек.пол = Пол.Яка_Мацка;
    }
  }
}
*/

namespace Humans
{
    using System;

    public class HumanCreator
    {
        public void CreateHuman(int age)
        {
            Human human = new Human();
            human.Age = age;

            bool areAgeAnEvenNumber = age % 2 == 0;
            if (areAgeAnEvenNumber)
            {
                human.Name = "Dude";
                human.Gender = Gender.Man;
            }
            else
            {
                human.Name = "Chick";
                human.Gender = Gender.Women;
            }
        }
    }
}