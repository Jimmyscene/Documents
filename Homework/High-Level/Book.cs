using System;

namespace Application
{
	public class Book
	{
		private string Title;
		private string ISBN;
		private string Publisher;
		private int Year;
		private Person Author;
		public Book(string title, string ISBN, string Publisher, int year, Person author)
		{
			this.Title=title;
			this.ISBN=ISBN;
			this.Publisher=Publisher;
			this.Year=year;
			this.Author=author;
		}
	 	public void setTitle(string title){
 			this.Title=title;
 		}
	        public void setISBN(string ISBN){
	        	this.ISBN=ISBN ;
	        }
	        public void setPublisher(string Publisher){
	        	this.Publisher=Publisher ;
	        }
	        public void setYear(int Year){
	        	this.Year=Year ;
	        }
	        public void setAuthor(Person Author){
	        	this.Author=Author;
	        }
	   	public string getTitle(){
			return this.Title;
	   	}
	        public string getISBN(){
	 		return this.ISBN;
	        }
	        public string getPublisher(){
 			return this.Publisher;
	        }
	        public int getYear(){
 			return this.Year;
	        }
	        public Person getAuthor(){
 			return this.Author;
	        }
	        public override bool Equals(object b){
	        	if(this.ISBN==((Book)b).getISBN()){
	        		return true;
	        	}
	        	else
	        		return false;
	        }
	        public override String ToString(){
			string representation = "Title: " + this.Title + "\nISBN: " + this.ISBN + "\nPublisher: " + this.Publisher + "\nYear: " + this.Year + "\nAuthor: " + this.Author;
			return representation;	        }
	}

	public class Person {
	  private string id;
	  private Name name;
	  private Address address;
	  public  Person(string i, Name n, Address a) {
	    id = i; name = n; address = a;
	  } 
	  public string GetId() {
	    return id;
	  }
	  public override string ToString() {
	    return name + "\n" + address;
	  }

	  public override bool Equals(object obj)
	  {
	      return id == ((Person)obj).id;
	  }
	}

	public class Address {
	  private string street;
	  private string city;
	  private string state;
	  private string zip;
	  public Address(string st, string cy, String se, String zp) {
	    street = st; city = cy; state = se; zip = zp;
	  } 
	  public override string ToString() {
	    return street + "\n" + city + ", " + state + " " + zip;
	  }
	}

	public class Name {
	  private string first;
	  private char initial;
	  private string last;
	          
	  public Name(string f, string l) {
	    first = f; 
	    last = l; 
	  }
	  public Name(string f, char i, string l) {
	    first = f;
	    last = l;
	    initial = i;  
	  } 
	  public override string ToString() {
	    if (initial == '\u0000')
	       return first + " " + last;
	    else  
	       return first + " " + initial + " " + last;
	  }
	}
	public class TestBook{
		public static void Main(){
			Book aBook= new Book("information","12456","PubHouse", 2004, new Person("01", new Name("Blake", "Easley"), new Address("914 Brookwood", "El Dorado", "AR", "717370")));
			Book bBook= new Book("Useless","654321","Data", 1994, new Person("02", new Name("Christian", "Beasley"), new Address("No idea", "El Dorado", "AR", "717370")));
			System.Console.WriteLine(aBook.Equals(bBook));
		}
	}
}
/*
  Write a class Called Book. It has following instance variables:
  A string type called title
  A string type called ISBN
  A string type called publisher
  A int type called year
  A Person type called author (You need to use classes like person, Name, Address from the textbook).

  Create one constructor. 
  Override a Tostring method to display information about the book.  
  Also override Equals method. Two Books are consider equal if their ISBN are same

  Create a class called TestBook. In its Main method declare and create two Book objects. Call their Tostring methods. Call Equals using one object and the other as parameter and display the result.
 */
