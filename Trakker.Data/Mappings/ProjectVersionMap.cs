﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace Trakker.Data.Mappings
{
    class ProjectVersionMap : ClassMap<ProjectVersion>
    {
        public ProjectVersionMap()
        {
            Id(pv => pv.Id).GeneratedBy.Identity();
            Map(pv => pv.Name);
            Map(pv => pv.Description);
            Map(pv => pv.ReleaseDate);
            Map(pv => pv.IsReleased);


            References<Project>(pv => pv.Project)
                .Column("ProjectId")
                .Not.Insert()
                .Not.Update();            
        }
    }
}
