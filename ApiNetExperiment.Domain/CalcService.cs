namespace ApiNetExperiment.Domain
{
    public class CalcService
    {
        public CalcResult Sum(decimal a, decimal b) => new CalcResult(a + b);
        public CalcResult Subtract(decimal a, decimal b) => new CalcResult(a - b);
    }
}