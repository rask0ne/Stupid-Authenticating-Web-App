using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stupid_Authenticating_Web_App.Models
{
    public class PeopleSelectionViewModel
    {
        public List<SelectPersonEditorViewModel> People { get; set; }
        public PeopleSelectionViewModel()
        {
            this.People = new List<SelectPersonEditorViewModel>();
        }
        public IEnumerable<int> GetSelectedIds()
        {
            // Return an Enumerable containing the Id's of the selected people:
            return (from p in this.People where p.Selected select p.Id).ToList();
        }
    }
}