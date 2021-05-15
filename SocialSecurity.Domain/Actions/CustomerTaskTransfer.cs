using SocialSecurity.Data.EFClasses.Tasks;
using SocialSecurity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSecurity.Domain.Actions
{
    public class CustomerTaskTransfer
    {
        public static CustomerTask GetData(PersonTask personTask) 
        {
            var customerTask = new CustomerTask();
            customerTask.ID = personTask.ID;
            customerTask.Title = personTask.Title;
            customerTask.Status = personTask.Status;
            customerTask.Summary = personTask.Summary;
            customerTask.TaskType = personTask.TaskType;
            customerTask.Priority = personTask.Priority;
            customerTask.ReferenceEntity = personTask.ReferenceEntity;
            customerTask.ReferenceNumber = personTask.ReferenceNumber;
            customerTask.ReferenceDate = personTask.ReferenceDate;
            customerTask.DateToBeCompleted = personTask.DateToBeCompleted;
            customerTask.Colour = personTask.Colour;
            customerTask.User = personTask.User;
            customerTask.UserID = personTask.UserID;

            return customerTask;
        }

        public static PersonTask PostData(CustomerCreateTask customerCreateTask)
        {
            var personTask = new PersonTask();
            personTask.Title = customerCreateTask.Title;
            personTask.Status = customerCreateTask.Status;
            personTask.Summary = customerCreateTask.Summary;
            personTask.TaskType = customerCreateTask.TaskType;
            personTask.Priority = customerCreateTask.Priority;
            personTask.ReferenceEntity = customerCreateTask.ReferenceEntity;
            personTask.ReferenceNumber = customerCreateTask.ReferenceNumber;
            personTask.ReferenceDate = customerCreateTask.ReferenceDate;
            personTask.DateToBeCompleted = customerCreateTask.DateToBeCompleted;
            personTask.Colour = customerCreateTask.Colour;

            return personTask;
        }

        public static void PutData(PersonTask personTask, CustomerTask customerTask)
        {
            personTask.Title = customerTask.Title;
            personTask.Status = customerTask.Status;
            personTask.Summary = customerTask.Summary;
            personTask.TaskType = customerTask.TaskType;
            personTask.Priority = customerTask.Priority;
            personTask.ReferenceEntity = customerTask.ReferenceEntity;
            personTask.ReferenceNumber = customerTask.ReferenceNumber;
            personTask.ReferenceDate = customerTask.ReferenceDate;
            personTask.DateToBeCompleted = customerTask.DateToBeCompleted;
            personTask.Colour = customerTask.Colour;
        }


    }
}
