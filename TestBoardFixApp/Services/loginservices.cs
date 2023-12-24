namespace TestBoardFixApp.Serves
{
    public static class loginservices
    {
        public static bool login(string username)
        {
            if (username == "admin")
                return true;
            else return false;
        }
    }
}
