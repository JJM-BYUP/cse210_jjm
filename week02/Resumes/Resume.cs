
public class Resume
{
    public string _name = "";
    public List<Job> _jobList = new List<Job>();

    public void ResumeDisplay()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job jobInfo in _jobList)
        {
            // Alternative from sample code example: job.Display();
            Console.WriteLine($"{jobInfo._company} {jobInfo._jobTitle} {jobInfo._startYear}-{jobInfo._endYear}");
        }
    }
}