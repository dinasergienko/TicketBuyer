﻿using System;
using System.Collections.Generic;

namespace TicketBuyer.ViewModels
{
    public class EventViewModel : EventLiteViewModel
    {
        public string Information { get; set; }

        public int PlaceId { get; set; }

        public PlaceLiteViewModel Place { get; set; }

        public IList<EventCommentViewModel> EventComments { get; set; }

        //public ICollection<EventPhoto> EventPhotos { get; set; }
    }
}