using StudentServiceLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Score8_Should_ReturnA()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Huy";
            s.Age = 30;
            s.Score = 8;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void Score8_Should_ReturnB()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Huy";
            s.Age = 30;
            s.Score = 7.0;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void Score8_Should_ReturnC()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Huy";
            s.Age = 30;
            s.Score = 6.0;

            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void Score8_Should_ReturnD()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Huy";
            s.Age = 30;
            s.Score = 3.5;

            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }

        [TestMethod]
        public void Score8_Should_ReturnE()
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Huy";
            s.Age = 30;
            s.Score = 2;

            char letter = s.getLetterScore();
            Assert.AreEqual('E', letter);
        }

        [TestMethod]

        public void addFirstStudent_Success_True()
        {
            StudentService sv = new StudentService();
            Student s = new Student() { Id = 1, Name = "Thanh", Age = 21, Score = 9 };

            bool status = sv.addStudent(s);
            Assert.IsTrue(status);

            int size = sv.size();
            Assert.AreEqual(1, size);


        }

       

    }
}