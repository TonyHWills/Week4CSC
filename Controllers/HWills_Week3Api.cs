using Microsoft.AspNetCore.Mvc;

namespace HWills_CS2_Week3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HWills_Week3Api : ControllerBase
    {
        [HttpPost(Name = "GetWeatherForecast")]
        public ActionResult<List<string>> IntListWork(List<int> lint)
        {
            List<string> stringyList = new List<string>();
            double count = 0;
            double sum = 0;
            double sumSq = 0;
            
            double standDev;

            lint.Sort();
            try{
               foreach (int i in lint){
                    if (count <= 0)
                    {
                        count++;
                        sum += i;
                        sumSq += i * i;
                        standDev = Math.Sqrt((sumSq - sum * sum / count) / (count - 1));
                        stringyList.Add("List too small");
                    }
                    else
                    {
                        count++;
                        sum += i;
                        sumSq += i * i;
                        standDev = Math.Sqrt((sumSq - sum * sum / count) / (count - 1));
                        stringyList.Add(count + ": Current S.D.: " + standDev);
                        //sConsole.WriteLine(LogObject(stringyList));
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong boss!");

            }
            Console.WriteLine("Sum: " + sum);

            return Accepted(stringyList);
        }
        string LogObject(string input)
        {
            return input;
        }
    }
}