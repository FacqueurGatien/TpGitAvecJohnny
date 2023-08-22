using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGitADeux.src
{
    /// <summary>
    /// Représente une personne.
    /// </summary>
    public class Person
    {
        
        public string LastName { get; set; }
        public string FirstName { get; set; }

        /// <summary>
        /// Constructeur paramétré.
        /// </summary>
        /// <param name="_lastName">string</param> nom de la personne.
        /// <param name="_firstName">string</param> prénom de la personne.
        public Person(string _lastName, string _firstName)
        {
            LastName = _lastName;
            FirstName = _firstName;
        }

        /// <summary>
        /// retourne le nom et le prénom de la personne.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"nom : {LastName} prénom : {FirstName}.";
        }
    }
}
