using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class ProfessorDataEF
    {
        public int Add(Professor professor, Location location, User user)
        {
            int resultToReturn;

            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                resultToReturn = context.InsertUpdateProfessor(professor.Id,
                                       user.Username,
                                       user.Password,
                                       user.IsAdministrator,
                                       user.Status,
                                       professor.Name,
                                       professor.LastName,
                                       professor.Mail,
                                       professor.Image,
                                       location.ProvinceId,
                                       location.CantonId,
                                       location.DistrictId,
                                       professor.AcademicDegreeId,
                                       "Insert");
            }
            return resultToReturn;
        }

        public int Update(Professor professor, Location location, User user)
        {
            int resultToReturn;

            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                resultToReturn = context.InsertUpdateProfessor(professor.Id,
                                       user.Username,
                                       user.Password,
                                       user.IsAdministrator,
                                       user.Status,
                                       professor.Name,
                                       professor.LastName,
                                       professor.Mail,
                                       professor.Image,
                                       location.ProvinceId,
                                       location.CantonId,
                                       location.DistrictId,
                                       professor.AcademicDegreeId,
                                       "Update");
            }
            return resultToReturn;
        }

        public List<SelectProfessor_Result> ListAllProfessors()
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                var professors = context.SelectProfessor().ToList();

                return professors;

            }
        }

        public GetProfessorById_Result GetProfessorById(int id)
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                var professor = context.GetProfessorById(id).Single();

                return professor;

            }
        }


        public int DeleteProfessor(int id)
        {
            int resultToReturn;

            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                resultToReturn = context.DeleteProfessor(id);
            }
            return resultToReturn;
        }

        public List<SelectAcademicDegree_Result> ListAcademicDegree()
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                return context.SelectAcademicDegree().ToList();
            }
        }

        public int AddSocialNetwork(SocialNetworksProfessor socialNetworksProfessor)
        {
            int resultToReturn;

            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                resultToReturn = context.InsertUpdateSocialNetworkProfessor(socialNetworksProfessor.Id,
                                       socialNetworksProfessor.ProfessorId,
                                       socialNetworksProfessor.Url,
                                       socialNetworksProfessor.SocialNetworksNameId,
                                       "Insert");
            }
            return resultToReturn;
        }

        public int AddProfessorCourse(ProfessorCourse professorCourse)
        {
            int resultToReturn;

            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                resultToReturn = context.InsertProfessorCourse(professorCourse.ProfessorId,
                                       professorCourse.CourseId);
            }
            return resultToReturn;
        }

        public List<GetNameSocialNetworks_Result> ListSocialNetworksCatalog()
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                return context.GetNameSocialNetworks().ToList();
            }
        }

        public List<GetSocialNetworksByIdProfessor_Result> GetSocialNetworksByIdProfessor(int id)
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                var socialNetworks = context.GetSocialNetworksByIdProfessor(id).ToList();

                return socialNetworks;

            }
        }

        public int UpdateImage(Professor professor)
        {
            int resultToReturn;

            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                resultToReturn = context.UpdateProfessorImage(professor.Image, professor.Id);
            }
            return resultToReturn;
        }
    }
}