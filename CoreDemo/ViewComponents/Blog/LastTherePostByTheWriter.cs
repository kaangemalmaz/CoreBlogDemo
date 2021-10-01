using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Blog
{
    public class LastTherePostByTheWriter : ViewComponent
    {
        private readonly IBlogService _blogService;

        public LastTherePostByTheWriter(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var lastThreePost = _blogService.GetListBlogsByWriter(id);
            return View(lastThreePost);
        }
    }
}
