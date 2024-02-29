using DataAccessLayer;
using System;
using System.Web.Mvc;

public class EmployeeController : Controller
{

    BlogInfoRepository blogOperations = new BlogInfoRepository();
    public static string user;
 
    public ActionResult BlogList()
    {
        user = (string)Session["User"];
        return View(blogOperations.GetUserBlog(user));
    }

    public ActionResult SaveBlog()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult SaveBlog(FormCollection c)
    {
        if (ModelState.IsValid)
        {
            BlogInfo blog = new BlogInfo
            {
                BlogId = Convert.ToInt32(c["BlogId"]),
                Title = c["Title"],
                Subject = c["Subject"],
                DateOfCreation = DateTime.Parse(c["DateOfCreation"]),
                BlogUrl = c["BlogUrl"],
                EmpEmailId = c["EmpEmailId"]
            };
            blog.EmpEmailId = user;
            blogOperations.Insert(blog);
            blogOperations.Save();
            return RedirectToAction("BlogList");
        }
        return View("BlogList");
    }

   
    public ActionResult Edit(int id)
    {
        BlogInfo blogInfo = blogOperations.GetBlogId(id);
        return View(blogInfo);
    }

  
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit([Bind(Include = "BlogId,Title,Subject,DateOfCreation,BlogUrl,EmpEmailId")] BlogInfo blogInfo)
    {
        if (ModelState.IsValid)
        {
            blogOperations.Update(blogInfo);
            blogOperations.Save();
            return RedirectToAction("BlogList");
        }
        return View(blogInfo);
    }

  
    public ActionResult Delete(int id)
    {
        BlogInfo blogInfo = blogOperations.GetBlogId(id);
        return View(blogInfo);
    }

  
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult DeleteConfirmed(int id)
    {
        blogOperations.Delete(id);
        blogOperations.Save();
        return RedirectToAction("BlogList");
    }
}