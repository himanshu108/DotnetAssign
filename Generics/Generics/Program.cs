using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    class Program
    {
        static void Main(string[] args)
        {
            Players[] p = new Players[3]{
          new Players( "Dhoni", 45),
          new Players ("Rohit Sharma", 56),
          new Players("Sachin",55),
          };
            Team India = new Team(p);
            foreach (var user in India)
            {
                Console.WriteLine(user.Name + ", " + user.Score);
            }
            Console.ReadLine();
        }
    }
    public class Players
    {
        public Players(string name, int score)
        {

            this.Name = name;
            this.Score = score;
        }

        public string Name { get; set; }
        public int Score { get; set; }
    }
    //Implements IEnumerable Interface
    public class Team : IEnumerable
    {
        private Players[] _user;
        public Team(Players[] uArray)
        {
            _user = new Players[uArray.Length];
            for (int i = 0; i < uArray.Length; i++)
            {
                _user[i] = uArray[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public UsersEnum GetEnumerator()
        {
            return new UsersEnum(_user);
        }
    }
    // Implements IEnumerator Interface
    public class UsersEnum : IEnumerator
    {
        public Players[] _user;
        int currentIndex = -1;
        public UsersEnum(Players[] list)
        {
            _user = list;
        }
        public bool MoveNext()
        {
            currentIndex++;
            return (currentIndex < _user.Length);
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public Players Current
        {
            get
            {
                try
                {
                    return _user[currentIndex];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
