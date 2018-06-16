namespace Signature.Domain.Entities.SignIn
{
    public class ShortProfileModel
    {
        public int DeptId { get; set; }
        public string FirstName { get; set; }
        public string FirstNameEng { get; set; }
        public string Image { get; set; }
        public bool IsEnabled { get; set; }
        public string LastName { get; set; }
        public string LastNameEng { get; set; }
        public string Position { get; set; }
        public int ProfileId { get; set; }
        public string Room { get; set; }
    }
}
