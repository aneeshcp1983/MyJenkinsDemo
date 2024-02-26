using JenkinsDemo;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_sayJenkins_1()
        {
                TestMe obj1=new TestMe();
            String result = obj1.sayJenkins(2);
            Assert.AreEqual("JenkinsJenkins", result);

        }
        [Test]
        public void Test_sayJenkins_2()
        {
            TestMe obj1 = new TestMe();
            String result = obj1.sayJenkins(1);
            Assert.AreEqual("Jenkins", result);

        }
    }
}