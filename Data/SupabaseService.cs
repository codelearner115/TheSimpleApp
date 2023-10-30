namespace TheSimpleApp.Data
{
    // Services/SupabaseService.cs
    public class SupabaseService
    {
        private readonly Supabase.Client _client;

        public SupabaseService()
        {
            _client = new Supabase.Client("projectURL", "publicKey");
        }

        public Supabase.Client Client => _client;
    }

}
