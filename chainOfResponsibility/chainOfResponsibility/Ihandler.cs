using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainOfResponsibility
{
    public interface Ihandler
    {
     Ihandler SetNexthandler(Ihandler handler);
        string Handle(string s); 
    }


    public class MonkeyHandler : Ihandler
    {
        public Ihandler _next;

      public  Ihandler SetNexthandler(Ihandler handler)
        {

            _next = handler;
            return _next;
        }

        public string Handle(string s)
        {
            if(s =="monkey")
            {
                Console.Write("Handled by monkey handler");
                return s;
            }
            else
            {
              return  _next.Handle(s);
            }

        }
    }


    public class DogHandler : Ihandler
    {
        public Ihandler _next;

        public Ihandler SetNexthandler(Ihandler handler)
        {

            _next = handler;
            return _next;
        }

        public string Handle(string s)
        {
            if (s == "dog")
            {
                Console.Write("Handled by dog handler");
                return s;
            }
            else
            {
                return _next.Handle(s);
            }

        }
    }

    public class SquirrelHandler : Ihandler
    {
        public Ihandler _next;

        public Ihandler SetNexthandler(Ihandler handler)
        {

            _next = handler;
            return _next;
        }

        public string Handle(string s)
        {
            if (s == "squirrel")
            {
                Console.Write("Handled by squirrel handler");
                return s;
            }
            else
            {
                return _next.Handle(s);
            }

        }
    }
}
