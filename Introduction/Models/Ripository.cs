using Microsoft.EntityFrameworkCore;

namespace Introduction.Models
{
    public class Ripository
    {
        private EFIntroDbContext _context;
        public Ripository()
        {
            EFIntroDbContext edb = new EFIntroDbContext();
            _context = edb;

        }
        public void AddPerson(string firstname, string lastname)
        {
            Person p = new()
            {
                Firstname = firstname,
                Lastname = lastname
            };
            _context.People.Add(p);
            _context.SaveChanges();
        }
        public void UpdatePerson(int id, string firstname, string lastname)
        {
            Person person = _context.People.Find(id);
            if (person != null)
            {
                person.Firstname = firstname;
                person.Lastname = lastname;
                _context.SaveChanges();
            }
            else if(person==null)
            {
                Console.WriteLine($"Your Selected Id: {id} is null");
            }
        }
        public void PrintPeople()
        {
            var person = _context.People.AsNoTracking().ToList();
            foreach (var p in person)
            {
                Console.WriteLine($"{p.Id}: {p.Firstname}  | {p.Lastname}");
            }
        }
        public void DeleteMembers(int id)
        {
            Person person= _context.People.Find(id);
            if(person!=null)
            {
                _context.People.Remove(person);
                _context.SaveChanges();
            }
        }
    }
}
