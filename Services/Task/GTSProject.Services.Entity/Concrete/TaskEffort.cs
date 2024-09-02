﻿using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskEffort : IEntity // Talep eforlarını içerir.
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public int TaskEffortTypeId { get; set; }
        public int ConfirmedByUserId { get; set; }
    }
}
