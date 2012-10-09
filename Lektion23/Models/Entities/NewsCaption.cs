using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lektion23.Models.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lektion23.Models.Entities
{
    public class NewsCaption : IEntity
    {
        //[Key, ForeignKey("News")]
        public Guid ID { get; set; }
        //public virtual News News { get; set; }
        public string Caption { get; set; }
    }
}