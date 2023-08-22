using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGitADeux.src
{
    public class PeopleContainer : IPersonContainer<Person>
    {
        public List<Person> people { get; private set; }
        public PeopleContainer(List<Person> _people = null) 
        {
            if (_people == null)
            {
                people = new List<Person>();
            }
            else
            {
                people= _people;
            }
        }
        public List<Person>? SortByFirstName()
        {
            if (people.Count > 0)
            {
                Person[] ap = people.OrderBy(p => p.FirstName).ToArray();
                List<Person> lp = new List<Person>();
                foreach (Person p in ap)
                {
                    lp.Add(p);
                }
                return lp;
            }
            else
            {
                return null;
            }
        }

        public List<Person>? SortByLastName()
        {
            if (people.Count > 0)
            {
                Person[] ap = people.OrderBy(p => p.LastName).ToArray();
                List<Person> lp = new List<Person>();
                foreach (Person p in ap)
                {
                    lp.Add(p);
                }
                return lp;
            }
            else
            {
                return null;
            }
        }
    }
}
