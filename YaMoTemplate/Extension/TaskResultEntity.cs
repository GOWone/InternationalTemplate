using System.Data;
using System;
using System.Runtime.Serialization;

namespace YaMoTemplate.Extension
{
    [DataContract]
    [KnownType(nameof(DBNull))]
    public class TaskResultEntity
    {
        [DataMember]
        public string NameSpace { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public DataSet Data { get; set; }
        [DataMember]
        public Object Request { get; set; }

        private ExtendedProperty _properties = null;
        [DataMember]
        public ExtendedProperty Properties
        {
            get
            {
                bool flag = this._properties == null;
                if (flag)
                {
                    this._properties = new ExtendedProperty();
                }
                return this._properties;
            }
            set
            {
                this.Properties = value;
            }
        }
    }
}
