namespace WCFDUPLEXSERVICE
{
    using System.ServiceModel;
    public interface ICalculatorDuplexCallBack
    {

        [OperationContract(IsOneWay = true)]
        void Equal(double result);

        [OperationContract(IsOneWay = true)]
        void Equation(string eqn);
    }
}