using DAL.Repositories.Base;
using DATA;

namespace DAL.Repositories
{
    public class ClassroomRepository : BaseRepository<Classroom, string>
    {
        public void Update(Classroom newClassroom)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                Classroom oldClassroom = _context.Classrooms.FirstOrDefault(x => x.ID == newClassroom.ID);
                if (oldClassroom != null)
                {
                    oldClassroom.IsLessonsOnMonday = newClassroom.IsLessonsOnMonday;
                    oldClassroom.IsLessonsOnTuesday = newClassroom.IsLessonsOnTuesday;
                    oldClassroom.IsLessonsOnWednesday = newClassroom.IsLessonsOnWednesday;
                    oldClassroom.IsLessonsOnThursday = newClassroom.IsLessonsOnThursday;
                    oldClassroom.IsLessonsOnFriday = newClassroom.IsLessonsOnFriday;
                    oldClassroom.IsLessonsOnSaturday = newClassroom.IsLessonsOnSaturday;
                    oldClassroom.IsLessonsOnSunday = newClassroom.IsLessonsOnSunday;
                    oldClassroom.DailyEducationHour = newClassroom.DailyEducationHour;
                    oldClassroom.EducationStartTime = newClassroom.EducationStartTime;
                    oldClassroom.EducationFinishTime = newClassroom.EducationFinishTime;
                    oldClassroom.ModificationDate = newClassroom.ModificationDate;
                    oldClassroom.LessonsCountUntilMoficationDate = oldClassroom.LessonsCountUntilMoficationDate + newClassroom.LessonsCountUntilMoficationDate;
                   _context.SaveChanges();
                }
            //}
        }

        //public void FillComboboxwithClassroomsByBranchID(ComboBox cmbBox, int branchID)
        //{
        //    ClassroomRepository classroomRepository = new ClassroomRepository();
        //    var list = classroomRepository.GetClassroomsByBranch(branchID);

        //    if (list.Count > 0)
        //    {
        //        foreach (var item in list)
        //        {
        //            cmbBox.Items.Add(item.ID);
        //        }
        //    }
        //}

        public Classroom GetClassroomByClassroomID(string classroomID)
        {
            //using (AppDbContext context = new AppDbContext())
            //{
                return _context.Classrooms.FirstOrDefault(x => x.ID == classroomID);
            //}

        }

        // Raporda kullanıyoruz.
        public List<int> GetLessonDays(string classroomID)
        {
            List<int> lessonDays = new List<int>();

            Classroom classroom = GetClassroomByClassroomID(classroomID);
            if (classroom != null)
            {
                if (classroom.IsLessonsOnMonday == true)
                    lessonDays.Add(1);
                if (classroom.IsLessonsOnTuesday == true)
                    lessonDays.Add(2);
                if (classroom.IsLessonsOnWednesday == true)
                    lessonDays.Add(3);
                if (classroom.IsLessonsOnThursday == true)
                    lessonDays.Add(4);
                if (classroom.IsLessonsOnFriday == true)
                    lessonDays.Add(5);
                if (classroom.IsLessonsOnSaturday == true)
                    lessonDays.Add(6);
                if (classroom.IsLessonsOnSunday == true)
                    lessonDays.Add(7);

                return lessonDays;
            }
            return lessonDays;
        }


    }
}
