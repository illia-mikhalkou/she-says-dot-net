using System;
using System.Collections.Generic;
using backend.ViewModels;

namespace Signature.Domain.Entities.SignIn
{
    /// <summary>
    /// 
    /// </summary>
    public class ProfileDetails
    {
        /// <summary>
        /// Gets or sets the birthday.
        /// </summary>
        /// <value>
        /// The birthday.
        /// </value>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Gets or sets the dept identifier.
        /// </summary>
        /// <value>
        /// The dept identifier.
        /// </value>
        public int DeptId { get; set; }

        /// <summary>
        /// Gets or sets the name of the domen.
        /// </summary>
        /// <value>
        /// The name of the domen.
        /// </value>
        public string DomenName { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the employment date.
        /// </summary>
        /// <value>
        /// The employment date.
        /// </value>
        public DateTime EmploymentDate { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the first name eng.
        /// </summary>
        /// <value>
        /// The first name eng.
        /// </value>
        public string FirstNameEng { get; set; }

        /// <summary>
        /// Gets or sets the group.
        /// </summary>
        /// <value>
        /// The group.
        /// </value>
        public object Group { get; set; }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the last name eng.
        /// </summary>
        /// <value>
        /// The last name eng.
        /// </value>
        public string LastNameEng { get; set; }

        /// <summary>
        /// Gets or sets the name of the middle.
        /// </summary>
        /// <value>
        /// The name of the middle.
        /// </value>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        /// <value>
        /// The phone.
        /// </value>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the profile identifier.
        /// </summary>
        /// <value>
        /// The profile identifier.
        /// </value>
        public int ProfileId { get; set; }

        /// <summary>
        /// Gets or sets the rank.
        /// </summary>
        /// <value>
        /// The rank.
        /// </value>
        public string Rank { get; set; }

        /// <summary>
        /// Gets or sets the room.
        /// </summary>
        /// <value>
        /// The room.
        /// </value>
        public string Room { get; set; }

        /// <summary>
        /// Gets or sets the skype.
        /// </summary>
        /// <value>
        /// The skype.
        /// </value>
        public string Skype { get; set; }





        public List<AchievementInfo> Achievements { get; set; }
    }
}
