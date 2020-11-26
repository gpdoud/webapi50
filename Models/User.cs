public class User {

    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public bool IsReviewer { get; set; }
    public bool IsAdmin { get; set; }

    public User() {
        Id = 0;
        Username = string.Empty;
        Password = "Train@MAX";
        Firstname = string.Empty;
        Lastname = string.Empty;
        Phone = string.Empty;
        Email = string.Empty;
        IsReviewer = false;
        IsAdmin = false;
    }
    
}