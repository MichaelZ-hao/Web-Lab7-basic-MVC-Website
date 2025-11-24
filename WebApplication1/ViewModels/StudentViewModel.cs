using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class StudentViewModel
    {
        public IQueryable<Student> Students { get; set; }
        public string Search { get; set; }
        public IEnumerable<CategoryWithCount> CatsWithCount { get; set; }
        public string Category { get; set; }
        public IEnumerable<SelectListItem> CatFilterItems
        {
            get
            {
                var allCats = CatsWithCount.Select(cc => new SelectListItem
                {
                    Value = cc.CampusName,
                    Text = cc.CatNameWithCount
                });
                return allCats;
            }
        }
        public class CategoryWithCount
        {
            public int StudentCount { get; set; }
            public string CampusName { get; set; }
            public string CatNameWithCount
            {
                get
                {
                    return CampusName + " (" + StudentCount.ToString() + ")";
                }
            }
        }
    }
}