using new_project_crud.Models;

namespace new_project_crud.Repositories
{
    public static class UserRepository
    {
        private static List<User> users = new();
        private static int currentId = 1;

        public static void Add(User user)
        {
            user.Id = currentId++;
            users.Add(user);
        }

        public static List<User> GetAll() => new(users);

        public static User? GetById(int id) =>
            users.FirstOrDefault(u => u.Id == id);

        public static bool Update(User user)
        {
            var existingUser = users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
                existingUser.Password = user.Password;
                return true;
            }

            return false;
        }

        public static bool Delete(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                users.Remove(user);
                return true;
            }
            return false;
        }

    }
}
