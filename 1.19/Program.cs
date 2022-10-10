using _1._19_;

int[,] doubleArray = new int[3, 4]
    {
    {1, 9, 10,20},
    { 2, 4, -5, 1},
    { 8, 1,0, 0}
    };

//int minElement = ArrayProcessing.MinElementOfArray(doubleArray);
//Console.WriteLine(minElement);

//int maxElement = ArrayProcessing.MaxElementOfArray(doubleArray);
//Console.WriteLine(maxElement);

//int [] indexMinElement = ArrayProcessing.IndexOfMinElementOfArray(doubleArray);
//Console.WriteLine(indexMinElement);
//ArrayProcessing.WriteToConsoleElementsOfArray(indexMinElement);

//int[] indexMaxElement = ArrayProcessing.IndexOfMaxElementOfArray(doubleArray);
//Console.WriteLine(indexMaxElement);
//ArrayProcessing.WriteToConsoleElementsOfArray(indexMaxElement);

int countElementsThatMoreLeftAndBottomElementsSameTime = ArrayProcessing.CountElementThatMoreLeftAndBottomElementsSameTime(doubleArray);
Console.WriteLine(countElementsThatMoreLeftAndBottomElementsSameTime);