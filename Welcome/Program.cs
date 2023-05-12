using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    class Program
    {

        static void Main(string[] args)
        {
            User user1;
            user1 = new User("Anastasiq Dimitrovska", "Mypass159", UserRolesEnum.STUDENT,/* "dimitrovskaanastasija80@gmail.com", "123220011",*/ 1);

            UserViewModel userViewModel;
            userViewModel = new UserViewModel(user1);

            UserView userView;
            userView = new UserView(userViewModel);

            userView.Display();

          
        }
    }
}