using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion23.Models.Entities.Abstract;

namespace Lektion23.Models.Entities
{
    public class News : IEntity
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public Guid CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual NewsCaption NewsCaption { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}