using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebCalculator.Pages
{
    public enum CalcOperation
    {
        Nothing, Addition, Subtraction, Multiplication, Division
    }
    public class IndexModel : PageModel
    {
        public string Result { get; private set; }

        public void OnGet()
        {
            Result = "Result will be shown here.";
        }

        public void OnPost(int NumberA, int NumberB, CalcOperation Calc)
        {
            switch (Calc)
            {
                case CalcOperation.Nothing: Result = "Invalid operation"; break;
                case CalcOperation.Addition: Result = "Result: " + (NumberA + NumberB); break;
                case CalcOperation.Subtraction: Result = "Result: " + (NumberA - NumberB); break;
                case CalcOperation.Multiplication: Result = "Result: " + (NumberA * NumberB); break;
                case CalcOperation.Division:
                    Result = (NumberB == 0) ? "Result: Division by 0." : "Result: " + (NumberA / NumberB);
                    break;
            }
        }
    }
}
