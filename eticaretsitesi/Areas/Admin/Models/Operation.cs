namespace eticaretsitesi.Models
{
    public static class Operation
    {
        public static bool IsAdd(string action)
        {
            return action.EqualsNoCase("add");
        }
        public static bool IsDelete(string action)
        {
            return action.EqualsNoCase("delete");
        }
    }
}