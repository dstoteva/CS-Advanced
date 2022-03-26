using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.members = new List<Person>();
        }
        public void AddMember(Person member)
        {
            this.members.Add(member);
        }
        public Person GetOldestMember()
        {
            return this.members.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public List<Person> GetPeopleOver30()
        {
            return this.members.Where(x => x.Age > 30).ToList();
        }
    }
}
