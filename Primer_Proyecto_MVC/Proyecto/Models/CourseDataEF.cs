using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class CourseDataEF
    {
        public int Add(Course course)
        {
            int resultToReturn;

            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                resultToReturn = context.InsertUpdateCourse(
                                       course.Id,
                                       course.Initials,
                                       course.Name,
                                       course.IsActive,
                                       course.Credits,
                                       course.Cycle,
                                       "Insert");
            }
            return resultToReturn;
        }

        public int Update(Course course)
        {
            int resultToReturn;

            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                resultToReturn = context.InsertUpdateCourse(
                                       course.Id,
                                       course.Initials,
                                       course.Name,
                                       course.IsActive,
                                       course.Credits,
                                       course.Cycle,
                                       "Update");
            }
            return resultToReturn;
        }

        public List<SelectCourse_Result> ListAllCourses()
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                var courses = context.SelectCourse().ToList();

                return courses;

            }
        }

        public GetCourseById_Result GetCourseById(int id)
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                var course = context.GetCourseById(id).Single();

                return course;

            }
        }


        public int DeleteCourse(int id)
        {
            int resultToReturn;

            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                resultToReturn = context.DeleteCourse(id);
            }
            return resultToReturn;
        }

        public List<GetStudentCourses_Result> GetStudentCourses(int id)
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                var studentCourses = context.GetStudentCourses(id).ToList();

                return studentCourses;

            }
        }

        public List<GetProfessorCourses_Result> GetProfessorCourses(int id)
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                var professorCourses = context.GetProfessorCourses(id).ToList();

                return professorCourses;

            }
        }

        public List<GetProfessorByIdCourse_Result> GetProfessorByIdCourse(int id)
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                var professorCourses = context.GetProfessorByIdCourse(id).ToList();

                return professorCourses;

            }
        }

        public int AddPublicConsultation(PublicConsultation publicConsultation)
        {
            int resultToReturn;

            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                resultToReturn = context.InsertPublicConsultation(
                                       publicConsultation.CourseId,
                                       publicConsultation.StudentId,
                                       publicConsultation.ProfessorId,
                                       publicConsultation.Motive,
                                       publicConsultation.DateTime);
            }
            return resultToReturn;
        }


        public int AddRepliesPublicConsultation(RepliesPublicConsultation repliesPublicConsultation)
        {
            int resultToReturn;

            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                resultToReturn = context.InsertRepliesPublicConsultation(
                                       repliesPublicConsultation.PublicConsultationId,
                                       repliesPublicConsultation.StudentId,
                                       repliesPublicConsultation.ProfessorId,
                                       repliesPublicConsultation.Motive,
                                       repliesPublicConsultation.DateTime);
            }
            return resultToReturn;
        }

        public int AddPrivateMessage(PrivateMessage privateMessage)
        {
            int resultToReturn;

            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                resultToReturn = context.InsertPrivateMessage(
                                       privateMessage.CourseId,
                                       privateMessage.StudentId,
                                       privateMessage.ProfessorId,
                                       privateMessage.Motive,
                                       privateMessage.DateTime);
            }
            return resultToReturn;
        }

        public List<GetPublicConsultation_Result> GetPublicConsultation(int courseId, int professorId)
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                var publicConsultation = context.GetPublicConsultation(courseId, professorId).ToList();

                return publicConsultation;

            }
        }

        public List<GetPrivateMessage_Result> GetPrivateMessage(int courseId, int professorId)
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                var privateMessage = context.GetPrivateMessage(courseId, professorId).ToList();

                return privateMessage;

            }
        }

        public List<GetRepliesPublicConsultation_Result> GetRepliesPublicConsultation(int publicConsultationId)
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                var replies = context.GetRepliesPublicConsultation(publicConsultationId).ToList();

                return replies;

            }
        }

        public int AddRepliesPrivateMessage(RepliesPrivateMessage repliesPrivateMessage)
        {
            int resultToReturn;

            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                resultToReturn = context.InsertRepliesPrivateMessage(
                                       repliesPrivateMessage.PrivateMessageId,
                                       repliesPrivateMessage.StudentId,
                                       repliesPrivateMessage.ProfessorId,
                                       repliesPrivateMessage.Motive,
                                       repliesPrivateMessage.DateTime);
            }
            return resultToReturn;
        }

        public List<GetRepliesPrivateMessage_Result> GetRepliesPrivateMessage(int privateMessageId)
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                var replies = context.GetRepliesPrivateMessage(privateMessageId).ToList();

                return replies;

            }
        }

        public int AddAppointment(Appointment appointment)
        {
            int resultToReturn;

            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                resultToReturn = context.InsertAppointment(
                                       appointment.CourseId,
                                       appointment.StudentId,
                                       appointment.ProfessorId,
                                       appointment.Motive,
                                       appointment.Accepted,
                                       appointment.DateTime.ToString());
            }
            return resultToReturn;
        }

        public int UpdateStatusAppointment(Appointment appointment)
        {
            int resultToReturn;

            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                resultToReturn = context.StatusAppointment(
                                       appointment.Id,
                                       appointment.Accepted);
            }
            return resultToReturn;
        }

        public List<GetAppointment_Result> GetAppointment(int studentId, int professorId, int courseId)
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                var appointment = context.GetAppointment(studentId,professorId, courseId).ToList();

                return appointment;

            }
        }

        public GetAppointmentById_Result GetAppointmentById(int id)
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                var appointment = context.GetAppointmentById(id).Single();

                return appointment;

            }
        }

        public List<GetAppointmentProfessor_Result> GetAppointmentProfessor(int professorId, int courseId)
        {
            using (var context = new MVC_IF4101MVCLPACEntities())
            {
                var appointment = context.GetAppointmentProfessor(professorId, courseId).ToList();

                return appointment;

            }
        }
    }
}