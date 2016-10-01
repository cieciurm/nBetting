using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBetting.Domain.Entities
{
    public class User : Entity
    {
        public string Login { get; set; }

        public User(string login)
        {
            Login = login;
        }

        protected User()
        {
            
        }
    }
}
