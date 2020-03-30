using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityRegistry.Data
{
    /// <summary>
    /// A class representing a person associated with the university
    /// </summary>
    public class Person
    {
        /// <summary>
        /// The next ID to assign to a newly-created person
        /// </summary>
        public static uint NextID = 80000000;

        /// <summary>
        /// The uinque identifier of this person
        /// </summary>
        public uint ID { get; private set; }

        /// <summary>
        /// The person's first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The person's last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The person's date of birth
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// If this person is active in the university (currently a part of the university)
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// The person's role
        /// </summary>
        public Role Role { get; set; }
        
        /// <summary>
        /// Creates a new user, assigning them an ID
        /// </summary>
        public Person()
        {
            ID = NextID++;
        }
    }
}
