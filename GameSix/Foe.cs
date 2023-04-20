using System;

namespace GameSix
{
 public class Foe
 {
  private int powerUp;
  private string name;
  private float health;
  private float shield;
  public Foe (string name)
  {
   this.name = name;
   health = 100;
   shield = 0;
   powerUp = 0;
  }
  public string GetName()
  {
   return name;
  }
  public void TakeDamage (float damage)
  {
   shield -= damage;
   if (shield < 0)
   {
   float damageStillTolnflict =- shield;
   shield = 0;
   health -= damageStillTolnflict;
   if (health < 0) health = 0;
   }
  }
  public float GetHealth()
  {
   return health;
  }
  public float GetShield()
  {
   return shield;
  }
  public void SetName(string newName)
  {    
   newName = newName.Trim(); 
   if (newName.Length > 0 && newName[0] != ' ' && newName[newName.Length - 1] != ' ')
   {
    name = newName;
   }
  }
  public int GetPowerUp()
  {
   return powerUp;
  }
  public void PickupPowerUp(PowerUp p, float f)
  {
   if(p == PowerUp.Health)
   {
    health += f;
    powerUp++;
   }
   else if(p == PowerUp.Shield)
   {
    shield += f;
    powerUp++;
   } 
   else
   {
    if (shield > 100 || health > 100)
    {
     Console.WriteLine("not possible");
    }
    
   }
  }

 
  
 }
}