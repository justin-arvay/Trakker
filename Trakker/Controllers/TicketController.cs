using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Trakker.Helpers;
using Trakker.Data;
using Trakker.ViewData.TicketData;
using Trakker.Data.Services;
using AutoMapper;
using Trakker.Attributes;
using System.Web.UI.HtmlControls;

namespace Trakker.Controllers
{
    [Authenticate]
    public class TicketController : MasterController
    {
       
        public TicketController(ITicketService ticketService, IUserService userService, IProjectService projectService)
            : base(projectService, ticketService, userService)
        {
        }


        #region MainActionResults
        public ActionResult TicketDetails(string keyName)
        {
            Ticket ticket = _ticketService.GetTicketWithKeyName(keyName);

            IList<WidgetAction> comments = new List<WidgetAction>();

            foreach (Comment comment in _ticketService.GetCommentsWithticketId(ticket.TicketId))
            {
                comments.Add(new WidgetAction("Comment", "ticket", comment));
            }

            TicketDetailsViewData viewData = new TicketDetailsViewData()
            {
                Id = ticket.TicketId,
                Summary = ticket.Summary,
                Description = ticket.Description,
                Created = ticket.Created,
                DueDate = ticket.DueDate.Value,
                Status = _ticketService.GetStatusWithId(ticket.StatusId),
                Priority = _ticketService.GetPriorityWithId(ticket.PriorityId),
                Cateogory = _ticketService.GetCategoryWithId(ticket.CategoryId),
                KeyName = ticket.KeyName,
                Comments = comments,
                AssignedBy = _userService.GetUserWithId(ticket.AssignedByUserId),
                CreatedBy = _userService.GetUserWithId(ticket.CreatedByUserId),
                AssignedTo = _userService.GetUserWithId(ticket.AssignedToUserId)
            };
         
            return View(viewData);
        }

        [Authenticate]
        public ActionResult TicketList(int? index)
        {
            const int PAGE_SIZE = 10;
            User user;

            IDictionary<int, Priority> priorities = new Dictionary<int, Priority>();
            IDictionary<int, Status> status = new Dictionary<int, Status>();
            IDictionary<int, Category> categories = new Dictionary<int, Category>();
            IDictionary<int, User> users = new Dictionary<int, User>();

            foreach (var p in _ticketService.GetAllPriorities()) priorities.Add(p.PriorityId, p);
            foreach (var s in _ticketService.GetAllStatus())status.Add(s.StatusId, s);        
            foreach (var c in _ticketService.GetAllCategories()) categories.Add(c.CategoryId, c);

            IList<Ticket> tickets = _ticketService.TicketList(PAGE_SIZE, index ?? 1);
            foreach (Ticket ticket in tickets)
            {
                if (users.ContainsKey(ticket.AssignedToUserId) == false)
                {
                    user = _userService.GetUserWithId(ticket.AssignedToUserId);
                    users.Add(user.UserId, user);
                }

                if (users.ContainsKey(ticket.AssignedByUserId) == false)
                {
                    user = _userService.GetUserWithId(ticket.AssignedByUserId);
                    users.Add(user.UserId, user);
                }

                if (users.ContainsKey(ticket.CreatedByUserId) == false)
                {
                    user = _userService.GetUserWithId(ticket.CreatedByUserId);
                    users.Add(user.UserId, user);
                }
            }
            
            TicketListViewData viewData = new TicketListViewData()
            {
                Items = tickets,
                Users = users,
                Priorities = priorities,
                Categories = categories,
                Status = status,
                Pagination = new WidgetAction("ticketListPagination", "Nav", new
                { 
                    pageIndex = index ?? 1,
                    totalItemCount = _ticketService.TotalTickets(),
                    pageSize = PAGE_SIZE
                })
            };


            return View(viewData);
        }


        public ActionResult CreateTicket()
        {
            CreateEditViewData viewData = new CreateEditViewData()
            {
                Categories = _ticketService.GetAllCategories(),
                Priorities = _ticketService.GetAllPriorities(),
                Status = _ticketService.GetAllStatus(),
                Users = _userService.GetAllUsers(),
                Projects = _projectService.GetAllProjects(),
                Resolutions = _ticketService.GetAllResolutions()
            };


            return View(viewData);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult CreateTicket(CreateEditViewData viewData)
        {
            if (ModelState.IsValid)
            {
                Mapper.CreateMap<CreateEditViewData, Ticket>();
                Ticket ticket = Mapper.Map(viewData, new Ticket());

                ticket.CreatedByUserId = _userService.CurrentUser.UserId;
                ticket.AssignedByUserId = _userService.CurrentUser.UserId;
                ticket.Created = DateTime.Now;

                _ticketService.Save(ticket);
                UnitOfWork.Commit();

                return RedirectToAction<TicketController>(x => x.TicketList(1));
            }

            viewData.Categories = _ticketService.GetAllCategories();
            viewData.Priorities = _ticketService.GetAllPriorities();
            viewData.Status = _ticketService.GetAllStatus();
            viewData.Users = _userService.GetAllUsers();
            viewData.Projects = _projectService.GetAllProjects();
            viewData.Resolutions = _ticketService.GetAllResolutions();

            return View(viewData);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult EditTicket(string keyName)
        {
            Ticket ticket = _ticketService.GetTicketWithKeyName(keyName);

            if (ticket == null) throw new Exception("redirect, ticket doesnt exist!");

            CreateEditViewData viewData = new CreateEditViewData()
            {
                Projects = _projectService.GetAllProjects(),
                Categories = _ticketService.GetAllCategories(),
                Priorities = _ticketService.GetAllPriorities(),
                Status = _ticketService.GetAllStatus(),
                Users = _userService.GetAllUsers()
            };

            Mapper.CreateMap<Ticket, CreateEditViewData>();
            viewData = Mapper.Map(ticket, viewData);

            return View(viewData);
        }
         
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditTicket(string keyName, CreateEditViewData viewData)
        {
            Ticket ticket = _ticketService.GetTicketWithKeyName(keyName);

            if (ticket == null) throw new Exception("redirect, ticket doesnt exist!");

            if (ModelState.IsValid)
            {
                Mapper.CreateMap<CreateEditViewData, Ticket>();
                ticket = Mapper.Map(viewData, ticket);

                _ticketService.Save(ticket);
                UnitOfWork.Commit();

                return RedirectToAction<TicketController>(x => x.TicketDetails(ticket.KeyName));
            }

            viewData.Categories = _ticketService.GetAllCategories();
            viewData.Priorities = _ticketService.GetAllPriorities();
            viewData.Status = _ticketService.GetAllStatus();
            viewData.Users = _userService.GetAllUsers();
            viewData.Projects = _projectService.GetAllProjects();

            return View(viewData);
        }

        #endregion

        #region Comment

        public ActionResult CreateComment(string keyName)
        {
            Ticket ticket = _ticketService.GetTicketWithKeyName(keyName);

            if(ticket == null)
                throw new Exception("need a redirect here! the ticket does not exist");

            return View(new CommentCreateEditViewData());
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult CreateComment(string keyName, Comment comment)
        {

            Ticket ticket = _ticketService.GetTicketWithKeyName(keyName);
            
            if (ticket == null)
                throw new Exception("need a redirect here! the ticket does not exist");
                        
            try
            {
                comment.Created = DateTime.Today;
                comment.Modified = DateTime.Today;
                comment.UserId = 1;
                comment.TicketId = ticket.TicketId;
                _ticketService.Save(comment);

                return RedirectToAction<TicketController>(x => x.TicketDetails(keyName));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public ActionResult EditComment(string keyName, int id)
        {
            Ticket ticket = _ticketService.GetTicketWithKeyName(keyName);
            Comment comment = _ticketService.GetCommentWithId(id);

            if (ticket == null) throw new Exception("redirect, ticket does not exist");
            if (comment == null) throw new Exception("redirect, comment does not exist");

            if (comment.TicketId != ticket.TicketId) throw new Exception("redirect, comment does not belong to this ticket");
            if (comment.UserId != 1) throw new Exception("redirect comment does not belong to this user");

            CommentCreateEditViewData viewData = new CommentCreateEditViewData()
            {
                Comment = comment
            };

            return View(viewData);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditComment(string keyName, int id, Comment comment)
        {
            Ticket ticket = _ticketService.GetTicketWithKeyName(keyName);
            Comment originalComment = _ticketService.GetCommentWithId(id);

            if (ticket == null) throw new Exception("redirect, ticket does not exist");
            if (ticket == null) throw new Exception("redirect, comment does not exist");

            if (originalComment.TicketId != ticket.TicketId) throw new Exception("redirect, comment does not belong to this ticket");
            if (originalComment.UserId != 1) throw new Exception("redirect comment does not belong to this user");

            try
            {
                originalComment.Body = comment.Body;
                originalComment.Modified = DateTime.Now;
                _ticketService.Save(originalComment);
            }
            catch (Exception e)
            {
                throw new Exception();
            }

            CommentCreateEditViewData viewData = new CommentCreateEditViewData()
            {
                Comment = comment
            };

            return View(viewData);
        }

        #endregion

        #region Widgets

        public ActionResult Comment(Comment comment)
        {
            CommentViewData viewData = Mapper.Map<Comment, CommentViewData>(comment);

            return PartialView(viewData);
        }
        #endregion

        #region Priority

        public ActionResult CreatePriority()
        {
            return View(new CreateEditPriorityViewData());
        }

        [HttpPost]
        public ActionResult CreatePriority(CreateEditPriorityViewData viewData)
        {
            if (ModelState.IsValid)
            {
                Mapper.CreateMap<CreateEditPriorityViewData, Priority>();
                Priority priority = Mapper.Map(viewData, new Priority());

                _ticketService.Save(priority);
                UnitOfWork.Commit();
            }

            return View(viewData);
        }
        #endregion

        #region Resolution
        public ActionResult CreateResolution()
        {
            return View(new CreateEditResolutionViewData());
        }

        [HttpPost]
        public ActionResult CreateResolution(CreateEditResolutionViewData viewData)
        {
            if (ModelState.IsValid)
            {
                Mapper.CreateMap<CreateEditResolutionViewData, Resolution>();
                Resolution resolution = Mapper.Map(viewData, new Resolution());

                _ticketService.Save(resolution);
                UnitOfWork.Commit();
            }

            return View(viewData);
        }
        #endregion
    }
}
