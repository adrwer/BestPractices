using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestige.Biz
{
    public class Actor
    {
        public Actor()
        {
            Console.WriteLine("An actor is born");
        }

        public Actor(string actorName): this()
        {
            ActorName = actorName;
        }

        private string actorName;

        public string ActorName
        {
            get { return actorName; }
            set
            {
                var formattedValue = value?.Trim();
                actorName = formattedValue;
            }
        }


        private string jobTitle;

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public int ActorAge { get; set; }
        public string ActorDescription { get; set; } =
            "Regular actor";

        /// <summary>
        /// This is will return the title
        /// </summary>
        /// <returns></returns>
        public string GetOccupation()
        {
            jobTitle = "Actor";
            return jobTitle;
        }

        /// <summary>
        /// Books actor and no date specified
        /// </summary>
        public string BookActor()
        {
            return BookActor(string.Empty);
        }

        /// <summary>
        /// Books actor on specific date
        /// </summary>
        /// <param name="theDate"></param>
        public string BookActor(string theDate)
        {
            string details = "Booking can change if" +
                " actor starts trouble";
            string theActor = "Actor " + ActorName + " is booked";

            if (theDate != string.Empty)
            {
                return theActor + " on " + theDate + ". "  + details;
            }
            else
            {
                return theActor + ". "  + details;
            }
            
        }

        public string GetAgency()
        {
            var currentAgency = new Agency();
            return currentAgency.Name;
        }
    }
}
