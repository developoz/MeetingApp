namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository ()
         {
            _users.Add(new UserInfo() {Id=1,Name="Zeynep",Email="abc@gmail.com",Phone="23244",WillAttend=true});

            _users.Add(new UserInfo() {Id=2,Name="Ozan",Email="ozan@gmail.com",Phone="32488",WillAttend=false});

            _users.Add(new UserInfo() {Id=3,Name="Ali",Email="ali@gmail.com",Phone="54657",WillAttend=true});

            

        }


        public static List<UserInfo> Users{
            get{
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
             _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}