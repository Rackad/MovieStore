using System.Collections.Generic;
namespace MovieStore.Models
{
    public class Movies
    {
     
        public List<Movie> list { get; set; }


        public Movies(dynamic JSON)
        {
            // initialze the variable 
            list = new List<Movie>();

            // loop throgh the dataset
            foreach (var item in JSON)
            {
                foreach (var info in item)
                {
                    // create Movie object, and append it to the list
                    var data = new Movie(info);
                    list.Add(data);
                }
            }

        }
    }
}
