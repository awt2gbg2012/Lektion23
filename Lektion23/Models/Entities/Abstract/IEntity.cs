﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lektion23.Models.Entities.Abstract
{
    public interface IEntity
    {
        Guid ID { get; set; }
    }
}
