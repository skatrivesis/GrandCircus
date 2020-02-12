using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_2
{
    class Movie
    {
        #region fields
        private string movieName;
        private string category;
        #endregion

        #region properties
        public string Name { get => movieName; set => movieName = value; }
        public string Category { get => category; set => category = value; }
        #endregion

        #region constructors
        public Movie(string name, string category)
        {
            this.Name = name;
            this.Category = category;
        }
        #endregion

        #region methods
        public override string ToString()
        {
            return $"Movie Title: {movieName, -30}\tCategory: {category, -20}";
        }
        #endregion


    }
}
