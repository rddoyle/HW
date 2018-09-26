using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCommon
{
    public class Project
    {
        public Project(string name, int id)
        {
            _name = name;
            _id = id;
        }

        private int     _customerId;

        private string  _name;
        private int     _id;

    }
}
