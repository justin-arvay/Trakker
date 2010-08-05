﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trakker.Data;

namespace Trakker.Services
{
    public interface ITicketService
    {
        /********* Ticket *********/
        Ticket GetTicketWithId(int id);
        IList<Ticket> TicketList(int pageSize, int index);
        Ticket GetTicketWithKeyName(string keyName);
        int CountTicketsWithAssignedTo(int userId);
        IList<Ticket> GetTicketsWithAssignedTo(int userId);
        IList<Ticket> GetNewestTicketsWithProjectId(int projectId, int limit);
        string GenerateTicketKeyName(int projectId);
        int TotalTickets();
        void Save(Ticket ticket);

        /********* Comment *********/
        IList<Comment> GetCommentsWithticketId(int id);
        Comment GetCommentWithId(int id);
        void Save(Comment comment);

        /********* Category *********/
        Category GetCategoryWithId(int id);
        IList<Category> GetAllCategories();

        /********* Priority *********/
        Priority GetPriorityWithId(int id);
        IList<Priority> GetAllPriorities();

        /********* Status *********/
        Status GetStatusWithId(int id);
        IList<Status> GetAllStatus();

        /********* Severity *********/
        Severity GetSeverityWithId(int id);
        IList<Severity> GetAllSeverities();

    }
}
