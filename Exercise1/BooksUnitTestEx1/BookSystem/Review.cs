using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem
{
    public class Review
    {
        #region Data Members

        private string _comment = string.Empty;
        private string _isbn = string.Empty;
        private Reviewer _reviewer;
        private RatingType _ratingType;
        #endregion

        #region Properties
        public string Comment
        {
            get => _comment;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Comment is required");
                }
                _comment = value.Trim();
            }
        }

        public string ISBN
        {
            get => _isbn;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Valid ISBN is required");
                }
                _isbn = value.Trim();
            }
        }
        public RatingType Rating
        {
            get => _ratingType;

            set
            {
                if(!Enum.IsDefined(typeof(RatingType), value))
                {
                    throw new ArgumentException($"Rating Type{value} is invalid.");
                }
                _ratingType = value;
            }
        }

        public Reviewer Reviewer
        {
          get => _reviewer;
          set
            {
                if (value == null)
                {
                    throw new ArgumentException("Reviewer is required");
                }
                _reviewer = value;
            }

        }
        #endregion

        #region Constructor
        public Review(string isbn,Reviewer reviewer,RatingType rating,string comment )
        {
         ISBN = isbn;
         Reviewer = reviewer;
         Rating = rating;
         Comment = comment;
        }

        #endregion

        #region Method
        public override string ToString() => $"{ISBN},{Reviewer},{Rating},{Comment}";
        #endregion


    }
}
