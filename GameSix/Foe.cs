namespace GameSix
{
 public class Foe
 {
  private string name;
  private float health;
  private float shield;
  public Foe (string name)
  {
   this.name = name;
   health = 100;
   shield = 0;
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
 }
}