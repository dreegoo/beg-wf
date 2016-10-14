﻿using System;
using System.Activities;
using System.Activities.Tracking;

namespace LeadGenerator
{
    /*****************************************************/
    // This custom activity creates a Lead class using
    // the input parameters (ContactName, ContactPhone, 
    // Interests and Notes).  A Lead record is inserted 
    // into the database and then this is returned in 
    // the Lead output parameter.  
    /*****************************************************/
    public sealed class CreateLead : CodeActivity
    {
        public InArgument<string> ContactName { get; set; }
        public InArgument<string> ContactPhone { get; set; }
        public InArgument<string> Interests { get; set; }
        public InArgument<string> Notes { get; set; }
        public OutArgument<Lead> Lead { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            // Create a Lead class and populate it with the input arguments
            Lead l = new Lead();
            l.ContactName = ContactName.Get(context);
            l.ContactPhone = ContactPhone.Get(context);
            l.Interests = Interests.Get(context);
            l.Comments = Notes.Get(context);
            l.WorkflowID = context.WorkflowInstanceId;
            l.Status = "Open";

            // Get the connection string
            DBExtension ext = context.GetExtension<DBExtension>();
            if (ext == null)
                throw new InvalidProgramException("No connection string available");

            // Insert a record into the Lead table
            LeadDataDataContext dc =
                new LeadDataDataContext(ext.ConnectionString);
            dc.Leads.InsertOnSubmit(l);
            dc.SubmitChanges();

            // Store the request in the OutArgument
            Lead.Set(context, l);

            // Add a custom track record
            CustomTrackingRecord userRecord = new CustomTrackingRecord("New Lead")
            {
                Data = 
                {
                    {"Name", l.ContactName},
                    {"Phone", l.ContactPhone}
                }
            };

            // Emit the custom tracking record
            context.Track(userRecord);
        }
    }
}
