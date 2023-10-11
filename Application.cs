using ABC_Bakery.Helpers;
using ABC_Bakery.Models;
using ABC_Bakery.Repositorys;

namespace ABC_Bakery
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            var db = new DatabaseContext();
            RoleRepository roleRepository = new RoleRepository(db);
            //roleRepository.Create(new Role { Name = "Admin" });
        }
    }
}