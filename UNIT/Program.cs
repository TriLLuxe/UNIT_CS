double[] array = new double [1000];
Span<double> span = array.AsSpan(100,200); //Можно Readonly
span[0] = 10;