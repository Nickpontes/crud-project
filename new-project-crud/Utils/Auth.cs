namespace new_project_crud.Utils
{
    public static class Auth
    {
        public static bool Login(string email, string password)
        {
            // Simulated authentication
            return email == "admin@example.com" && password == "admin";
        }
    }
}
