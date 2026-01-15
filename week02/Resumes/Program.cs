using System;

class Program
{
    static void Main(string[] args)
    {
        // Enter job1 information using Job()
        Job job1 = new Job();
        job1._company = "Sunrise Engineering";
        job1._jobTitle = "Surveyor";
        job1._startYear = 2020;
        job1._endYear = 2023;

        // Enter job2 information using Job()
        Job job2 = new Job();
        job2._company = "Silverstar Communications";
        job2._jobTitle = "Technical Engineer";
        job2._startYear = 2023;
        job2._endYear = 2025;

        // Create resume job list and display it using Resume()
        Resume newResume = new Resume();
        // Enter user name
        newResume._name = "Jen Merritt";

        // Add both jobs to the Resume list
        newResume._jobList.Add(job1);
        newResume._jobList.Add(job2);

        newResume.ResumeDisplay();
    }
}