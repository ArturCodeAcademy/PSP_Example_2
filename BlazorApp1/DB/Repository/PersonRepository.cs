namespace BlazorApp1.DB.Repository
{
	public class PersonRepository
	{
		private readonly Context _context;

		public PersonRepository(Context context)
		{
			_context = context;
		}

		public void AddPerson(Models.Person person)
		{
			_context.People.Add(person);
			_context.SaveChanges();
		}

		public List<Models.Person> GetPeople(int skip, int take)
		{
			return _context.People.Skip(skip).Take(take).ToList();
		}

		public List<Models.Person> GetPeopleWithNamesStartingWith(string begin)
		{
			return _context.People.Where(p => p.Name.StartsWith(begin)).ToList();
		}
	}
}
