﻿using System;
using ENode.Commanding;

namespace ConferenceManagement.Commands
{
    [Serializable]
    public class UpdateSeatType : AggregateCommand<Guid>
    {
        public Guid SeatTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public UpdateSeatType(Guid conferenceId) : base(conferenceId) { }
    }
}
