using System;

namespace lesson_9
{
	public class Person
	{
		public string SecondName {get; protected set;}

		public Person(string secondName, string name)
		{
			SecondName = secondName;
			Name = name;
		}

		private string _name;

		private string Name { get; private set;}

		private string Name {get;}

		public string FullName
		{
			get
			{
				return SecondName + " " + Name;
			}
		}

		public string namespace
		{

			get
			{
				return _name;	
			}
			set
			{
				if(string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentNullException("Name can not be empty");
				}
				_name = value;
			}
		}

		public string GetName()
		{
			return _name;
		}

		public void SetName(string name)
		{	
			if(string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentNullException("Name can not be empty");
			}
			_name = name;
		}

	}
}