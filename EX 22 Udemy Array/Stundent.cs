namespace EX_22_Udemy
{
    internal class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Apart { get; set; }

        public Student(string name, string email, int apart)
        {
            Name = name;
            Email = email;
            Apart = apart;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Apartamento: {Apart}";
        }
    }
}
