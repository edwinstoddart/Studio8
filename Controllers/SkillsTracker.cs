using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studio8.Controllers
{
    [Route("skills")]
    public class SkillsTracker : Controller
    {
        // GET: /skills/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2><ol>" +
                    "<li>JavaScript</li>" +
                    "<li>C#</li>" +
                    "<li>Angular</li>" +
                "</h2></ol>";

            return Content(html, "text/html");
        }

        // GET: /skills/form/
        [HttpGet("form")]
        public IActionResult Form()
        {
            string html = "<form method='post' action='completeForm'>" +
                "<input type='date' name='entryDate'>" +
                "<h3>Javascript</h3><select name='javaScript'>" +
                    "<option value='Beginner'>Beginner</option>" +
                    "<option value='Intermediate'>Intermediate</option>" +
                    "<option value='Advanced'>Advanced</option>" +
                "</select>" +
                "<h3>C#</h3><select name='cSharp'>" +
                    "<option value='Beginner'>Beginner</option>" +
                    "<option value='Intermediate'>Intermediate</option>" +
                    "<option value='Advanced'>Advanced</option>" +
                "</select>" +
                "<h3>Angular</h3><select name='angular'>" +
                    "<option value='Beginner'>Beginner</option>" +
                    "<option value='Intermediate'>Intermediate</option>" +
                    "<option value='Advanced'>Advanced</option>" +
                "</select><br>" +
                "<input type='submit' value='Submit'></form>";
            return Content(html, "text/html");
        }

        [HttpPost("completeForm")]
        public IActionResult CompleteForm(string entryDate, string javaScript, string cSharp, string angular)
        {
            string html = $"<h1>{entryDate}</h1>" +
                "<table>" +
                    "<tr>" +
                        "<th>Javascript</th>" +
                        "<th>C#</th>" +
                        "<th>Angular</th>" +
                    "</tr><tr>" +
                    $"<td>{javaScript}</td>" +
                    $"<td>{cSharp}</td>" +
                    $"<td>{angular}</td>" +
                $"</tr>" +
                "</table>";

            return Content(html, "text/html");
        }
    }
}
