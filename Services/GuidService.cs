
namespace WebApplication1.Services
{
    public class GuidService : IGuidService
    {
        private string _specialGuid;
        public GuidService()
        {
            Console.WriteLine("GuidService constructor called");
            _specialGuid = Guid.NewGuid().ToString();
        }
        public string GetSpecialGuidFromWeb()
        {
            return _specialGuid;
        }
    }
}
