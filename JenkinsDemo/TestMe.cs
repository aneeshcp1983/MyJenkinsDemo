namespace JenkinsDemo
{
    public class TestMe
    {

        public String sayJenkins(int times)
        {
            String OUTPUT = "";
            for (int i = 0; i < times; i++) 
            {
                OUTPUT += "Jenkins";
            }
            return OUTPUT;
        }

    }
}
