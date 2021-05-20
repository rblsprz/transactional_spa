using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class LocationDataEF
    {
        public List<GetProvinces_Result> ListAllProvinces()
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                return context.GetProvinces().ToList();
            }
        }

        public List<GetCantonsByIdProvince_Result> ListCantonsByIdProvince(int id)
        {

            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                var cantons = context.GetCantonsByIdProvince(id).ToList();

                return cantons;

            }

        }

        public List<GetDistrictsByIdCanton_Result> ListDistrictsByIdCanton(int id)
        {

            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                var districts = context.GetDistrictsByIdCanton(id).ToList();

                return districts;

            }

        }


    }
}