using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Lektion23.Models.Contexts;
using Lektion23.Models.Entities;

namespace Lektion23.Models.DBInitializers
{
    public class EFDbInitializer : DropCreateDatabaseAlways<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {
            var cat1 = new Category { ID = Guid.NewGuid(), 
                                        Name = "TestCat 1" };
            var cat2 = new Category { ID = Guid.NewGuid(), 
                                        Name = "TestCat 2" };
            var cat3 = new Category { ID = Guid.NewGuid(), 
                                        Name = "TestCat 3" };
            var catList = new List<Category> { cat1, cat2, cat3 };
            catList.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();

            var tag1 = new Tag { ID = Guid.NewGuid(), Name = "Tag 1" };
            var tag2 = new Tag { ID = Guid.NewGuid(), Name = "Tag 2" };
            var tagList = new List<Tag> { tag1, tag2 };
            tagList.ForEach(t => context.Tags.Add(t));
            context.SaveChanges();

            var news1 = new News {  ID = Guid.NewGuid(),
                                    Title = "News Title 1",
                                    Body = "News Body 1", 
                                    CategoryID = cat1.ID };
            var news2 = new News {  ID = Guid.NewGuid(), 
                                    Title = "News Title 2", 
                                    Body = "News Body 2",
                                    CategoryID = cat2.ID };
            var news3 = new News {  ID = Guid.NewGuid(), 
                                    Title = "News Title 3", 
                                    Body = "News Body 3", 
                                    CategoryID = cat3.ID };
            news1.Tags = new List<Tag>(); news1.Tags.Add(tag1); news1.Tags.Add(tag2);
            news2.Tags = new List<Tag>(); news2.Tags.Add(tag1);
            news3.Tags = new List<Tag>(); news3.Tags.Add(tag2);
            var newsList = new List<News> { news1, news2, news3 };
            newsList.ForEach(n => context.News.Add(n));
            context.SaveChanges();

            var newsCaption1 = new NewsCaption
            {
                ID = news1.ID,
                Caption = "News Caption 1"
            };
            var newsCaption2 = new NewsCaption
            {
                ID = news2.ID,
                Caption = "News Caption 2"
            };
            var newsCaption3 = new NewsCaption
            {
                ID = news3.ID,
                Caption = "News Caption 3"
            };
            var captionList = new List<NewsCaption> { newsCaption1, 
                                                        newsCaption2, 
                                                        newsCaption3 };
            captionList.ForEach(nc => context.NewsCaptions.Add(nc));
            context.SaveChanges();
        }
    }
}