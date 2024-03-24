// See https://aka.ms/new-console-template for more information

using tpmodul6_1302223010;

public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo_1302223010 video = null;

        try
        {
            video = new SayaTubeVideo_1302223010("Tutorial Design By Contract - Riva Dwi Fadhillah Fajri Permana");
            for (int i = 0; i < 10000000; i++)
            {
                video.IncreasePlayCount(1);
            }
        }
    }
}