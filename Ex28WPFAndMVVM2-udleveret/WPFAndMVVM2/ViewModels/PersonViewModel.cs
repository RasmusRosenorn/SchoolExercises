using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class PersonViewModel
    {
        private Person person;
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _phone;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public PersonViewModel(Person person)
        {
            this.person = person;
            this.FirstName = person.FirstName;
            this.LastName = person.LastName;
            this.Age = person.Age;
            this.Phone = person.Phone;
        }

    }
}
