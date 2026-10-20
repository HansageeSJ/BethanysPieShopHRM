
namespace BethanysPieShopHRM.HR
{
    internal class Developer : Employee
    {
        // Developer-specific properties and methods can be added here. Need to create the constructor.

        private string currentProject;

        public string CurrentProject
        {
            get { return currentProject; }
            set
            {
                currentProject = value;
            }
        }

        public Developer(string firstName, string lastName, string email, DateTime birthday, double? hourlyRate)
            : base(firstName, lastName, email, birthday, hourlyRate)
        {
        }
    }
}