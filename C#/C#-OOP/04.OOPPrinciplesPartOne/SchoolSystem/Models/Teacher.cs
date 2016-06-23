namespace SchoolSystem.Models
{
    using System.Collections.Generic;

    using SchoolSystem.Interfaces;

    public class Teacher : Person, ICommentable
    {
        private ICollection<Discipline> setOfDisciplines;

        public Teacher(string name)
            : base(name)
        {
            this.setOfDisciplines = new List<Discipline>();
        }

        public ICollection<Discipline> SetOfDisciplines
        {
            get
            {
                return new List<Discipline>(this.setOfDisciplines);
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.setOfDisciplines.Add(discipline);
        }

        public string Teach()
        {
            var message = this.Name + " " + "is teaching...";
            return message;
        }
    }
}
