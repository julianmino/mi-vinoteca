using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DAL
{
    public class BusinessEntity
    {
        [NotMapped]
        private States _State;
        public States State
        {
            get { return _State; }
            set { _State = value; }
        }
        public BusinessEntity()
        {
            this.State = States.New;
        }
        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }
    }
}