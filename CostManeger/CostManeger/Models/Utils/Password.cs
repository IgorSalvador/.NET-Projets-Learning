namespace CostManeger.Models.Utils
{
    public static class Password
    {
        public static string GenerateRandomPassword(int length = 10)
        {
            // Gerar nova senha aleatória
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789#@!&*+=-_";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }
    }
}
