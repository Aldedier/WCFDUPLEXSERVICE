using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFDUPLEXSERVICE
{
    [ServiceContract(SessionMode = SessionMode.Required, 
        CallbackContract = typeof(ICalculatorDuplexCallBack))]
    public interface ICalculatorService
    {
        [OperationContract(IsOneWay = true)]
        void Clear();

        [OperationContract(IsOneWay = true)]
        void AddTo(double n);

        [OperationContract(IsOneWay = true)]
        void SubstractFrom(double n);

        [OperationContract(IsOneWay = true)]
        void MultiplyBy(double n);

        [OperationContract(IsOneWay = true)]
        void DivideBy(double n);


    }
}
