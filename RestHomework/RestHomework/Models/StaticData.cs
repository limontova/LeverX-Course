namespace RestHomework.Models
{
    public class StaticData
    {
        public static List<Group> Groups = new List<Group>()
        {
            new Group
            {
                GroupID = 1, Name = "Yellow",
                Students = new List<Student>()
                {
                    new Student()
                    {
                         StudentID = 1, Birthday = new DateTime(1999, 10, 10), Bonus = 1200, Bursary = 5000, Name = "Alex"
                    },
                    new Student()
                    {
                         StudentID = 2, Birthday = new DateTime(2000, 2, 13), Bonus = 0, Bursary = 0, Name = "Oleg"
                    },
                    new Student()
                    {
                         StudentID = 3, Birthday = new DateTime(2001, 12, 27), Bonus = 100, Bursary = 1000, Name = "Masha"
                    },
                }
            },
             new Group
            {
                GroupID = 2, Name = "Green",
                Students = new List<Student>()
                {
                    new Student()
                    {
                         StudentID = 4, Birthday = new DateTime(1998, 11, 3), Bonus = 1500, Bursary = 3000, Name = "Sergey"
                    },
                    new Student()
                    {
                         StudentID = 5, Birthday = new DateTime(2000, 8, 8), Bonus = 1000, Bursary = 2000, Name = "Ivan"
                    },
                    new Student()
                    {
                         StudentID = 6, Birthday = new DateTime(2000, 12, 12), Bonus = 1200, Bursary = 4000, Name = "Alena"
                    },
                }
            }
        };
    }
}
