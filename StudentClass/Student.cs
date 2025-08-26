namespace StudentClass
{
    public class Student
    {
        //build first to create the dll file - changes have to rebuild
        public string strName;
        private int intMark;
        public Student()
        {
            strName = "";
            intMark = 0;
        }
        public Student(string name, int mark)
        {
            strName = name;
            intMark = mark;
        }
        public Student(string name)
        {
            strName = name;
            intMark = 0;
        }
        public override string ToString()
        {
            return "Name is " + strName + ", Mark is " + intMark;
        }
    }
}
