namespace AbstraçãoRPG
{
    public abstract class Hero
    {
        public Hero (string Name, int level, string heroType, string specialPower,int XP, int energy) 
        {
           
            this.Name= Name;
            this.level = level;
            this.heroType = heroType;
            this.specialPower = specialPower;
            this.XP = XP;
            this.energy = energy;
                
        }
        public Hero (){

        }
      public string Name;

      public int level;

      public string heroType;  

      public string specialPower;

      public int XP;

      public int energy;

      public override string ToString()
      {
          return this.Name + " " + this.level + " " + this.heroType;
      }
         public virtual string attack()
         {

          return this.Name + " Atacou com o seu poder de";
         }



      
    }
}