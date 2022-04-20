using System;

namespace LISClasses
{
    public class GTimer{
        private int hour = 0;
        public int Hour{
            get => hour;
            set{
                if(value >= 24)
                    hour = value % 24;
                else
                    hour = value;
            }
        }
        public int Minute{ get; set;} =0;

        override public string ToString() => string.Format("{0:D2}:{1:D2}",hour,Minute);
        
        public void SetClockNow(){
            DateTime now = DateTime.Now;

            if(now.Hour % 2 == 1) Hour = 12 + now.Minute;
            else Hour = now.Minute;
            Minute = now.Second;
        }
    }

    public class Food{
        public string name;
        public int neededlevel;
        public int cost;
        public int heal;
        
        public Food(string name,int neededlevel,int cost,int heal){
            this.name = name;
            this.neededlevel = neededlevel;
            this.cost = cost;
            this.heal = heal;
        }
    }

    public class Gold{

    }
}