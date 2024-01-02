namespace CostManeger.Models.Utils
{
    public enum Profiles
    {
        General = 1,
        Viewer = 2,
        Administrator = 3
    }

    public static class ProfileOptins
    {
        public static string GetProfileDescription(int profile)
        {
            string description;

            switch (profile)
            {
                case 1:
                    description = "General";
                    break;
                case 2:
                    description = "Viewer";
                    break;
                case 3:
                    description = "Administrator";
                    break;
                default:
                    description = "General";
                    break;
            }

            return description;
        }
    }
}
