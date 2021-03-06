﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trakker.Data;
using Trakker.Helpers;
using Trakker.Infastructure.Streams.Activity.Model;

namespace Trakker.Models.Ticket
{
    public class TicketDetailsModel : MasterModel
    {
        public Trakker.Data.Ticket Ticket { get; set; }
        public IList<Comment> Comments { get; set; }
        public IList<ActivityGroupModel> ActivityGroups { get; set; }
    }
}
