namespace WOW
{
    public abstract class BaseMatrix : IMatrix
    {
       protected abstract IEnumerable<(int i, int j, double element)> Values{get;}
    void virtual Mult(ReadOnlySpan<double> vector, Span<double> res)
    {
        res.Fill(0);
        foreach (var p in Values) res[p.i]+=vector[p.j]*p.element;
        
    }
    public virtual void LMult(ReadOnlySpan<double> vector, Span<double> res)
    {
         res.Fill(0);
        foreach (var p in Values) 
        {
            if (p.i<p.j)    res[p.i]+=p.element*vector[p.j];
        }
    }
    void UMult(ReadOnlySpan<double> vector, Span<double> res)
    {
        res.Fill(0);
        foreach (var p in Values) 
        {
            if (p.i<p.j)    res[p.i]+=p.element*vector[p.j];
        }
    }
    void DMult(ReadOnlySpan<double> vector, Span<double> res);
    void LDInverseMult(ReadOnlySpan<double> vector, Span<double> res)
    {
        //тут не успел, да что-то еще
    }
    }
}