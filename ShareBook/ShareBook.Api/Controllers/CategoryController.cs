﻿using Microsoft.AspNetCore.Mvc;
using ShareBook.Domain;
using ShareBook.Service;

namespace ShareBook.Api.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : BaseController<Category>
    {
        public CategoryController(ICategoryService categoryService) : base(categoryService)
        {
            SetDefault(x => x.Name);
        }
    }
}
