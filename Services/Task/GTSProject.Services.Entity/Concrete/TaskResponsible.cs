﻿using GTSProject.Services.Core.Entity;

namespace GTSProject.Services.Entity.Concrete
{
    public class TaskResponsible : IEntity // Talep sorumluluklarını tutar.
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public int CreatorUserId { get; set; }
    }
}
