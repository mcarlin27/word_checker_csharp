using Nancy;
using WordCounter.Objects;
using System.Collections.Generic;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      }; //homepage
      Post["/"] = _ => {
        RepeatCounter wordCheck = new RepeatCounter();
        string firstInput = Request.Form["first-input"];
        string secondInput = Request.Form["second-input"];
        int output = wordCheck.CountRepeats(firstInput, secondInput);
        // string stringOutput = output.ToString();
        // Dictionary<string, string> model = new Dictionary<string, string>();
        // model.Add("first-input", firstInput);
        // model.Add("instances", stringOutput);
        // model.Add("second-input", secondInput);
        return View["results.cshtml", output];
      }; //displays results
    }
  }
}
