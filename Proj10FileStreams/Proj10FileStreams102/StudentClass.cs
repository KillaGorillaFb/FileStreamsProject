using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj10FileStreams102
{
    /// <summary>
    /// This class defines a student class
    /// </summary>
    class StudentClass
    {
        private string lastName,
            firstName;
        private int idNumber;
        string className,
            grade;
        
        #region Constructors
        /// <summary>
        /// This constructor requires all parameters
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <param name="idNumber"></param>
        /// <param name="className"></param>
        /// <param name="grade"></param>
        public StudentClass(string lastName, string firstName, int idNumber, string className, string grade)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.idNumber = idNumber;
            this.className = className;
            this.grade = grade;
        }

        /// <summary>
        /// Default No Arg Constructor
        /// </summary>
        public StudentClass()
        {
        }
        #endregion

        #region Getters/Setters 
        /// <summary>
        /// Getters/ Setters
        /// </summary>
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public int IdNumber
        {
            get
            {
                return idNumber;
            }

            set
            {
                idNumber = value;
            }
        }

        public string ClassName
        {
            get
            {
                return className;
            }

            set
            {
                className = value;
            }
        }

        public string Grade
        {
            get
            {
                return grade;
            }

            set
            {
                grade = value;
            }


        }
        #endregion

        #region Methods
        //Methods
        /// <summary>
        /// Output Data In Listbox Format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return lastName + ", " +
                   firstName + ":\t" +
                   idNumber + "\t" +
                   className + "\t" +
                   grade;
        }//end of tostring

        /// <summary>
        /// Output Data In File Format
        /// </summary>
        /// <returns></returns>
        public string ToFileString()
        {
            return lastName + "," +
                   firstName + "," +
                   idNumber + "," +
                   className + "," +
                   grade;
        }//end of tofilestring
        #endregion
    }
}
