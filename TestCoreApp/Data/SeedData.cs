namespace TestCoreApp.Data
{
    public static class SeedData
    {
        // static GUIDs for Roles
        public static readonly Guid AdminRoleId = Guid.Parse("5f4d4b1f-e1f1-4f23-98d3-0123456789ab");
        public static readonly Guid UserRoleId = Guid.Parse("7a8c6d3b-efcb-48f9-bb27-fedcba098765");

        // static stamps (you can also make these Guid.Parse if you prefer)
        public const string AdminConcurrencyStamp = "a2a1b3c5-d4f6-4e9c-9f23-567890abcdef";
        public const string UserConcurrencyStamp = "b7f4a6d9-1734-4ff2-bc33-334455667788";
    }
}
