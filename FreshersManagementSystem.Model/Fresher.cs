using System;

namespace FreshersManagementSystem.Model
{
    /// <summary>
    /// This class impeliment an application for an fresher model
    /// </summary>
    public class Fresher
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Fresher() { }

        /// <summary>
        /// Parameterized constructor for define an properties of fresher
        /// </summary>
        /// <param name="id">id of an fresher</param>
        /// <param name="name">name of an fresher</param>
        /// <param name="emailId">email id of an fresher</param>
        /// <param name="mobileNumber">mobile number of an fresher</param>
        /// <param name="address">address of an fresher</param>
        /// <param name="dateOfBirth">date of birth of an fresher</param>
        /// <param name="qualification">qualification of an fresher </param>
        public Fresher(string name, string emailId, string mobileNumber, string address, DateTime dateOfBirth, string qualification)
        {
            this.id = id;
            this.name = name;
            this.mobileNumber = mobileNumber;
            this.address = address;
            this.emailId = emailId;
            this.dateOfBirth = dateOfBirth;
            this.qualification = qualification;
        }

        public int id { get; set; }

        public string emailId { get; set; }

        public string name { get; set; }

        public string mobileNumber { get; set; }

        public string address { get; set; }

        public string qualification { get; set; }

        public DateTime dateOfBirth { get; set; }

    }
}
