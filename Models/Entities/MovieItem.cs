using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace aspnet_exam_movie.Models.Entities
{
    public class Movie
    {
        public int MovieItemID{get;set;}
        public string MovieTitle{get;set;}
        public int YearPublished{get;set;}
        public string Genre{get;set;}
        public string Director{get;set;}
        public string MovieLength{get;set;}
        public string MoviePlot{get;set;}
        public int Rating{get;set;}
    }
}