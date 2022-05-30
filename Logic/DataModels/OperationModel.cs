using Logic.HelperModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.DataModels
{
    public class OperationModel
    {
        public OperationEnum Operation { get; set; }
        public DataTypeEnum DataType { get; set; }
        public dynamic Data { get; set; }
        public dynamic oldData { get; set; }

    }
}
