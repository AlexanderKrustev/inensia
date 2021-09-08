using System;
using System.Text;

namespace Task1
{
    public class MovieStar
    {
        public string Name { get; set; }

        public string Surname{ get; set; }

        public string Sex { get; set; }

        public string Nationality { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age => (int)(DateTime.Now - DateOfBirth).TotalDays/365;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Name+" "+this.Surname);
            sb.AppendLine(this.Sex);
            sb.AppendLine(this.Nationality);
            sb.AppendLine(this.Age.ToString());
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
