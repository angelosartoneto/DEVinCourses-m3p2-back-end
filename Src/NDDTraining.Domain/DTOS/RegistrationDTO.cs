﻿using System;
using NDDTraining.Domain.Models;


namespace NDDTraining.Domain.DTOS
{
    public class RegistrationDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TrainingId { get; set; }
        public string Status { get; set; }
       


        public RegistrationDTO()
        {
        }

        public RegistrationDTO(Registration registration)
        {
            Id = registration.Id;
            UserId = registration.UserId;
            TrainingId = registration.TrainingId;
            Status = registration.Status;

           
        }

       
    }
}

