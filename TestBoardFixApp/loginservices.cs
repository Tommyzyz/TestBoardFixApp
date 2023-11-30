

namespace TestBoardFixApp
{
    public static class loginServices
    {
        public static bool login(string username)
        {
            if(username == "admin")
            return true;
            else return false;
        }
    }
}
