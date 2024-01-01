namespace CostManeger.Models.Utils
{
    public enum Profiles
    {
        General = 0,
        Viewer = 1,
        Administrator = 2
    }

    public static class ProfileOptins
    {
        public static string GetProfileDescription(int profile)
        {
            string description;

            switch (profile)
            {
                case 0:
                    description = "General";
                    break;
                case 1:
                    description = "Viewer";
                    break;
                case 2:
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
