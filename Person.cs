﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListExample
{
    public class Person
    {
        private string lastname;
        private string firstname;
        private string middlename;
        private int age;
        private string address;

        public Person(string lastname, string firstname,
            string middlename, int age, string address)
        {
            this.lastname = lastname;
            this.firstname = firstname;
            this.middlename = middlename;
            this.age = age;
            this.address = address;
        }

        public string Lastname
        {
            get { return lastname; }
            //set { lastname = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            //set { firstname = value; }
        }

        public string Middlename
        {
            get { return middlename; }
            //set { middlename = value; }
        }

        public int Age
        {
            get { return age; }
            //set { age = value; }
        }

        public string Address
        {
            get { return address; }
            //set { address = value; }
        }

    }
}
