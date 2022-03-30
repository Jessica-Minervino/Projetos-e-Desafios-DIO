namespace AbstraçãoRPG
{
    public class Wizard : Hero
    {
        public Wizard (string Name, int level, string heroType, string specialPower, int XP, int energy) 
        {
           
            this.Name = Name;
            this.level = level;
            this.heroType = heroType;
            this.specialPower = specialPower;
            this.XP = XP;
            this.energy = energy;   
        }
         public override string attack()
         {

          return this.Name + " Lançou magia";
         }
         
         public string attack(int bonus)
         {
             if (bonus >= 8 ){
            return this.Name + " Lançou o elemento special power com bônus de =" + bonus + "=" + " e com isso reduziu sua energia para " + (energy - 50);
             }else if (bonus > 5){
            return this.Name + " Lançou magia com bônus de =" + bonus + "=" + " e com isso reduziu sua energia para " + (energy - 25);     
             }else{
             return this.Name + " Lançou magia fraca com bônus de =" + bonus + "=" + " e com isso reduziu sua energia para " + (energy - 10);    
             }
             
         }
    }
}