using System;
using System.Text;
using System.Collections.Generic;


namespace Model {
    
    public class Help {
        public Help()
        {
        }
        public virtual string Topic { get; set; }
        public virtual decimal Seq { get; set; }
        public virtual string Info { get; set; }
        /*       #region NHibernate Composite Key Requirements
               public override bool Equals(object obj) {
                   if (obj == null) return false;
                   var t = obj as help;
                   if (t == null) return false;
                   if (topic == t.topic
                    && seq == t.seq)
                       return true;

                   return false;
               }
               public override int GetHashCode() {
                   int hash = GetType().GetHashCode();
                   hash = (hash * 397) ^ topic.GetHashCode();
                   hash = (hash * 397) ^ seq.GetHashCode();

                   return hash;
               }
               #endregion
         * */
    }
}
