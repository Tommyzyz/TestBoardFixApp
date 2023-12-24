namespace TestBoardFixApp.Serves
{
    public static class LoginServices
    {
        public static bool login(string username)
        {
            if (username == "admin")
                return true;
            else return false;
        }
    }
}
