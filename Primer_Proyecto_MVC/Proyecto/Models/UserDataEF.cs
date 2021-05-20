using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class UserDataEF
    {

        public List<SelectUsers_Result> ListAllUsers()
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                var users = context.SelectUsers().ToList();

                return users;

            }
        }
    }
}