using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Coast Communications";
        job1._title = "Billing Specialist";
        job1._start = 2005;
        job1._end = 2025;

        //Console.WriteLine(job1._company);


        //job1.DisplayJob();


        Job job2 = new Job();
        job2._company = "Church of Jesus Christ of Latter-day Saints";
        job2._title = "Public Affairs Specialist";
        job2._start = 2020;
        job2._end = 2025;

        //job2.DisplayJob();

        

        Resume myResume = new Resume();

        myResume._name = "Melanie Emry";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();

    }


}