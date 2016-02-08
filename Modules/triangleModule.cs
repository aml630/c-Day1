using Nancy;
using System;
using triangle;

namespace triangleprogram
{
  public class triangleModule : NancyModule
  {
    public triangleModule() {
      Get["/form"] = _ => {
        return View["form.html"];
      };

      Get["/triangle"] = _ => {
        inputTriangle newTriangle = new inputTriangle {
          side1 = Request.Query["Side1"],
          side2 = Request.Query["Side2"],
          side3 = Request.Query["Side3"],
          answer = "nothing"
        };

          if (newTriangle.side1 == newTriangle.side2 && newTriangle.side2 != newTriangle.side3) {
            newTriangle.answer = "isoceles";
            // return newTriangle.answer;
          } else if (newTriangle.side1 != newTriangle.side2 && newTriangle.side2 != newTriangle.side1){
            newTriangle.answer = "scalene";
            // return newTriangle.answer;
          }
          return View["triangle.html", newTriangle];
        };
    }
  }
}
