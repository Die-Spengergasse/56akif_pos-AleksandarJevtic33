using Spg.PluePos._01.Test;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{
    public class SmartPhoneApp : List<Post>
    {
        public string? SmartPhoneId { get; set; } = string.Empty;

        public new void Add(Post p)
        {
            if(p != null)
            {
                base.Add(p);
                p.SmartPhone = this;
            }
        }


    public SmartPhoneApp(string? smartPhoneId)
        {
            SmartPhoneId = smartPhoneId;
        }

        public string ProcessPosts()
        {
            string? n = string.Empty;
            foreach(Post post in this)
            {
               n += post.Html;
            }
            return n;         

            
        }

        public int CalcRating()
        {
            int sum = 0;
            foreach(Post post in this)
            {
                sum += post.Rating;
            }
            return sum;
        }

      public Post this[string title]
        {
            get 
            {
               foreach (Post post in this)
                {
                    if(post.Title == title)
                    {
                        return post;
                    }

                }
                return null;
                    
            }
            
        }
        
        


       
    }
}
