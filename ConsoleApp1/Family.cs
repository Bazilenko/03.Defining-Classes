using System;

    public class Family
    {
        private List<Person> members = new List<Person>();
        public void AddMember(Person member)
        {
            members.Add(member);
        }
        public Person GetOldestMember()
        {
            Person oldest = null;
            foreach (var member in members)
            {
                if (oldest == null || member.Age > oldest.Age)
                {
                    oldest = member;
                }
            }
            return oldest;

        }
    }
    
