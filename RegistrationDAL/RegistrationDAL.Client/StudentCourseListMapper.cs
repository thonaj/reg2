﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationDAL;
using RegistrationClient.Models;

namespace RegistrationDAL.Client
{
   public class StudentCourseListMapper
   {
      public StudentCourseList MapToStudentCourseList(StudentCourseListDAO studentCourseList)
      {
         var scl = new StudentCourseList();
         scl.courseID = studentCourseList.courseID;
         scl.StudentCourseID = studentCourseList.StudentCourseID;
         scl.studentID = studentCourseList.studentID;
         scl.active = studentCourseList.active;

         return scl;
      }
      public StudentCourseListDAO MapToStudentCourseListDAO(StudentCourseList studentCourseList)
      {
         var scl = new StudentCourseListDAO();
         scl.Course = new CourseMapper().MapToCourseDAO(studentCourseList.Course);
         scl.courseID = studentCourseList.courseID;
         scl.Student = new StudentMapper().MapToStudentDAO(studentCourseList.Student);
         scl.StudentCourseID = studentCourseList.StudentCourseID;
         scl.studentID = studentCourseList.studentID;
         scl.Course = new CourseMapper().MapToCourseDAO(studentCourseList.Course);
         scl.active = studentCourseList.active;

         return scl;
      }
   }
}
