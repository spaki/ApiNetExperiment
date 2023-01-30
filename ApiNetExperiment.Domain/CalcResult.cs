namespace ApiNetExperiment.Domain
{
    public class CalcResult
    {
        public CalcResult(decimal result) => Result = result;

        public decimal Result { get; set; }
    }
}