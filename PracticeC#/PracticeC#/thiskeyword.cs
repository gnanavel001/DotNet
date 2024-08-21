using System;

namespace thiskeyword
{
   
    public class ChildClass
    {
        public void printer(Parentclass insteanceofpant)
        {
            Console.WriteLine(" parent class Name : " + insteanceofpant.V);
        }
    }
    public class Parentclass
    {

        public string V { get; }
        public DateTime DateTime { get; }


        public Parentclass(string v, DateTime dateTime)
        {
            V = v;
            DateTime = dateTime;
            var childClassInstance = new ChildClass();
            childClassInstance.printer(this);
        }

        public DateTime getDateValue()
        {
            return DateTime;
        }
        public static void main(string[] args)
        {
            var insteanceofPant = new Parentclass("gnanavel", new DateTime(1999, 05, 18));
        }
    }

}