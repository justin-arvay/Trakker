﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trakker.Infastructure.Streams.Activity.Model
{
    public class ActivityGroupModel
    {
        public Boolean IsWithinTheHour { get; set; }
        public Boolean IsToday { get; set; }
        public DateTime Created { get; set; }
        public IList<ActivityModel> Activities { get; set; }
    }
}
