namespace D.StudentClass
{
    public delegate void PropertyChangedEventHandler(Student student, PropertyChangedEventArgs args);

    public class Student
    {
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Name", this.name, value));
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(
                        this, 
                        new PropertyChangedEventArgs("Age", this.age.ToString(), value.ToString()));
                }

                this.age = value;
            }
        }     
    }
}
