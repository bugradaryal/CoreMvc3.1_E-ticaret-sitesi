using Microsoft.AspNetCore.Http;

namespace eticaretsitesi.Models
{
    public class GridBuilder
    {
        protected const string RouteKey = "currentroute";
        protected RouteDictionary Routes { get; set; }
        protected ISession Session { get; set; }
        public RouteDictionary CurrentRoute => this.Routes;
        public GridBuilder(ISession sess)
        {
            this.Session = sess;
            this.Routes = this.Session.GetObject<RouteDictionary>(RouteKey) ?? new RouteDictionary();
        }
        public GridBuilder(ISession sess, GridDTO values, string defaultSortField)
        {
            this.Session = sess;

            this.Routes = new RouteDictionary();
            this.Routes.PageNumber = values.PageNumber;
            this.Routes.PageSize = values.PageSize;
            this.Routes.SortField = values.SortField ?? defaultSortField;
            this.Routes.SortDirection = values.SortDirection;

            this.SaveRouteSegments();
        }
        public void SaveRouteSegments()
        {
            this.Session.SetObject(RouteKey, this.Routes);
        }
        public int GetTotalPages(int count)
        {
            var size = this.Routes.PageSize;
            return (count + size - 1) / size;
        }
    }
}